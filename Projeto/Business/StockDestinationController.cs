using DimStock.Model;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class StockDestinationController
    {
        #region Get e Set
        public int Id { get; set; }
        public string Location { get; set; }
        public List<StockDestinationController> ListOfRecords { get; set; }
        #endregion

        #region Methods

        public bool Register()
        {
            var transaction = false;

            var stockDestination = new StockDestinationModel(this);

            if (stockDestination.CheckIfDestinationExists() == false)
            {
                if (stockDestination.Insert() == true)
                {
                    transaction = true;
                    NotificationController.Message = "Cadastrado com sucesso!";
                }
            }
            else
            {
                NotificationController.Message = "Esse destino já existe, cadastre outro!";
            }

            return transaction;
        }

        public bool Change(int id)
        {
            var stockDestination = new StockDestinationModel(this);

            var transaction = false;

            if (stockDestination.Update(id) == true)
            {
                NotificationController.Message = "Editado com sucesso!";
                transaction = true;
            }

            return transaction;
        }

        public bool Exclude(int id)
        {
            var stockDestination = new StockDestinationModel(this);

            bool transaction = false;

            if (stockDestination.Delete(id) == true)
            {
                NotificationController.Message = "Deletado com sucesso!";
                transaction = true;
            }
            else
            {
                NotificationController.Message = "Esse registro já foi deletado, atualize a lista de dados!";
            }

            return transaction;
        }

        public void ListData()
        {
            var stockDestination = new StockDestinationModel(this);
            stockDestination.SelectAll();
        }

        public void GetDetails(int id)
        {
            var stockDestination = new StockDestinationModel(this);
            stockDestination.GetFields(id);
        }

        #endregion
    }
}
