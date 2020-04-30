using DimStock.Views;
using DimStock.Models;
using System;
using DimStock.AuxilyTools.AuxilyClasses;

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
            try
            {
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
                    if (user.Insert() == true)
                        ClearView(sender, e);

                if (view.Id > 0)
                    user.Update();
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

        public void ClearView(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }
    }
}
