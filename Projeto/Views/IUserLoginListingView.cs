namespace DimStock.Views
{
    public interface IUserLoginListingView : IUserLoginAddView
    {
        object DataList { get; set; }
    }
}
