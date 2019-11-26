using SysEstoque.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace SysEstoque.Model
{
    public class MdlUsuarioHistorico
    {
        #region Propriedades
        private readonly BllUsuarioHistorico historico;
        #endregion

        #region Construtores
        public MdlUsuarioHistorico()
        {

        }

        public MdlUsuarioHistorico(BllUsuarioHistorico historico)
        {
            this.historico = historico;
        }
        #endregion

        #region Cadastrar()
        public bool Cadastrar()
        {
            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                var commandSQL = @"INSERT INTO TBUsuarioHistorico(Login, Operacao, Modulo, Data, Hora, 
                DadosRegistroAfetado)VALUES(@Login, @Operacao, @Modulo, @Data, @Hora, @DadosRegistroAfetado)";

                connection.AddParameter("@Login", OleDbType.VarChar, historico.Login);
                connection.AddParameter("@Operacao", OleDbType.VarChar, historico.Operacao);
                connection.AddParameter("@Modulo", OleDbType.VarChar, historico.Modulo);
                connection.AddParameter("@Data", OleDbType.Date, historico.Data);
                connection.AddParameter("@Hora", OleDbType.VarChar, historico.Hora);
                connection.AddParameter("@DadosRegistroAfetado", OleDbType.VarChar, historico.DadosRegistroAfetado);

                return connection.ExecuteNonQuery(commandSQL) > 0;

            }
        }
        #endregion

        #region Listar()
        public List<BllUsuarioHistorico> Listar(int quantidadeRegistros = 100)
        {
            var commandSQL = @"SELECT TOP " + quantidadeRegistros + @" * FROM TBUsuarioHistorico";

            List<BllUsuarioHistorico> listaHistorico = new List<BllUsuarioHistorico>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {
                using (OleDbDataReader dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        BllUsuarioHistorico historico = new BllUsuarioHistorico
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Login = Convert.ToString(dr["Login"]),
                            Operacao = Convert.ToString(dr["Operacao"]),
                            Modulo = Convert.ToString(dr["Modulo"]),
                            Data = Convert.ToDateTime(dr["Data"]),
                            Hora = Convert.ToString(dr["Hora"]),
                            DadosRegistroAfetado = Convert.ToString(dr["DadosRegistroAfetado"])
                        };

                        listaHistorico.Add(historico);
                    }
                }
            }

            return listaHistorico;
        }
        #endregion

        #region Consultar()
        public List<BllUsuarioHistorico> Consultar(string login, string dataInicio, string dataFinal, int quantidadeRegistros = 100)
        {
            var commandSQL = @"SELECT * FROM TBUsuarioHistorico WHERE Login LIKE @Login AND Data >= @Data1 AND Data <= @Data2";

            List<BllUsuarioHistorico> listaHistorico = new List<BllUsuarioHistorico>();

            using (MdlAccessConnection connection = new MdlAccessConnection())
            {

                var e = connection.Command.Parameters;
                e.AddWithValue("@Login", string.Format("%{0}%", login));
                e.AddWithValue("@Data1", string.Format("{0}", dataInicio));
                e.AddWithValue("@Data2", string.Format("{0}", dataFinal));

                using (OleDbDataReader dr = connection.ExecuteParameterQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        BllUsuarioHistorico historico = new BllUsuarioHistorico
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Login = Convert.ToString(dr["Login"]),
                            Operacao = Convert.ToString(dr["Operacao"]),
                            Modulo = Convert.ToString(dr["Modulo"]),
                            Data = Convert.ToDateTime(dr["Data"]),
                            Hora = Convert.ToString(dr["Hora"]),
                            DadosRegistroAfetado = Convert.ToString(dr["DadosRegistroAfetado"])
                        };

                        listaHistorico.Add(historico);
                    }
                }
            }

            return listaHistorico;
        }
        #endregion
    }
}
