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

            var model = new ProductModel();
            var product = model;

            product.Id = view.Id;
            actionResult = product.Delete();
            
            return actionResult;
        }

        public bool GetDetail()
        {
            var actionResult = false;

            var model = new ProductModel();
            var product = model;

            product.Id = view.Id;
            actionResult = product.GetDetail();

            if (actionResult == true)
            {
                view.Id = product.Id;
                view.InternalCode = product.InternalCode;
                view.Description = product.Description;
                view.CostPrice = product.CostPrice;
                view.SalePrice = product.SalePrice;
                view.BarCode = product.BarCode;
                view.CategoryId = product.Category.Id;
                view.CategoryDescription = product.Category.Description;
            }

            return actionResult;
        }

        public DataTable FetchData()
        {
            var model = new ProductModel();
            var product = model;

            product.InternalCode = view.SearchInternalCode;
            product.Description = view.SearchDescription;

            var table = product.FetchData();
            view.ProductList = table;

            return table;
        }

        public void ResetView()
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
    }
}
