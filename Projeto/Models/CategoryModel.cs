using DimStock.Auxiliarys;
using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Propriedades da classe
/// </summary>
namespace DimStock.Models
{
    public partial class CategoryModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public List<CategoryModel> List { get; set; }
        public AxlDataPage DataPage { get; set; }
    }
}


/// <summary>
/// Métodos da classe
/// </summary>
namespace DimStock.Models
{
    public partial class CategoryModel
    {
        public CategoryModel() { }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var db = new AccessConnection())
            {
                using (db.Transaction = db.Open().BeginTransaction())
                {
                    sql = @"INSERT INTO Category(Description)VALUES(@Description)";

                    db.ClearParameter();
                    db.AddParameter("@Description", Description);

                    actionResult = db.ExecuteTransaction(sql) > 0;

                    if (actionResult == true)
                    {
                        db.Transaction.Commit();

                        MessageNotifier.Message = "Cadastrado com sucesso!";
                        MessageNotifier.Title = "Sucesso";

                        return actionResult;
                    }
                }

                return actionResult;
            }
        }

        public bool Update(int id)
        {
            var actionResult = false;
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var db = new AccessConnection())
            {
                using (db.Transaction = db.Open().BeginTransaction())
                {
                    sql = @"UPDATE Category SET Description = @Description WHERE Id = @Id";

                    db.ClearParameter();
                    db.AddParameter("@Description", Description);
                    db.AddParameter("@Id", id);

                    actionResult = db.ExecuteTransaction(sql) > 0;

                    if (actionResult == true)
                    {
                        db.Transaction.Commit();

                        MessageNotifier.Message = "Categoria editada com sucesso!";
                        MessageNotifier.Title = "Sucesso";

                        return actionResult;
                    }
                }

                return actionResult;
            }
        }

        public bool Delete(int id)
        {
            var actionResult = false;
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var db = new AccessConnection())
            {
                using (db.Transaction = db.Open().BeginTransaction())
                {
                    sql = @"DELETE FROM Category WHERE Id = @Id";

                    db.ClearParameter();
                    db.AddParameter("@Id", id);

                    actionResult = db.ExecuteTransaction(sql) > 0;

                    if (actionResult == true)
                    {
                        db.Transaction.Commit();

                        MessageNotifier.Message = "Categoria deletada com sucesso!";
                        MessageNotifier.Title = "Sucesso";

                        return actionResult;
                    }
                }

                return actionResult;
            }
        }

        public DataTable FetchData()
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

                DataPage.RecordCount =
                Convert.ToInt32(connection.ExecuteScalar(
                sqlCount));

                var dataTable = connection.GetTable(
                sqlQuery, DataPage.OffSetValue,
                DataPage.PageSize);

                PassToList(dataTable);
                return dataTable;
            }
        }

        public void ListData()
        {
            using (var connection = new AccessConnection())
            {
                var parameter = connection.Command.Parameters;
                var criterion = string.Empty;
                var sqlQuery = string.Empty;
                var categoryList = new List<CategoryModel>();

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
                        var category = new CategoryModel
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
            var categoryList = new List<CategoryModel>();

            foreach (DataRow row in dataTable.Rows)
            {
                var category = new CategoryModel()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Description = Convert.ToString(row["Description"]),
                };

                categoryList.Add(category);
            }

            List = categoryList;
        }

        public DataTable Query()
        {
            var sql = string.Empty;

            using (var db = new AccessConnection())
            {
                sql = "SELECT * FROM Category ";

                if (Description != string.Empty)
                {
                    sql += "WHERE Description LIKE @Description";

                    db.AddParameter("@Description",
                    string.Format("%{0}%", Description));
                }

                return db.GetTable(sql);
            }
        }

        public bool GetDetail()
        {
            if (CategoryValidationModel.ValidateToGetDetail(this) == false)
                return false;

            using (var db = new AccessConnection())
            {
                var sql = @"SELECT Id, Description From Category Where Id = @Id ";
                var count = 0;

                db.ClearParameter();
                db.AddParameter("@Id", Id);

                using (var reader = db.GetReader(sql))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id"]);
                        Description = Convert.ToString(reader["Description"]);

                        count += 1;
                    }
                }

                return count > 0;
            }
        }
    }
}


