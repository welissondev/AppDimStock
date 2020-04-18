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
                MessageNotifier.Set("Informe um código para " +
                "esse produto!", "Não Informado");

                return isValid;
            }

            if (product.Description == string.Empty || product.Description == null)
            {
                MessageNotifier.Set("Informe a descrição " +
                "do produto!", "Não Informado");

                return isValid;
            }

            if (product.Category.Id == 0 || product.Category.Description == string.Empty)
            {
                MessageNotifier.Set("Selecione a categoria " +
                "do produto!", "Não Selecionado");

                return isValid;
            }

            if (product.CostPrice == 0.00)
            {
                MessageNotifier.Set("Informe o preço de custo " +
                "do produto!", "Não Informado");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToUpdate(ProductModel product)
        {
            var isValid = false;

            if (ValidateIfRegisterExists(product) == false)
            {
                MessageNotifier.Set("Não é possivel atualizar " +
                "porque esse registro foi excluido!",
                "Atualize a Lista");

                return isValid;
            }

            if (product.InternalCode == string.Empty || product.InternalCode == null)
            {
                MessageNotifier.Set("Informe um código " +
                "para esse produto!", "Não Informado");

                return isValid;
            }

            if (product.Description == string.Empty || product.Description == null)
            {
                MessageNotifier.Set("Informe a descrição " +
                "do produto!", "Não Informado");

                return isValid;
            }

            if (product.Category.Id == 0 || product.Category.Description == string.Empty)
            {
                MessageNotifier.Set("Selecione a categoria " +
                "do produto!", "Não Selecionada");

                return isValid;
            }

            if (product.CostPrice == 0.00)
            {
                MessageNotifier.Set("Informe o preço de " +
                "custo do prouto!", "Não Informado");

                return isValid;
            }

            if (ValidateToUpdateStockValue(product) == false)
            {
                MessageNotifier.Set("O preço de custo não pode " +
                "ser modificado, até que todos os estoques atuais " +
                "sejam retirados!", "Não Permitido");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateIfRegisterExists(ProductModel product)
        {
            var sql = string.Empty;
            var actionResult = false;

            using (var dataBase = new ConnectionModel())
            {
                sql = "SELECT Id FROM Product WHERE Id = @Id";

                ParameterModel.Clear();
                ParameterModel.Add("@Id", product.Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.Read() == false)
                    {
                        MessageNotifier.Set("Esse produto não encontra-se " +
                        "registrado em sua base de dados!",
                        "Não Encontrada");

                        return actionResult;
                    }
                }
            }

            return actionResult = true;
        }

        public static bool ValidateToUpdateStockValue(ProductModel product)
        {
            var recentCostPrice = product.CostPrice;
            var currentCostPrice = product.GetCostPrice();
            var isValid = false;

            if (recentCostPrice != currentCostPrice)
            {
                if (new StockModel(product).GetQuantity() > 0)
                {
                    return isValid;
                }
            }

            return isValid = true;
        }

        public static bool ValidateToDelete(ProductModel product)
        {
            var isValid = false;

            if (product.Id == 0)
            {
                MessageNotifier.Set("Selecione o produto " +
                "para excluir!", "Não Selecionado");

                return isValid;
            }

            if (ValidateIfRegisterExists(product) == false)
            {
                MessageNotifier.Set("Esse produto ja foi excluido, " +
                "atualize sua lista de registros!",
                "Atualize a Lista");

                return isValid;
            }

            return isValid = true;
        }

        public static bool ValidateToGetDetail(ProductModel product)
        {
            var isValid = false;

            if (product.Id == 0)
            {
                MessageNotifier.Set("Selecione um produto " +
                "para visualizar!", "Não Selecionado");

                return isValid;
            }

            if (ValidateIfRegisterExists(product) == false)
            {
                MessageNotifier.Set("Não é possivel visualizar " +
                "porque esse registro foi excluido!",
                "Atualize a Lista");

                return isValid;
            }

            return isValid = true;
        }
    }
}
