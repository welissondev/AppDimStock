using DimStock.Auxiliarys;
using System.Data.OleDb;

namespace DimStock.Models
{
    public class Company
    {
        #region Get & Set
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF_CNPJ { get; set; }
        public string RG_IE { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Cep { get; set; }
        public string StrieetNumber { get; set; }
        #endregion

        #region Function

        public bool Save()
        {
            using (var connection = new AccessConnection())
            {
                bool registerState = false;

                var sqlCommand = @"INSERT INTO Company([Name], CPF_CNPJ, RG_IE, Address, 
                District, City, State, Cep, StrieetNumber)VALUES(@Name, @CPF_CNPJ, @RG_IE, 
                @Address, @District, @City, @State, @Cep, @StrieetNumber)";

                connection.AddParameter("@Name", Name);
                connection.AddParameter("@CPF_CNPJ", CPF_CNPJ);
                connection.AddParameter("@RG_IE", RG_IE);
                connection.AddParameter("@Address", Address);
                connection.AddParameter("@District", District);
                connection.AddParameter("@City", City);
                connection.AddParameter("@State", State);
                connection.AddParameter("@Cep", Cep);
                connection.AddParameter("@StrieetNumber", StrieetNumber);

                registerState = connection.ExecuteCommand(sqlCommand) > 0;

                AxlMessageNotifier.Message = "Cadastrado com sucesso!";

                return registerState;
            }
        }

        #endregion
    }
}
