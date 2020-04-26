using DimStock.Views;
using DimStock.Models;
using System;

namespace DimStock.Presenters
{
    public class UserLoginPresenter
    {
        private IUserLoginView view;

        public UserLoginPresenter(IUserLoginView view)
        {
            this.view = view;
        }

        public void Access(object sender, EventArgs e)
        {
            var user = new UserLoginModel()
            {
                Login = view.Login,
                AccessPassWord = view.AccessPassWord
            };        
            user.Access();
        }
    }
}
