using MetroFramework.Forms;
using DimStock.Views;

namespace DimStock.Screens
{
    public partial class SupplierListingScreen : MetroForm, ISupplierListingView
    {
        public int Id { get; set; }
        public string TypeOfRegistration { get; set; }
        public string CompyName { get; set; }
        public string FantasyName { get; set; }
        public string IndentyCard_StateRegister { get; set; }
        public string SocialSecurity_NationalRegister { get; set; }
        public string AddressDescription { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string StateLocation { get; set; }
        public string ZipCode { get; set; }
        public int StreetNumber { get; set; }
        public string FixePhone { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }

        public string SearchTypeOfRegistration { get; set; }
        public string SearchCompanyName { get => TextSearchCompanyName.Text; set => TextSearchCompanyName.Text = value; }
        public string SearchIndentyCard_StateRegister { get => TextSearchIndentyCard_StateRegister.Text; set => TextSearchIndentyCard_StateRegister.Text = value; }
        public string SearchSocialSecurity_NationalRegister { get => TextSearchSocialSecurity_NationalRegister.Text; set => TextSearchSocialSecurity_NationalRegister.Text = value; }
        public object DataList { get => GridList.DataSource; set => GridList.DataSource = value; }
    }
}

namespace DimStock.Screens
{
    public partial class SupplierListingScreen
    {
        public SupplierListingScreen()
        {
            InitializeComponent();
        }
    }
}
