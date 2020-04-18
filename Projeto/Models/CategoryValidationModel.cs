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
            var isValid = false;

            if (category.Description == "" || category.Description == null)
            {
                MessageNotifier.Set("Descrição da categoria " +
                "não informada!", "Obrigatório");

                return isValid;
            }

            if (ValidateIfExists(category) == true)
            {
                MessageNotifier.Set("Já existe uma categoria " +
                "registrada com esse nome!", "Já Existe");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToUpdate(CategoryModel category)
        {
            var isValid = false;

            if (category.Id == 0)
            {
                MessageNotifier.Set("Selecione uma categoria para " +
                "atualizar!", "Selecione");

                return isValid;
            }

            if (category.Description == "" || category.Description == null)
            {
                MessageNotifier.Set("Descrição da categoria " +
                "não informada!", "Obrigatório");

                return isValid;
            }

            if (ValidateIfExists(category) == false)
            {
                MessageNotifier.Set("Não foi possivel atualizar porque " +
                "esse registro foi excluido!", "Atualize a Lista");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToDelete(CategoryModel category)
        {
            var isValid = false;

            if (category.Id == 0)
            {
                MessageNotifier.Set("Selecione uma categoria " +
                "para deletar!", "Selecione");

                return isValid;
            }

            if (ValidateIfExists(category) == false)
            {
                MessageNotifier.Set("Essa categoria já foi excluida, " +
                "atualize a lista de registros!", "Atualize");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToGetDetail(CategoryModel category)
        {
            bool isValid = false;

            if (category.Id == 0)
            {
                MessageNotifier.Set("Selecione uma categoria " +
                "para visualizar!", "Selecione");

                return isValid;
            }

            if (ValidateIfExists(category) == false)
            {
                MessageNotifier.Set("Não é possivel visualizar porque " +
               "esse registro foi excluido!", "Atualize a Lista");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateIfExists(CategoryModel category)
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Id, Description FROM Category WHERE Id = @Id ";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", category.Id);
               

                if (category.Description != string.Empty &&
                    category.Description != null)
                {
                    sql += "OR Description = @Description";
                    dataBase.AddParameter("@Description", category.Description);
                }

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.Read() == false)
                    {
                        MessageNotifier.Set("Essa categoria não encontra-se " +
                        "registrada em sua base de dados!", "Não Encontrada");

                        return actionResult;
                    }
                }
            }

            return actionResult = true;
        }
    }
}
