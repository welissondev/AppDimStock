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

            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = @"INSERT INTO MovementItem(MovementId, ProductId, StockId, 
                Quantity, UnitaryValue, TotalValue)VALUES(@MovementId, @ProductId, @StockId, 
                @Quantity, @UnitaryValue, @TotalValue)";

                dataBase.ClearParameter();
                dataBase.AddParameter("@MovementId", Movement.Id);
                dataBase.AddParameter("@ProductId", Product.Id);
                dataBase.AddParameter("@StockId", Stock.Id);
                dataBase.AddParameter("@Quantity", Quantity);
                dataBase.AddParameter("@UnitaryValue", UnitaryValue);
                dataBase.AddParameter("@TotalValue", TotalValue);

                if (dataBase.ExecuteNonQuery() > 0)
                    actionResult = true;
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = @"DELETE FROM MovementItem Where Id = @Id";
                dataBase.ClearParameter();
                dataBase.AddParameter("Id", Id);

                if (dataBase.ExecuteNonQuery() > 0)
                {
                    actionResult = true;
                }
            }

            return actionResult;
        }

        public DataTable ListItems()
        {
            using (var dataBase = new ConnectionModel())
            {
                dataBase.SqlQuery = @"SELECT MovementItem.*, Product.Description, Product.InternalCode 
                FROM MovementItem INNER JOIN Product ON MovementItem.ProductId = Product.Id WHERE 
                MovementItem.MovementId = @MovementId ORDER BY InternalCode";

                dataBase.ClearParameter();
                dataBase.AddParameter("@MovementId", Movement.Id);

                return dataBase.GetTable();
            }
        }
    }
}
