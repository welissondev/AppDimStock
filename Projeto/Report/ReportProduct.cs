using System;
using System.Collections.Generic;
using DimStock.Business;
using DimStock.Auxiliary.Interfaces;

namespace DimStock.Report
{
    public class ReportProduct : IReportController<BllProduct>
    {

        #region Get e Set
        public int Code { get; set; }
        public int Size { get; set; }
        public int Reference { get; set; }
        public string Supplier { get; set; }
        public string Description { get; set; }
        public int MinStock { get; set; }
        public int MaxStock { get; set; }
        public double CostPrice { get; set; }
        public List<ReportProduct> ListOfRecords { get; set; }
        #endregion

        #region Methods

        public void GenerateReport(List<BllProduct> productList)
        {
            ListOfRecords = new List<ReportProduct>();

            for (int i = 0; i < productList.Count; i++)
            {
                var reportProduct = new ReportProduct()
                {
                    Code = Convert.ToInt32(productList[i].Code),
                    Size = Convert.ToInt32(productList[i].Size),
                    Reference = Convert.ToInt32(productList[i].Reference),
                    Supplier = productList[i].Supplier,
                    Description = productList[i].Description,
                    MinStock = productList[i].MinStock,
                    MaxStock = productList[i].MaxStock,
                    CostPrice = productList[i].CostPrice
                };

                ListOfRecords.Add(reportProduct);
            }
        }

        #endregion 

    }
}
