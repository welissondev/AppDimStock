﻿using DimStock.Auxiliarys;
using DimStock.Models;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class HomeScreenForm : Form
    {
        #region Builder

        public HomeScreenForm()
        {
            InitializeComponent();
        }

        #endregion

        #region Properties

        private int childFormNumber = 0;

        #endregion 

        #region  Get & Set

        public static HomeScreenForm He { get; set; }

        #endregion

        #region Form

        private void HomeScreenForm_Load(object sender, EventArgs e)
        {
            He = this;
            DayOfTheWeek.Text = DateTime.Now.ToLongDateString();

            Hide();

            UserLoginForm.ShowForm();
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
            AxlMdiForm.CloseAllForms();

            var form = new ProductRegistrationForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            LabelNavegationDescription.Text = "Cadastro De Produtos";
        }

        private void MenuProduct_RegisterNew_Category_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new ProductCategoryRegistrationForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            LabelNavegationDescription.Text = "Cadastro De Categorias";
        }

        private void MenuProduct_ListRegisters_Product_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new ProductListingForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            LabelNavegationDescription.Text = "Lista De Produtos";
        }

        private void MenuProduct_ListRegisters_Category_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new ProductCategoryListingForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            LabelNavegationDescription.Text = "Lista De Categorias";
        }

        private void MenuStock_RegisterNew_Entrie_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new StockMovementRegistrationForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };

            form.Show();

            form.StartNewOperation("Entrada");

            LabelNavegationDescription.Text = "Cadastro de Estoques";
        }

        private void MenuStock_RegisterNew_Output_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new StockMovementRegistrationForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill
            };
            form.Show();

            form.StartNewOperation("Saída");

            LabelNavegationDescription.Text = "Cadastro De Estoque";
        }

        private void MenuStock_ListMovements_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new StockMovementListingForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            LabelNavegationDescription.Text = "Lista De Movimentações";
        }

        private void MenuStock_ListStocks_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new StockListingForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            LabelNavegationDescription.Text = "Lista De Estoque";
        }

        private void MenuUser_RegisterNew_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.GetDetail(AxlLogin.Id);

            if (user.PermissionToView == true)
            {
                AxlMdiForm.CloseAllForms();

                var form = new UserResgistrationForm()
                {
                    MdiParent = this,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                form.Show();

                LabelNavegationDescription.Text = "Cadastro De Usuários";
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
            var user = new User();
            user.GetDetail(AxlLogin.Id);

            if (user.PermissionToView == true)
            {
                AxlMdiForm.CloseAllForms();

                var form = new UserListingForm()
                {
                    MdiParent = this,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                form.Show();

                LabelNavegationDescription.Text = "Lista De Usuários";
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar " +
                "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void MenuUser_ListHistory_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.GetDetail(AxlLogin.Id);

            if (user.PermissionToView == true)
            {
                AxlMdiForm.CloseAllForms();

                var form = new UserHistoryListingForm()
                {
                    MdiParent = this,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };

                form.Show();

                LabelNavegationDescription.Text = "Lista De Históricos";
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
            AxlMdiForm.CloseAllForms();

            var form = new BackupSaveForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            LabelNavegationDescription.Text = "Configurações";
        }

        private void MenuSettings_Backup_ImportAnother_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new AppSettingsForm()
            {
                WindowState = FormWindowState.Normal,
                MdiParent = HomeScreenForm.He,
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
                AxlException.Message.Show(ex);
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
