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
            var catgory = new CategoryModel() { Id = view.Id};
            
            if (catgory.Delete() == true)
            {
                ClearView(sender, e);
            }
        }

        public void GetDetails(object sender, EventArgs e)
        {
            var category = new CategoryModel() { Id = view.Id};

            if (category.GetDetails() == true)
            {
                view.Id= category.Id;
                view.Description= category.Description;
            }
        }

        public void ClearView(object sender, EventArgs e)
        {
            view.Id = 0;
            view.Description = string.Empty;

            SearchData(sender, e);
        }

        public void SearchData(object sender, EventArgs e)
        {
            var category = new CategoryModel()
            {
                Description = view.Description
            };

            var searchResult = category.SearchData();
            view.DataList = searchResult;
        }
    }
}
