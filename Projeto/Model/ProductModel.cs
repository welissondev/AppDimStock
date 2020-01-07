using DimStock.Business;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace DimStock.Model
{
    public class ProductModel
    {
        #region Properties
        private readonly ProductController product;
        #endregion

        #region Constructs
        public ProductModel(ProductController product)
        {
            this.product = product;
        }
        #endregion

        #region Methods
        public bool Insert()
        {
            using (var connection = new ConnectionModel())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"INSERT INTO Product (Code, [Size], Reference, Supplier, 
                    Description, CostPrice, SalePrice, MinStock, MaxStock, BarCode, PhotoName) VALUES
                    (@Code, @Size, @Reference, @Supplier, @Description, @CostPrice, @SalePrice, 
                    @MinStock, @MaxStock, @BarCode, @PhotoName)";

                    connection.AddParameter("@Code", OleDbType.Integer, product.Code);
                    connection.AddParameter("@Size", OleDbType.Integer, product.Size);
                    connection.AddParameter("@Reference", OleDbType.Integer, product.Reference);
                    connection.AddParameter("@Supplier", OleDbType.VarChar, product.Supplier);
                    connection.AddParameter("@Description", OleDbType.VarChar, product.Description);
                    connection.AddParameter("@CostPrice", OleDbType.Double, product.CostPrice);
                    connection.AddParameter("@SalePrice", OleDbType.Double, product.SalePrice);
                    connection.AddParameter("@MinStock", OleDbType.Integer, product.MinStock);
                    connection.AddParameter("@MaxStock", OleDbType.Integer, product.MaxStock);
                    connection.AddParameter("@BarCode", OleDbType.VarChar, product.BarCode);
                    connection.AddParameter("@PhotoName", OleDbType.VarChar, product.PhotoName);

                    bool transactionState = false;

                    if (connection.ExecuteTransaction(sqlCommand) > 0)
                    {
                        product.Id = Convert.ToInt32(connection.ExecuteScalar("SELECT MAX(Id) From Product"));

                        var stock = new StockModel();

                        if (stock.InsertRelatedProduct(connection, product.Id) == true)
                        {
                            connection.Transaction.Commit();
                            transactionState = true;
                            NotificationController.Message = "Produto cadastrado com sucesso!";
                        }
                    }

                    return transactionState;
                }
            }
        }

        public bool Update(int id)
        {
            using (var connection = new ConnectionModel())
            {
                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"UPDATE Product Set Code = @Code, 
                    [Size] = @Size, Reference = @Reference, Supplier = @Supplier, 
                    Description = @Description, CostPrice = @CostPrice, SalePrice = @SalePrice, 
                    MinStock = @MinStock, MaxStock = @MaxStock, BarCode = @BarCode, 
                    PhotoName = @PhotoName WHERE Id = @Id";

                    connection.AddParameter("@Code", OleDbType.Integer, product.Code);
                    connection.AddParameter("@Size", OleDbType.Integer, product.Size);
                    connection.AddParameter("@Reference", OleDbType.Integer, product.Reference);
                    connection.AddParameter("@Supplier", OleDbType.VarChar, product.Supplier);
                    connection.AddParameter("@Description", OleDbType.VarChar, product.Description);
                    connection.AddParameter("@CostPrice", OleDbType.Double, product.CostPrice);
                    connection.AddParameter("@SalePrice", OleDbType.Double, product.SalePrice);
                    connection.AddParameter("@MinStock", OleDbType.Integer, product.MinStock);
                    connection.AddParameter("@MaxStock", OleDbType.Integer, product.MaxStock);
                    connection.AddParameter("@BarCode", OleDbType.VarChar, product.BarCode);
                    connection.AddParameter("@PhotoName", OleDbType.VarChar, product.PhotoName);
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

                        var stock = new StockModel();

                        if (stock.UpdateValue(connection, costPrice, id) == true)
                        {
                            connection.Transaction.Commit();
                            transactionState = true;
                            NotificationController.Message = "Produto alterado com sucesso!";
                        }
                    };

                    return transactionState;
                }
            }
        }

        public bool Delete(int id)
        {
            using (var connection = new ConnectionModel())
            {
                var deleteState = false;
                var sqlCommand = string.Empty;

                sqlCommand = @"DELETE FROM Product WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    NotificationController.Message = "Produto deletado com sucesso!";
                    deleteState = true;
                }
                else
                {
                    NotificationController.Message = @"Esse produto já foi deletado, 
                    atualize a lista de dados!";
                }

                return deleteState;
            }
        }

        public void DataQuery()
        {
            using (var connection = new ConnectionModel())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var criterion = string.Empty;
                var parameter = connection.Command.Parameters;

                sqlQuery = @"SELECT Id, Code, [Size], Reference, Supplier, Description, 
                CostPrice, SalePrice, PhotoName FROM Product WHERE Id > 0";

                sqlCount = @"SELECT COUNT(*) FROM Product WHERE Id > 0";

                if (product.SearchByCode != string.Empty)
                {
                    criterion += " AND Code LIKE @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    product.SearchByCode));
                }

                if (product.SearchBySize != string.Empty)
                {
                    criterion += " AND [Size] LIKE @Size";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                    product.SearchBySize));
                }

                if (product.SearchByReference != string.Empty)
                {
                    criterion += " AND Reference LIKE @Reference";

                    parameter.AddWithValue("@Reference", string.Format("{0}",
                    product.SearchByReference));
                }

                if (product.SearchByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    product.SearchByDescription));
                }

                sqlQuery += criterion + " Order By [Code],[Size],[Reference]";

                sqlCount += criterion;
  
                product.DataPagination.RecordCount = Convert.ToInt32(
                connection.ExecuteScalar(sqlCount));
                
                var dataTable = connection.QueryWithDataTable(sqlQuery,
                product.DataPagination.OffSetValue,
                product.DataPagination.PageSize);

                PassDataTableToList(dataTable);          
            }
        }

        public void ListData()
        {
            using (var connection = new ConnectionModel())
            {
                
                var parameter = connection.Command.Parameters;
                var criterion = string.Empty;
                var sqlQuery = string.Empty;
                var productList = new List<ProductController>();
                              
                sqlQuery = @"SELECT Id, Code, [Size], Reference, Supplier, Description, 
                CostPrice, SalePrice, PhotoName FROM Product WHERE Id > 0";
                               
                if (product.SearchByCode != string.Empty)
                {
                    criterion += " AND Code = @Code";

                    parameter.AddWithValue("@Code", string.Format("{0}",
                    product.SearchByCode));
                }
                
                if (product.SearchBySize != string.Empty)
                {
                    criterion += " AND [Size] = @Size";

                    parameter.AddWithValue("@Size", string.Format("{0}",
                    product.SearchBySize));
                }
                
                if (product.SearchByReference != string.Empty)
                {
                    criterion += " AND Reference = @Reference";

                    parameter.AddWithValue("@Reference", string.Format("{0}",
                    product.SearchByReference));
                }
                
                if (product.SearchByDescription != string.Empty)
                {
                    criterion += " AND Description LIKE @Description";

                    parameter.AddWithValue("@Description", string.Format("%{0}%",
                    product.SearchByDescription));
                }
                
                sqlQuery += criterion + " Order By Code, [Size], Reference Asc";
                
                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var product = new ProductController
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

                    product.ListOfRecords = productList;
                }
                
            }
        }
       
        public void ViewDetails(int id)
        {
            using (var connection = new ConnectionModel())
            {
                var sqlQuery = @"SELECT Id, Code, [Size], Reference, Supplier, 
                Description, MinStock, MaxStock, CostPrice, SalePrice, PhotoName, 
                BarCode From Product Where Id = @Id ";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        product.Id = Convert.ToInt32(reader["Id"]);
                        product.Code = Convert.ToInt32(reader["Code"]);
                        product.Size = Convert.ToInt32(reader["Size"]);
                        product.Reference = Convert.ToInt32(reader["Reference"]);
                        product.Supplier = Convert.ToString(reader["Supplier"]);
                        product.Description = Convert.ToString(reader["Description"]);
                        product.MinStock = Convert.ToInt32(reader["MinStock"]);
                        product.MaxStock = Convert.ToInt32(reader["MaxStock"]);
                        product.CostPrice = Convert.ToDouble(reader["CostPrice"]);
                        product.SalePrice = Convert.ToDouble(reader["SalePrice"]);
                        product.PhotoName = Convert.ToString(reader["PhotoName"]);
                        product.BarCode = Convert.ToString(reader["BarCode"]);
                    }
                }
            }
        }
        
        public string GetAffectedFields(int id)
        {
            using (var connection = new ConnectionModel())
            {
                var affectedFieldList = new List<string>();

                var sqlQuery = @"SELECT * From Product Where Id = @Id ";

                connection.AddParameter("Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        affectedFieldList.Add("Id:" + reader["Id"].ToString());
                        affectedFieldList.Add("Código:" + reader["Code"].ToString());
                        affectedFieldList.Add("Referência:" + reader["Reference"].ToString());
                        affectedFieldList.Add("Fornecedor:" + reader["Supplier"].ToString());
                        affectedFieldList.Add("Descrição:" + reader["Description"].ToString());
                        affectedFieldList.Add("Tamanho:" + reader["Size"].ToString());
                        affectedFieldList.Add("PreçoCusto:" + reader["CostPrice"].ToString());
                        affectedFieldList.Add("PreçoVenda:" + reader["SalePrice"].ToString());
                        affectedFieldList.Add("CódigoBarras:" + reader["BarCode"].ToString());
                        affectedFieldList.Add("FotoNome:" + reader["PhotoName"].ToString());
                    }
                }

                return string.Join(" | ", affectedFieldList.Select(x => x.ToString()));
            }
        }

        public bool CheckIfCodeExists()
        {
            using (var connection = new ConnectionModel())
            {
                var recordsFounds = 0;
                var sqlQuery = string.Empty;

                sqlQuery = @"SELECT Code FROM Product WHERE Code LIKE @Code";

                connection.AddParameter("@Code", OleDbType.Integer, product.Code);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        recordsFounds += 1;
                    }

                }

                return recordsFounds > 0;
            }
        }

        private void PassDataTableToList(DataTable dataTable)
        {
            var productList = new List<ProductController>();

            foreach (DataRow row in dataTable.Rows)
            {
                var product = new ProductController()
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

            product.ListOfRecords = productList;
        }
        #endregion
    }
}
