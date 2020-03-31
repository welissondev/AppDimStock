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
    }
}
