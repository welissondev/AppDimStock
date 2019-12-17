using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Model
{
    public class MdlStockItem
    {
        #region Properties
        private readonly BllStockItem item;
        #endregion 

        #region Constructs
        public MdlStockItem() { }

        public MdlStockItem(BllStockItem stockItem)
        {
            this.item = stockItem;
        }
        #endregion

        #region Add()
        public void Add()
        {
            using (var connection = new MdlConnection())
            {
                var sqlCommand = @"INSERT INTO StockItem(StockActivityId, ProductId, StockId, 
                Quantity, UnitaryValue, TotalValue)VALUES(@StockActivityId, @ProductId, @StockId, 
                @Quantity, @UnitaryValue, @TotalValue)";

                connection.AddParameter("@StockActivityId", OleDbType.Integer, item.StockActivityId);
                connection.AddParameter("@ProductId", OleDbType.Integer, item.ProductId);
                connection.AddParameter("@StockId", OleDbType.Integer, item.StockId);
                connection.AddParameter("@Quantity", OleDbType.Integer, item.Quantity);
                connection.AddParameter("@UnitaryValue", OleDbType.Double, item.UnitaryValue);
                connection.AddParameter("@TotalValue", OleDbType.Double, item.TotalValue);

                connection.ExecuteNonQuery(sqlCommand);
            }
        }
        #endregion

        #region ListItem()
        public List<BllStockItem> ListItem(int id)
        {
            using (var connection = new MdlConnection())
            {
                var sqlQuery = @"SELECT StockItem.*, Product.Description, Product.Code, [Product.Size],
                Product.Reference FROM StockItem INNER JOIN Product ON StockItem.ProductId = Product.Id WHERE 
                StockItem.StockActivityId LIKE @Id ORDER BY Code";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                var itemList = new List<BllStockItem>();

                using (var dr = connection.QueryWithDataReader(sqlQuery))
                {
                    while (dr.Read())
                    {
                        var item = new BllStockItem()
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
                }

                return itemList;
            }
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            var deleteState = false;

            using (var connection = new MdlConnection())
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
        #endregion 
    }
}
