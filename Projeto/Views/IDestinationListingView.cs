namespace DimStock.Views
{
    public interface IDestinationListingView : IDestinationAddView
    {
        string SearchLocationDescription { get; set; }
        object DataList { get; set; }
    }
}
