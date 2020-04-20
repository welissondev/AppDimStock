using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de validação da categoria
    /// </summary>
    public class CategoryValidationModel
    {
        public static bool ValidateToInsert(CategoryModel category)
        {
            var validationStatus = false;

            if (category.Description == string.Empty)
            {
                MessageNotifier.Set("Informe a descrição " +
                "da categoria!", "Campo Obrigatório");

                return validationStatus;
            }

            if (category.CheckIfRegister() == true)
            {
                MessageNotifier.Set("Já existe uma categoria " +
                "registrada com esse nome!", "Já Existe");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToUpdate(CategoryModel category)
        {
            var validationStatus = false;

            if (category.Id == 0)
            {
                MessageNotifier.Set("Selecione a categoria para " +
                "atualizar!", "Não Selecionada");

                return validationStatus;
            }

            if (category.Description == string.Empty)
            {
                MessageNotifier.Set("Informe a descrição " +
                "da categoria!", "Campo Obrigatório");

                return validationStatus;
            }

            if (category.CheckIfRegister() == false)
            {
                MessageNotifier.Set("Não é possivel atualizar " +
                "essa categoria, porque ela foi excluida da sua" +
                "base de dados!", "Atualize a Lista");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToDelete(CategoryModel category)
        {
            var validationStatus = false;

            if (category.Id == 0)
            {
                MessageNotifier.Set("Selecione uma categoria " +
                "para deletar!", "Selecione");

                return validationStatus;
            }

            if (category.CheckIfRegister() == false)
            {
                MessageNotifier.Set("Não foi possivel excluir " +
                "essa categoria, porque ela não esta mais registrada " +
                "na sua base de dados!", "Atualize a Lista");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToGetDetail(CategoryModel category)
        {
            var validationStatus = false;

            if (category.Id == 0)
            {
                MessageNotifier.Set("Selecione a categoria " +
                "para visualizar!", "Não Selecionada");

                return validationStatus;
            }

            if (category.CheckIfRegister() == false)
            {
                MessageNotifier.Set("Não é possivel visualizar " +
                "essa categoria, porque ela foi excluida da sua" +
                "base de dados!", "Atualize a Lista");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
