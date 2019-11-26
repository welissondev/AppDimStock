using System;
using System.Windows.Forms;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class FrmUsuarioLogin : Form
    {
        #region Construtores
        public FrmUsuarioLogin()
        {
            InitializeComponent();
        }
        #endregion

        #region BtnLogar_Click()
        private void BtnLogar_Click(object sender, EventArgs e)
        {
            try
            {
                BllUsuario usuario = new BllUsuario
                {
                    Login = TxtLogin.Text,
                    Senha = TxtSenha.Text
                };

                if (usuario.Acessar() == true)
                {
                    AxlLogin.Id = usuario.Id;
                    AxlLogin.Nome = usuario.Nome;
                    AxlLogin.Login = usuario.Login;
                    AxlLogin.PermissaoCadastrar = usuario.PermissaoCadastrar;
                    AxlLogin.PermissaoAlterar = usuario.PermissaoEditar;
                    AxlLogin.PermissaoDeletar = usuario.PermissaoDeletar;
                    AxlLogin.PermissaoVisualizar = usuario.PermissaoVisualizar;

                    Hide();
                    using (Form mdi = new MDIPrincipal())
                    {
                        mdi.Closed += (s, args) => Close();
                        mdi.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show(BllNotificar.Message, "NÃO ENCONTRADO", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 
    }
}
