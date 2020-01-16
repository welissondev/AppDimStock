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
        #region  Get & Set

        public static HomeScreenForm Form { get; set; }

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
            Form = this;
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
            ProductRegistrationForm.Init();
        }

        private void MenuProduct_ListProducts_Click(object sender, EventArgs e)
        {
            ProductListingForm.Init();
        }

        private void MenuStock_RegisterNew_Entry_Click(object sender, EventArgs e)
        {
            try
            {
                StockMovementRegistrationForm.Init();
                StockMovementRegistrationForm.InitializeNewMovement("Entrada");
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void MenuStock_RegisterNew_Output_Click(object sender, EventArgs e)
        {
            try
            {
                StockMovementRegistrationForm.Init();
                StockMovementRegistrationForm.InitializeNewMovement("Saída");
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void MenuStock_ListStockMovement_Click(object sender, EventArgs e)
        {
            try
            {
                StockMovementListingForm.Init();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void MenuStock_ListStocks_Click(object sender, EventArgs e)
        {
           StockListingForm.Init();
        }

        private void MenuUser_RegisterNew_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User();
                user.ViewDetails(LoginAssistant.Id);

                if (user.PermissionToView == true)
                {
                    UserResgistrationForm.Init();
                }
                else
                {
                    MessageBox.Show("Apenas administradores podem acessar " +
                    "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void MenuUser_ListUsers_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User();
                user.ViewDetails(LoginAssistant.Id);

                if (user.PermissionToView == true)
                {
                    UserListingForm.Init();
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para acessar " +
                    "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void MenuUser_ListHistorics_Click(object sender, EventArgs e)
        {
            try
            {
                var user = new User();
                user.ViewDetails(LoginAssistant.Id);

                if (user.PermissionToView == true)
                {
                    UserHistoryListingForm.Init();
                }
                else
                {
                    MessageBox.Show("Você não tem permissão para acessar " +
                    "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion
    }
}
