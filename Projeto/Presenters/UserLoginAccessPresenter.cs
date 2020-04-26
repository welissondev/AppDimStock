using DimStock.Views;
using DimStock.Models;
using System;

namespace DimStock.Presenters
{
    public class UserLoginAccessPresenter
    {
        private IUserLoginAccessView view;

        public UserLoginAccessPresenter(IUserLoginAccessView view)
        {
            this.view = view;
        }

        public bool Access(object sender, EventArgs e)
        {
            var accessStatus = false;

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

                accessStatus = true;
            }

            return accessStatus;
        }
    }
}
