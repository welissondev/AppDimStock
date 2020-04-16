using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de validação do produto
    /// </summary>
    public class ProductValidationModel
    {
        public static bool ValidateToInsert(ProductModel product)
        {
            var isValid = false;

            if (product.InternalCode == string.Empty || product.InternalCode == null)
            {
                MessageNotifier.Message = "Informe um código para esse produto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            if (product.Description == string.Empty || product.Description == null)
            {
                MessageNotifier.Message = "Informe a descrição do produto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            if (product.Category.Id == 0 || product.Category.Description == string.Empty)
            {
                MessageNotifier.Message = "Selecione a categoria do produto!";
                MessageNotifier.Title = "Não Selecionada";

                return isValid;
            }

            if (product.CostPrice == 0.00)
            {
                MessageNotifier.Message = "Informe o preço de custo do produto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToUpdate(ProductModel product)
        {
            var isValid = false;

            if (ValidateIfExists(product) == false)
            {
                MessageNotifier.Message = "Não é possivel atualizar porque esse registro foi excluido!";
                MessageNotifier.Title = "Atualize a Lista";

                return isValid;
            }

            if (product.InternalCode == string.Empty || product.InternalCode == null)
            {
                MessageNotifier.Message = "Informe um código para esse produto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            if (product.Description == string.Empty || product.Description == null)
            {
                MessageNotifier.Message = "Informe a descrição do produto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            if (product.Category.Id == 0 || product.Category.Description == string.Empty)
            {
                MessageNotifier.Message = "Selecione a categoria do produto!";
                MessageNotifier.Title = "Não Selecionada";

                return isValid;
            }

            if (product.CostPrice == 0.00)
            {
                MessageNotifier.Message = "Informe o preço de custo do prouto!";
                MessageNotifier.Title = "Não Informado";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToDelete(ProductModel product)
        {
            var isValid = false;

            if (product.Id == 0)
            {
                MessageNotifier.Message = "Selecione o produto para excluir!";
                MessageNotifier.Title = "Não Selecionado";

                return isValid;
            }

            if (ValidateIfExists(product) == false)
            {
                MessageNotifier.Message = "Esse produto ja foi excluido, atualize sua lista de registros!";
                MessageNotifier.Title = "Atualize a Lista";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToGetDetail(ProductModel product)
        {
            var isValid = false;

            if (product.Id == 0)
            {
                MessageNotifier.Message = "Selecione um produto para visualizar!";
                MessageNotifier.Title = "Não Selecionado";

                return isValid;
            }

            if (ValidateIfExists(product) == false)
            {
                MessageNotifier.Message = "Não é possivel visualizar porque esse registro foi excluido!";
                MessageNotifier.Title = "Atualize a Lista";

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateIfExists(ProductModel product)
        {
            var sql = string.Empty;
            var actionResult = false;

            using (var dataBase = new ConnectionModel())
            {
                sql = "SELECT Id FROM Product WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", product.Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.Read() == false)
                    {
                        MessageNotifier.Message = "Esse produto não encontra-se registrado em sua base de dados!";
                        MessageNotifier.Title = "Não Encontrada";

                        return actionResult;
                    }
                }
            }

            return actionResult = true;
        }
    }
}
