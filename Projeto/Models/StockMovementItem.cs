using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Models
{
    public class StockMovementItem
    {
        #region Builder

        public StockMovementItem()
        {
            Stock = new Stock();
            Product = new Product();
            StockMovement = new StockMovement();
            List = new List<StockMovementItem>();
        }

        #endregion

        #region Get e Set

        public int Id { get; set; }
        public int Quantity { get; set; }
        public double UnitaryValue { get; set; }
        public double TotalValue { get; set; }
        public double SubTotal { get; set; }
        public Stock Stock { get; set; }
        public Product Product { get; set; }
        public StockMovement StockMovement { get; set; }
        public List<StockMovementItem> List { get; set; }

        #endregion

        #region Function

        public bool Add()
        {
            using (var connection = new AccessConnection())
            {
                var sqlCommand = @"INSERT INTO StockMovementItem(StockMovementId, ProductId, StockId, 
                Quantity, UnitaryValue, TotalValue)VALUES(@StockMovementId, @ProductId, @StockId, 
                @Quantity, @UnitaryValue, @TotalValue)";

                connection.ParameterClear();
                connection.AddParameter("@StockMovementId", OleDbType.Integer, StockMovement.Id);
                connection.AddParameter("@ProductId", OleDbType.Integer, Product.Id);
                connection.AddParameter("@StockId", OleDbType.Integer, Stock.Id);
                connection.AddParameter("@Quantity", OleDbType.Integer, Quantity);
                connection.AddParameter("@UnitaryValue", OleDbType.Double, UnitaryValue);
                connection.AddParameter("@TotalValue", OleDbType.Double, TotalValue);

                return connection.ExecuteNonQuery(sqlCommand) > 0;
            }
        }

        public bool Remove(int id)
        {
            var deleteState = false;

            using (var connection = new AccessConnection())
            {
                var sqlCommand = @"DELETE FROM StockMovementItem Where Id = @Id";

                connection.AddParameter("Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    deleteState = true;
                }
            }

            return deleteState;
        }

        public void ListItems(int id)
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = @"SELECT StockMovementItem.*, Product.Description, Product.InternalCode 
                FROM StockMovementItem INNER JOIN Product ON StockMovementItem.ProductId = Product.Id WHERE 
                StockMovementItem.StockMovementId LIKE @Id ORDER BY InternalCode";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var dr = connection.QueryWithDataReader(sqlQuery))
                {
                    while (dr.Read())
                    {
                        var item = new StockMovementItem()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Quantity = Convert.ToInt32(dr["Quantity"]),
                            UnitaryValue = Convert.ToDouble(dr["UnitaryValue"]),
                            TotalValue = Convert.ToDouble(dr["TotalValue"])
                        };

                        item.Stock.Id = Convert.ToInt32(dr["StockId"]);
                        item.Product.InternalCode = dr["InternalCode"].ToString();
                        item.Product.Description = dr["Description"].ToString();

                        List.Add(item);
                    }
                }
            }
        }

        public static double CalculeSubTotal(int quantity, double unitaryValue)
        {
            return quantity * unitaryValue;
        }

        #endregion
    }
}
