using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

/// <summary>
/// Propriedades da classe
/// </summary>
namespace DimStock.Models
{
    public partial class StockMovementModel
    {
        private TransactionModel transaction;

        public int Id { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public DateTime OperationHour { get; set; }
        public string OperationCode { get; set; }
        public string OperationSituation { get; set; }
        public StockDestinationModel Destination { get; set; }
    }
}

/// <summary>
/// Métodos da classe
/// </summary>
namespace DimStock.Models
{
    public partial class StockMovementModel
    {
        public StockMovementModel()
        {
            Destination = new StockDestinationModel();
        }

        public bool StartOperation()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                sql = @"INSERT INTO StockMovement(OperationType)
                VALUES(@OperationType)";

                transaction.DataBase.ClearParameter();
                transaction.DataBase.AddParameter("@OperationType", OperationType);

                if (transaction.DataBase.ExecuteTransaction(sql) > 0)
                {
                    if (SetOperationCode() == true)
                    {
                        transaction.Commit();
                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool CloseOperation()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                var postingItems = GetItems();

                var stock = new StockModel();
                if (stock.InsertPostingOfEntries(postingItems) == true)
                {
                    sql = @"UPDATE StockMovement Set OperationSituation = 
                    'Finalizada' WHERE Id = @Id";

                    transaction.DataBase.ClearParameter();
                    transaction.DataBase.AddParameter("@Id", Id);

                    if (transaction.DataBase.ExecuteTransaction(sql) > 0)
                    {
                        transaction.Commit();
                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool SetOperationCode()
        {
            var seed = GetLastId();
            OperationCode = new SingleCodeGenerator(seed).GetCode();

            var sql = @"UPDATE StockMovement SET OperationCode = 
            @OperationCode WHERE Id = @Id";

            transaction.DataBase.ClearParameter();
            transaction.DataBase.AddParameter("@OperationCode", OperationCode);
            transaction.DataBase.AddParameter("@Id", Id);

            return transaction.DataBase.ExecuteTransaction(sql) > 0;
        }

        public bool RelateDestination()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var db = new ConnectionModel())
            {
                sql = @"UPDATE StockMovement SET 
                StockDestinationId = @StockDestinationId WHERE Id = @Id";

                db.ClearParameter();
                db.AddParameter("@StockDestinationId", Destination.Id);
                db.AddParameter("@Id", Id);

                if (db.ExecuteCommand(sql) > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                if (CancelPostings() == true)
                {
                    sql = @"DELETE FROM StockMovement WHERE Id = @Id";

                    transaction.DataBase.ClearParameter();
                    transaction.DataBase.AddParameter("Id", Id);

                    if (transaction.DataBase.ExecuteTransaction(sql) > 0)
                    {
                        actionResult = true;

                        MessageNotifier.Message = "Movimentação excluida com sucesso!";
                        MessageNotifier.Title = "Sucesso";
                    }
                }
            }

            return actionResult;
        }

        public DataTable FetchData()
        {
            using (var db = new ConnectionModel())
            {
                var sql = string.Empty;
                var sqlLink = string.Empty;

                sql = @"SELECT StockMovement.*, StockDestination.* FROM StockMovement
                LEFT JOIN StockDestination On StockMovement.StockDestinationId = 
                StockDestination.Id WHERE StockMovement.Id > 0 ";

                if (OperationType != string.Empty)
                {
                    sqlLink += @" AND OperationType LIKE @OperationType";

                    db.AddParameter("@OperationType", string.Format("{0}",
                    OperationType));
                }

                if (OperationSituation != string.Empty)
                {
                    sqlLink += @" AND OperationSituation LIKE @OperationSituation";

                    db.AddParameter("@OperationSituation", string.Format("{0}",
                    OperationSituation));
                }

                if (OperationCode != string.Empty)
                {
                    sqlLink += @" AND StockMovement.OperationCode LIKE @OperationCode ";

                    db.AddParameter("@OperationCode", string.Format("{0}",
                    OperationCode));
                }

                sql += sqlLink + @" ORDER BY StockMovement.Id DESC";

                return db.GetTable(sql);
            }
        }

        public bool GetDetail()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var db = new ConnectionModel())
            {
                sql = @"SELECT StockMovement.*, StockDestination.* FROM StockMovement LEFT JOIN 
                StockDestination ON StockMovement.StockDestinationId = StockDestination.Id WHERE 
                StockMovement.Id = @Id";

                db.ClearParameter();
                db.AddParameter("Id", Id);

                using (var reader = db.GetReader(sql))
                {
                    if (reader.FieldCount > 0)
                    {
                        while (reader.Read())
                        {
                            Id = int.Parse(reader["StockMovement.Id"].ToString());
                            OperationType = reader["OperationType"].ToString();
                            OperationDate = DateTime.Parse(reader["OperationDate"].ToString());
                            OperationHour = DateTime.Parse(reader["OperationHour"].ToString());
                            OperationSituation = reader["OperationSituation"].ToString();
                            OperationCode = reader["OperationCode"].ToString();

                            if (reader["StockDestination.Id"] != DBNull.Value)
                                Destination.Id = int.Parse(reader["StockDestination.Id"].ToString());

                            Destination.Location = reader["Location"].ToString();
                        }

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        private int GetLastId()
        {
            var sql = @"SELECT MAX(Id) FROM StockMovement";
            return transaction.DataBase.ExecuteScalar(sql);
        }

        private DataTable GetItems()
        {
            var item = new StockMovementItem();
            item.StockMovement.Id = Id;

            return item.ListItems();
        }

        private bool CancelPostings()
        {
            var actionResult = false;

            var postedItems = GetItems();

            var stock = new StockModel(transaction);
            switch (OperationType)
            {
                case "Entry":
                    actionResult = stock.CancelPostingOfEntries(postedItems);
                    break;

                case "OutPut":
                    actionResult = stock.CancelPostingOfOutPuts(postedItems);
                    break;
            }

            return actionResult;
        }
    }
}
