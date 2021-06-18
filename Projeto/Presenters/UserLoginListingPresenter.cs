using DimStock.Models;
using DimStock.Views;

namespace DimStock.Presenters
{
    public class UserLoginListingPresenter
    {
        private IUserLoginListingView view;

        public UserLoginListingPresenter(IUserLoginListingView view)
        {
            this.view = view;
        }

        public bool GetDetails()
        {
            var actionResult = false;

            var user = new UserLoginModel() { Id = view.Id };

            if (user.GetDetails() == true)
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
                actionResult = true;
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            if (new UserLoginModel() { Id = view.Id }.Delete() == true)
            {
                actionResult = true;
                Clear();
            }

            return actionResult;
        }

        public void SearchData()
        {
            var user = new UserLoginModel()
            {
                YourName = view.SearchYourName,
                Login = view.SearchLogin,
                Email = view.SearchEmail
            };
            view.DataList = user.SearchData();
        }

        public void Clear()
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

            SearchData();
        }
    }
}
