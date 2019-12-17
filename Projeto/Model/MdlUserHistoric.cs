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
                var sqlCommand = @"INSERT INTO UserHistoric(Login, OperationType, OperationDate, OperationHour, 
                OperationModule, DataFromAffectedRecord)VALUES(@Login, @OperationType, @OperationDate, @OperationHour, 
                @Module, @DataFromAffectedRecord)";

                connection.AddParameter("@Login", OleDbType.VarChar, historic.Login);
                connection.AddParameter("@OperationType", OleDbType.VarChar, historic.OperationType);
                connection.AddParameter("@OperationDate", OleDbType.Date, historic.OperationDate);
                connection.AddParameter("@OperationHour", OleDbType.VarChar, historic.OperationHour);
                connection.AddParameter("@OperationModule", OleDbType.VarChar, historic.OperationModule);
                connection.AddParameter("@DataFromAffectedRecord", OleDbType.VarChar, historic.DataFromAffectedRecord);

                return connection.ExecuteNonQuery(sqlCommand) > 0;

            }
        }
        #endregion

        #region ListAll()
        public List<BllUserHistoric> ListAll(int numberOfRecords = 100)
        {
            var sqlQuery = @"SELECT TOP " + numberOfRecords + @" * FROM UserHistoric";

            var historicsList = new List<BllUserHistoric>();

            using (var connection = new MdlConnection())
            {
                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var historic = new BllUserHistoric
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Login = Convert.ToString(reader["Login"]),
                            OperationType = Convert.ToString(reader["OperationType"]),
                            OperationModule = Convert.ToString(reader["OperationModule"]),
                            OperationDate = Convert.ToDateTime(reader["OperationDate"]),
                            OperationHour = Convert.ToString(reader["OperationHour"]),
                            DataFromAffectedRecord = Convert.ToString(reader["DataFromAffectedRecord"])
                        };

                        historicsList.Add(historic);
                    }
                }
            }

            return historicsList;
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            using (var connection = new MdlConnection())
            {
                #region Variables
                var sqlQuery = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;
                #endregion 

                #region DefaultQuery

                sqlQuery = @"SELECT * FROM UserHistoric WHERE Id > 0";

                #endregion 

                #region Criterion + OperationDate

                if (historic.QueryByStartDate != string.Empty &&
                    historic.QueryByFinalDate != string.Empty)
                {
                    criterion += " AND OperationDate >= @StartDate And OperationDate <= @FinalDate";

                    parameter.AddWithValue("@StartDate", string.Format("{0}",
                    historic.QueryByStartDate));

                    parameter.AddWithValue("@FinalDate", string.Format("{0}",
                    historic.QueryByFinalDate));
                }

                #endregion

                #region Criterion + Login

                if (historic.QueryByLogin != string.Empty)
                {
                    criterion += " AND Login LIKE @Login ";

                    parameter.AddWithValue("@Login", string.Format("%{0}%",
                    historic.QueryByLogin));
                }

                #endregion 

                #region Criterion + SqlQuery

                sqlQuery += criterion;

                #endregion

                #region FillDataTable

                var dataTable = connection.QueryWithDataTable(sqlQuery,
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
                    OperationType = Convert.ToString(row["OperationType"]),
                    OperationModule = Convert.ToString(row["OperationModule"]),
                    OperationDate = Convert.ToDateTime(row["OperationDate"]),
                    OperationHour = Convert.ToString(row["OperationHour"]),
                    DataFromAffectedRecord = Convert.ToString(row["DataFromAffectedRecord"])
                };

                historicList.Add(historic);
            }

            historic.ListOfRecords = historicList;
        }
        #endregion 
    }
}
