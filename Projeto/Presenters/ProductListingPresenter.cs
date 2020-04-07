using DimStock.Models;
using DimStock.Views;
using System.Data;

namespace DimStock.Presenters
{
    public class ProductListingPresenter
    {
        private IProductListingView view;

        public ProductListingPresenter(IProductListingView view)
        {
            this.view = view;
        }

        public DataTable FetchData()
        {
            var model = new ProductModel();
            var product = model;

            product.InternalCode = view.InternalCode;
            product.Description = view.Description;
            
            var table = product.FetchData();
            view.ProductList = table;
            
            return table;
        }
    }
}
