using System;
using DimStock.Model;
using System.Collections.Generic;
using DimStock.Report;
using DimStock.Auxiliary;

namespace DimStock.Business
{
    public class BllStockProduct
    {
        #region Constructs

        public BllStockProduct() { }

        public BllStockProduct(AxlDataPagination dataPagination)
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
        public string StockResume { get; set; }
        public string StockResult { get; set; }
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductSize { get; set; }
        public string ProductDescription { get; set; }
        public string ProductReference { get; set; }
        public double ProductCostPrice { get; set; }
        public string ProductPhotoName { get; set; }
        public List<BllStockProduct> ListOfRecords { get; set; }
        #endregion 

        #region QueryProperties

        private string queryByResume = "All";

        public string QueryByCode { get; set; }
        public string QueryBySize { get; set; }
        public string QueryByReference { get; set; }
        public string QueryByDescription { get; set; }
        public string QueryByResume { get => queryByResume; set => queryByResume = value; }
        public AxlDataPagination DataPagination { get; set; }
       
        #endregion

        #region Methods

        #region Filter()
        public void Filter(string code, string size, string reference,
        string description, int numberOfRecords = 20)
        {
            var stockProduct = new MdlStockProduct();

            ListOfRecords = stockProduct.Filter(code, size, reference,
            description, numberOfRecords);
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            var stockProduct = new MdlStockProduct(this);

            stockProduct.FetchData();

            SetResult(); SetResume();
        }
        #endregion

        #region ListAll()
        public void ListAll()
        {
            var stockProduct = new MdlStockProduct(this);
            ListOfRecords = stockProduct.ListAll();

            SetResume();

            SetResult();
        }
        #endregion

        #region SetResume()
        private void SetResume()
        {
            var ls = ListOfRecords;

            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].StockQuantity > 0 && ls[i].StockQuantity >=
                    ls[i].MinStock && ls[i].StockQuantity <= ls[i].MaxStock)
                    ls[i].StockResume = "OK";

                if (ls[i].StockQuantity > ls[i].MaxStock)
                    ls[i].StockResume = "Alto";

                if (ls[i].StockQuantity < ls[i].MinStock)
                    ls[i].StockResume = "Baixo";

                if (ls[i].StockQuantity == 0 & ls[i].MinStock == 0 && ls[i].MaxStock == 0)
                    ls[i].StockResume = "???";
            }
        }
        #endregion

        #region SetResult()
        public void SetResult()
        {
            var ls = ListOfRecords;

            for (int i = 0; i < ls.Count; i++)
            {
                if (ls[i].StockQuantity < ls[i].MinStock)
                    ls[i].StockResult = " + " + Convert.ToString(ls[i].MinStock - ls[i].StockQuantity);

                if (ls[i].StockQuantity > ls[i].MaxStock)
                    ls[i].StockResult = " - " + Convert.ToString(ls[i].StockQuantity - ls[i].MaxStock);

                if (ls[i].StockQuantity > 0 && ls[i].StockQuantity >= ls[i].MinStock &&
                    ls[i].StockQuantity <= ls[i].MaxStock)
                    ls[i].StockResult = "OK";

                if (ls[i].StockQuantity == 0 && ls[i].MinStock == 0 && ls[i].MaxStock == 0)
                    ls[i].StockResult = "???";
            }
        }
        #endregion

        #region GetRegistryData()
        public void GetRegistryData(int id)
        {
            var stockProduct = new MdlStockProduct(this);
            stockProduct.GetRegistryData(id);
        }
        #endregion

        #region GenerateReport()
        public void GenerateReport(List<BllStockProduct> listOfRecords)
        {
            var reportStockProduct = new ReportStockProduct();
            reportStockProduct.GenerateReport(listOfRecords);
        }
        #endregion

        #endregion

    }
}
