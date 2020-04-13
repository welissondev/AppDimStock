﻿using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo do produto
    /// </summary>
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
                dataBase.SqlQuery = @"INSERT INTO Product (CategoryId, InternalCode, Description, 
                CostPrice, SalePrice, BarCode) VALUES (@CategoryId, @Code, @InternalCode, 
                @CostPrice, @SalePrice, @BarCode)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@CategoryId", Category.Id);
                dataBase.AddParameter("@InternalCode", InternalCode);
                dataBase.AddParameter("@Description", Description);
                dataBase.AddParameter("@CostPrice", CostPrice);
                dataBase.AddParameter("@SalePrice", SalePrice);
                dataBase.AddParameter("@BarCode", BarCode);

                if (dataBase.ExecuteNonQuery() > 0)
                {
                    MessageNotifier.Message = "Produto cadastrado com sucesso!";
                    MessageNotifier.Title = "Sucesso";
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Update()
        {
            var actionResult = false;

            if (ProductValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (transaction = new TransactionModel(new ConnectionModel()))
            {
                transaction.SqlQuery = @"UPDATE Product SET CategoryId = @CategoryId, InternalCode = @InternalCode, 
                Description = @Description, CostPrice = @CostPrice, SalePrice = @SalePrice, 
                BarCode = @BarCode WHERE Id = @Id";

                transaction.ClearParameter();
                transaction.AddParameter("@CategoryId", Category.Id);
                transaction.AddParameter("@InternalCode", InternalCode);
                transaction.AddParameter("@Description", Description);
                transaction.AddParameter("@CostPrice", CostPrice);
                transaction.AddParameter("@SalePrice", SalePrice);
                transaction.AddParameter("@BarCode", BarCode);
                transaction.AddParameter("@Id", Id);

                if (transaction.Execute() > 0)
                {
                    if (new StockModel(transaction, this).UpdateValue() == true)
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

        public bool Delete()
        {
            var actionResult = false;

            if (ProductValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = @"DELETE FROM Product WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteNonQuery() > 0)
                {
                    MessageNotifier.Message = "Produto excluido com sucesso!";
                    MessageNotifier.Title = "Sucesso";
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool GetDetail()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (ProductValidationModel.ValidateToGetDetail(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = @"SELECT Product.*, Category.* FROM Product
                LEFT JOIN Category ON Product.CategoryId = Category.Id
                WHERE Product.Id = @Id ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                using (var reader = dataBase.GetReader())
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

        public int GetLastId()
        {
            transaction.SqlQuery = @"SELECT MAX(Id) From Product";
            return transaction.Scalar();
        }

        public DataTable FetchData()
        {
            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = @"SELECT Id, InternalCode, Description, 
                CostPrice, SalePrice FROM Product WHERE Id > 0";

                if (InternalCode != string.Empty)
                {
                    dataBase.SqlQuery += " AND InternalCode LIKE @InternalCode";

                    dataBase.AddParameter("@InternalCode", string.
                    Format("{0}%", InternalCode));
                }

                if (Description != string.Empty)
                {
                    dataBase.SqlQuery += " AND Description LIKE @Description";

                    dataBase.AddParameter("@Description", string.
                    Format("%{0}%", Description));
                }

                dataBase.SqlQuery += " Order By Id, InternalCode Desc";

                return dataBase.GetTable();
            }
        }
    }
}
