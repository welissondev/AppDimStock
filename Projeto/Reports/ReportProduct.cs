using DimStock.Business;
using System.Collections.Generic;
using DimStock.Interfaces;
using DimStock.UserForms;

namespace DimStock.Reports
{
    public class ReportProduct : IReport<Product>
    {
        #region Get e Set

        public int Code { get; set; }
        public int Size { get; set; }
        public int Reference { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }

        #endregion

        #region Methods

        public void GenerateReport(List<Product> list)
        {
            var reportList = new List<ReportProduct>();

            for (int i = 0; i < list.Count; i++)
            {
                var report = new ReportProduct()
                {
                    Code = list[i].Code,
                    Size = list[i].Size,
                    Reference = list[i].Reference,
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
