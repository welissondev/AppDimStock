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
    }
}
