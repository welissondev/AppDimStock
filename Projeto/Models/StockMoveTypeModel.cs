namespace DimStock.Models
{
    public class StockMoveTypeModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public int GetIdByDescription()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT id FROM stockMoveType WHERE 
                description = @description";

                dataBase.ClearParameter();
                dataBase.AddParameter("@description", Description);

                Id = dataBase.ExecuteScalar(sql);
            }

            return Id;
        }
    }
}
