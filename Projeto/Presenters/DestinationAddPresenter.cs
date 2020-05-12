using DimStock.Views;

namespace DimStock.Presenters
{
    public class DestinationAddPresenter
    {
        private IDestinationAddView view;

        public DestinationAddPresenter(IDestinationAddView view)
        {
            this.view = view;
        }
    }
}
