using System;
using System.Drawing;
using System.Windows.Forms;
using Syncfusion.Windows.Forms.Tools;
using SysEstoque.Business;
using SysEstoque.Auxiliary;
using SysEstoque.Properties;
using System.IO;

namespace SysEstoque.View
{
    public partial class FrmProdutoCadastro : Form
    {
        #region Propriedades

        int id = 0;

        public int Id { get => id; set => id = value; }
        #endregion

        #region Constructor() 
        public FrmProdutoCadastro()
        {
            InitializeComponent();

            LblDataLong.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region BtnSalvar_Click()
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (Id == 0)
            {
                if(AxlLogin.PermissaoCadastrar == false)
                {
                    MessageBox.Show("Você não tem permissão para cadastrar produtos!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Cadastrar();
                }  
            }
            else if(id > 0)
            {
                if(AxlLogin.PermissaoAlterar == false)
                {
                    MessageBox.Show("Você não tem permissão para alterar produtos!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    Alterar();
                }  
            };
        }
        #endregion

        #region BtnLimpar_Click()
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            ChamarTodosResetes();
        }
        #endregion

        #region PicFoto_Click()
        private void PicFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (CarregarFoto() == false)
                {
                    if (BllProdutoFoto.EncontrarArquivo(BllProdutoFoto.PegarCaminho() + PicFoto.FotoNome).Equals(false))
                    {
                        PicFoto.FotoNome = "";
                        PicFoto.ArquivoDiretorioSelecionado = "";
                        PicFoto.Image = Resources.FotoNothing;
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region CarregarFoto()
        private bool CarregarFoto()
        {

            AxlImage image = new AxlImage();

            image.OpenFileDialog();
            if (image.DirectoryFile != "")
            {
                using (FileStream file = new FileStream(image.DirectoryFile, FileMode.Open, FileAccess.Read))
                {
                    PicFoto.Image = Image.FromStream(file);
                    PicFoto.FotoNome = BllProdutoFoto.PegarGuid() + ".jpg";
                    PicFoto.ArquivoDiretorioSelecionado = image.DirectoryFile;

                    return true;
                }
            }

            return false;
        }
        #endregion

        #region RecarregarFoto()
        public void RecarregarFoto(string fotoNome, bool novoGuid = false)
        {
            var fotoProduto = BllProdutoFoto.PegarCaminho() + fotoNome;

            if (BllProdutoFoto.EncontrarArquivo(fotoProduto).Equals(true))
            {
                using (FileStream file = new FileStream(fotoProduto, FileMode.Open, FileAccess.Read))
                {
                    PicFoto.Image = Image.FromStream(file);
                    PicFoto.ArquivoDiretorioSelecionado = fotoProduto;
                    PicFoto.UltimaFoto = fotoProduto;
                    if (novoGuid.Equals(true)) fotoNome = BllProdutoFoto.PegarGuid() + ".jpg";
                    PicFoto.FotoNome = fotoNome;
                }
            }
            else
            {
                PicFoto.Image = Resources.FotoNothing;
            }
        }
        #endregion 

        #region ValidarDadosEntrada()
        private bool ValidarDadosEntrada()
        {
            if (TxtCodigo.Text == string.Empty)
            {
                MessageBox.Show("Campo código produto é obrigatório!", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtCodigo.Select();
                return false;
            }

            else if (TxtTamanho.Text == string.Empty)
            {
                MessageBox.Show("Campo tamanho é obrigatório!", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtTamanho.Select();
                return false;
            }

            else if (TxtReferencia.Text == string.Empty)
            {
                MessageBox.Show("Campo código estampa é obrigatório!", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtReferencia.Select();
                return false;
            }

            else if (TxtFornecedor.Text == string.Empty)
            {
                MessageBox.Show("Campo nome é obrigatório!", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtFornecedor.Select();
                return false;
            }

            else if (TxtDescricao.Text == string.Empty)
            {
                MessageBox.Show("Campo descrição é obrigatório!", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtDescricao.Select();
                return false;
            }

            else if (TxtEstoqueMin.Text == string.Empty)
            {
                MessageBox.Show("Quantidade mínima obrigatória!", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEstoqueMin.Select();
                return false;
            }
            else if (TxtEstoqueMax.Text == string.Empty)
            {
                MessageBox.Show("Quantidade máxima obrigatória!", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEstoqueMax.Select();
                return false;
            }

            else if (Convert.ToInt32(TxtEstoqueMin.Text) > Convert.ToInt32(TxtEstoqueMax.Text))
            {
                MessageBox.Show("Quantidade mínima não pode ser maior que quantidade máxima!", "OBRIGATÓRIO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                TxtEstoqueMax.Select();
                return false;
            }

            else
            {
                return true;
            }
        }
        #endregion 

        #region Cadastrar()
        private void Cadastrar()
        {
            try
            {
                if (ValidarDadosEntrada() == false)
                {
                    return;
                }
                {
                    BllProduto produto = new BllProduto
                    {
                        Codigo = TxtCodigo.Text,
                        Tamanho = TxtTamanho.Text,
                        Referencia = TxtReferencia.Text,
                        Fornecedor = TxtFornecedor.Text,
                        Descricao = TxtDescricao.Text,
                        EstoqueMin = Convert.ToInt32(TxtEstoqueMin.Text),
                        EstoqueMax = Convert.ToInt32(TxtEstoqueMax.Text),
                        PrecoCusto = Convert.ToDouble(TxtPrecoCusto.Text.Replace("R$", "").Replace("$", "")),
                        PrecoVenda = Convert.ToDouble(TxtPrecoVenda.Text.Replace("R$", "").Replace("$", "")),
                        CodigoBarras = TxtCodigoBarras.Text,
                        FotoNome = PicFoto.FotoNome
                    };

                    if (produto.Registrar() == true)
                    {
                        BllProdutoFoto.CopiarParaDiretorio(PicFoto.ArquivoDiretorioSelecionado,
                        produto.PastaDiretorioDasFotos + produto.FotoNome);

                        MessageBox.Show(BllNotificar.Message, "SUCESSO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ChamarTodosResetes();
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
                if (ValidarDadosEntrada() == false)
                {
                    return;
                }
                else
                {
                    BllProduto produto = new BllProduto()
                    {
                        Codigo = TxtCodigo.Text,
                        Tamanho = TxtTamanho.Text,
                        Referencia = TxtReferencia.Text,
                        Fornecedor = TxtFornecedor.Text,
                        Descricao = TxtDescricao.Text,
                        EstoqueMin = Convert.ToInt32(TxtEstoqueMin.Text),
                        EstoqueMax = Convert.ToInt32(TxtEstoqueMax.Text),
                        PrecoCusto = Convert.ToDouble(TxtPrecoCusto.Text.Replace("R$", "").Replace("$", "")),
                        PrecoVenda = Convert.ToDouble(TxtPrecoVenda.Text.Replace("R$", "").Replace("$", "")),
                        CodigoBarras = TxtCodigoBarras.Text,
                        FotoNome = PicFoto.FotoNome,
                    };

                    if (produto.Alterar(id) == true)
                    {

                        if (BllProdutoFoto.EncontrarArquivo(produto.PastaDiretorioDasFotos 
                        + produto.FotoNome).Equals(false)) BllProdutoFoto.DeletarArquivo(PicFoto.UltimaFoto);

                        BllProdutoFoto.CopiarParaDiretorio(PicFoto.ArquivoDiretorioSelecionado,
                        produto.PastaDiretorioDasFotos + produto.FotoNome);

                        MessageBox.Show(BllNotificar.Message, "SUCESSO", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ResetarControles()
        private void ResetarControles()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                    {
                        ctl.Text = string.Empty;
                    }
                    else if (ctl.GetType() == typeof(CurrencyTextBox))
                    {
                        ctl.Text = string.Empty;
                    }
                    else if (ctl.GetType() == typeof(IntegerTextBox))
                    {
                        ctl.Text = "";
                    }
                }

                PicFoto.Image = Resources.FotoNothing;
                PicFoto.FotoNome = "";
                PicFoto.ArquivoDiretorioSelecionado = "";
                PicFoto.UltimaFoto = "";
                TxtCodigo.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ResetarVariaveis()
        private void ResetarVariaveis()
        {
            id = 0;
        }
        #endregion

        #region ChamarTodosResetes()
        private void ChamarTodosResetes()
        {
            ResetarControles();
            ResetarVariaveis();
        }
        #endregion
    }
}


