using Syncfusion.Windows.Forms.Tools;
using DimStock.Auxiliary;
using System;
using System.Windows.Forms;

namespace DimStock.View
{
    public partial class FrmProdutoReport : Form
    {

        #region Construtores
        public FrmProdutoReport()
        {
            InitializeComponent();
        }
        #endregion

        #region FrmProdutoReport_Load()
        private void FrmProdutoReport_Load(object sender, EventArgs e)
        {
            ExibirReport();
        }
        #endregion

        #region LblLimpar_LinkClicked()
        private void LblLimpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimparBuscas();
            ExibirReport();
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
                //TimerExecultaConsulta.Enabled = false;
                //PicCarregando.Visible = false;

                //this.tBProdutoTableAdapter.Fill(this.dbEstoqueDataSet.TBProduto, TxtBuscarCodigo.Text, TxtBuscarTamanho.Text,
                //TxtBuscarReferencia.Text, TxtBuscarDescricao.Text);
                //this.RelProdutos.RefreshReport();
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

        #region ExibirReport()
        private void ExibirReport()
        {
            try
            {
                //this.tBProdutoTableAdapter.Fill(this.dbEstoqueDataSet.TBProduto,
                //TxtBuscarCodigo.Text, TxtBuscarTamanho.Text, TxtBuscarReferencia.Text, TxtBuscarDescricao.Text);
                //this.RelProdutos.RefreshReport();
            }
            catch(Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region FrmProdutoReport_Resize()
        private void FrmProdutoReport_Resize(object sender, EventArgs e)
        {
            try
            {
                // Centraliza image gif carregando no formulário
                PicCarregando.Left = this.Width / 2 - PicCarregando.Width / 2;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion
    }
}
