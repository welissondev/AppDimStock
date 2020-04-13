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
        private TransactionModel transaction;

        public int Id { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public DateTime Hour { get; set; }
        public string Code { get; set; }
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

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                transaction.SqlQuery = @"INSERT INTO Movement([Type])VALUES(@Type)";

                transaction.ClearParameter();
                transaction.AddParameter("@Type", Type);

                if (transaction.Execute() > 0)
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

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                var postingItems = GetPostingsList();

                if (new StockModel().InsertPostingOfEntries(postingItems) == true)
                {
                    transaction.SqlQuery = @"UPDATE Movement Set Situation = 'Finalizada' WHERE Id = @Id";

                    transaction.ClearParameter();
                    transaction.AddParameter("@Id", Id);

                    if (transaction.Execute() > 0)
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
            Code = new SingleCodeGenerator(seed).GetCode();

            transaction.SqlQuery = @"UPDATE Movement SET Code = @Code WHERE Id = @Id";

            transaction.ClearParameter();
            transaction.AddParameter("@Code", Code);
            transaction.AddParameter("@Id", Id);

            return transaction.Execute() > 0;
        }

        public bool SetDestinationId()
        {
            var actionResult = false;

            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = @"UPDATE Movement SET DestinationId = @DestinationId WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@DestinationId", Destination.Id);
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteNonQuery() > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                if (CancelPostings() == true)
                {
                    transaction.SqlQuery = @"DELETE FROM Movement WHERE Id = @Id";

                    transaction.ClearParameter();
                    transaction.AddParameter("Id", Id);

                    if (transaction.Execute() > 0)
                    {
                        actionResult = true;

                        MessageNotifier.Message = "Movimentação excluida com sucesso!";
                        MessageNotifier.Title = "Sucesso";
                    }
                }
            }

            return actionResult;
        }

        public bool GetDetail()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = @"SELECT Movement.*, Destination.* FROM Movement LEFT JOIN 
                Destination ON Movement.DestinationId = Destination.Id WHERE 
                Movement.Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("Id", Id);

                using (var reader = dataBase.GetReader())
                {
                    if (reader.FieldCount > 0)
                    {
                        while (reader.Read())
                        {
                            Id = int.Parse(reader["Movement.Id"].ToString());
                            Type = reader["[Type]"].ToString();
                            Date = DateTime.Parse(reader["[Date]"].ToString());
                            Hour = DateTime.Parse(reader["[Hour]"].ToString());
                            Situation = reader["[Situation]"].ToString();
                            Code = reader["[Code]"].ToString();

                            if (reader["Destination.Id"] != DBNull.Value)
                                Destination.Id = int.Parse(reader["Destination.Id"].ToString());

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
            var sqlLink = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = @"SELECT Movement.*, Destination.* FROM Movement
                LEFT JOIN Destination On Movement.DestinationId = 
                Destination.Id WHERE Movement.Id > 0 ";

                if (Type != string.Empty)
                {
                    sqlLink += @" AND [Type] LIKE @Type";

                    dataBase.AddParameter("@Type", string.Format("{0}", Type));
                }

                if (Situation != string.Empty)
                {
                    sqlLink += @" AND Situation LIKE @Situation";

                    dataBase.AddParameter("@Situation", string.Format("{0}", Situation));
                }

                if (Code != string.Empty)
                {
                    sqlLink += @" AND Movement.Code LIKE @Code ";

                    dataBase.AddParameter("@Code", string.Format("{0}", Code));
                }

                dataBase.SqlQuery += sqlLink + @" ORDER BY Movement.Id DESC";

                return dataBase.GetTable();
            }
        }

        public DataTable GetPostingsList()
        {
            return new MovementItemModel(this).ListItems();
        }

        public bool CancelPostings()
        {
            var actionResult = false;

            var postedItems = GetPostingsList();

            switch (Type)
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

        public int GetLastId()
        {
            transaction.SqlQuery = @"SELECT MAX(Id) FROM Movement";
            return transaction.Scalar();
        }
    }
}