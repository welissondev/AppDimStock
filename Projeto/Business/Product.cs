using DimStock.Auxiliarys;
using DimStock.Interfaces;
using DimStock.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace DimStock.Business
{
    public class Product : IReport<Product>
    {
        #region Builder

        public Product()
        {
            Category = new ProductCategory();
        }

        public Product(AxlDataPage pagination)
        {
            Pagination = pagination;
            Category = new ProductCategory();
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
        public ProductCategory Category { get; set; }
        public AxlDataPage Pagination { get; set; }
        public List<Product> List { get; set; }

        #endregion 

        #region Function

        public bool Save()
        {
            using (var connection = new DatabaseConnection())
            {
                bool transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"INSERT INTO Product 
                    (ProductCategoryId, InternalCode, Description, CostPrice, 
                    SalePrice, BarCode, Photo) VALUES (@ProductCategoryId, @Code, 
                    @InternalCode, @CostPrice, @SalePrice, @BarCode, @Photo)";

                    connection.AddParameter("@ProductCategoryId", OleDbType.Integer, Category.Id);
                    connection.AddParameter("@InternalCode", OleDbType.VarChar, InternalCode);
                    connection.AddParameter("@Description", OleDbType.VarChar, Description);
                    connection.AddParameter("@CostPrice", OleDbType.Double, CostPrice);
                    connection.AddParameter("@SalePrice", OleDbType.Double, SalePrice);
                    connection.AddParameter("@BarCode", OleDbType.VarChar, BarCode);
                    connection.AddParameter("@Photo", OleDbType.VarChar, Photo);

                    transactionState = connection.ExecuteTransaction(
                    sqlCommand) > 0;


                    //Pegar id do último registro inserido
                    Id = Convert.ToInt32(connection.ExecuteScalar(
                    "SELECT MAX(Id) From Product"));


                    //Relacionar o produto ao stock
                    var stock = new Stock(connection);
                    transactionState = stock.RelateProduct(Id);


                    //Registrar histórico do usuário
                    var userHistory = new UserHistory(connection)
                    {
                        OperationType = "Cadastrou",
                        OperationModule = "Produto",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = GetAffectedFields(Id, connection)
                    };

                    userHistory.User.Id = AxlLogin.Id;

                    transactionState = userHistory.Save();


                    //Fianalizar transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Produto cadastrado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Edit(int id)
        {
            using (var connection = new DatabaseConnection())
            {
                bool transactionState = false;

                var affectedFields = GetAffectedFields(id, connection);

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"UPDATE Product Set ProductCategoryId = @ProductCategoryId, 
                    InternalCode = @InternalCode, Description = @Description, CostPrice = @CostPrice, 
                    SalePrice = @SalePrice, BarCode = @BarCode, 
                    Photo = @Photo WHERE Id = @Id";

                    connection.ParameterClear();
                    connection.AddParameter("@ProductCategoryId", OleDbType.Integer, Category.Id);
                    connection.AddParameter("@InternalCode", OleDbType.VarChar, InternalCode);
                    connection.AddParameter("@Description", OleDbType.VarChar, Description);
                    connection.AddParameter("@CostPrice", OleDbType.Double, CostPrice);
                    connection.AddParameter("@SalePrice", OleDbType.Double, SalePrice);
                    connection.AddParameter("@BarCode", OleDbType.VarChar, BarCode);
                    connection.AddParameter("@Photo", OleDbType.VarChar, Photo);
                    connection.AddParameter("@Id", OleDbType.Integer, id);

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Seleciona preço de costo do produto
                    var sqlQuery = @"SELECT CostPrice FROM 
                    Product WHERE Id = @Id";

                    connection.ParameterClear();
                    connection.AddParameter("@Id",
                    OleDbType.Integer, id);

                    var costPrice = Convert.ToDouble(
                    connection.ExecuteScalar(sqlQuery));

                    //Atualiza o valor no estoque
                    var stock = new Stock(connection);
                    transactionState = stock.UpdateValue(
                    costPrice, id);

                    //Registrar histórico do usuário
                    var history = new UserHistory(connection)
                    {
                        OperationType = "Editou",
                        OperationModule = "Produto",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };

                    history.User.Id = AxlLogin.Id;

                    transactionState = history.Save();

                    //Fianaliza a transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Produto alterado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Remove(int id)
        {
            if (CheckIfExists(id) == false)
            {
                AxlMessageNotifier.Message = "Esse registro já foi excluido, " +
               "atualize a lista de dados!";

                return false;
            }

            using (var connection = new DatabaseConnection())
            {
                var sqlCommand = string.Empty;
                var transactionState = false;

                //Pega campos afetados
                var affectedFields = GetAffectedFields(id, connection);

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    sqlCommand = @"DELETE FROM Product WHERE Id = @Id";
                    connection.AddParameter("@Id", OleDbType.Integer, id);

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Registrar histórico do usuário
                    var history = new UserHistory(connection)
                    {
                        OperationType = "Deletou",
                        OperationModule = "Produto",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };

                    history.User.Id = AxlLogin.Id;

                    transactionState = history.Save();

                    //Fianaliza transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Produto deletado com sucesso!";
                }

                return transactionState;
            }
        }

        public void GetDetail(int id)
        {
            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = @"SELECT Product.*, ProductCategory.* FROM Product
                LEFT JOIN ProductCategory ON Product.ProductCategoryId = ProductCategory.Id
                WHERE Product.Id = @Id ";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Product.Id"]);


                        bool convert = int.TryParse(reader[
                        "ProductCategory.Id"].ToString(),
                        out int result);

                        if (convert != false)
                            Category.Id = result;

                        Category.Description = Convert.ToString(
                        reader["ProductCategory.Description"]);

                        InternalCode = Convert.ToString(reader["InternalCode"]);
                        Description = Convert.ToString(reader["Product.Description"]);
                        CostPrice = Convert.ToDouble(reader["CostPrice"]);
                        SalePrice = Convert.ToDouble(reader["SalePrice"]);
                        Photo = reader["Photo"].ToString();
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
            using (var connection = new DatabaseConnection())
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

                sqlQuery += criterion + " Order By InternalCode";

                sqlCount += criterion;

                Pagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                Pagination.OffSetValue,
                Pagination.PageSize);

                PassToList(dataTable);
            }
        }

        public void ListData()
        {
            using (var connection = new DatabaseConnection())
            {
                var parameter = connection.Command.Parameters;
                var criterion = string.Empty;
                var sqlQuery = string.Empty;

                sqlQuery = @"SELECT Id, InternalCode, Description, 
                CostPrice, SalePrice, Photo FROM Product WHERE Id > 0";

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

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Description = Convert.ToString(reader["Description"]),
                            InternalCode = Convert.ToString(reader["InternalCode"]),
                            CostPrice = Convert.ToDouble(reader["CostPrice"]),
                            SalePrice = Convert.ToDouble(reader["SalePrice"]),
                            Photo = Convert.ToString(reader["Photo"])
                        };

                        List.Add(product);
                    }
                }
            }
        }

        public bool CheckIfExists(int id)
        {
            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = "SELECT Id FROM Product WHERE Id = @Id";
                var recordsFound = 0;

                connection.AddParameter("Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
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
                    Photo = Convert.ToString(row["Photo"])
                };

                List.Add(product);
            }
        }

        private string GetAffectedFields(int id, DatabaseConnection connection)
        {
            var affectedFieldList = new List<string>();

            var commandSQL = @"SELECT * From Product Where Id = @Id";

            connection.ParameterClear();
            connection.AddParameter("@Id", OleDbType.Integer, id);

            using (var dataReader = connection.QueryWithDataReader(commandSQL))
            {
                while (dataReader.Read())
                {
                    affectedFieldList.Add("Id:" + dataReader["Id"].ToString());
                    affectedFieldList.Add("Código:" + dataReader["InternalCode"].ToString());
                    affectedFieldList.Add("Descrição:" + dataReader["Description"].ToString());
                    affectedFieldList.Add("PreçoCusto:" + dataReader["CostPrice"].ToString());
                    affectedFieldList.Add("PreçoVenda:" + dataReader["SalePrice"].ToString());
                    affectedFieldList.Add("CódigoBarras:" + dataReader["BarCode"].ToString());
                    affectedFieldList.Add("FotoNome:" + dataReader["Photo"].ToString());
                }
            }

            return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
        }

        #endregion
    }
}
