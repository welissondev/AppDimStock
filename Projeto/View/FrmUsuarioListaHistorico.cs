using System;
using System.Windows.Forms;
using SysEstoque.Auxiliary;
using SysEstoque.Business;

namespace SysEstoque.View
{
    public partial class FrmUsuarioListaHistorico : Form
    {
        #region Propriedades
        private int quantidadeRegistros = 100;
        #endregion 

        #region Construtores
        public FrmUsuarioListaHistorico()
        {
            InitializeComponent();
            InitializeDefinicoes();
        }
        #endregion

        #region BtnAtualizar_Click()
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
        #endregion 

        #region FrmUsuarioHistorico_Load()
        private void FrmUsuarioHistorico_Load(object sender, EventArgs e)
        {
            Listar();
        }
        #endregion

        #region TxtBuscarLogin_TextChanged()
        private void TxtBuscarLogin_TextChanged(object sender, EventArgs e)
        {
            PicCarregando.Visible = true;
            TimeExecultaConsulta.Enabled = false;
            TimeExecultaConsulta.Enabled = true;
        }
        #endregion

        #region TxtBuscaDataInicio_ValueChanged()
        private void TxtBuscaDataInicio_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            //PicCarregando.Visible = true;
            //TimeExecultaConsulta.Enabled = false;
            //TimeExecultaConsulta.Enabled = true;
        }
        #endregion

        #region TxtBuscaDataFinal_ValueChanged()
        private void TxtBuscaDataFinal_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            PicCarregando.Visible = true;
            TimeExecultaConsulta.Enabled = false;
            TimeExecultaConsulta.Enabled = true;
        }
        #endregion 

        #region TimeExecultaConsulta_Tick()
        private void TimeExecultaConsulta_Tick(object sender, EventArgs e)
        {
            PicCarregando.Visible = false;
            TimeExecultaConsulta.Enabled = false;
            Consultar();
        }
        #endregion 

        #region Listar()
        public void Listar()
        {
            try
            {
                BllUsuarioHistorico historico = new BllUsuarioHistorico();
                historico.Listar(quantidadeRegistros);

                GridListaHistorico.Rows.Clear();

                for (int item =0; item < historico.Lista.Count; item++)
                {
                    GridListaHistorico.Rows.Add(
                    historico.Lista[item].Id,
                    historico.Lista[item].Login,
                    historico.Lista[item].Operacao,
                    historico.Lista[item].Modulo,
                    historico.Lista[item].Data,
                    historico.Lista[item].Hora,
                    historico.Lista[item].DadosRegistroAfetado);
                }

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
                BllUsuarioHistorico historico = new BllUsuarioHistorico();
                historico.Consultar(TxtBuscarLogin.Text, Convert.ToDateTime(TxtBuscaDataInicio.Value).ToString("dd-MM-yyyy"), 
                Convert.ToDateTime(TxtBuscaDataFinal.Value).ToString("dd-MM-yyyy"), quantidadeRegistros);

                GridListaHistorico.Rows.Clear();

                for (int item = 0; item < historico.Lista.Count; item++)
                {
                    GridListaHistorico.Rows.Add(
                    historico.Lista[item].Id,
                    historico.Lista[item].Login,
                    historico.Lista[item].Operacao,
                    historico.Lista[item].Modulo,
                    historico.Lista[item].Data,
                    historico.Lista[item].Hora,
                    historico.Lista[item].DadosRegistroAfetado);
                }

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
            DefinirGridColumn();

            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridListaHistorico);

            LblDataLong.Text = DateTime.Now.ToLongDateString();

        }
        #endregion

        #region DefinirGridColumn
        private void DefinirGridColumn()
        {
            try
            {
                DataGridViewTextBoxColumn historicoIdColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn loginColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn operacaoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn moduloColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dataColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn horaColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn dadosRegistroAfetadoColumn = new DataGridViewTextBoxColumn();
                //DataGridViewImageColumn btnEditar = new DataGridViewImageColumn();
                //DataGridViewImageColumn btnDeletar = new DataGridViewImageColumn();

                DataGridView dtg = GridListaHistorico;

                dtg.Columns.Add(historicoIdColumn);
                dtg.Columns[0].Name = "historicoIdColumn";
                dtg.Columns[0].HeaderText = "ID";
                dtg.Columns[0].ReadOnly = true;

                dtg.Columns.Add(loginColumn);
                dtg.Columns[1].Name = "loginColumn";
                dtg.Columns[1].Width = 130;
                dtg.Columns[1].HeaderText = "LOGIN";
                dtg.Columns[1].ReadOnly = true;

                dtg.Columns.Add(operacaoColumn);
                dtg.Columns[2].Name = "operacaoColumn";
                dtg.Columns[2].HeaderText = "OPERAÇÃO";
                dtg.Columns[2].ReadOnly = true;

                dtg.Columns.Add(moduloColumn);
                dtg.Columns[3].Name = "moduloColumn";
                dtg.Columns[3].HeaderText = "MÓDULO";
                dtg.Columns[3].ReadOnly = true;

                dtg.Columns.Add(dataColumn);
                dtg.Columns[4].Name = "dataColumn";
                dtg.Columns[4].HeaderText = "DATA";
                dtg.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
                dtg.Columns[4].ReadOnly = true;

                dtg.Columns.Add(horaColumn);
                dtg.Columns[5].Name = "horaColumn";
                dtg.Columns[5].HeaderText = "HÓRA";
                dtg.Columns[5].ReadOnly = true;

                dtg.Columns.Add(dadosRegistroAfetadoColumn);
                dtg.Columns[6].Name = "dadosRegistroAfetadoColumn";
                dtg.Columns[6].HeaderText = "DADOS DO REGISTRO AFETADO";
                dtg.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg.Columns[6].ReadOnly = false;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }
        #endregion
    }
}
