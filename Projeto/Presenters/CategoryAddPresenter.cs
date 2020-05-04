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
                Description = view.Description.TrimStart().TrimEnd()
            };

            if (category.Insert() == true)
            {
                actionResult = true;
                Clear();
            }

            return actionResult;
        }

        public bool Update()
        {
            var actionResult = false;

            var category = new CategoryModel()
            {
                Id = view.Id,
                Description = view.Description.TrimStart().TrimEnd()
            };

            if (category.Update() == true)
                actionResult = true;

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            var category = new CategoryModel
            {
                Id = view.Id
            };

            if (Delete() == true)
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
