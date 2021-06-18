namespace DimStock.Views
{
    public interface ISupplierListingView : ISupplierAddView
    {
        string SearchTypeOfRegistration { get; set; }
        string SearchYourName { get; set; }
        string SearchIndentyCard_StateRegister { get; set; }
        string SearchSocialSecurity_NationalRegister { get; set; }
        string SearchEmail { get; set; }
        object DataList { get; set; }
    }
}
