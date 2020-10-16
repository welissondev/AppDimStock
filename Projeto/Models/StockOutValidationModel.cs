using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class StockOutValidationModel
    {
        public static bool ValidateToInsert(StockOutModel stockOut)
        {
            var validationStatus = false;

            if (stockOut.Destination.Id == 0)
            {
                MessageNotifier.Show("Informe o destino!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockOut.StockMovement.Id == 0)
            {
                MessageNotifier.Show("Selecione uma movimentação!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockOut.RegisterDate == null)
            {
                MessageNotifier.Show("Informe a data de saída!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockOut.RegisterHour == null)
            {
                MessageNotifier.Show("Informe a hora de saída",
                "Obrigatório", "!");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToUpdate(StockOutModel stockOut)
        {
            var validationStatus = false;

            if (stockOut.Destination.Id == 0)
            {
                MessageNotifier.Show("Informe o destino!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockOut.StockMovement.Id == 0)
            {
                MessageNotifier.Show("Selecione uma movimentação!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockOut.RegisterDate == null)
            {
                MessageNotifier.Show("Informe a data de saída!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockOut.RegisterHour == null)
            {
                MessageNotifier.Show("Informe a hora de saída",
                "Obrigatório", "!");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToDelete(StockOutModel stockOut)
        {
            var validationStatus = false;

            if (stockOut.Id == 0)
            {
                MessageNotifier.Show("Selecione um registro para deletar!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
