using System.Collections.Generic;
using DimStock.Business;

namespace DimStock.Reports
{
    public class ReportProduct 
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

        public void GenerateReport(List<Product> productList)
        {
            ListOfRecords = new List<ReportProduct>();

            for (int i = 0; i < productList.Count; i++)
            {
                var reportProduct = new ReportProduct()
                {
                    Code = productList[i].Code,
                    Size = productList[i].Size,
                    Reference = productList[i].Reference,
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
