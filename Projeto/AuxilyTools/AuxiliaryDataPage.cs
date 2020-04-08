using System;

namespace DimStock.AuxilyTools
{
    /// <summary>
    /// Pode ser usado entre a view e um model a fim de obter ou 
    /// definir estados de uma paginação de dados
    /// </summary>
    public class AuxiliaryDataPage
    {
        private int pageSize = 20;
        private int currentPage = 1;

        public int RecordCount { get; set; }
        public int CurrentPage { get => currentPage; set => currentPage = value; }
        public int OffSetValue { get; set; }
        public int PageSize { get => pageSize; set => pageSize = value; }
        public int NumberOfPages { get => CountTotalPages(); } 

        private int CountTotalPages()
        {
            var resultDivisionPage = (float)RecordCount / PageSize;
            
            var nunberOfPages = Convert.ToInt32(Math.Ceiling(resultDivisionPage)); 

            return nunberOfPages;
        }
    }
}
