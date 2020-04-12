using DimStock.AuxilyTools.AuxilyClasses;
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

            using (var dataBase = new ConnectionModel())
            {
                using (dataBase.Transaction = dataBase.Open().BeginTransaction())
                {
                    sql = @"INSERT INTO Category(Description)VALUES(@Description)";

                    dataBase.ClearParameter();
                    dataBase.AddParameter("@Description", Description);

                    actionResult = dataBase.ExecuteTransaction(sql) > 0;

                    if (actionResult == true)
                    {
                        dataBase.Transaction.Commit();

                        MessageNotifier.Message = "Cadastrado com sucesso!";
                        MessageNotifier.Title = "Sucesso";

                        return actionResult;
                    }
                }

                return actionResult;
            }
        }

        public bool Update()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                using (dataBase.Transaction = dataBase.Open().BeginTransaction())
                {
                    sql = @"UPDATE Category SET Description = @Description WHERE Id = @Id";

                    dataBase.ClearParameter();
                    dataBase.AddParameter("@Description", Description);
                    dataBase.AddParameter("@Id", Id);

                    actionResult = dataBase.ExecuteTransaction(sql) > 0;

                    if (actionResult == true)
                    {
                        dataBase.Transaction.Commit();

                        MessageNotifier.Message = "Categoria editada com sucesso!";
                        MessageNotifier.Title = "Sucesso";

                        return actionResult;
                    }
                }

                return actionResult;
            }
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                using (dataBase.Transaction = dataBase.Open().BeginTransaction())
                {
                    sql = @"DELETE FROM Category WHERE Id = @Id";

                    dataBase.ClearParameter();
                    dataBase.AddParameter("@Id", Id);

                    actionResult = dataBase.ExecuteTransaction(sql) > 0;

                    if (actionResult == true)
                    {
                        dataBase.Transaction.Commit();

                        MessageNotifier.Message = "Categoria deletada com sucesso!";
                        MessageNotifier.Title = "Sucesso";

                        return actionResult;
                    }
                }

                return actionResult;
            }
        }

        public bool GetDetail()
        {
            var actionResult = false;

            if (CategoryValidationModel.ValidateToGetDetail(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                var sql = @"SELECT Id, Description From 
                Category Where Id = @Id ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                using (var reader = dataBase.GetReader(sql))
                {
                    if (reader.FieldCount > 0)
                    {
                        actionResult = true;

                        while (reader.Read())
                        {
                            Id = int.Parse(reader["Id"].ToString());
                            Description = reader["Description"].ToString();
                        }
                    }
                }
            }

            return actionResult;
        }

        public int GetIdByDescription()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = "SELECT Id FROM Category WHERE Description = @Description";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Description", Description);

                return dataBase.ExecuteScalar(sql);
            }
        }

        public DataTable FetchData()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = "SELECT * FROM Category ";

                if (Description != string.Empty)
                {
                    sql += "WHERE Description LIKE @Description ";

                    dataBase.AddParameter("@Description",
                    string.Format("%{0}%", Description));
                }

                sql += "ORDER BY Description";

                return dataBase.GetTable(sql);
            }
        }

        public DataTable ListData()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = "SELECT * FROM Category ORDER BY Description";
                return dataBase.GetTable(sql);
            }
        }
    }
}


