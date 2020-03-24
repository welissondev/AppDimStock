using DimStock.Auxiliarys;

namespace DimStock.Models
{
    public class CategoryValidationModel
    {
        public static bool ValidateToInsert(CategoryModel category)
        {
            bool isValid = false;

            if (category.Description == "" || category.Description == null)
            {
                MessageNotifier.Message = "Descrição da categoria não informada!";
                MessageNotifier.Title = "Obrigatório";
                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToUpdate(CategoryModel category)
        {
            bool isValid = false;

            if (category.Id == 0)
            {
                MessageNotifier.Message = "Selecione uma categoria para atualizar!";
                MessageNotifier.Title = "Não Selecionada";
                return isValid;
            }

            if (category.Description == "" || category.Description == null)
            {
                MessageNotifier.Message = "Descrição da categoria não informada!";
                MessageNotifier.Title = "Obrigatório";
                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToDelete(CategoryModel category)
        {
            bool isValid = false;

            if (category.Id == 0)
            {
                MessageNotifier.Message = "Selecione uma categoria para deletar!";
                MessageNotifier.Title = "Não Selecionada";
                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToGetDetail(CategoryModel category)
        {
            bool isValid = false;

            if (category.Id == 0)
            {
                MessageNotifier.Message = "Selecione uma categoria para visualizar!";
                MessageNotifier.Title = "Não Selecionada";
                return isValid;
            }

            return isValid = true;
        }
    }
}
