using System;
using System.Collections.Generic;
using System.Data.OleDb;
using DimStock.Auxiliary;

namespace DimStock.Business
{
    public class Stock
    {
        #region Properties
        private Connection connectionTransaction;
        #endregion

        #region Contructs

        public Stock() { }

        public Stock(Connection connection)
        {
            this.connectionTransaction = connection;
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

                    //Fianaliza a operação
                    var stockMovement = new StockMovement(connection);
                    transactionState = stockMovement.FinalizeOperation(
                    stockMovementId);

                    //Registra o histórico do usuário
                    var userHistory = new UserHistory(connection)
                    {
                        Login = LoginAssistant.Login,
                        OperationType = "Entrada",
                        OperationModule = "Estoque",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = stockMovement.GetDataFromAffectedFields(stockMovementId, connection)
                    };
                    transactionState = userHistory.Register();

                    //Finalza o transação
                    connection.Transaction.Commit();

                    Notification.Message = "Ok, todos os estoques foram cadastrados!";
                }

                return transactionState;
            }
        }

        public bool RegisterRemovals(List<Stock> itemList, int stockMovementId)
        {
            using (var connection = new Connection())
            {
                var transactionState = false;
                var sqlCommand = string.Empty;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
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

                    //Finaliza a operação
                    var stockMovement = new StockMovement(connection);
                    transactionState = stockMovement.FinalizeOperation(stockMovementId);

                    //Registra o histórico do usuário
                    var userHistory = new UserHistory(connection)
                    {
                        Login = LoginAssistant.Login,
                        OperationType = "Saída",
                        OperationModule = "Estoque",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = stockMovement.GetDataFromAffectedFields(stockMovementId, connection)
                    };
                    transactionState = userHistory.Register();

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    Notification.Message = "Ok! Todos os estoques foram retirados!";
                }

                return transactionState;
            }
        }

        public bool AddRelatedProduct(int id)
        {
            var transactionState = false;

            var sqlCommand = @"INSERT INTO Stock(ProductId)VALUES(@ProductId)";

            connectionTransaction.ParameterClear();
            connectionTransaction.AddParameter("@ProductId", OleDbType.Integer, id);

            if (connectionTransaction.ExecuteTransaction(sqlCommand) > 0)
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

            connectionTransaction.ParameterClear();
            connectionTransaction.AddParameter("ProductCostPrice", OleDbType.Double, productCostPrice);
            connectionTransaction.AddParameter("@ProductId", OleDbType.Integer, productId);

            return transactionState = connectionTransaction.ExecuteTransaction(sqlCommand) > 0;
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
