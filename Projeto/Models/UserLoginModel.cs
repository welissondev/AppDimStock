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
        public UserPermissionModel Permission { get; set; }
    }

    public partial class UserLoginModel
    {
        public UserLoginModel()
        {
        }    
    }
}
