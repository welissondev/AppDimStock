using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    public class StockInModel
    {
        ConnectionTransactionModel dataBaseTransaction;

        public int Id { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime RegisterHour { get; set; }
        public string NFE { get; set; }
        public SupplierModel Supplier { get; set; }
        public StockMovementModel StockMovement { get; set; }

        public StockInModel()
        {
            Supplier = new SupplierModel();
            StockMovement = new StockMovementModel();
        }

        public bool Insert()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (StockInValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO stockIn(supplierId, stockMovementId, registerDate, registerHour, nfe)
                VALUES(@supplierId, @stockMovementId, @registerDate, @registerHour, @nfe)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@supplierId", Supplier.Id);
                dataBase.AddParameter("@stockMovementId", StockMovement.Id);
                dataBase.AddParameter("@registerDate", RegisterDate);
                dataBase.AddParameter("@registerHour", RegisterHour);
                dataBase.AddParameter("@nfe", NFE);

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

            if (StockInValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE stockIn SET supplierId = @supplierId, stockMovementId = @stockMovementId,
                registerDate = @registerDate, registerHour = @registerHour, nfe = @nfe WHERE id = @id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@supplierId", Supplier.Id);
                dataBase.AddParameter("@stockMovementId", StockMovement.Id);
                dataBase.AddParameter("@registerDate", RegisterDate);
                dataBase.AddParameter("@registerHour", RegisterHour);
                dataBase.AddParameter("@nfe", NFE);
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

            if (StockInValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM stockIn WHERE id = @id";

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

        private bool InsertPosting()
        {
            return new StockModel(dataBaseTransaction).InsertPostingOfEntries(GetItems());
        }
        private bool RemovePosting()
        {
            return new StockModel(dataBaseTransaction).RemovePostingOfEntries(GetItems());
        }

        public DataTable GetItems()
        {
            return new StockInItemModel(this).ListItems();
        }

        public int GetLastId()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT MAX(id) FROM stockIn";
                Id = dataBase.ExecuteScalar(sql);
            }

            return Id;
        }
    }

}
