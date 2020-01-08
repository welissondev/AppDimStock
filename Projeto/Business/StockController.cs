using DimStock.Model;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Business
{
    public class StockController
    {
        #region Get e Set
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalValue { get; set; }
        #endregion 

        #region Methods

        public bool RegisterEntries(List<StockController> itemList, int stockMovementId)
        {
            var transactionState = false;

            var stock = new StockModel();

            if (stock.InsertEntries(itemList, stockMovementId) == true)
            {
                transactionState = true;
            }

            return transactionState;
        }

        public bool RegisterRemovals(List<StockController> itemList, int stockMovementId)
        {
            var transactionState = false;

            var stock = new StockModel();

            if (stock.InsertRemovals(itemList, stockMovementId) == true)
            {
                transactionState = true;
            }

            return transactionState;
        }

        public bool RegisterRelatedProduct(Connection connection, int id)
        {
            var transactionState = false;

            var sqlCommand = @"INSERT INTO Stock(ProductId)VALUES(@ProductId)";

            connection.ParameterClear();
            connection.AddParameter("@ProductId", OleDbType.Integer, id);

            if (connection.ExecuteTransaction(sqlCommand) > 0)
            {
                transactionState = true;
            }

            return transactionState;
        }

        public bool UpdateValue(Connection connection, double productCostPrice, int productId)
        {
            var transactionState = false;

            var sqlCommand = @"UPDATE Stock Set TotalValue = @ProductCostPrice * 
            Quantity WHERE ProductId = @ProductId";

            connection.ParameterClear();
            connection.AddParameter("ProductCostPrice", OleDbType.Double, productCostPrice);
            connection.AddParameter("@ProductId", OleDbType.Integer, productId);

            if (connection.ExecuteTransaction(sqlCommand) > 0)
            {
                transactionState = true;
            }

            return transactionState;
        }

        public bool Reset(List<StockItemController> stockItemList)
        {
            var transaction = false;

            var stock = new StockModel();

            if (stock.Reset(stockItemList) == true)
            {
                transaction = true;
            }

            return transaction;
        }

        #endregion
    }
}
