using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using DimStock.Views;
using System;

namespace DimStock.Presenters
{
    public class CategoryAddPresenter
    {
        private ICategoryAddView view;

        public CategoryAddPresenter(ICategoryAddView view) { this.view = view; }

        public void InsertUpdate(object sender, EventArgs e)
        {
            try
            {
                var category = new CategoryModel()
                {
                    Id = view.Id,
                    Description = view.Description.TrimStart().TrimEnd()
                };

                if (view.Id == 0)
                    if (category.Insert() == true)
                        ClearView(sender, e);

                if (view.Id > 0)
                    category.Update();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
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

        public void ClearView(object sender, EventArgs e)
        {
            try
            {
                view.Id = 0;
                view.Description = string.Empty;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
