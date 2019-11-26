using SysEstoque.Auxiliary;
using SysEstoque.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace SysEstoque.Model
{
    public class MdlEstoqueAtividade
    {
        #region Propriedades
        private readonly BllEstoqueAtividade estoqueAtividade;
        #endregion

        #region Construtores
        public MdlEstoqueAtividade() { }

        public MdlEstoqueAtividade(BllEstoqueAtividade estoqueAtividade)
        {
            this.estoqueAtividade = estoqueAtividade;
        }
        #endregion

        #region Adicionar()
        public bool Adicionar()
        {
            bool adicionar = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"INSERT INTO TBEstoqueAtividade(Tipo, Data, Hora, Situacao)
                VALUES(@Tipo, @Data, @Hora, @Situacao)";

                connection.AddParameter("@Tipo", OleDbType.VarChar, estoqueAtividade.Tipo);
                connection.AddParameter("@Data", OleDbType.Date, estoqueAtividade.Data);
                connection.AddParameter("@Hora", OleDbType.VarChar, estoqueAtividade.Hora);
                connection.AddParameter("@Situacao", OleDbType.VarChar, estoqueAtividade.Situacao);

                if (connection.ExecuteNonQuery(sql) > 0)
                {
                    estoqueAtividade.Id = Convert.ToInt32(connection.ExecuteScalar(@"SELECT MAX(Id) FROM TBEstoqueAtividade"));

                    if (estoqueAtividade.Id > 0)
                    {
                        adicionar = true;
                    }

                }

                return adicionar;
            }
        }
        #endregion

        #region AdicionarDestino()
        public bool AdicionarDestino(int id)
        {
            bool adicionar = false;

            if (estoqueAtividade.Destino != "")
            {
                using (MdlAccessConnection connection = new MdlAccessConnection())
                {
                    var sql = @"UPDATE TBEstoqueAtividade SET Destino = @Destino WHERE Id =" + id;

                    connection.AddParameter("@Destino", OleDbType.VarChar, estoqueAtividade.Destino);

                    adicionar = connection.ExecuteNonQuery(sql) > 0;

                }
            }

            return adicionar;
        }
        #endregion

        #region Deletar()
        public bool Deletar(int id)
        {
            bool deletar = false;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var commandSQL = @"DELETE FROM TBEstoqueAtividade WHERE Id = " + id;

                if (connection.ExecuteNonQuery(commandSQL) > 0)
                {
                    BllNotificar.Message = "Atividade deletada com sucesso!";
                    deletar = true;
                }
                else
                {
                    BllNotificar.Message = "Essa atividade já foi deletada, " +
                    "atualize a lista de dados!";
                }
            }

            return deletar;
        }
        #endregion 

        #region AtualizarSituacao()
        public bool AtualizarSituacao(MdlAccessConnection connection, int idEstoqueAtividade)
        {
            var sql = @"UPDATE TBEstoqueAtividade Set Situacao = 'Finalizada' Where Id = " + idEstoqueAtividade;
            var transacao = false;

            if (connection.ExecuteTransaction(sql) > 0)
            {
                BllUsuarioHistorico historico = new BllUsuarioHistorico()
                {
                    Login = AxlLogin.Login,
                    Operacao = "Confirmou",
                    Modulo = "Atividade",
                    Data = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    Hora = DateTime.Now.ToString("HH:mm:ss"),
                    DadosRegistroAfetado = PegarDadosAfetados(idEstoqueAtividade)
                };
                if (historico.Registrar() == true)
                {
                    transacao = true;
                }
            }

            return transacao;
        }
        #endregion

        #region Listar()
        public List<BllEstoqueAtividade> Listar(int numeroDeRegistros = 100)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var sql = @"SELECT TOP " + numeroDeRegistros + " * From TBEstoqueAtividade";

                List<BllEstoqueAtividade> listaEstoqueAtividade = new List<BllEstoqueAtividade>();

                using (OleDbDataReader dr = connection.QueryWithDataReader(sql))
                {
                    while (dr.Read())
                    {
                        BllEstoqueAtividade estoqueAtividade = new BllEstoqueAtividade()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Tipo = dr["Tipo"].ToString(),
                            Data = Convert.ToDateTime(dr["Data"]),
                            Hora = dr["Hora"].ToString(),
                            Situacao = dr["Situacao"].ToString(),
                        };

                        listaEstoqueAtividade.Add(estoqueAtividade);

                    }
                }

                return listaEstoqueAtividade;
            }
        }
        #endregion

        #region Consultar()
        public List<BllEstoqueAtividade> Consultar
        (string numeroAtividade, string tipo, string operacao, string dataInicio, string dataFinal, int numeroRegistros = 100)
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var commandSQL = @"SELECT TOP " + numeroRegistros +
                @" * From TBEstoqueAtividade WHERE Data >= @DataInicio AND Data <= @DataFinal";

                var criterio = "";

                if (numeroAtividade != "")
                    criterio += " And Id LIKE @Id";

                if (tipo != "")
                    criterio += " And Tipo LIKE @Tipo";

                if (operacao != "")
                    criterio += " And Situacao LIKE @Situacao";

                commandSQL += criterio;

                var e = connection.Command.Parameters;
                e.AddWithValue("@DataInicio", string.Format("{0}", dataInicio));
                e.AddWithValue("@DataFinal", string.Format("{0}", dataFinal));

                if (numeroAtividade != "")
                    e.AddWithValue("@Id", string.Format("{0}", numeroAtividade));

                if (tipo != "")
                    e.AddWithValue("@Tipo", string.Format("{0}", tipo));

                if (operacao != "")
                    e.AddWithValue("@Situacao", string.Format("{0}", operacao));

                List<BllEstoqueAtividade> listaEstoqueAtividade = new List<BllEstoqueAtividade>();

                using (OleDbDataReader dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        BllEstoqueAtividade estoqueAtividade = new BllEstoqueAtividade()
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Tipo = dr["Tipo"].ToString(),
                            Data = Convert.ToDateTime(dr["Data"]),
                            Hora = dr["Hora"].ToString(),
                            Situacao = dr["Situacao"].ToString(),
                        };

                        listaEstoqueAtividade.Add(estoqueAtividade);

                    }
                }

                return listaEstoqueAtividade;
            }
        }
        #endregion

        #region GetDetalhesAtividade()
        public void GetDetalhesAtividade(int id)
        {
            var sql = @"SELECT * FROM TBEstoqueAtividade WHERE Id = " + id;

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (OleDbDataReader dr = connection.QueryWithDataReader(sql))
                {
                    while (dr.Read())
                    {
                        estoqueAtividade.Id = Convert.ToInt32(dr["Id"]);
                        estoqueAtividade.Tipo = Convert.ToString(dr["Tipo"]);
                        estoqueAtividade.Data = Convert.ToDateTime(dr["Data"]);
                        estoqueAtividade.Hora = Convert.ToString(dr["Hora"]);
                        estoqueAtividade.Situacao = Convert.ToString(dr["Situacao"]);
                        estoqueAtividade.Destino = Convert.ToString(dr["Destino"]);
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

                var commandSQL = @"SELECT * From TBEstoqueAtividade Where Id = " + id;

                List<string> listaAtividade = new List<string>();

                using (OleDbDataReader dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        listaAtividade.Add("Id:" + dr["Id"].ToString());
                        listaAtividade.Add("Tipo:" + dr["Tipo"].ToString());
                        listaAtividade.Add("Data:" + Convert.ToDateTime(dr["Data"]).ToString("dd-MM-yyyy"));
                        listaAtividade.Add("Hora:" + dr["Hora"].ToString());
                        listaAtividade.Add("Situacao:" + dr["Situacao"].ToString());
                    }
                }

                return string.Join(" | ", listaAtividade.Select(x => x.ToString()));
            }
        }
        #endregion
    }
}
