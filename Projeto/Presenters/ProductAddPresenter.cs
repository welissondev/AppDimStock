using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using DimStock.Views;
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

        public bool Update()
        {
            var actionResult = false;

            var product = new ProductModel
            {
                Id = view.Id,
                InternalCode = view.InternalCode,
                Description = view.Description,
                CostPrice = view.CostPrice,
                SalePrice = view.SalePrice,
                BarCode = view.BarCode
            };
            product.Category.Id = view.CategoryId;
            product.Category.Description = view.CategoryDescription;

            //Insert register
            if (view.Id == 0)
            {
                if (product.Insert() == true)
                {
                    actionResult = true;
                    Clear();
                }
            }

            //Update register
            if (view.Id > 0)
            {
                if (product.Update() == true)
                    actionResult = true;
            }

            return actionResult;
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

        public void Clear()
        {
            try
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
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void GetCategoryIdByDescription()
        {
            var product = new ProductModel();
            product.Category.Description = view.CategoryDescription;

            view.CategoryId = product.Category.GetIdByDescription();
        }
        public void SearchCategory()
        {
            var product = new ProductModel();
            product.Category.Description = view.CategoryDescription;

            view.CategoryDataList = product.Category.SearchData();
        }
        public void ListCategory()
        {
            var product = new ProductModel();
            view.CategoryDataList = product.Category.ListData();
        }
    }
}
