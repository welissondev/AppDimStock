using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    public class StockMoveModel
    {
        private ConnectionTransactionModel dataBaseTransaction;

        public int Id { get; set; }
        public string IndentificationNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime FinishDate { get; set; }
        public DateTime FinishHour { get; set; }
        public string Situation { get; set; }
        public StockMoveTypeModel MoveType { get; set; }

        public StockMoveModel()
        {
            MoveType = new StockMoveTypeModel();
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
                sql = @"INSERT INTO stockMove(stockMoveTypeId, startDate, startHour,
                situation)VALUES(@stockMoveTypeId, @startDate, @startHour, @situation)";

                dataBaseTransaction.ClearParameter();
                dataBaseTransaction.AddParameter("@stockMoveTypeId", MoveType.Id);
                dataBaseTransaction.AddParameter("@startDate", DateTime.Now.ToString("'dd'/'MM'/'yyyy'"));
                dataBaseTransaction.AddParameter("@startHor", DateTime.Now.ToString("'HH':'mm':'ss"));
                dataBaseTransaction.AddParameter("@situation", Situation);

                if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
                {
                    if (SetIndentificationNumber() == true)
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

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("@finishDate", DateTime.Now.ToString("'dd'/'MM'/'yyyy'"));
            dataBaseTransaction.AddParameter("@finishHour", DateTime.Now.ToString("'HH':'mm':'ss"));
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

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("@situation", Situation);
            dataBaseTransaction.AddParameter("@id", Id);

            return dataBaseTransaction.ExecuteNonQuery(sql) > 0;

        }

        private bool SetIndentificationNumber()
        {
            var seed = GetLastId();
            IndentificationNumber = new SingleCodeGenerator(seed).GetCode();

            var sql = @"UPDATE stockMove SET indentificationNumber = 
            @indentificationNumber WHERE id = @id";

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("@indentificationNumber", IndentificationNumber);
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
                        MoveType.Id = int.Parse(reader["operationTypeId"].ToString());
                        IndentificationNumber = reader["operationNumber"].ToString();
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
                criterionSqlSelect = @"SELECT stockMove.*, operationType.description FROM stockMove
                INNER JOIN operationType ON stockMove.operationTypeId = operationType.id WHERE 
                stockMove.Id > 0 ";

                criterionSqlOderBy = @"ORDER BY id DESC";

                if (MoveType.Description != string.Empty && MoveType.Description != null)
                {
                    criterionSqlParameter += @"AND operationType.description LIKE @operationType.description ";
                    dataBase.AddParameter("@operationType.description", string.Format("{0}", MoveType));
                }

                if (IndentificationNumber != string.Empty && IndentificationNumber != null)
                {
                    criterionSqlParameter += @"AND indentificationNumber LIKE @indentificationNumber ";
                    dataBase.AddParameter("@indentificationNumber", string.Format("{0}", IndentificationNumber));
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