using DimStock.Auxiliarys;
using DimStock.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using DimStock.Interfaces;

namespace DimStock.Business
{
    public class Product : IReport<Product>
    {
        #region Constructors

        public Product()
        {
            Category = new ProductCategory();

            List = new List<Product>();
        }

        public Product(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;

            Category = new ProductCategory();

            List = new List<Product>();
        }

        #endregion

        #region BussinesProperties
        public int Id { get; set; }
        public int Code { get; set; }
        public int Size { get; set; }
        public int Reference { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public string BarCode { get; set; }
        public string PhotoPath { get; set; }
        public ProductCategory Category { get; set; }
        public List<Product> List { get; set; }
        #endregion 

        #region SearchProperties

        public string SearchByCode { get; set; }
        public string SearchBySize { get; set; }
        public string SearchByReference { get; set; }
        public string SearchByDescription { get; set; }
        public AxlDataPagination DataPagination { get; set; }

        #endregion

        #region Methods

        public bool Register()
        {
            using (var connection = new Connection())
            {
                bool transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"INSERT INTO Product 
                    (ProductCategoryId, Code, [Size], Reference, Description, CostPrice, 
                    SalePrice, BarCode, PhotoPath) VALUES (@ProductCategoryId, @Code, 
                    @Size, @Reference, @Description, @CostPrice, @SalePrice, @BarCode, @PhotoPath)";

                    connection.AddParameter("@ProductCategoryId", OleDbType.Integer, Category.Id);
                    connection.AddParameter("@Code", OleDbType.Integer, Code);
                    connection.AddParameter("@Size", OleDbType.Integer, Size);
                    connection.AddParameter("@Reference", OleDbType.Integer, Reference);
                    connection.AddParameter("@Description", OleDbType.VarChar, Description);
                    connection.AddParameter("@CostPrice", OleDbType.Double, CostPrice);
                    connection.AddParameter("@SalePrice", OleDbType.Double, SalePrice);
                    connection.AddParameter("@BarCode", OleDbType.VarChar, BarCode);
                    connection.AddParameter("@PhotoPath", OleDbType.VarChar, PhotoPath);

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
                        UserId = AxlLogin.Id,
                        OperationType = "Cadastrou",
                        OperationModule = "Produto",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = GetAffectedFields(Id, connection)
                    };
                    transactionState = userHistory.Register();


                    //Fianalizar transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Produto cadastrado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Edit(int id)
        {
            using (var connection = new Connection())
            {
                bool transactionState = false;

                var affectedFields = GetAffectedFields(id, connection);

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"UPDATE Product Set ProductCategoryId = @ProductCategoryId, Code = @Code, 
                    [Size] = @Size, Reference = @Reference, Description = @Description, CostPrice = @CostPrice, 
                    SalePrice = @SalePrice, BarCode = @BarCode, 
                    PhotoPath = @PhotoPath WHERE Id = @Id";

                    connection.ParameterClear();
                    connection.AddParameter("@ProductCategoryId", OleDbType.Integer, Category.Id);
                    connection.AddParameter("@Code", OleDbType.Integer, Code);
                    connection.AddParameter("@Size", OleDbType.Integer, Size);
                    connection.AddParameter("@Reference", OleDbType.Integer, Reference);
                    connection.AddParameter("@Description", OleDbType.VarChar, Description);
                    connection.AddParameter("@CostPrice", OleDbType.Double, CostPrice);
                    connection.AddParameter("@SalePrice", OleDbType.Double, SalePrice);
                    connection.AddParameter("@BarCode", OleDbType.VarChar, BarCode);
                    connection.AddParameter("@PhotoPath", OleDbType.VarChar, PhotoPath);
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
                    var userHistory = new UserHistory(connection)
                    {
                        UserId = AxlLogin.Id,
                        OperationType = "Editou",
                        OperationModule = "Produto",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };
                    transactionState = userHistory.Register();

                    //Fianaliza a transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Produto alterado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Delete(int id)
        {
            if (CheckIfRegisterExists(id) == false)
            {
                AxlMessageNotifier.Message = "Esse registro já foi excluido, " +
               "atualize a lista de dados!";

                return false;
            }

            using (var connection = new Connection())
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
                    var userHistory = new UserHistory(connection)
                    {
                        UserId = AxlLogin.Id,
                        OperationType = "Deletou",
                        OperationModule = "Produto",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };
                    transactionState = userHistory.Register();

                    //Fianaliza transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Produto deletado com sucesso!";
                }

                return transactionState;
            }
        }

        public void ListData()
        {
            using (var connection = new Connection())
            {
                var parameter = connection.Command.Parameters;
                var criterion = string.Empty;
                var sqlQuery = string.Empty;

                sqlQuery = @"SELECT Id, Code, [Size], Reference, Description, 
                CostPrice, SalePrice, PhotoPath FROM Product WHERE Id > 0";

                if (SearchByCode != string.Empty)
                {
                    criterion += " AND Code = @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    SearchByCode));
                }

                if (SearchBySize != string.Empty)
                {
                    criterion += " AND [Size] = @Size";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                    SearchBySize));
                }

                if (SearchByReference != string.Empty)
                {
                    criterion += " AND Reference = @Reference";

                    parameter.AddWithValue("@Reference", string.Format("{0}",
                    SearchByReference));
                }

                if (SearchByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    SearchByDescription));
                }

                sqlQuery += criterion + " Order By Code, [Size], Reference Asc";

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var product = new Product
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Code = Convert.ToInt32(reader["Code"]),
                            Reference = Convert.ToInt32(reader["Reference"]),
                            Description = Convert.ToString(reader["Description"]),
                            Size = Convert.ToInt32(reader["Size"]),
                            CostPrice = Convert.ToDouble(reader["CostPrice"]),
                            SalePrice = Convert.ToDouble(reader["SalePrice"]),
                            PhotoPath = Convert.ToString(reader["PhotoPath"])
                        };

                        List.Add(product);
                    }
                }
            }
        }

        public void SearchData()
        {
            using (var connection = new Connection())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;

                sqlQuery = @"SELECT Id, Code, [Size], Reference, Description, 
                CostPrice, SalePrice, PhotoPath FROM Product WHERE Id > 0";

                sqlCount = @"SELECT COUNT(*) FROM Product WHERE Id > 0";

                if (SearchByCode != string.Empty)
                {
                    criterion += " AND Code LIKE @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    SearchByCode));
                }

                if (SearchBySize != string.Empty)
                {
                    criterion += " AND [Size] LIKE @Size";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                    SearchBySize));
                }

                if (SearchByReference != string.Empty)
                {
                    criterion += " AND Reference LIKE @Reference";

                    parameter.AddWithValue("@Reference", string.Format("{0}",
                    SearchByReference));
                }

                if (SearchByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    SearchByDescription));
                }

                sqlQuery += criterion + " Order By [Code],[Size],[Reference]";

                sqlCount += criterion;

                DataPagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                DataPagination.OffSetValue,
                DataPagination.PageSize);

                PassToList(dataTable);
            }
        }

        public void ViewDetails(int id)
        {
            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT Product.*, ProductCategory.* FROM Product
                left join ProductCategory ON Product.ProductCategoryId = ProductCategory.Id
                WHERE Product.Id = @Id ";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Product.Id"]);

                        if (!reader.IsDBNull(4))
                            Category.Id = Convert.ToInt32(
                            reader["ProductCategory.Id"]);

                        if (!reader.IsDBNull(5))
                            Category.Description = Convert.ToString(
                            reader["ProductCategory.Description"]);

                        Code = Convert.ToInt32(reader["Code"]);
                        Size = Convert.ToInt32(reader["Size"]);
                        Reference = Convert.ToInt32(reader["Reference"]);
                        Description = Convert.ToString(reader["Product.Description"]);
                        CostPrice = Convert.ToDouble(reader["CostPrice"]);
                        SalePrice = Convert.ToDouble(reader["SalePrice"]);
                        PhotoPath = reader["PhotoPath"].ToString();
                        BarCode = reader["BarCode"].ToString();
                    }
                }
            }
        }

        public void GenerateReport(List<Product> list)
        {
            var product = new ReportProduct();
            ListData(); product.GenerateReport(list);
        }

        public void PassToList(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                var product = new Product()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Code = Convert.ToInt32(row["Code"]),
                    Size = Convert.ToInt32(row["Size"]),
                    Reference = Convert.ToInt32(row["Reference"]),
                    Description = Convert.ToString(row["Description"]),
                    CostPrice = Convert.ToDouble(row["CostPrice"]),
                    SalePrice = Convert.ToDouble(row["SalePrice"]),
                    PhotoPath = Convert.ToString(row["PhotoPath"])
                };

                List.Add(product);
            }
        }

        public string GetAffectedFields(int id, Connection connection)
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
                    affectedFieldList.Add("Código:" + dataReader["Code"].ToString());
                    affectedFieldList.Add("Tamanho:" + dataReader["Size"].ToString());
                    affectedFieldList.Add("Referência:" + dataReader["Reference"].ToString());
                    affectedFieldList.Add("Descrição:" + dataReader["Description"].ToString());
                    affectedFieldList.Add("PreçoCusto:" + dataReader["CostPrice"].ToString());
                    affectedFieldList.Add("PreçoVenda:" + dataReader["SalePrice"].ToString());
                    affectedFieldList.Add("CódigoBarras:" + dataReader["BarCode"].ToString());
                    affectedFieldList.Add("FotoNome:" + dataReader["PhotoPath"].ToString());
                }
            }

            return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
        }

        public bool CheckIfRegisterExists(int id)
        {
            using (var connection = new Connection())
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

        #endregion
    }
}
