using DimStock.Auxiliary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace DimStock.Business
{
    public class StockMovement
    {
        #region Properties
        private Connection connection;
        #endregion

        #region Constructs

        public StockMovement() { }

        public StockMovement(DataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        public StockMovement(Connection connection)
        {
            this.connection = connection;
        }

        #endregion 

        #region BussinessProperties
        public int Id { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public string OperationHour { get; set; }
        public string OperationSituation { get; set; }
        public string StockDestinationLocation { get; set; }
        public List<StockMovement> ListOfRecords { get; set; }
        #endregion

        #region SearchProperties

        public string SearchByType { get; set; }
        public string SearchBySituation { get; set; }
        public string SearchByMovimentId { get; set; }
        public DataPagination DataPagination { get; set; }

        #endregion 

        #region Methods

        public bool Register()
        {
            bool registerState = false;

            using (var connection = new Connection())
            {
                var sqlCommand = @"INSERT INTO StockMovement(OperationType, OperationDate, 
                OperationHour, OperationSituation)VALUES(@OperationType, @OperationDate, 
                @OperationHour, @OperationSituation)";

                connection.AddParameter("@OperationType", OleDbType.VarChar, OperationType);
                connection.AddParameter("@OperationDate", OleDbType.Date, OperationDate);
                connection.AddParameter("@OperationHour", OleDbType.VarChar, OperationHour);
                connection.AddParameter("@OperationSituation", OleDbType.VarChar, OperationSituation);

                registerState = connection.ExecuteNonQuery(sqlCommand) > 0;

                //Seleciona o id da ultima movimentação inserida
                Id = Convert.ToInt32(connection.ExecuteScalar(
                @"SELECT MAX(Id) FROM StockMovement"));

                return registerState;
            }
        }

        public bool SetDestination(int id)
        {
            bool setDestinationState = false;

            if (StockDestinationLocation != string.Empty)
            {
                using (var connection = new Connection())
                {
                    var sqlCommand = @"UPDATE StockMovement SET StockDestinationLocation
                    = @StockDestinationLocation WHERE Id = @Id";

                    connection.AddParameter("@StockDestinationLocation",
                    OleDbType.VarChar, StockDestinationLocation);
                    connection.AddParameter("@Id", OleDbType.Integer, id);

                    if (connection.ExecuteNonQuery(sqlCommand) > 0)
                    {
                        setDestinationState = true;
                    }
                }
            }

            return setDestinationState;
        }

        public bool FinalizeOperation(int id)
        {
            var transactionState = false;

            var sqlCommand = @"UPDATE StockMovement Set OperationSituation 
            = 'Finalizada' Where Id = @Id";

            connection.ParameterClear();
            connection.AddParameter("@Id", OleDbType.Integer, id);

            return transactionState = connection.ExecuteTransaction(
            sqlCommand) > 0;
        }

        public bool Delete(int id)
        {
            if (CheckIfRegisterExists(id) == false)
            {
                Notification.Message = "Esse registro já foi " +
                "excluido, atualize a lista de dados!";

                return false;
            }

            var stockItem = new StockItem();
            stockItem.ListItems(id);

            var transactionState = false;

            using (var connection = new Connection())
            {
                var affectedFields = GetAffectedFields(id, connection);

                using (connection.Transaction = 
                connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"DELETE FROM StockMovement 
                    WHERE Id = @Id";

                    connection.ParameterClear();
                    connection.AddParameter("@Id", 
                    OleDbType.Integer, id);

                    transactionState = connection.ExecuteTransaction(
                    sqlCommand) > 0;

                    if (stockItem.ListOfRecords.Count > 0)
                    {
                        //Remove o estoque
                        var stok = new Stock(connection);

                        switch (OperationType)
                        {
                            case "Entrada":
                                transactionState = stok.RemoveEntries(
                                stockItem.ListOfRecords);
                                break;

                            case "Saída":
                                transactionState = stok.RemoveOutputs(
                                stockItem.ListOfRecords);
                                break;
                        }
                    }

                    //Registra o histórico do usuário
                    var userHistory = new UserHistory(connection)
                    {
                        Login = LoginAssistant.Login,
                        OperationType = "Deletou",
                        OperationModule = "Estoque",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };
                    transactionState = userHistory.Register();

                    //Finaliza o transação
                    connection.Transaction.Commit();

                    Notification.Message = "Deletado com sucesso!";
                }

                return transactionState;
            }
        }

        public void ListData()
        {
            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT * From StockMovement";

                var stockMovementsList = new List<StockMovement>();

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var stockMovement = new StockMovement()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            OperationType = reader["OperationType"].ToString(),
                            OperationDate = Convert.ToDateTime(reader["OperationDate"]),
                            OperationHour = reader["OperationHour"].ToString(),
                            OperationSituation = reader["OperationSituation"].ToString(),
                            StockDestinationLocation = reader["StockDestinationLocation"].ToString(),
                        };

                        stockMovementsList.Add(stockMovement);
                    }

                    ListOfRecords = stockMovementsList;
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

                sqlQuery = @"SELECT * From StockMovement 
                WHERE Id > 0 ";

                sqlCount = @"SELECT COUNT(*) FROM StockMovement 
                WHERE Id > 0 ";

                if (SearchByType != string.Empty)
                {
                    criterion += @" AND OperationType LIKE @OperationType";

                    parameter.AddWithValue("@OperationType", string.Format("{0}",
                    SearchByType));
                }

                if (SearchBySituation != string.Empty)
                {
                    criterion += @" AND OperationSituation LIKE @OperationSituation";

                    parameter.AddWithValue("@OperationSituation", string.Format("{0}",
                    SearchBySituation));
                }

                if (SearchByMovimentId != string.Empty)
                {
                    criterion += @" AND Id LIKE @MovimentId ";

                    parameter.AddWithValue("@MovimentId", string.Format("{0}",
                    SearchByMovimentId));
                }

                sqlQuery += criterion + @" ORDER BY Id DESC";

                sqlCount += criterion;

                DataPagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                DataPagination.OffSetValue,
                DataPagination.PageSize);

                PassDataTableToList(dataTable);

            }
        }

        public void ViewDetails(int id)
        {
            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT * FROM StockMovement WHERE Id = @Id";

                connection.AddParameter("Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id"]);
                        OperationType = Convert.ToString(reader["OperationType"]);
                        OperationDate = Convert.ToDateTime(reader["OperationDate"]);
                        OperationHour = Convert.ToString(reader["OperationHour"]);
                        OperationSituation = Convert.ToString(reader["OperationSituation"]);
                        StockDestinationLocation = Convert.ToString(reader["StockDestinationLocation"]);
                    }
                }
            }
        }

        public void PassDataTableToList(DataTable dataTable)
        {
            var stockMovementsList = new List<StockMovement>();

            foreach (DataRow row in dataTable.Rows)
            {
                var stockMovement = new StockMovement()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    OperationType = Convert.ToString(row["OperationType"]),
                    OperationDate = Convert.ToDateTime(row["OperationDate"]),
                    OperationHour = Convert.ToString(row["OperationHour"]),
                    OperationSituation = Convert.ToString(row["OperationSituation"]),
                    StockDestinationLocation = row["StockDestinationLocation"].ToString(),
                };

                stockMovementsList.Add(stockMovement);
            }

            ListOfRecords = stockMovementsList;
        }

        public string GetAffectedFields(int id, Connection connection)
        {
            var sqlQuery = @"SELECT * FROM StockMovement WHERE Id = @Id";

            connection.ParameterClear();
            connection.AddParameter("@Id", OleDbType.Integer, id);

            var affectedFieldList = new List<string>();

            using (var reader = connection.QueryWithDataReader(sqlQuery))
            {
                while (reader.Read())
                {
                    affectedFieldList.Add("Id:" + reader["Id"].ToString());
                    affectedFieldList.Add("Tipo:" + reader["OperationType"].ToString());
                    affectedFieldList.Add("Data:" + Convert.ToDateTime(reader["OperationDate"]).ToString("dd-MM-yyyy"));
                    affectedFieldList.Add("Hora:" + reader["OperationHour"].ToString());
                    affectedFieldList.Add("Situação:" + reader["OperationSituation"].ToString());
                    affectedFieldList.Add("LocalDestino:" + reader["StockDestinationLocation"].ToString());
                }
            }

            return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
        }

        public bool CheckIfRegisterExists(int id)
        {
            using (var connection = new Connection())
            {
                var sqlQuery = "SELECT Id FROM StockMovement WHERE Id = @Id";
                var recordsFound = 0;

                connection.AddParameter("Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        recordsFound += 1;
                    }
                }

                return recordsFound > 0;
            }
        }

        #endregion
    }
}
