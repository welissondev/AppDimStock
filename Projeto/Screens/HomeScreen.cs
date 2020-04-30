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
        private static HomeScreen thisScreen;
        private List<string> listMenuNames;
    }
}

namespace DimStock.Screens
{
    public partial class HomeScreen
    {
        public HomeScreen()
        {
            try
            {
                InitializeComponent();
                InitializeEvents();
                SetScreen();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            try
            {
                SetTopSideMenuIcons();
                GetSideMenuNames();
                ShowUserLoginAccessScreen();
                Mdi3dRemove.SetBevel(this, false, Color.White);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ShowChildScreen(object sender, EventArgs e)
        {
            if (sender.Equals(ToolStripCategoyAddScreen))
                CategoryAddScreen.ShowScreen(this);

            if (sender.Equals(ButtonMenuCategorys))
                CategoryListingScreen.ShowScreen(this);

            if (sender.Equals(ToolStripProductAddScreen))
                ProductAddScreen.ShowScreen(this);

            if (sender.Equals(ButtonMenuProducts))
                ProductListingScreen.ShowScreen(this);

            if (sender.Equals(ToolStripUserAddScreen))
                UserLoginAddScreen.ShowScreen(this);

            if (sender.Equals(ButtonMenuUsers))
                UserListingScreen.ShowScreen(this);
        }

        private void ShowMenuContext(object sender, EventArgs e)
        {
            try
            {
                if (sender.Equals(ButtonMenuGeneralRegistrations))
                {
                    MenuContextRegistration.Show(this, MousePosition);
                }
                else if (sender.Equals(ButtonMenuSettings))
                {
                    MenuContextSettings.Show(this, MousePosition);
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ShowUserLoginAccessScreen()
        {
            try
            {
                thisScreen.Hide();

                var screen = new UserLoginAccessScreen();
                screen.Show();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void MenuExtenter(object sender, EventArgs e)
        {
            try
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
                    {
                        buttonMenu.IdleBorderRadius = 45;
                        buttonMenu.Text = string.Empty;
                    }
                }
                else
                {
                    PanelMenuSide.Width = expanded;
                    ButtonMenuExtender.Left = PanelMenuSide.Left + 170;
                    ButtonMenuExtender.Image = Resources.IconBack;
                    PanelMenuLower.Visible = true;

                    var i = 0;
                    foreach (BunifuButton buttonMenu in PanelMenuSide.Controls.OfType<BunifuButton>())
                    {
                        buttonMenu.IdleBorderRadius = 50;
                        buttonMenu.Text = listMenuNames[i].ToString();
                        i += 1;
                    }
                }
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
                ButtonMenuProducts.Click += new EventHandler(ShowChildScreen);
                ToolStripCategoyAddScreen.Click += new EventHandler(ShowChildScreen);
                ToolStripProductAddScreen.Click += new EventHandler(ShowChildScreen);
                ToolStripUserAddScreen.Click += new EventHandler(ShowChildScreen);
                ButtonMenuCategorys.Click += new EventHandler(ShowChildScreen);
                ButtonMenuUsers.Click += new EventHandler(ShowChildScreen);
                ButtonMenuGeneralRegistrations.Click += new EventHandler(ShowMenuContext);
                ButtonMenuSettings.Click += new EventHandler(ShowMenuContext);
                ButtonMenuExtender.Click += new EventHandler(MenuExtenter);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void SetTopSideMenuIcons()
        {
            try
            {
                //Menus do panel lateral
                var iconSidePadgingDefault = 10;
                var iconTopPadginDefault = 10;

                ButtonMenuCategorys.IdleIconLeftImage = Resources.IconCategory;
                ButtonMenuCategorys.TextMarginLeft = -10;
                ButtonMenuCategorys.IconPadding = iconSidePadgingDefault;

                ButtonMenuProducts.IdleIconLeftImage = Resources.IconProduct;
                ButtonMenuProducts.TextMarginLeft = -12;
                ButtonMenuProducts.IconPadding = iconSidePadgingDefault;

                ButtonMenuStocks.IdleIconLeftImage = Resources.IconStock;
                ButtonMenuStocks.TextMarginLeft = -12;
                ButtonMenuStocks.IconPadding = iconSidePadgingDefault;

                ButtonMenuMovements.IdleIconLeftImage = Resources.IconMovementStock;
                ButtonMenuMovements.TextMarginLeft = 8;
                ButtonMenuMovements.IconPadding = iconSidePadgingDefault;

                ButtonMenuDestinations.IdleIconLeftImage = Resources.IconDestination;
                ButtonMenuDestinations.TextMarginLeft = -14;
                ButtonMenuDestinations.IconPadding = iconSidePadgingDefault;

                ButtonMenuSupplies.IdleIconLeftImage = Resources.IconSupplier;
                ButtonMenuSupplies.IconPadding = iconSidePadgingDefault;

                ButtonMenuUsers.IdleIconLeftImage = Resources.IconUser;
                ButtonMenuUsers.TextMarginLeft = -15;
                ButtonMenuUsers.IconPadding = iconSidePadgingDefault;

                ButtonMenuExtender.Image = Resources.IconBack;

                //Menu do panel do top
                ButtonMenuGeneralRegistrations.IdleIconLeftImage = Resources.IconNew;
                ButtonMenuGeneralRegistrations.TextMarginLeft = 12;
                ButtonMenuGeneralRegistrations.IconPadding = iconTopPadginDefault;

                ButtonMenuTechSupport.IdleIconLeftImage = Resources.IconSupport;
                ButtonMenuTechSupport.TextMarginLeft = 10;
                ButtonMenuTechSupport.IconPadding = iconTopPadginDefault;

                ButtonMenuSettings.IdleIconLeftImage = Resources.IconSettings;
                ButtonMenuSettings.TextMarginLeft = 6;
                ButtonMenuSettings.IconPadding = iconTopPadginDefault;

                ButtonDimStockIcon.IdleIconLeftImage = Resources.ImageLogoType;
                ButtonDimStockIcon.TextMarginLeft = -10;
                ButtonDimStockIcon.IconPadding = 7;
                ButtonDimStockIcon.IconMarginLeft = 18;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void GetSideMenuNames()
        {
            try
            {
                listMenuNames = new List<string>();

                foreach (BunifuButton buttonMenu in PanelMenuSide.Controls.OfType<BunifuButton>())
                    listMenuNames.Add(buttonMenu.Text);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public static HomeScreen GetScreen()
        {
            return thisScreen;
        }
        private void SetScreen()
        {
            thisScreen = this;
        }

    }
}
