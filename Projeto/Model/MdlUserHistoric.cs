using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data;
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
        public void FechData()
        {
            var commandSQL = string.Empty;
            var criterion = string.Empty;

            using (var connection = new MdlConnection())
            {

                var parameter = connection.Command.Parameters;

                #region QueryPadrão

                commandSQL = @"SELECT * FROM TBUsuarioHistorico WHERE Id > 0";

                #endregion 

                #region Ciretório + DataInicio e DataFinal

                if(historic.QueryByStartDate != string.Empty && 
                historic.QueryByFinalDate != string.Empty)
                {
                    criterion += " AND Data >= @StartDate And Data <= @FinalDate";

                    parameter.AddWithValue("@StartDate", string.Format("{0}",
                    historic.QueryByStartDate));

                    parameter.AddWithValue("@FinalDate", string.Format("{0}",
                    historic.QueryByFinalDate));
                }

                #endregion

                #region Critério + Login

                if(historic.QueryByLogin != string.Empty)
                {
                    criterion += " AND Login LIKE @Login ";

                    parameter.AddWithValue("@Login", string.Format("%{0}%",
                    historic.QueryByLogin));
                }

                #endregion 

                #region SqlCommand + Critério

                commandSQL += criterion;

                #endregion

                #region DataTable

                var dataTable = connection.QueryWithDataTable(commandSQL,
                historic.DataPagination.OffSetValue,
                historic.DataPagination.PageSize);

                PassDataTableForList(dataTable);

                #endregion 
            }
        }
        #endregion

        #region PassDataTableForList()
        private void PassDataTableForList(DataTable dataTable)
        {
            var historicList = new List<BllUserHistoric>();

            foreach (DataRow row in dataTable.Rows)
            {
                var historic = new BllUserHistoric
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Login = Convert.ToString(row["Login"]),
                    OperationType = Convert.ToString(row["Operacao"]),
                    Module = Convert.ToString(row["Modulo"]),
                    OperationDate = Convert.ToDateTime(row["Data"]),
                    OperationHour = Convert.ToString(row["Hora"]),
                    DataFromAffectedRecord = Convert.ToString(row["DadosRegistroAfetado"])
                };

                historicList.Add(historic);
            }

            historic.ListOfRecords = historicList;
        }
        #endregion 
    }
}
