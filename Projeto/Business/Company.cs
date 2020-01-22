using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimStock.Business
{
    public class Company
    {
        public int Id { get; set; }    
        public string Name { get; set; }
        public string CPF_CNPJ{ get; set; }
        public string RG_IE { get; set; }
        public string AddRess { get; set; }
        public string District{ get; set; }
        public string City{ get; set; }
        public string State { get; set; }
        public string Cep { get; set; }
        public int StrieetNumber{ get; set; }
    }
}
