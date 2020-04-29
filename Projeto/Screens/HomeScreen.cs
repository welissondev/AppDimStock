using Bunifu.UI.WinForms.BunifuButton;
using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class HomeScreen : Form
    {
        private static HomeScreen homeScreen;
        private List<string> sideMenuNames;
    }
}

namespace DimStock.Screens
{
    public partial class HomeScreen
    {
        public HomeScreen()
        {
            InitializeComponent();
            InitializeEvents();
            Mdi3dRemove.SetBevel(this, false, Color.White);
            homeScreen = this;
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            SetMenuIcons();
            SetSideMenuNames();
            ShowUserLoginAccessScreen();
        }

        private void ShowCategoryAddScreen(object sender, EventArgs e)
        {
            var screen = new ProductListingScreen()
            {
                MdiParent = this,
                Dock = DockStyle.Fill,
                ControlBox = false,
                Movable = false,
                Style = MetroFramework.MetroColorStyle.White
            };
            screen.Show();
        }

        private void ShowMenuGeneralRegistration(object sender, EventArgs e)
        {
            MenuContextRegistration.Show(this, MousePosition);
        }

        private void ShowUserLoginAccessScreen()
        {
            homeScreen.Hide();

            var screen = new UserLoginAccessScreen();
            screen.Show();
        }

        private void MenuExtenter(object sender, EventArgs e)
        {
            var expanded = 200;
            var unexpanded = 65;

            if (PanelMenuSide.Width == expanded)
            {
                PanelMenuSide.Width = unexpanded;
                PanelMenuLower.Visible = false;
                ButtonMenuExtender.Left = PanelMenuSide.Width / 2 - ButtonMenuExtender.Width / 2;
                ButtonMenuExtender.Image = Resources.IconNext;

                foreach (BunifuButton buttonMenu in PanelMenuSide.Controls.OfType<BunifuButton>())
                    buttonMenu.Text = string.Empty;
            }
            else
            {
                PanelMenuSide.Width = expanded;
                ButtonMenuExtender.Left = PanelMenuSide.Left + 165;
                ButtonMenuExtender.Image = Resources.IconBack;
                PanelMenuLower.Visible = true;

                var i = 0;
                foreach (BunifuButton buttonMenu in PanelMenuSide.Controls.OfType<BunifuButton>())
                {
                    buttonMenu.Text = sideMenuNames[i].ToString();
                    i += 1;
                }
            }
        }

        private void InitializeEvents()
        {
            Load += new EventHandler(ScreenLoad);
            ButtonMenuProducts.Click += new EventHandler(ShowCategoryAddScreen);
            ButtonMenuGeneralRegistrations.Click += new EventHandler(ShowMenuGeneralRegistration);
            ButtonMenuExtender.Click += new EventHandler(MenuExtenter);
        }

        private void SetMenuIcons()
        {
            try
            {
                //Menus do panel lateral
                var iconPadgingDefault = 10;

                ButtonMenuCategorys.IdleIconLeftImage = Resources.IconCategory;
                ButtonMenuCategorys.TextMarginLeft = -10;
                ButtonMenuCategorys.IconPadding = iconPadgingDefault;

                ButtonMenuProducts.IdleIconLeftImage = Resources.IconProduct;
                ButtonMenuProducts.TextMarginLeft = -12;
                ButtonMenuProducts.IconPadding = iconPadgingDefault;

                ButtonMenuStocks.IdleIconLeftImage = Resources.IconStock;
                ButtonMenuStocks.TextMarginLeft = -12;
                ButtonMenuStocks.IconPadding = iconPadgingDefault;

                ButtonMenuMovements.IdleIconLeftImage = Resources.IconMovementStock;
                ButtonMenuMovements.TextMarginLeft = 8;
                ButtonMenuMovements.IconPadding = iconPadgingDefault;

                ButtonMenuDestinations.IdleIconLeftImage = Resources.IconDestination;
                ButtonMenuDestinations.TextMarginLeft = -14;
                ButtonMenuDestinations.IconPadding = iconPadgingDefault;

                ButtonMenuSupplies.IdleIconLeftImage = Resources.IconSupplier;
                ButtonMenuSupplies.IconPadding = iconPadgingDefault;

                ButtonMenuUsers.IdleIconLeftImage = Resources.IconUser;
                ButtonMenuUsers.TextMarginLeft = -15;
                ButtonMenuUsers.IconPadding = iconPadgingDefault;

                ButtonMenuExtender.Image = Resources.IconBack;

                //Menu do panel do top
                ButtonMenuGeneralRegistrations.IdleIconLeftImage = Resources.IconNew;
                ButtonMenuGeneralRegistrations.TextMarginLeft = 12;
                ButtonMenuGeneralRegistrations.IconPadding = iconPadgingDefault;

                ButtonMenuTechSupport.IdleIconLeftImage = Resources.IconSupport;
                ButtonMenuTechSupport.TextMarginLeft = 10;
                ButtonMenuTechSupport.IconPadding = iconPadgingDefault;

                ButtonMenuSettings.IdleIconLeftImage = Resources.IconSettings;
                ButtonMenuSettings.TextMarginLeft = 6;
                ButtonMenuSettings.IconPadding = iconPadgingDefault;

                ButtonDimStockIcon.IdleIconLeftImage = Resources.ImageLogoType;
                ButtonDimStockIcon.TextMarginLeft = -10;
                ButtonDimStockIcon.IconPadding = 10;
                ButtonDimStockIcon.IconMarginLeft = 12;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void SetSideMenuNames()
        {
            sideMenuNames = new List<string>();

            foreach (BunifuButton buttonMenu in PanelMenuSide.Controls.OfType<BunifuButton>())
                sideMenuNames.Add(buttonMenu.Text);
        }

        public static HomeScreen GetScreen()
        {
            return homeScreen;
        }

    }
}
