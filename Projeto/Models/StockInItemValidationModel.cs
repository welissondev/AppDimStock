using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class StockInItemValidationModel
    {
        public static bool ValidateToInsert(StockInItemModel stockInItem)
        {
            var validationStatus = false;

            if (stockInItem.Product.Id == 0)
            {
                MessageNotifier.Show("Selecione um produto!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            if (stockInItem.Quantity == 0)
            {
                MessageNotifier.Show("Informe a quantidade!",
                "Não Informado", "!");

                return validationStatus;
            }

            if (stockInItem.Quantity <= 0)
            {
                MessageNotifier.Show("A quantidade não é válida!",
                "Não Permitido", "!");

                return validationStatus;
            }


            if (stockInItem.UnitaryValue == 0.00)
            {
                MessageNotifier.Show("Informe o valor unitário!",
                "Não Informado", "!");

                return validationStatus;
            }

            if (stockInItem.UnitaryValue <= 0.00)
            {
                MessageNotifier.Show("O valor unitário não é válido!",
                "Não Permitido", "!");

                return validationStatus;
            }


            return validationStatus = true;
        }

        public static bool ValidateToUpdate(StockInItemModel stockInItem)
        {
            var validationStatus = false;

            if (stockInItem.Id == 0)
            {
                MessageNotifier.Show("Selecione um item para editar!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            if (stockInItem.Product.Id == 0)
            {
                MessageNotifier.Show("Selecione um produto!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            if (stockInItem.Quantity == 0)
            {
                MessageNotifier.Show("Informe a quantidade!",
                "Não Informado", "!");

                return validationStatus;
            }

            if (stockInItem.Quantity <= 0)
            {
                MessageNotifier.Show("A quantidade não é válida!",
                "Não Permitido", "!");

                return validationStatus;
            }


            if (stockInItem.UnitaryValue == 0.00)
            {
                MessageNotifier.Show("Informe o valor unitário!",
                "Não Informado", "!");

                return validationStatus;
            }

            if (stockInItem.UnitaryValue <= 0.00)
            {
                MessageNotifier.Show("O valor unitário não é válido!",
                "Não Permitido", "!");

                return validationStatus;
            }


            return validationStatus = true;
        }

        public static bool ValidateToDelete(StockInItemModel stockInItem)
        {
            var validationStatus = false;

            if (stockInItem.Id == 0)
            {
                MessageNotifier.Show("Selecione um item para deletar!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
