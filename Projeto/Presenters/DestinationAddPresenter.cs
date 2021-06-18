using DimStock.Views;
using DimStock.Models;

namespace DimStock.Presenters
{
    public class DestinationAddPresenter
    {
        private IDestinationAddView view;

        public DestinationAddPresenter(IDestinationAddView view)
        {
            this.view = view;
        }

        public bool Update()
        {
            var actionResult = false;

            var destination = new DestinationModel()
            {
                Id = view.Id,
                LocationDescription = view.LocationDescription
            };

            if (view.Id == 0)
            {
                if (destination.Insert() == true)
                {
                    actionResult = true;
                    Clear();
                }
            }

            if (view.Id > 0)
                destination.Update();

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;

            if (new DestinationModel() { Id = view.Id }.Delete() == true)
            {
                actionResult = true;
                Clear();
            }

            return actionResult;
        }

        public void Clear()
        {
            view.Id = 0;
            view.LocationDescription = string.Empty;
        }
    }
}
