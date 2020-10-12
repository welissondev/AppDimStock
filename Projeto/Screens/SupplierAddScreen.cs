using MetroFramework.Forms;
using DimStock.Views;

namespace DimStock.Screens
{
    public partial class SupplierAddScreen : MetroForm, ISupplierAddView
    {
        public int Id { get; set; }
        public string TypeOfRegistration { get => TextTypeOfRegistration.Text; set => TextTypeOfRegistration.Text = value; }
        public string CompyName { get => TextCompanyName.Text; set => TextCompanyName.Text = value; }
        public string FantasyName { get => TextFantasyName.Text; set => TextFantasyName.Text = value; }
        public string IndentyCard_StateRegister { get => TextIndentyCard_StateRegister.Text; set => TextIndentyCard_StateRegister.Text = value; }
        public string SocialSecurity_NationalRegister { get => TextSocialSecurity_NationalRegistration.Text; set => TextSocialSecurity_NationalRegistration.Text = value; }
        public string AddressDescription { get => TextAddressDescription.Text; set => TextAddressDescription.Text = value; }
        public string District { get => TextDistrict.Text; set => TextDistrict.Text = value; }
        public string City { get => TextCity.Text; set => TextCity.Text = value; }
        public string StateLocation { get => TextStateLocation.Text; set => TextStateLocation.Text = value; }
        public string ZipCode { get => TextZipCode.Text; set => TextZipCode.Text = value; }
        public int StreetNumber { get => int.Parse(TextStreetNumber.Text); set => TextStreetNumber.Text = value.ToString(); }
        public string FixePhone { get => TextFixePhone.Text; set => TextFixePhone.Text = value; }
        public string MobilePhone { get => TextMobilePhone.Text; set => TextMobilePhone.Text = value; }
        public string Email { get => TextEmail.Text; set => TextEmail.Text = value; }
    }
}

namespace DimStock.Screens
{
    public partial class SupplierAddScreen
    {
        public SupplierAddScreen()
        {
            InitializeComponent();
        }
    }
}
