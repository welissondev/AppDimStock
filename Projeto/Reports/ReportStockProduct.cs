using DimStock.Business;
using DimStock.Interfaces;
using DimStock.UserForms;
using System.Collections.Generic;

namespace DimStock.Reports
{
    public class ReportStockProduct : IReport<Stock>
    {
        #region Get e Set
        public int ProductCode { get; set; }
        public int ProductSize { get; set; }
        public int ProductReference { get; set; }
        public string ProductDescription { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public int StockQuantity { get; set; }
        public double StockValue { get; set; }
        public string StockSummary { get; set; }
        public string StockResult { get; set; }
        #endregion

        #region Methods

        public void GenerateReport(List<Stock> list)
        {
            var reportList = new List<ReportStockProduct>();

            for (int i = 0; i < list.Count; i++)
            {
                var report = new ReportStockProduct()
                {
                    ProductCode = list[i].Product.Code,
                    ProductSize = list[i].Product.Size,
                    ProductReference = list[i].Product.Reference,
                    ProductDescription = list[i].Product.Description,
                    MinStock = list[i].Min,
                    MaxStock = list[i].Max,
                    StockQuantity = list[i].Quantity,
                    StockValue = list[i].TotalValue,
                    StockSummary = list[i].Summary,
                    StockResult = list[i].Result
                };

                reportList.Add(report);
            }

            var path = "DimStock.Reports.StockProduct.rdlc";
            var description = "Relatório de estoque";
            var dataSet = "DataSetStockProduct";

            ReportViewForm.ShowReport(path, description, true,
            new Dictionary<string, object>() { {dataSet,
            reportList}});

        }
        #endregion
    }
}
