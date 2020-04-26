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
    }
}
