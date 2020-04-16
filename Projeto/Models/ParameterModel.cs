using System.Collections.Generic;
using System.Data.OleDb;

namespace DimStock.Models
{
    /// <summary>
    /// Fornece métodos e propriedades para manipulação de parâmetros
    /// </summary>
    public class ParameterModel
    {
        public static List<OleDbParameter> Collection;

        public static void Add(string name, object value)
        {
            var parameter = new OleDbParameter()
            {
                ParameterName = name,
                Value = value
            };

            if (Collection == null)
                Collection = new List<OleDbParameter>();

            Collection.Add(parameter);
        }
        public static void Clear()
        {
            if (Collection != null)
                Collection.Clear();
        }
    }
}
