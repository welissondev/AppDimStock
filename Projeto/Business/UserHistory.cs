using System;
using DimStock.Auxiliary;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;

namespace DimStock.Business
{
    public class UserHistory
    {
        #region Properties
        private Connection connection;
        #endregion

        #region Constructs

        public UserHistory()
        {
        }

        public UserHistory(DataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        public UserHistory(Connection connection)
        {
            this.connection = connection;
        }

        #endregion 

        #region BussinessProperties
        public int Id { get; set; }
        public string Login { get; set; }
        public string AffectedFields { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public string OperationHour { get; set; }
        public string OperationModule { get; set; }
        public List<UserHistory> ListOfRecords { get; set; }
        #endregion

        #region SearchProperties

        public string SearchByLogin { get; set; }
        public string SearchByStartDate { get; set; }
        public string SearchByFinalDate { get; set; }
        public DataPagination DataPagination { get; set; }

        #endregion 

        #region Methods

        public bool Register()
        {
            var sqlCommand = @"INSERT INTO UserHistoric(Login, OperationType, OperationDate, OperationHour, 
            OperationModule, AffectedFields)VALUES(@Login, @OperationType, @OperationDate, @OperationHour, 
            @Module, @AffectedFields)";


            connection.ParameterClear();
            connection.AddParameter("@Login", OleDbType.VarChar, Login);
            connection.AddParameter("@OperationType", OleDbType.VarChar, OperationType);
            connection.AddParameter("@OperationDate", OleDbType.Date, OperationDate);
            connection.AddParameter("@OperationHour", OleDbType.VarChar, OperationHour);
            connection.AddParameter("@OperationModule", OleDbType.VarChar, OperationModule);
            connection.AddParameter("@AffectedFields", OleDbType.VarChar, AffectedFields);

            return connection.ExecuteTransaction(sqlCommand) > 0;
        }

        public void ListData()
        {
            var sqlQuery = @"SELECT * FROM UserHistoric";

            var historicList = new List<UserHistory>();

            using (var connection = new Connection())
            {
                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var historic = new UserHistory
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

                    ListOfRecords = historicList;
                }
            }
        }

        public void SearchData()
        {
            using (var connection = new Connection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;

                sqlQuery = @"SELECT * FROM UserHistoric WHERE Id > 0 ";
                 
                sqlCount = @"SELECT COUNT(*) FROM UserHistoric WHERE Id > 0 ";

                if (SearchByStartDate != string.Empty &&
                    SearchByFinalDate != string.Empty)
                {
                    criterion += " AND OperationDate >= @StartDate And OperationDate <= @FinalDate";

                    parameter.AddWithValue("@StartDate", string.Format("{0}",
                    SearchByStartDate));

                    parameter.AddWithValue("@FinalDate", string.Format("{0}",
                    SearchByFinalDate));
                }

                if (SearchByLogin != string.Empty)
                {
                    criterion += " AND Login LIKE @Login ";

                    parameter.AddWithValue("@Login", string.Format("%{0}%",
                    SearchByLogin));
                }

                sqlQuery += criterion;

                sqlCount += criterion;

                DataPagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                DataPagination.OffSetValue,
                DataPagination.PageSize);

                PassForList(dataTable);
            }
        }

        public void PassForList(DataTable dataTable)
        {
            var historicList = new List<UserHistory>();

            foreach (DataRow row in dataTable.Rows)
            {
                var historic = new UserHistory
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

            ListOfRecords = historicList;
        }

        #endregion 
    }
}
