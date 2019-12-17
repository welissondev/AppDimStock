using DimStock.Auxiliary;
using DimStock.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimStock.Business
{
    public class BllUser
    {
        #region Constructs

        public BllUser() { }

        public BllUser(AxlDataPagination dataPagination)
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
        public List<BllUser> ListOfRecords { get; set; }
        #endregion

        #region QueryProperties

        public string QueryByName { get; set; }
        public string QueryByEmail { get; set; }
        public AxlDataPagination DataPagination { get; set; }

        #endregion 

        #region Access()
        public bool Access()
        {
            var user = new MdlUser(this);
            return user.Access();
        }
        #endregion 

        #region Register()
        public bool Register()
        {
            var user = new MdlUser(this);

            if (user.Register() == true)
            {
                var historic = new BllUserHistoric()
                {
                    Login = AxlLogin.Login,
                    OperationType = "Cadastrou",
                    OperationModule = "Usuário",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = user.GetDataFromAffectedRecord(Id)
                };

                return historic.Register();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Edit()
        public bool Edit(int id)
        {
            var user = new MdlUser(this);

            if (user.Edit(id) == true)
            {
                var historic = new BllUserHistoric()
                {
                    Login = AxlLogin.Login,
                    OperationType = "Editou",
                    OperationModule = "Usuário",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = user.GetDataFromAffectedRecord(id)
                };

                return historic.Register();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            var user = new MdlUser(this);

            var dataFromAffectedRecord = user.GetDataFromAffectedRecord(id);

            if (user.Delete(id) == true)
            {
                var historic = new BllUserHistoric()
                {
                    Login = AxlLogin.Login,
                    OperationType = "Deletou",
                    OperationModule = "Usuário",
                    OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                    OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                    DataFromAffectedRecord = dataFromAffectedRecord
                };

                return historic.Register();
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region ListAll()
        public void ListAll(int numberOfRecords = 100)
        {
            var user = new MdlUser();
            ListOfRecords = user.ListAll(numberOfRecords);
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            var user = new MdlUser(this);
            user.FetchData();
        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {
            var user = new MdlUser(this);
            user.ViewData(id);
        }
        #endregion
    }
}
