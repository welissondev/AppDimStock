namespace DimStock.Views
{
    public interface ISupplierListingView : ISupplierAddView
    {
        string SearchTypeOfRegistration { get; set; }
        string SearchCompanyName { get; set; }
        string SearchIndentyCard_StateRegister { get; set; }
        string SearchSocialSecurity_NationalRegister { get; set; }
        object DataList { get; set; }
    }
}
