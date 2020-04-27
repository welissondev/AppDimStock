using DimStock.Properties;
using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Bunifu.UI.WinForms.BunifuButton;

namespace DimStock.Screens
{
    public partial class HomeScreen : Form
    {
        private static HomeScreen instance;
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
            instance = this;
        }

        private void ScreenLoad(object sender, EventArgs e)
        {
            SetScreenIcons();
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

        private void ShowContextMenuRegistration(object sender, EventArgs e)
        {
            MenuContextRegistration.Show(this, MousePosition);
        }

        private void MenuExtenter(object sender, EventArgs e)
        {
            var extended = 215;
            var unexpanded = 80;

            if (PanelMenuSide.Width == extended)
                PanelMenuSide.Width = unexpanded;
            else
                PanelMenuSide.Width = extended;

            foreach (BunifuButton ctl in PanelMenuSide.Controls.OfType<BunifuButton>())
            {
                ctl.Text = string.Empty;
            }
        }

        private void InitializeEvents()
        {
            Load += new EventHandler(ScreenLoad);
            ButtonMenuProducts.Click += new EventHandler(ShowCategoryAddScreen);
            ButtonMenuGeneralRegistrations.Click += new EventHandler(ShowContextMenuRegistration);
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

                //foreach (PictureBox ctl in PanelMenuSide.Controls.OfType<PictureBox>())
                //{
                //    if (ctl.Tag.ToString() == "ImageSeparator" && ctl.GetType() == typeof(PictureBox))
                //    {
                //        ctl.Image = Resources.ImageSeparator;
                //    };
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public static HomeScreen GetInstance()
        {
            return instance;
        }

    }
}
