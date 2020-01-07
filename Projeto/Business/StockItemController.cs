using DimStock.Model;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class StockItemController
    {
        #region Get e Set
        public int Id { get; set; }
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int StockMovementId { get; set; }
        public string ProductCode { get; set; }
        public string ProductSize { get; set; }
        public string ProductReference { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public double UnitaryValue { get; set; }
        public double TotalValue { get; set; }
        public double SubTotal { get; set; }
        public List<StockItemController> ListOfRecords { get; set; }
        #endregion

        #region Methods

        public bool Register()
        {
            var stockItem = new StockItemModel(this);
            return stockItem.Insert();
        }

        public void ListData(int id)
        {
            var stockItem = new StockItemModel(this);
            stockItem.ListData(id);
        }

        public bool Exclude(int id)
        {
            var stockItem = new StockItemModel();
            return stockItem.Delete(id);
        }

        #endregion
    }
}
