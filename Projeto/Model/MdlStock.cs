using DimStock.Business;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace DimStock.Model
{
    public class MdlStock
    {
        #region Properties
        private readonly BllStock stock;
        #endregion 

        #region Constructs
        public MdlStock() { }

        public MdlStock(BllStock stock)
        {
            this.stock = stock;
        }
        #endregion 

        #region AddEntries()
        public bool AddEntries(List<BllStock> stockList, int activityId)
        {
            var transaction = false;

            using (var connection = new MdlConnection())

            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    for (int i = 0; i < stockList.Count; i++)
                    {

                        var stockId = stockList[i].Id;
                        var quantity = stockList[i].Quantity;
                        var totalValue = stockList[i].TotalValue;

                        var commandSQL = @"UPDATE TBEstoque Set Quantidade = Quantidade + '" + quantity +
                        "', Valor = Valor + '" + totalValue + "' WHERE Id = " + stockId;

                        connection.ExecuteTransaction(commandSQL);
                    }

                    var stockActivity = new MdlStockActivity();

                    if (stockActivity.UpdateSituation(connection, activityId) == true)
                    {
                        connection.Transaction.Commit();
                        transaction = true;
                        BllNotification.Message = "OK! todos os estoques foram adicionados!";
                    }

                    return transaction;
                }
            }
        }
        #endregion

        #region AddOutPuts()
        public bool AddOutPuts(List<BllStock> stockList, int activityId)
        {
            using (var connection = new MdlConnection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    for (int i = 0; i < stockList.Count; i++)
                    {

                        var stockId = stockList[i].Id;
                        var quantity = stockList[i].Quantity;
                        var totalValue = stockList[i].TotalValue;

                        var commandSQL = @"UPDATE TBEstoque Set Quantidade = Quantidade - '" + quantity +
                        "', Valor = Valor - '" + totalValue + "' WHERE Id = " + stockId;

                        connection.ExecuteTransaction(commandSQL);
                    }

                    var stockActivity = new MdlStockActivity();
                    stockActivity.UpdateSituation(connection, activityId);

                    connection.Transaction.Commit();

                    BllNotification.Message = "Ok! Todos os estoques foram removidos!";

                    return true;
                }
            }
        }
        #endregion

        #region RelateProduct()
        public bool RelateProduct(MdlConnection connection, int productId)
        {
            var commandSQL = @"INSERT INTO TBEstoque(IdProduto)VALUES(@IdProduto)";
            var transaction = false;

            connection.ParameterClear();
            connection.AddParameter("@IdProduto", OleDbType.Integer, productId);

            if (connection.ExecuteTransaction(commandSQL) > 0)
            {
                transaction = true;
            }

            return transaction;
        }
        #endregion

        #region UpdateValue()
        public bool UpdateValue(MdlConnection connection, double productCostPrice, int productId)
        {
            var commandSQL = @"UPDATE TBEstoque Set Valor = '" + productCostPrice + "' * Quantidade WHERE IdProduto = " + productId;
            var transaction = false;

            if (connection.ExecuteTransaction(commandSQL) > 0)
            {
                transaction = true;
            }

            return transaction;
        }
        #endregion

        #region Reset()
        public bool Reset(List<BllStockItem> stockItemList)
        {
            using (var connection = new MdlConnection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    for (int i = 0; i < stockItemList.Count; i++)
                    {
                        var commandSQL = @"UPDATE TBEstoque Set Quantidade = '0', Valor = '0' WHERE Id = " + stockItemList[i].StockId;

                        connection.ExecuteTransaction(commandSQL);
                    }

                    connection.Transaction.Commit();

                    BllNotification.Message = "Ok! Todos os estoques foram removidos!";

                    return true;
                }
            }
        }
        #endregion 

        #region GetDataFromAffectedRecord()
        public string GetDataFromAffectedRecord(int id)
        {
            using (var connection = new MdlConnection())
            {

                var commandSQL = @"SELECT * From TBEstoque Where Id = " + id;

                var affectedFieldList = new List<string>();

                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        affectedFieldList.Add("Id:" + dr["Id"].ToString());
                        affectedFieldList.Add("IdProduto:" + dr["IdProduto"].ToString());
                        affectedFieldList.Add("Quantidade:" + dr["Quantidade"].ToString());
                        affectedFieldList.Add("Valor:" + dr["Valor"].ToString());
                    }
                }

                return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
            }
        }
        #endregion
    }
}
