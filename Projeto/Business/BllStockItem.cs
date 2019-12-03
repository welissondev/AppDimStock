using DimStock.Model;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class BllStockItem
    {
        #region Get e Set
        public int Id { get; set; }
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int StockActivityId { get; set; }
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public double UnitaryValue { get; set; }
        public double TotalValue { get; set; }
        public double SubTotal { get; set; }
        public List<BllStockItem> ListOfRecords { get; set; }
        #endregion

        #region Add()
        public void Add()
        {
            var stockItem = new MdlStockItem(this);
            stockItem.Add();
        }
        #endregion

        #region ListItem()
        public void ListItem(int activityId)
        {
            var stockItem = new MdlStockItem(this);
            ListOfRecords = stockItem.ListItem(activityId);
        }
        #endregion

        #region Delete()
        public void Delete(int id)
        {
            var stockItem = new MdlStockItem();
            stockItem.Delete(id);
        }
        #endregion
    }
}
