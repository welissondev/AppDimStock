using DimStock.Views;
using DimStock.Models;
using System;
using DimStock.AuxilyTools.AuxilyClasses;

namespace DimStock.Presenters
{
    public class UserLoginListingPresenter
    {
        private IUserLoginListingView view;

        public UserLoginListingPresenter(IUserLoginListingView view)
        {
            this.view = view;
        }

        public void GetDetails(object sender, EventArgs e)
        {
            try
            {
                var user = new UserLoginModel() { Id = view.Id };
                user.GetDetails();

                view.Id = user.Id;
                view.YourName = user.YourName;
                view.Email = user.Email;
                view.Login = user.Login;
                view.AccessPassWord = user.AccessPassWord;
                view.PassWordCheck = user.PassWordCheck;
                view.InsertAllowed = user.InsertAllowed;
                view.UpdateAllowed = user.UpdateAllowed;
                view.DeleteAllowed = user.DeleteAllowed;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void Delete(object sender, EventArgs e)
        {
            try
            {
                if (new UserLoginModel() { Id = view.Id }.Delete() == true)
                    ClearView(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void SearchData(object sender, EventArgs e)
        {
            try
            {
                var user = new UserLoginModel()
                {
                    YourName = view.SearchYourName,
                    Login = view.SearchLogin,
                    Email = view.SearchEmail
                };

                view.DataList = user.SearchData();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        public void ClearView(object sender, EventArgs e)
        {
            try
            {
                view.Id = 0;
                view.YourName = string.Empty;
                view.Email = string.Empty;
                view.Login = string.Empty;
                view.SearchYourName = string.Empty;
                view.SearchEmail = string.Empty;
                view.SearchLogin = string.Empty;
                view.AccessPassWord = string.Empty;
                view.PassWordCheck = string.Empty;
                view.InsertAllowed = false;
                view.UpdateAllowed = false;
                view.DeleteAllowed = false;

                SearchData(sender, e);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
