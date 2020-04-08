using DimStock.Auxiliarys;
using System;
using System.Data;

namespace DimStock.Models
{
    public partial class ProductModel
    {
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

            using (var db = new ConnectionModel())
            {
                using (db.Transaction = db.Open().BeginTransaction())
                {
                    sql = @"INSERT INTO Product (CategoryId, InternalCode, Description, 
                    CostPrice, SalePrice, BarCode) VALUES (@CategoryId, @Code, @InternalCode, 
                    @CostPrice, @SalePrice, @BarCode)";

                    db.ClearParameter();
                    db.AddParameter("@CategoryId", Category.Id);
                    db.AddParameter("@InternalCode", InternalCode);
                    db.AddParameter("@Description", Description);
                    db.AddParameter("@CostPrice", CostPrice);
                    db.AddParameter("@SalePrice", SalePrice);
                    db.AddParameter("@BarCode", BarCode);

                    actionResult = db.ExecuteTransaction(sql) > 0;
                    if (actionResult == true)
                    {
                        //Obten id do último registro inserido
                        sql = @"SELECT MAX(Id) From Product";
                        Id = db.ExecuteScalar(sql);

                        //Relaciona produto ao stock
                        var stock = new StockModel(db);
                        actionResult = stock.RelateProduct(Id);

                        if (actionResult == true)
                        {
                            db.Transaction.Commit();

                            MessageNotifier.Message = "Produto cadastrado com sucesso!";
                            MessageNotifier.Title = "Sucesso";
                        }
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

            using (var db = new ConnectionModel())
            {
                using (db.Transaction = db.Open().BeginTransaction())
                {
                    sql = @"UPDATE Product SET CategoryId = @CategoryId, InternalCode = @InternalCode, 
                    Description = @Description, CostPrice = @CostPrice, SalePrice = @SalePrice, 
                    BarCode = @BarCode WHERE Id = @Id";

                    db.ClearParameter();
                    db.AddParameter("@CategoryId", Category.Id);
                    db.AddParameter("@InternalCode", InternalCode);
                    db.AddParameter("@Description", Description);
                    db.AddParameter("@CostPrice", CostPrice);
                    db.AddParameter("@SalePrice", SalePrice);
                    db.AddParameter("@BarCode", BarCode);
                    db.AddParameter("@Id", Id);

                    actionResult = db.ExecuteTransaction(sql) > 0;

                    if (actionResult == true)
                    {
                        //Seleciona preço de custo
                        sql = @"SELECT CostPrice FROM Product WHERE Id = @Id";

                        db.ClearParameter();
                        db.AddParameter("@Id", Id);

                        var costPrice = double.Parse(db.ExecuteScalar(sql).ToString());

                        //Atualiza o valor no estoque
                        var stock = new StockModel(db);
                        actionResult = stock.UpdateValue(costPrice, Id);

                        if (actionResult == true)
                        {
                            db.Transaction.Commit();
                            MessageNotifier.Message = "Produto atualizado com sucesso!";
                            MessageNotifier.Title = "Sucesso";
                        }
                    }
                }

                return actionResult;
            }
        }

        public bool Delete()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (ProductValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var db = new ConnectionModel())
            {
                using (db.Transaction = db.Open().BeginTransaction())
                {
                    sql = @"DELETE FROM Product WHERE Id = @Id";

                    db.ClearParameter();
                    db.AddParameter("@Id", Id);

                    actionResult = db.ExecuteTransaction(sql) > 0;
                    if (actionResult == true)
                    {
                        db.Transaction.Commit();

                        MessageNotifier.Message = "Produto excluido com sucesso!";
                        MessageNotifier.Title = "Sucesso";
                    }
                }

                return actionResult;
            }
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
