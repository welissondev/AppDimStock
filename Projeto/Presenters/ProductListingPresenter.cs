using DimStock.Models;
using DimStock.Views;

namespace DimStock.Presenters
{
    public class ProductListingPresenter
    {
        private IProductListingView view;

        public ProductListingPresenter(IProductListingView view)
        {
            this.view = view;
        }

        public bool Delete()
        {
            var actionResult = false;

            if (new ProductModel() { Id = view.Id }.Delete() == true)
            {
                actionResult = true;
                Clear();
            }

            return actionResult;
        }

        public bool GetDetails()
        {
            var actionResult = false;

            var product = new ProductModel
            {
                Id = view.Id
            };

            if (product.GetDetails() == true)
            {
                view.Id = product.Id;
                view.InternalCode = product.InternalCode;
                view.Description = product.Description;
                view.CostPrice = product.CostPrice;
                view.SalePrice = product.SalePrice;
                view.BarCode = product.BarCode;
                view.CategoryId = product.Category.Id;
                view.CategoryDescription = product.Category.Description;
                view.StockMin = product.Stock.Min;
                view.StockMax = product.Stock.Max;

                actionResult = true;
            }

            return actionResult;
        }

        public void Clear()
        {
            view.Id = 0;
            view.InternalCode = string.Empty;
            view.Description = string.Empty;
            view.CostPrice = 0.00;
            view.SalePrice = 0.00;
            view.BarCode = string.Empty;
            view.CategoryId = 0;
            view.CategoryDescription = string.Empty;
            view.InternalCode = string.Empty;
            view.Description = string.Empty;
            view.CategoryDataList = null;
            view.DataList = null;
            view.SearchInternalCode = string.Empty;
            view.SearchDescription = string.Empty;

            SearchData();
        }

        public void SearchData()
        {
            var product = new ProductModel
            {
                InternalCode = view.SearchInternalCode,
                Description = view.SearchDescription
            };

            var searchResult = product.SearchData();
            view.DataList = searchResult;
        }
    }
}
