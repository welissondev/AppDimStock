using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    public partial class ProductModel
    {
        private TransactionModel transaction;

        public int Id { get; set; }
        public string InternalCode { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string BarCode { get; set; }
        public CategoryModel Category { get; set; }
    }
}

namespace DimStock.Models
{
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

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                sql = @"INSERT INTO Product (CategoryId, InternalCode, Description, 
                CostPrice, SalePrice, BarCode) VALUES (@CategoryId, @Code, @InternalCode, 
                @CostPrice, @SalePrice, @BarCode)";

                transaction.DataBase.ClearParameter();
                transaction.DataBase.AddParameter("@CategoryId", Category.Id);
                transaction.DataBase.AddParameter("@InternalCode", InternalCode);
                transaction.DataBase.AddParameter("@Description", Description);
                transaction.DataBase.AddParameter("@CostPrice", CostPrice);
                transaction.DataBase.AddParameter("@SalePrice", SalePrice);
                transaction.DataBase.AddParameter("@BarCode", BarCode);

                if (transaction.DataBase.ExecuteTransaction(sql) > 0)
                {
                    if (RelateToStock() == true)
                    {
                        transaction.Commit();

                        MessageNotifier.Message = "Produto cadastrado com sucesso!";
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
            var sql = string.Empty;

            if (ProductValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                sql = @"UPDATE Product SET CategoryId = @CategoryId, InternalCode = @InternalCode, 
                Description = @Description, CostPrice = @CostPrice, SalePrice = @SalePrice, 
                BarCode = @BarCode WHERE Id = @Id";

                transaction.DataBase.ClearParameter();
                transaction.DataBase.AddParameter("@CategoryId", Category.Id);
                transaction.DataBase.AddParameter("@InternalCode", InternalCode);
                transaction.DataBase.AddParameter("@Description", Description);
                transaction.DataBase.AddParameter("@CostPrice", CostPrice);
                transaction.DataBase.AddParameter("@SalePrice", SalePrice);
                transaction.DataBase.AddParameter("@BarCode", BarCode);
                transaction.DataBase.AddParameter("@Id", Id);

                if (transaction.DataBase.ExecuteTransaction(sql) > 0)
                {
                    if (UpdateStockValue() == true)
                    {
                        transaction.Commit();

                        MessageNotifier.Message = "Produto atualizado com sucesso!";
                        MessageNotifier.Title = "Sucesso!";

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool UpdateStockValue()
        {
            var stock = new StockModel(transaction);
            return stock.UpdateValue(this);
        }

        public bool RelateToStock()
        {
            Id = GetLastId();

            var stock = new StockModel(transaction);
            return stock.RelateProduct(this);
        }

        public int GetLastId()
        {
            var sql = @"SELECT MAX(Id) From Product";
            return transaction.DataBase.ExecuteScalar(sql);
        }

        public bool GetDetail()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (ProductValidationModel.ValidateToGetDetail(this) == false)
                return actionResult;

            using (var db = new ConnectionModel())
            {
                sql = @"SELECT Product.*, Category.* FROM Product
                LEFT JOIN Category ON Product.CategoryId = Category.Id
                WHERE Product.Id = @Id ";

                db.ClearParameter();
                db.AddParameter("@Id", Id);

                using (var reader = db.GetReader(sql))
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

                            if (reader["CategoryId"] != DBNull.Value)
                                Category.Id = int.Parse(reader["Category.Id"].ToString());

                            Category.Description = reader["Category.Description"].ToString();
                        }

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool Delete()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (ProductValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                sql = @"DELETE FROM Product WHERE Id = @Id";

                transaction.DataBase.ClearParameter();
                transaction.DataBase.AddParameter("@Id", Id);

                if (transaction.DataBase.ExecuteTransaction(sql) > 0)
                {
                    transaction.Commit();

                    MessageNotifier.Message = "Produto excluido com sucesso!";
                    MessageNotifier.Title = "Sucesso";

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public DataTable FetchData()
        {
            var sql = string.Empty;

            using (var db = new ConnectionModel())
            {
                sql = @"SELECT Id, InternalCode, Description, 
                CostPrice, SalePrice FROM Product WHERE Id > 0";

                if (InternalCode != string.Empty)
                {
                    sql += " AND InternalCode LIKE @InternalCode";

                    db.AddParameter("@InternalCode", string.
                    Format("{0}%", InternalCode));
                }

                if (Description != string.Empty)
                {
                    sql += " AND Description LIKE @Description";

                    db.AddParameter("@Description", string.
                    Format("%{0}%", Description));
                }

                sql += " Order By Id, InternalCode Desc";

                return db.GetTable(sql);
            }
        }
    }
}
