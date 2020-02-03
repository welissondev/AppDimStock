using DimStock.Auxiliarys;
using DimStock.Business;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class HomeScreenForm : Form
    {
        #region  Get & Set

        public static HomeScreenForm He { get; set; }

        #endregion

        #region Properties

        private int childFormNumber = 0;

        #endregion 

        #region Contructs

        public HomeScreenForm()
        {
            InitializeComponent();
        }

        #endregion

        #region UserForm

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

        private void MenuProduct_RegisterNew_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new ProductRegistrationForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            FormNovigationDescription.Text = "Cadastro De Produtos";
        }

        private void MenuProduct_ListProduct_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new ProductListingForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            FormNovigationDescription.Text = "Lista De Produtos";
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

            FormNovigationDescription.Text = "Cadastro de Estoques";
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

            FormNovigationDescription.Text = "Cadastro De Estoque";
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

            FormNovigationDescription.Text = "Lista De Movimentações";
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

            FormNovigationDescription.Text = "Lista De Estoque";
        }

        private void MenuUser_RegisterNew_Click(object sender, EventArgs e)
        {
            var user = new User();
            user.ViewDetails(AxlLogin.Id);

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

                FormNovigationDescription.Text = "Cadastro De Usuários";
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
            user.ViewDetails(AxlLogin.Id);

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

                FormNovigationDescription.Text = "Lista De Usuários";
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
            user.ViewDetails(AxlLogin.Id);

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

                FormNovigationDescription.Text = "Lista De Históricos";
            }
            else
            {
                MessageBox.Show("Você não tem permissão para acessar " +
                "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void MenuSettings_Backup_Click(object sender, EventArgs e)
        {
            AxlMdiForm.CloseAllForms();

            var form = new BackupSaveForm()
            {
                MdiParent = this,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
            };

            form.Show();

            FormNovigationDescription.Text = "Configurações";
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
