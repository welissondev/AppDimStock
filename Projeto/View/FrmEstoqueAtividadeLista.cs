using System;
using System.Windows.Forms;
using SysEstoque.Business;
using SysEstoque.Auxiliary;
using SysEstoque.Properties;
using System.Linq;
using System.Collections.Generic;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.ListView;

namespace SysEstoque.View
{
    public partial class FrmEstoqueAtividadeLista : Form
    {
        #region Propriedades
        private readonly int numeroRegistros = 100;
        #endregion 

        #region Construtores
        public FrmEstoqueAtividadeLista()
        {
            InitializeComponent();

            InitializeDefinicoes();
        }
        #endregion

        #region BtnAtualizar()
        private void Btn_Click(object sender, EventArgs e)
        {
            ListarAtividades();
        }
        #endregion

        #region FrmEstoqueAtividadeLista_Load()
        private void FrmEstoqueAtividadeLista_Load(object sender, EventArgs e)
        {
        }
        #endregion

        #region GridListaAtividade_CellMouseMove()
        private void GridListaAtividade_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnIndexName = GridListaAtividade.Columns[e.ColumnIndex].Name;
                if (columnIndexName == "btnVisualizarColumn" || columnIndexName == "btnDeletarColumn")
                {
                    GridListaAtividade.Cursor = Cursors.Hand;
                }
                else
                {
                    GridListaAtividade.Cursor = Cursors.Arrow;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region GridListaAtividade_CellClick()
        private void GridListaAtividade_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridListaAtividade.Rows.Count > 0)
            {
                var columnName = GridListaAtividade.Columns[e.ColumnIndex].Name;

                if (columnName == "btnVisualizarColumn" && e.RowIndex != -1)
                {
                    Visualizar();
                }
                else if (columnName == "btnDeletarColumn" && e.RowIndex != -1)
                {
                    Deletar();
                }
            }
        }
        #endregion

        #region TimerExecutaConsulta_Tick()
        private void TimerExecutaConsulta_Tick(object sender, EventArgs e)
        {
            TimerExecutaConsulta.Enabled = false;
            PicCarregando.Visible = false;
            Consultar();
        }
        #endregion

        #region TxtDataInicio_ValueChanged()
        private void TxtDataInicio_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            //TimerExecutaConsulta.Enabled = false;
            //TimerExecutaConsulta.Enabled = true;
        }
        #endregion

        #region TxtDataFinal_ValueChanged()
        private void TxtDataFinal_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            PicCarregando.Visible = true;
            TimerExecutaConsulta.Enabled = false;
            TimerExecutaConsulta.Enabled = true;
        }
        #endregion

        #region CboTipo_SelectedIndexChanged()
        private void CboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicCarregando.Visible = true;
            TimerExecutaConsulta.Enabled = false;
            TimerExecutaConsulta.Enabled = true;
        }
        #endregion

        #region CboSituacao_SelectedIndexChanged()
        private void CboSituacao_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicCarregando.Visible = true;
            TimerExecutaConsulta.Enabled = false;
            TimerExecutaConsulta.Enabled = true;
        }
        #endregion

        #region TxtBuscaNumeroAtividade_TextChanged
        private void TxtBuscaNumeroAtividade_TextChanged(object sender, EventArgs e)
        {
            TimerExecutaConsulta.Enabled = false;
            TimerExecutaConsulta.Enabled = true;
            PicCarregando.Visible = true;
        }
        #endregion

        #region LblLimpar_LinkClicked()
        private void LblLimpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;

                    if (ctl.GetType() == typeof(SfComboBox))
                        ctl.Text = string.Empty;
                }

                TxtBuscaNumeroAtividade.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ListarAtividades()
        private void ListarAtividades()
        {
            try
            {
                BllEstoqueAtividade estoqueAtividade = new BllEstoqueAtividade();
                estoqueAtividade.Listar();

                GridListaAtividade.Rows.Clear();
                for (int item = 0; item < estoqueAtividade.Lista.Count; item++)
                {
                    GridListaAtividade.Rows.Add(
                    estoqueAtividade.Lista[item].Id,
                    estoqueAtividade.Lista[item].Tipo,
                    estoqueAtividade.Lista[item].Data,
                    estoqueAtividade.Lista[item].Hora,
                    estoqueAtividade.Lista[item].Situacao
                    );
                }

                AxlDataGridViewLealt.SortcolumnDesc(GridListaAtividade, 0);

                TxtTotalAtividade.Text = Convert.ToString(estoqueAtividade.Lista.Count());

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Consultar()
        public void Consultar()
        {
            try
            {
                BllEstoqueAtividade estoqueAtividade = new BllEstoqueAtividade();

                estoqueAtividade.Consultar(TxtBuscaNumeroAtividade.Text,
                CboTipo.Text, CboSituacao.Text, Convert.ToDateTime(TxtDataInicio.Value).ToString("dd-MM-yyyy"),
                Convert.ToDateTime(TxtDataFinal.Value).ToString("dd-MM-yyyy"), numeroRegistros);

                GridListaAtividade.Rows.Clear();
                for (int item = 0; item < estoqueAtividade.Lista.Count; item++)
                {
                    GridListaAtividade.Rows.Add(
                    estoqueAtividade.Lista[item].Id,
                    estoqueAtividade.Lista[item].Tipo,
                    estoqueAtividade.Lista[item].Data,
                    estoqueAtividade.Lista[item].Hora,
                    estoqueAtividade.Lista[item].Situacao
                    );
                }

                AxlDataGridViewLealt.SortcolumnDesc(GridListaAtividade, 0);

                TxtTotalAtividade.Text = Convert.ToString(estoqueAtividade.Lista.Count());

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region Deletar()
        private void Deletar()
        {
            try
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(GridListaAtividade.CurrentRow.Cells["idColumn"].Value);

                    BllEstoqueAtividade atividade = new BllEstoqueAtividade();

                    if (atividade.Deletar(id) == true)
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

        #region Visualizar()
        private void Visualizar()
        {
            try
            {
                int id = Convert.ToInt32(
                GridListaAtividade.CurrentRow.Cells["idColumn"].Value
                );

                var frm = new FrmEstoqueAtividade();
                frm.GetDetalhesAtividade(id);
                frm.ListEstoqueItens();
                frm.ShowDialog();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region DefineGridColumns()
        private void DefineGridColumns()
        {
            try
            {
                DataGridViewTextBoxColumn IdColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn tipoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn horaColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn situacaoColumn = new DataGridViewTextBoxColumn();
                DataGridViewImageColumn btnVisualizarColumn = new DataGridViewImageColumn();
                DataGridViewImageColumn btnDeletarColumn = new DataGridViewImageColumn();

                DataGridView dtg = GridListaAtividade;

                dtg.Columns.Add(IdColumn);
                dtg.Columns[0].Name = "IdColumn";
                dtg.Columns[0].HeaderText = "ID";
                dtg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].Visible = false;
                dtg.Columns[0].ReadOnly = true;

                dtg.Columns.Add(tipoColumn);
                dtg.Columns[1].Width = 100;
                dtg.Columns[1].Name = "tipoColumn";
                dtg.Columns[1].HeaderText = "TIPO";
                dtg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[1].ReadOnly = true;

                dtg.Columns.Add(dataColumn);
                dtg.Columns[2].Width = 100;
                dtg.Columns[2].Name = "dataColumn";
                dtg.Columns[2].HeaderText = "DATA";
                dtg.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                dtg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].ReadOnly = true;

                dtg.Columns.Add(horaColumn);
                dtg.Columns[3].Name = "horaColumn";
                dtg.Columns[3].HeaderText = "HÓRA";
                dtg.Columns[3].Width = 100;
                dtg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[3].DisplayIndex = 2;
                dtg.Columns[3].ReadOnly = true;
                dtg.Columns[3].Visible = true;

                dtg.Columns.Add(situacaoColumn);
                dtg.Columns[4].Width = 100;
                dtg.Columns[4].Name = "situacaoColumn";
                dtg.Columns[4].HeaderText = "SITUAÇÃO";
                dtg.Columns[4].ReadOnly = true;
                dtg.Columns[4].Visible = true;

                dtg.Columns.Add(btnVisualizarColumn);
                dtg.Columns[5].Name = "btnVisualizarColumn";
                dtg.Columns[5].HeaderText = "";
                dtg.Columns[5].Width = 70;
                dtg.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[5].ReadOnly = true;
                btnVisualizarColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                btnVisualizarColumn.Image = Resources.Visualizar2;

                dtg.Columns.Add(btnDeletarColumn);
                dtg.Columns[6].Name = "btnDeletarColumn";
                dtg.Columns[6].HeaderText = "";
                dtg.Columns[6].Width = 70;
                dtg.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[6].ReadOnly = true;
                btnDeletarColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                btnDeletarColumn.Image = Resources.Deletar;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region PreencherComboBoxes()
        private void PreencherComboBoxes()
        {
            try
            {
                List<string> listaTipo = new List<string>()
                {
                    "Entrada",
                    "Saída"
                };

                CboTipo.DataSource = listaTipo;


                List<string> listaSituacao = new List<string>()
                {
                    "Em Aberto",
                    "Finalizada"
                };

                CboSituacao.DataSource = listaSituacao;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region InitializeDefinicoes()
        public void InitializeDefinicoes()
        {

            DefineGridColumns();

            PreencherComboBoxes();

            //Defini o lealt do datagridviw
            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridListaAtividade);

            //Exibi a data atual para usuáio, no formato long
            LblDataLong.Text = DateTime.Now.ToLongDateString();

            //Defini uma data inicial e final
            var primeiroDia = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var ultimoDia = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            var dataInicial = primeiroDia;
            var dataFinal = ultimoDia + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;

            TxtDataInicio.Text = Convert.ToString(dataInicial);
            TxtDataFinal.Text = Convert.ToString(dataFinal);

        }

        #endregion

    }
}
