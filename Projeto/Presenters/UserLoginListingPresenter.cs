using DimStock.Views;
using DimStock.Models;
using System;

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
            var user = new UserLoginModel() { Id = view.Id };

            if (user.GetDetails() == true)
            {
                view.Id = user.Id;
                view.Name = user.Name;
                view.Email = user.Email;
                view.Login = user.Login;
                view.AccessPassWord = user.AccessPassWord;
                view.PassWordCheck = user.PassWordCheck;
                view.InsertAllowed = user.InsertAllowed;
                view.UpdateAllowed = user.UpdateAllowed;
                view.DeleteAllowed = user.DeleteAllowed;
            }
        }

        public void Delete(object sender, EventArgs e)
        {
            var user = new UserLoginModel() { Id = view.Id };

            if (user.Delete() == true)
            {
                ClearView(sender, e);
            }
        }

        public void SearchData(object sender, EventArgs e)
        {
            var user = new UserLoginModel()
            {
                Name = view.Name,
                Login = view.Login,
                Email = view.Email
            };

            view.DataList = user.SearchData();
        }

        public void ClearView(object sender, EventArgs e)
        {
            view.Id = 0;
            view.Name = string.Empty;
            view.Email = string.Empty;
            view.Login = string.Empty;
            view.AccessPassWord = string.Empty;
            view.PassWordCheck = string.Empty;
            view.InsertAllowed = false;
            view.UpdateAllowed = false;
            view.DeleteAllowed = false;

            SearchData(sender, e);
        }
    }
}
