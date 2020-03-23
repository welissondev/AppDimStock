using DimStock.Auxiliarys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace DimStock.Models
{
    public class UserLogin
    {
        #region Builder

        public UserLogin() 
        { 
            
        }

        public UserLogin(AxlDataPage pagination)
        {
            Pagination = pagination;
            List = new List<UserLogin>();
        }

        #endregion

        #region Get & Set 

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
        public AxlDataPage Pagination { get; set; }
        public List<UserLogin> List { get; set; }
        #endregion

        #region Function

        public bool SignIn()
        {
            var accessState = false;

            using (var connection = new AccessConnection())
            {
                var sqlQuery = @"SELECT * FROM [UserLogin] WHERE Login 
                LIKE @Login AND [PassWord] = @PassWord";

                var paramerter = connection.Command.Parameters;
                paramerter.AddWithValue("@Login", Login);
                paramerter.AddWithValue("@PassWord", PassWord);

                using (var reader = connection.GetReader(sqlQuery))
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
                AxlMessageNotifier.Message = "Usuário não encontrado!";
            }

            return accessState;
        }

        public bool CreateNewLogin()
        {

            if (ValidateEmail(Email) == false)
                return false;

            using (var connection = new AccessConnection())
            {
                var createState = false;

                var sqlCommand = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
                PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

                connection.AddParameter("@Name", Name);
                connection.AddParameter("@Email", Email);
                connection.AddParameter("@Login", Login);
                connection.AddParameter("@PassWord", PassWord);
                connection.AddParameter("@PermissionToRegister", true);
                connection.AddParameter("@PermissionToEdit", true);
                connection.AddParameter("@PermissionToDelete", true);
                connection.AddParameter("@PermissionToView", true);
                connection.AddParameter("@AllPermissions", true);

                createState = connection.ExecuteCommand(sqlCommand) > 0;

                CreateDefaultLogin(connection);

                return createState;
            }
        }

        private void CreateDefaultLogin(AccessConnection connection)
        {
            Login = "Admin";

            if (CheckIfLoginExists() == true)
                return;

            connection.ClearParameter();
            var sqlCommand = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
            PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
            AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
            @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

            connection.AddParameter("@Name", "AdminUser");
            connection.AddParameter("@Email", "Admin@admin.com");
            connection.AddParameter("@Login", "Admin");
            connection.AddParameter("@PassWord", "Admin");
            connection.AddParameter("@PermissionToRegister", true);
            connection.AddParameter("@PermissionToEdit", true);
            connection.AddParameter("@PermissionToDelete", true);
            connection.AddParameter("@PermissionToView", true);
            connection.AddParameter("@AllPermissions", true);

            connection.ExecuteCommand(sqlCommand);
        }

        public bool Save()
        {
            if (CheckIfLoginExists() == true)
                return false;

            if (ValidateEmail(Email) == false)
                return false;

            using (var connection = new AccessConnection())
            {
                var transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
                    PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                    AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                    @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

                    connection.AddParameter("@Name", Name);
                    connection.AddParameter("@Email", Email);
                    connection.AddParameter("@Login", Login);
                    connection.AddParameter("@PassWord", PassWord);
                    connection.AddParameter("@PermissionToRegister", PermissionToRegister);
                    connection.AddParameter("@PermissionToEdit", PermissionToEdit);
                    connection.AddParameter("@PermissionToDelete", PermissionToDelete);
                    connection.AddParameter("@PermissionToView", PermissionToView);
                    connection.AddParameter("@AllPermissions", AllPermissions);

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Seleciona ultimo ID inserido
                    Id = Convert.ToInt32(connection.ExecuteScalar(
                    "SELECT MAX(Id) FROM [User]"));  

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Usuário cadastado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Edit(int id)
        {
            if (ValidateEmail(Email) == false)
                return false;

            using (var connection = new AccessConnection())
            {
                var transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"UPDATE [UserLogin] Set [Name] = @Name, Email = @Email, 
                    Login = @Login, [PassWord] = @PassWord, PermissionToRegister = @PermissionToRegister, 
                    PermissionToEdit = @PermissionToEdit, PermissionToDelete = @PermissionToDelete, 
                    PermissionToView = @PermissionToView, AllPermissions = @AllPermissions 
                    WHERE Id = @Id";

                    connection.ClearParameter();
                    connection.AddParameter("@Name", Name);
                    connection.AddParameter("@Email", Email);
                    connection.AddParameter("@Login", Login);
                    connection.AddParameter("@PassWord", PassWord);
                    connection.AddParameter("@PermissionToRegister", PermissionToRegister);
                    connection.AddParameter("@PermissionToEdit", PermissionToEdit);
                    connection.AddParameter("@PermissionToDelete", PermissionToDelete);
                    connection.AddParameter("@PermissionToView", PermissionToView);
                    connection.AddParameter("@AllPermissions", AllPermissions);
                    connection.AddParameter("@Id", id);

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Usuário alterado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Remove(int id)
        {
            if (CheckIfResgisterExists(id) == false)
            {
                AxlMessageNotifier.Message = "Esse registro já foi excluido " +
                "atualize a lista de dados";

                return false;
            }

            if (CheckCurrentRegister(id) == true)
            {
                AxlMessageNotifier.Message = "Você não pode deletar seu " +
                "próprio registro de usuário!";

                return false;
            }

            using (var connection = new AccessConnection())
            {
                var transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"DELETE FROM [UserLogin] WHERE Id = @Id";

                    connection.ClearParameter();
                    connection.AddParameter("@Id", id);

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Usuário excluido com sucesso!";
                }

                return transactionState;
            }
        }

        public void ListData()
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = "SELECT * FROM [User]";

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var User = new UserLogin()
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = Convert.ToString(reader["Name"]),
                            Email = Convert.ToString(reader["Email"])
                        };

                        List.Add(User);
                    }
                }
            }
        }

        public void GetDetail(int id)
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = @"SELECT * FROM [UserLogin] WHERE Id = @Id";

                connection.AddParameter("@Id", id);

                using (var reader = connection.GetReader(sqlQuery))
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

        public void FetchData()
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = @"SELECT * FROM [UserLogin] WHERE [Name]  
                LIKE @Name Or Email LIKE @Email";

                var parameter = connection.Command.Parameters;
                parameter.AddWithValue("@Name", string.Format("%{0}%", Name));
                parameter.AddWithValue("@Email", string.Format("%{0}%", Email));

                var dataTable = connection.GetTable(sqlQuery,
                Pagination.OffSetValue, Pagination.PageSize);

                PassToList(dataTable);
            }
        }

        public bool ValidateEmail(string email)
        {
            var validation = AxlEmailAddress.Validate(email);

            if (validation == false)
                AxlMessageNotifier.Message = "O endereço de e-mail " +
                "informado não é válido!";

            return validation;
        }

        public bool CheckIfLoginExists()
        {
            using (var connection = new AccessConnection())
            {
                var userFound = 0;

                var sqlQuery = @"SELECT Login FROM [UserLogin] 
                WHERE Login LIKE @Login";

                connection.AddParameter("@Login", Login);

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        userFound += 1;
                    }
                }

                if (userFound > 0)
                {
                    AxlMessageNotifier.Message = "Já existe um usuário " +
                    "com o login |" + Login + "|. Por favor, informe " +
                    "outro nome de login!";
                }

                return userFound > 0;
            }
        }

        public bool CheckCurrentRegister(int id)
        {
            if (AxlLogin.Id == id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckIfResgisterExists(int id)
        {
            using (var connection = new AccessConnection())
            {
                var sqlQuery = "SELECT Id FROM [UserLogin] WHERE Id = @Id";
                var recordsFound = 0;

                connection.ClearParameter();
                connection.AddParameter("Id", id);

                using (var reader = connection.GetReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        recordsFound += 1;
                    }
                }

                return recordsFound > 0;
            }
        }

        public void PassToList(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                var User = new UserLogin()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["Login"]),
                    Email = Convert.ToString(row["Email"])
                };

                List.Add(User);
            }
        }

        #endregion
    }
}
