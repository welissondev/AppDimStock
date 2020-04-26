using DimStock.Views;
using DimStock.Models;
using System;

namespace DimStock.Presenters
{
    public class UserLoginAddPresenter
    {
        private IUserLoginAddView view;

        public UserLoginAddPresenter(IUserLoginAddView view)
        {
            this.view = view;
        }

        public void InsertUpdate(object sender, EventArgs e)
        {
            var user = new UserLoginModel
            {
                Id = view.Id,
                Name = view.Name,
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
                    ClearView(sender, e);
            }

            if (view.Id > 0)
            {
               user.Update();
            }
        }

        public void Delete(object sender, EventArgs e)
        {
            var user = new UserLoginModel() { Id = view.Id };

            if (user.Delete() == true)
                ClearView(sender, e);
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
        }
    }
}
