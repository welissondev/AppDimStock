using DimStock.Model;
using System.Collections.Generic;

namespace DimStock.Business
{
    public class BllStockDestination
    {
        #region Get e Set
        public int Id { get; set; }
        public string Location { get; set; }
        public List<BllStockDestination> ListOfRecords { get; set; }
        #endregion

        #region Register()
        public bool Register()
        {
            var transaction = false;

            var stockDestination = new MdlStockDestination(this);

            if (stockDestination.CheckIfDestinationExists() == false)
            {
                if (stockDestination.Register() == true)
                {
                    transaction = true;
                    BllNotification.Message = "Cadastrado com sucesso!";
                }
            }
            else
            {
                BllNotification.Message = "Esse destino já existe, cadastre outro!";
            }

            return transaction;
        }
        #endregion

        #region Edit()
        public bool Edit(int id)
        {
            var stockDestination = new MdlStockDestination(this);

            var transaction = false;

            if (stockDestination.Edit(id) == true)
            {
                BllNotification.Message = "Editado com sucesso!";
                transaction = true;
            }

            return transaction;
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            var stockDestination = new MdlStockDestination(this);

            bool transaction = false;

            if (stockDestination.Delete(id) == true)
            {
                BllNotification.Message = "Deletado com sucesso!";
                transaction = true;
            }
            else
            {
                BllNotification.Message = "Esse registro já foi deletado, atualize a lista de dados!";
            }

            return transaction;
        }
        #endregion

        #region ListAll()
        public void ListAll()
        {
            var stockDestination = new MdlStockDestination();
            ListOfRecords = stockDestination.ListAll();
        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {
            var stockDestination = new MdlStockDestination(this);
            stockDestination.ViewData(id);
        }
        #endregion
    }
}
