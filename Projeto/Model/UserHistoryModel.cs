using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Model
{
    public class UserHistoryModel
    {
        #region Properties
        private UserHistoryController historic;
        #endregion

        #region Constructs
        public UserHistoryModel()
        {

        }

        public UserHistoryModel(UserHistoryController historic)
        {
            this.historic = historic;
        }
        #endregion

        #region Methods

        public bool Insert()
        {
            using (var connection = new MdlConnection())
            {
                var sqlCommand = @"INSERT INTO UserHistoric(Login, OperationType, OperationDate, OperationHour, 
                OperationModule, AffectedFields)VALUES(@Login, @OperationType, @OperationDate, @OperationHour, 
                @Module, @AffectedFields)";

                connection.AddParameter("@Login", OleDbType.VarChar, historic.Login);
                connection.AddParameter("@OperationType", OleDbType.VarChar, historic.OperationType);
                connection.AddParameter("@OperationDate", OleDbType.Date, historic.OperationDate);
                connection.AddParameter("@OperationHour", OleDbType.VarChar, historic.OperationHour);
                connection.AddParameter("@OperationModule", OleDbType.VarChar, historic.OperationModule);
                connection.AddParameter("@AffectedFields", OleDbType.VarChar, historic.AffectedFields);

                return connection.ExecuteNonQuery(sqlCommand) > 0;

            }
        }

        public void SelectAll()
        {
            var sqlQuery = @"SELECT * FROM UserHistoric";

            var historicList = new List<UserHistoryController>();

            using (var connection = new MdlConnection())
            {
                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var historic = new UserHistoryController
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Login = Convert.ToString(reader["Login"]),
                            OperationType = Convert.ToString(reader["OperationType"]),
                            OperationModule = Convert.ToString(reader["OperationModule"]),
                            OperationDate = Convert.ToDateTime(reader["OperationDate"]),
                            OperationHour = Convert.ToString(reader["OperationHour"]),
                            AffectedFields = Convert.ToString(reader["AffectedFields"])
                        };

                        historicList.Add(historic);
                    }

                    historic.ListOfRecords = historicList;
                }
            }

        }

        public void SelectCustom()
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

                if (historic.SearchByStartDate != string.Empty &&
                    historic.SearchByFinalDate != string.Empty)
                {
                    criterion += " AND OperationDate >= @StartDate And OperationDate <= @FinalDate";

                    parameter.AddWithValue("@StartDate", string.Format("{0}",
                    historic.SearchByStartDate));

                    parameter.AddWithValue("@FinalDate", string.Format("{0}",
                    historic.SearchByFinalDate));
                }

                #endregion

                #region Criterion + Login

                if (historic.SearchByLogin != string.Empty)
                {
                    criterion += " AND Login LIKE @Login ";

                    parameter.AddWithValue("@Login", string.Format("%{0}%",
                    historic.SearchByLogin));
                }

                #endregion 

                #region Criterion + SqlQuery

                sqlQuery += criterion;

                #endregion

                #region FillDataTable

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                historic.DataPagination.OffSetValue,
                historic.DataPagination.PageSize);

                PassTableForList(dataTable);

                #endregion 
            }
        }

        private void PassTableForList(DataTable dataTable)
        {
            var historicList = new List<UserHistoryController>();

            foreach (DataRow row in dataTable.Rows)
            {
                var historic = new UserHistoryController
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Login = Convert.ToString(row["Login"]),
                    OperationType = Convert.ToString(row["OperationType"]),
                    OperationModule = Convert.ToString(row["OperationModule"]),
                    OperationDate = Convert.ToDateTime(row["OperationDate"]),
                    OperationHour = Convert.ToString(row["OperationHour"]),
                    AffectedFields = Convert.ToString(row["AffectedFields"])
                };

                historicList.Add(historic);
            }

            historic.ListOfRecords = historicList;
        }

        #endregion
    }
}
