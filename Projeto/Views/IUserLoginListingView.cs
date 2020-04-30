namespace DimStock.Views
{
    public interface IUserLoginListingView : IUserLoginAddView
    {
        string SearchYourName { get; set; }
        string SearchLogin { get; set; }
        string SearchEmail { get; set; }
        object DataList { get; set; }
    }
}
