﻿using DimStock.AuxilyTools.AuxilyClasses;
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
        public DataTable Items { get; set;}

        public StockInModel()
        {
            Supplier = new SupplierModel();
            StockMovement = new StockMovementModel();
        }
        public StockInModel(StockMovementModel stockMovement)
        {
            StockMovement = stockMovement;
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

            if (StockInValidationModel.ValidateToFinisy(this) == false)
                return actionResult;

            using (dataBaseTransaction = new ConnectionTransactionModel())
            {
                if (InsertPostingStock() == true)
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
                if (RemovePostingStock() == true)
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

        public bool CheckRelationWithStockMovement()
        {
            var relatedStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM stockIn WHERE 
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

        private bool InsertPostingStock()
        {
            var actionResult = false;

            Items = GetItems();

            if (StockInValidationModel.ValidatePostingItems(this) == false)
                return actionResult;

            if (new StockModel(dataBaseTransaction).InsertPostingOfEntries(Items) == true)
            {
                actionResult = true;
            }

            return actionResult;
        }
        private bool RemovePostingStock()
        {
            var actionResult = false;
            
            Items = GetItems();

            if (StockInValidationModel.ValidatePostingItems(this) == false)
                return actionResult;

            if (new StockModel(dataBaseTransaction).RemovePostingOfEntries(Items) == true)
            {
                actionResult = true;
            }

            return actionResult;
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
