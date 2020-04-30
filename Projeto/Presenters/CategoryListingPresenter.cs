using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using DimStock.Views;
using System;


namespace DimStock.Presenters
{
    public class CategoryListingPresenter
    {
        private ICategoryListingView view;

        public CategoryListingPresenter(ICategoryListingView view)
        {
            this.view = view;
        }

        public void Delete(object sender, EventArgs e)
        {
            try
            {
                if (new CategoryModel() { Id = view.Id }.Delete() == true)
                    ClearView(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void GetDetails(object sender, EventArgs e)
        {
            try
            {
                var category = new CategoryModel() { Id = view.Id };

                if (category.GetDetails() == true)
                {
                    view.Id = category.Id;
                    view.Description = category.Description;
                }
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
                view.SearchDescription = string.Empty;

                SearchData(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void SearchData(object sender, EventArgs e)
        {
            try
            {
                var searchResult = new CategoryModel() { Description = view.SearchDescription }.SearchData();
                view.DataList = searchResult;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
