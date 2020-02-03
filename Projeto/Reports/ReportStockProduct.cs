using DimStock.Business;
using System.Collections.Generic;

namespace DimStock.Reports
{
    public class ReportStockProduct 
    {
        #region Get e Set
        public int ProductCode { get; set; }
        public int ProductSize { get; set; }
        public int ProductReference { get; set; }
        public string ProductDescription { get; set; }
        public string Supplier { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public int StockQuantity { get; set; }
        public double StockValue { get; set; }
        public string StockSummary { get; set; }
        public string StockResult { get; set; }
        public List<ReportStockProduct> ListOfRecords { get; set; }
        #endregion

        #region Methods
        public void GenerateReport(List<StockProduct> listOfRecords)
        {
            ListOfRecords = new List<ReportStockProduct>();

            for (int i = 0; i < listOfRecords.Count; i++)
            {
                var reportStockProduct = new ReportStockProduct()
                {
                    ProductCode = listOfRecords[i].ProductCode,
                    ProductSize = listOfRecords[i].ProductSize,
                    ProductReference = listOfRecords[i].ProductReference,
                    Supplier = listOfRecords[i].Supplier,
                    ProductDescription = listOfRecords[i].ProductDescription,
                    MinStock = listOfRecords[i].MinStock,
                    MaxStock = listOfRecords[i].MaxStock,
                    StockQuantity = listOfRecords[i].StockQuantity,
                    StockValue = listOfRecords[i].StockValue,
                    StockSummary = listOfRecords[i].StockSummary,
                    StockResult = listOfRecords[i].StockResult
                };

                ListOfRecords.Add(reportStockProduct);
            }
        }
        #endregion
    }
}
