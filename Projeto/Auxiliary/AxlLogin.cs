namespace DimStock.Auxiliary
{

    /// <summary>
    /// Uma classe axiliar statica que guarda os estados de um usuário logado
    /// </summary>
    public static class AxlLogin 
    {
        public static int Id;
        public static string Nome;
        public static string Login;
        public static bool PermissaoCadastrar;
        public static bool PermissaoAlterar;
        public static bool PermissaoDeletar;
        public static bool PermissaoVisualizar;
    }
}
