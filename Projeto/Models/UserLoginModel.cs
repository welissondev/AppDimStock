using DimStock.AuxilyTools.AuxilyClasses;
using System.Data;

namespace DimStock.Models
{
    /// <summary>
    /// Representa o modelo de login do usuário
    /// </summary>
    public partial class UserLoginModel
    {
        public int Id { get; set; }
        public string YourName { get; set; }
        public string Email { get; set; }
        public string Login { get; set; }
        public string AccessPassWord { get; set; }
        public string PassWordCheck { get; set; }
        public bool InsertAllowed { get; set; }
        public bool UpdateAllowed { get; set; }
        public bool DeleteAllowed { get; set; }
    }

    public partial class UserLoginModel
    {
        public UserLoginModel()
        {
        }

        public bool Access()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (UserLoginValidationModel.ValidateToAccess(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM UserLogin WHERE Login = @Login AND
                AccessPassWord = @AccessPassWord";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Login", Login);
                dataBase.AddParameter("@AccessPassWord", AccessPassWord);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.Read() == false)
                    {
                        MessageNotifier.Show("Usuário ou senha " +
                        "incorretos!", "Não Encontrado", "?");
                    }
                    else
                    {
                        while (reader.Read())
                        {
                            UserLoginState.Id = int.Parse(reader["Id"].ToString());
                            UserLoginState.Name = reader["YourName"].ToString();
                            UserLoginState.Login = reader["Login"].ToString();
                            actionResult = true;
                        }
                    }
                }
            }

            return actionResult;
        }

        public bool Insert()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (UserLoginValidationModel.ValidateToInsert(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO UserLogin (YourName, Email, Login, 
                AccessPassWord, InsertAllowed, UpdateAllowed, DeleteAllowed)
                VALUES(@YourName, @Email, @Login, @AccessPassWord, @InsertAllowed,
                @UpdateAllowed, @DeleteAllowed";

                dataBase.ClearParameter();
                dataBase.AddParameter("@YourName", YourName);
                dataBase.AddParameter("@Email", Email);
                dataBase.AddParameter("@Login", Login);
                dataBase.AddParameter("@AccessPassWord", AccessPassWord);
                dataBase.AddParameter("@InsertAllowed", InsertAllowed);
                dataBase.AddParameter("@UpdateAllowed", UpdateAllowed);
                dataBase.AddParameter("@DeleteAllowed", DeleteAllowed);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Usuário cadastrado com " +
                    "sucesso!", "Sucesso", "!");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Update()
        {
            var sql = string.Empty;
            var actionResult = false;

            if (UserLoginValidationModel.ValidateToUpdate(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"UPDATE UserLogin SET YourName = @YourName, Email = @Email,
                Login = @Login, AccessPassWord = @AccessPassWord, InsertAllowed = 
                @InsertAllowed, UpdateAllowed = @UpdateAllowed, DeleteAllowed = 
                @DeleteAllowed WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@YourName", YourName);
                dataBase.AddParameter("@Email", Email);
                dataBase.AddParameter("@Login", Login);
                dataBase.AddParameter("@AccessPassWord", AccessPassWord);
                dataBase.AddParameter("@InsertAllowed", InsertAllowed);
                dataBase.AddParameter("@UpdateAllowed", UpdateAllowed);
                dataBase.AddParameter("@DeleteAllowed", DeleteAllowed);
                dataBase.AddParameter("@Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Usuário atualizado com " +
                    "sucesso!", "Sucesso", "!");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool Delete()
        {
            var actionResult = false;
            var sql = string.Empty;

            if (UserLoginValidationModel.ValidateToDelete(this) == false)
                return actionResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"DELETE FROM UserLogin WHERE Id = @Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("Id", Id);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                    MessageNotifier.Show("Usuário excluido com " +
                    "sucesso", "Sucesso", "!");

                    actionResult = true;
                }
            }

            return actionResult;
        }

        public bool GetDetails()
        {
            var actionResult = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM UserLogin WHERE Id = Id";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);

                using (var reader = dataBase.ExecuteReader(sql))
                {
                    if (reader.FieldCount > 0)
                    {
                        while (reader.Read())
                        {
                            Id = int.Parse(reader["Id"].ToString());
                            YourName = reader["YourName"].ToString();
                            Email = reader["Email"].ToString();
                            AccessPassWord = reader["AccessPassWord"].ToString();
                            InsertAllowed = bool.Parse(reader["InsertAllowed"].ToString());
                            UpdateAllowed = bool.Parse(reader["UpdateAllowed"].ToString());
                            DeleteAllowed = bool.Parse(reader["DeleteAllowed"].ToString());
                        }

                        actionResult = true;
                    }
                }
            }

            return actionResult;
        }

        public bool CheckIfRegister()
        {
            /*Essa verificação também precisou ser feita pelo 
             login do usuário, porque a regra de negócio não
             permite dois usuários com o mesmo login
             */

            var registrationStatus = false;
            var sql = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT * FROM UserLogin WHERE 
                Id = @Id OR Login = @Login";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Id", Id);
                dataBase.AddParameter("Login", Login);

                if (dataBase.ExecuteScalar(sql) == 0)
                {
                    return registrationStatus;
                }
            }

            return registrationStatus = true;
        }

        public DataTable SearchData()
        {
            var sql = string.Empty;
            DataTable searchResult;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"SELECT Id, Login, YourName, Email FROM UserLogin WHERE 
                Login LIKE @Login OR YourName LIKE @YourName OR Email = LIKE @Email";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Login", string.Format("%{0}%", Login));
                dataBase.AddParameter("@YourName", string.Format("%{0}%", YourName));
                dataBase.AddParameter("@Email", string.Format("%{0}%", Email));

                searchResult = dataBase.ExecuteDataAdapter(sql);
            }

            return searchResult;
        }
    }
}
