using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Model
{
    public class MdlUserHistoric
    {
        #region Properties
        private readonly BllUserHistoric historic;
        #endregion

        #region Constructs
        public MdlUserHistoric()
        {

        }

        public MdlUserHistoric(BllUserHistoric historic)
        {
            this.historic = historic;
        }
        #endregion

        #region Register()
        public bool Register()
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @"INSERT INTO TBUsuarioHistorico(Login, Operacao, Modulo, Data, Hora, 
                DadosRegistroAfetado)VALUES(@Login, @Operacao, @Modulo, @Data, @Hora, @DadosRegistroAfetado)";

                connection.AddParameter("@Login", OleDbType.VarChar, historic.Login);
                connection.AddParameter("@Operacao", OleDbType.VarChar, historic.OperationType);
                connection.AddParameter("@Modulo", OleDbType.VarChar, historic.Module);
                connection.AddParameter("@Data", OleDbType.Date, historic.OperationDate);
                connection.AddParameter("@Hora", OleDbType.VarChar, historic.OperationHour);
                connection.AddParameter("@DadosRegistroAfetado", OleDbType.VarChar, historic.DataFromAffectedRecord);

                return connection.ExecuteNonQuery(commandSQL) > 0;

            }
        }
        #endregion

        #region ListAll()
        public List<BllUserHistoric> ListAll(int numberOfRecords = 100)
        {
            var commandSQL = @"SELECT TOP " + numberOfRecords + @" * FROM TBUsuarioHistorico";

            var historicsList = new List<BllUserHistoric>();

            using (var connection = new MdlConnection())
            {
                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        var historic = new BllUserHistoric
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Login = Convert.ToString(dr["Login"]),
                            OperationType = Convert.ToString(dr["Operacao"]),
                            Module = Convert.ToString(dr["Modulo"]),
                            OperationDate = Convert.ToDateTime(dr["Data"]),
                            OperationHour = Convert.ToString(dr["Hora"]),
                            DataFromAffectedRecord = Convert.ToString(dr["DadosRegistroAfetado"])
                        };

                        historicsList.Add(historic);
                    }
                }
            }

            return historicsList;
        }
        #endregion

        #region FechData()
        public List<BllUserHistoric> FechData(string login, string startDate, string finalDate, int numberOfRecords = 100)
        {
            var commandSQL = @"SELECT * FROM TBUsuarioHistorico WHERE Login LIKE @Login AND Data >= @Data1 AND Data <= @Data2";

            var historicsList = new List<BllUserHistoric>();

            using (var connection = new MdlConnection())
            {

                var e = connection.Command.Parameters;
                e.AddWithValue("@Login", string.Format("%{0}%", login));
                e.AddWithValue("@Data1", string.Format("{0}", startDate));
                e.AddWithValue("@Data2", string.Format("{0}", finalDate));

                using (var dr = connection.ExecuteParameterQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        var historic = new BllUserHistoric
                        {
                            Id = Convert.ToInt32(dr["Id"]),
                            Login = Convert.ToString(dr["Login"]),
                            OperationType = Convert.ToString(dr["Operacao"]),
                            Module = Convert.ToString(dr["Modulo"]),
                            OperationDate = Convert.ToDateTime(dr["Data"]),
                            OperationHour = Convert.ToString(dr["Hora"]),
                            DataFromAffectedRecord = Convert.ToString(dr["DadosRegistroAfetado"])
                        };

                        historicsList.Add(historic);
                    }
                }
            }

            return historicsList;
        }
        #endregion
    }
}
