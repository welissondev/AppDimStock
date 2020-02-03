using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Business
{
    public class StockItem
    {
        #region Get e Set
        public int Id { get; set; }
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int StockMovementId { get; set; }
        public string ProductCode { get; set; }
        public string ProductSize { get; set; }
        public string ProductReference { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public double UnitaryValue { get; set; }
        public double TotalValue { get; set; }
        public double SubTotal { get; set; }
        public List<StockItem> ListOfRecords { get; set; }
        #endregion

        #region Methods

        public bool Add()
        {
            using (var connection = new Connection())
            {
                var sqlCommand = @"INSERT INTO StockItem(StockMovementId, ProductId, StockId, 
                Quantity, UnitaryValue, TotalValue)VALUES(@StockMovementId, @ProductId, @StockId, 
                @Quantity, @UnitaryValue, @TotalValue)";

                connection.AddParameter("@StockMovementId", OleDbType.Integer, StockMovementId);
                connection.AddParameter("@ProductId", OleDbType.Integer, ProductId);
                connection.AddParameter("@StockId", OleDbType.Integer, StockId);
                connection.AddParameter("@Quantity", OleDbType.Integer, Quantity);
                connection.AddParameter("@UnitaryValue", OleDbType.Double, UnitaryValue);
                connection.AddParameter("@TotalValue", OleDbType.Double, TotalValue);

                return connection.ExecuteNonQuery(sqlCommand) > 0;
            }
        }

        public bool Remove(int id)
        {
            var deleteState = false;

            using (var connection = new Connection())
            {
                var sqlCommand = @"DELETE FROM StockItem Where Id = @Id";

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
            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT StockItem.*, Product.Description, Product.Code, [Product.Size],
                Product.Reference FROM StockItem INNER JOIN Product ON StockItem.ProductId = Product.Id WHERE 
                StockItem.StockMovementId LIKE @Id ORDER BY Code";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                var itemList = new List<StockItem>();

                using (var dr = connection.QueryWithDataReader(sqlQuery))
                {
                    while (dr.Read())
                    {
                        var item = new StockItem()
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

                    ListOfRecords = itemList;
                }
            }
        }

        #endregion
    }
}
