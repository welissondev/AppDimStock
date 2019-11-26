using SysEstoque.Business;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace SysEstoque.Model
{
    public class MdlEstoque
    {
        #region Propriedades
        private readonly BllEstoque estoque;
        #endregion 

        #region Construtores
        public MdlEstoque() { }

        public MdlEstoque(BllEstoque estoque)
        {
            this.estoque = estoque;
        }
        #endregion 

        #region AdicionarEntradas()
        public bool AdicionarEntradas(List<BllEstoque> listaEstoque, int idEstoqueAtividade)
        {
            bool transacao = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    for (int item = 0; item < listaEstoque.Count; item++)
                    {

                        var idEstoque = listaEstoque[item].Id;
                        var quantidade = listaEstoque[item].Quantidade;
                        var valorTotal = listaEstoque[item].Valor;

                        var commandSQL = @"UPDATE TBEstoque Set Quantidade = Quantidade + '" + quantidade +
                        "', Valor = Valor + '" + valorTotal + "' WHERE Id = " + idEstoque;

                        connection.ExecuteTransaction(commandSQL);
                    }

                    MdlEstoqueAtividade atividade = new MdlEstoqueAtividade();

                    if (atividade.AtualizarSituacao(connection, idEstoqueAtividade) == true)
                    {
                        connection.Transaction.Commit();
                        transacao = true;
                        BllNotificar.Message = "OK! todos os estoques foram adicionados!";
                    }

                    return transacao;
                }
            }
        }
        #endregion

        #region AdicionarSaidas()
        public bool AdicionarSaidas(List<BllEstoque> listaEstoque, int idEstoqueAtividade)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    for (int item = 0; item < listaEstoque.Count; item++)
                    {

                        var idEstoque = listaEstoque[item].Id;
                        var quantidade = listaEstoque[item].Quantidade;
                        var valorTotal = listaEstoque[item].Valor;

                        var commandSQL = @"UPDATE TBEstoque Set Quantidade = Quantidade - '" + quantidade +
                        "', Valor = Valor - '" + valorTotal + "' WHERE Id = " + idEstoque;

                        connection.ExecuteTransaction(commandSQL);
                    }

                    MdlEstoqueAtividade estoqueAtividade = new MdlEstoqueAtividade();
                    estoqueAtividade.AtualizarSituacao(connection, idEstoqueAtividade);

                    connection.Transaction.Commit();

                    BllNotificar.Message = "Ok! Todos os estoque foram removidos!";

                    return true;
                }
            }
        }
        #endregion

        #region RelacionarProduto()
        public bool RelacionarProduto(MdlAccessConnection connection, int idProduto)
        {
            var commandSQL = @"INSERT INTO TBEstoque(IdProduto)VALUES(@IdProduto)";

            connection.ParameterClear();
            connection.AddParameter("@IdProduto", OleDbType.Integer, idProduto);

            var transacao = false;

            if (connection.ExecuteTransaction(commandSQL) > 0)
            {
                transacao = true;
            }

            return transacao;
        }
        #endregion

        #region AtualizarValor()
        public bool AtualizarValor(MdlAccessConnection connection, double produtoPrecoCusto, int idProduto)
        {
            var sql = @"UPDATE TBEstoque Set Valor = '" + produtoPrecoCusto + "' * Quantidade WHERE IdProduto = " + idProduto;
            var transacao = false;

            if (connection.ExecuteTransaction(sql) > 0)
            {
                transacao = true;
            }

            return transacao;
        }
        #endregion

        #region Reset()
        public bool Reset(List<BllEstoqueItem> listaEstoqueItem)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    for (int item = 0; item < listaEstoqueItem.Count; item++)
                    {
                        var commandSQL = @"UPDATE TBEstoque Set Quantidade = '0', Valor = '0' WHERE Id = " + listaEstoqueItem[item].IdEstoque;

                        connection.ExecuteTransaction(commandSQL);
                    }

                    connection.Transaction.Commit();

                    BllNotificar.Message = "Ok! Todos os estoques foram removidos!";

                    return true;
                }
            }
        }
        #endregion 

        #region PegarDadosAfetados()
        public string PegarDadosAfetados(int id)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {

                var commandSQL = @"SELECT * From TBEstoque Where Id = " + id;

                List<string> listaEstoque = new List<string>();

                using (OleDbDataReader dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        listaEstoque.Add("Id:" + dr["Id"].ToString());
                        listaEstoque.Add("IdProduto:" + dr["IdProduto"].ToString());
                        listaEstoque.Add("Quantidade:" + dr["Quantidade"].ToString());
                        listaEstoque.Add("Valor:" + dr["Valor"].ToString());
                    }
                }

                return string.Join(" | ", listaEstoque.Select(x => x.ToString()));
            }
        }
        #endregion
    }
}
