using System;
using System.Data;

namespace DimStock.Models
{
    public class StockOutModel
    {
        private ConnectionTransactionModel dataBaseTransaction;

        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime RegisterHour { get; set; }
        public DestinationModel Destination { get; set; }
        public StockMoveModel StockMove { get; set; }
        public DataTable Items { get; set; }

        public StockOutModel()
        {
            Destination = new DestinationModel();
            StockMove = new StockMoveModel();
        }
        public StockOutModel(StockMoveModel stockMove)
        {
            StockMove = stockMove;
        }

        public bool Insert()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (StockOutValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO stockOut(destinationId, stockMoveId, registerDate, registerHour)
                VALUES(@destinationId, @stockMoveId, @registerDate, @registerHour, @nfe)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@destinationId", Destination.Id);
                dataBase.AddParameter("@stockMoveId", StockMove.Id);
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
                sql = @"UPDATE stockOut SET destinationId = @destinationId, stockMoveId = @stockMoveId,
                registerDate = @registerDate, registerHour = @registerHour WHERE id = @id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@destinationId", Destination.Id);
                dataBase.AddParameter("@stockMoveId", StockMove.Id);
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

            if (StockOutValidationModel.ValidateToFinisy(this) == false)
                return actionResult;

            using (dataBaseTransaction = new ConnectionTransactionModel())
            {
                if (InsertPostingStock() == true)
                {
                    if (new StockMoveModel(dataBaseTransaction) { Id = StockMove.Id }.Finish() == true)
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

            if (StockOutValidationModel.ValidateToCancel(this) == false)
                return actionResult;

            using (dataBaseTransaction = new ConnectionTransactionModel())
            {
                if (RemovePostingStock() == true)
                {
                    if (new StockMoveModel(dataBaseTransaction) { Id = StockMove.Id }.Cancel() == true)
                    {
                        actionResult = true;
                        dataBaseTransaction.Commit();
                    }
                }
            }

            return actionResult;
        }

        public bool CheckRelationWithStockMove()
        {
            var relatedStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM stockOut WHERE 
                stockMoveId = @stockMoveId";

                dataBase.ClearParameter();
                dataBase.AddParameter("stockMoveId", StockMove.Id);

                if (dataBase.ExecuteScalar(sql) > 0)
                {
                    relatedStatus = true;
                }
            }

            return relatedStatus;

        }

        private bool InsertPostingStock()
        {
            var actionResult = false;

            Items = GetItems();

            if (StockOutValidationModel.ValidatePostingItems(this) == false)
                return actionResult;

            if (new StockModel(dataBaseTransaction).InsertPostingOfOutPuts(Items) == true)
            {
                actionResult = true;
            }

            return actionResult;
        }
        private bool RemovePostingStock()
        {
            var actionResult = false;

            Items = GetItems();

            if (StockOutValidationModel.ValidatePostingItems(this) == false)
                return actionResult;

            if (new StockModel(dataBaseTransaction).RemovePostingOfOutPuts(Items) == true)
            {
                actionResult = true;
            }

            return actionResult;
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
