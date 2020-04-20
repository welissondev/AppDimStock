using DimStock.AuxilyTools.AuxilyClasses;
using System.Data;

namespace DimStock.Models
{
    public class StockValidationModel
    {
        public static bool ValidatePostingItems(DataTable postedItems)
        {
            var validationStatus = false;

            if (postedItems.Rows.Count == 0)
            {
                MessageNotifier.Set("Nenhum item foi adicionado para " +
                "lançamento no estoque!", "Adicione Um Item");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToUpdateTotalValue(StockModel stock)
        {
            var validationStatus = false;

            if (stock.Product.Id == 0)
            {
                MessageNotifier.Set("É necessário informar o produto para " +
                "atualizar seu valor no estoque!", "Não Informado");

                return validationStatus;
            }

            if (stock.Product.CostPrice == 0.00)
            {
                MessageNotifier.Set("Para atualizar o valor no estoque, " +
                "é preciso informar o preço de custo do produto!",
                "Não Informado");

                return validationStatus;
            }

            if (stock.Product.CostPrice < 0.00)
            {
                MessageNotifier.Set("Para atualizar o estoque do produto, " +
                "o preço de custo não pode ser negativo!", "Não Permitido");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToGetDetails(StockModel stock)
        {
            var validationStatus = false;

            if (stock.Id == 0)
            {
                MessageNotifier.Set("Selecione o estoque para " +
                "visualizar!", "Não Selecionado");

                return validationStatus;
            }

            if (stock.CheckIfRegister() == false)
            {
                MessageNotifier.Set("Não é possivel visualizar porque " +
                "esse registro foi excluido!", "Atualize a Lista");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
