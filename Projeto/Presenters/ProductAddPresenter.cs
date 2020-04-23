using DimStock.Models;
using DimStock.Views;
using System.Data;
using System;

namespace DimStock.Presenters
{
    public partial class ProductAddPresenter
    {
        private IProductAddView view;

        public ProductAddPresenter(IProductAddView view)
        {
            this.view = view;
        }

        public void Update(object sender, EventArgs e)
        {
            var product = new ProductModel();

            product.Id = view.Id;
            product.InternalCode = view.InternalCode;
            product.Description = view.Description;
            product.CostPrice = view.CostPrice;
            product.SalePrice = view.SalePrice;
            product.BarCode = view.BarCode;
            product.Category.Id = view.CategoryId;
            product.Category.Description = view.CategoryDescription;

            if (product.Id == 0)
            {
                product.Insert();
            }
            else
            {
                product.Update();
            }
        }

        public void Delete(object sender, EventArgs e)
        {
            var product = new ProductModel
            {
                Id = view.Id
            };

            product.Delete();
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
        }

        public void GetCategoryIdByDescription(object sender, EventArgs e)
        {
            var category = new CategoryModel
            {
                Description = view.CategoryDescription
            };

            view.CategoryId = category.GetIdByDescription();
        }
        public void SearchCategory(object sender, EventArgs e)
        {
            var category = new CategoryModel
            {
                Description = view.CategoryDescription
            };

            var searchResult = category.SearchData();
            view.CategoryDataList = searchResult;
        }
        public void ListCategory(object sender, EventArgs e)
        {
            var category = new CategoryModel();

            var queryResult = category.ListData();
            view.CategoryDataList = queryResult;
        }
    }
}
