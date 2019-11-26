using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using Syncfusion.Windows.Forms.Tools;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class FrmUsuarioCadastro : Form
    {
        private readonly int id = 0;

        #region Construtores
        public FrmUsuarioCadastro()
        {
            InitializeComponent();

            LblDataLong.Text = DateTime.Now.ToLongDateString();
        }

        public FrmUsuarioCadastro(int id)
        {
            InitializeComponent();

            LblDataLong.Text = DateTime.Now.ToLongDateString();

            this.id = id;
        }
        #endregion

        #region BtnNovaAtividade_Click()
        private void BtnNovaAtividade_Click(object sender, EventArgs e)
        {
            ReseteControles();
        }
        #endregion 

        #region BtnSalvar_Click()
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                Registrar();
            }
            else
            {
                Alterar();
            }
        }
        #endregion 

        #region ReseteControles()
        private void ReseteControles()
        {
            try
            {
                foreach (Control ctl in GbxPermissoes.Controls)
                {
                    Application.DoEvents();
                    if (ctl is BunifuCheckbox)
                        ((BunifuCheckbox)ctl).Checked = false;
                }

                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                    {
                        ctl.Text = "";
                    }
                }

                TxtNome.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ChkPermissaoTodas_OnChange()
        private void ChkPermissaoTodas_OnChange(object sender, EventArgs e)
        {
            AtivarTodasPermissoes();
        }
        #endregion 

        #region AtivarTodasPermissoes()
        private void AtivarTodasPermissoes()
        {
            try
            {
                if (ChkPermissaoTodas.Checked == true)
                {
                    foreach (Control ctl in GbxPermissoes.Controls)
                    {
                        if (ctl is BunifuCheckbox)
                            ((BunifuCheckbox)ctl).Checked = true;
                    }
                }
                else
                {
                    foreach (Control ctl in GbxPermissoes.Controls)
                    {
                        if (ctl is BunifuCheckbox)
                            ((BunifuCheckbox)ctl).Checked = false;
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Registrar()
        private void Registrar()
        {
            try
            {
                if (ValidarDadosEntrada() == true)
                {
                    BllUsuario usuario = new BllUsuario
                    {
                        Nome = TxtNome.Text.TrimStart().TrimEnd(),
                        Email = TxtEmail.Text.TrimStart().TrimEnd(),
                        Login = TxtLogin.Text.Trim(),
                        Senha = TxtSenha.Text.Trim(),
                        PermissaoCadastrar = ChkPermissaoCadastrar.Checked,
                        PermissaoEditar = ChkPermissaoEditar.Checked,
                        PermissaoDeletar = ChkPermissaoDeletar.Checked,
                        PermissaoVisualizar = ChkPermissaoVisualizar.Checked,
                        PermissaoTodas = ChkPermissaoTodas.Checked
                    };

                    if (usuario.Registrar() == true)
                    {
                        MessageBox.Show(BllNotificar.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ReseteControles();
                    }
                    else
                    {
                        MessageBox.Show(BllNotificar.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Alterar()
        private void Alterar()
        {
            try
            {
                if (ValidarDadosEntrada() == true)
                {
                    BllUsuario usuario = new BllUsuario
                    {
                        Nome = TxtNome.Text,
                        Email = TxtEmail.Text,
                        Login = TxtLogin.Text,
                        Senha = TxtSenha.Text,
                        PermissaoCadastrar = ChkPermissaoCadastrar.Checked,
                        PermissaoEditar = ChkPermissaoEditar.Checked,
                        PermissaoDeletar = ChkPermissaoDeletar.Checked,
                        PermissaoVisualizar = ChkPermissaoVisualizar.Checked,
                        PermissaoTodas = ChkPermissaoTodas.Checked
                    };

                    if(usuario.Alterar(id) == true)
                    {
                        MessageBox.Show(BllNotificar.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(BllNotificar.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ValidarDadosEntrada()
        private bool ValidarDadosEntrada()
        {
            if (TxtNome.Text == "")
            {
                MessageBox.Show("O nome é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtNome.Select();

                return false;
            }

            else if (TxtEmail.Text == "")
            {
                MessageBox.Show("E-mail é obrigatório!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtEmail.Select();

                return false;
            }

            else if (ValidarEmail(TxtEmail.Text).Equals(false))
            {
                MessageBox.Show("O email informado não é válido, verifique " +
                "e tente novamente! ", "EMAIL INVÁLIDO", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                TxtEmail.Select();

                return false;

            }
            else if (TxtSenha.Text == "")
            {
                MessageBox.Show("A senha é obrigatória!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtSenha.Select();

                return false;
            }

            else if (TxtConfirmarSenha.Text == "")
            {
                MessageBox.Show("Confirme a senha!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtConfirmarSenha.Select();

                return false;
            }

            else if (TxtConfirmarSenha.Text != TxtSenha.Text)
            {
                MessageBox.Show("A senhas não conferem!", "NÃO CONFERE",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtConfirmarSenha.Select();

                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion

        #region ValidarEmail()
        private bool ValidarEmail(string email)
        {
            Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if (rg.IsMatch(email))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion 
    }
}
