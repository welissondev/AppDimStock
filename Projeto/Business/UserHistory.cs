using DimStock.Auxiliarys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;

namespace DimStock.Business
{
    public class UserHistory
    {
        #region Builder

        public UserHistory(){}

        public UserHistory(AxlDataPage pagination)
        {
            Pagination = pagination;
        }

        public UserHistory(DatabaseConnection connection)
        {
            this.connection = connection;
        }

        #endregion

        #region Properties

        private DatabaseConnection connection;
        public List<UserHistory> List = new List<UserHistory>();
        public AxlDataPage Pagination = new AxlDataPage();
        public User User = new User();

        #endregion

        #region Get & Set

        public int Id { get; set; }
        public string AffectedFields { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public string OperationHour { get; set; }
        public string OperationModule { get; set; }

        #endregion

        #region Function

        public bool Save()
        {
            var sqlCommand = @"INSERT INTO UserHistory(UserId, OperationType, OperationDate, OperationHour, 
            OperationModule, AffectedFields)VALUES(@UserId, @OperationType, @OperationDate, @OperationHour, 
            @Module, @AffectedFields)";

            connection.ParameterClear();
            connection.AddParameter("@UserId", OleDbType.VarChar, User.Id);
            connection.AddParameter("@OperationType", OleDbType.VarChar, OperationType);
            connection.AddParameter("@OperationDate", OleDbType.Date, OperationDate);
            connection.AddParameter("@OperationHour", OleDbType.VarChar, OperationHour);
            connection.AddParameter("@OperationModule", OleDbType.VarChar, OperationModule);
            connection.AddParameter("@AffectedFields", OleDbType.VarChar, AffectedFields);

            return connection.ExecuteTransaction(sqlCommand) > 0;
        }

        public void ListData()
        {
            var sqlQuery = @"SELECT [User].*, UserHistory.* FROM UserHistory 
            INNER JOIN [User] ON User.Id = UserHistory.UserId";

            using (var connection = new DatabaseConnection())
            {
                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var history = new UserHistory
                        {
                            Id = Convert.ToInt32(reader["UserHistory.Id"]),
                            OperationType = Convert.ToString(reader["OperationType"]),
                            OperationModule = Convert.ToString(reader["OperationModule"]),
                            OperationDate = Convert.ToDateTime(reader["OperationDate"]),
                            OperationHour = Convert.ToString(reader["OperationHour"]),
                            AffectedFields = Convert.ToString(reader["AffectedFields"])
                        };

                        history.User.Id = Convert.ToInt32(reader["UserId"]);
                        history.User.Login = Convert.ToString(reader["Login"]);

                        List.Add(history);
                    }
                }
            }
        }

        public void SearchData(string startDate, string finalDate)
        {
            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;

                sqlQuery = @"SELECT [User].*, UserHistory.* FROM UserHistory 
                INNER JOIN [User] ON User.Id = UserHistory.UserId WHERE User.Id > 0 ";

                sqlCount = @"SELECT COUNT(*) FROM UserHistory WHERE Id > 0 ";

                if (startDate != string.Empty &&
                    finalDate != string.Empty)
                {
                    criterion += " AND OperationDate >= @StartDate " +
                    "And OperationDate <= @FinalDate";

                    parameter.AddWithValue("@StartDate", string.Format("{0}",
                    startDate));

                    parameter.AddWithValue("@FinalDate", string.Format("{0}",
                    finalDate));
                }

                if (User.Login != string.Empty)
                {
                    criterion += " AND Login LIKE @Login ";

                    parameter.AddWithValue("@Login", string.Format("%{0}%",
                    User.Login));
                }

                sqlQuery += criterion + " ORDER BY UserHistory.Id Asc";

                sqlCount += criterion;

                Pagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                Pagination.OffSetValue,
                Pagination.PageSize);

                PassToList(dataTable);
            }
        }

        public void PassToList(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                var history = new UserHistory
                {
                    Id = Convert.ToInt32(row["UserHistory.Id"]),
                    OperationType = Convert.ToString(row["OperationType"]),
                    OperationModule = Convert.ToString(row["OperationModule"]),
                    OperationDate = Convert.ToDateTime(row["OperationDate"]),
                    OperationHour = Convert.ToString(row["OperationHour"]),
                    AffectedFields = Convert.ToString(row["AffectedFields"])
                };

                history.User.Login = Convert.ToString(row["Login"]);

                List.Add(history);
            }
        }

        #endregion 
    }
}
