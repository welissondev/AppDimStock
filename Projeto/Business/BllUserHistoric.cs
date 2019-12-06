using System;
using DimStock.Model;
using DimStock.Auxiliary;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class BllUserHistoric
    {
        #region Constructs

        public BllUserHistoric() { }

        public BllUserHistoric(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion 

        #region BussinessProperties
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

        #region QueryProperties

        public string QueryByLogin { get; set; }
        public string QueryByStartDate { get; set; }
        public string QueryByFinalDate { get; set; }
        public AxlDataPagination DataPagination { get; set; }

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
        public void FetchData()
        {
            var historic = new MdlUserHistoric(this);
            historic.FechData();
        }
        #endregion 
    }
}
