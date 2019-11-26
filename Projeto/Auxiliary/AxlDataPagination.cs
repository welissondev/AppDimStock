using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SysEstoque.Auxiliary
{
    public class AxlDataPagination
    {
        public int RecordCount { get; set; }
        public int PageSize { get; set; }
        public int OffSetValue { get; set; }
        public int CurrentPage { get; set; }
        public int NumberOfPages{get;set;}

        #region CountTotalPages()
        public int CountTotalPages()
        {
            var resultDivisionPage = (float)RecordCount / PageSize;

            NumberOfPages = Convert.ToInt32(Math.Ceiling(resultDivisionPage));

            return NumberOfPages;
        }
        #endregion
    }
}
