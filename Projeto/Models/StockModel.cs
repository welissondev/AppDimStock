using DimStock.Reports;
using System;
using System.Collections.Generic;
using System.Data;

/// <summary>
/// Definições das propriedades
/// </summary>
namespace DimStock.Models
{
    public partial class StockModel
    {
        private string summary = "All";
        private TransactionModel transaction;

        public int Id { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Quantity { get; set; }
        public double TotalValue { get; set; }
        public string Result { get; set; }
        public string Summary { get => summary; set => summary = value; }
        public ProductModel Product { get; set; }

    }
}


/// <summary>
/// Construtores da classe
/// </summary>
namespace DimStock.Models
{
    public partial class StockModel
    {
        public StockModel()
        {
            Product = new ProductModel();
        }

        public StockModel(TransactionModel transaction)
        {
            this.transaction = transaction;
        }
    }
}

/// <summary>
/// Métodos e funções
/// </summary>
namespace DimStock.Models
{
    public partial class StockModel
    {
        public DataTable ListData()
        {
            using (var db = new ConnectionModel())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var sqlLink = string.Empty;

                switch (summary)
                {
                    case "All":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Stock INNER JOIN Product ON 
                        Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.Min, Stock.Max, Stock.TotalValue, 
                        Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, 
                        Product.Photo From Product INNER JOIN Stock ON Stock.ProductId = 
                        Product.Id WHERE Stock.Id > 0";

                        break;

                    case "Nothing":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                        Stock.ProductId = Product.Id WHERE Quantity = 0 AND Stock.Min = 0 
                        AND Stock.Max = 0";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                        Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo 
                        From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                        Quantity = 0 AND Stock.Min = 0 AND Stock.Max = 0";

                        break;

                    case "Ok":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                        Product.Id = Stock.ProductId WHERE Quantity > 0 AND Quantity >= 
                        Stock.Min AND Quantity <= Stock.Max";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max, 
                        Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo 
                        From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Quantity > 0 
                        AND Quantity >= Stock.Min AND Quantity <= Stock.Max";

                        break;

                    case "High":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                        Stock.ProductId = Product.Id WHERE Stock.Quantity > Stock.Max";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, 
                        Stock.Max, Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, 
                        Product.Photo From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                        Stock.Quantity > Stock.Max";

                        break;

                    case "Low":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                        Stock.ProductId = Product.Id WHERE Stock.Quantity < Stock.Min";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                        Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo From 
                        Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                        Stock.Quantity < Stock.Min";

                        break;
                }

                if (Product.InternalCode != string.Empty)
                {
                    sqlLink += " AND InternalCode LIKE @InternalCode";

                    db.AddParameter("@InternalCode", string.Format("{0}%",
                    Product.InternalCode));
                }
                if (Product.Description != string.Empty)
                {
                    sqlLink += " AND Description LIKE @Description";

                    db.AddParameter("@Description", string.Format("%{0}%",
                    Product.Description));
                }

                sqlQuery += sqlLink + " Order By InternalCode Asc";
                sqlCount += sqlLink;

                return db.GetTable(sqlQuery);
            }
        }
        public DataTable FetchData()
        {
            using (var db = new ConnectionModel())
            {
                var sqlQuery = string.Empty;
                var sqlCount = string.Empty;
                var sqlLink = string.Empty;

                switch (summary)
                {
                    case "All":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Stock INNER JOIN Product ON 
                        Stock.ProductId = Product.Id WHERE Stock.Id > 0";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.Min, Stock.Max, Stock.TotalValue, 
                        Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, 
                        Product.Photo From Product INNER JOIN Stock ON Stock.ProductId = 
                        Product.Id WHERE Stock.Id > 0";

                        break;

                    case "Nothing":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                        Stock.ProductId = Product.Id WHERE Quantity = 0 AND Stock.Min = 0 
                        AND Stock.Max = 0";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                        Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo 
                        From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                        Quantity = 0 AND Stock.Min = 0 AND Stock.Max = 0";

                        break;

                    case "Ok":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                        Product.Id = Stock.ProductId WHERE Quantity > 0 AND Quantity >= 
                        Stock.Min AND Quantity <= Stock.Max";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max, 
                        Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo 
                        From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE Quantity > 0 
                        AND Quantity >= Stock.Min AND Quantity <= Stock.Max";

                        break;

                    case "High":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                        Stock.ProductId = Product.Id WHERE Stock.Quantity > Stock.Max";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, 
                        Stock.Max, Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, 
                        Product.Photo From Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                        Stock.Quantity > Stock.Max";

                        break;

                    case "Low":

                        sqlCount = @"SELECT COUNT(Stock.Id) From Product INNER JOIN Stock ON 
                        Stock.ProductId = Product.Id WHERE Stock.Quantity < Stock.Min";

                        sqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.TotalValue, Stock.Min, Stock.Max,
                        Product.Id, Product.Description, Product.CostPrice, Product.InternalCode, Product.Photo From 
                        Product INNER JOIN Stock ON Stock.ProductId = Product.Id WHERE 
                        Stock.Quantity < Stock.Min";

                        break;
                }

                if (Product.InternalCode != string.Empty)
                {
                    sqlLink += " AND InternalCode LIKE @InternalCode";

                    db.AddParameter("@InternalCode", string.Format("{0}%",
                    Product.InternalCode));
                }
                if (Product.Description != string.Empty)
                {
                    sqlLink += " AND Description LIKE @Description";

                    db.AddParameter("@Description", string.Format("%{0}%",
                    Product.Description));
                }

                sqlQuery += sqlLink + " Order By InternalCode Asc";
                sqlCount += sqlLink;

                return db.GetTable(sqlQuery);
            }
        }

        public bool GetDetail()
        {
            var actionResult = false;

            using (var db = new ConnectionModel())
            {
                var sql = @"SELECT Product.Id, Product.InternalCode, Product.Description, 
                Product.CostPrice, Stock.Id, Stock.Quantity FROM Product INNER JOIN 
                Stock ON Product.Id = Stock.ProductId WHERE Product.Id = @Id";

                db.ClearParameter();
                db.AddParameter("@Id", Id);

                using (var reader = db.GetReader(sql))
                {
                    if (reader.FieldCount > 0)
                    {
                        actionResult = true;

                        while (reader.Read())
                        {
                            Id = int.Parse(reader["Stock.Id"].ToString());
                            Product.Id = int.Parse(reader["Product.Id"].ToString());
                            Product.InternalCode = reader["InternalCode"].ToString();
                            Product.Description = reader["Description"].ToString();
                            Product.CostPrice = double.Parse(reader["CostPrice"].ToString());
                            Quantity = int.Parse(reader["Quantity"].ToString());
                        }
                    }
                }
            }

            return actionResult;
        }

        public bool InsertPostingOfEntries(DataTable postingItems)
        {
            var actionResult = false;
            var sql = string.Empty;

            foreach (DataRow item in postingItems.Rows)
            {
                sql = @"UPDATE Stock Set Quantity = Quantity + @ItemQuantity, 
                TotalValue = TotalValue + @ItemTotalValue WHERE Id = @StockId";

                transaction.DataBase.ClearParameter();
                transaction.DataBase.AddParameter("@ItemQuantity", item["Quantity"]);
                transaction.DataBase.AddParameter("@ItemTotalValue", item["TotalValue"]);
                transaction.DataBase.AddParameter("@StockId", item["StockId"]);

                actionResult = transaction.DataBase.ExecuteTransaction(sql) > 0;
            }

            return actionResult;
        }
        public bool InsertPostingOfOutPuts(DataTable postingItems)
        {
            var actionResult = false;
            var sql = string.Empty;

            foreach (DataRow item in postingItems.Rows)
            {
                sql = @"UPDATE Stock Set Quantity = Quantity - @ItemQuantity, 
                TotalValue = TotalValue - @ItemTotalValue WHERE Id = @StockId";

                transaction.DataBase.ClearParameter();
                transaction.DataBase.AddParameter("@ItemQuantity", item["Quantity"]);
                transaction.DataBase.AddParameter("@ItemTotalValue", item["TotalValue"]);
                transaction.DataBase.AddParameter("@StockId", item["StockId"]);

                actionResult = transaction.DataBase.ExecuteTransaction(sql) > 0;
            }

            return actionResult;
        }

        public bool CancelPostingOfEntries(DataTable postedItems)
        {
            var actionResult = false;
            var sql = string.Empty;

            foreach (DataRow item in postedItems.Rows)
            {
                sql = @"UPDATE Stock Set Quantity = Quantity - @ItemQuantity, 
                TotalValue = TotalValue - @ItemTotalValue WHERE Id = @StockId";

                transaction.DataBase.ClearParameter();
                transaction.DataBase.AddParameter("@ItemQuantity", item["Quantity"]);
                transaction.DataBase.AddParameter("@ItemTotalValue", item["TotalValue"]);
                transaction.DataBase.AddParameter("@StockId", item["StockId"]);

                actionResult = transaction.DataBase.ExecuteTransaction(sql) > 0;
            }

            return actionResult;
        }
        public bool CancelPostingOfOutPuts(DataTable postedItems)
        {
            var actionResult = false;
            var sql = string.Empty;

            foreach (DataRow item in postedItems.Rows)
            {
                sql = @"UPDATE Stock Set Quantity = Quantity + @ItemQuantity, 
                TotalValue = TotalValue + @ItemTotalValue WHERE Id = @StockId";

                transaction.DataBase.ClearParameter();
                transaction.DataBase.AddParameter("@ItemQuantity", item["Quantity"]);
                transaction.DataBase.AddParameter("@ItemTotalValue", item["TotalValue"]);
                transaction.DataBase.AddParameter("@StockId", item["StockId"]);

                actionResult = transaction.DataBase.ExecuteTransaction(sql) > 0;
            }

            return actionResult;
        }

        public bool RelateProduct(ProductModel product)
        {
            var sql = @"INSERT INTO Stock(ProductId)VALUES(@ProductId)";

            transaction.DataBase.ClearParameter();
            transaction.DataBase.AddParameter("@ProductId", product.Id);

            return transaction.DataBase.ExecuteTransaction(sql) > 0;
        }

        public void GenerateReport(List<StockModel> list)
        {
            var stock = new StockReport();

            ListData(); stock.GenerateReport(list);
        }

        public bool UpdateValue(ProductModel product)
        {
            var sql = @"UPDATE Stock Set TotalValue = @ProductCostPrice * 
            Quantity WHERE ProductId = @ProductId";

            transaction.DataBase.ClearParameter();
            transaction.DataBase.AddParameter("ProductCostPrice", product.CostPrice);
            transaction.DataBase.AddParameter("@ProductId", product.Id);

            return transaction.DataBase.ExecuteTransaction(sql) > 0;
        }

        public void SetSummary(List<StockModel> listOfRecords)
        {
            for (int i = 0; i < listOfRecords.Count; i++)
            {
                var stockItem = listOfRecords[i];
                var quantity = stockItem.Quantity;
                var minStock = stockItem.Min;
                var maxStock = stockItem.Max;

                if (quantity > 0 && quantity >= minStock && quantity <= maxStock)
                    stockItem.Summary = "OK";

                if (quantity > maxStock)
                    stockItem.Summary = "Alto";

                if (quantity < minStock)
                    stockItem.Summary = "Baixo";

                if (quantity == 0 & minStock == 0 && maxStock == 0)
                    stockItem.Summary = "???";
            }
        }

        public void SetResult(List<StockModel> listOfRecords)
        {
            for (int i = 0; i < listOfRecords.Count; i++)
            {
                var stockItem = listOfRecords[i];
                var quantity = stockItem.Quantity;
                var minStock = stockItem.Min;
                var maxStock = stockItem.Max;

                if (quantity < minStock)
                    stockItem.Result = " + " + Convert.ToString(minStock - quantity);

                if (quantity > maxStock)
                    stockItem.Result = " - " + Convert.ToString(quantity - maxStock);

                if (quantity > 0 && quantity >= minStock && quantity <= maxStock)
                    stockItem.Result = "OK";

                if (quantity == 0 && minStock == 0 && maxStock == 0)
                    stockItem.Result = "???";
            }
        }
    }
}
