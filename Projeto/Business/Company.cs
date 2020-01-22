using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DimStock.Auxiliary;

namespace DimStock.Business
{
    public class Company
    {
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


        public bool Register()
        {
            using (var connection = new Connection())
            {
                bool registerState = false;

                var sqlCommand = @"INSERT INTO Company([Name], CPF_CNPJ, RG_IE, Address, 
                District, City, State, Cep, StrieetNumber)VALUES(@Name, @CPF_CNPJ, @RG_IE, 
                @Address, @District, @City, @State, @Cep, @StrieetNumber)";

                connection.AddParameter("@Name", OleDbType.VarChar, Name);
                connection.AddParameter("@CPF_CNPJ", OleDbType.VarChar, CPF_CNPJ);
                connection.AddParameter("@RG_IE", OleDbType.VarChar, RG_IE);
                connection.AddParameter("@Address", OleDbType.VarChar, Address);
                connection.AddParameter("@District", OleDbType.VarChar, District);
                connection.AddParameter("@City", OleDbType.VarChar, City);
                connection.AddParameter("@State", OleDbType.VarChar, State);
                connection.AddParameter("@Cep", OleDbType.VarChar, Cep);
                connection.AddParameter("@StrieetNumber", OleDbType.VarChar, StrieetNumber);

                registerState = connection.ExecuteNonQuery(sqlCommand) > 0;

                MessageNotifier.Message = "Cadastrado com sucesso!";

                return registerState;
            }
        }

    }
}
