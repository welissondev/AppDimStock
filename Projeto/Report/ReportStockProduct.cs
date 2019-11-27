using DimStock.Business;
using System;
using System.Collections.Generic;

namespace DimStock.Report
{
    public class ReportStockProduct
    {
        #region Get e Set
        public int ProductCode { get; set; }
        public int ProductSize { get; set; }
        public int ProductReference { get; set; }
        public string ProductDescription { get; set; }
        public string ProductSupplier { get; set; }
        public int StockMin { get; set; }
        public int StockMax { get; set; }
        public int StockQuantity { get; set; }
        public double StockValue { get; set; }
        public string StockResume { get; set; }
        public string StockResult { get; set; }
        public List<ReportStockProduct> ListOfRecords{ get; set; }
        #endregion
    }
}
