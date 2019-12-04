using DimStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimStock.Business
{
    public class BllUserHistoric
    {
        #region Get e Set
        public int Id { get; set; }
        public string Login { get; set; }
        public int AffectedRegistryId { get; set; }
        public string DataFromAffectedRecord { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public string OperationHour { get; set; }
        public string Module { get; set; }
        public List<BllUserHistoric> ListOfRecords { get; set; }
        #endregion

        #region Register()
        public bool Register()
        {
            var historic = new MdlUserHistoric(this);
            return historic.Register();
        }
        #endregion

        #region ListAll()
        public void ListAll(int numberOfRecords)
        {
            var historic = new MdlUserHistoric();
            ListOfRecords = historic.ListAll(numberOfRecords);
        }
        #endregion

        #region FetchData()
        public void FetchData(string login, string startDate, string finalDate, int numberOfRecords = 100)
        {
            var historic = new MdlUserHistoric();
            ListOfRecords = historic.FechData(login, startDate, finalDate, numberOfRecords);
        }
        #endregion 
    }
}
