using DimStock.Models;
using DimStock.Views;

namespace DimStock.Presenters
{
    public class UserLoginAddPresenter
    {
        private IUserLoginAddView view;

        public UserLoginAddPresenter(IUserLoginAddView view)
        {
            this.view = view;
        }

        public bool Update()
        {
            var actionResult = false;

            var user = new UserLoginModel
            {
                Id = view.Id,
                YourName = view.YourName,
                Email = view.Email,
                Login = view.Login,
                AccessPassWord = view.AccessPassWord,
                PassWordCheck = view.PassWordCheck,
                InsertAllowed = view.InsertAllowed,
                UpdateAllowed = view.UpdateAllowed,
                DeleteAllowed = view.DeleteAllowed
            };

            if (view.Id == 0)
            {
                if (user.Insert() == true)
                {
                    actionResult = true;
                    Clear();
                }
            }

            if (view.Id > 0)
                actionResult = user.Update();

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            if (new UserLoginModel() { Id = view.Id }.Delete() == true)
                actionResult = true;

            return actionResult;
        }

        public void Clear()
        {
            view.Id = 0;
            view.YourName = string.Empty;
            view.Email = string.Empty;
            view.Login = string.Empty;
            view.AccessPassWord = string.Empty;
            view.PassWordCheck = string.Empty;
            view.InsertAllowed = false;
            view.UpdateAllowed = false;
            view.DeleteAllowed = false;
        }
    }
}

