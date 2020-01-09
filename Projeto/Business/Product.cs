using System;
using DimStock.Auxiliary;
using DimStock.Report;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;

namespace DimStock.Business
{
    public class Product
    {
        #region Constructors

        public Product() { }

        public Product(DataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion

        #region BussinesProperties
        public int Id { get; set; }
        public int Code { get; set; }
        public int Size { get; set; }
        public int Reference { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SalePrice { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string BarCode { get; set; }
        public string PhotoName { get; set; }
        public List<Product> ListOfRecords { get; set; }
        #endregion 

        #region SearchProperties

        public string SearchByCode { get; set; }
        public string SearchBySize { get; set; }
        public string SearchByReference { get; set; }
        public string SearchByDescription { get; set; }
        public DataPagination DataPagination { get; set; }

        #endregion

        #region Methods

        public bool Register()
        {
            using (var connection = new Connection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"INSERT INTO Product (Code, [Size], Reference, Supplier, 
                    Description, CostPrice, SalePrice, MinStock, MaxStock, BarCode, PhotoName) VALUES
                    (@Code, @Size, @Reference, @Supplier, @Description, @CostPrice, @SalePrice, 
                    @MinStock, @MaxStock, @BarCode, @PhotoName)";

                    connection.AddParameter("@Code", OleDbType.Integer, Code);
                    connection.AddParameter("@Size", OleDbType.Integer, Size);
                    connection.AddParameter("@Reference", OleDbType.Integer, Reference);
                    connection.AddParameter("@Supplier", OleDbType.VarChar, Supplier);
                    connection.AddParameter("@Description", OleDbType.VarChar, Description);
                    connection.AddParameter("@CostPrice", OleDbType.Double, CostPrice);
                    connection.AddParameter("@SalePrice", OleDbType.Double, SalePrice);
                    connection.AddParameter("@MinStock", OleDbType.Integer, MinStock);
                    connection.AddParameter("@MaxStock", OleDbType.Integer, MaxStock);
                    connection.AddParameter("@BarCode", OleDbType.VarChar, BarCode);
                    connection.AddParameter("@PhotoName", OleDbType.VarChar, PhotoName);

                    bool transactionState = false;

                    if (connection.ExecuteTransaction(sqlCommand) > 0)
                    {
                        Id = Convert.ToInt32(connection.ExecuteScalar("SELECT MAX(Id) From Product"));

                        var stock = new Stock();

                        if (stock.RegisterRelatedProduct(connection, Id) == true)
                        {
                            connection.Transaction.Commit();
                            transactionState = true;
                            Notification.Message = "Produto cadastrado com sucesso!";
                        }
                    }

                    return transactionState;
                }
            }
        }

        public bool Edit(int id)
        {
            using (var connection = new Connection())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"UPDATE Product Set Code = @Code, 
                    [Size] = @Size, Reference = @Reference, Supplier = @Supplier, 
                    Description = @Description, CostPrice = @CostPrice, SalePrice = @SalePrice, 
                    MinStock = @MinStock, MaxStock = @MaxStock, BarCode = @BarCode, 
                    PhotoName = @PhotoName WHERE Id = @Id";

                    connection.AddParameter("@Code", OleDbType.Integer, Code);
                    connection.AddParameter("@Size", OleDbType.Integer, Size);
                    connection.AddParameter("@Reference", OleDbType.Integer, Reference);
                    connection.AddParameter("@Supplier", OleDbType.VarChar, Supplier);
                    connection.AddParameter("@Description", OleDbType.VarChar, Description);
                    connection.AddParameter("@CostPrice", OleDbType.Double, CostPrice);
                    connection.AddParameter("@SalePrice", OleDbType.Double, SalePrice);
                    connection.AddParameter("@MinStock", OleDbType.Integer, MinStock);
                    connection.AddParameter("@MaxStock", OleDbType.Integer, MaxStock);
                    connection.AddParameter("@BarCode", OleDbType.VarChar, BarCode);
                    connection.AddParameter("@PhotoName", OleDbType.VarChar, PhotoName);
                    connection.AddParameter("@Id", OleDbType.Integer, id);

                    bool transactionState = false;

                    if (connection.ExecuteTransaction(sqlCommand) > 0)
                    {
                        var sqlQuery = @"SELECT CostPrice FROM 
                        Product WHERE Id = @Id";

                        connection.ParameterClear();
                        connection.AddParameter("@Id",
                        OleDbType.Integer, id);

                        var costPrice = Convert.ToDouble(
                        connection.ExecuteScalar(sqlQuery));

                        var stock = new Stock();

                        if (stock.UpdateValue(connection, costPrice, id) == true)
                        {
                            connection.Transaction.Commit();
                            transactionState = true;
                            Notification.Message = "Produto alterado com sucesso!";
                        }
                    };

                    return transactionState;
                }
            }
        }

        public bool Delete(int id)
        {
            using (var connection = new Connection())
            {
                var deleteState = false;
                var sqlCommand = string.Empty;

                sqlCommand = @"DELETE FROM Product WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    Notification.Message = "Produto deletado com sucesso!";
                    deleteState = true;
                }
                else
                {
                    Notification.Message = @"Esse produto já foi deletado, 
                    atualize a lista de dados!";
                }

                return deleteState;
            }
        }

        public void ListData()
        {
            using (var connection = new Connection())
            {

                var parameter = connection.Command.Parameters;
                var criterion = string.Empty;
                var sqlQuery = string.Empty;
                var productList = new List<Product>();

                sqlQuery = @"SELECT Id, Code, [Size], Reference, Supplier, Description, 
                CostPrice, SalePrice, PhotoName FROM Product WHERE Id > 0";

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
                            Supplier = Convert.ToString(reader["Supplier"]),
                            Description = Convert.ToString(reader["Description"]),
                            Size = Convert.ToInt32(reader["Size"]),
                            CostPrice = Convert.ToDouble(reader["CostPrice"]),
                            SalePrice = Convert.ToDouble(reader["SalePrice"]),
                            PhotoName = Convert.ToString(reader["PhotoName"])
                        };

                        productList.Add(product);
                    }

                    ListOfRecords = productList;
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

                sqlQuery = @"SELECT Id, Code, [Size], Reference, Supplier, Description, 
                CostPrice, SalePrice, PhotoName FROM Product WHERE Id > 0";

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

                PassDataTableToList(dataTable);
            }
        }

        public void ViewDetails(int id)
        {
            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT Id, Code, [Size], Reference, Supplier, 
                Description, MinStock, MaxStock, CostPrice, SalePrice, PhotoName, 
                BarCode From Product Where Id = @Id ";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id"]);
                        Code = Convert.ToInt32(reader["Code"]);
                        Size = Convert.ToInt32(reader["Size"]);
                        Reference = Convert.ToInt32(reader["Reference"]);
                        Supplier = Convert.ToString(reader["Supplier"]);
                        Description = Convert.ToString(reader["Description"]);
                        MinStock = Convert.ToInt32(reader["MinStock"]);
                        MaxStock = Convert.ToInt32(reader["MaxStock"]);
                        CostPrice = Convert.ToDouble(reader["CostPrice"]);
                        SalePrice = Convert.ToDouble(reader["SalePrice"]);
                        PhotoName = reader["PhotoName"].ToString();
                        BarCode = reader["BarCode"].ToString();
                    }
                }
            }
        }

        public void GenerateReport(List<Product> listOfRecords)
        {
            var product = new ReportProduct();
            product.GenerateReport(listOfRecords);
        }

        public void PassDataTableToList(DataTable dataTable)
        {
            var productList = new List<Product>();

            foreach (DataRow row in dataTable.Rows)
            {
                var product = new Product()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Code = Convert.ToInt32(row["Code"]),
                    Size = Convert.ToInt32(row["Size"]),
                    Reference = Convert.ToInt32(row["Reference"]),
                    Supplier = Convert.ToString(row["Supplier"]),
                    Description = Convert.ToString(row["Description"]),
                    CostPrice = Convert.ToDouble(row["CostPrice"]),
                    SalePrice = Convert.ToDouble(row["SalePrice"]),
                    PhotoName = Convert.ToString(row["PhotoName"])
                };

                productList.Add(product);
            }

            ListOfRecords = productList;
        }

        #endregion
    }
}
