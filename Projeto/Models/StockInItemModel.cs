using System.Data;

namespace DimStock.Models
{
    public class StockInItemModel : ItemModel
    {
        public StockInModel StockIn { get; set; }
        public ProductModel Product { get; set; }

        public StockInItemModel()
        {
            StockIn = new StockInModel();
            Product = new ProductModel();
        }

        public StockInItemModel(StockInModel stockIn)
        {
            StockIn = stockIn;
        }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO stockInItem (stockInId, productId, 
                quantity, unitaryValue, totalValue)VALUES(@stockInId, @productId, 
                @quantity, @unitaryValue, @totalValue)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockInId", StockIn.Id);
                dataBase.AddParameter("@productId", Product.Id);
                dataBase.AddParameter("@quantity", Quantity);
                dataBase.AddParameter("@unitaryValue", UnitaryValue);
                dataBase.AddParameter("@totalValue", TotalValue);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM stockInItem Where id = @id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public DataTable ListItems()
        {
            var sql = string.Empty;
            var searchResult = new DataTable();

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT i.*, p.description, p.internalCode FROM stockInItem i INNER JOIN 
                product p ON i.productId = p.id WHERE i.stockInId = @stockInId";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockInId", StockIn.Id);

                searchResult = dataBase.ExecuteDataAdapter(sql);
            }

            return searchResult;
        }
    }
}
