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
        public bool InsertAllowed { get; set; }
        public bool UpdateAllowed { get; set; }
        public bool DeleteAllowed { get; set; }
    }

    public partial class UserLoginModel
    {
        public UserLoginModel()
        {
        }

        public bool Insert()
        {
            var sql = string.Empty;
            var actionResult = false;

            using (var dataBase = new ConnectionModel())
            {
                sql = @"INSERT INTO UserLogin ([Name], Email, Login, 
                [PassWord]) VALUES (@Name, @Email, @Login, @PassWord";

                dataBase.ClearParameter();
                dataBase.AddParameter("@Name", Name);
                dataBase.AddParameter("@Email", Email);
                dataBase.AddParameter("@Login", Login);
                dataBase.AddParameter("PassWord", PassWord);

                if (dataBase.ExecuteNonQuery(sql) > 0)
                {
                }
            }
        }
    }
}
