using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Models
{
    public class StockMovementItem
    {
        #region Builder

        public StockMovementItem()
        {
            Stock = new StockModel();
            Product = new ProductModel();
            StockMovement = new StockMovementModel();
            List = new List<StockMovementItem>();
        }

        #endregion

        #region Get e Set

        public int Id { get; set; }
        public int Quantity { get; set; }
        public double UnitaryValue { get; set; }
        public double TotalValue { get; set; }
        public double SubTotal { get; set; }
        public StockModel Stock { get; set; }
        public ProductModel Product { get; set; }
        public StockMovementModel StockMovement { get; set; }
        public List<StockMovementItem> List { get; set; }

        #endregion

        #region Function

        public bool Add()
        {
            using (var connection = new ConnectionModel())
            {
                var sqlCommand = @"INSERT INTO StockMovementItem(StockMovementId, ProductId, StockId, 
                Quantity, UnitaryValue, TotalValue)VALUES(@StockMovementId, @ProductId, @StockId, 
                @Quantity, @UnitaryValue, @TotalValue)";

                connection.ClearParameter();
                connection.AddParameter("@StockMovementId", StockMovement.Id);
                connection.AddParameter("@ProductId", Product.Id);
                connection.AddParameter("@StockId", Stock.Id);
                connection.AddParameter("@Quantity", Quantity);
                connection.AddParameter("@UnitaryValue", UnitaryValue);
                connection.AddParameter("@TotalValue", TotalValue);

                return connection.ExecuteCommand(sqlCommand) > 0;
            }
        }

        public bool Remove(int id)
        {
            var deleteState = false;

            using (var connection = new ConnectionModel())
            {
                var sqlCommand = @"DELETE FROM StockMovementItem Where Id = @Id";

                connection.AddParameter("Id", id);

                if (connection.ExecuteCommand(sqlCommand) > 0)
                {
                    deleteState = true;
                }
            }

            return deleteState;
        }

        public DataTable ListItems()
        {
            using (var db = new ConnectionModel())
            {
                var sql = @"SELECT StockMovementItem.*, Product.Description, Product.InternalCode 
                FROM StockMovementItem INNER JOIN Product ON StockMovementItem.ProductId = Product.Id WHERE 
                StockMovementItem.StockMovementId LIKE @StockMovementId ORDER BY InternalCode";

                db.ClearParameter();
                db.AddParameter("@StockMovementId", StockMovement.Id);

                return db.GetTable(sql);
            }
        }

        public static double CalculeSubTotal(int quantity, double unitaryValue)
        {
            return quantity * unitaryValue;
        }

        #endregion
    }
}
