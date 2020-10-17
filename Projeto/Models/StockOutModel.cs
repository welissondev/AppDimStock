using System;
using System.Data;

namespace DimStock.Models
{
    public class StockOutModel
    {
        ConnectionTransactionModel dataBaseTransaction;

        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime RegisterHour { get; set; }
        public DestinationModel Destination { get; set; }
        public StockMovementModel StockMovement { get; set; }

        public StockOutModel()
        {
            Destination = new DestinationModel();
            StockMovement = new StockMovementModel();
        }
        public StockOutModel(StockMovementModel stockMovement)
        {
            StockMovement = stockMovement;
        }

        public bool Insert()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (StockOutValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO stockOut(destinationId, stockMovementId, registerDate, registerHour)
                VALUES(@destinationId, @stockMovementId, @registerDate, @registerHour, @nfe)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@destinationId", Destination.Id);
                dataBase.AddParameter("@stockMovementId", StockMovement.Id);
                dataBase.AddParameter("@registerDate", RegisterDate);
                dataBase.AddParameter("@registerHour", RegisterHour);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }
        public bool Update()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (StockOutValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE stockOut SET destinationId = @destinationId, stockMovementId = @stockMovementId,
                registerDate = @registerDate, registerHour = @registerHour WHERE id = @id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@destinationId", Destination.Id);
                dataBase.AddParameter("@stockMovementId", StockMovement.Id);
                dataBase.AddParameter("@registerDate", RegisterDate);
                dataBase.AddParameter("@registerHour", RegisterHour);
                dataBase.AddParameter("@id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
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

            if (StockOutValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM stockOut WHERE id = @id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@id", Id);

                actionResult = dataBase.ExecuteNonQuery(sql) > 0;
            }

            return actionResult;
        }

        public bool Finish()
        {
            var actionResult = false;

            using (dataBaseTransaction = new ConnectionTransactionModel())
            {
                if (InsertPosting() == true)
                {
                    if (new StockMovementModel(dataBaseTransaction) { Id = StockMovement.Id }.Finish() == true)
                    {
                        actionResult = true;
                        dataBaseTransaction.Commit();
                    }
                }
            }

            return actionResult;
        }
        public bool Cancel()
        {
            var actionResult = false;

            using (dataBaseTransaction = new ConnectionTransactionModel())
            {
                if (RemovePosting() == true)
                {
                    if (new StockMovementModel(dataBaseTransaction) { Id = StockMovement.Id }.Cancel() == true)
                    {
                        actionResult = true;
                        dataBaseTransaction.Commit();
                    }
                }
            }

            return actionResult;
        }

        public bool CheckRelatedWithStockMovement()
        {
            var relatedStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM stockOut WHERE 
                stockMovementId = @stockMovementId";

                dataBase.ClearParameter();
                dataBase.AddParameter("stockMovementId", StockMovement.Id);

                if (dataBase.ExecuteScalar(sql) > 0)
                {
                    relatedStatus = true;
                }
            }

            return relatedStatus;

        }

        private bool InsertPosting()
        {
            return new StockModel(dataBaseTransaction).InsertPostingOfOutPuts(GetItems());
        }
        private bool RemovePosting()
        {
            return new StockModel(dataBaseTransaction).RemovePostingOfOutPuts(GetItems());
        }

        public DataTable GetItems()
        {
            return new StockOutItemModel(this).ListItems();
        }

        public int GetLastId()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT MAX(id) FROM stockOut";
                Id = dataBase.ExecuteScalar(sql);
            }

            return Id;
        }
    }
}
