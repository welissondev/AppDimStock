using DimStock.Model;
using System.Collections.Generic;
using DimStock.Report;
using DimStock.Auxiliary;

namespace DimStock.Business
{
    public class StockProductController
    {
        #region Constructs

        public StockProductController() { }

        public StockProductController(DataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion

        #region BussinesProperties
        public int StockId { get; set; }
        public string Supplier { get; set; }
        public int StockQuantity { get; set; }
        public double StockValue { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public string StockSummary { get; set; }
        public string StockResult { get; set; }
        public int ProductId { get; set; }
        public int ProductCode { get; set; }
        public int ProductSize { get; set; }
        public string ProductDescription { get; set; }
        public int ProductReference { get; set; }
        public double ProductCostPrice { get; set; }
        public string ProductPhoto { get; set; }
        public List<StockProductController> ListOfRecords { get; set; }
        #endregion 

        #region SearchProperties

        private string searchBySummary = "All";

        public string SearchByCode { get; set; }
        public string SearchBySize { get; set; }
        public string SearchByReference { get; set; }
        public string SearchByDescription { get; set; }
        public string SearchBySummary { get => searchBySummary; set => searchBySummary = value; }
        public DataPagination DataPagination { get; set; }

        #endregion

        #region Methods

        public void ListData()
        {
            var stockProduct = new StockProductModel(this);
            stockProduct.ListData();
        }

        public void SearchData()
        {
            var stockProduct = new StockProductModel(this);
            stockProduct.DataQuery();
        }

        public void ViewDetails(int id)
        {
            var stockProduct = new StockProductModel(this);
            stockProduct.ViewDetails(id);
        }

        public void GenerateReport(List<StockProductController> listOfRecords)
        {
            var stockProduct = new ReportStockProduct();
            stockProduct.GenerateReport(listOfRecords);
        }

        #endregion

    }
}
