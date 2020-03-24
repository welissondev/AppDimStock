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
            var catgory = new CategoryModel()
            {
                Id = view.Id
            };

            var actionResult = false;
            actionResult = catgory.Delete(view.Id);

            if (actionResult == true)
                ResetView();

            return actionResult;
        }

        public DataTable Query()
        {
            var category = new CategoryModel()
            {
                Description = view.SearchByDescription
            };

            var table = category.Query();
            view.DataList = table;

            return table;
        }

        public bool GetDetail()
        {
            var model = new CategoryModel() { Id = view.Id };

            var actionResult = false;
            actionResult = model.GetDetail();

            if (actionResult == true)
            {
                view.Id = model.Id;
                view.Description = model.Description;
            }
            
            return actionResult;
        }

        public void ResetView()
        {
            view.Id = 0;
            view.SearchByDescription = string.Empty;
        }
    }
}
