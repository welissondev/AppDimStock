using System;
using DimStock.Auxiliary;
using DimStock.Business;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Data;

namespace DimStock.Model
{
    public class MdlStockActivity
    {
        #region Properties
        private readonly BllStockActivity activity;
        #endregion

        #region Constructs
        public MdlStockActivity() { }

        public MdlStockActivity(BllStockActivity stockActivity)
        {
            this.activity = stockActivity;
        }
        #endregion

        #region Register()
        public bool Register()
        {
            bool registerState = false;

            using (var connection = new MdlConnection())
            {
                var sqlCommand = @"INSERT INTO StockActivity(OperationType, OperationDate, 
                OperationHour, Situation)VALUES(@OperationType, @OperationDate, @OperationHour, 
                @Situation)";

                connection.AddParameter("@OperationType", OleDbType.VarChar, activity.OperationType);
                connection.AddParameter("@OperationDate", OleDbType.Date, activity.OperationDate);
                connection.AddParameter("@OperationHour", OleDbType.VarChar, activity.OperationHour);
                connection.AddParameter("@Situation", OleDbType.VarChar, activity.Situation);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    activity.Id = Convert.ToInt32(connection.ExecuteScalar(
                    @"SELECT MAX(Id) FROM StockActivity"));

                    if (activity.Id > 0)
                    {
                        registerState = true;
                    }

                }

                return registerState;
            }
        }
        #endregion

        #region AddDestination()
        public bool AddDestination(int id)
        {
            bool addState = false;

            if (activity.StockDestination != string.Empty)
            {
                using (var connection = new MdlConnection())
                {
                    var sqlCommand = @"UPDATE StockActivity SET StockDestination 
                    = @StockDestination WHERE Id = @Id";

                    connection.AddParameter("@StockDestination", OleDbType.VarChar, activity.StockDestination);
                    connection.AddParameter("@Id", OleDbType.Integer, id);

                    if(connection.ExecuteNonQuery(sqlCommand) > 0)
                    {
                        addState = true;
                    }
                }
            }

            return addState;
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            bool deleteState = false;

            using (var connection = new MdlConnection())
            {
                var sqlCommand = @"DELETE FROM StockActivity WHERE Id = @Id" ;

                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    BllNotification.Message = "Atividade deletada com sucesso!";
                    deleteState = true;
                }
                else
                {
                    BllNotification.Message = "Essa atividade já foi deletada, " +
                    "atualize a lista de dados!";
                }
            }

            return deleteState;
        }
        #endregion 

        #region ChangeSituation()
        public bool ChangeSituation(MdlConnection connection, int id)
        {
            var transactionState = false;

            var sqlCommand = @"UPDATE StockActivity Set Situation = 'Finalizada' Where Id = @Id";

            connection.ParameterClear();
            connection.AddParameter("@Id", OleDbType.Integer, id);
  
            if (connection.ExecuteTransaction(sqlCommand) > 0)
            {
                var historic = new BllUserHistoric()
                {
                    Login = AxlLogin.Login,
                    OperationType = "Confirmou",
                    OperationModule = "Atividade",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = GetAffectedFields(id)
                };

                if (historic.Register() == true)
                {
                    transactionState = true;
                }
            }

            return transactionState;
        }
        #endregion

        #region ListAll()
        public void ListAll()
        {
            using (var connection = new MdlConnection())
            {
                var sqlQuery = @"SELECT * From StockActivity";

                var activityList = new List<BllStockActivity>();

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var stockActivity = new BllStockActivity()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            OperationType = reader["OperationType"].ToString(),
                            OperationDate = Convert.ToDateTime(reader["OperationDate"]),
                            OperationHour = reader["OperationHour"].ToString(),
                            Situation = reader["Situation"].ToString(),
                        };

                        activityList.Add(stockActivity);
                    }

                    activity.ListOfRecords = activityList;
                }
            }
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            using (var connection = new MdlConnection())
            {
                #region Variables
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;
                #endregion 

                #region DefaultQuery

                sqlQuery = @"SELECT * From StockActivity WHERE Id > 0 ";

                sqlCount = @"SELECT COUNT(*) FROM StockActivity WHERE Id > 0 ";

                #endregion

                #region QueryByCriterion

                #region Criterion + OperationType
                if (activity.QueryByType != string.Empty)
                {
                    criterion += @"AND OperationType LIKE @OperationType";

                    parameter.AddWithValue("@OperationType", string.Format("{0}",
                    activity.QueryByType));
                }
                #endregion

                #region Criterion + Situation
                if (activity.QueryBySituation != string.Empty)
                {
                    criterion += @"AND Situation LIKE @Situation ";

                    parameter.AddWithValue("@Situation", string.Format("{0}",
                    activity.QueryBySituation));

                }
                #endregion

                #region Criterion + ActivityNumber
                if (activity.QueryByActivityNumber != string.Empty)
                {
                    criterion += @"AND Id LIKE @ActvityNumber ";

                    parameter.AddWithValue("@ActvityNumber", string.Format("{0}",
                    activity.QueryByActivityNumber));
                }
                #endregion

                #region Criterion + SqlCommand
                sqlQuery += criterion + @" ORDER BY Id DESC";
                #endregion

                #region Criterion + SqlCount

                sqlCount += criterion;

                #endregion 

                #endregion

                #region SqlCount

                activity.DataPagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                #endregion 

                #region FillDataTable
                var dataTable = connection.QueryWithDataTable(sqlQuery,
                activity.DataPagination.OffSetValue,
                activity.DataPagination.PageSize);
                #endregion 

                #region PassDataTableToList
                PassDataTableToList(dataTable);
                #endregion
            }
        }
        #endregion

        #region GetDetails()
        public void GetDetails(int id)
        {
            using (var connection = new MdlConnection())
            {
                var sqlQuery = @"SELECT * FROM StockActivity WHERE Id = @Id";

                connection.AddParameter("Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        activity.Id = Convert.ToInt32(reader["Id"]);
                        activity.OperationType = Convert.ToString(reader["OperationType"]);
                        activity.OperationDate = Convert.ToDateTime(reader["OperationDate"]);
                        activity.OperationHour = Convert.ToString(reader["OperationHour"]);
                        activity.Situation = Convert.ToString(reader["Situation"]);
                        activity.StockDestination = Convert.ToString(reader["StockDestination"]);
                    }
                }
            }
        }
        #endregion

        #region GetAffectedFields()
        public string GetAffectedFields(int id)
        {
            using (var connection = new MdlConnection())
            {
                var affectedFieldList = new List<string>();

                var sqlQuery = @"SELECT * From StockActivity Where Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        affectedFieldList.Add("Id:" + reader["Id"].ToString());
                        affectedFieldList.Add("Tipo:" + reader["OperationType"].ToString());
                        affectedFieldList.Add("Data:" + Convert.ToDateTime(reader["OperationDate"]).ToString("dd-MM-yyyy"));
                        affectedFieldList.Add("Hora:" + reader["OperationHour"].ToString());
                        affectedFieldList.Add("Situacao:" + reader["Situation"].ToString());
                    }
                }

                return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
            }
        }
        #endregion

        #region PassDataTableToList()
        private void PassDataTableToList(DataTable dataTable)
        {
            var activityList = new List<BllStockActivity>();

            foreach (DataRow row in dataTable.Rows)
            {
                var activity = new BllStockActivity()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    OperationType = Convert.ToString(row["OperationType"]),
                    OperationDate = Convert.ToDateTime(row["OperationDate"]),
                    OperationHour = Convert.ToString(row["OperationHour"]),
                    Situation = Convert.ToString(row["Situation"])
                };

                activityList.Add(activity);
            }

            activity.ListOfRecords = activityList;
        }
        #endregion
    }
}
