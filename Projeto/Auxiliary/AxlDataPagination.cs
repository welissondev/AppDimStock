using System;

namespace DimStock.Auxiliary
{
    public class AxlDataPagination
    {
        #region PrivateProperties
        private int pageSize = 100;
        #endregion 

        #region PublicProperties
        public int RecordCount { get; set; }
        public int CurrentPage { get; set; }
        public int OffSetValue { get; set; }
        public int PageSize { get => pageSize; set => pageSize = value; }
        public int NumberOfPages { get => CountTotalPages(); }
        #endregion 

        #region Methods

        #region CountTotalPages()
        private int CountTotalPages()
        {
            var resultDivisionPage = (float)RecordCount / PageSize;
            
            var nunberOfPages = Convert.ToInt32(Math.Ceiling(resultDivisionPage)); 

            return nunberOfPages;
        }
        #endregion

        #endregion
    }
}
