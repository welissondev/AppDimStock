using DimStock.Models;
using DimStock.Views;

namespace DimStock.Presenters
{
    public class UserLoginAccessPresenter
    {
        private IUserLoginAccessView view;

        public UserLoginAccessPresenter(IUserLoginAccessView view)
        {
            this.view = view;
        }

        public bool ResquestAccess()
        {
            var actionResult = false;

            var user = new UserLoginModel()
            {
                Login = view.Login,
                AccessPassWord = view.AccessPassWord
            };

            if (user.RequestAccess() == true)
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
    }
}
