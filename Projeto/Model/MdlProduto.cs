using SysEstoque.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace SysEstoque.Model
{
    public class MdlProduto
    {
        #region Properties Privadas
        private readonly BllProduto produto;
        #endregion 

        #region Construtores
        public MdlProduto()
        {
        }

        public MdlProduto(BllProduto produto)
        {
            this.produto = produto;
        }
        #endregion 

        #region Registrar()
        public bool Registrar()
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (connection.Transaction = connection.OpenConnection().BeginTransaction())
                {
                    var commandSQL = @"INSERT INTO TBProduto(Nome, Descricao, Codigo, Tamanho, Referencia, PrecoCusto, 
                        PrecoVenda, EstoqueMin, EstoqueMax, CodigoBarras, FotoNome)VALUES(@Nome, @Descricao, @Codigo, @Tamanho, 
                        @Referencia, @PrecoCusto, @PrecoVenda, @EstoqueMin, @EstoqueMax, @CodigoBarras, @FotoNome)";

                    connection.AddParameter("@Nome", OleDbType.VarChar, produto.Nome);
                    connection.AddParameter("@Descricao", OleDbType.VarChar, produto.Descricao);
                    connection.AddParameter("@Codigo", OleDbType.VarChar, produto.Codigo);
                    connection.AddParameter("@Tamanho", OleDbType.VarChar, produto.Tamanho);
                    connection.AddParameter("@Referencia", OleDbType.VarChar, produto.Referencia);
                    connection.AddParameter("@PrecoCusto", OleDbType.Double, produto.PrecoCusto);
                    connection.AddParameter("@PrecoVenda", OleDbType.Double, produto.PrecoVenda);
                    connection.AddParameter("@EstoqueMin", OleDbType.Integer, produto.EstoqueMin);
                    connection.AddParameter("@EstoqueMax", OleDbType.Integer, produto.EstoqueMax);
                    connection.AddParameter("@CodigoBarras", OleDbType.VarChar, produto.CodigoBarras);
                    connection.AddParameter("@FotoNome", OleDbType.VarChar, produto.FotoNome);

                    bool trasacao = false;

                    if (connection.ExecuteTransaction(commandSQL) > 0)
                    {
                        produto.Id = Convert.ToInt32(connection.ExecuteScalar("SELECT MAX(Id) From TBProduto"));

                        MdlEstoque estoque = new MdlEstoque();

                        if (estoque.RelacionarProduto(connection, produto.Id) == true)
                        {
                            connection.Transaction.Commit();
                            trasacao = true;
                            BllNotificar.Message = "Produto cadastrado com sucesso!";
                        }
                    }

                    return trasacao;
                }
            }
        }
        #endregion

        #region Alterar()
        public bool Alterar(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (connection.Transaction = connection.OpenConnection().BeginTransaction())
                {

                    var commandSQL = @"UPDATE TBProduto Set Nome = @Nome, Descricao = @Descricao, Codigo = @Codigo, Tamanho = @Tamanho,
                    Referencia = @Referencia , PrecoCusto = @PrecoCusto, PrecoVenda = @PrecoVenda, EstoqueMin = @EstoqueMin, EstoqueMax = @EstoqueMax, 
                    CodigoBarras = @CodigoBarras , FotoNome = @FotoNome Where Id = " + id;

                    connection.AddParameter("@Nome", OleDbType.VarChar, produto.Nome);
                    connection.AddParameter("@Descricao", OleDbType.VarChar, produto.Descricao);
                    connection.AddParameter("@Codigo", OleDbType.VarChar, produto.Codigo);
                    connection.AddParameter("@Tamanho", OleDbType.VarChar, produto.Tamanho);
                    connection.AddParameter("@Referecia", OleDbType.VarChar, produto.Referencia);
                    connection.AddParameter("@PrecoCusto", OleDbType.Double, produto.PrecoCusto);
                    connection.AddParameter("@PrecoVenda", OleDbType.Double, produto.PrecoVenda);
                    connection.AddParameter("@EstoqueMin", OleDbType.Integer, produto.EstoqueMin);
                    connection.AddParameter("@EstoqueMax", OleDbType.Integer, produto.EstoqueMax);
                    connection.AddParameter("@CodigoBarras", OleDbType.VarChar, produto.CodigoBarras);
                    connection.AddParameter("@FotoNome", OleDbType.VarChar, produto.FotoNome);

                    bool transacao = false;

                    if (connection.ExecuteTransaction(commandSQL) > 0)
                    {
                        var precoCusto = Convert.ToDouble(connection.ExecuteScalar(
                        "SELECT precoCusto FROM TBProduto WHERE Id = " + id));

                        MdlEstoque estoque = new MdlEstoque();

                        if (estoque.AtualizarValor(connection, precoCusto, id) == true)
                        {
                            connection.Transaction.Commit();
                            transacao = true;
                            BllNotificar.Message = "Produto alterado com sucesso!";
                        }
                    };

                    return transacao;
                }
            }
        }
        #endregion

        #region Deletar()
        public bool Deletar(int id)
        {
            var delete = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                if (connection.ExecuteNonQuery("DELETE From TBProduto WHERE Id = " + id) > 0)
                {
                    BllNotificar.Message = "Produto deletado com sucesso!";
                    delete = true;
                }
                else
                {
                    BllNotificar.Message = @"Esse produto já foi deletado, 
                    atualize a lista de dados!";
                }
            }

            return delete;
        }
        #endregion

        #region Listar()
        public List<BllProduto> Listar(int numeroDeRegistros = 100)
        {
            var sql = @"SELECT TOP " + numeroDeRegistros + @" Id, Codigo, Nome, Referencia, Descricao, 
            Tamanho, PrecoCusto, PrecoVenda, FotoNome From TBProduto Order By Codigo, Tamanho, Referencia Asc";

            List<BllProduto> listaProdutos = new List<BllProduto>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
                {
                    while (dr.Read())
                    {
                        BllProduto produto = new BllProduto
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Codigo = Convert.ToString(dr["Codigo"]),
                            Referencia = Convert.ToString(dr["Referencia"]),
                            Nome = Convert.ToString(dr["Nome"]),
                            Descricao = Convert.ToString(dr["Descricao"]),
                            Tamanho = Convert.ToString(dr["Tamanho"]),
                            PrecoCusto = Convert.ToDouble(dr["PrecoCusto"]),
                            PrecoVenda = Convert.ToDouble(dr["PrecoVenda"]),
                            FotoNome = Convert.ToString(dr["FotoNome"])
                        };

                        listaProdutos.Add(produto);
                    }
                }

                return listaProdutos;
            }
        }
        #endregion

        #region Consultar()
        public List<BllProduto> Consultar(string codigo, string tamanho, string referencia, string descricao, int numeroDeRegistros = 100)
        {

            List<BllProduto> ListaProduto = new List<BllProduto>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {

                var sqlFiltrar = @"SELECT TOP " + numeroDeRegistros + @" Id, Codigo, Nome, Referencia, Descricao, 
                Tamanho, PrecoCusto, PrecoVenda, FotoNome From TBProduto WHERE Codigo LIKE @Codigo AND Tamanho LIKE @Tamanho
                AND Referencia LIKE @Referencia AND Descricao LIKE @Descricao Order By Codigo, Tamanho, Referencia Asc";

                var e = connection.Command.Parameters;
                e.AddWithValue("@Codigo", string.Format("%{0}", codigo));
                e.AddWithValue("@Tamanho", string.Format("%{0}", tamanho));
                e.AddWithValue("@Referencia", string.Format("%{0}", referencia));
                e.AddWithValue("@Descricao", string.Format("%{0}%", descricao));

                using (OleDbDataReader dr = connection.ExecuteParameterQuery(sqlFiltrar))
                {
                    while (dr.Read())
                    {
                        BllProduto produto = new BllProduto
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Codigo = Convert.ToString(dr["Codigo"]),
                            Referencia = Convert.ToString(dr["Referencia"]),
                            Nome = Convert.ToString(dr["Nome"]),
                            Descricao = Convert.ToString(dr["Descricao"]),
                            Tamanho = Convert.ToString(dr["Tamanho"]),
                            PrecoCusto = Convert.ToDouble(dr["PrecoCusto"]),
                            PrecoVenda = Convert.ToDouble(dr["PrecoVenda"]),
                            FotoNome = Convert.ToString(dr["FotoNome"])
                        };

                        ListaProduto.Add(produto);
                    }
                }

                return ListaProduto;
            }
        }
        #endregion

        #region VisualizarDados()
        public void VisualizarDados(int id)
        {

            var sql = @"SELECT Id, Codigo, Referencia, CodigoBarras, Nome, Descricao, Tamanho, PrecoCusto,
                PrecoVenda, EstoqueMin, EstoqueMax, FotoNome From TBProduto Where Id = " + id;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (OleDbDataReader dr = connection.ExecuteQuery(sql))
                {
                    while (dr.Read())
                    {
                        produto.Id = Convert.ToInt32(dr["Id"]);
                        produto.Codigo = dr["Codigo"].ToString();
                        produto.Referencia = dr["Referencia"].ToString();
                        produto.CodigoBarras = dr["CodigoBarras"].ToString();
                        produto.Nome = dr["Nome"].ToString();
                        produto.Descricao = dr["Descricao"].ToString();
                        produto.Tamanho = dr["Tamanho"].ToString();
                        produto.PrecoCusto = Convert.ToDouble(dr["PrecoCusto"]);
                        produto.PrecoVenda = Convert.ToDouble(dr["PrecoVenda"]);
                        produto.EstoqueMin = Convert.ToInt32(dr["EstoqueMin"]);
                        produto.EstoqueMax = Convert.ToInt32(dr["EstoqueMax"]);
                        produto.FotoNome = dr["FotoNome"].ToString();
                    }
                }
            }
        }
        #endregion

        #region PegarDadosAfetados()
        public string PegarDadosAfetados(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {

                var commandSQL = @"SELECT * From TBProduto Where Id = " + id;

                List<string> ListaProduto = new List<string>();

                using (OleDbDataReader dr = connection.ExecuteQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        ListaProduto.Add("Id:" + dr["Id"].ToString());
                        ListaProduto.Add("Código:" + dr["Codigo"].ToString());
                        ListaProduto.Add("Referência:" + dr["Referencia"].ToString());
                        ListaProduto.Add("Nome:" + dr["Nome"].ToString());
                        ListaProduto.Add("Descrição:" + dr["Descricao"].ToString());
                        ListaProduto.Add("Tamanho:" + dr["Tamanho"].ToString());
                        ListaProduto.Add("PreçoCusto:" + dr["PrecoCusto"].ToString());
                        ListaProduto.Add("PreçoVenda:" + dr["PrecoVenda"].ToString());
                        ListaProduto.Add("CódigoBarras:" + dr["CodigoBarras"].ToString());
                        ListaProduto.Add("FotoNome:" + dr["FotoNome"].ToString());
                    }
                }

                return string.Join(" | ", ListaProduto.Select(x => x.ToString()));
            }
        }
        #endregion

        #region ChegarSeCodigoProdutoExiste()
        public bool ChegarSeCodigoProdutoExiste()
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                string commandSQL = @"SELECT Codigo FROM TBProduto WHERE Codigo LIKE '" + produto.Codigo + "'";
                int cont = 0;

                using (OleDbDataReader dr = connection.ExecuteQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        cont = +1;
                    }
                }
                return cont > 0;
            }
        }
        #endregion 
    }
}

