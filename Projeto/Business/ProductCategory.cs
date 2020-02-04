using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using DimStock.Auxiliarys;

namespace DimStock.Business
{
    public class ProductCategory
    {
        public ProductCategory() { }

        public ProductCategory(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public List<ProductCategory> ListOfRecords { get; set; }
        public AxlDataPagination DataPagination { get; set; }

        public bool Register()
        {
            var registerState = false;
            var sqlCommand = string.Empty;

            using (var connection = new Connection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    sqlCommand = @"INSERT INTO ProductCategory
                    (Description)VALUES(@Description)";

                    connection.AddParameter("@Description",
                    OleDbType.VarChar, Description);

                    registerState =
                    connection.ExecuteTransaction(
                    sqlCommand) > 0;

                    //Pegar id do último registro inserido
                    Id = Convert.ToInt32(connection.ExecuteScalar(
                    "SELECT MAX(Id) From ProductCategory"));

                    //Registrar histórico do usuário
                    var userHistory = new UserHistory(connection)
                    {
                        UserId = AxlLogin.Id,
                        OperationType = "Cadastrou",
                        OperationModule = "Produto Categoria",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = GetAffectedFields(Id, connection)
                    };

                    registerState = userHistory.Register();

                    //Finalizar transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Categoria " +
                    "cadastrada com sucesso!";
                }

                return registerState;
            }
        }

        public bool Modify(int id)
        {
            var modifyState = false;
            var sqlCommand = string.Empty;

            using (var connection = new Connection())
            {
                var affectedFields =
                GetAffectedFields(id, connection);

                using (connection.Transaction =
                connection.Open().BeginTransaction())
                {
                    sqlCommand = @"UPDATE ProductCategory SET 
                    Description = @Description WHERE Id = @Id";

                    connection.AddParameter("@Description",
                    OleDbType.VarChar, Description);

                    connection.AddParameter("@Id",
                    OleDbType.Integer, id);

                    modifyState =
                    connection.ExecuteTransaction(
                    sqlCommand) > 0;

                    //Registrar histórico do usuário
                    var userHistory = new UserHistory(connection)
                    {
                        UserId = AxlLogin.Id,
                        OperationType = "Editou",
                        OperationModule = "Produto Categoria",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };
                    modifyState = userHistory.Register();

                    //Finalizar transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Categoria " +
                    "editada com sucesso!";
                }

                return modifyState;
            }
        }

        public bool Delete(int id)
        {
            var deleteState = false;
            var sqlCommand = string.Empty;

            using (var connection = new Connection())
            {
                var affectedFields =
                GetAffectedFields(id, connection);

                using (connection.Transaction =
                connection.Open().BeginTransaction())
                {
                    sqlCommand = @"DELETE FROM ProductCategory 
                    WHERE Id = @Id";

                    connection.AddParameter("@Id",
                    OleDbType.Integer, id);

                    deleteState =
                    connection.ExecuteTransaction(
                    sqlCommand) > 0;

                    //Registrar histórico do usuário
                    var userHistory = new UserHistory(connection)
                    {
                        UserId = AxlLogin.Id,
                        OperationType = "Deletou",
                        OperationModule = "Produto Categoria",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };
                    deleteState = userHistory.Register();

                    //Finalizar transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Categoria " +
                    "deletada com sucesso!";
                }

                return deleteState;
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

                sqlQuery = @"SELECT * FROM ProductCategory 
                WHERE Id > 0 ";

                sqlCount = @"SELECT COUNT(*) FROM ProductCategory 
                WHERE Id > 0 ";

                if (Description != string.Empty)
                {
                    criterion += @" AND Description LIKE @Description ";

                    parameter.AddWithValue("@Description", 
                    Description);
                }

                sqlQuery += criterion + @"ORDER BY Description";

                sqlCount += criterion;

                DataPagination.RecordCount = 
                Convert.ToInt32(connection.ExecuteScalar(
                sqlCount));

                var dataTable = connection.QueryWithDataTable(
                sqlQuery, DataPagination.OffSetValue,
                DataPagination.PageSize);

                PassToList(dataTable);
            }
        }

        public string GetAffectedFields(int id, Connection connection)
        {
            var affectedFieldList = new List<string>();

            var commandSQL = @"SELECT * From ProductCategory Where Id = @Id";
            connection.AddParameter("@Id", OleDbType.Integer, id);

            using (var dataReader = connection.QueryWithDataReader(commandSQL))
            {
                while (dataReader.Read())
                {
                    affectedFieldList.Add("Id:" + dataReader["Id"].ToString());
                    affectedFieldList.Add("Descrição:" + dataReader["Description"].ToString());
                }
            }

            return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
        }

        public void PassToList(DataTable dataTable)
        {
            var categoryList = new List<ProductCategory>();

            foreach (DataRow row in dataTable.Rows)
            {
                var category = new ProductCategory()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Description = Convert.ToString(row["Description"]),
                };

                categoryList.Add(category);
            }

            ListOfRecords = categoryList;
        }
    }
}
