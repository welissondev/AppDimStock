using DimStock.Models;
using DimStock.Views;
using System.Data;

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
            var catgory = new CategoryModel() { Id = view.Id };
            
            if (catgory.Delete() == true)
            {
                ClearView();
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

        public void ClearView()
        {
            view.Id = 0;
            view.SearchDescription = string.Empty;
        }

        public DataTable SearchData()
        {
            var category = new CategoryModel()
            {
                Description = view.SearchDescription
            };

            var searchResult = category.SearchData();
            view.DataList = searchResult;

            return searchResult;
        }
    }
}
