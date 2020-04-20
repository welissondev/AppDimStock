using DimStock.Models;
using DimStock.Views;
using System.Data;

namespace DimStock.Presenters
{
    public partial class ProductAddPresenter
    {
        private IProductAddView view;

        public ProductAddPresenter(IProductAddView view)
        {
            this.view = view;
        }

        public bool Insert()
        {
            var actionResult = false;

            var product = new ProductModel();

            product.InternalCode = view.InternalCode;
            product.Description = view.Description;
            product.CostPrice = view.CostPrice;
            product.SalePrice = view.SalePrice;
            product.BarCode = view.BarCode;
            product.Category.Id = view.CategoryId;
            product.Category.Description = view.CategoryDescription;

            if (product.Insert() == true)
            {
                actionResult = true;
                ClearView();
            }

            return actionResult;
        }

        public bool Update()
        {
            var actionResult = false;

            var product = new ProductModel();

            product.Id = view.Id;
            product.InternalCode = view.InternalCode;
            product.Description = view.Description;
            product.CostPrice = view.CostPrice;
            product.SalePrice = view.SalePrice;
            product.BarCode = view.BarCode;
            product.Category.Id = view.CategoryId;
            product.Category.Description = view.CategoryDescription;

            if (product.Update() == true)
            {
                actionResult = true;
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            var product = new ProductModel
            {
                Id = view.Id
            };

            if (product.Delete() == true)
            {
                actionResult = true;
            }

            return actionResult;
        }

        public int GetCategoryIdByDescription()
        {
            var category = new CategoryModel
            {
                Description = view.CategoryDescription
            };

            return category.GetIdByDescription();
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
        }

        public DataTable FetchCategoryData()
        {
            var category = new CategoryModel
            {
                Description = view.CategoryDescription
            };

            var searchResult = category.FetchData();
            view.CategoryList = searchResult;

            return searchResult;
        }

        public DataTable ListAllCategoryData()
        {
            var category = new CategoryModel();

            var queryResult = category.ListData();
            view.CategoryList = queryResult;

            return queryResult;
        }
    }
}
