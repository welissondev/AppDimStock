using DimStock.Models;
using DimStock.Views;
using System.Data;

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

            var product = new ProductModel
            {
                Id = view.Id
            };
            actionResult = product.Delete();

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

                actionResult = true;
            }

            return actionResult;
        }

        public void ClearView()
        {
            view.Id = 0;
            view.InternalCode = string.Empty;
            view.Description = string.Empty;
            view.CostPrice = 0.00;
            view.SalePrice = 0.00;
            view.BarCode = string.Empty;
            view.CategoryId = 0;
            view.CategoryDescription = string.Empty;
            view.SearchDescription = string.Empty;
            view.SearchInternalCode = string.Empty;
            view.CategoryList = null;
            view.ProductList = null;
        }

        public DataTable SearchData()
        {
            var product = new ProductModel
            {
                InternalCode = view.SearchInternalCode,
                Description = view.SearchDescription
            };

            var searchResult = product.SearchData();
            view.ProductList = searchResult;

            return searchResult;
        }
    }
}
