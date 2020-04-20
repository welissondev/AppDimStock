using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo do produto
    /// </summary>
    public partial class ProductModel
    {
        private ConnectionTransactionModel dataBaseTransaction;

        public int Id { get; set; }
        public string InternalCode { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string BarCode { get; set; }
        public CategoryModel Category { get; set; }
    }

    public partial class ProductModel
    {
        public ProductModel()
        {
            Category = new CategoryModel();
        }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (ProductValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO Product (CategoryId, InternalCode, Description, 
                CostPrice, SalePrice, BarCode) VALUES (@CategoryId, @Code, @InternalCode, 
                @CostPrice, @SalePrice, @BarCode)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@CategoryId", Category.Id);
                dataBase.AddParameter("@InternalCode", InternalCode);
                dataBase.AddParameter("@Description", Description);
                dataBase.AddParameter("@CostPrice", CostPrice);
                dataBase.AddParameter("@SalePrice", SalePrice);
                dataBase.AddParameter("@BarCode", BarCode);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Set("Produto cadastrado com sucesso!", "Sucesso");
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Update()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (ProductValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (dataBaseTransaction = new ConnectionTransactionModel())
            {
                sql = @"UPDATE Product SET CategoryId = @CategoryId, InternalCode = @InternalCode, 
                Description = @Description, CostPrice = @CostPrice, SalePrice = @SalePrice, 
                BarCode = @BarCode WHERE Id = @Id";

                dataBaseTransaction.ClearParameter();
                dataBaseTransaction.AddParameter("@CategoryId", Category.Id);
                dataBaseTransaction.AddParameter("@InternalCode", InternalCode);
                dataBaseTransaction.AddParameter("@Description", Description);
                dataBaseTransaction.AddParameter("@CostPrice", CostPrice);
                dataBaseTransaction.AddParameter("@SalePrice", SalePrice);
                dataBaseTransaction.AddParameter("@BarCode", BarCode);
                dataBaseTransaction.AddParameter("@Id", Id);

                if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
                {
                    if (new StockModel(dataBaseTransaction, this).UpdateTotalValue() == true)
                    {
                        dataBaseTransaction.Commit();
                        MessageNotifier.Set("Produto atualizado com sucesso!", "Sucesso");
                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (ProductValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM Product WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Set("Produto excluido " +
                    "com sucesso!", "Sucesso");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool CheckIfRegister()
        {
            var registrationState = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = "SELECT Id FROM Product WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.Read() == false)
                    {
                        MessageNotifier.Set("Esse produto não " +
                        "encontra-se registrado em sua base de " +
                        "dados!", "Não Encontrado");

                        return registrationState;
                    }
                }
            }

            return registrationState = true;
        }

        public bool CheckRelationWithStock()
        {
            return new StockModel(this).CheckRelationWithProduct();
        }

        public bool GetDetails()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (ProductValidationModel.ValidateToGetDetails(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Product.*, Category.* FROM Product
                LEFT JOIN Category ON Product.CategoryId = Category.Id
                WHERE Product.Id = @Id ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.FieldCount > 0)
                    {
                        while (reader.Read())
                        {
                            Id = int.Parse(reader["Product.Id"].ToString());
                            InternalCode = reader["InternalCode"].ToString();
                            Description = reader["Product.Description"].ToString();
                            CostPrice = double.Parse(reader["CostPrice"].ToString());
                            SalePrice = double.Parse(reader["SalePrice"].ToString());
                            BarCode = reader["BarCode"].ToString();

                            if (reader["Category.Id"] != DBNull.Value)
                                Category.Id = int.Parse(reader["Category.Id"].ToString());

                            if (reader["Category.Description"] != DBNull.Value)
                                Category.Description = reader["Category.Description"].ToString();
                        }

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public int GetQuantityInStock()
        {
            return new StockModel(this).GetQuantity();
        }

        public int GetLastId()
        {
            var sql = @"SELECT MAX(Id) From Product";
            return dataBaseTransaction.ExecuteScalar(sql);
        }

        public double GetCostPrice()
        {
            double costPrice = CostPrice;

            using (var dataBase = new ConnectionModel())
            {
                var sql = @"SELECT CostPrice FROM 
                Product WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        costPrice = double.Parse(reader["CostPrice"].ToString());
                    }
                }
            }

            return costPrice;
        }

        public DataTable SearchData()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Id, InternalCode, Description, 
                CostPrice, SalePrice FROM Product WHERE Id > 0";

                dataBase.ClearParameter();

                if (InternalCode != string.Empty)
                {
                    sql += " AND InternalCode LIKE @InternalCode";

                    dataBase.AddParameter("@InternalCode", string.
                    Format("{0}%", InternalCode));
                }

                if (Description != string.Empty)
                {
                    sql += " AND Description LIKE @Description";

                    dataBase.AddParameter("@Description", string.
                    Format("%{0}%", Description));
                }

                sql += " Order By Id, InternalCode Desc";

                return dataBase.ExecuteDataAdapter(sql);
            }
        }
    }
}
