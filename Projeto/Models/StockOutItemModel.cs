using System.Data;

namespace DimStock.Models
{
    public class StockOutItemModel : ItemModel
    {
        public StockModel Stock { get; set; }
        public StockOutModel StockOut { get; set; }

        public StockOutItemModel()
        {
            StockOut = new StockOutModel();
            Stock = new StockModel();
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
                sql = @"INSERT INTO stockOutItem (stockOutId, stockId, 
                quantity, unitaryValue, totalValue)VALUES(@stockOutId, @stockId, 
                @quantity, @unitaryValue, @totalValue)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockOutId", StockOut.Id);
                dataBase.AddParameter("@stockId", Stock.Id);
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

        public bool Update()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (StockOutItemValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE stockOutItem SET stockOutId = @stockOutId, stockId = @stockId, 
                quantity = @quantity, unitaryValue = @unitaryValue, totalValue = @totalValue 
                WHERE id = @id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockOutId", StockOut.Id);
                dataBase.AddParameter("@stockId", Stock.Id);
                dataBase.AddParameter("@quantity", Quantity);
                dataBase.AddParameter("@unitaryValue", UnitaryValue);
                dataBase.AddParameter("@totalValue", TotalValue);
                dataBase.AddParameter("@id", Id);

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
                sql = @"DELETE FROM stockOutItem WHERE id = @id";

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
                sql = @"SELECT item.id, item.quantity, item.unitaryValue, item.totalValue ,
                product.description FROM (stockOutItem AS item INNER JOIN stock ON item.stockId = stock.id) 
                INNER JOIN product ON product.id = stock.productId ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockOutId", StockOut.Id);

                searchResult = dataBase.ExecuteDataAdapter(sql);
            }

            return searchResult;
        }
    }
}
