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

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO Category(Description)VALUES(@Description)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Description", Description);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Categoria cadastrada " +
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

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE Category SET Description = 
                @Description WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Description", Description);
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Categoria alterada " +
                    "com sucesso!", "Sucesso");
                    actionResult = true;
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

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM Category WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Categoria deletada " +
                    "com sucesso!", "Scuesso");
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool GetDetails()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (CategoryValidationModel.ValidateToGetDetail(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Id, Description From 
                Category Where Id = @Id ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        Id = int.Parse(reader["Id"].ToString());
                        Description = reader["Description"].ToString();
                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool CheckIfRegister()
        {
            /*Essa verificação também precisou ser feita pelo 
             nome da categoria, porque a regra de negócio não 
             permiti duas categorias com o mesmo nome*/

            var registrationStatus = false;
            var sqlSelect = string.Empty;
            var sqlParameter = string.Empty;
            var query = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sqlSelect = @"SELECT * FROM Category 
                WHERE Id = @Id ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (Description != string.Empty && Description != null)
                {
                    sqlParameter += "OR Description = @Description ";
                    dataBase.AddParameter("@Description", Description);
                }

                query += sqlSelect + sqlParameter;

                if (dataBase.ExecuteScalar(query) == 0)
                {
                    return registrationStatus;
                }
            }

            return registrationStatus = true;
        }

        public bool CheckRelationWithProduct()
        {
            return new ProductModel(this).CheckRelationWithCategory();
        }

        public int GetIdByDescription()
        {
            var sql = string.Empty;

            if (Description == string.Empty || Description == null)
            {
                MessageNotifier.Show("Para obter o ID da categoria é " +
                "preciso informar sua descrição!", "Obrigatório");
            }

            using (var dataBase = new ConnectionModel())
            {
                dataBase.AddParameter("@Description", Description);

                sql = @"SELECT * FROM Category WHERE 
                Description = @Description";

                return dataBase.ExecuteScalar(sql);
            }
        }

        public DataTable SearchData()
        {
            var sqlSelect = string.Empty;
            var sqlParemeter = string.Empty;
            var sqlOderBy = string.Empty;
            var query = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sqlSelect = @"SELECT * FROM Category ";

                sqlOderBy = @"ORDER BY Description";

                if (Description != string.Empty)
                {
                    sqlParemeter += "WHERE Description LIKE @Description ";

                    dataBase.AddParameter("@Description",
                    string.Format("%{0}%", Description));
                }

                query += sqlSelect + sqlParemeter + sqlOderBy;

                return dataBase.ExecuteDataAdapter(query);
            }
        }

        public DataTable ListData()
        {
            var searchResult = new DataTable();
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM Category 
                ORDER BY Description";

                searchResult = dataBase.ExecuteDataAdapter(sql);
            }

            return searchResult;
        }
    }
}