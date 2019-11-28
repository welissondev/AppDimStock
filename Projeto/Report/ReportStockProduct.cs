using DimStock.Business;
using System;
using System.Collections.Generic;

namespace DimStock.Report
{
    public class ReportStockProduct
    {
        #region Get e Set
        public string ProductCode { get; set; }
        public string ProductSize { get; set; }
        public string ProductReference { get; set; }
        public string ProductDescription { get; set; }
        public string Supplier { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public int StockQuantity { get; set; }
        public double StockValue { get; set; }
        public string StockResume { get; set; }
        public string StockResult { get; set; }
        public List<ReportStockProduct> ListOfRecords { get; set; }
        #endregion

        public void Generate(List<BllStockProduct> listOfRecords)
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
                    StockResume = listOfRecords[i].StockResume,
                    StockResult = listOfRecords[i].StockResult
                };

                ListOfRecords.Add(reportStockProduct);
            }
        }
    }
}
