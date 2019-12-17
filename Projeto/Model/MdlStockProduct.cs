using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Model
{
    public class MdlStockProduct
    {
        #region Constructors
        public MdlStockProduct() { }

        public MdlStockProduct(BllStockProduct stockProduct)
        {
            this.stockProduct = stockProduct;
        }
        #endregion 

        #region Properties
        private BllStockProduct stockProduct;
        #endregion

        #region Filter()
        public List<BllStockProduct> Filter(string code, string size, string reference,
            string description, int numberOfRecords = 100)
        {

            List<BllStockProduct> listaEstoqueProduto = new List<BllStockProduct>();

            using (MdlConnection connection = new MdlConnection())
            {
                var sqlSelectEstoqueProduto = @"SELECT TOP " + numberOfRecords + @" Stock.Id, Product.Fornecedor, Stock.Quantidade, Stock.Valor, 
                Product.Id, Product.Descricao, Product.PrecoCusto, Product.Codigo, Product.Referencia, Product.Tamanho, 
                Product.EstoqueMin, Product.EstoqueMax, Product.PrecoCusto, Product.FotoNome From Product INNER JOIN Stock ON 
                Stock.IdProduto = Product.Id WHERE Descricao LIKE @Descricao";

                var criterio = "";

                if (code != "")
                    criterio += " AND Codigo LIKE @Codigo ";

                if (size != "")
                    criterio += " AND Tamanho LIKE @Tamanho ";

                if (reference != "")
                    criterio += " AND Referencia LIKE @Referencia ";

                sqlSelectEstoqueProduto += criterio + " Order By Codigo, Tamanho, Referencia Asc";

                var e = connection.Command.Parameters;
                e.AddWithValue("@Descricao", string.Format("%{0}%", description));

                if (code != "")
                    e.AddWithValue("@Codigo", string.Format("{0}", code));

                if (size != "")
                    e.AddWithValue("@Tamanho", string.Format("{0}", size));

                if (reference != "")
                    e.AddWithValue("@Referencia", string.Format("{0}", reference));

                using (OleDbDataReader dr = connection.ExecuteParameterQuery(sqlSelectEstoqueProduto))
                {
                    while (dr.Read())
                    {
                        BllStockProduct estoqueProduto = new BllStockProduct
                        {
                            StockId = Convert.ToInt32(dr["Stock.Id"]),
                            ProductId = Convert.ToInt32(dr["Product.Id"]),
                            Supplier = Convert.ToString(dr["Fornecedor"]),
                            ProductCode = Convert.ToInt32(dr["Codigo"]),
                            ProductReference = Convert.ToInt32(dr["Referencia"]),
                            ProductSize = Convert.ToInt32(dr["Tamanho"]),
                            ProductDescription = Convert.ToString(dr["Descricao"]),
                            MinStock = Convert.ToInt32(dr["EstoqueMin"]),
                            MaxStock = Convert.ToInt32(dr["EstoqueMax"]),
                            StockQuantity = Convert.ToInt32(dr["Quantidade"]),
                            StockValue = Convert.ToDouble(dr["Valor"]),
                            ProductCostPrice = Convert.ToDouble(dr["PrecoCusto"]),
                            ProductPhoto = Convert.ToString(dr["FotoNome"]),
                        };

                        listaEstoqueProduto.Add(estoqueProduto);
                    }
                }

                return listaEstoqueProduto;
            }
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            using (var con = new MdlConnection())
            {
                #region Variables
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = con.Command.Parameters;
                #endregion 

                #region QueryByResume

                #region All
                if (stockProduct.QueryByResume == "All")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From Product 
                    INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Stock.Id > 0";
                }
                #endregion

                #region Nothing
                if (stockProduct.QueryByResume == "Nothing")
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
                #endregion

                #region Ok
                if (stockProduct.QueryByResume == "Ok")
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
                #endregion

                #region High
                if (stockProduct.QueryByResume == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity > MaxStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, [Product.Size], 
                    Product.MinStock, Product.MaxStock, Product.PhotoName From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity > MaxStock";
                }
                #endregion

                #region Low
                if (stockProduct.QueryByResume == "Low")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity < MinStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, [Product.Size], 
                    Product.MinStock, Product.MaxStock, Product.PhotoName From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity < MinStock";
                }
                #endregion

                #endregion

                #region QueryByCriterion

                #region Criterion + Code
                if (stockProduct.QueryByCode != string.Empty)
                {
                    criterion += " AND Code LIKE @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    stockProduct.QueryByCode));
                }
                #endregion 

                #region Criterion + Size
                if (stockProduct.QueryBySize != string.Empty)
                {
                    criterion += " AND [Product.Size] LIKE @Size ";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                    stockProduct.QueryBySize));
                }
                #endregion 

                #region Criterion + Reference
                if (stockProduct.QueryByReference != string.Empty)
                {
                    criterion += " AND Reference LIKE @Reference ";

                    parameter.AddWithValue("@Reference ", string.Format("{0}",
                    stockProduct.QueryByReference));
                }
                #endregion

                #region Criterion + Description
                if (stockProduct.QueryByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    stockProduct.QueryByDescription));
                }
                #endregion 

                #region Criterion + SqlQuery
                sqlQuery += criterion + " Order By Code, [Product.Size], Reference Asc";
                #endregion 

                #region Criterion + SqlCount
                sqlCount += criterion;
                #endregion

                #endregion 

                #region SqlCount
                stockProduct.DataPagination.RecordCount = Convert.ToInt32(
                con.ExecuteScalar(sqlCount));
                #endregion

                #region FillDataTable
                var dataTable = con.QueryWithDataTable(sqlQuery,
                stockProduct.DataPagination.OffSetValue,
                stockProduct.DataPagination.PageSize);
                #endregion

                #region PassDataTableToList

                PassDataTableToList(dataTable);

                #endregion 

                #region SetResume
                SetResume(stockProduct.ListOfRecords);
                #endregion 

                #region SetResult
                SetResult(stockProduct.ListOfRecords);
                #endregion
            }
        }
        #endregion

        #region ListAll()
        public void ListAll()
        {
            using (var connection = new MdlConnection())
            {
                #region Variables
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;
                var listOfRecords = new List<BllStockProduct>();
                #endregion

                #region QueryByResume

                #region All
                if (stockProduct.QueryByResume == "All")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Stock.Id > 0";
                }
                #endregion 

                #region Nothing
                if (stockProduct.QueryByResume == "Nothing")
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
                #endregion 

                #region Ok
                if (stockProduct.QueryByResume == "Ok")
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
                #endregion

                #region High
                if (stockProduct.QueryByResume == "High")
                {
                    sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                    Stock.ProductId = Product.Id WHERE Quantity > MaxStock";

                    sqlQuery = @"SELECT Stock.Id, Product.Supplier, Stock.Quantity, TotalValue, 
                    Product.Id, Product.Description, Product.CostPrice, Product.Code, Product.Reference, 
                    [Product.Size], Product.MinStock, Product.MaxStock, Product.PhotoName From 
                    Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                    Quantity > MaxStock";
                }
                #endregion 

                #region Low
                if (stockProduct.QueryByResume == "Low")
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

                #endregion

                #region QueryByCriterion

                #region Criterion + QueryByDescription

                if (stockProduct.QueryByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    stockProduct.QueryByDescription));
                }

                #endregion 

                #region Criterion + QueryByCode

                if (stockProduct.QueryByCode != string.Empty)
                {
                    criterion += " AND Code LIKE @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    stockProduct.QueryByCode));

                }

                #endregion

                #region Criterion + QueryBySize

                if (stockProduct.QueryBySize != string.Empty)
                {
                    criterion += " AND [Product.Size] LIKE @Size";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                   stockProduct.QueryBySize));
                }

                #endregion

                #region Criterion + QueryByReference

                if (stockProduct.QueryByReference != string.Empty)
                {
                    criterion += " AND Reference LIKE @Reference";

                    parameter.AddWithValue("@Reference", string.Format("{0}",
                    stockProduct.QueryByReference));
                }

                #endregion

                #region Criterion + SqlQuery

                sqlQuery += criterion + @" Order By Code, [Product.Size], Reference Asc";

                #endregion

                #region Criterion + SqlCount

                sqlCount += criterion;

                #endregion

                #endregion

                #region FillListOfRecords

                using (var dr = connection.QueryWithDataReader(sqlQuery))
                {
                    while (dr.Read())
                    {
                        var stockProduct = new BllStockProduct
                        {
                            StockId = Convert.ToInt32(dr["Stock.Id"]),
                            ProductId = Convert.ToInt32(dr["Product.Id"]),
                            Supplier = Convert.ToString(dr["Supplier"]),
                            ProductCode = Convert.ToInt32(dr["Code"]),
                            ProductReference = Convert.ToInt32(dr["Reference"]),
                            ProductSize = Convert.ToInt32(dr["Product.Size"]),
                            ProductDescription = Convert.ToString(dr["Description"]),
                            MinStock = Convert.ToInt32(dr["MinStock"]),
                            MaxStock = Convert.ToInt32(dr["MaxStock"]),
                            StockQuantity = Convert.ToInt32(dr["Quantity"]),
                            StockValue = Convert.ToDouble(dr["TotalValue"]),
                            ProductCostPrice = Convert.ToDouble(dr["CostPrice"]),
                            ProductPhoto = Convert.ToString(dr["PhotoName"]),
                        };

                        listOfRecords.Add(stockProduct);
                    }

                    stockProduct.ListOfRecords = listOfRecords;
                }
                #endregion

                #region SetResume
                SetResume(stockProduct.ListOfRecords);
                #endregion 

                #region SetResult
                SetResult(stockProduct.ListOfRecords);
                #endregion
            }
        }
        #endregion

        #region SetResume()

        public void SetResume(List<BllStockProduct> listOfRecords)
        {
            for (int i = 0; i < listOfRecords.Count; i++)
            {
                var listItem = listOfRecords[i];
                var quantity = listItem.StockQuantity;
                var minStock = listItem.MinStock;
                var maxStock = listItem.MaxStock;

                if (quantity > 0 && quantity >= minStock && quantity <= maxStock)
                    listItem.StockResume = "OK";

                if (quantity > maxStock)
                    listItem.StockResume = "Alto";

                if (quantity < minStock)
                    listItem.StockResume = "Baixo";

                if (quantity == 0 & minStock == 0 && maxStock == 0)
                    listItem.StockResume = "???";
            }
        }

        #endregion

        #region SetResult()
        public void SetResult(List<BllStockProduct> listOfRecords)
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
        #endregion 

        #region GetRegistryData()
        public void GetRegistryData(int id)
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
        #endregion

        #region PassDataTableToList()

        private void PassDataTableToList(DataTable dataTable)
        {
            var stockProductList = new List<BllStockProduct>();

            foreach (DataRow row in dataTable.Rows)
            {
                var stockProduct = new BllStockProduct
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
