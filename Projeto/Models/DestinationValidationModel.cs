using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class DestinationValidationModel
    {
        public static bool ValidateToInsert(DestinationModel destination)
        {
            var validationStatus = false;

            if (destination.LocationDescription == string.Empty)
            {
                MessageNotifier.Show("O destino não foi " +
                "informado!", "Obrigatório", "?");

                return validationStatus;
            }

            if (destination.CheckIfRegister() == true)
            {
                MessageNotifier.Show("Já existe um destino " +
                "registrado com esse nome!", "Já Existe", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToUpdate(DestinationModel destination)
        {
            var validationStatus = false;

            if (destination.LocationDescription == string.Empty)
            {
                MessageNotifier.Show("O destino não foi " +
                "informado!", "Obrigatório", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToDelete(DestinationModel destination)
        {
            var validationStatus = false;

            if (destination.Id == 0)
            {
                MessageNotifier.Show("Selecione um destino " +
                "para excluir!", "Não Selecionado", "?");

                return validationStatus;
            }

            if (destination.CheckIfRegister() == false)
            {
                MessageNotifier.Show("Esse registro já " +
                "foi excluido!", "Atualize a Lista", "?");

                return validationStatus;
            }

            if (MessageNotifier.Reply("Confirma mesmo a exclusão " +
            "desse destino?", "IMPORTANTE") == false)
                return validationStatus;

            return validationStatus = true;
        }

        public static bool ValidateToGetDetails(DestinationModel destination)
        {
            var validationStatus = false;

            if (destination.Id == 0)
            {
                MessageNotifier.Show("Selecione um registro " +
                "para visualizar!", "Não Selecionado", "?");

                return validationStatus;
            }

            if (destination.CheckIfRegister() == false)
            {
                MessageNotifier.Show("Não é possível visualizar " +
                "porque esse registro foi excluido de sua " +
                "base de dados!", "Atualize a Lista", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }
    }
}
