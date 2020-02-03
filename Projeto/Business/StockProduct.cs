using DimStock.Auxiliarys;
using DimStock.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Business
{
    public class StockProduct
    {
        #region Constructs

        public StockProduct() { }

        public StockProduct(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion

        #region BussinesProperties
        public int StockId { get; set; }
        public string Supplier { get; set; }
        public int StockQuantity { get; set; }
        public double StockValue { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string StockSummary { get; set; }
        public string StockResult { get; set; }
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public int ProductSize { get; set; }
        public string ProductDescription { get; set; }
        public int ProductReference { get; set; }
        public double ProductCostPrice { get; set; }
        public string ProductPhoto { get; set; }
        public List<StockProduct> ListOfRecords { get; set; }
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
                var listOfRecords = new List<StockProduct>();

                if (SearchBySummary == "All")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Stock.Id > 0";
                }

                if (SearchBySummary == "Nothing")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity = 0 AND MinStock = 0 
                    AND MaxStock = 0";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Quantity = 0 
                    AND MinStock = 0 AND MaxStock = 0";
                }

                if (SearchBySummary == "Ok")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Product.Id = Stock.ProductId WHERE Quantity > 0 AND Quantity >= 
                    MinStock AND Quantity <= MaxStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Quantity > 0 
                    AND Quantity >= MinStock AND Quantity <= MaxStock";
                }

                if (SearchBySummary == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity > MaxStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Quantity > MaxStock";
                }

                if (SearchBySummary == "Low")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity < MinStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Quantity < MinStock";
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
                        var stockProduct = new StockProduct
                        {
                            StockId = Convert.ToInt32(reader["Stock.Id"]),
                            ProductId = Convert.ToInt32(reader["Product.Id"]),
                            Supplier = Convert.ToString(reader["Supplier"]),
                            ProductCode = Convert.ToInt32(reader["Code"]),
                            ProductReference = Convert.ToInt32(reader["Reference"]),
                            ProductSize = Convert.ToInt32(reader["Product.Size"]),
                            ProductDescription = Convert.ToString(reader["Description"]),
                            MinStock = Convert.ToInt32(reader["MinStock"]),
                            MaxStock = Convert.ToInt32(reader["MaxStock"]),
                            StockQuantity = Convert.ToInt32(reader["Quantity"]),
                            StockValue = Convert.ToDouble(reader["TotalValue"]),
                            ProductCostPrice = Convert.ToDouble(reader["CostPrice"]),
                            ProductPhoto = Convert.ToString(reader["PhotoName"]),
                        };

                        listOfRecords.Add(stockProduct);
                    }

                    ListOfRecords = listOfRecords;
                }

                SetSummary(ListOfRecords);

                SetResult(ListOfRecords);
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
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From Product 
                    INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Stock.Id > 0";
                }

                if (SearchBySummary == "Nothing")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity = 0 AND MinStock = 0 
                    AND MaxStock = 0";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From Product 
                    INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Quantity = 0 AND 
                    MinStock = 0 AND MaxStock = 0";
                }

                if (SearchBySummary == "Ok")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Product.Id = Stock.ProductId WHERE Quantity > 0 AND Quantity >= 
                    MinStock AND Quantity <= MaxStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From Product 
                    INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Quantity > 0 AND 
                    Quantity >= MinStock AND Quantity <= MaxStock";
                }

                if (SearchBySummary == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity > MaxStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, [Product.Size], 
                    Product.MinStock, Product.MaxStock, Product.PhotoName From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity > MaxStock";
                }

                if (SearchBySummary == "Low")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity < MinStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, [Product.Size], 
                    Product.MinStock, Product.MaxStock, Product.PhotoName From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity < MinStock";
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

                SetSummary(ListOfRecords);

                SetResult(ListOfRecords);
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
                        StockId = Convert.ToInt32(reader["Stock.Id"]);
                        ProductId = Convert.ToInt32(reader["Product.Id"]);
                        ProductCode = Convert.ToInt32(reader["Code"]);
                        ProductDescription = reader["Description"].ToString();
                        ProductReference = Convert.ToInt32(reader["Reference"]);
                        ProductSize = Convert.ToInt32(reader["Size"]);
                        ProductCostPrice = Convert.ToDouble(reader["CostPrice"]);
                        StockQuantity = Convert.ToInt32(reader["Quantity"]);
                    }
                }
            }
        }

        public void GenerateReport(List<StockProduct> listOfRecords)
        {
            var stockProduct = new ReportStockProduct();
            stockProduct.GenerateReport(listOfRecords);
        }

        public void SetSummary(List<StockProduct> listOfRecords)
        {
            for (int i = 0; i < listOfRecords.Count; i++)
            {
                var listItem = listOfRecords[i];
                var quantity = listItem.StockQuantity;
                var minStock = listItem.MinStock;
                var maxStock = listItem.MaxStock;

                if (quantity > 0 && quantity >= minStock && quantity <= maxStock)
                    listItem.StockSummary = "OK";

                if (quantity > maxStock)
                    listItem.StockSummary = "Alto";

                if (quantity < minStock)
                    listItem.StockSummary = "Baixo";

                if (quantity == 0 & minStock == 0 && maxStock == 0)
                    listItem.StockSummary = "???";
            }
        }

        public void SetResult(List<StockProduct> listOfRecords)
        {
            for (int i = 0; i < listOfRecords.Count; i++)
            {
                var listItem = listOfRecords[i];
                var quantity = listItem.StockQuantity;
                var minStock = listItem.MinStock;
                var maxStock = listItem.MaxStock;

                if (quantity < minStock)
                    listItem.StockResult = " + " + Convert.ToString(minStock - quantity);

                if (quantity > maxStock)
                    listItem.StockResult = " - " + Convert.ToString(quantity - maxStock);

                if (quantity > 0 && quantity >= minStock && quantity <= maxStock)
                    listItem.StockResult = "OK";

                if (quantity == 0 && minStock == 0 && maxStock == 0)
                    listItem.StockResult = "???";
            }
        }

        public void PassToList(DataTable dataTable)
        {
            var stockProductList = new List<StockProduct>();

            foreach (DataRow row in dataTable.Rows)
            {
                var stockProduct = new StockProduct
                {
                    StockId = Convert.ToInt32(row["Stock.Id"]),
                    ProductId = Convert.ToInt32(row["Product.Id"]),
                    Supplier = Convert.ToString(row["Supplier"]),
                    ProductCode = Convert.ToInt32(row["Code"]),
                    ProductReference = Convert.ToInt32(row["Reference"]),
                    ProductSize = Convert.ToInt32(row["Product.Size"]),
                    ProductDescription = Convert.ToString(row["Description"]),
                    MinStock = Convert.ToInt32(row["MinStock"]),
                    MaxStock = Convert.ToInt32(row["MaxStock"]),
                    StockQuantity = Convert.ToInt32(row["Quantity"]),
                    StockValue = Convert.ToDouble(row["TotalValue"]),
                    ProductCostPrice = Convert.ToDouble(row["CostPrice"]),
                    ProductPhoto = Convert.ToString(row["PhotoName"]),
                };

                stockProductList.Add(stockProduct);
            }

            ListOfRecords = stockProductList;
        }

        #endregion

    }
}
