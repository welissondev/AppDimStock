using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de items da movimentação
    /// </summary>
    public partial class MovementItemModel
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public double UnitaryValue { get; set; }
        public double TotalValue { get; set; }
        public double SubTotal { get; set; }
        public StockModel Stock { get; set; }
        public ProductModel Product { get; set; }
        public MovementModel Movement { get; set; }
    }

    public partial class MovementItemModel
    {
        public MovementItemModel()
        {
            Stock = new StockModel();
            Product = new ProductModel();
            Movement = new MovementModel();
        }
        public MovementItemModel(MovementModel movement)
        {
            Movement = movement;
        }

        public bool Insert()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO MovementItem(MovementId, ProductId, StockId, 
                Quantity, UnitaryValue, TotalValue)VALUES(@MovementId, @ProductId, @StockId, 
                @Quantity, @UnitaryValue, @TotalValue)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@MovementId", Movement.Id);
                dataBase.AddParameter("@ProductId", Product.Id);
                dataBase.AddParameter("@StockId", Stock.Id);
                dataBase.AddParameter("@Quantity", Quantity);
                dataBase.AddParameter("@UnitaryValue", UnitaryValue);
                dataBase.AddParameter("@TotalValue", TotalValue);

                if (dataBase.ExecuteCommand(sql) > 0)
                    actionResult = true;
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM MovementItem Where Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("Id", Id);

                if (dataBase.ExecuteCommand(sql) > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public DataTable ListItems()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT MovementItem.*, Product.Description, Product.InternalCode 
                FROM MovementItem INNER JOIN Product ON MovementItem.ProductId = Product.Id WHERE 
                MovementItem.MovementId = @MovementId ORDER BY InternalCode";

                dataBase.ClearParameter();
                dataBase.AddParameter("@MovementId", Movement.Id);

                return dataBase.GetDataTable(sql);
            }
        }
    }
}
