using DimStock.Auxiliary;
using DimStock.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimStock.Business
{
    public class BllUser
    {
        #region Get e Set 
        public int Id { get; set; }
        public string YourName { get; set; }
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
                    Module = "Usuário",
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
                    Module = "Usuário",
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
                    Module = "Usuário",
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
        public void FetchData(string query, int numberOfRecords)
        {
            var user = new MdlUser();
            ListOfRecords = user.FetchData(query, numberOfRecords);
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
