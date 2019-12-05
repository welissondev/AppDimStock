using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.Model
{
    public class MdlUser
    {
        #region Variables
        private readonly BllUser user;
        #endregion

        #region Constructs
        public MdlUser()
        {

        }

        public MdlUser(BllUser user)
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
                var commandSQL = @"SELECT * FROM TBUsuario WHERE Login LIKE @Login AND Senha = @Senha";

                var e = connection.Command.Parameters;
                e.AddWithValue("@Login", user.Login);
                e.AddWithValue("@Senha", user.PassWord);

                using (var dr = connection.ExecuteParameterQuery(commandSQL))
                {
                    while (dr.Read())
                    {
                        user.Id = Convert.ToInt32(dr["Id"]);
                        user.YourName = dr["Nome"].ToString();
                        user.Login = dr["Login"].ToString();
                        user.PermissionToRegister = Convert.ToBoolean(dr["PermissaoCadastrar"]);
                        user.PermissionToEdit = Convert.ToBoolean(dr["PermissaoEditar"]);
                        user.PermissionToDelete = Convert.ToBoolean(dr["PermissaoDeletar"]);
                        user.PermissionToView = Convert.ToBoolean(dr["PermissaoVisualizar"]);

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
                    var commandSQL = @"INSERT INTO TBUsuario(Nome, Email, Login, Senha, PermissaoCadastrar, 
                    PermissaoEditar, PermissaoDeletar, PermissaoVisualizar, PermissaoTodas)VALUES(@Nome, @Email, @Login, @Senha, @PermissaoCadastrar, 
                    @PermissaoEditar, @PermissaoDeletar, @PermissaoVisualizar, @PermissaoTodas)";

                    connection.AddParameter("@nome", OleDbType.VarChar, user.YourName);
                    connection.AddParameter("@email", OleDbType.VarChar, user.Email);
                    connection.AddParameter("@login", OleDbType.VarChar, user.Login);
                    connection.AddParameter("@senha", OleDbType.VarChar, user.PassWord);
                    connection.AddParameter("@PermissaoCadastra", OleDbType.Boolean, user.PermissionToRegister);
                    connection.AddParameter("@PermissaoEditar", OleDbType.Boolean, user.PermissionToEdit);
                    connection.AddParameter("@PermissaoDeletar", OleDbType.Boolean, user.PermissionToDelete);
                    connection.AddParameter("@PermissaoVisualizar", OleDbType.Boolean, user.PermissionToView);
                    connection.AddParameter("@PermissaoTodas", OleDbType.Boolean, user.PermissionToDelete);

                    if (connection.ExecuteNonQuery(commandSQL) > 0)
                    {
                        user.Id = Convert.ToInt32(connection.ExecuteScalar("SELECT MAX(Id) FROM TBUsuario"));

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
                var commandSQL = @"UPDATE TBUsuario Set Nome = @Nome, Email = @Email, Login = @Login, Senha = @Senha, PermissaoCadastrar = @PermissaoCadastrar,
                PermissaoEditar = @PermissaoEditar, PermissaoDeletar = @PermissaoDeletar, PermissaoVisualizar = @PermissaoVisualizar, PermissaoTodas = @PermissaoTodas WHERE Id = " + id;

                connection.AddParameter("@nome", OleDbType.VarChar, user.YourName);
                connection.AddParameter("@email", OleDbType.VarChar, user.Email);
                connection.AddParameter("@login", OleDbType.VarChar, user.Login);
                connection.AddParameter("@senha", OleDbType.VarChar, user.PassWord);
                connection.AddParameter("@PermissaoCadastra", OleDbType.Boolean, user.PermissionToRegister);
                connection.AddParameter("@PermissaoEditar", OleDbType.Boolean, user.PermissionToEdit);
                connection.AddParameter("@PermissaoDeletar", OleDbType.Boolean, user.PermissionToDelete);
                connection.AddParameter("@PermissaoVisualizar", OleDbType.Boolean, user.PermissionToView);
                connection.AddParameter("@PermissaoTodas", OleDbType.Boolean, user.PermissionToDelete);

                if (connection.ExecuteNonQuery(commandSQL) > 0)
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
                if (CheckIfCurrentUser(id) == false)
                {
                    if (connection.ExecuteNonQuery(@"DELETE FROM TBUsuario WHERE Id = " + id) > 0)
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
                string commandSQL = @"SELECT Login FROM TBUsuario WHERE Login LIKE '" + user.Login + "'";
                int usersFound = 0;

                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        usersFound +=1;
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
        public List<BllUser> ListAll(int numberOfRecords = 100)
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = "SELECT TOP " + numberOfRecords + @" Id, Nome, Email FROM TBUsuario";

                var usersList = new List<BllUser>();

                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        var user = new BllUser()
                        {
                            Id = Convert.ToInt32(dr["id"]),
                            YourName = Convert.ToString(dr["Nome"]),
                            Email = Convert.ToString(dr["Email"])
                        };

                        usersList.Add(user);
                    }

                    return usersList;
                }
            }
        }
        #endregion

        #region FetchData()
        public DataTable FetchData()
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = "SELECT * FROM TBUsuario WHERE Nome LIKE @Nome Or Email LIKE @Email";

                var e = connection.Command.Parameters;
                e.AddWithValue("@Nome", string.Format("%{0}%", user.YourName));
                e.AddWithValue("@Email", string.Format("%{0}%", user.Email));

                return connection.QueryWithDataTable(commandSQL, user.DataPagination.OffSetValue, 
                user.DataPagination.PageSize);

            }
        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {
            using (var connection = new MdlConnection())
            {
                var commandSQL = @" SELECT * FROM TBUsuario WHERE Id = " + id;

                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        user.Id = Convert.ToInt32(dr["Id"]);
                        user.YourName = Convert.ToString(dr["Nome"]);
                        user.Email = Convert.ToString(dr["Email"]);
                        user.Login = Convert.ToString(dr["Login"]);
                        user.PassWord = Convert.ToString(dr["Senha"]);
                        user.PermissionToRegister = Convert.ToBoolean(dr["PermissaoCadastrar"]);
                        user.PermissionToEdit = Convert.ToBoolean(dr["PermissaoEditar"]);
                        user.PermissionToDelete = Convert.ToBoolean(dr["PermissaoDeletar"]);
                        user.AllPermissions = Convert.ToBoolean(dr["PermissaoTodas"]);
                        user.PermissionToView = Convert.ToBoolean(dr["PermissaoVisualizar"]);
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

                var commandSQL = @" SELECT * FROM TBUsuario WHERE Id = " + id;

                var usersList = new List<string>();

                using (var dr = connection.QueryWithDataReader(commandSQL))
                {
                    while (dr.Read())
                    {
                        usersList.Add("Id:" + dr["Id"].ToString());
                        usersList.Add("Nome:" + dr["Nome"].ToString());
                        usersList.Add("Email:" + dr["Email"].ToString());
                        usersList.Add("Login:" + dr["Login"].ToString());
                        usersList.Add("Senha:" + dr["Senha"].ToString());
                        usersList.Add("PermissãoCadastrar:" + dr["PermissaoCadastrar"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                        usersList.Add("PermissãoEditar:" + dr["PermissaoEditar"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                        usersList.Add("PermissãoDeletar:" + dr["PermissaoDeletar"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                        usersList.Add("PermissãoTodas:" + dr["PermissaoTodas"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                    }
                }

                return string.Join(" | ", usersList.Select(x => x.ToString()));
            }
        }
        #endregion

    }
}

