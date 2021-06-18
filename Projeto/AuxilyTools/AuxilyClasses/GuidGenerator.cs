using System;
using System.Text.RegularExpressions;

namespace DimStock.AuxilyTools.AuxilyClasses
{
    public class GuidGenerator
    {
        public static string Get()
        {
            return Regex.Replace(Guid.NewGuid().ToString().ToUpper(), "[^0-9a-zA-Z]+", "");
        }
    }
}
