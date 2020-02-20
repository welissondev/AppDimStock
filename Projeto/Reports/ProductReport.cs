using DimStock.Business;
using System.Collections.Generic;
using DimStock.Interfaces;
using DimStock.UserForms;

namespace DimStock.Reports
{
    public class ProductReport : IReport<Product>
    {
        #region Get e Set

        public string Code { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }

        #endregion

        #region Methods

        public void GenerateReport(List<Product> list)
        {
            var reportList = new List<ProductReport>();

            for (int i = 0; i < list.Count; i++)
            {
                var report = new ProductReport()
                {
                    Code = list[i].InternalCode,
                    Description = list[i].Description,
                    CostPrice = list[i].CostPrice
                };

                reportList.Add(report);
            }

            var path = "DimStock.Reports.Product.rdlc";
            var description = "Relatório de Produtos";
            var dataset = "DataSetProduct";

            ReportViewForm.ShowReport(path, description, true,
            new Dictionary<string, object>() {{dataset,
            reportList}});

        }

        #endregion
    }
}
