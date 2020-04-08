using DimStock.Auxiliarys;
using DimStock.Reports;
using System;
using System.Collections.Generic;
using System.Data;

namespace DimStock.Models
{
    public class Stock 
    {
        #region Buider

        public Stock()
        {
            Product = new ProductModel();
            List = new List<Stock>();
        }

        public Stock(AxlDataPage pagination)
        {
            Pagination = pagination;
            Product = new ProductModel();
            List = new List<Stock>();
        }

        public Stock(AccessConnection connection)
        {
            this.connection = connection;
            Product = new ProductModel();
        }

        #endregion

        #region Get & Set

        private string summary = "All";
        private AccessConnection connection;

        public int Id { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Quantity { get; set; }
        public double TotalValue { get; set; }
        public string Result { get; set; }
        public string Summary { get => summary; set => summary = value; }
        public ProductModel Product { get; set; }
        public AxlDataPage Pagination { get; set; }
        public List<Stock> List { get; set; }

        #endregion

        #region Function

        public void ListData()
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;

                if (Summary == "All")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Stock INNER JOIN Product ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.Min, Stock.Max, Stock.TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, 
                    Product.Photo From Product INNER JOIN Stock ON Stock.ProductId = 
                    Product.Id WHERE Stock.Id > 0";
                }

                if (Summary == "Nothing")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity = 0 AND Stock.Min = 0 
                    AND Stock.Max = 0";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                    Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo 
                    From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Quantity = 0 AND Stock.Min = 0 AND Stock.Max = 0";
                }

                if (Summary == "Ok")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Product.Id = Stock.ProductId WHERE Quantity > 0 AND Quantity >= 
                    Stock.Min AND Quantity <= Stock.Max";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max, 
                    Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo 
                    From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Quantity > 0 
                    AND Quantity >= Stock.Min AND Quantity <= Stock.Max";
                }

                if (Summary == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity > Stock.Max";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, 
                    Stock.Max, Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, 
                    Product.Photo From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Stock.Quantity > Stock.Max";
                }

                if (Summary == "Low")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity < Stock.Min";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                    Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Stock.Quantity < Stock.Min";
                }

                if (Product.InternalCode != string.Empty)
                {
                    criterion += " AND InternalCode LIKE @InternalCode";

                    parameter.AddWithValue("@InternalCode", string.Format("{0}%",
                    Product.InternalCode));
                }

                if (Product.Description != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    Product.Description));
                }

                sqlQuery += criterion + " Order By InternalCode Asc";

                sqlCount += criterion;

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var stock = new Stock
                        {
                            Id = Convert.ToInt32(reader["Stock.Id"]),
                            Min = Convert.ToInt32(reader["Min"]),
                            Max = Convert.ToInt32(reader["Max"]),
                            Quantity = Convert.ToInt32(reader["Quantity"]),
                            TotalValue = Convert.ToDouble(reader["TotalValue"])
                        };

                        stock.Product.Id = Convert.ToInt32(reader["Product.Id"]);
                        stock.Product.InternalCode = Convert.ToString(reader["InternalCode"]);
                        stock.Product.Description = Convert.ToString(reader["Description"]);
                        stock.Product.CostPrice = Convert.ToDouble(reader["CostPrice"]);


                        List.Add(stock);
                    }
                }

                SetSummary(List);

                SetResult(List);
            }
        }

        public void FetchData()
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;

                if (Summary == "All")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Stock INNER JOIN Product ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.Min, Stock.Max, Stock.TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, 
                    Product.Photo From Product INNER JOIN Stock ON Stock.ProductId = 
                    Product.Id WHERE Stock.Id > 0";
                }

                if (Summary == "Nothing")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity = 0 AND Stock.Min = 0 
                    AND Stock.Max = 0";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                    Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo 
                    From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Quantity = 0 AND Stock.Min = 0 AND Stock.Max = 0";
                }

                if (Summary == "Ok")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Product.Id = Stock.ProductId WHERE Quantity > 0 AND Quantity >= 
                    Stock.Min AND Quantity <= Stock.Max";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max, 
                    Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo 
                    From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Quantity > 0 
                    AND Quantity >= Stock.Min AND Quantity <= Stock.Max";
                }

                if (Summary == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity > Stock.Max";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, 
                    Stock.Max, Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, 
                    Product.Photo From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Stock.Quantity > Stock.Max";
                }

                if (Summary == "Low")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity < Stock.Min";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                    Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Stock.Quantity < Stock.Min";
                }

                if (Product.InternalCode != string.Empty)
                {
                    criterion += " AND InternalCode LIKE @InternalCode";

                    parameter.AddWithValue("@InternalCode", string.Format("{0}%",
                    Product.InternalCode));
                }

                if (Product.Description != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    Product.Description));
                }

                sqlQuery += criterion + " Order By InternalCode Asc";

                sqlCount += criterion;

                Pagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.GetTable(sqlQuery,
                Pagination.OffSetValue,
                Pagination.PageSize);

                PassToList(dataTable);

                SetSummary(List);

                SetResult(List);
            }
        }

        public void GetDetail(int id)
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = @"SELECT Product.*, Stock.* From Product INNER JOIN 
                Stock ON Product.Id = Stock.ProductId WHERE Product.Id = @Id";

                connection.AddParameter("@Id", id);

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Stock.Id"]);
                        Product.Id = Convert.ToInt32(reader["Product.Id"]);
                        Product.InternalCode = Convert.ToString(reader["InternalCode"]);
                        Product.Description = reader["Description"].ToString();
                        Product.CostPrice = Convert.ToDouble(reader["CostPrice"]);
                        Quantity = Convert.ToInt32(reader["Quantity"]);
                    }
                }
            }
        }

        public bool AddEntries(List<Stock> itemList, int stockMovementId)
        {
            var transactionState = false;
            var sqlCommand = string.Empty;

            using (var connection = new AccessConnection())
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

                        connection.ClearParameter();
                        connection.AddParameter("@Quantity", quantity);
                        connection.AddParameter("@TotalValue" , totalValue);
                        connection.AddParameter("@Id", stockId);

                        connection.ExecuteTransaction(sqlCommand);
                    }

                    //Fianaliza a operação
                    var stockMovement = new StockMovement(connection);
                    transactionState = stockMovement.FinalizeOperation(
                    stockMovementId);

                    //Finalza o transação
                    connection.Transaction.Commit();

                    MessageNotifier.Message = "Ok, todos os estoques foram cadastrados!";
                }

                return transactionState;
            }
        }

        public bool AddOutputs(List<Stock> itemList, int stockMovementId)
        {
            using (var connection = new AccessConnection())
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

                        connection.ClearParameter();
                        connection.AddParameter("@Quantity", quantity);
                        connection.AddParameter("@TotalValue" ,totalValue);
                        connection.AddParameter("@Id", stockId);

                        connection.ExecuteTransaction(sqlCommand);
                    }

                    //Finaliza a operação
                    var stockMovement = new StockMovement(connection);
                    transactionState = stockMovement.FinalizeOperation(stockMovementId);

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    MessageNotifier.Message = "Ok! Todos os estoques foram retirados!";
                }

                return transactionState;
            }
        }

        public bool RemoveEntries(List<StockMovementItem> stockItems)
        {
            var transactionState = false;

            var sqlCommand = string.Empty;

            for (int i = 0; i < stockItems.Count; i++)
            {
                var stockId = stockItems[i].Stock.Id;
                var quantity = stockItems[i].Quantity;
                var totalValue = stockItems[i].TotalValue;

                sqlCommand = @"UPDATE Stock Set Quantity = Quantity - @Quantity, 
                TotalValue = TotalValue - @TotalValue WHERE Id = @Id";

                connection.ClearParameter();
                connection.AddParameter("@Quantity", quantity);
                connection.AddParameter("@TotalValue" ,totalValue);
                connection.AddParameter("@Id", stockId);

                transactionState = connection.ExecuteTransaction(sqlCommand) > 0;
            }

            return transactionState;
        }

        public bool RemoveOutputs(List<StockMovementItem> stockItems)
        {
            var transactionState = false;

            var sqlCommand = string.Empty;

            for (int i = 0; i < stockItems.Count; i++)
            {
                var stockId = stockItems[i].Stock.Id;
                var quantity = stockItems[i].Quantity;
                var totalValue = stockItems[i].TotalValue;

                sqlCommand = @"UPDATE Stock Set Quantity = Quantity + @Quantity, 
                    TotalValue = TotalValue + @TotalValue WHERE Id = @Id";

                connection.ClearParameter();
                connection.AddParameter("@Quantity", quantity);
                connection.AddParameter("@TotalValue" ,totalValue);
                connection.AddParameter("@Id", stockId);

                transactionState = connection.ExecuteTransaction(sqlCommand) > 0;
            }

            return transactionState;
        }

        public bool RelateProduct(int id)
        {
            var transactionState = false;

            var sqlCommand = @"INSERT INTO Stock(ProductId)VALUES(@ProductId)";

            connection.ClearParameter();
            connection.AddParameter("@ProductId", id);

            if (connection.ExecuteTransaction(sqlCommand) > 0)
            {
                transactionState = true;
            }

            return transactionState;
        }

        public void GenerateReport(List<Stock> list)
        {
            var stock = new StockReport();

            ListData(); stock.GenerateReport(list);
        }

        public bool UpdateValue(double productCostPrice, int productId)
        {
            var transactionState = false;

            var sqlCommand = @"UPDATE Stock Set TotalValue = @ProductCostPrice * 
            Quantity WHERE ProductId = @ProductId";

            connection.ClearParameter();
            connection.AddParameter("ProductCostPrice" ,productCostPrice);
            connection.AddParameter("@ProductId", productId);

            return transactionState = connection.ExecuteTransaction(sqlCommand) > 0;
        }

        public void SetSummary(List<Stock> listOfRecords)
        {
            for (int i = 0; i < listOfRecords.Count; i++)
            {
                var stockItem = listOfRecords[i];
                var quantity = stockItem.Quantity;
                var minStock = stockItem.Min;
                var maxStock = stockItem.Max;

                if (quantity > 0 && quantity >= minStock && quantity <= maxStock)
                    stockItem.Summary = "OK";

                if (quantity > maxStock)
                    stockItem.Summary = "Alto";

                if (quantity < minStock)
                    stockItem.Summary = "Baixo";

                if (quantity == 0 & minStock == 0 && maxStock == 0)
                    stockItem.Summary = "???";
            }
        }

        public void SetResult(List<Stock> listOfRecords)
        {
            for (int i = 0; i < listOfRecords.Count; i++)
            {
                var stockItem = listOfRecords[i];
                var quantity = stockItem.Quantity;
                var minStock = stockItem.Min;
                var maxStock = stockItem.Max;

                if (quantity < minStock)
                    stockItem.Result = " + " + Convert.ToString(minStock - quantity);

                if (quantity > maxStock)
                    stockItem.Result = " - " + Convert.ToString(quantity - maxStock);

                if (quantity > 0 && quantity >= minStock && quantity <= maxStock)
                    stockItem.Result = "OK";

                if (quantity == 0 && minStock == 0 && maxStock == 0)
                    stockItem.Result = "???";
            }
        }

        public void PassToList(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                var stock = new Stock()
                {
                    Id = Convert.ToInt32(row["Stock.Id"]),
                    Min = Convert.ToInt32(row["Min"]),
                    Max = Convert.ToInt32(row["Max"]),
                    Quantity = Convert.ToInt32(row["Quantity"]),
                    TotalValue = Convert.ToDouble(row["TotalValue"])
                };

                stock.Product.Id = Convert.ToInt32(row["Product.Id"]);
                stock.Product.InternalCode = Convert.ToString(row["InternalCode"]);
                stock.Product.Description = Convert.ToString(row["Description"]);
                stock.Product.CostPrice = Convert.ToDouble(row["CostPrice"]);


                List.Add(stock);
            }
        }

        #endregion
    }
}
