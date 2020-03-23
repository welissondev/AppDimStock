using DimStock.Auxiliarys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DimStock.Models
{
    public class Category
    {
        #region Builder

        public Category() { }

        public Category(AccessConnection connection)
        {
            this.connection = connection;
        }

        public Category(AxlDataPage pagination)
        {
            Pagination = pagination;
        }

        #endregion

        #region Properties

        private readonly AccessConnection connection;

        #endregion

        #region Get & Set

        public int Id { get; set; }
        public string Description { get; set; }
        public List<Category> List { get; set; }
        public AxlDataPage Pagination { get; set; }

        #endregion

        #region Function

        public bool Save()
        {
            var registerState = false;
            var sqlCommand = string.Empty;

            using (var connection = new AccessConnection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    sqlCommand = @"INSERT INTO Category
                    (Description)VALUES(@Description)";

                    connection.AddParameter("@Description", Description);

                    registerState =
                    connection.ExecuteTransaction(
                    sqlCommand) > 0;

                    //Pegar id do último registro inserido
                    Id = Convert.ToInt32(connection.ExecuteScalar(
                    "SELECT MAX(Id) From Category"));

                    //Finalizar transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Categoria " +
                    "cadastrada com sucesso!";
                }

                return registerState;
            }
        }

        public bool Edit(int id)
        {
            var modifyState = false;
            var sqlCommand = string.Empty;

            using (var connection = new AccessConnection())
            {
                using (connection.Transaction =
                connection.Open().BeginTransaction())
                {
                    sqlCommand = @"UPDATE Category SET 
                    Description = @Description WHERE Id = @Id";

                    connection.AddParameter("@Description", Description);

                    connection.AddParameter("@Id", id);

                    modifyState =
                    connection.ExecuteTransaction(
                    sqlCommand) > 0;

                    //Finalizar transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Categoria " +
                    "editada com sucesso!";
                }

                return modifyState;
            }
        }

        public bool Remove(int id)
        {
            var deleteState = false;
            var sqlCommand = string.Empty;

            using (var connection = new AccessConnection())
            {
                using (connection.Transaction =
                connection.Open().BeginTransaction())
                {
                    sqlCommand = @"DELETE FROM Category 
                    WHERE Id = @Id";

                    connection.AddParameter("@Id", id);

                    deleteState =
                    connection.ExecuteTransaction(
                    sqlCommand) > 0;

                    //Finalizar transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Categoria " +
                    "deletada com sucesso!";
                }

                return deleteState;
            }
        }

        public void GetDetail(int id)
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = @"SELECT Id, Description From 
                Category Where Id = @Id ";

                connection.AddParameter("@Id", id);

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id"]);
                        Description = Convert.ToString(reader["Description"]);
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

                sqlQuery = @"SELECT * FROM Category 
                WHERE Id > 0 ";

                sqlCount = @"SELECT COUNT(*) FROM Category 
                WHERE Id > 0 ";

                if (Description != string.Empty)
                {
                    criterion += @" AND Description LIKE @Description ";

                    parameter.AddWithValue("@Description",
                    string.Format("%{0}%", Description));
                }

                sqlQuery += criterion + @"ORDER BY Description";

                sqlCount += criterion;

                Pagination.RecordCount =
                Convert.ToInt32(connection.ExecuteScalar(
                sqlCount));

                var dataTable = connection.GetTable(
                sqlQuery, Pagination.OffSetValue,
                Pagination.PageSize);

                PassToList(dataTable);
            }
        }

        public void ListData()
        {
            using (var connection = new AccessConnection())
            {
                var parameter = connection.Command.Parameters;
                var criterion = string.Empty;
                var sqlQuery = string.Empty;
                var categoryList = new List<Category>();

                sqlQuery = @"SELECT * FROM Category 
                WHERE Id > 0 ";

                if (Description != string.Empty)
                {
                    criterion += " AND Description LIKE @Description ";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    Description));
                }

                sqlQuery += criterion + @"ORDER BY Description";

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var category = new Category
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Description = Convert.ToString(reader["Description"])
                        };

                        categoryList.Add(category);
                    }

                    List = categoryList;
                }
            }
        }

        public void PassToList(DataTable dataTable)
        {
            var categoryList = new List<Category>();

            foreach (DataRow row in dataTable.Rows)
            {
                var category = new Category()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Description = Convert.ToString(row["Description"]),
                };

                categoryList.Add(category);
            }

            List = categoryList;
        }

        #endregion
    }
}
