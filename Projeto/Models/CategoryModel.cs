using DimStock.AuxilyTools.AuxilyClasses;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de uma categoria
    /// </summary>
    public partial class CategoryModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
    }

    public partial class CategoryModel
    {
        public CategoryModel() { }

        public bool Insert()
        {
            var actionResult = false;

            if (CategoryValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                using (dataBase.Transaction = dataBase.Open().BeginTransaction())
                {
                    dataBase.SqlQuery = @"INSERT INTO Category(Description)VALUES(@Description)";

                    dataBase.ClearParameter();
                    dataBase.AddParameter("@Description", Description);

                    if (dataBase.ExecuteTransaction() > 0)
                    {
                        dataBase.Transaction.Commit();

                        MessageNotifier.Message = "Cadastrado com sucesso!";
                        MessageNotifier.Title = "Sucesso";
                        actionResult = true;
                    }
                }

                return actionResult;
            }
        }

        public bool Update()
        {
            var actionResult = false;

            if (CategoryValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                using (dataBase.Transaction = dataBase.Open().BeginTransaction())
                {
                    dataBase.SqlQuery = @"UPDATE Category SET Description = @Description WHERE Id = @Id";

                    dataBase.ClearParameter();
                    dataBase.AddParameter("@Description", Description);
                    dataBase.AddParameter("@Id", Id);

                    actionResult = dataBase.ExecuteTransaction() > 0;

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

            if (CategoryValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                using (dataBase.Transaction = dataBase.Open().BeginTransaction())
                {
                    dataBase.SqlQuery = @"DELETE FROM Category WHERE Id = @Id";

                    dataBase.ClearParameter();
                    dataBase.AddParameter("@Id", Id);

                    actionResult = dataBase.ExecuteTransaction() > 0;

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
                dataBase.SqlQuery = @"SELECT Id, Description From 
                Category Where Id = @Id ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                using (var reader = dataBase.GetReader())
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
            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlScala = "SELECT Id FROM Category WHERE Description = @Description";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Description", Description);

                return dataBase.ExecuteScalar();
            }
        }

        public DataTable FetchData()
        {
            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = "SELECT * FROM Category ";

                if (Description != string.Empty)
                {
                    dataBase.SqlQuery += "WHERE Description LIKE @Description ";

                    dataBase.AddParameter("@Description",
                    string.Format("%{0}%", Description));
                }

                dataBase.SqlQuery += "ORDER BY Description";

                return dataBase.GetTable();
            }
        }

        public DataTable ListData()
        {
            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = "SELECT * FROM Category ORDER BY Description";
                return dataBase.GetTable();
            }
        }
    }
}


