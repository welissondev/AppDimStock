using DimStock.Auxiliarys;
using DimStock.Reports;
using System;
using System.Collections.Generic;
using System.Data;

namespace DimStock.Models
{
    public class Product 
    {
        #region Builder

        public Product()
        {
            Category = new CategoryModel();
        }

        public Product(AxlDataPage pagination)
        {
            Pagination = pagination;
            Category = new CategoryModel();
            List = new List<Product>();
        }

        #endregion

        #region Get & Set

        public int Id { get; set; }
        public string InternalCode { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string BarCode { get; set; }
        public string Photo { get; set; }
        public CategoryModel Category { get; set; }
        public AxlDataPage Pagination { get; set; }
        public List<Product> List { get; set; }

        #endregion 

        #region Function

        public bool Save()
        {
            using (var connection = new AccessConnection())
            {
                bool transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"INSERT INTO Product 
                    (CategoryId, InternalCode, Description, CostPrice, 
                    SalePrice, BarCode) VALUES (@CategoryId, @Code, 
                    @InternalCode, @CostPrice, @SalePrice, @BarCode)";

                    connection.AddParameter("@CategoryId", Category.Id);
                    connection.AddParameter("@InternalCode", InternalCode);
                    connection.AddParameter("@Description", Description);
                    connection.AddParameter("@CostPrice", CostPrice);
                    connection.AddParameter("@SalePrice" , SalePrice);
                    connection.AddParameter("@BarCode", BarCode);

                    transactionState = connection.ExecuteTransaction(
                    sqlCommand) > 0;


                    //Pegar id do último registro inserido
                    Id = Convert.ToInt32(connection.ExecuteScalar(
                    "SELECT MAX(Id) From Product"));


                    //Relacionar o produto ao stock
                    var stock = new Stock(connection);
                    transactionState = stock.RelateProduct(Id);


                    //Fianalizar transação
                    connection.Transaction.Commit();

                    MessageNotifier.Message = "Produto cadastrado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Edit(int id)
        {
            using (var connection = new AccessConnection())
            {
                bool transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"UPDATE Product Set CategoryId = @CategoryId, 
                    InternalCode = @InternalCode, Description = @Description, CostPrice = @CostPrice,
                    SalePrice = @SalePrice, BarCode = @BarCode WHERE Id = @Id";

                    connection.ClearParameter();
                    connection.AddParameter("@CategoryId", Category.Id);
                    connection.AddParameter("@InternalCode", InternalCode);
                    connection.AddParameter("@Description", Description);
                    connection.AddParameter("@CostPrice" , CostPrice);
                    connection.AddParameter("@SalePrice" ,SalePrice);
                    connection.AddParameter("@BarCode", BarCode);
                    connection.AddParameter("@Id", id);

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Seleciona preço de costo do produto
                    var sqlQuery = @"SELECT CostPrice FROM 
                    Product WHERE Id = @Id";

                    connection.ClearParameter();
                    connection.AddParameter("@Id", id);

                    var costPrice = Convert.ToDouble(
                    connection.ExecuteScalar(sqlQuery));

                    //Atualiza o valor no estoque
                    var stock = new Stock(connection);
                    transactionState = stock.UpdateValue(
                    costPrice, id);

                    //Fianaliza a transação
                    connection.Transaction.Commit();

                    MessageNotifier.Message = "Produto alterado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Remove(int id)
        {
            if (CheckIfExists(id) == false)
            {
                MessageNotifier.Message = "Esse registro já foi excluido, " +
               "atualize a lista de dados!";

                return false;
            }

            using (var connection = new AccessConnection())
            {
                var sqlCommand = string.Empty;
                var transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    sqlCommand = @"DELETE FROM Product WHERE Id = @Id";
                    connection.AddParameter("@Id", id);

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Fianaliza transação
                    connection.Transaction.Commit();

                    MessageNotifier.Message = "Produto deletado com sucesso!";
                }

                return transactionState;
            }
        }

        public void GetDetail(int id)
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = @"SELECT Product.*, Category.* FROM Product
                LEFT JOIN Category ON Product.CategoryId = Category.Id
                WHERE Product.Id = @Id ";

                connection.AddParameter("@Id", id);

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Product.Id"]);


                        bool convert = int.TryParse(reader[
                        "Category.Id"].ToString(),
                        out int result);

                        if (convert != false)
                            Category.Id = result;

                        Category.Description = Convert.ToString(
                        reader["Category.Description"]);

                        InternalCode = Convert.ToString(reader["InternalCode"]);
                        Description = Convert.ToString(reader["Product.Description"]);
                        CostPrice = Convert.ToDouble(reader["CostPrice"]);
                        SalePrice = Convert.ToDouble(reader["SalePrice"]);
                        BarCode = reader["BarCode"].ToString();
                    }
                }
            }
        }

        public void GenerateReport(List<Product> list)
        {
            var product = new ProductReport();
            ListData(); product.GenerateReport(list);
        }

        public void FetchData()
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;

                sqlQuery = @"SELECT * FROM Product WHERE Id > 0";

                sqlCount = @"SELECT COUNT(Id) FROM Product WHERE Id > 0";

                if (InternalCode != string.Empty)
                {
                    criterion += " AND InternalCode LIKE @InternalCode";

                    parameter.AddWithValue("@InternalCode", string.Format("{0}%",
                    InternalCode));
                }

                if (Description != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    Description));
                }

                sqlQuery += criterion + " Order By Id, InternalCode Desc";

                sqlCount += criterion;

                Pagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.GetTable(sqlQuery,
                Pagination.OffSetValue,
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

                sqlQuery = @"SELECT Id, InternalCode, Description, 
                CostPrice, SalePrice FROM Product WHERE Id > 0";

                if (InternalCode != string.Empty)
                {
                    criterion += " AND InternalCode LIKE @InternalCode";

                    parameter.AddWithValue("@InternalCode", string.Format("{0}%",
                    InternalCode));
                }

                if (Description != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    Description));
                }

                sqlQuery += criterion + " Order By InternalCode Asc";

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Description = Convert.ToString(reader["Description"]),
                            InternalCode = Convert.ToString(reader["InternalCode"]),
                            CostPrice = Convert.ToDouble(reader["CostPrice"]),
                            SalePrice = Convert.ToDouble(reader["SalePrice"])
                        };

                        List.Add(product);
                    }
                }
            }
        }

        public bool CheckIfExists(int id)
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = "SELECT Id FROM Product WHERE Id = @Id";
                var recordsFound = 0;

                connection.AddParameter("Id", id);

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        recordsFound += 1;
                    }
                }

                return recordsFound > 0;
            }
        }

        private void PassToList(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                var product = new Product()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    InternalCode = Convert.ToString(row["InternalCode"]),
                    Description = Convert.ToString(row["Description"]),
                    CostPrice = Convert.ToDouble(row["CostPrice"]),
                    SalePrice = Convert.ToDouble(row["SalePrice"]),
                };

                List.Add(product);
            }
        }

        #endregion
    }
}
