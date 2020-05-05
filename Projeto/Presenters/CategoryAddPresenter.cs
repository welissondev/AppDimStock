using DimStock.Models;
using DimStock.Views;

namespace DimStock.Presenters
{
    public class CategoryAddPresenter
    {
        private ICategoryAddView view;

        public CategoryAddPresenter(ICategoryAddView view) { this.view = view; }

        public bool Update()
        {
            var actionResult = false;

            var category = new CategoryModel()
            {
                Id = view.Id,
                Description = view.Description.TrimStart().TrimEnd()
            };

            //Insert register
            if (view.Id == 0)
            {
                if (category.Insert() == true)
                {
                    actionResult = true;
                    Clear();
                }
            }

            //Update register
            if (view.Id > 0)
            {
                if (category.Update() == true)
                    actionResult = true;
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            var category = new CategoryModel
            {
                Id = view.Id
            };

            if (category.Delete() == true)
            {
                actionResult = true;
                Clear();
            }

            return actionResult;
        }

        public void Clear()
        {
            view.Id = 0;
            view.Description = string.Empty;
        }
    }
}
