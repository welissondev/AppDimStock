using DimStock.Views;
using DimStock.Models;
using System;
using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Presenters
{
    public class UserLoginAccessPresenter
    {
        private IUserLoginAccessView view;

        public UserLoginAccessPresenter(IUserLoginAccessView view)
        {
            this.view = view;
        }

        public void Access(object sender, EventArgs e)
        {
            try
            {
                var user = new UserLoginModel()
                {
                    Login = view.Login,
                    AccessPassWord = view.AccessPassWord
                };

                if (user.Access() == true)
                {
                    view.Id = user.Id;
                    view.YourName = user.YourName;
                    view.Email = user.Email;
                    view.Login = user.Login;
                    view.AccessPassWord = user.AccessPassWord;
                    view.PassWordCheck = user.PassWordCheck;
                    view.InsertAllowed = user.InsertAllowed;
                    view.UpdateAllowed = user.UpdateAllowed;
                    view.DeleteAllowed = user.DeleteAllowed;
                    view.AcessStatus = true;
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
