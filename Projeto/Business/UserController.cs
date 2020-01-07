using System;
using System.Collections.Generic;
using DimStock.Auxiliary;
using DimStock.Model;

namespace DimStock.Business
{
    public class UserController
    {
        #region Constructs

        public UserController() { }

        public UserController(DataPagination dataPagination)
        {
            DataPagination = dataPagination;
        }

        #endregion 

        #region BussinesProperties 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string PassWord { get; set; }
        public bool PermissionToRegister { get; set; }
        public bool PermissionToEdit { get; set; }
        public bool PermissionToDelete { get; set; }
        public bool PermissionToView { get; set; }
        public bool AllPermissions { get; set; }
        public List<UserController> ListOfRecords { get; set; }
        #endregion

        #region SearchProperties

        public string SearchByName { get; set; }
        public string SearchByEmail { get; set; }
        public DataPagination DataPagination { get; set; }

        #endregion 

        #region Methods

        public bool Access()
        {
            var user = new UserModel(this);
            return user.Access();
        }

        public bool Register()
        {
            var user = new UserModel(this);

            if (user.Insert() == true)
            {
                var historic = new UserHistoryController()
                {
                    Login = LoginAssistant.Login,
                    OperationType = "Cadastrou",
                    OperationModule = "Usuário",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    AffectedFields = user.GetAffectedFields(Id)
                };

                return historic.Register();
            }
            else
            {
                return false;
            }
        }

        public bool Edit(int id)
        {
            var user = new UserModel(this);

            if (user.Update(id) == true)
            {
                var historic = new UserHistoryController()
                {
                    Login = LoginAssistant.Login,
                    OperationType = "Editou",
                    OperationModule = "Usuário",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    AffectedFields = user.GetAffectedFields(id)
                };

                return historic.Register();
            }
            else
            {
                return false;
            }
        }

        public bool Exclude(int id)
        {
            var user = new UserModel(this);

            var dataFromAffectedFields = user.GetAffectedFields(id);

            if (user.Delete(id) == true)
            {
                var historic = new UserHistoryController()
                {
                    Login = LoginAssistant.Login,
                    OperationType = "Deletou",
                    OperationModule = "Usuário",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    AffectedFields = dataFromAffectedFields
                };

                return historic.Register();
            }
            else
            {
                return false;
            }
        }

        public void ListData()
        {
            var user = new UserModel(this);
            user.ListData();
        }

        public void SearchData()
        {
            var user = new UserModel(this);
            user.DataQuery();
        }

        public void ViewDetails(int id)
        {
            var user = new UserModel(this);
            user.ViewDetails(id);
        }

        #endregion
    }
}
