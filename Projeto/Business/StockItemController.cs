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

        public void Add()
        {
            var stockItem = new StockItemModel(this);
            stockItem.Insert();
        }

        public void ListItens(int id)
        {
            var stockItem = new StockItemModel(this);
            stockItem.SelectAll(id);
        }

        public void Exclude(int id)
        {
            var stockItem = new StockItemModel();
            stockItem.Delete(id);
        }

        #endregion
    }
}
