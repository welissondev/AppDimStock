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
            var category = new CategoryModel()
            {
                Id = view.Id,
                Description = view.Description
            };

            var actionResult = false;

            //->Executa cadastrado
            if (view.Id == 0)
            {
                actionResult = category.Insert();

                if (actionResult == true)
                    ResetView();
            }

            //->Executa atualização
            if (view.Id > 0)
            {
                actionResult = category.Update(view.Id);
            }

            return actionResult;
        }

        public bool Delete()
        {
            var category = new CategoryModel()
            {
                Id = view.Id,
            };

            bool actionResult = false;

            actionResult = category.Delete(view.Id);

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
