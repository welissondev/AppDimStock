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
    public partial class HomeScreen : Form
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
            SetScreenIcons();
            SetSideMenuNames();
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

        private void MenuExtenter(object sender, EventArgs e)
        {
            var expanded = 200;
            var unexpanded = 65;

            if (PanelMenuSide.Width == expanded)
            {
                PanelMenuSide.Width = unexpanded;
                PanelMenuLower.Visible = false;
                ButtonMenuExtender.Left = PanelMenuSide.Width / 2 - ButtonMenuExtender.Width / 2;

                foreach (BunifuButton buttonMenu in PanelMenuSide.Controls.OfType<BunifuButton>())
                    buttonMenu.Text = string.Empty;
            }
            else
            {
                PanelMenuSide.Width = expanded;
                ButtonMenuExtender.Location = new Point(163, 16);
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

        private void SetScreenIcons()
        {
            try
            {
                ButtonMenuCategorys.IdleIconLeftImage = Resources.IconCategory;
                ButtonMenuProducts.IdleIconLeftImage = Resources.IconProduct;
                ButtonMenuStocks.IdleIconLeftImage = Resources.IconStock;
                ButtonMenuMovements.IdleIconLeftImage = Resources.IconMovementStock;
                ButtonMenuDestinations.IdleIconLeftImage = Resources.IconDestination;
                ButtonMenuSupplies.IdleIconLeftImage = Resources.IconSupplier;
                ButtonMenuUsers.IdleIconLeftImage = Resources.IconUser;
                ButtonMenuGeneralRegistrations.IdleIconLeftImage = Resources.IconNew;
                ButtonMenuTechSupport.IdleIconLeftImage = Resources.IconSupplier;
                ButtonMenuSettings.IdleIconLeftImage = Resources.IconSettings;
                ButtonMenuExtender.Image = Resources.IconExtendedMenu;
                ImageLogoBrand.SizeMode = PictureBoxSizeMode.StretchImage;
                ImageLogoBrand.Image = Resources.ImageLogoType;

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
