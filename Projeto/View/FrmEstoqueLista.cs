using Microsoft.Reporting.WinForms;
using Syncfusion.Windows.Forms.Tools;
using SysEstoque.Auxiliary;
using SysEstoque.Business;
using SysEstoque.Properties;
using SysEstoque.Relatorio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SysEstoque.View
{
    public partial class FrmEstoqueLista : Form
    {
        #region Propriedades
        public int NumeroDeRegistros = 500;
        #endregion 

        #region FrmEstoqueLista()
        public FrmEstoqueLista()
        {
            InitializeComponent();
            DefinirColunasNoGrid();

            LblDataLong.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region FrmEstoqueLista_Load()
        private void FrmEstoqueLista_Load(object sender, EventArgs e)
        {
            Listar();
            ListarNumeroDeRegistros();
            ListarCboResumo();
            WindowState = FormWindowState.Maximized;
        }
        #endregion

        #region BtnAtualizar_Click()
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            ResetarControles();
            Listar();
        }
        #endregion

        #region BrnRelatorio_Click()
        private void BrnRelatorio_Click(object sender, EventArgs e)
        {
            try
            {
                BllEstoqueProduto estoque = new BllEstoqueProduto();
                FrmEstoqueRelatorio relatorio = new FrmEstoqueRelatorio();

                if (CboResumo.Text == "Todos")
                {
                    estoque.Filtrar(TxtBuscaCodigo.Text, TxtBuscaTamanho.Text, TxtBuscarReferencia.Text, TxtBuscarDescricao.Text, 500);
                }
                else
                {
                    estoque.FiltroDinamico(TxtBuscaCodigo.Text, TxtBuscaTamanho.Text, TxtBuscarReferencia.Text, TxtBuscarDescricao.Text, 500, CboResumo.Text);
                }

                relatorio.Show();
                
                relatorio.RpvEstoque.LocalReport.DataSources.Clear();
                relatorio.RpvEstoque.LocalReport.DataSources.Add(new ReportDataSource("RpvEstoqueProdutoDts", estoque.Lista));
                relatorio.RpvEstoque.RefreshReport();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ExecultarFiltros_KeyPress()
        private void ExecultarFiltros_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimerExecultaConsulta.Enabled = false;
            TimerExecultaConsulta.Enabled = true;
            PicCarregando.Visible = true;
        }
        #endregion

        #region TimerExecultaConsulta_Tick()
        private void TimerExecultaConsulta_Tick(object sender, EventArgs e)
        {
            TimerExecultaConsulta.Enabled = false;
            PicCarregando.Visible = false;

            if(CboResumo.Text == "Todos")
            {
                Filtrar(TxtBuscaCodigo.Text, TxtBuscaTamanho.Text, TxtBuscarReferencia.Text, TxtBuscarDescricao.Text);
            }
            else
            {
                FiltroDinamico(TxtBuscaCodigo.Text, TxtBuscaTamanho.Text, TxtBuscarReferencia.Text, TxtBuscarDescricao.Text, CboResumo.Text);
            }
        }
        #endregion

        #region CboResumo_SelectedIndexChanged()
        private void CboResumo_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimerExecultaConsulta.Enabled = false;
            TimerExecultaConsulta.Enabled = true;
            PicCarregando.Visible = true;
        }
        #endregion

        #region GridListaEstoque_Layout()
        private void GridListaEstoque_Layout(object sender, LayoutEventArgs e)
        {
            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridListaEstoque);
        }
        #endregion

        #region CboNumeroDeRegistros_SelectedIndexChanged()
        private void CboNumeroDeRegistros_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = CboQuantidadeDeRegistros.SelectedIndex;

                switch (itemSelected)
                {
                    case 0:
                        NumeroDeRegistros = 10;
                        break;
                    case 1:
                        NumeroDeRegistros = 25;
                        break;
                    case 2:
                        NumeroDeRegistros = 75;
                        break;
                    case 3:
                        NumeroDeRegistros = 100;
                        break;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region LblLimpar_LinkClicked()
        private void LblLimpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ResetarControles();
        }
        #endregion

        #region ListarNumeroDeRegistros()
        private void ListarNumeroDeRegistros()
        {

            List<string> itens = new List<string>
            {
                "10 Registros",
                "25 Registros",
                "75 Registros",
                "100 Registros"
            };

            CboQuantidadeDeRegistros.DataSource = itens;
            CboQuantidadeDeRegistros.Text = "100 Registros";
        }
        #endregion

        #region ListarCboResumo()
        private void ListarCboResumo()
        {
            try
            {
                List<string> itens = new List<string>
                {
                    "Todos",
                    "Alto",
                    "Baixo",
                    "Ok",
                    "Sem Resumo"
                };

                CboResumo.DataSource = itens;
                CboResumo.Text = "Todos";
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Listar()
        private void Listar()
        {
            try
            {
                BllEstoqueProduto estoqueProduto = new BllEstoqueProduto();

                estoqueProduto.Listar(NumeroDeRegistros);

                GridListaEstoque.Rows.Clear();
                for (int item = 0; item < estoqueProduto.Lista.Count; item++)
                {
                    GridListaEstoque.Rows.Add(
                    estoqueProduto.Lista[item].IdEstoque,
                    estoqueProduto.Lista[item].IdProduto,
                    estoqueProduto.Lista[item].CodigoProduto,
                    estoqueProduto.Lista[item].ReferenciaProduto,
                    estoqueProduto.Lista[item].TamanhoProduto,
                    estoqueProduto.Lista[item].DescricaoProduto,
                    estoqueProduto.Lista[item].EstoqueMin,
                    estoqueProduto.Lista[item].EstoqueMax,
                    estoqueProduto.Lista[item].QuantidadeEstoque,
                    estoqueProduto.Lista[item].ValorEstoque
                    );

                    var diretorioFotoProduto = BllProdutoFoto.PegarCaminho() + estoqueProduto.Lista[item].FotoNomeProduto;
                    ListarFotoNoGrid(GridListaEstoque, diretorioFotoProduto, item);

                    ListarResumoNoGrid(GridListaEstoque, estoqueProduto, estoqueProduto.Lista, item);

                    ListarResultadoNoGrid(GridListaEstoque, estoqueProduto, estoqueProduto.Lista, item);

                    DefinirCorResumoNoGrid(GridListaEstoque, item);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Filtrar()
        private void Filtrar(string codigo, string tamanho, string referencia, string descricao)
        {
            try
            {
                BllEstoqueProduto estoqueProduto = new BllEstoqueProduto();

                estoqueProduto.Filtrar(codigo, tamanho, referencia, descricao, NumeroDeRegistros);

                GridListaEstoque.Rows.Clear();

                for (int item = 0; item < estoqueProduto.Lista.Count; item++)
                {
                    GridListaEstoque.Rows.Add(
                    estoqueProduto.Lista[item].IdEstoque,
                    estoqueProduto.Lista[item].IdProduto,
                    estoqueProduto.Lista[item].CodigoProduto,
                    estoqueProduto.Lista[item].ReferenciaProduto,
                    estoqueProduto.Lista[item].TamanhoProduto,
                    estoqueProduto.Lista[item].DescricaoProduto,
                    estoqueProduto.Lista[item].EstoqueMin,
                    estoqueProduto.Lista[item].EstoqueMax,
                    estoqueProduto.Lista[item].QuantidadeEstoque,
                    estoqueProduto.Lista[item].ValorEstoque
                    );

                    var diretorioFotoProduto = BllProdutoFoto.PegarCaminho() + estoqueProduto.Lista[item].FotoNomeProduto;
                    ListarFotoNoGrid(GridListaEstoque, diretorioFotoProduto, item);

                    ListarResumoNoGrid(GridListaEstoque, estoqueProduto, estoqueProduto.Lista, item);

                    ListarResultadoNoGrid(GridListaEstoque, estoqueProduto, estoqueProduto.Lista, item);

                    DefinirCorResumoNoGrid(GridListaEstoque, item);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region FiltroDinamico()
        private void FiltroDinamico(string codigo, string tamanho, string referencia, string descricao, string resumo)
        {
            try
            {
                BllEstoqueProduto estoqueProduto = new BllEstoqueProduto();

                estoqueProduto.FiltroDinamico(codigo, tamanho, referencia, descricao, NumeroDeRegistros, resumo);

                GridListaEstoque.Rows.Clear();

                for (int item = 0; item < estoqueProduto.Lista.Count; item++)
                {
                    GridListaEstoque.Rows.Add(
                    estoqueProduto.Lista[item].IdEstoque,
                    estoqueProduto.Lista[item].IdProduto,
                    estoqueProduto.Lista[item].CodigoProduto,
                    estoqueProduto.Lista[item].ReferenciaProduto,
                    estoqueProduto.Lista[item].TamanhoProduto,
                    estoqueProduto.Lista[item].DescricaoProduto,
                    estoqueProduto.Lista[item].EstoqueMin,
                    estoqueProduto.Lista[item].EstoqueMax,
                    estoqueProduto.Lista[item].QuantidadeEstoque,
                    estoqueProduto.Lista[item].ValorEstoque
                    );

                    var diretorioFotoProduto = BllProdutoFoto.PegarCaminho() + estoqueProduto.Lista[item].FotoNomeProduto;
                    ListarFotoNoGrid(GridListaEstoque, diretorioFotoProduto, item);

                    ListarResumoNoGrid(GridListaEstoque, estoqueProduto, estoqueProduto.Lista, item);

                    ListarResultadoNoGrid(GridListaEstoque, estoqueProduto, estoqueProduto.Lista, item);

                    DefinirCorResumoNoGrid(GridListaEstoque, item);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ChamarTodosResetes()
        private void ChamarTodosResetes()
        {
            ResetarVariaveis();
            ResetarControles();
        }

        #endregion

        #region ResetarVariaveis()
        private void ResetarVariaveis()
        {
            NumeroDeRegistros = 100;
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
                        ctl.Text = string.Empty;
                }

                TxtBuscaCodigo.Select();
                CboResumo.Text = "Todos";
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region ListarFotoNoGrid()
        private void ListarFotoNoGrid(DataGridView dataGrid, string productPhoto, int item)
        {
            if (BllProdutoFoto.EncontrarArquivo(productPhoto) == true)
            {
                using (FileStream file = new FileStream(productPhoto, FileMode.Open, FileAccess.Read))
                {
                    dataGrid.Rows[item].Cells["ImgFotoColumn"].Value = Image.FromStream(file);
                }
            }
        }
        #endregion

        #region ListarResumoNoGrid()
        private void ListarResumoNoGrid(DataGridView dataGrid, BllEstoqueProduto estoqueProduto, List<BllEstoqueProduto> listaEstoqueProduto, int item)
        {
            var listItem = listaEstoqueProduto[item];
            dataGrid.Rows[item].Cells["ResumoColumn"].Value = estoqueProduto.ObterResumo(
            listItem.QuantidadeEstoque, listItem.EstoqueMin, listItem.EstoqueMax);
        }
        #endregion

        #region ListarResultadoNoGrid()
        private void ListarResultadoNoGrid(DataGridView dataGrid, BllEstoqueProduto estoqueProduto, List<BllEstoqueProduto> listaEstoqueProduto, int item)
        {
            var listItem = listaEstoqueProduto[item];
            dataGrid.Rows[item].Cells["ResultadoColumn"].Value = estoqueProduto.ObterResultado(
            listItem.QuantidadeEstoque, listItem.EstoqueMin, listItem.EstoqueMax);
        }
        #endregion 

        #region DefinirCorResumoNoGrid()
        private void DefinirCorResumoNoGrid(DataGridView dataGrid, int item)
        {

            if (dataGrid.Rows[item].Cells["ResumoColumn"].Value.ToString() == "Ok")
            {
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.BackColor = Color.FromArgb(95, 190, 133);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.SelectionBackColor = Color.FromArgb(95, 190, 133);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.SelectionForeColor = Color.FromArgb(255, 255, 255);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.ForeColor = Color.FromArgb(255, 255, 255);
            }

            if (dataGrid.Rows[item].Cells["ResumoColumn"].Value.ToString() == "Alto")
            {
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.BackColor = Color.FromArgb(209, 73, 73);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.SelectionBackColor = Color.FromArgb(209, 73, 73);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.SelectionForeColor = Color.FromArgb(255, 255, 255);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.ForeColor = Color.FromArgb(255, 255, 255);
            }

            if (dataGrid.Rows[item].Cells["ResumoColumn"].Value.ToString() == "Baixo")
            {
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.BackColor = Color.FromArgb(201, 181, 74);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.SelectionBackColor = Color.FromArgb(201, 181, 74);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.SelectionForeColor = Color.FromArgb(255, 255, 255);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.ForeColor = Color.FromArgb(255, 255, 255);
            }

            if (dataGrid.Rows[item].Cells["ResumoColumn"].Value.ToString() == "???")
            {
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.BackColor = Color.FromArgb(145, 145, 145);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.SelectionBackColor = Color.FromArgb(145, 145, 145);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.SelectionForeColor = Color.FromArgb(255, 255, 255);
                dataGrid.Rows[item].Cells["ResumoColumn"].Style.ForeColor = Color.FromArgb(255, 255, 255);
            }
        }
        #endregion

        #region DefinirColunasNoGrid()
        private void DefinirColunasNoGrid()
        {
            try
            {
                DataGridViewTextBoxColumn IdEstoqueColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn IdProdutoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn CodigoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn ReferenciaColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn TamanhoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn DescricaoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn EstoqueMinColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn EstoqueMaxColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn QuantidadeColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn ValorColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn ResumoColumn = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn ResultadoColumn = new DataGridViewTextBoxColumn();
                DataGridViewImageColumn ImgFotoColumn = new DataGridViewImageColumn();
                //DataGridViewImageColumn BtnEditarColumn = new DataGridViewImageColumn();
                //DataGridViewImageColumn BtnDeletarColumn = new DataGridViewImageColumn();

                DataGridView dtg = GridListaEstoque;

                dtg.Columns.Add(IdEstoqueColumn);
                dtg.Columns[0].Name = "IdEstoqueColumn";
                dtg.Columns[0].HeaderText = "ID";
                dtg.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[0].Visible = false;
                dtg.Columns[0].ReadOnly = true;

                dtg.Columns.Add(IdProdutoColumn);
                dtg.Columns[1].Name = "IdProdutoColumn";
                dtg.Columns[1].HeaderText = "ID PRODUTO";
                dtg.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[1].Visible = false;
                dtg.Columns[1].ReadOnly = true;

                dtg.Columns.Add(CodigoColumn);
                dtg.Columns[2].Name = "CodigoColumn";
                dtg.Columns[2].HeaderText = "CÓDIGO PRODUTO";
                dtg.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[2].Visible = true;
                dtg.Columns[2].ReadOnly = true;
                dtg.Columns[2].Width = 80;

                dtg.Columns.Add(ReferenciaColumn);
                dtg.Columns[3].Name = "ReferenciaColumn";
                dtg.Columns[3].HeaderText = "REFERÊNCIA";
                dtg.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[3].Visible = true;
                dtg.Columns[3].ReadOnly = true;
                dtg.Columns[3].Width = 80;

                dtg.Columns.Add(TamanhoColumn);
                dtg.Columns[4].Name = "TamanhoColumn";
                dtg.Columns[4].HeaderText = "TAMANHO";
                dtg.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[4].Visible = true;
                dtg.Columns[4].ReadOnly = true;
                dtg.Columns[4].DisplayIndex = 3;
                dtg.Columns[4].Width = 80;

                dtg.Columns.Add(DescricaoColumn);
                dtg.Columns[5].Width = 200;
                dtg.Columns[5].Name = "DescricaoColumn";
                dtg.Columns[5].HeaderText = "DESCRIÇÃO";
                dtg.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dtg.Columns[5].ReadOnly = true;

                dtg.Columns.Add(EstoqueMinColumn);
                dtg.Columns[6].Width = 100;
                dtg.Columns[6].Name = "EstoqueMinColumn";
                dtg.Columns[6].HeaderText = "ESTOQUE MIN.";
                dtg.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[6].ReadOnly = true;

                dtg.Columns.Add(EstoqueMaxColumn);
                dtg.Columns[7].Width = 100;
                dtg.Columns[7].Name = "EstoqueMaxColumn";
                dtg.Columns[7].HeaderText = "ESTOQUE MAX.";
                dtg.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[7].ReadOnly = true;

                dtg.Columns.Add(QuantidadeColumn);
                dtg.Columns[8].Width = 100;
                dtg.Columns[8].Name = "QuantidadeColumn";
                dtg.Columns[8].HeaderText = "QTD. ESTOQUE";
                dtg.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[8].ReadOnly = true;

                dtg.Columns.Add(ValorColumn);
                dtg.Columns[9].Width = 100;
                dtg.Columns[9].Name = "ValorColumn";
                dtg.Columns[9].HeaderText = "VALOR";
                dtg.Columns[9].DefaultCellStyle.Format = "c2";
                dtg.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dtg.Columns[9].DisplayIndex = 6;
                dtg.Columns[9].ReadOnly = true;

                //dtg.Columns.Add(BtnEditarColumn);
                //BtnEditarColumn.Image = Resources.Editar;
                //BtnEditarColumn.ToolTipText = "Editar";
                //BtnEditarColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                //dtg.Columns[10].Name = "BtnEditarColumn";
                //dtg.Columns[10].HeaderText = "";
                //dtg.Columns[10].Width = 70;
                //dtg.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dtg.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dtg.Columns[10].ReadOnly = true;

                //dtg.Columns.Add(BtnDeletarColumn);
                //BtnDeletarColumn.ToolTipText = "Deletar";
                //BtnDeletarColumn.Image = Resources.Deletar;
                //BtnDeletarColumn.ImageLayout = DataGridViewImageCellLayout.Normal;
                //dtg.Columns[11].Name = "BtnDeletarColumn";
                //dtg.Columns[11].HeaderText = "";
                //dtg.Columns[11].Width = 70;
                //dtg.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dtg.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dtg.Columns[11].ReadOnly = true;

                dtg.Columns.Add(ImgFotoColumn);
                ImgFotoColumn.Image = Resources.FotoNothing;
                ImgFotoColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dtg.Columns[10].Name = "ImgFotoColumn";
                dtg.Columns[10].HeaderText = "FOTO";
                dtg.Columns[10].Width = 40;
                dtg.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[10].DisplayIndex = 0;
                dtg.Columns[10].ReadOnly = true;

                dtg.Columns.Add(ResumoColumn);
                dtg.Columns[11].Width = 100;
                dtg.Columns[11].Name = "ResumoColumn";
                dtg.Columns[11].HeaderText = "RESUMO";
                dtg.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[11].DisplayIndex = 11;
                dtg.Columns[11].ReadOnly = true;

                dtg.Columns.Add(ResultadoColumn);
                dtg.Columns[12].Width = 100;
                dtg.Columns[12].Name = "ResultadoColumn";
                dtg.Columns[12].HeaderText = "RESULTADO";
                dtg.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[12].DisplayIndex = 12;
                dtg.Columns[12].ReadOnly = true;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }
        #endregion

    }

}
