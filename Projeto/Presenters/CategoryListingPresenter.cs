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
            actionResult = catgory.Delete();

            if (actionResult == true)
                ResetView();

            return actionResult;
        }

        public bool GetDetail()
        {
            var actionResult = false;

            var category = new CategoryModel(){Id = view.Id};
            actionResult = category.GetDetail();

            if (actionResult == true)
            {
                view.Id = category.Id;
                view.Description = category.Description;
            }

            return actionResult;
        }

        public DataTable FetchData()
        {
            var category = new CategoryModel()
            {
                Description = view.SearchDescription
            };

            var table = category.FetchData();
            view.DataList = table;

            return table;
        }

        public void ResetView()
        {
            view.Id = 0;
            view.SearchDescription = string.Empty;
        }
    }
}
