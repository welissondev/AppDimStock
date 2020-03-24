namespace DimStock.Views
{
    public interface ICategoryListingView : ICategoryAddView
    {
        string SearchByDescription { get; set; }
        object DataList { get; set; }
    }
}
