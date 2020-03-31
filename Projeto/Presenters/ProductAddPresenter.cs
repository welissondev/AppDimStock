using DimStock.Models;
using DimStock.Views;
using System.Data;

/// <summary>
/// Propriedades da classe
/// </summary>
namespace DimStock.Presenters
{
    public partial class ProductAddPresenter
    {
        private IProductAddView view;
    }
}

/// <summary>
/// Funções da classe
/// </summary>
namespace DimStock.Presenters
{
    public partial class ProductAddPresenter
    {
        public ProductAddPresenter(IProductAddView view)
        {
            this.view = view;
        }

        public bool Insert()
        {
            var actionResult = false;

            var model = new ProductModel();
            var product = model;

            product.InternalCode = view.InternalCode;
            product.Description = view.Description;
            product.CostPrice = view.CostPrice;
            product.SalePrice = view.SalePrice;
            product.BarCode = view.BarCode;
            product.Category.Id = view.CategoryId;
            product.Category.Description = view.CategoryDescription;

            actionResult = product.Insert();

            if (actionResult == true)
                ResetView();

            return actionResult;
        }

        public bool Update()
        {
            var actionResult = false;

            var model = new ProductModel();
            var product = model;

            product.Id = view.Id;
            product.InternalCode = view.InternalCode;
            product.Description = view.Description;
            product.CostPrice = view.CostPrice;
            product.SalePrice = view.SalePrice;
            product.BarCode = view.BarCode;
            product.Category.Id = view.CategoryId;
            product.Category.Description = view.CategoryDescription;

            actionResult = product.Update();

            return actionResult;
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

        public int GetIdByDescription()
        {
            var model = new CategoryModel();
            var category = model;

            category.Description = view.CategoryDescription;
            return category.GetIdByDescription();
        }
    }
}

/// <summary>
/// Métodos auxiliares da classe
/// </summary>
namespace DimStock.Presenters
{
    public partial class ProductAddPresenter
    {
        public DataTable FetchCategoryData()
        {
            var model = new CategoryModel();
            var category = model;

            category.Description = view.CategoryDescription;
            var table = category.FetchData();

            view.CategoryList = table;

            return table;
        }

        public DataTable ListAllCategoryData()
        {
            var model = new CategoryModel();
            var category = model;

            var table = category.ListData();
            view.CategoryList = table;

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
        }
    }
}