using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class StockOutItemValidationModel
    {
        public static bool ValidateToInsert(StockOutItemModel stockOut)
        {
            var validationStatus = false;

            if (stockOut.Product.Id == 0)
            {
                MessageNotifier.Show("Selecione um produto!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            if (stockOut.Quantity == 0)
            {
                MessageNotifier.Show("Informe a quantidade!",
                "Não Informado", "!");

                return validationStatus;
            }

            if (stockOut.Quantity <= 0)
            {
                MessageNotifier.Show("A quantidade não é válida!",
                "Não Permitido", "!");

                return validationStatus;
            }


            if (stockOut.UnitaryValue == 0.00)
            {
                MessageNotifier.Show("Informe o valor unitário!",
                "Não Informado", "!");

                return validationStatus;
            }

            if (stockOut.UnitaryValue <= 0.00)
            {
                MessageNotifier.Show("O valor unitário não é válido!",
                "Não Permitido", "!");

                return validationStatus;
            }


            return validationStatus = true;
        }

        public static bool ValidateToUpdate(StockOutItemModel stockOut)
        {
            var validationStatus = false;

            if (stockOut.Id == 0)
            {
                MessageNotifier.Show("Selecione um item para editar!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            if (stockOut.Product.Id == 0)
            {
                MessageNotifier.Show("Selecione um produto!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            if (stockOut.Quantity == 0)
            {
                MessageNotifier.Show("Informe a quantidade!",
                "Não Informado", "!");

                return validationStatus;
            }

            if (stockOut.Quantity <= 0)
            {
                MessageNotifier.Show("A quantidade não é válida!",
                "Não Permitido", "!");

                return validationStatus;
            }


            if (stockOut.UnitaryValue == 0.00)
            {
                MessageNotifier.Show("Informe o valor unitário!",
                "Não Informado", "!");

                return validationStatus;
            }

            if (stockOut.UnitaryValue <= 0.00)
            {
                MessageNotifier.Show("O valor unitário não é válido!",
                "Não Permitido", "!");

                return validationStatus;
            }


            return validationStatus = true;
        }

        public static bool ValidateToDelete(StockOutItemModel stockOut)
        {
            var validationStatus = false;

            if (stockOut.Id == 0)
            {
                MessageNotifier.Show("Selecione um item para deletar!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
