using System;
using DimStock.Auxiliary;
using DimStock.Business;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Data;

namespace DimStock.Model
{
    public class StockMovementModel
    {
        #region Properties
        private readonly StockMovementController stockMovement;
        #endregion

        #region Constructs
        public StockMovementModel() { }

        public StockMovementModel(StockMovementController stockMovement)
        {
            this.stockMovement = stockMovement;
        }
        #endregion

        #region Methods

        public bool Insert()
        {
            bool registerState = false;

            using (var connection = new ConnectionModel())
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

        public bool SetDestination(int id)
        {
            bool addState = false;

            if (stockMovement.StockDestinationLocation != string.Empty)
            {
                using (var connection = new ConnectionModel())
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

        public bool Delete(int id)
        {
            bool deleteState = false;

            using (var connection = new ConnectionModel())
            {
                var sqlCommand = @"DELETE FROM StockMovement WHERE Id = @Id" ;

                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    NotificationController.Message = "Deletado com sucesso!";
                    deleteState = true;
                }
                else
                {
                    NotificationController.Message = "Esse registro já foi deletado, " +
                    "atualize a lista de registros!";
                }
            }

            return deleteState;
        }

        public bool FianalizeOperation(ConnectionModel connection, int id)
        {
            var transactionState = false;

            var sqlCommand = @"UPDATE StockMovement Set OperationSituation = 'Finalizada' Where Id = @Id";

            connection.ParameterClear();
            connection.AddParameter("@Id", OleDbType.Integer, id);
  
            if (connection.ExecuteTransaction(sqlCommand) > 0)
            {
                var historic = new UserHistoryController()
                {
                    Login = LoginAssistant.Login,
                    OperationType = "Confirmou",
                    OperationModule = "Atividade",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    AffectedFields = GetAffectedFields(id)
                };

                if (historic.Register() == true)
                {
                    transactionState = true;
                }
            }

            return transactionState;
        }

        public void ListData()
        {
            using (var connection = new ConnectionModel())
            {
                var sqlQuery = @"SELECT * From StockMovement";

                var stockMovementsList = new List<StockMovementController>();

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var stockMovement = new StockMovementController()
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

        public void DataQuery()
        {
            using (var connection = new ConnectionModel())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;

                sqlQuery = @"SELECT * From StockMovement 
                WHERE Id > 0 ";

                sqlCount = @"SELECT COUNT(*) FROM StockMovement 
                WHERE Id > 0 ";

                if (stockMovement.SearchByType != string.Empty)
                {
                    criterion += @" AND OperationType LIKE @OperationType";

                    parameter.AddWithValue("@OperationType", string.Format("{0}",
                    stockMovement.SearchByType));
                }

                if (stockMovement.SearchBySituation != string.Empty)
                {
                    criterion += @" AND OperationSituation LIKE @OperationSituation";

                    parameter.AddWithValue("@OperationSituation", string.Format("{0}",
                    stockMovement.SearchBySituation));
                }

                if (stockMovement.SearchByMovimentId != string.Empty)
                {
                    criterion += @" AND Id LIKE @MovimentId ";

                    parameter.AddWithValue("@MovimentId", string.Format("{0}",
                    stockMovement.SearchByMovimentId));
                }

                sqlQuery += criterion + @" ORDER BY Id DESC";

                sqlCount += criterion;

                stockMovement.DataPagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                stockMovement.DataPagination.OffSetValue,
                stockMovement.DataPagination.PageSize);

                PassDataTableToList(dataTable);

            }
        }

        public void ViewDetails(int id)
        {
            using (var connection = new ConnectionModel())
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

        public string GetAffectedFields(int id)
        {
            using (var connection = new ConnectionModel())
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

        private void PassDataTableToList(DataTable dataTable)
        {
            var stockMovementsList = new List<StockMovementController>();

            foreach (DataRow row in dataTable.Rows)
            {
                var stockMovement = new StockMovementController()
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
