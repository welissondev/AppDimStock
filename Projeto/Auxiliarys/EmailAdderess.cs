using System.Text.RegularExpressions;

namespace DimStock.Auxiliarys
{
    public static class EmailAdderess
    {
        public static bool Validate(string email)
        {
            var regex = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            return regex.IsMatch(email);
        }
    }
}
