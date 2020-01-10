using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Business
{
    public class Stock
    {
        private Connection connection;

        #region Contructs

        public Stock(){}

        public Stock(Connection connection)
        {
            this.connection = connection;
        }

        #endregion 

        #region Get e Set
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalValue { get; set; }
        #endregion 

        #region Methods

        public bool RegisterEntries(List<Stock> itemList, int stockMovementId)
        {
            var transactionState = false;
            var sqlCommand = string.Empty;

            using (var connection = new Connection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    for (int i = 0; i < itemList.Count; i++)
                    {
                        var stockId = itemList[i].Id;
                        var quantity = itemList[i].Quantity;
                        var totalValue = itemList[i].TotalValue;

                        sqlCommand = @"UPDATE Stock Set Quantity = Quantity + @Quantity, 
                        TotalValue = TotalValue + @TotalValue WHERE Id = @Id";

                        connection.ParameterClear();
                        connection.AddParameter("@Quantity", OleDbType.Integer, quantity);
                        connection.AddParameter("@TotalValue", OleDbType.Double, totalValue);
                        connection.AddParameter("@Id", OleDbType.Integer, stockId);

                        connection.ExecuteTransaction(sqlCommand);
                    }

                    var stockMovement = new StockMovement();

                    if (stockMovement.FinalizeOperation(connection, stockMovementId) == true)
                    {
                        connection.Transaction.Commit();
                        transactionState = true;
                        Notification.Message = "OK! todos os estoques foram adicionados!";
                    }

                    return transactionState;
                }
            }
        }

        public bool RegisterRemovals(List<Stock> itemList, int stockMovementId)
        {
            using (var connection = new Connection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {

                    var transactionState = false;
                    var sqlCommand = string.Empty;

                    for (int i = 0; i < itemList.Count; i++)
                    {

                        var stockId = itemList[i].Id;
                        var quantity = itemList[i].Quantity;
                        var totalValue = itemList[i].TotalValue;

                        sqlCommand = @"UPDATE Stock Set Quantity = Quantity - @Quantity, 
                        TotalValue = TotalValue - @TotalValue WHERE Id = @Id";

                        connection.ParameterClear();
                        connection.AddParameter("@Quantity", OleDbType.Integer, quantity);
                        connection.AddParameter("@TotalValue", OleDbType.Double, totalValue);
                        connection.AddParameter("@Id", OleDbType.Integer, stockId);

                        connection.ExecuteTransaction(sqlCommand);
                    }

                    var stockMovement = new StockMovement();

                    if (stockMovement.FinalizeOperation(connection, stockMovementId) == true)
                    {
                        connection.Transaction.Commit();
                        transactionState = true;
                        Notification.Message = "Ok! Todos os estoques foram removidos!";
                    }

                    return transactionState;
                }
            }
        }

        public bool AddRelatedProduct(int id)
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

        public bool UpdateValue(double productCostPrice, int productId)
        {
            var transactionState = false;

            var sqlCommand = @"UPDATE Stock Set TotalValue = @ProductCostPrice * 
            Quantity WHERE ProductId = @ProductId";

            connection.ParameterClear();
            connection.AddParameter("ProductCostPrice", OleDbType.Double, productCostPrice);
            connection.AddParameter("@ProductId", OleDbType.Integer, productId);

            return transactionState = connection.ExecuteTransaction(sqlCommand) > 0;
        }

        public bool Reset(List<StockItem> itemList)
        {
             using (var connection = new Connection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    for (int i = 0; i < itemList.Count; i++)
                    {
                        var stockId = itemList[i].StockId;

                        var sqlCommand = @"UPDATE Stock Set TotalValue = '0' WHERE Id = @StockId";

                        connection.ParameterClear();
                        connection.AddParameter("@StockId", OleDbType.Integer, stockId);

                        connection.ExecuteTransaction(sqlCommand);
                    }

                    connection.Transaction.Commit();

                    Notification.Message = "Ok! Todos os estoques foram removidos!";

                    return true;
                }
            }
        }

        #endregion
    }
}
