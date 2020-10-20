using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    public class StockMoveModel
    {
        private ConnectionTransactionModel dataBaseTransaction;
        private DateTime startDate;
        private DateTime startHour;
        private DateTime finishDate;
        private DateTime finishHour;

        public int Id { get; set; }
        public DateTime StartDate { get => startDate; }
        public DateTime StartHour { get => startHour; }
        public DateTime FinishDate { get => finishDate; }
        public DateTime FinishHour { get => finishHour; }
        public string Situation { get; set; }
        public StockMoveTypeModel StockMoveType { get; set; }

        public StockMoveModel()
        {
            StockMoveType = new StockMoveTypeModel();
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

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO stockMove(stockMoveTypeId)
                VALUES(@stockMoveTypeId)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockMoveTypeId", StockMoveType.GetIdByDescription());

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    if (GetLastId() > 0)
                    {
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
                        StockMoveType.Id = int.Parse(reader["operationTypeId"].ToString());
                        Situation = reader["situation"].ToString();
                        startDate = DateTime.Parse(reader["startDate"].ToString());
                        startHour = DateTime.Parse(reader["startHour"].ToString());
                        finishDate = DateTime.Parse(reader["finishDate"].ToString());
                        finishHour = DateTime.Parse(reader["finishHour"].ToString());

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

                if (StockMoveType.Description != string.Empty && StockMoveType.Description != null)
                {
                    criterionSqlParameter += @"AND operationType.description LIKE @operationType.description ";
                    dataBase.AddParameter("@operationType.description", string.Format("{0}", StockMoveType));
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

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT MAX(Id) FROM stockMove";
                Id = dataBase.ExecuteScalar(sql);
            }

            return Id;
        }
    }
}