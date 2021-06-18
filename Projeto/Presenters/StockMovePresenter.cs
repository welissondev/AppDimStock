using DimStock.Models;
using DimStock.Views;
using System;

namespace DimStock.Presenters
{
    public class StockMovePresenter
    {
        private IStockMoveView view;

        public StockMovePresenter(IStockMoveView view)
        {
            view = this.view;
        }

        public bool Start()
        {
            var actionResult = false;
            var stockMove = new StockMoveModel();

            stockMove.StockMoveType.Description = view.StockMoveTypeDescription;

            if (stockMove.Start() == true)
            {
                view.Id = stockMove.Id;
                actionResult = true;
            }

            return actionResult;
        }
    }
}
