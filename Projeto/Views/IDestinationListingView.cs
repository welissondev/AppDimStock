namespace DimStock.Views
{
    public interface IDestinationListingView : IDestinationAddView
    {
        string SearchDestinationDescription { get; set; }
        object DataList { get; set; }
    }
}
