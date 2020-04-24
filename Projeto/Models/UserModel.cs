using DimStock.AuxilyTools.AuxilyClasses;
using System;
using System.Collections.Generic;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de login do usuário
    /// </summary>
    public partial class UserModel
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
        public List<UserModel> List { get; set; }
    }

    public partial class UserModel
    {
        public UserModel()
        {

        }

        public UserModel(AuxiliaryDataPage pagination)
        {
            Pagination = pagination;
            List = new List<UserModel>();
        }

        public bool SignIn()
        {
            var accessState = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM [UserLogin] WHERE Login 
                LIKE @Login AND [PassWord] = @PassWord";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Login", Login);
                dataBase.AddParameter("@PassWord", PassWord);

                using (var reader = dataBase.ExecuteReader(sql))
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

                MessageNotifier.Show("Usuário não encontrado!",
                "Não Encontrado");
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

                dataBase.AddParameter("@Name", Name);
                dataBase.AddParameter("@Email", Email);
                dataBase.AddParameter("@Login", Login);
                dataBase.AddParameter("@PassWord", PassWord);
                dataBase.AddParameter("@PermissionToRegister", true);
                dataBase.AddParameter("@PermissionToEdit", true);
                dataBase.AddParameter("@PermissionToDelete", true);
                dataBase.AddParameter("@PermissionToView", true);
                dataBase.AddParameter("@AllPermissions", true);

                createState = dataBase.ExecuteNonQuery(sql) > 0;

                CreateDefaultLogin(dataBase);

                return createState;
            }
        }

        private void CreateDefaultLogin(ConnectionModel dataBase)
        {
            var sql = string.Empty;

            Login = "Admin";

            if (CheckIfLoginExists() == true)
                return;

            sql = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
            PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
            AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
            @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

            dataBase.ClearParameter();
            dataBase.AddParameter("@Name", "AdminUser");
            dataBase.AddParameter("@Email", "Admin@admin.com");
            dataBase.AddParameter("@Login", "Admin");
            dataBase.AddParameter("@PassWord", "Admin");
            dataBase.AddParameter("@PermissionToRegister", true);
            dataBase.AddParameter("@PermissionToEdit", true);
            dataBase.AddParameter("@PermissionToDelete", true);
            dataBase.AddParameter("@PermissionToView", true);
            dataBase.AddParameter("@AllPermissions", true);

            dataBase.ExecuteNonQuery(sql);
        }

        public bool Save()
        {
            if (CheckIfLoginExists() == true)
                return false;

            if (ValidateEmail(Email) == false)
                return false;

            var transactionState = false;
            var sql = string.Empty;

            using (var transaction = new ConnectionTransactionModel())
            {
                sql = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
                PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

                transaction.ClearParameter();
                transaction.AddParameter("@Name", Name);
                transaction.AddParameter("@Email", Email);
                transaction.AddParameter("@Login", Login);
                transaction.AddParameter("@PassWord", PassWord);
                transaction.AddParameter("@PermissionToRegister", PermissionToRegister);
                transaction.AddParameter("@PermissionToEdit", PermissionToEdit);
                transaction.AddParameter("@PermissionToDelete", PermissionToDelete);
                transaction.AddParameter("@PermissionToView", PermissionToView);
                transaction.AddParameter("@AllPermissions", AllPermissions);

                transactionState = transaction.ExecuteNonQuery(sql) > 0;

                sql = "SELECT MAX(Id) FROM [User]";
                Id = Convert.ToInt32(transaction.ExecuteScalar(sql));

                transaction.Commit();

                MessageNotifier.Show("Usuário cadastado " +
                "com sucesso!", "Sucesso");
            }

            return transactionState;
        }

        public bool Edit(int id)
        {
            var sql = string.Empty;

            if (ValidateEmail(Email) == false)
                return false;

            var transactionState = false;

            using (var transaction = new ConnectionTransactionModel())
            {
                sql = @"UPDATE [UserLogin] Set [Name] = @Name, Email = @Email, 
                Login = @Login, [PassWord] = @PassWord, PermissionToRegister = @PermissionToRegister, 
                PermissionToEdit = @PermissionToEdit, PermissionToDelete = @PermissionToDelete, 
                PermissionToView = @PermissionToView, AllPermissions = @AllPermissions 
                WHERE Id = @Id";

                transaction.ClearParameter();
                transaction.AddParameter("@Name", Name);
                transaction.AddParameter("@Email", Email);
                transaction.AddParameter("@Login", Login);
                transaction.AddParameter("@PassWord", PassWord);
                transaction.AddParameter("@PermissionToRegister", PermissionToRegister);
                transaction.AddParameter("@PermissionToEdit", PermissionToEdit);
                transaction.AddParameter("@PermissionToDelete", PermissionToDelete);
                transaction.AddParameter("@PermissionToView", PermissionToView);
                transaction.AddParameter("@AllPermissions", AllPermissions);
                transaction.AddParameter("@Id", id);

                transactionState = transaction.ExecuteNonQuery(sql) > 0;
                transaction.Commit();

                MessageNotifier.Show("Usuário alterado " +
                "com sucesso!", "Sucesso");
            }

            return transactionState;
        }

        public bool Remove(int id)
        {
            if (CheckIfResgisterExists(id) == false)
            {
                MessageNotifier.Show("Esse registro já foi excluido " +
                "atualize a lista de dados", "Sucesso");

                return false;
            }

            if (CheckCurrentRegister(id) == true)
            {
                MessageNotifier.Show("Você não pode deletar seu " +
                "próprio registro de usuário!","Não Permitido");

                return false;
            }

            var transactionState = false;
            var sql = string.Empty;

            using (var transaction = new ConnectionTransactionModel())
            {
                sql = @"DELETE FROM [UserLogin] WHERE Id = @Id";

                transaction.ClearParameter();
                transaction.AddParameter("@Id", id);

                transactionState = transaction.ExecuteNonQuery(sql) > 0;
                transaction.Commit();

                MessageNotifier.Show("Usuário excluido " +
                "com sucesso!", "Sucesso");
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
                        var User = new UserModel()
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

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM [UserLogin] WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", id);

                using (var reader = dataBase.ExecuteReader(sql))
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
            using (var dataBase = new ConnectionModel())
            {
                var sql = @"SELECT * FROM [UserLogin] WHERE [Name]  
                LIKE @Name Or Email LIKE @Email";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Name", string.Format("%{0}%", Name));
                dataBase.AddParameter("@Email", string.Format("%{0}%", Email));

                var dataTable = dataBase.ExecuteDataAdapter(sql);

                PassToList(dataTable);
            }
        }

        public bool ValidateEmail(string email)
        {
            var validation = EmailAddressValidator.Validate(email);

            if (validation == false)
                MessageNotifier.Show("O endereço de e-mail " +
                "informado não é válido!", "Inválido");

            return validation;
        }

        public bool CheckIfLoginExists()
        {
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                var userFound = 0;

                sql = @"SELECT Login FROM [UserLogin] 
                WHERE Login LIKE @Login";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Login", Login);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    while (reader.Read())
                    {
                        userFound += 1;
                    }
                }

                if (userFound > 0)
                {
                    MessageNotifier.Show("Já existe um usuário " +
                    "com o login |" + Login + "|. Por favor, informe " +
                    "outro nome de login!", "Já Existe");
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

            using (var dataBase = new ConnectionModel())
            {
                sql = "SELECT Id FROM [UserLogin] WHERE Id = @Id";
                var recordsFound = 0;

                dataBase.ClearParameter();
                dataBase.AddParameter("Id", id);

                using (var reader = dataBase.ExecuteReader(sql))
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
                var User = new UserModel()
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
