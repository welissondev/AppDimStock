using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class MovementValidationModel
    {
        public static bool ValidateToStartOperation(MovementModel movement)
        {
            var validationStatus = false;

            if (movement.OperationType == string.Empty)
            {
                MessageNotifier.Show("Para iniciar uma operação " +
                "de movimentação é obrigatório informar seu tipo!",
                "Obrigatório", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToDelete(MovementModel movement)
        {
            var validationStatus = false;

            if (movement.Id == 0)
            {
                MessageNotifier.Show("Selecione a movimentação " +
                "para excluir!", "Não Selecionada", "?");

                return validationStatus;
            }

            if (movement.CheckIfRegister() == false)
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

        public static bool ValidateToGetDetails(MovementModel movement)
        {
            var validationStatus = false;

            if (movement.Id == 0)
            {
                MessageNotifier.Show("Selecione a movimentação " +
                "para visualizar!", "Não Selecionada", "?");

                return validationStatus;
            }

            if (movement.CheckIfRegister() == false)
            {
                MessageNotifier.Show("Não é possivel visualizar " +
                "porque esse registro foi excluido!",
                "Atualize a Lista", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
