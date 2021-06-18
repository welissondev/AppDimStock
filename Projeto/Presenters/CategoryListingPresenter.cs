using DimStock.Models;
using DimStock.Views;

namespace DimStock.Presenters
{
    public class CategoryListingPresenter
    {
        private ICategoryListingView view;

        public CategoryListingPresenter(ICategoryListingView view)
        {
            this.view = view;
        }

        public bool Delete()
        {
            var actionResult = false;

            var category = new CategoryModel() { Id = view.Id };

            if (category.Delete() == true)
            {
                actionResult = true;
                Clear();
            }

            return actionResult;
        }

        public bool GetDetails()
        {
            var actionResult = false;
            var category = new CategoryModel() { Id = view.Id };

            if (category.GetDetails() == true)
            {
                view.Id = category.Id;
                view.Description = category.Description;
                actionResult = true;
            }

            return actionResult;
        }

        public void Clear()
        {
            view.Id = 0;
            view.SearchDescription = string.Empty;
            SearchData();
        }

        public void SearchData()
        {
            var searchResult = new CategoryModel() { Description = view.SearchDescription }.SearchData();
            view.DataList = searchResult;
        }
    }
}
