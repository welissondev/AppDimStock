using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class MovementItemValidationModel
    {
        public static bool ValidateToInsert(MovementItemModel item)
        {
            var validationStatus = false;

            if (item.Movement.Id == 0)
            {
                MessageNotifier.Show("O ID da movimentação " +
                "não foi informado!", "Obrigatório", "?");

                return validationStatus;
            }

            if (item.Stock.Product.Id == 0)
            {
                MessageNotifier.Show("O ID do produto " +
                "não foi informado!", "Obrigatório", "?");

                return validationStatus;
            }

            if (item.Stock.Id == 0)
            {
                MessageNotifier.Show("O ID do estoque " +
                "não foi informado!", "Obrigatório", "?");
            }

            if (item.UnitaryValue == 0.00)
            {
                MessageNotifier.Show("Informe o valor " +
                "unitátio!", "Obrigatório", "?");

                return validationStatus;
            }

            if (item.Quantity == 0)
            {
                MessageNotifier.Show("A quantidade não " +
                "foi informada!", "Obrigatório", "?");

                return validationStatus;
            }

            if (item.Movement.OperationType == "OutPut")
            {
                if (item.Quantity > item.Stock.Quantity)
                {
                    MessageNotifier.Show("Esse produto não " +
                    "possui estoque suficiente para realizar " +
                    "essa operação!", "Estoque Baixo", "?");

                    return validationStatus;
                }
            }

            return validationStatus = true;
        }

        public static bool ValidateToDelete(MovementItemModel item)
        {
            bool validationStatus = false;

            if (item.Id == 0)
            {
                MessageNotifier.Show("Selecione um item " +
                "para deletar!", "Não Selecionado", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToListItems(MovementItemModel item)
        {
            var validationStatus = false;

            if (item.Movement.Id == 0)
            {
                MessageNotifier.Show("Informe o ID da movimentação " +
                "para listar seus itens!", "Obrigatório", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
