using DimStock.Auxiliary;
using DimStock.Model;
using System;
using System.Collections.Generic;


namespace DimStock.Business
{
    public class StockMovementController
    {
        #region Constructs

        public StockMovementController() { }

        public StockMovementController(DataPagination dataPagination)
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
        public List<StockMovementController> ListOfRecords { get; set; }
        #endregion

        #region SearchProperties

        public string SearchByType { get; set; }
        public string SearchBySituation { get; set; }
        public string SearchByMovimentId { get; set; }
        public DataPagination DataPagination { get; set; }

        #endregion 

        #region Methods

        public bool Register()
        {
            var addState = false;

            var stockMovement = new StockMovementModel(this);

            if (stockMovement.Insert() == true)
            {
                var historic = new UserHistoryController
                {
                    Login = LoginAssistant.Login,
                    OperationType = "Adicionou",
                    OperationModule = "Atividade",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    AffectedFields = stockMovement.GetAffectedFields(Id)
                };

                if (historic.Register() == true)
                {
                    addState = true;
                }
            }

            return addState;
        }

        public bool SetDestination(int id)
        {
            var stockMovement = new StockMovementModel(this);
            return stockMovement.SetDestination(id);
        }

        public bool Exclude(int id)
        {
            var deleteState = false;

            var stockMovement = new StockMovementModel(this);
            var affectedFileds = stockMovement.GetAffectedFields(id);

            var stockItem = new StockItemController();
            stockItem.ListData(id);

            if (stockMovement.Delete(id) == true)
            {
                var historic = new UserHistoryController()
                {
                    Login = LoginAssistant.Login,
                    OperationType = "Deletou",
                    OperationModule = "Atividade",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    AffectedFields = affectedFileds
                };

                if (historic.Register() == true)
                {
                    deleteState = true;
                }
            }


            return deleteState;
        }

        public void ListData()
        {
            var stockMovement = new StockMovementModel(this);
            stockMovement.ListData();
        }

        public void SearchData()
        {
            var stockMovement = new StockMovementModel(this);
            stockMovement.DataQuery();
        }

        public void ViewDetails(int id)
        {
            var stockMovement = new StockMovementModel(this);
            stockMovement.ViewDetails(id);
        }

        #endregion
    }
}
