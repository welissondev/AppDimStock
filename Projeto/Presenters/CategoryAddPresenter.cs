using DimStock.Models;
using DimStock.Views;

namespace DimStock.Presenters
{
    public class CategoryAddPresenter
    {
        private ICategoryAddView view;

        public CategoryAddPresenter(ICategoryAddView view) { this.view = view; }

        public bool Insert()
        {
            var actionResult = false;

            var category = new CategoryModel()
            {
                Id = view.Id,
                Description = view.Description
            };
            actionResult = category.Insert();

            if (actionResult == true)
                ResetView();  
            
            return actionResult;
        }

        public bool Update()
        {
            var actionResult = false;

            var category = new CategoryModel()
            {
                Id = view.Id,
                Description = view.Description
            };
            actionResult = category.Update();
            
            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            var category = new CategoryModel()
            {
                Id = view.Id,
            };
            actionResult = category.Delete();

            if (actionResult == true)
                ResetView();

            return actionResult;
        }

        public void ResetView()
        {
            view.Id = 0;
            view.Description = string.Empty;
        }
    }
}
