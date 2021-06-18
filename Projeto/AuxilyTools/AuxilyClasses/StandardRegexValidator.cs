using System.Text.RegularExpressions;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    public static class StandardRegexValidator
    {
        public static bool ValidateLoginName(string loginName)
        {
           return new Regex("^[a-z0-9]*[a-z]+[a-z0-9]*$").IsMatch(loginName);
        }

        public static bool ValidateEmail(string email)
        {
            return new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$").IsMatch(email);
        }
    }
}
