namespace DimStock.Models
{
    public class UserPermissionModel
    {
        public int Id { get; set; }
        public bool Insert { get; set; }
        public bool Update { get; set; }
        public bool Delete { get; set; }
        public bool Viewer { get; set; }
    }
}
