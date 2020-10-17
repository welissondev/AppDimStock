using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class StockInValidationModel
    {
        public static bool ValidateToInsert(StockInModel stockIn)
        {
            var validationStatus = false;

            if (stockIn.Supplier.Id == 0)
            {
                MessageNotifier.Show("Informe o fornecedor!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockIn.StockMovement.Id == 0)
            {
                MessageNotifier.Show("Selecione uma movimentação!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockIn.RegisterDate == null)
            {
                MessageNotifier.Show("Informe a data de entrada!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockIn.RegisterHour == null)
            {
                MessageNotifier.Show("Informe a hora de entrada",
                "Obrigatório", "!");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToUpdate(StockInModel stockIn)
        {
            var validationStatus = false;

            if (stockIn.Id == 0)
            {
                MessageNotifier.Show("Selecione uma entrada para " +
                "atualizar!", "Obrigatório", "!");

                return validationStatus;
            }

            if (stockIn.Supplier.Id == 0)
            {
                MessageNotifier.Show("Informe o fornecedor!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockIn.StockMovement.Id == 0)
            {
                MessageNotifier.Show("Selecione uma movimentação!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockIn.RegisterDate == null)
            {
                MessageNotifier.Show("Informe a data de entrada!",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (stockIn.RegisterHour == null)
            {
                MessageNotifier.Show("Informe a hora de entrada",
                "Obrigatório", "!");

                return validationStatus;
            }

            if (MessageNotifier.Reply("Você confirma essa operação?"
            , "IMPORTANTE") == false) return validationStatus;

            return validationStatus = true;
        }

        public static bool ValidateToDelete(StockInModel stockIn)
        {
            var validationStatus = false;

            if (stockIn.Id == 0)
            {
                MessageNotifier.Show("Selecione um registro para deletar!",
                "Não Selecionado", "!");

                return validationStatus;
            }

            if (MessageNotifier.Reply("Você confirma a deleção dese registro?"
            , "IMPORTANTE") == false) return validationStatus;

            return validationStatus = true;
        }

        public static bool ValidateToFinisy(StockInModel stockIn)
        {
            var validationStatus = false;

            if (stockIn.StockMovement.Id == 0)
            {
                MessageNotifier.Show("Selecione uma movimentação para " +
                "finalizar!", "Obrigatório", "!");

                return validationStatus;
            }

            if (MessageNotifier.Reply("Confirma essa operação?"
            , "IMPORTANTE") == false) return validationStatus;

            return validationStatus = true;
        }

        public static bool ValidateToCancel(StockInModel stockIn)
        {
            var validationStatus = false;

            if (stockIn.StockMovement.Id == 0)
            {
                MessageNotifier.Show("Selecione uma movimentação para " +
                "cancelar!", "Obrigatório", "!");

                return validationStatus;
            }

            if (MessageNotifier.Reply("Confirma essa operação?"
            , "IMPORTANTE") == false) return validationStatus;

            return validationStatus = true;
        }

        public static bool ValidatePostingItems(StockInModel stockIn)
        {
            var validationStatus = false;

            if (stockIn.Items.Rows.Count == 0)
            {
                MessageNotifier.Show("Nenhuma item foi adicionado!",
                "Obrigatório", "!");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
