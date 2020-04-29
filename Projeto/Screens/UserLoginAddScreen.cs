using System;
using MetroFramework.Forms;
using DimStock.Views;

namespace DimStock.Screens
{
    public partial class UserLoginAddScreen : IUserLoginAddView
    {
        public int Id { get; set; }
        public string YourName { get => TextYourName.Text; set => TextYourName.Text = value; }
        public string Email { get => TextEmail.Text; set => TextEmail.Text = value; }
        public string Login { get => TextLogin.Text; set => TextLogin.Text = value; }
        public string AccessPassWord { get => TextAccessPassWord.Text; set => TextAccessPassWord.Text = value; }
        public string PassWordCheck { get => TextPassWordCheck.Text; set => TextPassWordCheck.Text = value; }
        public bool InsertAllowed { get => true; set => value = true; }
        public bool UpdateAllowed { get => true; set => value = true; }
        public bool DeleteAllowed { get => true; set => value = true; }
    }
}

namespace DimStock.Screens
{
    public partial class UserLoginAddScreen : MetroForm
    {
        public UserLoginAddScreen()
        {
            InitializeComponent();
            InitializeEvents();
        }

        private void ScreenResize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void InitializeEvents()
        {
            Resize += new EventHandler(ScreenResize);
        }
    }
}
