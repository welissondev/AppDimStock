using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    public class StockMoveModel
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

        public StockMoveModel()
        {
        }

        public StockMoveModel(ConnectionTransactionModel connectionTransaction)
        {
            dataBaseTransaction = connectionTransaction;
        }

        public bool Start()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (StockMoveValidationModel.ValidateToStart(this) == false)
                return actionResult;

            using (dataBaseTransaction = new ConnectionTransactionModel())
            {
                sql = @"INSERT INTO stockMove(operationType)VALUES(@operationType)";

                dataBaseTransaction.ClearParameter();
                dataBaseTransaction.AddParameter("@operationType", OperationType);

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
        public bool Finish()
        {
            var actionResult = false;
            var sql = string.Empty;

            sql = @"UPDATE stockMove Set finishDate = @finishDate, 
                finishHour = @finishHour, situation = @situation
                WHERE id = @id";

            FinishDate = DateTime.Now;
            FinishHour = DateTime.Now;
            Situation = "Finalizada";

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("@finishDate", FinishDate);
            dataBaseTransaction.AddParameter("@finishHour", FinishHour);
            dataBaseTransaction.AddParameter("@situation", Situation);
            dataBaseTransaction.AddParameter("@id", Id);

            if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
            {
                actionResult = true;
            }

            return actionResult;
        }
        public bool Cancel()
        {
            var sql = string.Empty;

            sql = @"UPDATE stockMove SET situation = 
            @situation WHERE id = @id";

            Situation = "Aberta";

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("@aberta", Situation);
            dataBaseTransaction.AddParameter("@id", Id);

            return dataBaseTransaction.ExecuteNonQuery(sql) > 0;

        }

        public bool SetOperationNumber()
        {
            var seed = GetLastId();
            OperationNumber = new SingleCodeGenerator(seed).GetCode();

            var sql = @"UPDATE stockMove SET operationNumber = 
            @operationNumber WHERE id = @id";

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("@operationNumber", OperationNumber);
            dataBaseTransaction.AddParameter("@id", Id);

            return dataBaseTransaction.ExecuteNonQuery(sql) > 0;
        }

        public bool Delete()
        {
            var actionResult = false;

            if (StockMoveValidationModel.ValidateToDelete(this) == true)
                return actionResult;

            var sql = @"DELETE FROM stockMove WHERE id = @id";

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

            if (StockMoveValidationModel.ValidateToGetDetails(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM stockMove WHERE id = @id";

                dataBase.ClearParameter();
                dataBase.AddParameter("id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        Id = int.Parse(reader["id"].ToString());
                        OperationType = reader["operationType"].ToString();
                        OperationNumber = reader["operationNumber"].ToString();
                        StartDate = DateTime.Parse(reader["startDate"].ToString());
                        StartHour = DateTime.Parse(reader["startHour"].ToString());
                        FinishDate = DateTime.Parse(reader["finishDate"].ToString());
                        FinishHour = DateTime.Parse(reader["finishHour"].ToString());
                        Situation = reader["situation"].ToString();

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool CheckRegisterStatus()
        {
            var registrationStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM stockMove WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteScalar(sql) == 0)
                {
                    return registrationStatus;
                }
            }

            return registrationStatus = true;
        }

        public DataTable SearchData()
        {
            var criterionSqlSelect = string.Empty;
            var criterionSqlParameter = string.Empty;
            var criterionSqlOderBy = string.Empty;
            var Sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                criterionSqlSelect = @"SELECT * FROM stockMove
                WHERE stockMove.Id > 0 ";

                criterionSqlOderBy = @"ORDER BY id DESC";

                if (OperationType != string.Empty && OperationType != null)
                {
                    criterionSqlParameter += @"AND operationType LIKE @operationType ";
                    dataBase.AddParameter("@operationType", string.Format("{0}", OperationType));
                }

                if (OperationNumber != string.Empty && OperationNumber != null)
                {
                    criterionSqlParameter += @"AND operationNumber LIKE @operationNumber ";
                    dataBase.AddParameter("@operationNumber", string.Format("{0}", OperationNumber));
                }

                if (Situation != string.Empty && Situation != null)
                {
                    criterionSqlParameter += @"AND situation LIKE @situation ";
                    dataBase.AddParameter("@situation", string.Format("{0}", Situation));
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
                sql = @"SELECT MAX(Id) FROM stockMove";
                lastId = dataBase.ExecuteScalar(sql);
            }

            return lastId;
        }
    }
}