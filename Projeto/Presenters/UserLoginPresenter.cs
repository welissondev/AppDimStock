using DimStock.Views;

namespace DimStock.Presenters
{
    public class UserLoginPresenter
    {
        private IUserLoginView view;

        public UserLoginPresenter(IUserLoginView view)
        {
            this.view = view;
        }
    }
}
