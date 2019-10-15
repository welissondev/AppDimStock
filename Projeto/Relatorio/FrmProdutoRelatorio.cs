using Syncfusion.Windows.Forms.Tools;
using SysEstoque.Auxiliary;
using System;
using System.Windows.Forms;

namespace SysEstoque.View
{
    public partial class FrmProdutoRelatorio : Form
    {

        #region Construtores
        public FrmProdutoRelatorio()
        {
            InitializeComponent();
        }
        #endregion

        #region FrmProdutoRelatorio_Load()
        private void FrmProdutoRelatorio_Load(object sender, EventArgs e)
        {
            ExibirRelatorio();
        }
        #endregion

        #region LblLimpar_LinkClicked()
        private void LblLimpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimparBuscas();
            ExibirRelatorio();
        }
        #endregion

        #region TxtBuscarCodigo_KeyPress()
        private void TxtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimerExecultaConsulta.Enabled = false;
            TimerExecultaConsulta.Enabled = true;
            PicCarregando.Visible = true;
        }
        #endregion

        #region TimerExecultaConsulta_Tick()
        private void TimerExecultaConsulta_Tick(object sender, EventArgs e)
        {
            try
            {
                TimerExecultaConsulta.Enabled = false;
                PicCarregando.Visible = false;

                this.tBProdutoTableAdapter.Fill(this.dbEstoqueDataSet.TBProduto, TxtBuscarCodigo.Text, TxtBuscarTamanho.Text,
                TxtBuscarReferencia.Text, TxtBuscarDescricao.Text);
                this.RelProdutos.RefreshReport();
            }
            catch(Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }
        #endregion

        #region LimparBuscas()
        private void LimparBuscas()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;
                    if (ctl.GetType() == typeof(CurrencyTextBox))
                        ctl.Text = string.Empty;
                    if (ctl.GetType() == typeof(IntegerTextBox))
                        ctl.Text = string.Empty;
                }

                TxtBuscarCodigo.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ExibirRelatorio()
        private void ExibirRelatorio()
        {
            try
            {
                this.tBProdutoTableAdapter.Fill(this.dbEstoqueDataSet.TBProduto,
                TxtBuscarCodigo.Text, TxtBuscarTamanho.Text, TxtBuscarReferencia.Text, TxtBuscarDescricao.Text);
                this.RelProdutos.RefreshReport();
            }
            catch(Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

    }
}
