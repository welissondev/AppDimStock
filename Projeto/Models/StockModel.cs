using System;
using System.Collections.Generic;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo do estoque
    /// </summary>
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
        public StockModel(TransactionModel transaction, ProductModel product)
        {
            this.transaction = transaction;
            Product = product;
        }

        public DataTable FetchData()
        {
            var criterionSqlCount = string.Empty;
            var criterionSqlQuery = string.Empty;
            var criterionSqlParameter = string.Empty;
            var criterionSqlOrderBy = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                criterionSqlCount = @"SELECT COUNT(Stock.Id) FROM Stock 
                INNER JOIN Stock ON Stock.ProductId = Product.Id";

                criterionSqlQuery = @"SELECT Stock.Id, Stock.Quantity, Stock.Min, 
                Stock.Max, Stock.TotalValue, Product.Id, Product.Description, 
                Product.CostPrice, Product.InternalCode, Product.Photo FROM 
                Stock INNER JOIN Stock ON Stock.ProductId = Product.Id ";

                criterionSqlOrderBy = " Order By InternalCode Asc";

                /* 
                 * Link [WHERE] na consulta de acordo com
                 * o resumo buscado pelo usuário
                */
                switch (summary)
                {
                    case "All":

                        criterionSqlCount += @"WHERE Stock.Id > 0";
                        criterionSqlQuery += @"WHERE Stock.Id > 0";

                        break;

                    case "Nothing":

                        criterionSqlCount += @"WHERE Quantity = 0 
                        AND Stock.Min = 0 AND Stock.Max = 0";

                        criterionSqlQuery += @"WHERE Quantity = 0 
                        AND Stock.Min = 0 AND Stock.Max = 0";

                        break;

                    case "Ok":

                        criterionSqlCount += @"WHERE Quantity > 0 
                        AND Quantity >= Stock.Min AND Quantity 
                        <= Stock.Max";

                        criterionSqlQuery += @"WHERE Quantity > 0 
                        AND Quantity >= Stock.Min AND Quantity 
                        <= Stock.Max";

                        break;

                    case "High":

                        criterionSqlCount += @"WHERE Stock.Quantity 
                        > Stock.Max";

                        criterionSqlQuery += @"WHERE Stock.Quantity 
                        > Stock.Max";

                        break;

                    case "Low":

                        criterionSqlCount += @"WHERE Stock.Quantity 
                        < Stock.Min";

                        criterionSqlQuery += @"WHERE Stock.Quantity 
                        < Stock.Min";

                        break;
                }

                /*
                 *Link [AND] na consulta de acordo com o critério
                 *buscado pelo usuário
                */
                if (Product.InternalCode != string.Empty &&
                    Product.InternalCode != null)
                {
                    criterionSqlParameter += " AND InternalCode LIKE @InternalCode";

                    ParameterModel.Add("@InternalCode", string.Format("{0}%",
                    Product.InternalCode));
                }

                if (Product.Description != string.Empty &&
                    Product.Description != null)
                {
                    criterionSqlParameter += " AND Description LIKE @Description";

                    ParameterModel.Add("@Description", string.Format("%{0}%",
                    Product.Description));
                }

                criterionSqlCount += criterionSqlParameter;
                criterionSqlQuery += criterionSqlParameter + criterionSqlOrderBy;

                return dataBase.ExecuteDataAdapter(criterionSqlQuery);
            }
        }

        public bool GetDetail()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Product.Id, Product.InternalCode, Product.Description, 
                Product.CostPrice, Stock.Id, Stock.Quantity FROM Product INNER JOIN 
                Stock ON Product.Id = Stock.ProductId WHERE Product.Id = @Id";

                ParameterModel.Clear();
                ParameterModel.Add("@Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
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

                ParameterModel.Clear();
                ParameterModel.Add("@ItemQuantity", item["Quantity"]);
                ParameterModel.Add("@ItemTotalValue", item["TotalValue"]);
                ParameterModel.Add("@StockId", item["StockId"]);

                actionResult = transaction.ExecuteNonQuery(sql) > 0;
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

                ParameterModel.Clear();
                ParameterModel.Add("@ItemQuantity", item["Quantity"]);
                ParameterModel.Add("@ItemTotalValue", item["TotalValue"]);
                ParameterModel.Add("@StockId", item["StockId"]);

                actionResult = transaction.ExecuteNonQuery(sql) > 0;
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

                ParameterModel.Clear();
                ParameterModel.Add("@ItemQuantity", item["Quantity"]);
                ParameterModel.Add("@ItemTotalValue", item["TotalValue"]);
                ParameterModel.Add("@StockId", item["StockId"]);

                actionResult = transaction.ExecuteNonQuery(sql) > 0;
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

                ParameterModel.Clear();
                ParameterModel.Add("@ItemQuantity", item["Quantity"]);
                ParameterModel.Add("@ItemTotalValue", item["TotalValue"]);
                ParameterModel.Add("@StockId", item["StockId"]);

                actionResult = transaction.ExecuteNonQuery(sql) > 0;
            }

            return actionResult;
        }

        public bool UpdateValue()
        {
            var sql = @"UPDATE Stock Set TotalValue = @ProductCostPrice * 
            Quantity WHERE ProductId = @ProductId";

            ParameterModel.Clear();
            ParameterModel.Add("ProductCostPrice", Product.CostPrice);
            ParameterModel.Add("@ProductId", Product.Id);

            return transaction.ExecuteNonQuery(sql) > 0;
        }

        public void SetSummary(List<StockModel> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var stockItem = list[i];
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
        public void SetResult(List<StockModel> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var stockItem = list[i];
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

