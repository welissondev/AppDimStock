using System;
using DimStock.Auxiliary;
using DimStock.Business;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Data;

namespace DimStock.Model
{
    public class MdlStockMovement
    {
        #region Properties
        private readonly BllStockMovement stockMovement;
        #endregion

        #region Constructs
        public MdlStockMovement() { }

        public MdlStockMovement(BllStockMovement stockMovement)
        {
            this.stockMovement = stockMovement;
        }
        #endregion

        #region Register()
        public bool Register()
        {
            bool registerState = false;

            using (var connection = new MdlConnection())
            {
                var sqlCommand = @"INSERT INTO StockMovement(OperationType, OperationDate, 
                OperationHour, OperationSituation)VALUES(@OperationType, @OperationDate, @OperationHour, 
                @OperationSituation)";

                connection.AddParameter("@OperationType", OleDbType.VarChar, stockMovement.OperationType);
                connection.AddParameter("@OperationDate", OleDbType.Date, stockMovement.OperationDate);
                connection.AddParameter("@OperationHour", OleDbType.VarChar, stockMovement.OperationHour);
                connection.AddParameter("@OperationSituation", OleDbType.VarChar, stockMovement.OperationSituation);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    stockMovement.Id = Convert.ToInt32(connection.ExecuteScalar(
                    @"SELECT MAX(Id) FROM StockMovement"));

                    if (stockMovement.Id > 0)
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

            if (stockMovement.StockDestinationLocation != string.Empty)
            {
                using (var connection = new MdlConnection())
                {
                    var sqlCommand = @"UPDATE StockMovement SET StockDestinationLocation
                    = @StockDestinationLocation WHERE Id = @Id";

                    connection.AddParameter("@StockDestinationLocation", OleDbType.VarChar, stockMovement.StockDestinationLocation);
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
                var sqlCommand = @"DELETE FROM StockMovement WHERE Id = @Id" ;

                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    BllNotification.Message = "Deletado com sucesso!";
                    deleteState = true;
                }
                else
                {
                    BllNotification.Message = "Esse registro já foi deletado, " +
                    "atualize a lista de registros!";
                }
            }

            return deleteState;
        }
        #endregion 

        #region FianalizeOperation()
        public bool FianalizeOperation(MdlConnection connection, int id)
        {
            var transactionState = false;

            var sqlCommand = @"UPDATE StockMovement Set OperationSituation = 'Finalizada' Where Id = @Id";

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
                var sqlQuery = @"SELECT * From StockMovement";

                var stockMovementsList = new List<BllStockMovement>();

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var stockMovement = new BllStockMovement()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            OperationType = reader["OperationType"].ToString(),
                            OperationDate = Convert.ToDateTime(reader["OperationDate"]),
                            OperationHour = reader["OperationHour"].ToString(),
                            OperationSituation = reader["OperationSituation"].ToString(),
                        };

                        stockMovementsList.Add(stockMovement);
                    }

                    this.stockMovement.ListOfRecords = stockMovementsList;
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

                sqlQuery = @"SELECT * From StockMovement WHERE Id > 0 ";

                sqlCount = @"SELECT COUNT(*) FROM StockMovement WHERE Id > 0 ";

                #endregion

                #region QueryByCriterion

                #region Criterion + OperationType
                if (stockMovement.QueryByType != string.Empty)
                {
                    criterion += @"AND OperationType LIKE @OperationType";

                    parameter.AddWithValue("@OperationType", string.Format("{0}",
                    stockMovement.QueryByType));
                }
                #endregion

                #region Criterion + Situation
                if (stockMovement.QueryBySituation != string.Empty)
                {
                    criterion += @"AND OperationSituation LIKE @OperationSituation";

                    parameter.AddWithValue("@OperationSituation", string.Format("{0}",
                    stockMovement.QueryBySituation));

                }
                #endregion

                #region Criterion + MovimentId
                if (stockMovement.QueryByMovimentId != string.Empty)
                {
                    criterion += @"AND Id LIKE @MovimentId ";

                    parameter.AddWithValue("@MovimentId", string.Format("{0}",
                    stockMovement.QueryByMovimentId));
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

                stockMovement.DataPagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                #endregion 

                #region FillDataTable
                var dataTable = connection.QueryWithDataTable(sqlQuery,
                stockMovement.DataPagination.OffSetValue,
                stockMovement.DataPagination.PageSize);
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
                var sqlQuery = @"SELECT * FROM StockMovement WHERE Id = @Id";

                connection.AddParameter("Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        stockMovement.Id = Convert.ToInt32(reader["Id"]);
                        stockMovement.OperationType = Convert.ToString(reader["OperationType"]);
                        stockMovement.OperationDate = Convert.ToDateTime(reader["OperationDate"]);
                        stockMovement.OperationHour = Convert.ToString(reader["OperationHour"]);
                        stockMovement.OperationSituation = Convert.ToString(reader["OperationSituation"]);
                        stockMovement.StockDestinationLocation = Convert.ToString(reader["StockDestinationLocation"]);
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

                var sqlQuery = @"SELECT * From StockMovement Where Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        affectedFieldList.Add("Id:" + reader["Id"].ToString());
                        affectedFieldList.Add("Tipo:" + reader["OperationType"].ToString());
                        affectedFieldList.Add("Data:" + Convert.ToDateTime(reader["OperationDate"]).ToString("dd-MM-yyyy"));
                        affectedFieldList.Add("Hora:" + reader["OperationHour"].ToString());
                        affectedFieldList.Add("Situacao:" + reader["OperationSituation"].ToString());
                    }
                }

                return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
            }
        }
        #endregion

        #region PassDataTableToList()
        private void PassDataTableToList(DataTable dataTable)
        {
            var stockMovementsList = new List<BllStockMovement>();

            foreach (DataRow row in dataTable.Rows)
            {
                var stockMovement = new BllStockMovement()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    OperationType = Convert.ToString(row["OperationType"]),
                    OperationDate = Convert.ToDateTime(row["OperationDate"]),
                    OperationHour = Convert.ToString(row["OperationHour"]),
                    OperationSituation = Convert.ToString(row["OperationSituation"])
                };

                stockMovementsList.Add(stockMovement);
            }

            stockMovement.ListOfRecords = stockMovementsList;
        }
        #endregion
    }
}
