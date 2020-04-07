namespace DimStock.Views
{
    public interface IProductListingView : IProductAddView
    {
        string SearchInternalCode { get; set; }
        string SearchDescription { get; set; }
        object ProductList { get; set; }
    }
}
