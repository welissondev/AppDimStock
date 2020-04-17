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
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var transaction = new TransactionModel())
            {
                sql = @"INSERT INTO Category(Description)VALUES(@Description)";

                ParameterModel.Clear();
                ParameterModel.Add("@Description", Description);

                if (transaction.ExecuteNonQuery(sql) > 0)
                {
                    transaction.Commit();

                    MessageNotifier.Set("Categoria cadastrada " +
                    "com sucesso", "Sucesso");

                    actionResult = true;
                }
            }

            return actionResult;

        }

        public bool Update()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var transaction = new TransactionModel())
            {
                sql = @"UPDATE Category SET Description = @Description WHERE Id = @Id";

                ParameterModel.Clear();
                ParameterModel.Add("@Description", Description);
                ParameterModel.Add("@Id", Id);

                actionResult = transaction.ExecuteNonQuery(sql) > 0;

                if (actionResult == true)
                {
                    transaction.Commit();

                    MessageNotifier.Set("Categoria alterada " +
                    "com sucesso!", "Sucesso");

                    return actionResult;
                }
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var transaction = new TransactionModel())
            {
                sql = @"DELETE FROM Category WHERE Id = @Id";

                ParameterModel.Clear();
                ParameterModel.Add("@Id", Id);

                actionResult = transaction.ExecuteNonQuery(sql) > 0;

                if (actionResult == true)
                {
                    transaction.Commit();

                    MessageNotifier.Set("Categoria deletada " +
                    "com sucesso!", "Scuesso");
                    
                    return actionResult;
                }
            }

            return actionResult;
        }

        public bool GetDetail()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToGetDetail(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Id, Description From 
                Category Where Id = @Id ";

                ParameterModel.Clear();
                ParameterModel.Add("@Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
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
                var sql = "SELECT Id FROM Category WHERE Description = @Description";

                ParameterModel.Clear();
                ParameterModel.Add("@Description", Description);

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

                    ParameterModel.Add("@Description",
                   string.Format("%{0}%", Description));
                }

                sql += "ORDER BY Description";

                return dataBase.ExecuteDataAdapter(sql);
            }
        }

        public DataTable ListData()
        {
            using (var dataBase = new ConnectionModel())
            {
                var sql = "SELECT * FROM Category ORDER BY Description";
                return dataBase.ExecuteDataAdapter(sql);
            }
        }

    }
}


