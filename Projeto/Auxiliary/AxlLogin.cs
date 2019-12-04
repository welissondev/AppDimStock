namespace DimStock.Auxiliary
{

    /// <summary>
    /// Uma classe axiliar statica que guarda os estados de um usuário logado
    /// </summary>
    public static class AxlLogin 
    {
        public static int UserId;
        public static string UserName;
        public static string Login;
        public static bool PermissionToRegister;
        public static bool PermissionToEdit;
        public static bool PermissionToDelete;
        public static bool PermissionToView;
    }
}
