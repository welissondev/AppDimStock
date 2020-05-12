using DimStock.Views;

namespace DimStock.Presenters
{
    public class DestinationListingPresenter
    {
        private IDestinationListingView view;

        public DestinationListingPresenter(IDestinationListingView view)
        {
            this.view = view;
        }
    }
}
