using DimStock.Business;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace DimStock.Model
{
    public class StockModel
    {
        #region Properties
        private readonly StockController stock;
        #endregion 

        #region Constructs
        public StockModel() { }

        public StockModel(StockController stock)
        {
            this.stock = stock;
        }
        #endregion 

        #region Methods

        public bool Allocate(List<StockController> itemList, int stockMovementId)
        {
            var transactionState = false;
            var sqlCommand = string.Empty;

            using (var connection = new MdlConnection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    for (int i = 0; i < itemList.Count; i++)
                    {

                        var stockId = itemList[i].Id;
                        var quantity = itemList[i].Quantity;
                        var totalValue = itemList[i].TotalValue;

                        sqlCommand = @"UPDATE Stock Set Quantity = Quantity + '" + quantity +
                        "', TotalValue = TotalValue + '" + totalValue + "' WHERE Id = " + stockId;

                        connection.ExecuteTransaction(sqlCommand);
                    }

                    var stockMovement = new StockMovementModel();

                    if (stockMovement.FianalizeOperation(connection, stockMovementId) == true)
                    {
                        connection.Transaction.Commit();
                        transactionState = true;
                        NotificationController.Message = "OK! todos os estoques foram adicionados!";
                    }

                    return transactionState;
                }
            }
        }

        public bool Deallocate(List<StockController> itemList, int stockMovementId)
        {
            using (var connection = new MdlConnection())
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

                        sqlCommand = @"UPDATE Stock Set Quantity = Quantity - '" + quantity + "' " +
                        ", TotalValue = TotalValue - '" + totalValue + "' WHERE Id = " + stockId;

                        connection.ExecuteTransaction(sqlCommand);
                    }

                    var stockMovement = new StockMovementModel();

                    if (stockMovement.FianalizeOperation(connection, stockMovementId) == true)
                    {
                        connection.Transaction.Commit();
                        transactionState = true;
                        NotificationController.Message = "Ok! Todos os estoques foram removidos!";
                    }

                    return transactionState;
                }
            }
        }

        public bool RelateProduct(MdlConnection connection, int productId)
        {
            var transactionState = false;

            var sqlCommand = @"INSERT INTO Stock(ProductId)VALUES(@ProductId)";

            connection.ParameterClear();
            connection.AddParameter("@ProductId", OleDbType.Integer, productId);

            if (connection.ExecuteTransaction(sqlCommand) > 0)
            {
                transactionState = true;
            }

            return transactionState;
        }

        public bool UpdateValue(MdlConnection connection, double productCostPrice, int productId)
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

        public bool Reset(List<StockItemController> itemList)
        {
            using (var connection = new MdlConnection())
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

                    NotificationController.Message = "Ok! Todos os estoques foram removidos!";

                    return true;
                }
            }
        }

        public string GetAffectedFields(int id)
        {
            using (var connection = new MdlConnection())
            {
                var affectedFieldList = new List<string>();

                var sqlQuery = @"SELECT * From Stock Where Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        affectedFieldList.Add("Id:" + reader["Id"].ToString());
                        affectedFieldList.Add("IdProduto:" + reader["ProductId"].ToString());
                        affectedFieldList.Add("Quantidade:" + reader["Quantity"].ToString());
                        affectedFieldList.Add("Valor:" + reader["TotalValue"].ToString());
                    }
                }

                return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
            }
        }

        #endregion
    }
}
