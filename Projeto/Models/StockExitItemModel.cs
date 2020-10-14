using System.Data;

namespace DimStock.Models
{
    public class StockExitItemModel : ItemModel
    {
        public int StockExitId { get; set; }
        public int ProductId { get; set; }

        public StockExitItemModel()
        {
        }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO stockExitItem (stockExitId, productId, 
                quantity, unitaryValue, totalValue)VALUES(@stockExitId, @productId, 
                @quantity, @unitaryValue, @totalValue)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockExitId", StockExitId);
                dataBase.AddParameter("@productId", ProductId);
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
                sql = @"DELETE FROM stockExitItem Where id = @id";

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
                sql = @"SELECT i.*, p.description, p.internalCode FROM stockExitItem i INNER JOIN 
                product p ON i.productId = p.id WHERE i.stockEntrieId = @stockEntrieId";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockEntrieId", StockEntrieId);

                searchResult = dataBase.ExecuteDataAdapter(sql);
            }

            return searchResult;
        }
    }
}
