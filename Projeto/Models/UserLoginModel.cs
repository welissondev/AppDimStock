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
            var sql = string.Empty;

            using (var connection = new ConnectionModel())
            {
                sql = @"SELECT * FROM [UserLogin] WHERE Login 
                LIKE @Login AND [PassWord] = @PassWord";

                ParameterModel.Clear();
                ParameterModel.Add("@Login", Login);
                ParameterModel.Add("@PassWord", PassWord);

                using (var reader = connection.ExecuteReader(sql))
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
            var sql = string.Empty;

            if (ValidateEmail(Email) == false)
                return false;

            using (var dataBase = new ConnectionModel())
            {
                var createState = false;

                sql = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
                PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

                ParameterModel.Add("@Name", Name);
                ParameterModel.Add("@Email", Email);
                ParameterModel.Add("@Login", Login);
                ParameterModel.Add("@PassWord", PassWord);
                ParameterModel.Add("@PermissionToRegister", true);
                ParameterModel.Add("@PermissionToEdit", true);
                ParameterModel.Add("@PermissionToDelete", true);
                ParameterModel.Add("@PermissionToView", true);
                ParameterModel.Add("@AllPermissions", true);

                createState = dataBase.ExecuteNonQuery(sql) > 0;

                CreateDefaultLogin(dataBase);

                return createState;
            }
        }

        private void CreateDefaultLogin(ConnectionModel connection)
        {
            var sql = string.Empty;

            Login = "Admin";

            if (CheckIfLoginExists() == true)
                return;

            sql = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
            PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
            AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
            @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

            ParameterModel.Clear();
            ParameterModel.Add("@Name", "AdminUser");
            ParameterModel.Add("@Email", "Admin@admin.com");
            ParameterModel.Add("@Login", "Admin");
            ParameterModel.Add("@PassWord", "Admin");
            ParameterModel.Add("@PermissionToRegister", true);
            ParameterModel.Add("@PermissionToEdit", true);
            ParameterModel.Add("@PermissionToDelete", true);
            ParameterModel.Add("@PermissionToView", true);
            ParameterModel.Add("@AllPermissions", true);

            connection.ExecuteNonQuery(sql);
        }

        public bool Save()
        {
            if (CheckIfLoginExists() == true)
                return false;

            if (ValidateEmail(Email) == false)
                return false;

            var transactionState = false;
            var sql = string.Empty;

            using (var transaction = new TransactionModel())
            {
                sql = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
                PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

                ParameterModel.Clear();
                ParameterModel.Add("@Name", Name);
                ParameterModel.Add("@Email", Email);
                ParameterModel.Add("@Login", Login);
                ParameterModel.Add("@PassWord", PassWord);
                ParameterModel.Add("@PermissionToRegister", PermissionToRegister);
                ParameterModel.Add("@PermissionToEdit", PermissionToEdit);
                ParameterModel.Add("@PermissionToDelete", PermissionToDelete);
                ParameterModel.Add("@PermissionToView", PermissionToView);
                ParameterModel.Add("@AllPermissions", AllPermissions);

                transactionState = transaction.ExecuteNonQuery(sql) > 0;

                sql = "SELECT MAX(Id) FROM [User]";
                Id = Convert.ToInt32(transaction.ExecuteScalar(sql));

                transaction.Commit();

                MessageNotifier.Message = "Usuário cadastado com sucesso!";
            }

            return transactionState;
        }

        public bool Edit(int id)
        {
            var sql = string.Empty;

            if (ValidateEmail(Email) == false)
                return false;

            var transactionState = false;

            using (var transaction = new TransactionModel())
            {
                sql = @"UPDATE [UserLogin] Set [Name] = @Name, Email = @Email, 
                Login = @Login, [PassWord] = @PassWord, PermissionToRegister = @PermissionToRegister, 
                PermissionToEdit = @PermissionToEdit, PermissionToDelete = @PermissionToDelete, 
                PermissionToView = @PermissionToView, AllPermissions = @AllPermissions 
                WHERE Id = @Id";

                ParameterModel.Clear();
                ParameterModel.Add("@Name", Name);
                ParameterModel.Add("@Email", Email);
                ParameterModel.Add("@Login", Login);
                ParameterModel.Add("@PassWord", PassWord);
                ParameterModel.Add("@PermissionToRegister", PermissionToRegister);
                ParameterModel.Add("@PermissionToEdit", PermissionToEdit);
                ParameterModel.Add("@PermissionToDelete", PermissionToDelete);
                ParameterModel.Add("@PermissionToView", PermissionToView);
                ParameterModel.Add("@AllPermissions", AllPermissions);
                ParameterModel.Add("@Id", id);

                transactionState = transaction.ExecuteNonQuery(sql) > 0;
                transaction.Commit();

                MessageNotifier.Message = "Usuário alterado com sucesso!";
            }

            return transactionState;
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

            var transactionState = false;
            var sql = string.Empty;

            using (var transaction = new TransactionModel())
            {
                sql = @"DELETE FROM [UserLogin] WHERE Id = @Id";

                ParameterModel.Clear();
                ParameterModel.Add("@Id", id);

                transactionState = transaction.ExecuteNonQuery(sql) > 0;
                transaction.Commit();

                MessageNotifier.Message = "Usuário excluido com sucesso!";
            }

            return transactionState;
        }

        public void ListData()
        {
            var sql = string.Empty;

            using (var connection = new ConnectionModel())
            {
                sql = "SELECT * FROM [User]";

                using (var reader = connection.ExecuteReader(sql))
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
            var sql = string.Empty;

            using (var connection = new ConnectionModel())
            {
                sql = @"SELECT * FROM [UserLogin] WHERE Id = @Id";

                ParameterModel.Clear();
                ParameterModel.Add("@Id", id);

                using (var reader = connection.ExecuteReader(sql))
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
                var sql = @"SELECT * FROM [UserLogin] WHERE [Name]  
                LIKE @Name Or Email LIKE @Email";

                ParameterModel.Clear();
                ParameterModel.Add("@Name", string.Format("%{0}%", Name));
                ParameterModel.Add("@Email", string.Format("%{0}%", Email));

                var dataTable = connection.ExecuteDataAdapter(sql);

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
            var sql = string.Empty;

            using (var connection = new ConnectionModel())
            {
                var userFound = 0;

                sql = @"SELECT Login FROM [UserLogin] 
                WHERE Login LIKE @Login";

                ParameterModel.Add("@Login", Login);

                using (var reader = connection.ExecuteReader(sql))
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
            var sql = string.Empty;

            using (var connection = new ConnectionModel())
            {
                sql = "SELECT Id FROM [UserLogin] WHERE Id = @Id";
                var recordsFound = 0;

                ParameterModel.Clear();
                ParameterModel.Add("Id", id);

                using (var reader = connection.ExecuteReader(sql))
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
