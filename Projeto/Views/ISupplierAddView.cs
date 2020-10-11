namespace DimStock.Views
{
    public interface ISupplierAddView
    {
        int Id { get; set; }
        string TypeOfRegistration { get; set; }
        string CompyName { get; set; }
        string FantasyName { get; set; }
        string IndentyCard_StateRegister { get; set; }
        string SocialSecurity_NationalRegister { get; set; }
        string AddressDescription { get; set; }
        string District { get; set; }
        string City { get; set; }
        string StateLocation { get; set; }
        string ZipCode { get; set; }
        int StreetNumber { get; set; }
        string FixePhone { get; set; }
        string MobilePhone { get; set; }
        string Email { get; set; }
    }
}
