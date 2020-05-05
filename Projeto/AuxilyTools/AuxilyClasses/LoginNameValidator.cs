using System.Text.RegularExpressions;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    public class LoginNameValidator
    {
        public static bool CheckIfOnlyHaveNumbers(string loginName)
        {
            var regex = new Regex(@"[0-9]+");
            return regex.IsMatch(loginName);
        }
    }
}
