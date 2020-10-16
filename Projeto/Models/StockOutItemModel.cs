using System.Data;

namespace DimStock.Models
{
    public class StockOutItemModel : ItemModel
    {
        public StockOutModel StockOut { get; set; }
        public ProductModel Product { get; set; }

        public StockOutItemModel()
        {
            StockOut = new StockOutModel();
            Product = new ProductModel();
        }

        public StockOutItemModel(StockOutModel stockOut)
        {
            StockOut = stockOut;
        }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (StockOutItemValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO stockOutItem (stockOutId, productId, 
                quantity, unitaryValue, totalValue)VALUES(@stockOutId, @productId, 
                @quantity, @unitaryValue, @totalValue)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockOutId", StockOut.Id);
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

            if (StockOutItemValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM stockOutItem Where id = @id";

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
                sql = @"SELECT i.*, p.description, p.internalCode FROM stockOutItem i INNER JOIN 
                product p ON i.productId = p.id WHERE i.stockOutId = @stockOutId";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockOutId", StockOut.Id);

                searchResult = dataBase.ExecuteDataAdapter(sql);
            }

            return searchResult;
        }
    }
}
