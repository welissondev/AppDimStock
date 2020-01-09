using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using DimStock.Auxiliary;

namespace DimStock.Business
{
    public class UserLogin
    {
        #region Constructs

        public UserLogin() { }

        public UserLogin(DataPagination dataPagination)
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
        public List<UserLogin> ListOfRecords { get; set; }
        #endregion

        #region SearchProperties

        public string SearchByName { get; set; }
        public string SearchByEmail { get; set; }
        public DataPagination DataPagination { get; set; }

        #endregion 

        #region Methods

        public bool Access()
        {
            var accessState = false;

            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT * FROM UserLogin WHERE Login 
                LIKE @Login AND [PassWord] = @PassWord";

                var paramerter = connection.Command.Parameters;
                paramerter.AddWithValue("@Login", Login);
                paramerter.AddWithValue("@PassWord", PassWord);

                using (var reader = connection.ExecuteParameterQuery(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id"]);
                        Name = reader["Name"].ToString();
                        Login = reader["Login"].ToString();
                        PermissionToRegister = Convert.ToBoolean(reader["PermissionToRegister"]);
                        PermissionToEdit = Convert.ToBoolean(reader["PermissionToEdit"]);
                        PermissionToDelete = Convert.ToBoolean(reader["PermissionToDelete"]);
                        PermissionToView = Convert.ToBoolean(reader["PermissionToView"]);

                        accessState = true;
                    }
                }
            }

            if (accessState == false)
            {
                Notification.Message = "Usuário não encontrado!";
            }

            return accessState;
        }

        public bool Register()
        {
            var registerState = false;

            if (CheckIfRegisterExists() == false)
            {
                using (var connection = new Connection())
                {
                    var sqlCommand = @"INSERT INTO UserLogin([Name], Email, Login, [PassWord], 
                    PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                    AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                    @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

                    connection.AddParameter("@Name", OleDbType.VarChar, Name);
                    connection.AddParameter("@Email", OleDbType.VarChar, Email);
                    connection.AddParameter("@Login", OleDbType.VarChar, Login);
                    connection.AddParameter("@PassWord", OleDbType.VarChar, PassWord);
                    connection.AddParameter("@PermissionToRegister", OleDbType.Boolean, PermissionToRegister);
                    connection.AddParameter("@PermissionToEdit", OleDbType.Boolean, PermissionToEdit);
                    connection.AddParameter("@PermissionToDelete", OleDbType.Boolean, PermissionToDelete);
                    connection.AddParameter("@PermissionToView", OleDbType.Boolean, PermissionToView);
                    connection.AddParameter("@AllPermissions", OleDbType.Boolean, AllPermissions);

                    if (connection.ExecuteNonQuery(sqlCommand) > 0)
                    {
                        connection.ParameterClear();
                        Id = Convert.ToInt32(connection.ExecuteScalar(
                        "SELECT MAX(Id) FROM UserLogin"));

                        if (Id > 0)
                        {
                            Notification.Message = "Dados registrados com sucesso!";
                            registerState = true;
                        }
                    }
                }

                return registerState;
            }
            else
            {
                return registerState;
            }
        }

        public bool Edit(int id)
        {
            var editState = false;

            using (var connection = new Connection())
            {
                var sqlCommand = @"UPDATE UserLogin Set [Name] = @Name, Email = @Email, 
                Login = @Login, [PassWord] = @PassWord, PermissionToRegister = @PermissionToRegister, 
                PermissionToEdit = @PermissionToEdit, PermissionToDelete = @PermissionToDelete, 
                PermissionToView = @PermissionToView, AllPermissions = @AllPermissions 
                WHERE Id = @Id";

                connection.AddParameter("@Name", OleDbType.VarChar, Name);
                connection.AddParameter("@Email", OleDbType.VarChar, Email);
                connection.AddParameter("@Login", OleDbType.VarChar, Login);
                connection.AddParameter("@PassWord", OleDbType.VarChar, PassWord);
                connection.AddParameter("@PermissionToRegister", OleDbType.Boolean, PermissionToRegister);
                connection.AddParameter("@PermissionToEdit", OleDbType.Boolean, PermissionToEdit);
                connection.AddParameter("@PermissionToDelete", OleDbType.Boolean, PermissionToDelete);
                connection.AddParameter("@PermissionToView", OleDbType.Boolean, PermissionToView);
                connection.AddParameter("@AllPermissions", OleDbType.Boolean, AllPermissions);
                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    Notification.Message = "Dados alterados com sucesso!";
                    editState = true;
                }
            }

            return editState;
        }

        public bool Delete(int id)
        {
            var deleteState = false;

            using (var connection = new Connection())
            {
                var sqlCommand = @"DELETE FROM UserLogin WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (CheckCurrentRegister(id) == false)
                {
                    Notification.Message = "Você não pode deletar seu " +
                    "próprio registro de usuário!";

                    return deleteState;
                }

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    deleteState = true;
                    Notification.Message = "Dados deletados com sucesso!";
                }
                else
                {
                    Notification.Message = "Esse registro já foi deletado," +
                    "atualize a lista de dados!";
                }
            }

            return deleteState;
        }

        public void ListData()
        {
            using (var connection = new Connection())
            {
                var sqlQuery = "SELECT * FROM UserLogin";

                var userList = new List<UserLogin>();

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var userLogin = new UserLogin()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = Convert.ToString(reader["Name"]),
                            Email = Convert.ToString(reader["Email"])
                        };

                        userList.Add(userLogin);
                    }

                    ListOfRecords = userList;
                }
            }
        }

        public void SearchData()
        {
            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT * FROM UserLogin WHERE [Name]  
                LIKE @Name Or Email LIKE @Email";

                var parameter = connection.Command.Parameters;
                parameter.AddWithValue("@Name", string.Format("%{0}%", SearchByName));
                parameter.AddWithValue("@Email", string.Format("%{0}%", SearchByEmail));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                DataPagination.OffSetValue, DataPagination.PageSize);

                PassDataTableToList(dataTable);
            }
        }

        public void ViewDetails(int id)
        {
            using (var connection = new Connection())
            {
                var sqlQuery = @"SELECT * FROM UserLogin WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        Id = Convert.ToInt32(reader["Id"]);
                        Name = Convert.ToString(reader["Name"]);
                        Email = Convert.ToString(reader["Email"]);
                        Login = Convert.ToString(reader["Login"]);
                        PassWord = Convert.ToString(reader["PassWord"]);
                        PermissionToRegister = Convert.ToBoolean(reader["PermissionToRegister"]);
                        PermissionToEdit = Convert.ToBoolean(reader["PermissionToEdit"]);
                        PermissionToDelete = Convert.ToBoolean(reader["PermissionToDelete"]);
                        PermissionToView = Convert.ToBoolean(reader["PermissionToView"]);
                        AllPermissions = Convert.ToBoolean(reader["AllPermissions"]);
                    }
                }
            }
        }

        public bool CheckIfRegisterExists()
        {
            using (var connection = new Connection())
            {
                var userFound = 0;

                var sqlQuery = @"SELECT Login FROM UserLogin 
                WHERE Login LIKE @Login";

                connection.AddParameter("@Login",
                OleDbType.VarChar, Login);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        userFound += 1;
                    }
                }

                if (userFound > 0)
                {
                    Notification.Message = "Já existe um usuário com o login [" + Login + "]. " +
                    "Por favor, informe outro nome de login!";
                }

                return userFound > 0;
            }
        }

        public bool CheckCurrentRegister(int id)
        {
            if (LoginAssistant.Id == id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PassDataTableToList(DataTable dataTable)
        {
            var userList = new List<UserLogin>();

            foreach (DataRow row in dataTable.Rows)
            {
                var userLogin = new UserLogin()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["Login"]),
                    Email = Convert.ToString(row["Email"])
                };

                userList.Add(userLogin);
            }

            ListOfRecords = userList;
        }

        #endregion
    }
}
