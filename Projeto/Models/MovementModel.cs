using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de movimentação do estoque
    /// </summary>
    public partial class MovementModel
    {
        private ConnectionTransactionModel transaction;

        public int Id { get; set; }
        public string OperationType { get; set; }
        public string OperationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime FinishHour { get; set; }
        public string Situation { get; set; }
        public DestinationModel Destination { get; set; }
    }

    public partial class MovementModel
    {
        public MovementModel()
        {
            Destination = new DestinationModel();
        }

        public bool StartOperation()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (transaction = new ConnectionTransactionModel())
            {
                sql = @"INSERT INTO Movement(OperationType)VALUES(@OperationType)";

                transaction.ClearParameter();
                transaction.AddParameter("@OperationType", OperationType);

                if (transaction.ExecuteNonQuery(sql) > 0)
                {
                    if (SetOperationNumber() == true)
                    {
                        transaction.Commit();
                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }
        public bool FinishOperation()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (transaction = new ConnectionTransactionModel())
            {
                if (InsertStockPostings() == true)
                {
                    sql = @"UPDATE Movement Set FinishDate = @FinishDate, 
                    FinishHour = @FinishHour, Situation = @Situation
                    WHERE Id = @Id";

                    FinishDate = DateTime.Now;
                    FinishHour = DateTime.Now;
                    Situation = "Finalizada";

                    transaction.ClearParameter();
                    transaction.AddParameter("@FinishDate", FinishDate);
                    transaction.AddParameter("@FinishHour", FinishHour);
                    transaction.AddParameter("@Situation", Situation);
                    transaction.AddParameter("@Id", Id);

                    if (transaction.ExecuteNonQuery(sql) > 0)
                    {
                        transaction.Commit();

                        MessageNotifier.Show("Movimentação registrada " +
                        "com sucesso!", "Sucesso");

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool SetOperationNumber()
        {
            var seed = GetLastId();
            OperationNumber = new SingleCodeGenerator(seed).GetCode();

            var sql = @"UPDATE Movement SET OperationNumber = 
            @OperationNumber WHERE Id = @Id";

            transaction.ClearParameter();
            transaction.AddParameter("@OperationNumber", OperationNumber);
            transaction.AddParameter("@Id", Id);

            return transaction.ExecuteNonQuery(sql) > 0;
        }

        public bool SetDestinationId()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE Movement SET DestinationId = 
                @DestinationId WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@DestinationId", Destination.Id);
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool InsertStockPostings()
        {
            var actionResult = false;
            var postedItems = GetPostedItems();

            switch (OperationType)
            {
                case "Entry":
                    actionResult = new StockModel(transaction).InsertPostingOfEntries(postedItems);
                    break;

                case "OutPut":
                    actionResult = new StockModel(transaction).InsertPostingOfOutPuts(postedItems);
                    break;
            }

            return actionResult;
        }
        public bool CancelStockPostings()
        {
            var actionResult = false;
            var postedItems = GetPostedItems();

            switch (OperationType)
            {
                case "Entry":
                    actionResult = new StockModel(transaction).CancelPostingOfEntries(postedItems);
                    break;

                case "OutPut":
                    actionResult = new StockModel(transaction).CancelPostingOfOutPuts(postedItems);
                    break;
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (transaction = new ConnectionTransactionModel())
            {
                if (CancelStockPostings() == true)
                {
                    sql = @"DELETE FROM Movement WHERE Id = @Id";

                    transaction.ClearParameter();
                    transaction.AddParameter("Id", Id);

                    if (transaction.ExecuteNonQuery(sql) > 0)
                    {
                        transaction.Commit();

                        MessageNotifier.Show("Movimentação excluida " +
                        "com sucesso!", "Sucesso");

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool GetDetails()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Movement.*, Destination.* FROM Movement LEFT JOIN 
                Destination ON Movement.DestinationId = Destination.Id WHERE 
                Movement.Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.FieldCount > 0)
                    {
                        while (reader.Read())
                        {
                            Id = int.Parse(reader["Movement.Id"].ToString());
                            OperationType = reader["OperationType"].ToString();
                            OperationNumber = reader["OperationNumber"].ToString();
                            StartDate = DateTime.Parse(reader["StartDate"].ToString());
                            StartHour = DateTime.Parse(reader["StartHour"].ToString());
                            FinishDate = DateTime.Parse(reader["FinishDate"].ToString());
                            FinishHour = DateTime.Parse(reader["FinishHour"].ToString());
                            Situation = reader["Situation"].ToString();

                            if (reader["Destination.Id"] != DBNull.Value)
                                Destination.Id = int.Parse(reader["Destination.Id"].ToString());

                            if (reader["Destination.Location"] != DBNull.Value)
                                Destination.Location = reader["Location"].ToString();
                        }

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public DataTable FetchData()
        {
            var criterionSqlSelect = string.Empty;
            var criterionSqlParameter = string.Empty;
            var criterionSqlOderBy = string.Empty;
            var Sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                criterionSqlSelect = @"SELECT Movement.*, Destination.* FROM Movement
                LEFT JOIN Destination On Movement.DestinationId = Destination.Id 
                WHERE Movement.Id > 0 ";

                criterionSqlOderBy = @"ORDER BY Movement.Id DESC";

                if (OperationType != string.Empty && OperationType != null)
                {
                    criterionSqlParameter += @"AND OperationType LIKE @OperationType ";
                    dataBase.AddParameter("@OperationType", string.Format("{0}", OperationType));
                }

                if (OperationNumber != string.Empty && OperationNumber != null)
                {
                    criterionSqlParameter += @"AND OperationNumber LIKE @OperationNumber ";
                    dataBase.AddParameter("@OperationNumber", string.Format("{0}", OperationNumber));
                }

                if (Situation != string.Empty && Situation != null)
                {
                    criterionSqlParameter += @"AND Sitation LIKE @Sitation ";
                    dataBase.AddParameter("@Sitation", string.Format("{0}", Situation));
                }

                Sql += criterionSqlSelect + criterionSqlParameter + criterionSqlOderBy;

                return dataBase.ExecuteDataAdapter(Sql);
            }
        }

        public DataTable GetPostedItems()
        {
            return new MovementItemModel(this).ListItems();
        }

        public int GetLastId()
        {
            var sql = string.Empty;
            int lastId;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT MAX(Id) FROM Movement";
                lastId = dataBase.ExecuteScalar(sql);
            }

            return lastId;
        }
    }
}