using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class StockMovementValidationModel
    {
        public static bool ValidateToStart(StockMovementModel stockMovement)
        {
            var validationStatus = false;

            if (stockMovement.OperationType == string.Empty)
            {
                MessageNotifier.Show("Para iniciar uma operação " +
                "de movimentação é obrigatório informar seu tipo!",
                "Obrigatório", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }
        public static bool ValidateToGetDetails(StockMovementModel stockMovement)
        {
            var validationStatus = false;

            if (stockMovement.Id == 0)
            {
                MessageNotifier.Show("Selecione a movimentação " +
                "para visualizar!", "Não Selecionada", "?");

                return validationStatus;
            }

            if (stockMovement.CheckRegisterStatus() == false)
            {
                MessageNotifier.Show("Não é possivel visualizar " +
                "porque esse registro foi excluido!",
                "Atualize a Lista", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }
        public static bool ValidateToDelete(StockMovementModel stockMovement)
        {
            var validationStatus = false;

            if (stockMovement.Id == 0)
            {
                MessageNotifier.Show("Selecione a movimentação " +
                "para excluir!", "Não Selecionada", "?");

                return validationStatus;
            }

            if (stockMovement.OperationType == string.Empty)
            {
                MessageNotifier.Show("Para deletar uma operação " +
                "de movimentação é obrigatório informar seu tipo!",
                "Obrigatório", "?");

                return validationStatus;
            }

            switch (stockMovement.OperationType)
            {
                case "Entrada":

                    if (new StockInModel(stockMovement).CheckRelationWithStockMovement() == true &&
                    stockMovement.Situation == "Finalizada")
                    {
                        MessageNotifier.Show("Não foi possível deletar essa movimentação, pois ela " +
                        "ja foi finalizada, cancele a operação e tente excluir novamente!",
                        "Não Permitido", "?");

                        return validationStatus;
                    }

                    break;

                case "Saída":

                    if (new StockOutModel(stockMovement).CheckRelationWithStockMovement() == true &&
                    stockMovement.Situation == "Finalizada")
                    {
                        MessageNotifier.Show("Não foi possível deletar essa movimentação pois ela " +
                        "ja foi finalizada, cancele a operação e tente excluir novamente!",
                        "Não Permitido", "?");

                        return validationStatus;
                    }

                    break;
            }

            if (stockMovement.CheckRegisterStatus() == false)
            {
                MessageNotifier.Show("Não é possivel deletar " +
                "porque esse registro já foi excluido!",
                "Atualize a Lista", "?");

                return validationStatus;
            }

            if (MessageNotifier.Reply("Confirma mesmo a exclusão dessa " +
            "movimentação?", "IMPORTANTE") == false) return validationStatus;

            return validationStatus = true;
        }
    }
}
