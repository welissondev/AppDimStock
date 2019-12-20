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

        #region Allocate()
        public bool Allocate(List<BllStock> itemList, int stockMovementId)
        {
            var transactionState = false;

            var stock = new MdlStock();

            if (stock.Allocate(itemList, stockMovementId) == true)
            {
                transactionState = true;
            }

            return transactionState;
        }
        #endregion

        #region Deallocate()
        public bool Deallocate(List<BllStock> itemList, int stockMovementId)
        {
            var transactionState = false;

            var stock = new MdlStock();

            if (stock.Deallocate(itemList, stockMovementId) == true)
            {
                transactionState = true;
            }

            return transactionState;
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
