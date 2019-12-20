using DimStock.Auxiliary;
using DimStock.Model;
using System;
using System.Collections.Generic;


namespace DimStock.Business
{
    public class BllStockMovement
    {
        #region Constructs

        public BllStockMovement() { }

        public BllStockMovement(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion 

        #region BussinessProperties
        public int Id { get; set; }
        public string OperationType { get; set; }
        public DateTime OperationDate { get; set; }
        public string OperationHour { get; set; }
        public string OperationSituation { get; set; }
        public string StockDestinationLocation { get; set; }
        public List<BllStockMovement> ListOfRecords { get; set; }
        #endregion

        #region QueryProperties

        public string QueryByType { get; set; }
        public string QueryBySituation { get; set; }
        public string QueryByMovimentId { get; set; }
        public AxlDataPagination DataPagination { get; set; }

        #endregion 

        #region Register()
        public bool Register()
        {
            var addState = false;

            var stockMovement = new MdlStockMovement(this);

            if (stockMovement.Register() == true)
            {
                var historic = new BllUserHistoric
                {
                    Login = AxlLogin.Login,
                    OperationType = "Adicionou",
                    OperationModule = "Atividade",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = stockMovement.GetAffectedFields(Id)
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
            var stockMovement = new MdlStockMovement(this);
            return stockMovement.AddDestination(id);
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            var deleteState = false;

            var stockMovement = new MdlStockMovement(this);
            var affectedFileds = stockMovement.GetAffectedFields(id);

            var stockItem = new BllStockItem();
            stockItem.List(id);

            if (stockMovement.Delete(id) == true)
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


            return deleteState;
        }
        #endregion

        #region ListAll()
        public void ListAll()
        {
            var stockMovement = new MdlStockMovement(this);
            stockMovement.ListAll();
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            var stockMovement = new MdlStockMovement(this);
            stockMovement.FetchData();
        }
        #endregion 

        #region GetDetails()
        public void GetDetails(int id)
        {
            var stockMovement = new MdlStockMovement(this);
            stockMovement.GetDetails(id);
        }
        #endregion 
    }
}
