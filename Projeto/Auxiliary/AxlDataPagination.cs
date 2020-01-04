using System;

namespace DimStock.Auxiliary
{
    public class AxlDataPagination
    {
        #region PrivateProperties
        private int pageSize = 20;
        private int currentPage = 1;
        #endregion 

        #region PublicProperties
        public int RecordCount { get; set; }
        public int CurrentPage { get => currentPage; set => currentPage = value; }
        public int OffSetValue { get; set; }
        public int PageSize { get => pageSize; set => pageSize = value; }
        public int NumberOfPages { get => CountTotalPages(); }
        #endregion 

        #region Methods

        private int CountTotalPages()
        {
            var resultDivisionPage = (float)RecordCount / PageSize;
            
            var nunberOfPages = Convert.ToInt32(Math.Ceiling(resultDivisionPage)); 

            return nunberOfPages;
        }

        #endregion
    }
}
