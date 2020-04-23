namespace DimStock.Views
{
    public interface ICategoryListingView : ICategoryAddView
    {
        object DataList { get; set; }
    }
}
