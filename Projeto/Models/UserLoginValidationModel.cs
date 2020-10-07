using DimStock.AuxilyTools.AuxilyClasses;
using System.Text.RegularExpressions;

namespace DimStock.Models
{
    public class UserLoginValidationModel
    {
        public static bool ValidateToAccess(UserLoginModel user)
        {
            var validationStatus = false;

            if (user.Login == string.Empty)
            {
                MessageNotifier.Show("Nome de login não " +
                "Informado!", "Obrigatório", "?");

                return validationStatus;
            }

            if (user.AccessPassWord == string.Empty)
            {
                MessageNotifier.Show("Senha de acesso não " +
                "Informada!", "Obrigatório", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToInsert(UserLoginModel user)
        {
            var validationStatus = false;

            if (user.YourName == string.Empty)
            {
                MessageNotifier.Show("Nome do usuário não " +
                "informado!", "Obrigatório", "?");

                return validationStatus;
            }

            if (user.Email == string.Empty)
            {
                MessageNotifier.Show("Email do usuário não " +
                "informado", "Obrigatório", "?");

                return validationStatus;
            }

            if (StandardRegexValidator.ValidateEmail(user.Email) == false)
            {
                MessageNotifier.Show("O endereço de email do usuário " +
                "não é valido!", "Inválido", "?");

                return validationStatus;
            }

            if (user.Login == string.Empty)
            {
                MessageNotifier.Show("Login do usuário " +
                "não informado!", "Obrigatório", "?");

                return validationStatus;
            }

            if (StandardRegexValidator.ValidateLoginName(user.Login) == false)
            {
                MessageNotifier.Show("O nome de login não é válido!",
                "Não Permitido", "?");

                return validationStatus;
            }

            if (user.AccessPassWord == string.Empty)
            {
                MessageNotifier.Show("Senha do usuário não " +
                "informada!", "Obrigatório", "?");

                return validationStatus;
            }

            if (user.PassWordCheck == string.Empty)
            {
                MessageNotifier.Show("Senha de confirmação " +
                "não informada!", "Obrigatório", "?");

                return validationStatus;
            }

            if (user.PassWordCheck != user.AccessPassWord)
            {
                MessageNotifier.Show("As senhas informadas " +
                "não conferem!", "Senhas Diferentes", "?");

                return validationStatus;
            }

            if (user.CheckIfRegister() == true)
            {
                MessageNotifier.Show("Já existe um usuário " +
                "registrado com esse login!", "Já Existe", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToUpdate(UserLoginModel user)
        {
            var validationStatus = false;

            if (user.YourName == string.Empty)
            {
                MessageNotifier.Show("Nome do usuário não " +
                "informado!", "Obrigatório", "?");

                return validationStatus;
            }

            if (user.Email == string.Empty)
            {
                MessageNotifier.Show("Email do usuário não " +
                "informado", "Obrigatório", "?");

                return validationStatus;
            }

            if (StandardRegexValidator.ValidateEmail(user.Email) == false)
            {
                MessageNotifier.Show("O endereço de email do usuário " +
                "não é valido!", "Inválido", "?");

                return validationStatus;
            }

            if (user.Login == string.Empty)
            {
                MessageNotifier.Show("Login do usuário " +
                "não informado!", "Obrigatório", "?");

                return validationStatus;
            }

            if (StandardRegexValidator.ValidateLoginName(user.Login) == false)
            {
                MessageNotifier.Show("O nome de login não é válido!",
                "Não Permitido", "?");

                return validationStatus;
            }

            if (user.AccessPassWord == string.Empty)
            {
                MessageNotifier.Show("Senha do usuário não " +
                "informada!", "Obrigatório", "?");

                return validationStatus;
            }

            if (user.PassWordCheck == string.Empty)
            {
                MessageNotifier.Show("Senha de confirmação " +
                "não informada!", "Obrigatório", "?");

                return validationStatus;
            }

            if (user.PassWordCheck != user.AccessPassWord)
            {
                MessageNotifier.Show("As senhas informadas " +
                "não conferem!", "Senhas Diferentes", "?");

                return validationStatus;
            }

            return validationStatus = true;
        }

        public static bool ValidateToDelete(UserLoginModel user)
        {
            var validationStatus = false;

            if (user.Id == 0)
            {
                MessageNotifier.Show("Selecione um usuário " +
                "para excluir!", "Não Selecionado", "?");

                return validationStatus;
            }

            if (user.CheckIfRegister() == false)
            {
                MessageNotifier.Show("Esse usuário já " +
                "foi excluido!", "Atualize a Lista", "?");

                return validationStatus;
            }

            if (MessageNotifier.Reply("Confirma mesmo a exclusão desse " +
            "usuário?", "IMPORTANTE") == false) return validationStatus;

            return validationStatus = true;
        }
    }
}
