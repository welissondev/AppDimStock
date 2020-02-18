using DimStock.Auxiliarys;
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

        public StockMovement()
        {
            StockDestination = new StockDestination();
            List = new List<StockMovement>();
        }

        public StockMovement(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
            StockDestination = new StockDestination();
            List = new List<StockMovement>();
        }

        public StockMovement(Connection connection)
        {
            this.connection = connection;
            StockDestination = new StockDestination();
            List = new List<StockMovement>();
        }

        #endregion 

        #region BussinessProperties

        public int Id { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public DateTime OperationHour { get; set; }
        public string OperationSituation { get; set; }
        public StockDestination StockDestination { get; set; }
        public List<StockMovement> List { get; set; }

        #endregion

        #region SearchProperties

        public string SearchByType { get; set; }
        public string SearchBySituation { get; set; }
        public string SearchByMovimentId { get; set; }
        public AxlDataPagination DataPagination { get; set; }

        #endregion 

        #region Methods

        public bool StartNewOperation(string operationType)
        {
            bool registerState = false;

            using (var connection = new Connection())
            {
                var sqlCommand = @"INSERT INTO StockMovement(OperationType)
                VALUES(@OperationType)";

                connection.AddParameter("@OperationType", OleDbType.VarChar, operationType);

                registerState = connection.ExecuteNonQuery(sqlCommand) > 0;

                //Seleciona o id da ultima movimentação inserida
                Id = Convert.ToInt32(connection.ExecuteScalar(
                @"SELECT MAX(Id) FROM StockMovement"));

                return registerState;
            }
        }

        public bool RelateDestination(int id)
        {
            bool setDestinationState = false;
            var sqlCommand = string.Empty;

            using (var connection = new Connection())
            {
                //Pega Id de destino pelo nome do local
                sqlCommand = @"SELECT * FROM StockDestination 
                WHERE Location = @Location";

                connection.AddParameter("Location", OleDbType.VarChar,
                StockDestination.Location);

                bool convert = int.TryParse(connection.ExecuteScalar(
                sqlCommand).ToString(), out int result);

                if (convert != false)
                    StockDestination.Id = result;

                if (StockDestination.Id != 0)
                {
                    connection.ParameterClear();

                    sqlCommand = @"UPDATE StockMovement SET StockDestinationId
                    = @Value WHERE Id = @Id";

                    connection.AddParameter("@Value",
                    OleDbType.VarChar, StockDestination.Id);
                    connection.AddParameter("@Id", OleDbType.Integer, id);

                    if (connection.ExecuteNonQuery(sqlCommand) > 0)
                        setDestinationState = true;
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
                AxlMessageNotifier.Message = "Esse registro já foi " +
                "excluido, atualize a lista de dados!";

                return false;
            }

            var stockItem = new StockMovementItem();
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
                        UserId = AxlLogin.Id,
                        OperationType = "Deletou",
                        OperationModule = "Estoque",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };
                    transactionState = userHistory.Register();

                    //Finaliza o transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Deletado com sucesso!";
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
                            OperationHour = Convert.ToDateTime(reader["OperationHour"]),
                            OperationSituation = reader["OperationSituation"].ToString()
                        };

                        StockDestination.Id = Convert.ToInt32(reader["StockDestination.Id"]);
                        StockDestination.Location = Convert.ToString(reader["Location"]);

                        stockMovementsList.Add(stockMovement);
                    }

                    List = stockMovementsList;
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

                sqlQuery = @"SELECT StockMovement.*, StockDestination.* FROM StockMovement
                LEFT JOIN StockDestination On StockMovement.StockDestinationId = 
                StockDestination.Id WHERE StockMovement.Id > 0 ";

                sqlCount = @"SELECT COUNT(*) FROM StockMovement 
                WHERE StockMovement.Id > 0 ";

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
                    criterion += @" AND StockMovement.Id LIKE @MovimentId ";

                    parameter.AddWithValue("@MovimentId", string.Format("{0}",
                    SearchByMovimentId));
                }

                sqlQuery += criterion + @" ORDER BY StockMovement.Id DESC";

                sqlCount += criterion;

                DataPagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                DataPagination.OffSetValue,
                DataPagination.PageSize);

                PassToList(dataTable);

            }
        }

        public void ViewDetails(int id)
        {
            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT StockMovement.*, StockDestination.* 
                FROM StockMovement LEFT JOIN StockDestination ON StockMovement.StockDestinationId 
                = StockDestination.Id WHERE StockMovement.Id = @Id";

                connection.ParameterClear();
                connection.AddParameter("Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["StockMovement.Id"]);
                        OperationType = Convert.ToString(reader["OperationType"].ToString());
                        OperationDate = Convert.ToDateTime(reader["OperationDate"].ToString());
                        OperationHour = Convert.ToDateTime(reader["OperationHour"].ToString());
                        OperationSituation = Convert.ToString(reader["OperationSituation"].ToString());

                        bool convert = int.TryParse(reader[
                        "StockDestination.Id"].ToString(),
                        out int result);

                        if (convert != false)
                            StockDestination.Id = result;

                        StockDestination.Location = reader["Location"].ToString();
                    }
                }
            }
        }

        public void PassToList(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                var movement = new StockMovement()
                {
                    Id = Convert.ToInt32(row["StockMovement.Id"]),
                    OperationType = Convert.ToString(row["OperationType"]),
                    OperationDate = Convert.ToDateTime(row["OperationDate"]),
                    OperationHour = Convert.ToDateTime(row["OperationHour"]),
                    OperationSituation = Convert.ToString(row["OperationSituation"])
                };

                movement.StockDestination.Location =
                Convert.ToString(row["Location"]);

                List.Add(movement);
            }
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
