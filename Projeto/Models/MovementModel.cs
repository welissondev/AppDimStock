using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    public partial class MovementModel
    {
        private ConnectionTransactionModel dataBaseTransaction;

        public int Id { get; set; }
        public string OperationType { get; set; }
        public string OperationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime FinishHour { get; set; }
        public string Situation { get; set; }
    }

    public partial class MovementModel
    {
        public MovementModel()
        {
        }

        public MovementModel(ConnectionTransactionModel connectionTransaction)
        {
            dataBaseTransaction = connectionTransaction;
        }

        public bool StartOperation()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (MovementValidationModel.ValidateToStartOperation(this) == false)
                return actionResult;

            using (dataBaseTransaction = new ConnectionTransactionModel())
            {
                sql = @"INSERT INTO Movement(OperationType)VALUES(@OperationType)";

                dataBaseTransaction.ClearParameter();
                dataBaseTransaction.AddParameter("@OperationType", OperationType);

                if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
                {
                    if (SetOperationNumber() == true)
                    {
                        dataBaseTransaction.Commit();
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

            sql = @"UPDATE Movement Set FinishDate = @FinishDate, 
                FinishHour = @FinishHour, Situation = @Situation
                WHERE Id = @Id";

            FinishDate = DateTime.Now;
            FinishHour = DateTime.Now;
            Situation = "Finalizada";

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("@FinishDate", FinishDate);
            dataBaseTransaction.AddParameter("@FinishHour", FinishHour);
            dataBaseTransaction.AddParameter("@Situation", Situation);
            dataBaseTransaction.AddParameter("@Id", Id);

            if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
            {
                actionResult = true;
            }

            return actionResult;
        }

        public bool SetOperationNumber()
        {
            var seed = GetLastId();
            OperationNumber = new SingleCodeGenerator(seed).GetCode();

            var sql = @"UPDATE Movement SET OperationNumber = 
            @OperationNumber WHERE Id = @Id";

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("@OperationNumber", OperationNumber);
            dataBaseTransaction.AddParameter("@Id", Id);

            return dataBaseTransaction.ExecuteNonQuery(sql) > 0;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            sql = @"DELETE FROM movement WHERE Id = @Id";

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("Id", Id);

            if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
            {
                actionResult = true;
            }

            return actionResult;
        }

        public bool GetDetails()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (MovementValidationModel.ValidateToGetDetails(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM Movement LEFT JOIN 
                Destination ON Movement.DestinationId = Destination.Id WHERE 
                Movement.Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
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

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool CheckIfRegister()
        {
            var registrationStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM Movement WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteScalar(sql) == 0)
                {
                    return registrationStatus;
                }
            }

            return registrationStatus = true;
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