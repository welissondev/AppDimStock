using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class CategoryValidationModel
    {
        public static bool ValidateToInsert(CategoryModel category)
        {
            var validationStatus = false;

            if (category.Description == string.Empty)
            {
                MessageNotifier.Show("Informe a descrição " +
                "da categoria!", "Campo Obrigatório", "?");

                return validationStatus;
            }

            if (category.CheckRegisterStatus() == true)
            {
                MessageNotifier.Show("Já existe uma categoria " +
                "registrada com esse nome!", "Já Existe", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToUpdate(CategoryModel category)
        {
            var validationStatus = false;

            if (category.Id == 0)
            {
                MessageNotifier.Show("Selecione a categoria para " +
                "atualizar!", "Não Selecionada", "?");

                return validationStatus;
            }

            if (category.Description == string.Empty)
            {
                MessageNotifier.Show("Informe a descrição " +
                "da categoria!", "Campo Obrigatório", "?");

                return validationStatus;
            }

            if (category.CheckRegisterStatus() == false)
            {
                MessageNotifier.Show("Não é possivel atualizar " +
                "essa categoria, porque ela foi excluida da sua" +
                "base de dados!", "Atualize a Lista", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToDelete(CategoryModel category)
        {
            var validationStatus = false;

            if (category.Id == 0)
            {
                MessageNotifier.Show("Selecione uma categoria " +
                "para deletar!", "Selecione", "?");

                return validationStatus;
            }

            if (category.CheckRegisterStatus() == false)
            {
                MessageNotifier.Show("Não foi possivel excluir " +
                "essa categoria, porque ela não esta mais registrada " +
                "na sua base de dados!", "Atualize a Lista", "?");

                return validationStatus;
            }

            if (category.CheckRelationWithProduct() == true)
            {
                MessageNotifier.Show("Não é possível deletar " +
                "essa categoria, porque ela possui registros " +
                "relacionados a um produto!", "Não Permitido", "?");

                return validationStatus;
            }

            if (MessageNotifier.Reply("Confirma mesmo a exclusão dessa " +
            "categoria?", "IMPORTANTE") == false) return validationStatus;

            return validationStatus = true;
        }

        public static bool ValidateToGetDetail(CategoryModel category)
        {
            var validationStatus = false;

            if (category.Id == 0)
            {
                MessageNotifier.Show("Selecione a categoria " +
                "para visualizar!", "Não Selecionada", "?");

                return validationStatus;
            }

            if (category.CheckRegisterStatus() == false)
            {
                MessageNotifier.Show("Não é possivel visualizar " +
                "essa categoria, porque ela foi excluida da sua" +
                "base de dados!", "Atualize a Lista", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
