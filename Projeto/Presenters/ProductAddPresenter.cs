using DimStock.Models;
using DimStock.Views;
using System.Data;
using System;
using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Presenters
{
    public partial class ProductAddPresenter
    {
        private IProductAddView view;

        public ProductAddPresenter(IProductAddView view)
        {
            this.view = view;
        }

        public void InsertUpdate(object sender, EventArgs e)
        {
            try
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

                if (view.Id == 0)
                    product.Insert();

                if (view.Id > 0)
                    product.Update();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void Delete(object sender, EventArgs e)
        {
            try
            {
                if (new ProductModel() { Id = view.Id }.Delete() == true)
                    ClearView(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void ClearView(object sender, EventArgs e)
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

        public void GetCategoryIdByDescription(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductModel();
                product.Category.Description = view.CategoryDescription;
                view.CategoryId = product.Category.GetIdByDescription();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        public void SearchCategory(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductModel();
                product.Category.Description = view.CategoryDescription;
                view.CategoryDataList = product.Category.SearchData();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        public void ListCategory(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductModel();
                product.Category.ListData();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
