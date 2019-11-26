using DimStock.Auxiliary;
using DimStock.Report;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.View
{
    public partial class MDIPrincipal : Form
    {
        #region Propriedades
        private int childFormNumber = 0;
        #endregion 

        #region MDIPrincipal
        public MDIPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region ShowNewForm()
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form
            {
                MdiParent = this,
                Text = "Janela " + childFormNumber++
            };
            childForm.Show();
        }
        #endregion 

        #region OnLoad()
        protected override void OnLoad(EventArgs e)
        {
            //Remove o 3d do mdiform e modifica a cor de fundo
            try
            {
                var mdiclient = this.Controls.OfType<MdiClient>().SingleOrDefault();
                mdiclient.BackColor = Color.White;
                this.SuspendLayout();
                mdiclient.SuspendLayout();
                var hdiff = mdiclient.Size.Width - mdiclient.ClientSize.Width;
                var vdiff = mdiclient.Size.Height - mdiclient.ClientSize.Height;
                var size = new Size(mdiclient.Width + hdiff, mdiclient.Height + vdiff);
                var location = new Point(mdiclient.Left - (hdiff / 2), mdiclient.Top - (vdiff / 2));
                mdiclient.Dock = DockStyle.None;
                mdiclient.Size = size;
                mdiclient.Location = location;
                mdiclient.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                mdiclient.ResumeLayout(true);
                this.ResumeLayout(true);
                base.OnLoad(e);
            }

            catch (Exception ex)
            {
                ex.GetType();
                this.Close();
            }
        }
        #endregion

        #region EstoqueEntradaMenuItem_Click()
        private void EstoqueEntradaMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmEstoqueAtividade();
                frm.TipoAtividade = "Entrada";
                frm.AdicionarAtividade();
                frm.GetDetalhesAtividade(frm.IdEstoqueAtividade);
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region EstoqueSaidaMenuItem_Click()
        private void EstoqueSaidaMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var frm = new FrmEstoqueAtividade();
                frm.TipoAtividade = "Saída";
                frm.AdicionarAtividade();
                frm.GetDetalhesAtividade(frm.IdEstoqueAtividade);
                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region EstoqueListaMenuItem_Click()
        private void EstoqueListaMenuItem_Click(object sender, EventArgs e)
        {
            FrmStockList frmEstoqueLista = new FrmStockList();
            frmEstoqueLista.MdiParent = this;
            frmEstoqueLista.Show();
        }
        #endregion

        #region ProdutoListaMenuItem_Click()
        private void ProdutoListaMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoLista produtoLista = new FrmProdutoLista();
            produtoLista.MdiParent = this;
            produtoLista.Show();
        }
        #endregion

        #region ProdutoAdicionarMenuItem_Click()
        private void ProdutoAdicionarMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoCadastro produtoCadastro = new FrmProdutoCadastro();
            produtoCadastro.MdiParent = this;
            produtoCadastro.WindowState = FormWindowState.Maximized;
            produtoCadastro.Show();
        }
        #endregion

        #region ListaDeEstoqueMenuItem_Click()
        private void ListaDeEstoqueMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmEstoqueAtividadeLista estoqueAtividadeLista = new FrmEstoqueAtividadeLista();
                estoqueAtividadeLista.WindowState = FormWindowState.Maximized;
                estoqueAtividadeLista.MdiParent = this;
                estoqueAtividadeLista.Show();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region UsuarioCadastroMenuItem_Click()
        private void UsuarioCadastroMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AxlLogin.PermissaoVisualizar == true)
                {
                    FrmUsuarioCadastro frm = new FrmUsuarioCadastro();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Apenas administradores podem acessar " +
                    "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region UsuarioListaMenuItem_Click()
        private void UsuarioListaMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AxlLogin.PermissaoVisualizar == true)
                {
                    FrmUsuarioLista frm = new FrmUsuarioLista();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Apenas administradores podem acessar " +
                    "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region UsuarioHistóricoMenuItem_Click()
        private void UsuarioHistóricoMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (AxlLogin.PermissaoVisualizar == true)
                {
                    FrmUsuarioListaHistorico frm = new FrmUsuarioListaHistorico();
                    frm.WindowState = FormWindowState.Maximized;
                    frm.MdiParent = this;
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Apenas administradores podem acessar " +
                    "essa ária!", "ACESSO NEGADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ProdutoReportMenuItem_Click
        private void ProdutoReportMenuItem_Click(object sender, EventArgs e)
        {
            FrmProdutoReport frm = new FrmProdutoReport();
            frm.MdiParent = this;
            frm.WindowState = FormWindowState.Maximized;
            frm.Show();
        }
        #endregion
    }
}
