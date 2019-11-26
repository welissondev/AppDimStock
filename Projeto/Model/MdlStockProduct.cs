using SysEstoque.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace SysEstoque.Model
{
    public class MdlStockProduct
    {
        #region Properties
        private BllStockProduct stockProduct;
        #endregion

        #region Constructors
        public MdlStockProduct() { }

        public MdlStockProduct(BllStockProduct stockProduct)
        {
            this.stockProduct = stockProduct;
        }
        #endregion 

        #region Filter()
        public List<BllStockProduct> Filter(string code, string size, string reference, 
            string description, int numberOfRecords = 100)
        {

            List<BllStockProduct> listaEstoqueProduto = new List<BllStockProduct>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
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
                            ProductCode = Convert.ToString(dr["Codigo"]),
                            ProductReference = Convert.ToString(dr["Referencia"]),
                            ProductSize = Convert.ToString(dr["Tamanho"]),
                            ProductDescription = Convert.ToString(dr["Descricao"]),
                            MinStock = Convert.ToInt32(dr["EstoqueMin"]),
                            MaxStock = Convert.ToInt32(dr["EstoqueMax"]),
                            StockQuantity = Convert.ToInt32(dr["Quantidade"]),
                            StockValue = Convert.ToDouble(dr["Valor"]),
                            ProductCostPrice = Convert.ToDouble(dr["PrecoCusto"]),
                            ProductPhotoName = Convert.ToString(dr["FotoNome"]),
                        };

                        listaEstoqueProduto.Add(estoqueProduto);
                    }
                }

                return listaEstoqueProduto;
            }
        }
        #endregion

        #region FetchData()
        public DataTable FetchData(string code, string size, string reference,
            string description, string resume = "Todos", int startReg = 0, int maxReg = 10)
        {
            using (var con = new MdlAccessConnection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;

                #region Comandos-SQL

                if (resume == "Todos")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE TBEstoque.Id > 0";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE TBEstoque.Id > 0";
                }

                if (resume == "Sem Resumo")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade = 0 AND EstoqueMax = 0 AND EstoqueMin = 0";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade = 0 AND EstoqueMax = 0 AND EstoqueMin = 0";
                }

                if (resume == "Ok")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBProduto.Id = TBEstoque.IdProduto WHERE Quantidade > 0 AND Quantidade >= 
                    EstoqueMin AND Quantidade <= EstoqueMax";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > 0 AND Quantidade >= EstoqueMin AND Quantidade <= EstoqueMax";
                }

                if (resume == "Alto")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > EstoqueMax";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > EstoqueMax";
                }

                if (resume == "Baixo")
                {
                    sqlCount = @"SELECT COUNT(TBEstoque.Id) From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade < EstoqueMin";

                    sqlQuery = @"SELECT TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade < EstoqueMin";
                }
                #endregion

                #region Critério-de-consulta

                if (description != string.Empty)
                    criterion += " AND Descricao LIKE @Descricao";

                if (code != string.Empty)
                    criterion += " AND Codigo LIKE @Codigo ";

                if (size != string.Empty)
                    criterion += " AND Tamanho LIKE @Tamanho ";

                if (reference != string.Empty)
                    criterion += " AND Referencia LIKE @Referencia ";

                sqlQuery += criterion +
                " Order By Codigo, Tamanho, Referencia Asc";

                sqlCount += criterion;

                #endregion

                #region Critério-de-parametros
                var p = con.Command.Parameters;

                if (description != string.Empty)
                    p.AddWithValue("@Descricao", string.Format("%{0}%", description));

                if (code != "")
                    p.AddWithValue("@Codigo", string.Format("{0}", code));

                if (size != "")
                    p.AddWithValue("@Tamanho", string.Format("{0}", size));

                if (reference != "")
                    p.AddWithValue("@Referencia", string.Format("{0}", reference));
                #endregion

                #region Contagem-de-registros
                stockProduct.RecordCount = Convert.ToInt32(con.ExecuteScalar(sqlCount));
                #endregion

                #region Preencher-Datatable
                var dataTable = con.QueryWithDataTable(sqlQuery, startReg, maxReg);
                #endregion

                return dataTable;
            }
        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {

            var sql = @"SELECT TBProduto.*, TBEstoque.* From TBProduto INNER JOIN TBEstoque ON TBProduto.Id = TBEstoque.IdProduto
            WHERE TBProduto.Id = " + id;

            using (var con = new MdlAccessConnection())
            {
                using (var dr = con.QueryWithDataReader(sql))
                {
                    while (dr.Read())
                    {
                        stockProduct.StockId = Convert.ToInt32(dr["TBEstoque.Id"]);
                        stockProduct.ProductId = Convert.ToInt32(dr["TBProduto.Id"]);
                        stockProduct.ProductCode = Convert.ToString(dr["Codigo"]);
                        stockProduct.ProductDescription = dr["Descricao"].ToString();
                        stockProduct.ProductReference = dr["Referencia"].ToString();
                        stockProduct.ProductSize = dr["Tamanho"].ToString();
                        stockProduct.ProductCostPrice = Convert.ToDouble(dr["PrecoCusto"]);
                        stockProduct.StockQuantity = Convert.ToInt32(dr["Quantidade"]);
                    }
                }
            }
        }
        #endregion
    }
}
