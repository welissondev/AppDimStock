using DimStock.Auxiliarys;
using DimStock.Reports;
using DimStock.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Business
{
    public class Stock : IReport<Stock>
    {
        #region Properties
        private Connection connection;
        #endregion

        #region Contructs

        public Stock()
        {
            Product = new Product();
            List = new List<Stock>();
        }

        public Stock(Connection connection)
        {
            this.connection = connection;
        }

        public Stock(AxlDataPagination dataPagination)
        {
            Product = new Product();
            List = new List<Stock>();
            DataPagination = dataPagination;
        }

        #endregion 

        #region Get e Set
        public int Id { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Quantity { get; set; }
        public double TotalValue { get; set; }
        public string Summary { get; set; }
        public string Result { get; set; }
        public Product Product { get; set; }
        public List<Stock> List { get; set; }
        #endregion 

        #region SearchProperties

        private string searchBySummary = "All";

        public string SearchByCode { get; set; }
        public string SearchBySize { get; set; }
        public string SearchByReference { get; set; }
        public string SearchByDescription { get; set; }
        public string SearchBySummary { get => searchBySummary; set => searchBySummary = value; }
        public AxlDataPagination DataPagination { get; set; }

        #endregion

        #region Methods

        public void ListData()
        {
            using (var connection = new Connection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;

                if (SearchBySummary == "All")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,  
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.Photo FROM Product INNER JOIN Stock ON Stock.ProductId 
                    = Product.Id WHERE Stock.Id > 0";
                }

                if (SearchBySummary == "Nothing")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity = 0 AND Stock.Min = 0 
                    AND Stock.Max = 0";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.Photo From Product INNER JOIN Stock ON Stock.ProductId = 
                    Product.Id WHERE Stock.Quantity = 0 AND Stock.Min = 0 AND Stock.Max = 0";
                }

                if (SearchBySummary == "Ok")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Product.Id = Stock.ProductId WHERE Stock.Quantity > 0 AND Stock.Quantity >= 
                    Stock.Min AND Stock.Quantity <= Stock.Max";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.Photo From Product INNER JOIN Stock ON Stock.ProductId 
                    = Product.Id WHERE Stock.Quantity > 0 AND Stock.Quantity >= Stock.Min 
                    AND Stock.Quantity <= Stock.Max";
                }

                if (SearchBySummary == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity > Stock.Max";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,  
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size],Product.Photo From Product INNER JOIN Stock ON Stock.ProductId 
                    = Product.Id WHERE Stock.Quantity > Stock.Max";
                }

                if (SearchBySummary == "Low")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity < Stock.Min";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.Photo From Product INNER JOIN Stock ON Stock.ProductId 
                    = Product.Id WHERE Stock.Quantity < Stock.Min";
                }

                if (SearchByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    SearchByDescription));
                }

                if (SearchByCode != string.Empty)
                {
                    criterion += " AND Code LIKE @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    SearchByCode));

                }

                if (SearchBySize != string.Empty)
                {
                    criterion += " AND [Product.Size] LIKE @Size";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                    SearchBySize));
                }

                if (SearchByReference != string.Empty)
                {
                    criterion += " AND Reference LIKE @Reference";

                    parameter.AddWithValue("@Reference", string.Format("{0}",
                    SearchByReference));
                }

                sqlQuery += criterion + @" Order By Code, 
                [Product.Size], Reference Asc";

                sqlCount += criterion;

                using (var reader = connection.QueryWithDataReader(sqlQuery))
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
                        stock.Product.Code = Convert.ToInt32(reader["Code"]);
                        stock.Product.Reference = Convert.ToInt32(reader["Reference"]);
                        stock.Product.Size = Convert.ToInt32(reader["Product.Size"]);
                        stock.Product.Description = Convert.ToString(reader["Description"]);
                        stock.Product.CostPrice = Convert.ToDouble(reader["CostPrice"]);
                        stock.Product.Photo = Convert.ToString(reader["Photo"]);

                        List.Add(stock);
                    }
                }

                SetSummary(List);

                SetResult(List);
            }
        }

        public void SearchData()
        {
            using (var con = new Connection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = con.Command.Parameters;

                if (SearchBySummary == "All")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Stock INNER JOIN Product ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.Min, Stock.Max, Stock.TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.Photo From Product INNER JOIN Stock ON Stock.ProductId 
                    = Product.Id WHERE Stock.Id > 0";
                }

                if (SearchBySummary == "Nothing")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity = 0 AND Stock.Min = 0 
                    AND Stock.Max = 0";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.Photo From Product INNER JOIN Stock ON Stock.ProductId 
                    = Product.Id WHERE Quantity = 0 AND Stock.Min = 0 AND Stock.Max = 0";
                }

                if (SearchBySummary == "Ok")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Product.Id = Stock.ProductId WHERE Quantity > 0 AND Quantity >= 
                    Stock.Min AND Quantity <= Stock.Max";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.Photo From Product INNER JOIN Stock ON Stock.ProductId 
                    = Product.Id WHERE Quantity > 0 AND Quantity >= Stock.Min AND Quantity <= Stock.Max";
                }

                if (SearchBySummary == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity > Stock.Max";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, 
                    Stock.Max, Product.Id, Product.Description, Product.CostPrice, Product.Code, 
                    Product.Reference, [Product.Size], Product.Photo From Product 
                    INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Stock.Quantity > Stock.Max";
                }

                if (SearchBySummary == "Low")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity < Stock.Min";

                    sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.Photo From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Quantity < Stock.Min";
                }

                if (SearchByCode != string.Empty)
                {
                    criterion += " AND Code LIKE @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    SearchByCode));
                }

                if (SearchBySize != string.Empty)
                {
                    criterion += " AND [Product.Size] LIKE @Size ";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                    SearchBySize));
                }

                if (SearchByReference != string.Empty)
                {
                    criterion += " AND Reference LIKE @Reference ";

                    parameter.AddWithValue("@Reference ", string.Format("{0}",
                    SearchByReference));
                }

                if (SearchByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    SearchByDescription));
                }

                sqlQuery += criterion + " Order By Code, " +
                "[Product.Size], Reference Asc";

                sqlCount += criterion;

                DataPagination.RecordCount = Convert.ToInt32(
                con.ExecuteScalar(sqlCount));

                var dataTable = con.QueryWithDataTable(sqlQuery,
                DataPagination.OffSetValue,
                DataPagination.PageSize);

                PassToList(dataTable);

                SetSummary(List);

                SetResult(List);
            }
        }

        public void ViewDetails(int id)
        {
            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT Product.*, Stock.* From Product INNER JOIN 
                Stock ON Product.Id = Stock.ProductId WHERE Product.Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Stock.Id"]);
                        Product.Id = Convert.ToInt32(reader["Product.Id"]);
                        Product.Code = Convert.ToInt32(reader["Code"]);
                        Product.Description = reader["Description"].ToString();
                        Product.Reference = Convert.ToInt32(reader["Reference"]);
                        Product.Size = Convert.ToInt32(reader["Size"]);
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
                        UserId = AxlLogin.Id,
                        OperationType = "Entrada",
                        OperationModule = "Estoque",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = stockMovement.GetAffectedFields(stockMovementId, connection)
                    };
                    transactionState = userHistory.Register();

                    //Finalza o transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Ok, todos os estoques foram cadastrados!";
                }

                return transactionState;
            }
        }

        public bool AddOutputs(List<Stock> itemList, int stockMovementId)
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
                        UserId = AxlLogin.Id,
                        OperationType = "Saída",
                        OperationModule = "Estoque",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = stockMovement.GetAffectedFields(stockMovementId, connection)
                    };
                    transactionState = userHistory.Register();

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Ok! Todos os estoques foram retirados!";
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
                var stockId = stockItems[i].StockId;
                var quantity = stockItems[i].Quantity;
                var totalValue = stockItems[i].TotalValue;

                sqlCommand = @"UPDATE Stock Set Quantity = Quantity - @Quantity, 
                TotalValue = TotalValue - @TotalValue WHERE Id = @Id";

                connection.ParameterClear();
                connection.AddParameter("@Quantity", OleDbType.Integer, quantity);
                connection.AddParameter("@TotalValue", OleDbType.Double, totalValue);
                connection.AddParameter("@Id", OleDbType.Integer, stockId);

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
                var stockId = stockItems[i].StockId;
                var quantity = stockItems[i].Quantity;
                var totalValue = stockItems[i].TotalValue;

                sqlCommand = @"UPDATE Stock Set Quantity = Quantity + @Quantity, 
                    TotalValue = TotalValue + @TotalValue WHERE Id = @Id";

                connection.ParameterClear();
                connection.AddParameter("@Quantity", OleDbType.Integer, quantity);
                connection.AddParameter("@TotalValue", OleDbType.Double, totalValue);
                connection.AddParameter("@Id", OleDbType.Integer, stockId);

                transactionState = connection.ExecuteTransaction(sqlCommand) > 0;
            }

            return transactionState;
        }

        public bool RelateProduct(int id)
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

            connection.ParameterClear();
            connection.AddParameter("ProductCostPrice", OleDbType.Double, productCostPrice);
            connection.AddParameter("@ProductId", OleDbType.Integer, productId);

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
                var stock = new Stock
                {
                    Id = Convert.ToInt32(row["Stock.Id"]),
                    Min = Convert.ToInt32(row["Min"]),
                    Max = Convert.ToInt32(row["Max"]),
                    Quantity = Convert.ToInt32(row["Quantity"]),
                    TotalValue = Convert.ToDouble(row["TotalValue"])
                };

                stock.Product.Id = Convert.ToInt32(row["Product.Id"]);
                stock.Product.Code = Convert.ToInt32(row["Code"]);
                stock.Product.Reference = Convert.ToInt32(row["Reference"]);
                stock.Product.Size = Convert.ToInt32(row["Product.Size"]);
                stock.Product.Description = Convert.ToString(row["Description"]);
                stock.Product.CostPrice = Convert.ToDouble(row["CostPrice"]);
                stock.Product.Photo = Convert.ToString(row["Photo"]);

                List.Add(stock);
            }
        }

        #endregion
    }
}
