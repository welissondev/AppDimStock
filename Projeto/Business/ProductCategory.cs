using System.Collections.Generic;
using DimStock.Auxiliarys;

namespace DimStock.Business
{
    public class ProductCategory
    {
        public ProductCategory(){}

        public ProductCategory(AxlDataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public List<ProductCategory> ListOfRecords { get; set; }
        public AxlDataPagination DataPagination { get; set; }

        public bool Register()
        {
            return false;
        }

        public bool Modify(int id)
        {
            return false;
        }

        public bool Delete(int id)
        {
            return false;
        }

        public void SearchData()
        {

        }
    }
}
