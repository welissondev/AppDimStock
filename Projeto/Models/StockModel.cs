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
        private ConnectionTransactionModel dataBaseTransaction;

        public int Id { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public int Quantity { get; set; }
        public double TotalValue { get; set; }
        public string Result { get; set; }
        public string Summary { get => summary; set => summary = value; }
        public ProductModel Product { get; set; }
        public SupplierModel Supplier { get; set; }
    }

    public partial class StockModel
    {
        public StockModel()
        {
            Product = new ProductModel();
        }
        public StockModel(ProductModel product)
        {
            Product = product;
        }
        public StockModel(SupplierModel supplier)
        {
            Supplier = supplier;
        }
        public StockModel(ConnectionTransactionModel dataBaseTransaction)
        {
            this.dataBaseTransaction = dataBaseTransaction;
        }
        public StockModel(ConnectionTransactionModel dataBaseTransaction, ProductModel product)
        {
            this.dataBaseTransaction = dataBaseTransaction;
            Product = product;
        }


        public bool GetDetails()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (StockValidationModel.ValidateToGetDetails(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Stock.Id, Stock.Quantity, Product.Id, Product.InternalCode, 
                Product.Description, Product.CostPrice FROM Stock INNER JOIN Product ON 
                Stock.ProductId = Product.Id WHERE Stock.Id = @StockId";

                dataBase.ClearParameter();
                dataBase.AddParameter("@StockId", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        Id = int.Parse(reader["Stock.Id"].ToString());
                        Product.Id = int.Parse(reader["Product.Id"].ToString());
                        Product.InternalCode = reader["InternalCode"].ToString();
                        Product.Description = reader["Description"].ToString();
                        Product.CostPrice = double.Parse(reader["CostPrice"].ToString());
                        Quantity = int.Parse(reader["Quantity"].ToString());
                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool InsertPostingOfEntries(DataTable items)
        {
            var count = 0;
            var sql = string.Empty;

            if (StockValidationModel.ValidatePostingItems(items) == false)
                return false;

            foreach (DataRow item in items.Rows)
            {
                sql = @"UPDATE stock SET quantity = quantity + @quantity, 
                totalValue = totalValue + @totalValue WHERE productId = @productId";

                dataBaseTransaction.ClearParameter();
                dataBaseTransaction.AddParameter("@itemQuantity", item["quantity"]);
                dataBaseTransaction.AddParameter("@itemTotalValue", item["totalValue"]);
                dataBaseTransaction.AddParameter("@productId", item["productId"]);

                if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
                    count += 1;
            }

            return count > 0;
        }
        public bool InsertPostingOfOutPuts(DataTable items)
        {
            var count = 0;
            var sql = string.Empty;

            if (StockValidationModel.ValidatePostingItems(items) == false)
                return false;

            foreach (DataRow item in items.Rows)
            {
                sql = @"UPDATE stock SET quantity = quantity - @quantity, 
                totalValue = totalValue - @totalValue WHERE productId = @productId";

                dataBaseTransaction.ClearParameter();
                dataBaseTransaction.AddParameter("@quantity", item["quantity"].ToString());
                dataBaseTransaction.AddParameter("@totalValue", item["totalValue"].ToString());
                dataBaseTransaction.AddParameter("@productId", item["productId"].ToString());

                if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
                    count += 1;
            }

            return count > 0;
        }

        public bool RemovePostingOfEntries(DataTable items)
        {
            var count = 0;
            var sql = string.Empty;

            if (StockValidationModel.ValidatePostingItems(items) == false)
                return false;

            foreach (DataRow item in items.Rows)
            {
                sql = @"UPDATE stock SET quantity = quantity - @quantity, 
                totalValue = totalValue - @totalValue WHERE productId = @productId";

                dataBaseTransaction.ClearParameter();
                dataBaseTransaction.AddParameter("@quantity", item["quantity"]);
                dataBaseTransaction.AddParameter("@totalValue", item["totalValue"]);
                dataBaseTransaction.AddParameter("@productId", item["productId"]);

                if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
                    count += 1;
            }

            return count > 0;
        }
        public bool RemovePostingOfOutPuts(DataTable items)
        {
            var count = 0;
            var sql = string.Empty;

            if (StockValidationModel.ValidatePostingItems(items) == false)
                return false;

            foreach (DataRow item in items.Rows)
            {
                sql = @"UPDATE stock SET quantity = quantity + @quantity, 
                totalValue = totalValue + @totalValue WHERE productId = @productId";

                dataBaseTransaction.ClearParameter();
                dataBaseTransaction.AddParameter("@quantity", item["quantity"]);
                dataBaseTransaction.AddParameter("@totalValue", item["totalValue"]);
                dataBaseTransaction.AddParameter("@productId", item["productId"]);

                if (dataBaseTransaction.ExecuteNonQuery(sql) > 0)
                    count += 1;
            }

            return count > 0;
        }

        public bool UpdateTotalValue()
        {
            if (StockValidationModel.ValidateToUpdateTotalValue(this) == false)
                return false;

            var sql = @"UPDATE Stock Set TotalValue = @ProductCostPrice * 
            Quantity WHERE ProductId = @ProductId";

            dataBaseTransaction.ClearParameter();
            dataBaseTransaction.AddParameter("@ProductCostPrice", Product.CostPrice);
            dataBaseTransaction.AddParameter("@ProductId", Product.Id);

            return dataBaseTransaction.ExecuteNonQuery(sql) > 0;
        }

        public bool CheckRegisterStatus()
        {
            var registrationStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM Stock WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteScalar(sql) == 0)
                {
                    return registrationStatus;
                }
            }

            return registrationStatus = true;
        }

        public bool CheckRelationWithProduct()
        {
            var relatedStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM Stock WHERE 
                ProductId = @ProductId";

                dataBase.ClearParameter();
                dataBase.AddParameter("ProductId", Product.Id);

                if (dataBase.ExecuteScalar(sql) > 0)
                {
                    relatedStatus = true;
                }
            }

            return relatedStatus;
        }
        public bool CheckRelationWithSupplier()
        {
            var relatedStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM Stock WHERE 
                SupplierId = @SupplierId";

                dataBase.ClearParameter();
                dataBase.AddParameter("SupplierId", Supplier.Id);

                if (dataBase.ExecuteScalar(sql) > 0)
                {
                    relatedStatus = true;
                }
            }

            return relatedStatus;
        }

        public void SetSummary(List<StockModel> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var stock = list[i];
                var quantity = stock.Quantity;
                var min = stock.Min;
                var max = stock.Max;

                if (quantity > 0 && quantity >= min && quantity <= max)
                    stock.Summary = "OK";

                if (quantity > max)
                    stock.Summary = "Alto";

                if (quantity < min)
                    stock.Summary = "Baixo";

                if (quantity == 0 & min == 0 && max == 0)
                    stock.Summary = "???";
            }
        }
        public void SetResult(List<StockModel> list)
        {
            for (int i = 0; i < list.Count; i++)
            {
                var stock = list[i];
                var quantity = stock.Quantity;
                var min = stock.Min;
                var max = stock.Max;

                if (quantity < min)
                    stock.Result = " + " + Convert.ToString(min - quantity);

                if (quantity > max)
                    stock.Result = " - " + Convert.ToString(quantity - max);

                if (quantity > 0 && quantity >= min && quantity <= max)
                    stock.Result = "OK";

                if (quantity == 0 && min == 0 && max == 0)
                    stock.Result = "???";
            }
        }

        public int GetQuantity()
        {
            /*A quantidade pode ser obtida tanto pelo id do 
             *estoque como pelo id do produto*/

            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Quantity FROM STOCK WHERE 
                Id = @StockId OR ProductId = @ProductId";

                dataBase.ClearParameter();
                dataBase.AddParameter("@StockId", Id);
                dataBase.AddParameter("@ProductId", Product.Id);

                return dataBase.ExecuteScalar(sql);
            }
        }

        public DataTable SearchData()
        {
            var sqlSelect = string.Empty;
            var sqlParameter = string.Empty;
            var sqlOrderBy = string.Empty;
            var query = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sqlSelect = @"SELECT Stock.Id, Stock.Quantity, Stock.Min, 
                Stock.Max, Stock.TotalValue, Product.Id, Product.Description, 
                Product.CostPrice, Product.InternalCode, Product.Photo FROM 
                Stock INNER JOIN Stock ON Stock.ProductId = Product.Id ";

                sqlOrderBy = " Order By InternalCode Asc";

                /* 
                 * Link [WHERE] na consulta de acordo com
                 * o resumo buscado pelo usuário
                */
                switch (summary)
                {
                    case "All":

                        sqlSelect += @"WHERE Stock.Id > 0 ";

                        break;

                    case "Nothing":

                        sqlSelect += @"WHERE Quantity = 0 
                        AND Stock.Min = 0 AND Stock.Max = 0 ";

                        break;

                    case "Ok":

                        sqlSelect += @"WHERE Quantity > 0 
                        AND Quantity >= Stock.Min AND Quantity 
                        <= Stock.Max ";

                        break;

                    case "High":

                        sqlSelect += @"WHERE Stock.Quantity 
                        > Stock.Max ";

                        break;

                    case "Low":

                        sqlSelect += @"WHERE Stock.Quantity 
                        < Stock.Min ";

                        break;
                }

                /*
                 * Link [AND] na consulta de acordo com o critério
                 * buscado pelo usuário
                */
                if (Product.InternalCode != string.Empty &&
                    Product.InternalCode != null)
                {
                    sqlParameter += " AND InternalCode LIKE @InternalCode ";

                    dataBaseTransaction.AddParameter("@InternalCode", string.Format("{0}%",
                    Product.InternalCode));
                }

                if (Product.Description != string.Empty &&
                    Product.Description != null)
                {
                    sqlParameter += " AND Description LIKE @Description ";

                    dataBaseTransaction.AddParameter("@Description", string.Format("%{0}%",
                    Product.Description));
                }

                query += sqlSelect + sqlParameter + sqlOrderBy;

                return dataBase.ExecuteDataAdapter(query);
            }
        }
    }
}

