using DimStock.Models;
using DimStock.Views;
using System.Data;
using System;

namespace DimStock.Presenters
{
    public class ProductListingPresenter
    {
        private IProductListingView view;

        public ProductListingPresenter(IProductListingView view)
        {
            this.view = view;
        }

        public void Delete(object sender, EventArgs e)
        {
            var product = new ProductModel
            {
                Id = view.Id
            };
            product.Delete();
        }

        public void GetDetails(object sender, EventArgs e)
        {
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
            }
        }

        public void ClearView(object sender, EventArgs e)
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
            view.ProductDataList = null;
            view.SearchInternalCode = string.Empty;
            view.SearchDescription = string.Empty;

            SearchData(sender, e);
        }

        public void SearchData(object sender, EventArgs e)
        {
            var product = new ProductModel
            {
                InternalCode = view.SearchInternalCode,
                Description = view.SearchDescription
            };

            var searchResult = product.SearchData();
            view.ProductDataList = searchResult;
        }
    }
}
