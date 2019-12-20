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
        public int StockMovementId { get; set; }
        public string ProductCode { get; set; }
        public string ProductSize { get; set; }
        public string ProductReference { get; set; }
        public string ProductDescription { get; set; }
        public int Quantity { get; set; }
        public double UnitaryValue { get; set; }
        public double TotalValue { get; set; }
        public double SubTotal { get; set; }
        public List<BllStockItem> ListOfRecords { get; set; }
        #endregion

        #region Register()
        public void Register()
        {
            var stockItem = new MdlStockItem(this);
            stockItem.Insert();
        }
        #endregion

        #region List()
        public void List(int id)
        {
            var stockItem = new MdlStockItem(this);
            ListOfRecords = stockItem.List(id);
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
