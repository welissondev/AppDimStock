using Syncfusion.Windows.Forms.Tools;
using SysEstoque.Auxiliary;
using System;
using System.Windows.Forms;

namespace SysEstoque.Relatorio
{
    public partial class FrmEstoqueRelatorio : Form
    {
        #region Construtores
        public FrmEstoqueRelatorio()
        {
            InitializeComponent();
        }
        #endregion

        #region FrmEstoqueRelatorio_Load()
        private void FrmEstoqueRelatorio_Load(object sender, EventArgs e)
        {
            ListarRelatorio();
        }
        #endregion

        #region LblLimpar_LinkClicked()
        private void LblLimpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LimparBuscas();
            ListarRelatorio();
        }
        #endregion

        #region TxtBuscaCodigo_KeyPress()
        private void TxtBuscaCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            PicCarregando.Visible = true;
            TimerExecultaConsulta.Enabled = false;
            TimerExecultaConsulta.Enabled = true;
        }
        #endregion

        #region TimerExecultaConsulta_Tick()
        private void TimerExecultaConsulta_Tick(object sender, EventArgs e)
        {
            TimerExecultaConsulta.Enabled = false;
            PicCarregando.Visible = false;
            ListarRelatorio();
        }
        #endregion

        #region ListarRelatorio()
        private void ListarRelatorio()
        {
            try
            {
                this.tBEstoqueTableAdapter.Fill(this.dbEstoqueDataSet.TBEstoque, TxtBuscaCodigo.Text,
                TxtBuscaTamanho.Text, TxtBuscarReferencia.Text, TxtBuscarDescricao.Text);
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
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

                TxtBuscaCodigo.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion
    }
}
