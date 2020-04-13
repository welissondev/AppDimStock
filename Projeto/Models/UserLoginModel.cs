using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Collections.Generic;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de login do usuário
    /// </summary>
    public partial class UserLoginModel
    {
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
        public AuxiliaryDataPage Pagination { get; set; }
        public List<UserLoginModel> List { get; set; }
    }

    public partial class UserLoginModel
    {
        public UserLoginModel()
        {

        }

        public UserLoginModel(AuxiliaryDataPage pagination)
        {
            Pagination = pagination;
            List = new List<UserLoginModel>();
        }

        public bool SignIn()
        {
            var accessState = false;

            using (var connection = new ConnectionModel())
            {
                connection.SqlQuery = @"SELECT * FROM [UserLogin] WHERE Login 
                LIKE @Login AND [PassWord] = @PassWord";

                var paramerter = connection.Command.Parameters;
                paramerter.AddWithValue("@Login", Login);
                paramerter.AddWithValue("@PassWord", PassWord);

                using (var reader = connection.GetReader())
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
                MessageNotifier.Message = "Usuário não encontrado!";
            }

            return accessState;
        }

        public bool CreateNewLogin()
        {

            if (ValidateEmail(Email) == false)
                return false;

            using (var dataBase = new ConnectionModel())
            {
                var createState = false;

                dataBase.SqlQuery = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
                PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

                dataBase.AddParameter("@Name", Name);
                dataBase.AddParameter("@Email", Email);
                dataBase.AddParameter("@Login", Login);
                dataBase.AddParameter("@PassWord", PassWord);
                dataBase.AddParameter("@PermissionToRegister", true);
                dataBase.AddParameter("@PermissionToEdit", true);
                dataBase.AddParameter("@PermissionToDelete", true);
                dataBase.AddParameter("@PermissionToView", true);
                dataBase.AddParameter("@AllPermissions", true);

                createState = dataBase.ExecuteNonQuery() > 0;

                CreateDefaultLogin(dataBase);

                return createState;
            }
        }

        private void CreateDefaultLogin(ConnectionModel connection)
        {
            Login = "Admin";

            if (CheckIfLoginExists() == true)
                return;

            connection.ClearParameter();
            connection.SqlQuery = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
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

            connection.ExecuteNonQuery();
        }

        public bool Save()
        {
            if (CheckIfLoginExists() == true)
                return false;

            if (ValidateEmail(Email) == false)
                return false;

            using (var connection = new ConnectionModel())
            {
                var transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    connection.SqlQuery = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
                    PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                    AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                    @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

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

                    transactionState = connection.ExecuteTransaction() > 0;

                    connection.SqlQuery = "SELECT MAX(Id) FROM [User]";
                    Id = Convert.ToInt32(connection.ExecuteScalar());

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    MessageNotifier.Message = "Usuário cadastado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Edit(int id)
        {
            if (ValidateEmail(Email) == false)
                return false;

            using (var connection = new ConnectionModel())
            {
                var transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    connection.SqlQuery = @"UPDATE [UserLogin] Set [Name] = @Name, Email = @Email, 
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

                    transactionState = connection.ExecuteTransaction() > 0;

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    MessageNotifier.Message = "Usuário alterado com sucesso!";
                }

                return transactionState;
            }
        }

        public bool Remove(int id)
        {
            if (CheckIfResgisterExists(id) == false)
            {
                MessageNotifier.Message = "Esse registro já foi excluido " +
                "atualize a lista de dados";

                return false;
            }

            if (CheckCurrentRegister(id) == true)
            {
                MessageNotifier.Message = "Você não pode deletar seu " +
                "próprio registro de usuário!";

                return false;
            }

            using (var connection = new ConnectionModel())
            {
                var transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    connection.SqlQuery = @"DELETE FROM [UserLogin] WHERE Id = @Id";

                    connection.ClearParameter();
                    connection.AddParameter("@Id", id);

                    transactionState = connection.ExecuteTransaction() > 0;

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    MessageNotifier.Message = "Usuário excluido com sucesso!";
                }

                return transactionState;
            }
        }

        public void ListData()
        {
            using (var connection = new ConnectionModel())
            {
                connection.SqlQuery = "SELECT * FROM [User]";

                using (var reader = connection.GetReader())
                {
                    while (reader.Read())
                    {
                        var User = new UserLoginModel()
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
            using (var connection = new ConnectionModel())
            {
                connection.SqlQuery = @"SELECT * FROM [UserLogin] WHERE Id = @Id";

                connection.AddParameter("@Id", id);

                using (var reader = connection.GetReader())
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
            using (var connection = new ConnectionModel())
            {
                connection.SqlQuery = @"SELECT * FROM [UserLogin] WHERE [Name]  
                LIKE @Name Or Email LIKE @Email";

                var parameter = connection.Command.Parameters;
                parameter.AddWithValue("@Name", string.Format("%{0}%", Name));
                parameter.AddWithValue("@Email", string.Format("%{0}%", Email));

                var dataTable = connection.GetTable();

                PassToList(dataTable);
            }
        }

        public bool ValidateEmail(string email)
        {
            var validation = EmailAddressValidator.Validate(email);

            if (validation == false)
                MessageNotifier.Message = "O endereço de e-mail " +
                "informado não é válido!";

            return validation;
        }

        public bool CheckIfLoginExists()
        {
            using (var connection = new ConnectionModel())
            {
                var userFound = 0;

                connection.SqlQuery = @"SELECT Login FROM [UserLogin] 
                WHERE Login LIKE @Login";

                connection.AddParameter("@Login", Login);

                using (var reader = connection.GetReader())
                {
                    while (reader.Read())
                    {
                        userFound += 1;
                    }
                }

                if (userFound > 0)
                {
                    MessageNotifier.Message = "Já existe um usuário " +
                    "com o login |" + Login + "|. Por favor, informe " +
                    "outro nome de login!";
                }

                return userFound > 0;
            }
        }

        public bool CheckCurrentRegister(int id)
        {
            if (UserLoginState.Id == id)
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
            using (var connection = new ConnectionModel())
            {
                connection.SqlQuery = "SELECT Id FROM [UserLogin] WHERE Id = @Id";
                var recordsFound = 0;

                connection.ClearParameter();
                connection.AddParameter("Id", id);

                using (var reader = connection.GetReader())
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
                var User = new UserLoginModel()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["Login"]),
                    Email = Convert.ToString(row["Email"])
                };

                List.Add(User);
            }
        }
    }
}
