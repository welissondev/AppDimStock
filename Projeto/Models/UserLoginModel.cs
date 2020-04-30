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
                    while (reader.Read())
                    {
                        Id = int.Parse(reader["Id"].ToString());
                        YourName = reader["YourName"].ToString();
                        Email = reader["Email"].ToString();
                        Login = reader["Login"].ToString();
                        AccessPassWord = reader["AccessPassWord"].ToString();
                        InsertAllowed = bool.Parse(reader["InsertAllowed"].ToString());
                        UpdateAllowed = bool.Parse(reader["UpdateAllowed"].ToString());
                        DeleteAllowed = bool.Parse(reader["DeleteAllowed"].ToString());
                        actionResult = true;
                    }
                }

                if (actionResult == false)
                {
                    MessageNotifier.Show("Senha ou login de usuário " +
                    "incorretos!", "Não Encontrado", "?");
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
                sql = @"INSERT INTO UserLogin (YourName, Email, Login, AccessPassWord, 
                InsertAllowed, UpdateAllowed, DeleteAllowed)VALUES(@YourName, @Email, @Login, @AccessPassWord, 
                @InsertAllowed, @UpdateAllowed, @DeleteAllowed)";

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
                    while (reader.Read())
                    {
                        Id = int.Parse(reader["Id"].ToString());
                        YourName = reader["YourName"].ToString();
                        Email = reader["Email"].ToString();
                        Login = reader["Login"].ToString();
                        AccessPassWord = reader["AccessPassWord"].ToString();
                        InsertAllowed = bool.Parse(reader["InsertAllowed"].ToString());
                        UpdateAllowed = bool.Parse(reader["UpdateAllowed"].ToString());
                        DeleteAllowed = bool.Parse(reader["DeleteAllowed"].ToString());
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
            var sqlParameter = string.Empty;
            var sqlSelect = string.Empty;
            var sqlOderBy = string.Empty;
            var query = string.Empty;

            using (var dataBase = new ConnectionModel())
            {
                sqlSelect = @"SELECT Id, Login, YourName, Email 
                FROM UserLogin WHERE Id > 0 ";

                sqlOderBy = @"ORDER BY YourName";

                if (YourName != string.Empty && YourName != null)
                {
                    sqlParameter += @"AND YourName LIKE @YourName ";
                    dataBase.AddParameter("@YourName", string.Format("%{0}%", YourName));
                }

                if (Login != string.Empty && Login != null)
                {
                    sqlParameter += @"AND Login LIKE @Login ";
                    dataBase.AddParameter("@Login", string.Format("%{0}%", Login));
                }

                if (Email != string.Empty && Email != null)
                {
                    sqlParameter += @"AND Email LIKE @Email ";
                    dataBase.AddParameter("@Email", string.Format("%{0}%", Email));
                }

                query += sqlSelect + sqlParameter + sqlOderBy;

                return dataBase.ExecuteDataAdapter(query);
            }
        }
    }
}
