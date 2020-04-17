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

            using (transaction = new TransactionModel())
            {
                sql = @"INSERT INTO Movement(OperationType)VALUES(@OperationType)";

                ParameterModel.Clear();
                ParameterModel.Add("@OperationType", OperationType);

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

            using (transaction = new TransactionModel())
            {
                if (InsertStockPostings() == true)
                {
                    sql = @"UPDATE Movement Set FinishDate = @FinishDate, 
                    FinishHour = @FinishHour, Situation = @Situation
                    WHERE Id = @Id";

                    FinishDate = DateTime.Now;
                    FinishHour = DateTime.Now;
                    Situation = "Finalizada";

                    ParameterModel.Clear();
                    ParameterModel.Add("@FinishDate", FinishDate);
                    ParameterModel.Add("@FinishHour", FinishHour);
                    ParameterModel.Add("@Situation", Situation);
                    ParameterModel.Add("@Id", Id);

                    if (transaction.ExecuteNonQuery(sql) > 0)
                    {
                        transaction.Commit();

                        MessageNotifier.Set("Movimentação registrada " +
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

            ParameterModel.Clear();
            ParameterModel.Add("@OperationNumber", OperationNumber);
            ParameterModel.Add("@Id", Id);

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

                ParameterModel.Clear();
                ParameterModel.Add("@DestinationId", Destination.Id);
                ParameterModel.Add("@Id", Id);

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

            using (transaction = new TransactionModel())
            {
                if (CancelStockPostings() == true)
                {
                    sql = @"DELETE FROM Movement WHERE Id = @Id";

                    ParameterModel.Clear();
                    ParameterModel.Add("Id", Id);

                    if (transaction.ExecuteNonQuery(sql) > 0)
                    {
                        transaction.Commit();

                        MessageNotifier.Set("Movimentação excluida " +
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

                ParameterModel.Clear();
                ParameterModel.Add("Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.FieldCount > 0)
                    {
                        while (reader.Read())
                        {
                            Id = int.Parse(reader["Movement.Id"].ToString());
                            OperationType = reader["OperationType"].ToString();
                            OperationNumber = reader["OprationNumber"].ToString();
                            StartDate = DateTime.Parse(reader["StartDate"].ToString());
                            StartHour = DateTime.Parse(reader["StartHour"].ToString());
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
            var criterionSql = string.Empty;
            var criterionSqlParameter = string.Empty;
            var criterionSqlOderBy = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                criterionSql = @"SELECT Movement.*, Destination.* FROM Movement
                LEFT JOIN Destination On Movement.DestinationId = Destination.Id 
                WHERE Movement.Id > 0 ";

                criterionSqlOderBy = @"ORDER BY Movement.Id DESC";

                ParameterModel.Clear();

                if (OperationType != string.Empty && OperationType != null)
                {
                    criterionSqlParameter += @" AND OperationType LIKE @OperationType";
                    ParameterModel.Add("@OperationType", string.Format("{0}", OperationType));
                }

                if (OperationNumber != string.Empty && OperationNumber != null)
                {
                    criterionSqlParameter += @" AND OperationNumber LIKE @OperationNumber";
                    ParameterModel.Add("@OperationNumber", string.Format("{0}", OperationNumber));
                }

                if (Situation != string.Empty && Situation != null)
                {
                    criterionSqlParameter += @" AND Sitation LIKE @Sitation";
                    ParameterModel.Add("@Sitation", string.Format("{0}", Situation));
                }

                criterionSql += criterionSqlParameter + criterionSqlOderBy;

                return dataBase.ExecuteDataAdapter(criterionSql);
            }
        }

        public DataTable GetPostedItems()
        {
            return new MovementItemModel(this).ListItems();
        }

        public int GetLastId()
        {
            var sql = @"SELECT MAX(Id) FROM Movement";
            return transaction.ExecuteScalar(sql);
        }
    }
}