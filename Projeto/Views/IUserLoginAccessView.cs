namespace DimStock.Views
{
    public interface IUserLoginAccessView : IUserLoginAddView
    {
        bool AcessStatus { get; set; }
    }
}
