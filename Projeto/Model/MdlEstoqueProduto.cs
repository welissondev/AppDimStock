using SysEstoque.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace SysEstoque.Model
{
    public class MdlEstoqueProduto
    {
        #region Propriedades
        private BllEstoqueProduto estoqueProduto;
        #endregion

        #region Construtores
        public MdlEstoqueProduto() { }

        public MdlEstoqueProduto(BllEstoqueProduto estoqueProduto)
        {
            this.estoqueProduto = estoqueProduto;
        }
        #endregion 

        #region Listar()
        public List<BllEstoqueProduto> Listar(int namberOfRecords = 100)
        {
            var sqlSelecionarEstoqueProduto = @"Select TOP " + namberOfRecords + @" TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
            TBProduto.Id, TBProduto.Descricao, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, TBProduto.EstoqueMin, 
            TBProduto.EstoqueMax, TBProduto.PrecoCusto, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON TBEstoque.IdProduto 
            = TBProduto.Id Order By Codigo, Tamanho, Referencia Asc";

            List<BllEstoqueProduto> listaEstoqueProduto = new List<BllEstoqueProduto>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {

                using (OleDbDataReader dr = connection.ExecuteQuery(sqlSelecionarEstoqueProduto))
                {
                    while (dr.Read())
                    {
                        BllEstoqueProduto estoqueProduto = new BllEstoqueProduto
                        {
                            IdEstoque = Convert.ToInt32(dr["TBEstoque.Id"]),
                            IdProduto = Convert.ToInt32(dr["TBProduto.Id"]),
                            Fornecedor = Convert.ToString(dr["Fornecedor"]),
                            CodigoProduto = Convert.ToString(dr["Codigo"]),
                            ReferenciaProduto = Convert.ToString(dr["Referencia"]),
                            TamanhoProduto = Convert.ToString(dr["Tamanho"]),
                            DescricaoProduto = Convert.ToString(dr["Descricao"]),
                            EstoqueMin = Convert.ToInt32(dr["EstoqueMin"]),
                            EstoqueMax = Convert.ToInt32(dr["EstoqueMax"]),
                            QuantidadeEstoque = Convert.ToInt32(dr["Quantidade"]),
                            ValorEstoque = Convert.ToDouble(dr["Valor"]),
                            PrecoCustoProduto = Convert.ToDouble(dr["PrecoCusto"]),
                            FotoNomeProduto = Convert.ToString(dr["FotoNome"]),
                        };

                        listaEstoqueProduto.Add(estoqueProduto);
                    }
                }

                return listaEstoqueProduto;
            }
        }
        #endregion

        #region Filtrar()
        public List<BllEstoqueProduto> Filtrar(string codigo, string tamanho, string referencia, string descricao, int numeroDeRegistros = 100)
        {

            List<BllEstoqueProduto> listaEstoqueProduto = new List<BllEstoqueProduto>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sqlSelectEstoqueProduto = @"SELECT TOP " + numeroDeRegistros + @" TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.PrecoCusto, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                TBEstoque.IdProduto = TBProduto.Id WHERE Descricao LIKE @Descricao";

                var criterio = "";

                if (codigo != "")
                    criterio += " AND Codigo LIKE @Codigo ";

                if (tamanho != "")
                    criterio += " AND Tamanho LIKE @Tamanho ";

                if (referencia != "")
                    criterio += " AND Referencia LIKE @Referencia ";

                sqlSelectEstoqueProduto += criterio + " Order By Codigo, Tamanho, Referencia Asc";

                var e = connection.Command.Parameters;
                e.AddWithValue("@Descricao", string.Format("%{0}%", descricao));

                if (codigo != "")
                    e.AddWithValue("@Codigo", string.Format("{0}", codigo));

                if (tamanho != "")
                    e.AddWithValue("@Tamanho", string.Format("{0}", tamanho));

                if (referencia != "")
                    e.AddWithValue("@Referencia", string.Format("{0}", referencia));

                using (OleDbDataReader dr = connection.ExecuteParameterQuery(sqlSelectEstoqueProduto))
                {
                    while (dr.Read())
                    {
                        BllEstoqueProduto estoqueProduto = new BllEstoqueProduto
                        {
                            IdEstoque = Convert.ToInt32(dr["TBEstoque.Id"]),
                            IdProduto = Convert.ToInt32(dr["TBProduto.Id"]),
                            Fornecedor = Convert.ToString(dr["Fornecedor"]),
                            CodigoProduto = Convert.ToString(dr["Codigo"]),
                            ReferenciaProduto = Convert.ToString(dr["Referencia"]),
                            TamanhoProduto = Convert.ToString(dr["Tamanho"]),
                            DescricaoProduto = Convert.ToString(dr["Descricao"]),
                            EstoqueMin = Convert.ToInt32(dr["EstoqueMin"]),
                            EstoqueMax = Convert.ToInt32(dr["EstoqueMax"]),
                            QuantidadeEstoque = Convert.ToInt32(dr["Quantidade"]),
                            ValorEstoque = Convert.ToDouble(dr["Valor"]),
                            PrecoCustoProduto = Convert.ToDouble(dr["PrecoCusto"]),
                            FotoNomeProduto = Convert.ToString(dr["FotoNome"]),
                        };

                        listaEstoqueProduto.Add(estoqueProduto);
                    }
                }

                return listaEstoqueProduto;
            }
        }
        #endregion

        #region FiltroDinamico()
        public List<BllEstoqueProduto> FiltroDinamico(string codigo, string tamanho, string referencia, string descricao,
        int numeroDeRegistros = 100, string resumo = "")
        {
            List<BllEstoqueProduto> listaEstoqueProduto = new List<BllEstoqueProduto>();

            var commandSQL = "";
            var criterio = "";

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {

                if (resumo == "Sem Resumo")
                    commandSQL = @"SELECT TOP " + numeroDeRegistros + @" TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.PrecoCusto, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade = 0 AND EstoqueMax = 0 AND EstoqueMin = 0";

                if (resumo == "Ok")
                    commandSQL = @"SELECT TOP " + numeroDeRegistros + @" TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.PrecoCusto, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > 0 AND Quantidade >= EstoqueMax AND Quantidade <= EstoqueMax";

                if (resumo == "Alto")
                    commandSQL = @"SELECT TOP " + numeroDeRegistros + @" TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.PrecoCusto, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade > EstoqueMax";

                if (resumo == "Baixo")
                    commandSQL = @"SELECT TOP " + numeroDeRegistros + @" TBEstoque.Id, TBProduto.Fornecedor, TBEstoque.Quantidade, TBEstoque.Valor, 
                    TBProduto.Id, TBProduto.Descricao, TBProduto.PrecoCusto, TBProduto.Codigo, TBProduto.Referencia, TBProduto.Tamanho, 
                    TBProduto.EstoqueMin, TBProduto.EstoqueMax, TBProduto.PrecoCusto, TBProduto.FotoNome From TBProduto INNER JOIN TBEstoque ON 
                    TBEstoque.IdProduto = TBProduto.Id WHERE Quantidade < EstoqueMin";


                if (codigo != "")
                    criterio += " AND Codigo LIKE @Codigo ";

                if (tamanho != "")
                    criterio += " AND Tamanho LIKE @Tamanho ";

                if (referencia != "")
                    criterio += " AND Referencia LIKE @Referencia ";

                if (descricao != "")
                    criterio += " AND Descricao LIKE @Descricao ";

                commandSQL += criterio + " Order By Codigo, Tamanho, Referencia Asc";

                var e = connection.Command.Parameters;

                if (codigo != "")
                    e.AddWithValue("@Codigo", string.Format("{0}", codigo));

                if (tamanho != "")
                    e.AddWithValue("@Tamanho", string.Format("{0}", tamanho));

                if (referencia != "")
                    e.AddWithValue("@Referencia", string.Format("{0}", referencia));

                if (descricao != "")
                    e.AddWithValue("@Descricao", string.Format("%{0}%", descricao));

                using (OleDbDataReader dr = connection.ExecuteParameterQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        BllEstoqueProduto estoqueProduto = new BllEstoqueProduto
                        {
                            IdEstoque = Convert.ToInt32(dr["TBEstoque.Id"]),
                            IdProduto = Convert.ToInt32(dr["TBProduto.Id"]),
                            Fornecedor = Convert.ToString(dr["Fornecedor"]),
                            CodigoProduto = Convert.ToString(dr["Codigo"]),
                            ReferenciaProduto = Convert.ToString(dr["Referencia"]),
                            TamanhoProduto = Convert.ToString(dr["Tamanho"]),
                            DescricaoProduto = Convert.ToString(dr["Descricao"]),
                            EstoqueMin = Convert.ToInt32(dr["EstoqueMin"]),
                            EstoqueMax = Convert.ToInt32(dr["EstoqueMax"]),
                            QuantidadeEstoque = Convert.ToInt32(dr["Quantidade"]),
                            ValorEstoque = Convert.ToDouble(dr["Valor"]),
                            PrecoCustoProduto = Convert.ToDouble(dr["PrecoCusto"]),
                            FotoNomeProduto = Convert.ToString(dr["FotoNome"]),
                        };

                        listaEstoqueProduto.Add(estoqueProduto);
                    }
                }

                return listaEstoqueProduto;
            }
        }
        #endregion

        #region Visualizar()
        public void Visualizar(int id)
        {

            var sql = @"SELECT TBProduto.*, TBEstoque.* From TBProduto INNER JOIN TBEstoque ON TBProduto.Id = TBEstoque.IdProduto
            WHERE TBProduto.Id = " + id;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
                {
                    while (dr.Read())
                    {
                        estoqueProduto.IdEstoque = Convert.ToInt32(dr["TBEstoque.Id"]);
                        estoqueProduto.IdProduto = Convert.ToInt32(dr["TBProduto.Id"]);
                        estoqueProduto.CodigoProduto = Convert.ToString(dr["Codigo"]);
                        estoqueProduto.DescricaoProduto = dr["Descricao"].ToString();
                        estoqueProduto.ReferenciaProduto = dr["Referencia"].ToString();
                        estoqueProduto.TamanhoProduto = dr["Tamanho"].ToString();
                        estoqueProduto.PrecoCustoProduto = Convert.ToDouble(dr["PrecoCusto"]);
                        estoqueProduto.QuantidadeEstoque = Convert.ToInt32(dr["Quantidade"]);
                    }
                }
            }
        }
        #endregion
    }
}
