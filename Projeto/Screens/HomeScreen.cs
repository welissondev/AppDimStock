using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class HomeScreen : Form
    {
        #region Builder

        public HomeScreen()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private int childFormNumber = 0;

        #endregion 

        #region  Get & Set

        public static HomeScreen He { get; set; }

        #endregion

        #region Form

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {
            He = this;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form
            {
                MdiParent = this,
                Text = "Janela " + childFormNumber++
            };
            childForm.Show();
        }

        protected override void OnLoad(EventArgs e)
        {
            //Remove o 3d do mdiform e modifica a cor de fundo
            try
            {
                var homeScreen = this.Controls.OfType<MdiClient>().SingleOrDefault();
                homeScreen.BackColor = Color.White;
                this.SuspendLayout();
                homeScreen.SuspendLayout();
                var hdiff = homeScreen.Size.Width - homeScreen.ClientSize.Width;
                var vdiff = homeScreen.Size.Height - homeScreen.ClientSize.Height;
                var size = new Size(homeScreen.Width + hdiff, homeScreen.Height + vdiff);
                var location = new Point(homeScreen.Left - (hdiff / 2), homeScreen.Top - (vdiff / 2));
                homeScreen.Dock = DockStyle.None;
                homeScreen.Size = size;
                homeScreen.Location = location;
                homeScreen.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                homeScreen.ResumeLayout(true);
                this.ResumeLayout(true);
                base.OnLoad(e);
            }

            catch (Exception ex)
            {
                ex.GetType();
                this.Close();
            }
        }

        #endregion

        #region MenuStrip

        private void MenuProduct_RegisterNew_Product_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new ProductAddScreen()
            {
                MdiParent = this,
                ControlBox = false,
                Movable = false,
                Dock = DockStyle.Fill,
                MaximizeBox = false,
                MinimizeBox = false
            };

            form.Show();
        }

        private void MenuProduct_RegisterNew_Category_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new CategoryAddScreen()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ControlBox = false
            };

            form.Show();
        }

        private void MenuProduct_ListRegisters_Product_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new ProductListingScreen()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ControlBox = false
            };

            form.Show();
        }

        private void MenuProduct_ListRegisters_Category_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new CategoryListingScreen()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ControlBox = false
            };

            form.Show();

        }

        private void MenuStock_RegisterNew_Entrie_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new MovementAddScreen()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            form.Show();
        }

        private void MenuStock_RegisterNew_Output_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new MovementAddScreen()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            form.Show();
        }

        private void MenuStock_ListMovements_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new MovementListingScreen()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();
        }

        private void MenuStock_ListStocks_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new StockListingScreen()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();
        }

        private void MenuUser_RegisterNew_Click(object sender, EventArgs e)
        {
            var user = new UserLoginModel();
            user.GetDetail(UserLoginState.Id);

            if (user.PermissionToView == true)
            {
                MdiClosingAll.CloseAllForms();

                var form = new UserLoginAddScreen()
                {
                    MdiParent = this,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                form.Show();
            }
            else
            {
                MessageBox.Show("Apenas administradores podem acessar " +
                "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void MenuUser_ListUsers_Click(object sender, EventArgs e)
        {
            var user = new UserLoginModel();
            user.GetDetail(UserLoginState.Id);

            if (user.PermissionToView == true)
            {
                MdiClosingAll.CloseAllForms();

                var form = new UserListingScreen()
                {
                    MdiParent = this,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                form.Show();
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar " +
                "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void MenuSettings_Backup_GenerateNew_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new BackupSaveScreen()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();
        }

        private void MenuSettings_Backup_ImportAnother_Click(object sender, EventArgs e)
        {
            MdiClosingAll.CloseAllForms();

            var form = new AppSettingsScreen()
            {
                WindowState = FormWindowState.Normal,
                MdiParent = HomeScreen.He,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ShowInTaskbar = false
            };

            form.CheckBoxRestoureBackup.Checked = true;
            form.MainTabControl.SelectTab("PageBackUp");

            form.Show();
        }

        #endregion

        #region LabelLink

        private void MainMenu_Product_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContextMenu_Product.Show();
            ContextMenu_Product.Location = MousePosition;
        }

        private void MainMenu_Stock_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContextMenu_Stock.Show();
            ContextMenu_Stock.Location = MousePosition;
        }

        private void MainMenu_User_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContextMenu_User.Show();
            ContextMenu_User.Location = MousePosition;
        }

        private void MainMenu_Support_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                string url = "https://diarioexcel.com.br/contato-diario-excel/";
                Process.Start(url);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void MainMenu_Settings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ContextMenu_Settings.Show();
            ContextMenu_Settings.Location = MousePosition;
        }

        #endregion
    }
}
