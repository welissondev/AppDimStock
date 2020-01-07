using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Model
{
    public class StockItemModel
    {
        #region Properties
        private readonly StockItemController StockItem;
        #endregion 

        #region Constructs
        public StockItemModel() { }

        public StockItemModel(StockItemController stockItem)
        {
            this.StockItem = stockItem;
        }
        #endregion

        #region Methods

        public bool Insert()
        {
            using (var connection = new ConnectionModel())
            {
                var sqlCommand = @"INSERT INTO StockItem(StockMovementId, ProductId, StockId, 
                Quantity, UnitaryValue, TotalValue)VALUES(@StockMovementId, @ProductId, @StockId, 
                @Quantity, @UnitaryValue, @TotalValue)";

                connection.AddParameter("@StockMovementId", OleDbType.Integer, StockItem.StockMovementId);
                connection.AddParameter("@ProductId", OleDbType.Integer, StockItem.ProductId);
                connection.AddParameter("@StockId", OleDbType.Integer, StockItem.StockId);
                connection.AddParameter("@Quantity", OleDbType.Integer, StockItem.Quantity);
                connection.AddParameter("@UnitaryValue", OleDbType.Double, StockItem.UnitaryValue);
                connection.AddParameter("@TotalValue", OleDbType.Double, StockItem.TotalValue);

                return connection.ExecuteNonQuery(sqlCommand) > 0;
            }
        }

        public bool Delete(int id)
        {
            var deleteState = false;

            using (var connection = new ConnectionModel())
            {
                var sqlCommand = @"DELETE FROM StockItem Where Id = @Id";

                connection.AddParameter("Id", OleDbType.Integer, id);

                if(connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    deleteState = true;
                }
            }

            return deleteState;
        }

        public void ListData(int id)
        {
            using (var connection = new ConnectionModel())
            {
                var sqlQuery = @"SELECT StockItem.*, Product.Description, Product.Code, [Product.Size],
                Product.Reference FROM StockItem INNER JOIN Product ON StockItem.ProductId = Product.Id WHERE 
                StockItem.StockMovementId LIKE @Id ORDER BY Code";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                var itemList = new List<StockItemController>();

                using (var dr = connection.QueryWithDataReader(sqlQuery))
                {
                    while (dr.Read())
                    {
                        var item = new StockItemController()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            StockId = Convert.ToInt32(dr["StockId"]),
                            ProductCode = dr["Code"].ToString(),
                            ProductSize = dr["Product.Size"].ToString(),
                            ProductReference = dr["Reference"].ToString(),
                            ProductDescription = dr["Description"].ToString(),
                            Quantity = Convert.ToInt32(dr["Quantity"]),
                            UnitaryValue = Convert.ToDouble(dr["UnitaryValue"]),
                            TotalValue = Convert.ToDouble(dr["TotalValue"])
                        };

                        itemList.Add(item);
                    }

                    StockItem.ListOfRecords = itemList;
                }
            }
        }

        #endregion
    }
}
