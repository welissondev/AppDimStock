namespace DimStock.Views
{
    public interface IUserLoginAddView
    {
        int Id { get; set; }
        string Name { get; set; }
        string Email { get; set; }
        string Login { get; set; }
        string AccessPassWord { get; set; }
        string PassWordCheck { get; set; }
        bool InsertAllowed { get; set; }
        bool UpdateAllowed { get; set; }
        bool DeleteAllowed { get; set; }
    }
}
