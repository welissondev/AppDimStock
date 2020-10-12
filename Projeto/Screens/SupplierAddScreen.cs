using MetroFramework.Forms;
using DimStock.Views;
using System;
using DimStock.AuxilyTools.AuxilyClasses;
using System.Windows.Forms;
using MetroFramework;
using DimStock.Presenters;
using System.Collections.Generic;

namespace DimStock.Screens
{
    public partial class SupplierAddScreen : MetroForm, ISupplierAddView
    {
        private static MetroForm thisScreen;

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
            InitializeEvents();
            SetScreen();
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            FillTypeOfRegistration();
        }
        private void ScreenResize(object sender, EventArgs e)
        {
            try
            {
                Refresh();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void ScreenClose(object sender, EventArgs e)
        {
            try
            {
                if (this != null)
                    Close();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void InitializeEvents()
        {
            try
            {
                Load += new EventHandler(ScreenLoad);
                ButtonSave.Click += new EventHandler(PresenterUpdate);
                ButtonDelete.Click += new EventHandler(PresenterDelete);
                ButtonClearView.Click += new EventHandler(PresenterClear);
                ButtonClose.Click += new EventHandler(ScreenClose);
                Resize += new EventHandler(ScreenResize);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void FillTypeOfRegistration()
        {
            try
            {
                var items = new List<string>()
                {
                    "Física",
                    "Jurídica"
                };

                TextTypeOfRegistration.DataSource = items;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void ResetTabControl()
        {
            try
            {
                MainTabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public static void SetDetails(ISupplierAddView view, MetroForm owner = null)
        {
            try
            {
                var screen = new SupplierAddScreen()
                {
                    Id = view.Id,
                    TypeOfRegistration = view.TypeOfRegistration,
                    CompyName = view.CompyName,
                    FantasyName = view.FantasyName,
                    IndentyCard_StateRegister = view.IndentyCard_StateRegister,
                    SocialSecurity_NationalRegister = view.AddressDescription,
                    AddressDescription = view.AddressDescription,
                    District = view.District,
                    City = view.City,
                    StateLocation = view.StateLocation,
                    ZipCode = view.ZipCode,
                    StreetNumber = view.StreetNumber,
                    FixePhone = view.FixePhone,
                    MobilePhone = view.MobilePhone,
                    Email = view.Email,

                    ShowIcon = false,
                    ShowInTaskbar = false,
                    ControlBox = false
                };

                if (owner != null)
                    screen.Owner = owner;

                screen.ShowDialog();
                screen.Dispose();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void SetScreen()
        {
            thisScreen = this;
        }
        public static MetroForm GetScreen()
        {
            return thisScreen;
        }

        public static void ShowScreen(Form mdi = null, Form owner = null)
        {
            try
            {
                var screen = new SupplierAddScreen();

                if (mdi != null)
                {
                    screen.MdiParent = mdi;
                    screen.ShowInTaskbar = false;
                    screen.ControlBox = false;
                    screen.Dock = DockStyle.Fill;
                    screen.Style = MetroColorStyle.White;
                    screen.Movable = false;

                    screen.Show();
                }
                else
                {
                    screen.ShowInTaskbar = false;
                    screen.ControlBox = false;
                    screen.ShowIcon = false;
                    screen.Style = MetroColorStyle.Blue;

                    if (owner != null)
                        screen.Owner = owner;

                    screen.ShowDialog();
                    screen.Dispose();
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        //Eventos para chamada dos métodos do apresentador
        private void PresenterUpdate(object sender, EventArgs e)
        {
            try
            {
                if (new SupplierAddPresenter(this).Update() == true)
                    ResetTabControl();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterDelete(object sender, EventArgs e)
        {
            try
            {
                if (new SupplierAddPresenter(this).Delete() == true)
                    ResetTabControl();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
        private void PresenterClear(object sender, EventArgs e)
        {
            try
            {
                new SupplierAddPresenter(this).Clear();
                ResetTabControl();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
