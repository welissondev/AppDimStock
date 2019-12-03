using DimStock.Model;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class BllStock
    {
        #region Get e Set
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public double TotalValue { get; set; }
        #endregion 

        #region AddEntries()
        public bool AddEntries(List<BllStock> stockList, int activityId)
        {
            var transaction = false;

            var stock = new MdlStock();

            if (stock.AddEntries(stockList, activityId) == true)
            {
                transaction = true;
            }

            return transaction;
        }
        #endregion

        #region AddOutPuts()
        public bool AddOutPuts(List<BllStock> stockList, int activityId)
        {
            var transaction = false;

            var stock = new MdlStock();

            if (stock.AddOutPuts(stockList, activityId) == true)
            {
                transaction = true;
            }

            return transaction;
        }
        #endregion

        #region Reset()
        public bool Reset(List<BllStockItem> stockItemList)
        {
            var transaction = false;

            var stock = new MdlStock();

            if (stock.Reset(stockItemList) == true)
            {
                transaction = true;
            }

            return transaction;
        }
        #endregion 

    }
}
