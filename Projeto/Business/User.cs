using DimStock.Auxiliarys;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;

namespace DimStock.Business
{
    public class User
    {
        #region Builder

        public User() { }

        public User(AxlDataPage pagination)
        {
            Pagination = pagination;
        }

        #endregion

        #region Properties

        public List<User> List = new List<User>();
        public AxlDataPage Pagination = new AxlDataPage();

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

        #endregion

        #region Function

        public bool SignIn()
        {
            var accessState = false;

            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = @"SELECT * FROM [User] WHERE Login 
                LIKE @Login AND [PassWord] = @PassWord";

                var paramerter = connection.Command.Parameters;
                paramerter.AddWithValue("@Login", Login);
                paramerter.AddWithValue("@PassWord", PassWord);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
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

            using (var connection = new DatabaseConnection())
            {
                var createState = false;

                var sqlCommand = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
                PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
                AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
                @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

                connection.AddParameter("@Name", OleDbType.VarChar, Name);
                connection.AddParameter("@Email", OleDbType.VarChar, Email);
                connection.AddParameter("@Login", OleDbType.VarChar, Login);
                connection.AddParameter("@PassWord", OleDbType.VarChar, PassWord);
                connection.AddParameter("@PermissionToRegister", OleDbType.Boolean, true);
                connection.AddParameter("@PermissionToEdit", OleDbType.Boolean, true);
                connection.AddParameter("@PermissionToDelete", OleDbType.Boolean, true);
                connection.AddParameter("@PermissionToView", OleDbType.Boolean, true);
                connection.AddParameter("@AllPermissions", OleDbType.Boolean, true);

                createState = connection.ExecuteNonQuery(sqlCommand) > 0;

                CreateDefaultLogin(connection);

                return createState;
            }
        }

        private void CreateDefaultLogin(DatabaseConnection connection)
        {
            Login = "Admin";

            if (CheckIfLoginExists() == true)
                return;

            connection.ParameterClear();
            var sqlCommand = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
            PermissionToRegister, PermissionToEdit, PermissionToDelete, PermissionToView, 
            AllPermissions)VALUES(@Name, @Email, @Login, @PassWord, @PermissionToRegister, 
            @PermissionToEdit, @PermissionToDelete, @PermissionToView, @AllPermissions)";

            connection.AddParameter("@Name", OleDbType.VarChar, "AdminUser");
            connection.AddParameter("@Email", OleDbType.VarChar, "Admin@admin.com");
            connection.AddParameter("@Login", OleDbType.VarChar, "Admin");
            connection.AddParameter("@PassWord", OleDbType.VarChar, "Admin");
            connection.AddParameter("@PermissionToRegister", OleDbType.Boolean, true);
            connection.AddParameter("@PermissionToEdit", OleDbType.Boolean, true);
            connection.AddParameter("@PermissionToDelete", OleDbType.Boolean, true);
            connection.AddParameter("@PermissionToView", OleDbType.Boolean, true);
            connection.AddParameter("@AllPermissions", OleDbType.Boolean, true);

            connection.ExecuteNonQuery(sqlCommand);
        }

        public bool Save()
        {
            if (CheckIfLoginExists() == true)
                return false;

            if (ValidateEmail(Email) == false)
                return false;

            using (var connection = new DatabaseConnection())
            {
                var transactionState = false;

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"INSERT INTO [User]([Name], Email, Login, [PassWord], 
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

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Seleciona ultimo ID inserido
                    Id = Convert.ToInt32(connection.ExecuteScalar(
                    "SELECT MAX(Id) FROM [User]"));

                    //Registra histórico do usuário
                    var history = new UserHistory(connection)
                    {
                        OperationType = "Cadastrou",
                        OperationModule = "Usuário",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = GetAffectedFields(Id, connection)
                    };

                    history.User.Id = AxlLogin.Id;

                    transactionState = history.Save();

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

            using (var connection = new DatabaseConnection())
            {
                var transactionState = false;

                var affectedFields = GetAffectedFields(id, connection);

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"UPDATE [User] Set [Name] = @Name, Email = @Email, 
                    Login = @Login, [PassWord] = @PassWord, PermissionToRegister = @PermissionToRegister, 
                    PermissionToEdit = @PermissionToEdit, PermissionToDelete = @PermissionToDelete, 
                    PermissionToView = @PermissionToView, AllPermissions = @AllPermissions 
                    WHERE Id = @Id";

                    connection.ParameterClear();
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

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Registra histórico do usuário
                    var history = new UserHistory(connection)
                    {
                        OperationType = "Editou",
                        OperationModule = "Usuário",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };

                    history.User.Id = AxlLogin.Id;

                    transactionState = history.Save();

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

            using (var connection = new DatabaseConnection())
            {
                var transactionState = false;

                var affectedFields = GetAffectedFields(id, connection);

                using (connection.Transaction = connection.Open().BeginTransaction())
                {
                    var sqlCommand = @"DELETE FROM [User] WHERE Id = @Id";

                    connection.ParameterClear();
                    connection.AddParameter("@Id", OleDbType.Integer, id);

                    transactionState = connection.ExecuteTransaction(sqlCommand) > 0;

                    //Registra histórico do usuário
                    var history = new UserHistory(connection)
                    {
                        OperationType = "Deletou",
                        OperationModule = "Usuário",
                        OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy")),
                        OperationHour = DateTime.Now.ToString("HH:mm:ss"),
                        AffectedFields = affectedFields
                    };

                    history.User.Id = AxlLogin.Id;

                    transactionState = history.Save();

                    //Finaliza a transação
                    connection.Transaction.Commit();

                    AxlMessageNotifier.Message = "Usuário excluido com sucesso!";
                }

                return transactionState;
            }
        }

        public void ListData()
        {
            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = "SELECT * FROM [User]";

                using (var reader = connection.QueryWithDataReader(sqlQuery))
                {
                    while (reader.Read())
                    {
                        var User = new User()
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

        public void FetchData()
        {
            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = @"SELECT * FROM [User] WHERE [Name]  
                LIKE @Name Or Email LIKE @Email";

                var parameter = connection.Command.Parameters;
                parameter.AddWithValue("@Name", string.Format("%{0}%", Name));
                parameter.AddWithValue("@Email", string.Format("%{0}%", Email));

                var dataTable = connection.QueryWithDataTable(sqlQuery,
                Pagination.OffSetValue, Pagination.PageSize);

                PassToList(dataTable);
            }
        }

        public void GetDetail(int id)
        {
            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = @"SELECT * FROM [User] WHERE Id = @Id";

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
            using (var connection = new DatabaseConnection())
            {
                var userFound = 0;

                var sqlQuery = @"SELECT Login FROM [User] 
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
            using (var connection = new DatabaseConnection())
            {
                var sqlQuery = "SELECT Id FROM [User] WHERE Id = @Id";
                var recordsFound = 0;

                connection.ParameterClear();
                connection.AddParameter("Id", OleDbType.Integer, id);

                using (var reader = connection.QueryWithDataReader(sqlQuery))
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
                var User = new User()
                {
                    Id = Convert.ToInt32(row["Id"]),
                    Name = Convert.ToString(row["Login"]),
                    Email = Convert.ToString(row["Email"])
                };

                List.Add(User);
            }
        }

        public string GetAffectedFields(int id, DatabaseConnection connection)
        {
            var usersList = new List<string>();

            var sqlQuery = @"SELECT * FROM [User] WHERE Id = @Id";

            connection.ParameterClear();
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
                    usersList.Add("PermissãoVisualizar:" + reader["PermissionToView"].ToString().Replace("True", "Sím").Replace("False", "Não"));
                }
            }

            return string.Join(" | ", usersList.Select(x => x.ToString()));
        }

        #endregion
    }
}
