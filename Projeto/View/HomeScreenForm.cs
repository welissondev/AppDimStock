using DimStock.Auxiliary;
using DimStock.Business;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.View
{
    public partial class HomeScreenForm : Form
    {
        #region Properties
        private int childFormNumber = 0;
        #endregion 

        #region Contructs

        #region MDIPrincipal
        public HomeScreenForm()
        {
            InitializeComponent();
        }
        #endregion

        #endregion

        #region UserForm

        #region ShowNewForm()
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form
            {
                MdiParent = this,
                Text = "Janela " + childFormNumber++
            };
            childForm.Show();
        }
        #endregion

        #region OnLoad()
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

        #endregion

        #region MenuStrip

        #region MenuProduct_RegisterNew_Click()
        private void MenuProduct_RegisterNew_Click(object sender, EventArgs e)
        {
            var productRegister = new ProductRegistrationForm();
            productRegister.MdiParent = this;
            productRegister.WindowState = FormWindowState.Maximized;
            productRegister.Show();
        }
        #endregion

        #region MenuProduct_ListProducts_Click()
        private void MenuProduct_ListProducts_Click(object sender, EventArgs e)
        {
            var productList = new ProductListingForm();
            productList.MdiParent = this;
            productList.Show();
        }
        #endregion

        #region MenuStock_RegisterNew_Entry_Click()
        private void MenuStock_RegisterNew_Entry_Click(object sender, EventArgs e)
        {
            try
            {
                var view = new StockMovimentRegistrationForm();
                view.OperationType.Text = "Entrada";
                view.RegisterStockMovement();
                view.GetStockMovementDetails(Convert.ToInt32(view.StockMovementId.Text));
                view.MdiParent = this;
                view.WindowState = FormWindowState.Maximized;
                view.Show();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }
        #endregion

        #region MenuStock_RegisterNew_Output_Click()
        private void MenuStock_RegisterNew_Output_Click(object sender, EventArgs e)
        {
            try
            {
                var view = new StockMovimentRegistrationForm();
                view.OperationType.Text = "Saída";
                view.RegisterStockMovement();
                view.GetStockMovementDetails(Convert.ToInt32(view.StockMovementId.Text));
                view.MdiParent = this;
                view.WindowState = FormWindowState.Maximized;
                view.Show();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }
        #endregion

        #region MenuStock_ListStockMovement_Click()
        private void MenuStock_ListStockMovement_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new StockMovementListingForm();
                frm.WindowState = FormWindowState.Maximized;
                frm.MdiParent = this;
                frm.Show();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }
        #endregion

        #region MenuStock_ListStocks_Click()
        private void MenuStock_ListStocks_Click(object sender, EventArgs e)
        {
            var stockList = new StockListingForm();
            stockList.MdiParent = this;
            stockList.Show();
        }
        #endregion

        #region MenuUser_RegisterNew_Click()
        private void MenuUser_RegisterNew_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new UserController();
                user.ViewDetails(LoginAssistant.Id);

                if (user.PermissionToView == true)
                {
                    UserResgistrationForm frm = new UserResgistrationForm();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Apenas administradores podem acessar " +
                    "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }
        #endregion

        #region MenuUser_ListUsers_Click()
        private void MenuUser_ListUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new UserController();
                user.ViewDetails(LoginAssistant.Id);

                if (user.PermissionToView == true)
                {
                    var userList = new UserListingForm();
                    userList.WindowState = FormWindowState.Maximized;
                    userList.MdiParent = this;
                    userList.Show();
                }
                else
                {
                    MessageBox.Show("Apenas administradores podem acessar " +
                    "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }
        #endregion

        #region MenuUser_ListHistorics_Click()
        private void MenuUser_ListHistorics_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new UserController();
                user.ViewDetails(LoginAssistant.Id);

                if (user.PermissionToView == true)
                {
                    var userHistoricList = new UserHistoryListingForm();
                    userHistoricList.WindowState = FormWindowState.Maximized;
                    userHistoricList.MdiParent = this;
                    userHistoricList.Show();
                }
                else
                {
                    MessageBox.Show("Apenas administradores podem acessar " +
                    "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }
        #endregion

        #endregion
    }
}
