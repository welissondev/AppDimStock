using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.Model
{
    public class MdlUserLogin
    {
        #region Variables
        private readonly BllUserLogin user;
        #endregion

        #region Constructs
        public MdlUserLogin()
        {

        }

        public MdlUserLogin(BllUserLogin user)
        {
            this.user = user;
        }
        #endregion

        #region Access()
        public bool Access()
        {
            var accessState = false;

            using (var connection = new MdlConnection())
            {
                var sqlQuery = @"SELECT * FROM UserLogin WHERE Login 
                LIKE @Login AND [PassWord] = @PassWord";

                var paramerter = connection.Command.Parameters;
                paramerter.AddWithValue("@Login", user.Login);
                paramerter.AddWithValue("@PassWord", user.PassWord);

                using (var reader = connection.ExecuteParameterQuery(sqlQuery))
                {
                    while (reader.Read())
                    {
                        user.Id = Convert.ToInt32(reader["Id"]);
                        user.Name = reader["Name"].ToString();
                        user.Login = reader["Login"].ToString();
                        user.PermissionToRegister = Convert.ToBoolean(reader["PermissionToRegister"]);
                        user.PermissionToEdit = Convert.ToBoolean(reader["PermissionToEdit"]);
                        user.PermissionToDelete = Convert.ToBoolean(reader["PermissionToDelete"]);
                        user.PermissionToView = Convert.ToBoolean(reader["PermissionToView"]);

                        accessState = true;
                    }
                }
            }

            if (accessState == false)
            {
                BllNotification.Message = "Usuário não encontrado!";
            }

            return accessState;
        }
        #endregion 

        #region Register()
        public bool Register()
        {
            var registerState = false;

            if (CheckIfLoginExits() == false)
            {
                using (var connection = new MdlConnection())
                {
                    var sqlCommand = @"INSERT INTO UserLogin([Name], Email, Login, [PassWord], 
                    PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                    AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                    @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

                    connection.AddParameter("@Name", OleDbType.VarChar, user.Name);
                    connection.AddParameter("@Email", OleDbType.VarChar, user.Email);
                    connection.AddParameter("@Login", OleDbType.VarChar, user.Login);
                    connection.AddParameter("@PassWord", OleDbType.VarChar, user.PassWord);
                    connection.AddParameter("@PermissionToRegister", OleDbType.Boolean, user.PermissionToRegister);
                    connection.AddParameter("@PermissionToEdit", OleDbType.Boolean, user.PermissionToEdit);
                    connection.AddParameter("@PermissionToDelete", OleDbType.Boolean, user.PermissionToDelete);
                    connection.AddParameter("@PermissionToView", OleDbType.Boolean, user.PermissionToView);
                    connection.AddParameter("@AllPermissions", OleDbType.Boolean, user.AllPermissions);

                    if (connection.ExecuteNonQuery(sqlCommand) > 0)
                    {
                        user.Id = Convert.ToInt32(
                        connection.ExecuteScalar("SELECT MAX(Id) FROM UserLogin"));

                        if (user.Id > 0)
                        {
                            BllNotification.Message = "Dados registrados com sucesso!";
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
        #endregion

        #region Edit()
        public bool Edit(int id)
        {
            var editState = false;

            using (var connection = new MdlConnection())
            {
                var sqlCommand = @"UPDATE UserLogin Set [Name] = @Name, Email = @Email, 
                Login = @Login, [PassWord] = @PassWord, PermissionToRegister = @PermissionToRegister, 
                PermissionToEdit = @PermissionToEdit, PermissionToDelete = @PermissionToDelete, 
                PermissionToView = @PermissionToView, AllPermissions = @AllPermissions 
                WHERE Id = @Id";

                connection.AddParameter("@Name", OleDbType.VarChar, user.Name);
                connection.AddParameter("@Email", OleDbType.VarChar, user.Email);
                connection.AddParameter("@Login", OleDbType.VarChar, user.Login);
                connection.AddParameter("@PassWord", OleDbType.VarChar, user.PassWord);
                connection.AddParameter("@PermissionToRegister", OleDbType.Boolean, user.PermissionToRegister);
                connection.AddParameter("@PermissionToEdit", OleDbType.Boolean, user.PermissionToEdit);
                connection.AddParameter("@PermissionToDelete", OleDbType.Boolean, user.PermissionToDelete);
                connection.AddParameter("@PermissionToView", OleDbType.Boolean, user.PermissionToView);
                connection.AddParameter("@AllPermissions", OleDbType.Boolean, user.AllPermissions);
                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (connection.ExecuteNonQuery(sqlCommand) > 0)
                {
                    BllNotification.Message = "Dados alterados com sucesso!";
                    editState = true;
                }
            }

            return editState;
        }
        #endregion

        #region Delete()
        public bool Delete(int id)
        {
            var deleteState = false;

            using (var connection = new MdlConnection())
            {

                var sqlCommand = @"DELETE FROM UserLogin WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                if (CheckIfCurrentUser(id) == false)
                {
                    if (connection.ExecuteNonQuery(sqlCommand) > 0)
                    {
                        deleteState = true;
                        BllNotification.Message = "Dados deletados com sucesso!";
                    }
                    else
                    {
                        BllNotification.Message = "Esse registro já foi deletado," +
                        "atualize a lista de dados!";
                    }
                }
                else
                {
                    BllNotification.Message = "Você não pode deletar seu " +
                    "próprio registro de usuário!";
                }
            }

            return deleteState;
        }
        #endregion

        #region CheckIfCurrentUser()
        public bool CheckIfCurrentUser(int userId)
        {
            if (AxlLogin.UserId == userId)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

        #region CheckIfLoginExits()
        public bool CheckIfLoginExits()
        {
            using (var connection = new MdlConnection())
            {
                var usersFound = 0;

                var sqlQuery = @"SELECT Login FROM UserLogin 
                WHERE Login LIKE @Login";

                connection.AddParameter("@Login", 
                OleDbType.VarChar, user.Login);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        usersFound += 1;
                    }
                }

                if (usersFound > 0)
                {
                    BllNotification.Message = "Já existe um usuário com o login [" + user.Login + "]. " +
                    "Por favor, informe outro nome de login!";
                }

                return usersFound > 0;
            }
        }
        #endregion 

        #region ListAll()
        public List<BllUserLogin> ListAll(int numberOfRecords = 100)
        {
            using (var connection = new MdlConnection())
            {
                var sqlQuery = "SELECT TOP " + numberOfRecords + @" Id, [Name], Email FROM UserLogin";

                var usersList = new List<BllUserLogin>();

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var user = new BllUserLogin()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = Convert.ToString(reader["Name"]),
                            Email = Convert.ToString(reader["Email"])
                        };

                        usersList.Add(user);
                    }

                    return usersList;
                }
            }
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            using (var connection = new MdlConnection())
            {
                var sqlQuery = @"SELECT * FROM UserLogin WHERE [Name]  
                LIKE @Name Or Email LIKE @Email";

                var parameter = connection.Command.Parameters;
                parameter.AddWithValue("@Name", string.Format("%{0}%", user.QueryByName));
                parameter.AddWithValue("@Email", string.Format("%{0}%", user.QueryByEmail));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                user.DataPagination.OffSetValue,
                user.DataPagination.PageSize);

                PassDataTableToList(dataTable);
            }
        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {
            using (var connection = new MdlConnection())
            {
                var sqlQuery = @"SELECT * FROM UserLogin WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        user.Id = Convert.ToInt32(reader["Id"]);
                        user.Name = Convert.ToString(reader["Name"]);
                        user.Email = Convert.ToString(reader["Email"]);
                        user.Login = Convert.ToString(reader["Login"]);
                        user.PassWord = Convert.ToString(reader["PassWord"]);
                        user.PermissionToRegister = Convert.ToBoolean(reader["PermissionToRegister"]);
                        user.PermissionToEdit = Convert.ToBoolean(reader["PermissionToEdit"]);
                        user.PermissionToDelete = Convert.ToBoolean(reader["PermissionToDelete"]);
                        user.PermissionToView = Convert.ToBoolean(reader["PermissionToView"]);
                        user.AllPermissions = Convert.ToBoolean(reader["AllPermissions"]);
                    }
                }
            }
        }
        #endregion

        #region GetDataFromAffectedRecord()
        public string GetDataFromAffectedRecord(int id)
        {
            using (var connection = new MdlConnection())
            {
                var usersList = new List<string>();

                var sqlQuery = @" SELECT * FROM UserLogin WHERE Id = @Id";

                connection.AddParameter("@Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        usersList.Add("Id:" + reader["Id"].ToString());
                        usersList.Add("Nome:" + reader["Name"].ToString());
                        usersList.Add("Email:" + reader["Email"].ToString());
                        usersList.Add("Login:" + reader["Login"].ToString());
                        usersList.Add("Senha:" + reader["PassWord"].ToString());
                        usersList.Add("PermissãoCadastrar:" + reader["PermissionToRegister"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                        usersList.Add("PermissãoEditar:" + reader["PermissionToEdit"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                        usersList.Add("PermissãoDeletar:" + reader["PermissionToDelete"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                        usersList.Add("PermissãoTodas:" + reader["AllPermissions"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                    }
                }

                return string.Join(" | ", usersList.Select(x => x.ToString()));
            }
        }
        #endregion

        #region PassDataTableToList()

        private void PassDataTableToList(DataTable dataTable)
        {
            var userList = new List<BllUserLogin>();

            foreach (DataRow row in dataTable.Rows)
            {
                var user = new BllUserLogin()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["Login"]),
                    Email = Convert.ToString(row["Email"])
                };

                userList.Add(user);
            }

            user.ListOfRecords = userList;
        }

        #endregion 

    }
}

