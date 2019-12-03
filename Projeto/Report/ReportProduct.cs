using System;
using System.Collections.Generic;
using DimStock.Business;

namespace DimStock.Report
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
        public List<BllProduct> ListOfRecords { get; set; }
        #endregion
    }
}
