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
        #region Builder

        public StockMovement()
        {
            Destination = new StockDestination();
        }

        public StockMovement(AxlDataPage pagination)
        {
            Pagination = pagination;
            Destination = new StockDestination();
            List = new List<StockMovement>();
        }

        public StockMovement(AccessConnection connection)
        {
            this.connection = connection;
            Destination = new StockDestination();
        }

        #endregion

        #region Get & Set

        private AccessConnection connection;
        public int Id { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public DateTime OperationHour { get; set; }
        public string OperationCode { get; set; }
        public string OperationSituation { get; set; }
        public StockDestination Destination { get; set; }
        public AxlDataPage Pagination { get; set; }
        public List<StockMovement> List { get; set; }

        #endregion

        #region Function

        public bool InitOperation(string type)
        {
            bool registerState = false;

            using (var connection = new AccessConnection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"INSERT INTO StockMovement(OperationType)
                    VALUES(@OperationType)";

                    connection.AddParameter("@OperationType", OleDbType.VarChar, type);

                    registerState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Seleciona o id da ultima movimentação inserida
                    Id = Convert.ToInt32(connection.ExecuteScalar(
                    @"SELECT MAX(Id) FROM StockMovement"));

                    //O código da operação é o mesmo que o ID da tabela
                    connection.ParameterClear();
                    connection.AddParameter("@OperationCode", OleDbType.VarChar, Id);
                    connection.AddParameter("Id", OleDbType.Integer, Id);

                    sqlCommand = @"UPDATE StockMovement SET OperationCode 
                    = @OperationCode WHERE Id = @Id";

                    registerState = connection.ExecuteTransaction(sqlCommand) > 0;

                    connection.Transaction.Commit();
                }

                return registerState;
            }
        }

        public bool RelateDestination(int id)
        {
            bool setDestinationState = false;
            var sqlCommand = string.Empty;

            using (var connection = new AccessConnection())
            {
                //Pega Id de destino pelo nome do local
                sqlCommand = @"SELECT * FROM StockDestination 
                WHERE Location = @Location";

                connection.AddParameter("Location", OleDbType.VarChar,
                Destination.Location);

                bool convert = int.TryParse(connection.ExecuteScalar(
                sqlCommand).ToString(), out int result);

                if (convert != false)
                    Destination.Id = result;

                if (Destination.Id != 0)
                {
                    connection.ParameterClear();

                    sqlCommand = @"UPDATE StockMovement SET StockDestinationId
                    = @Value WHERE Id = @Id";

                    connection.AddParameter("@Value",
                    OleDbType.VarChar, Destination.Id);
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

        public bool Remove(int id)
        {
            if (CheckIfExists(id) == false)
            {
                AxlMessageNotifier.Message = "Esse registro já foi " +
                "excluido, atualize a lista de dados!";

                return false;
            }

            var stockItem = new StockMovementItem();
            stockItem.ListItems(id);

            var transactionState = false;

            using (var connection = new AccessConnection())
            {
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

                    if (stockItem.List.Count > 0)
                    {
                        //Remove o estoque
                        var stok = new Stock(connection);

                        switch (OperationType)
                        {
                            case "Entrada":
                                transactionState = stok.RemoveEntries(
                                stockItem.List);
                                break;

                            case "Saída":
                                transactionState = stok.RemoveOutputs(
                                stockItem.List);
                                break;
                        }
                    }

                    //Finaliza o transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Deletado com sucesso!";
                }

                return transactionState;
            }
        }

        public void ListData()
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = @"SELECT * From StockMovement";

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
                            OperationSituation = reader["OperationSituation"].ToString(),
                            OperationCode = reader["OperationCode"].ToString()
                        };

                        Destination.Id = Convert.ToInt32(reader["StockDestination.Id"]);
                        Destination.Location = Convert.ToString(reader["Location"]);

                        List.Add(stockMovement);
                    }
                }
            }
        }

        public void FetchData()
        {
            using (var connection = new AccessConnection())
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

                if (OperationType != string.Empty)
                {
                    criterion += @" AND OperationType LIKE @OperationType";

                    parameter.AddWithValue("@OperationType", string.Format("{0}",
                    OperationType));
                }

                if (OperationSituation != string.Empty)
                {
                    criterion += @" AND OperationSituation LIKE @OperationSituation";

                    parameter.AddWithValue("@OperationSituation", string.Format("{0}",
                    OperationSituation));
                }

                if (OperationCode != string.Empty)
                {
                    criterion += @" AND StockMovement.OperationCode LIKE @OperationCode ";

                    parameter.AddWithValue("@OperationCode", string.Format("{0}",
                    OperationCode));
                }

                sqlQuery += criterion + @" ORDER BY StockMovement.Id DESC";

                sqlCount += criterion;

                Pagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                Pagination.OffSetValue,
                Pagination.PageSize);

                PassToList(dataTable);

            }
        }

        public void GetDetail(int id)
        {
            using (var connection = new AccessConnection())
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
                        OperationCode = Convert.ToString(reader["OperationCode"]).ToString();

                        bool convert = int.TryParse(reader[
                        "StockDestination.Id"].ToString(),
                        out int result);

                        if (convert != false)
                            Destination.Id = result;

                        Destination.Location = reader["Location"].ToString();
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
                    OperationSituation = Convert.ToString(row["OperationSituation"]),
                    OperationCode = Convert.ToString(row["OperationCode"])
                };
                movement.Destination.Location = Convert.ToString(row["Location"]);

                List.Add(movement);
            }
        }

        public bool CheckIfExists(int id)
        {
            using (var connection = new AccessConnection())
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

        public string GetAffectedFields(int id, AccessConnection connection)
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
                    affectedFieldList.Add("Número:" + reader["OperationCode"].ToString());
                }
            }

            return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
        }

        #endregion
    }
}
