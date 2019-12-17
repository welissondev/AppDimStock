using DimStock.Auxiliary;
using DimStock.Model;
using System;
using System.Collections.Generic;


namespace DimStock.Business
{
    public class BllStockActivity
    {
        #region Constructs

        public BllStockActivity() { }

        public BllStockActivity(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion 

        #region BussinessProperties
        public int Id { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public string OperationHour { get; set; }
        public string Situation { get; set; }
        public string StockDestination { get; set; }
        public List<BllStockActivity> ListOfRecords { get; set; }
        #endregion

        #region QueryProperties

        public string QueryByType { get; set; }
        public string QueryBySituation { get; set; }
        public string QueryByActivityNumber { get; set; }
        public AxlDataPagination DataPagination { get; set; }

        #endregion 

        #region Register()
        public bool Register()
        {
            var addState = false;

            var stockActivity = new MdlStockActivity(this);

            if (stockActivity.Register() == true)
            {
                var historic = new BllUserHistoric
                {
                    Login = AxlLogin.Login,
                    OperationType = "Adicionou",
                    OperationModule = "Atividade",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = stockActivity.GetAffectedFields(Id)
                };

                if (historic.Register() == true)
                {
                    addState = true;
                }
            }

            return addState;
        }
        #endregion

        #region AddDestination()
        public bool AddDestination(int id)
        {
            var stockActivity = new MdlStockActivity(this);
            return stockActivity.AddDestination(id);
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            var deleteState = false;

            var stockActivity = new MdlStockActivity(this);
            var affectedFileds = stockActivity.GetAffectedFields(id);

            var stockItem = new BllStockItem();
            stockItem.ListItem(id);

            var stock = new BllStock();

            if (stock.Reset(stockItem.ListOfRecords) == true)
            {
                if (stockActivity.Delete(id) == true)
                {
                    var historic = new BllUserHistoric()
                    {
                        Login = AxlLogin.Login,
                        OperationType = "Deletou",
                        OperationModule = "Atividade",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        DataFromAffectedRecord = affectedFileds
                    };

                    if (historic.Register() == true)
                    {
                        deleteState = true;
                    }
                }
            }

            return deleteState;
        }
        #endregion

        #region ListAll()
        public void ListAll()
        {
            var stockActivity = new MdlStockActivity(this);
            stockActivity.ListAll();
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            var stockActivity = new MdlStockActivity(this);
            stockActivity.FetchData();
        }
        #endregion 

        #region GetActivityDetails()
        public void GetActivityDetails(int id)
        {
            var stockActivity = new MdlStockActivity(this);
            stockActivity.GetDetails(id);
        }
        #endregion 
    }
}
