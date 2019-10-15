using SysEstoque.View;

namespace SysEstoque.Auxiliary
{
    public static class AxlForm
    {
        public static FrmUsuarioLogin UsuarioLogin { get; set; }
        public static MDIPrincipal Principal { get; set; }
        public static FrmEstoqueAtividade EstoqueAtividade { get; set; }

        public static void DisposeAll()
        {
            if(UsuarioLogin != null)
            {
                UsuarioLogin.Dispose();
            }

            if (EstoqueAtividade != null)
            {
                Principal.Dispose();
            }
        }

    }
}
