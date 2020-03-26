namespace DimStock.Views
{
    public interface ICategoryListingView : ICategoryAddView
    {
        string SearchDescription { get; set; }
        object DataList { get; set; }
    }
}
