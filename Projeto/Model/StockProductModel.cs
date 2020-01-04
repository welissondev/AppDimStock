using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Model
{
    public class StockProductModel
    {
        #region Constructors
        public StockProductModel() { }

        public StockProductModel(StockProductController stockProduct)
        {
            this.stockProduct = stockProduct;
        }
        #endregion 

        #region Properties
        private StockProductController stockProduct;
        #endregion

        #region Methods

        public void SelectAll()
        {
            using (var connection = new MdlConnection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;
                var listOfRecords = new List<StockProductController>();

                #region QueryByResume

                if (stockProduct.SearchBySummary == "All")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Stock.Id > 0";
                }

                if (stockProduct.SearchBySummary == "Nothing")
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

                if (stockProduct.SearchBySummary == "Ok")
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

                if (stockProduct.SearchBySummary == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity > MaxStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Quantity > MaxStock";
                }

                if (stockProduct.SearchBySummary == "Low")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity < MinStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Quantity < MinStock";
                }

                #endregion

                #region QueryByCriterion

                if (stockProduct.SearchByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    stockProduct.SearchByDescription));
                }

                if (stockProduct.SearchByCode != string.Empty)
                {
                    criterion += " AND Code LIKE @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    stockProduct.SearchByCode));

                }

                if (stockProduct.SearchBySize != string.Empty)
                {
                    criterion += " AND [Product.Size] LIKE @Size";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                   stockProduct.SearchBySize));
                }

                if (stockProduct.SearchByReference != string.Empty)
                {
                    criterion += " AND Reference LIKE @Reference";

                    parameter.AddWithValue("@Reference", string.Format("{0}",
                    stockProduct.SearchByReference));
                }

                #endregion

                sqlQuery += criterion + @" Order By Code, 
                [Product.Size], Reference Asc";

                sqlCount += criterion;

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var stockProduct = new StockProductController
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

                    stockProduct.ListOfRecords = listOfRecords;
                }

                SetSummary(stockProduct.ListOfRecords);

                SetResult(stockProduct.ListOfRecords);
            }
        }

        public void SelectCustom()
        {
            using (var con = new MdlConnection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = con.Command.Parameters;

                #region QueryByResume

                if (stockProduct.SearchBySummary == "All")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From Product 
                    INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Stock.Id > 0";
                }

                if (stockProduct.SearchBySummary == "Nothing")
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

                if (stockProduct.SearchBySummary == "Ok")
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

                if (stockProduct.SearchBySummary == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity > MaxStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, [Product.Size], 
                    Product.MinStock, Product.MaxStock, Product.PhotoName From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity > MaxStock";
                }

                if (stockProduct.SearchBySummary == "Low")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity < MinStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, [Product.Size], 
                    Product.MinStock, Product.MaxStock, Product.PhotoName From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity < MinStock";
                }

                #endregion

                #region QueryByCriterion

                if (stockProduct.SearchByCode != string.Empty)
                {
                    criterion += " AND Code LIKE @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    stockProduct.SearchByCode));
                }

                if (stockProduct.SearchBySize != string.Empty)
                {
                    criterion += " AND [Product.Size] LIKE @Size ";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                    stockProduct.SearchBySize));
                }

                if (stockProduct.SearchByReference != string.Empty)
                {
                    criterion += " AND Reference LIKE @Reference ";

                    parameter.AddWithValue("@Reference ", string.Format("{0}",
                    stockProduct.SearchByReference));
                }

                if (stockProduct.SearchByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    stockProduct.SearchByDescription));
                }

                #endregion

                sqlQuery += criterion + " Order By Code, " +
                "[Product.Size], Reference Asc";

                sqlCount += criterion;

                stockProduct.DataPagination.RecordCount = Convert.ToInt32(
                con.ExecuteScalar(sqlCount));

                var dataTable = con.QueryWithDataTable(sqlQuery,
                stockProduct.DataPagination.OffSetValue,
                stockProduct.DataPagination.PageSize);

                PassTableToList(dataTable);

                SetSummary(stockProduct.ListOfRecords);

                SetResult(stockProduct.ListOfRecords);
            }
        }

        public void GetFields(int id)
        {
            using (var connection = new MdlConnection())
            {
                var sqlQuery = @"SELECT Product.*, Stock.* From Product INNER JOIN 
                Stock ON Product.Id = Stock.ProductId WHERE Product.Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        stockProduct.StockId = Convert.ToInt32(reader["Stock.Id"]);
                        stockProduct.ProductId = Convert.ToInt32(reader["Product.Id"]);
                        stockProduct.ProductCode = Convert.ToInt32(reader["Code"]);
                        stockProduct.ProductDescription = reader["Description"].ToString();
                        stockProduct.ProductReference = Convert.ToInt32(reader["Reference"]);
                        stockProduct.ProductSize = Convert.ToInt32(reader["Size"]);
                        stockProduct.ProductCostPrice = Convert.ToDouble(reader["CostPrice"]);
                        stockProduct.StockQuantity = Convert.ToInt32(reader["Quantity"]);
                    }
                }
            }
        }

        public void SetSummary(List<StockProductController> listOfRecords)
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

        public void SetResult(List<StockProductController> listOfRecords)
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

        private void PassTableToList(DataTable dataTable)
        {
            var stockProductList = new List<StockProductController>();

            foreach (DataRow row in dataTable.Rows)
            {
                var stockProduct = new StockProductController
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

            stockProduct.ListOfRecords = stockProductList;
        }

        #endregion
    }
}
