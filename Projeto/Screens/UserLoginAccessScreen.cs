﻿using MetroFramework.Forms;
using DimStock.Views;
using DimStock.Presenters;
using System;
using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Screens
{
    /// <summary>
    /// Representa a tela de acesso do usuário
    /// </summary>
    public partial class UserLoginAccessScreen : MetroForm, IUserLoginAccessView
    {
        private UserLoginAccessPresenter presenter;

        public int Id { get; set; }
        public string YourName { get; set; }
        public string Email { get; set; }
        public string Login { get => TextLogin.Text; set => TextLogin.Text = value; }
        public string AccessPassWord { get => TextPassWord.Text; set => TextPassWord.Text = value; }
        public string PassWordCheck { get; set; }
        public bool InsertAllowed { get; set; }
        public bool UpdateAllowed { get; set; }
        public bool DeleteAllowed { get; set; }
    }
}

namespace DimStock.Screens
{
    public partial class UserLoginAccessScreen : MetroForm
    {
        public UserLoginAccessScreen()
        {
            InitializeComponent();
            InitializePresenter();
            InitializeEvents();
        }

        private void ScreenClose(object sender, EventArgs e)
        {
            try
            {
                var homeScreen = HomeScreen.GetScreen();
                homeScreen.Close();

                Close();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void UserAccess(object sender, EventArgs e)
        {
            try
            {
                if (presenter.Access(sender, e) == true)
                {
                    var homeScreen = HomeScreen.GetScreen();
                    homeScreen.Show();

                    Close();
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void InitializePresenter()
        {
            presenter = new UserLoginAccessPresenter(this);
        }
        private void InitializeEvents()
        {
            ButtonEnter.Click += new EventHandler(UserAccess);
            ButtonExit.Click += new EventHandler(ScreenClose);
        }
    }
}
