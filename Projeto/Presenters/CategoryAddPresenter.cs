using DimStock.Models;
using DimStock.Views;
using System;

namespace DimStock.Presenters
{
    public class CategoryAddPresenter
    {
        private ICategoryAddView view;

        public CategoryAddPresenter(ICategoryAddView view) { this.view = view; }

        public void Update(object sender, EventArgs e)
        {
            var category = new CategoryModel()
            {
                Id = view.Id,
                Description = view.Description.TrimStart().TrimEnd()
            };

            if (view.Id == 0)
            {
                if (category.Insert() == true)
                    ClearView(sender, e);
            }
            else
            {
                category.Update();
            }
        }

        public void Delete(object sender, EventArgs e)
        {
            var category = new CategoryModel()
            {
                Id = view.Id,
            };

            if (category.Delete() == true)
            {
                ClearView(sender, e);
            }
        }

        public void ClearView(object sender, EventArgs e)
        {
            view.Id = 0;
            view.Description = string.Empty;
        }
    }
}
