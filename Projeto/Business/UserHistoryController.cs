using System;
using DimStock.Model;
using DimStock.Auxiliary;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class UserHistoryController
    {
        #region Constructs

        public UserHistoryController() { }

        public UserHistoryController(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion 

        #region BussinessProperties
        public int Id { get; set; }
        public string Login { get; set; }
        public string AffectedFields{ get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public string OperationHour { get; set; }
        public string OperationModule { get; set; }
        public List<UserHistoryController> ListOfRecords { get; set; }
        #endregion

        #region SearchProperties

        public string SearchByLogin { get; set; }
        public string SearchByStartDate { get; set; }
        public string SearchByFinalDate { get; set; }
        public AxlDataPagination DataPagination { get; set; }

        #endregion 

        #region Methods

        public bool Register()
        {
            var historic = new UserHistoryModel(this);
            return historic.Insert();
        }

        public void ListData()
        {
            var historic = new UserHistoryModel(this);
            historic.SelectAll();
        }

        public void FetchData()
        {
            var historic = new UserHistoryModel(this);
            historic.SelectCustom();
        }

        #endregion 
    }
}
