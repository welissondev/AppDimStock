using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Models
{
    public class SupplierValidationModel
    {
        public static bool ValidateToInsert(SupplierModel supplier)
        {
            var validationStatus = false;

            if (supplier.TypeOfRegistration == string.Empty)
            {
                MessageNotifier.Show("Selecione o tipo de cadastro!",
                "Obrigatório", "?");

                return validationStatus;
            }

            if (supplier.YourName == string.Empty)
            {
                MessageNotifier.Show("Informe o nome da empresa!"
                , "Obrigatório", "?");

                return validationStatus;
            }

            if (supplier.Contact.Email != string.Empty)
            {
                if (StandardRegexValidator.ValidateEmail(supplier.Contact.Email) == false)
                {
                    MessageNotifier.Show("O email informado não é válido!",
                    "Inválido", "?");

                    return validationStatus;
                }
            }

            return validationStatus = true;
        }

        public static bool ValidateToUpdate(SupplierModel supplier)
        {
            var validationStatus = false;

            if (supplier.Id == 0)
            {
                MessageNotifier.Show("Selecione um registro " +
                "para editar!", "Não Selecionado", "?");

                return validationStatus;
            }

            if (supplier.TypeOfRegistration == string.Empty)
            {
                MessageNotifier.Show("Selecione o tipo de cadastro!",
                "Obrigatório", "?");

                return validationStatus;
            }

            if (supplier.YourName == string.Empty)
            {
                MessageNotifier.Show("Informe o nome da empresa!",
                "Obrigatório", "?");

                return validationStatus;
            }

            if (supplier.Contact.Email != string.Empty)
            {
                if (StandardRegexValidator.ValidateEmail(supplier.Contact.Email) == false)
                {
                    MessageNotifier.Show("O email informado não é válido!",
                    "Inválido", "?");

                    return validationStatus;
                }
            }

            return validationStatus = true;
        }

        public static bool ValidateToDelete(SupplierModel supplier)
        {
            var validationStatus = false;

            if (supplier.Id == 0)
            {
                MessageNotifier.Show("Selecione um registro " +
                "para excluir!", "Não Selecionado", "?");

                return validationStatus;
            }

            if (supplier.CheckRelationWithStock() == true)
            {
                MessageNotifier.Show("Não é possível deletar " +
                "esse forncedor, porque ele possui registros " +
                "relacionados ao estoque!", "Não Permitido", "?");
            }

            if (MessageNotifier.Reply("Confirma mesmo a exclusão desse " +
            "fornecedor?", "IMPORTANTE") == false) return validationStatus;

            return validationStatus = true;
        }

        public static bool ValidateToGetDetails(SupplierModel supplier)
        {
            var valitationStatus = false;

            if (supplier.Id == 0)
            {
                MessageNotifier.Show("Selecione o fornecedor " +
                "para visualizar!", "Não Selecionado", "?");

                return valitationStatus;
            }

            if (supplier.CheckIfRegister() == false)
            {
                MessageNotifier.Show("Não é possivel visualizar " +
                "porque esse registro foi excluido!",
                "Atualize a Lista", "?");

                return valitationStatus;
            }

            return valitationStatus = true;
        }
    }
}
