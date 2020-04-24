﻿using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de items da movimentação
    /// </summary>
    public partial class MovementItemModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double UnitaryValue { get; set; }
        public double TotalValue { get; set; }
        public double SubTotal { get; set; }
        public StockModel Stock { get; set; }
        public MovementModel Movement { get; set; }
    }

    public partial class MovementItemModel
    {
        public MovementItemModel()
        {
            Stock = new StockModel();
            Movement = new MovementModel();
        }
        public MovementItemModel(MovementModel movement)
        {
            Movement = movement;
        }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (MovementItemValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO MovementItem(MovementId, ProductId, StockId, 
                Quantity, UnitaryValue, TotalValue)VALUES(@MovementId, @ProductId, @StockId, 
                @Quantity, @UnitaryValue, @TotalValue)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@MovementId", Movement.Id);
                dataBase.AddParameter("@ProductId", Stock.Product.Id);
                dataBase.AddParameter("@StockId", Stock.Id);
                dataBase.AddParameter("@Quantity", Quantity);
                dataBase.AddParameter("@UnitaryValue", UnitaryValue);
                dataBase.AddParameter("@TotalValue", TotalValue);

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

            if (MovementItemValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM MovementItem Where Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public DataTable ListItems()
        {
            var sql = string.Empty;
            var searchResult = new DataTable();

            if (MovementItemValidationModel.ValidateToListItems(this) == false)
                return searchResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT MovementItem.*, Product.Description, Product.InternalCode 
                FROM MovementItem INNER JOIN Product ON MovementItem.ProductId = Product.Id WHERE 
                MovementItem.MovementId = @MovementId ORDER BY InternalCode";

                dataBase.ClearParameter();
                dataBase.AddParameter("@MovementId", Movement.Id);

                searchResult = dataBase.ExecuteDataAdapter(sql);
            }

            return searchResult;
        }
    }
}
