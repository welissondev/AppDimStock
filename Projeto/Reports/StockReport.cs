using DimStock.Models;
using DimStock.Screens;
using System.Collections.Generic;

namespace DimStock.Reports
{
    public class StockReport 
    {
        #region Get e Set
        public string ProductCode { get; set; }
        public string ProductDescription { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public int StockQuantity { get; set; }
        public double StockValue { get; set; }
        public string StockSummary { get; set; }
        public string StockResult { get; set; }
        #endregion

        #region Methods

        public void GenerateReport(List<StockModel> list)
        {
            var reportList = new List<StockReport>();

            for (int i = 0; i < list.Count; i++)
            {
                var report = new StockReport()
                {
                    ProductCode = list[i].Product.InternalCode,
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

            var path = "DimStock.Reports.Stock.rdlc";
            var description = "Relatório de estoque";
            var dataSet = "DataSetStock";

            ReportViewScreen.ShowReport(path, description, true,
            new Dictionary<string, object>() { {dataSet,
            reportList}});

        }

        #endregion
    }
}
