using System.Data;

namespace DimStock.Models
{
    public class StockInItemModel : ItemModel
    {
        public StockModel Stock { get; set; }
        public StockInModel StockIn { get; set; }

        public StockInItemModel()
        {
            StockIn = new StockInModel();
            Stock = new StockModel();
        }

        public StockInItemModel(StockInModel stockIn)
        {
            StockIn = stockIn;
        }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (StockInItemValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO stockInItem (stockInId, stockId, 
                quantity, unitaryValue, totalValue)VALUES(@stockInId, @stockId, 
                @quantity, @unitaryValue, @totalValue)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockInId", StockIn.Id);
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

            if (StockInItemValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE stockInItem SET stockInId = @stockInId, stockId = @stockId, 
                quantity = @quantity, unitaryValue = @unitaryValue, totalValue = @totalValue 
                WHERE id = @id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockInId", StockIn.Id);
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

            if (StockInItemValidationModel.ValidateToDelete(this) == false)
                return actionResult;

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
                sql = @"SELECT item.id, item.quantity, item.unitaryValue, item.totalValue ,
                product.description FROM (stockInItem AS item INNER JOIN stock ON item.stockId = stock.id) 
                INNER JOIN product ON product.id = stock.productId ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockInId", StockIn.Id);

                searchResult = dataBase.ExecuteDataAdapter(sql);
            }

            return searchResult;
        }
    }
}
