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
                var sqlSelectEstoqueProduto = @"SELECT TOP " + numberOfRecords + @" TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.PrecoCusto, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                TBEstoque.IdProduto = TBProduto.Id WHERE Descricao LIKE @Descricao";

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
                            StockId = Convert.ToInt32(dr["TBEstoque.Id"]),
                            ProductId = Convert.ToInt32(dr["TBProduto.Id"]),
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
                var commandSQL = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = con.Command.Parameters;
                #endregion 

                #region QueryByResume

                #region All-Resume
                if (stockProduct.QueryByResume == "All")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE TBEstoque.Id > 0";

                    commandSQL = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, 
                    TBProduto.Tamanho, TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome 
                    From TBProduto INNER JOIN TBEstoque ON TBEstoque.IdProduto = TBProduto.Id WHERE TBEstoque.Id > 0";

                }
                #endregion

                #region Nothing-Resume
                if (stockProduct.QueryByResume == "Nothing")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade = 0 AND EstoqueMax = 0 AND EstoqueMin = 0";

                    commandSQL = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade = 0 AND EstoqueMax = 0 AND EstoqueMin = 0";
                }
                #endregion

                #region Ok-Resume
                if (stockProduct.QueryByResume == "Ok")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBProduto.Id = TBEstoque.IdProduto WHERE Quantidade > 0 AND Quantidade >= 
                    EstoqueMin AND Quantidade <= EstoqueMax";

                    commandSQL = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > 0 AND Quantidade >= EstoqueMin AND Quantidade <= EstoqueMax";
                }
                #endregion

                #region High-Resume
                if (stockProduct.QueryByResume == "High")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > EstoqueMax";

                    commandSQL = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > EstoqueMax";
                }
                #endregion

                #region Low-Resume
                if (stockProduct.QueryByResume == "Low")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade < EstoqueMin";

                    commandSQL = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade < EstoqueMin";
                }
                #endregion

                #endregion

                #region QueryByCritérion

                #region Critério + Codigo
                if (stockProduct.QueryByCode != string.Empty)
                {
                    criterion += " AND Codigo LIKE @Codigo ";

                    parameter.AddWithValue("@Codigo", string.Format("{0}",
                    stockProduct.QueryByCode));
                }
                #endregion 

                #region Critério + Tamanho
                if (stockProduct.QueryBySize != string.Empty)
                {
                    criterion += " AND Tamanho LIKE @Tamanho ";

                    parameter.AddWithValue("@Tamanho", string.Format("{0}",
                    stockProduct.QueryBySize));
                }
                #endregion 

                #region Critério + Referência
                if (stockProduct.QueryByReference != string.Empty)
                {
                    criterion += " AND Referencia LIKE @Referencia";

                    parameter.AddWithValue("@Referencia", string.Format("{0}",
                    stockProduct.QueryByReference));
                }
                #endregion

                #region Critério + Descrição
                if (stockProduct.QueryByDescription != string.Empty)
                {
                    criterion += " AND Descricao LIKE @Descricao";

                    parameter.AddWithValue("@Descricao", string.Format("%{0}%",
                    stockProduct.QueryByDescription));
                }
                #endregion 

                #region CommandSql + Critério
                commandSQL += criterion + " Order By Codigo, Tamanho, Referencia Asc";
                #endregion 

                #region SqlCount + Critério
                sqlCount += criterion;
                #endregion

                #endregion 

                #region QueryRecordCount
                stockProduct.DataPagination.RecordCount = Convert.ToInt32(
                con.ExecuteScalar(sqlCount));
                #endregion

                #region FillDataTable
                var dataTable = con.QueryWithDataTable(commandSQL,
                stockProduct.DataPagination.OffSetValue,
                stockProduct.DataPagination.PageSize);
                #endregion

                #region PassDataTableToList()

                PassDataTableToList(dataTable);

                #endregion 

                #region SetResume()
                SetResume(stockProduct.ListOfRecords);
                #endregion 

                #region SetResult()
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
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE TBEstoque.Id > 0";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE TBEstoque.Id > 0";
                }
                #endregion 

                #region Nothing
                if (stockProduct.QueryByResume == "Nothing")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade = 0 AND EstoqueMax = 0 AND EstoqueMin = 0";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade = 0 AND EstoqueMax = 0 AND EstoqueMin = 0";
                }
                #endregion 

                #region Ok
                if (stockProduct.QueryByResume == "Ok")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBProduto.Id = TBEstoque.IdProduto WHERE Quantidade > 0 AND Quantidade >= 
                    EstoqueMin AND Quantidade <= EstoqueMax";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > 0 AND Quantidade >= EstoqueMin AND Quantidade <= EstoqueMax";
                }
                #endregion

                #region High
                if (stockProduct.QueryByResume == "High")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > EstoqueMax";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > EstoqueMax";
                }
                #endregion 

                #region Low
                if (stockProduct.QueryByResume == "Low")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade < EstoqueMin";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade < EstoqueMin";
                }
                #endregion

                #endregion

                #region QueryByCriterion

                #region Criterion + QueryByDescription

                if (stockProduct.QueryByDescription != string.Empty)
                {
                    criterion += " AND Descricao LIKE @Descricao";

                    parameter.AddWithValue("@Descricao", string.Format("%{0}%",
                    stockProduct.QueryByDescription));
                }

                #endregion 

                #region Criterion + QueryByCode

                if (stockProduct.QueryByCode != string.Empty)
                {
                    criterion += " AND Codigo LIKE @Codigo ";

                    parameter.AddWithValue("@Codigo", string.Format("{0}", 
                    stockProduct.QueryByCode));

                }

                #endregion

                #region Criterion + QueryBySize

                if (stockProduct.QueryBySize != string.Empty)
                {
                    criterion += " AND Tamanho LIKE @Tamanho ";

                    parameter.AddWithValue("@Tamanho", string.Format("{0}", 
                   stockProduct.QueryBySize));
                }

                #endregion

                #region Criterion + QueryByReference

                if (stockProduct.QueryByReference != string.Empty)
                {
                    criterion += " AND Referencia LIKE @Referencia ";

                    parameter.AddWithValue("@Referencia", string.Format("{0}", 
                    stockProduct.QueryByReference));
                }

                #endregion

                #endregion

                #region CommandAndCriterion

                sqlQuery += criterion + @" Order By Codigo, Tamanho, Referencia Asc";

                sqlCount += criterion;

                #endregion

                #region FillListOfRecords()

                using (var dr = connection.QueryWithDataReader(sqlQuery))
                {
                    while (dr.Read())
                    {
                        var item = new BllStockProduct
                        {
                            StockId = Convert.ToInt32(dr["TBEstoque.Id"]),
                            ProductId = Convert.ToInt32(dr["TBProduto.Id"]),
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

                        listOfRecords.Add(item);
                    }

                    stockProduct.ListOfRecords = listOfRecords;
                }
                #endregion

                #region SetResume()
                SetResume(stockProduct.ListOfRecords);
                #endregion 

                #region SetResult()
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

            var sql = @"SELECT TBProduto.*, TBEstoque.* From TBProduto INNER JOIN TBEstoque ON TBProduto.Id = TBEstoque.IdProduto
            WHERE TBProduto.Id = " + id;

            using (var con = new MdlConnection())
            {
                using (var dr = con.QueryWithDataReader(sql))
                {
                    while (dr.Read())
                    {
                        stockProduct.StockId = Convert.ToInt32(dr["TBEstoque.Id"]);
                        stockProduct.ProductId = Convert.ToInt32(dr["TBProduto.Id"]);
                        stockProduct.ProductCode = Convert.ToInt32(dr["Codigo"]);
                        stockProduct.ProductDescription = dr["Descricao"].ToString();
                        stockProduct.ProductReference = Convert.ToInt32(dr["Referencia"]);
                        stockProduct.ProductSize = Convert.ToInt32(dr["Tamanho"]);
                        stockProduct.ProductCostPrice = Convert.ToDouble(dr["PrecoCusto"]);
                        stockProduct.StockQuantity = Convert.ToInt32(dr["Quantidade"]);
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
                    StockId = Convert.ToInt32(row["TBEstoque.Id"]),
                    ProductId = Convert.ToInt32(row["TBProduto.Id"]),
                    Supplier = Convert.ToString(row["Fornecedor"]),
                    ProductCode = Convert.ToInt32(row["Codigo"]),
                    ProductReference = Convert.ToInt32(row["Referencia"]),
                    ProductSize = Convert.ToInt32(row["Tamanho"]),
                    ProductDescription = Convert.ToString(row["Descricao"]),
                    MinStock = Convert.ToInt32(row["EstoqueMin"]),
                    MaxStock = Convert.ToInt32(row["EstoqueMax"]),
                    StockQuantity = Convert.ToInt32(row["Quantidade"]),
                    StockValue = Convert.ToDouble(row["Valor"]),
                    ProductCostPrice = Convert.ToDouble(row["PrecoCusto"]),
                    ProductPhoto = Convert.ToString(row["FotoNome"]),
                };

                stockProductList.Add(stockProduct);
            }

            stockProduct.ListOfRecords = stockProductList;
        }

        #endregion 
    }
}
