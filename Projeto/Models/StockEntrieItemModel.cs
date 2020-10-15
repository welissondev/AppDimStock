using System.Data;

namespace DimStock.Models
{
    public class StockEntrieItemModel : ItemModel
    {
        private StockEntrieModel stockEntrie;
        public int ProductId{ get; set; }

        public StockEntrieItemModel(StockEntrieModel stockEntrie)
        {
            this.stockEntrie = stockEntrie;
        }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO stockEntrieItem (stockEntrieId, productId, 
                quantity, unitaryValue, totalValue)VALUES(@stockEntrieId, @productId, 
                @quantity, @unitaryValue, @totalValue)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockEntrieId", stockEntrie.Id);
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
                sql = @"DELETE FROM stockEntrieItem Where id = @id";

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
                sql = @"SELECT i.*, p.description, p.internalCode FROM stockEntrieItem i INNER JOIN 
                product p ON i.productId = p.id WHERE i.stockEntrieId = @stockEntrieId";

                dataBase.ClearParameter();
                dataBase.AddParameter("@stockEntrieId", stockEntrie.Id);

                searchResult = dataBase.ExecuteDataAdapter(sql);
            }

            return searchResult;
        }
    }
}
