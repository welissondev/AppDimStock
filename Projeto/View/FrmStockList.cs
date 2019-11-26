using System;
using Syncfusion.Windows.Forms.Tools;
using DimStock.Auxiliary;
using DimStock.Business;
using DimStock.Properties;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DimStock.View
{
    public partial class FrmStockList : Form
    {
        #region Properties
        private AxlDataPagination dataPagination = new AxlDataPagination();
        #endregion

        #region Constructors

        #region FrmEstoqueLista()
        public FrmStockList()
        {
            InitializeComponent();

            ConfigureDataPagination();

            CreateColumnsInTheDataGrid();

            LblDataLong.Text = DateTime.Now.ToLongDateString();

            WindowState = FormWindowState.Maximized;
        }
        #endregion

        #endregion

        #region UserForm

        #region FrmEstoqueLista_Load()
        private void FrmEstoqueLista_Load(object sender, EventArgs e)
        {
            ListItemsInSummary();

            ListItemsInPageSize();

            ListDataGrid(FetchData());
        }
        #endregion

        #endregion

        #region Button

        #region BtnAtualizar_Click()
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            ResetControl();
            ConfigureDataPagination();
            ListDataGrid(FetchData());
        }
        #endregion

        #region BrnReport_Click()
        private void BrnReport_Click(object sender, EventArgs e)
        {
            try
            {
                var estoqueProduto = new BllStockProduct();

                estoqueProduto.GenerateReport(TxtCode.Text, TxtSize.Text,
                TxtReference.Text, TxtDescription.Text,
                CboResume.Text);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #endregion

        #region TextBox

        #region RunSearch_KeyPress()
        private void RunSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataPagination.CurrentPage = 1;
            dataPagination.OffSetValue = 0;
            TimeStartSearch();
        }
        #endregion

        #endregion

        #region Timer

        #region Timer_Tick()
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeStopSearch();
            ListDataGrid(FetchData());
        }
        #endregion

        #endregion

        #region ComboBox

        #region CboResume_SelectedIndexChanged()
        private void CboResume_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
            TimeStartSearch();
        }
        #endregion

        #region CboPageSize_SelectedIndexChanged()
        private void CboPageSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = CboPageSize.SelectedIndex;

                switch (itemSelected)
                {
                    case 0:
                        dataPagination.PageSize = 20;
                        break;
                    case 1:
                        dataPagination.PageSize = 30;
                        break;
                    case 2:
                        dataPagination.PageSize = 70;
                        break;
                    case 3:
                        dataPagination.PageSize = 100;
                        break;
                }

                dataPagination.OffSetValue = 0;
                dataPagination.CurrentPage = 1;
                TimeStartSearch();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #endregion

        #region DataGridView

        #region StockDataGrid_CellFormatting()
        private void StockDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (StockDataGrid.Columns[e.ColumnIndex].Name == "ResumoColumn")
                {
                    if (e.Value.GetType() != typeof(DBNull))
                    {
                        if (e.Value.ToString() == "OK")
                        {
                            e.CellStyle.BackColor = Color.FromArgb(95, 190, 133);
                            e.CellStyle.SelectionBackColor = Color.FromArgb(95, 190, 133);
                            e.CellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
                            e.CellStyle.ForeColor = Color.FromArgb(255, 255, 255);
                        }

                        if (e.Value.ToString() == "Alto")
                        {
                            e.CellStyle.BackColor = Color.FromArgb(209, 73, 73);
                            e.CellStyle.SelectionBackColor = Color.FromArgb(209, 73, 73);
                            e.CellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
                            e.CellStyle.ForeColor = Color.FromArgb(255, 255, 255);
                        }

                        if (e.Value.ToString() == "Baixo")
                        {
                            e.CellStyle.BackColor = Color.FromArgb(201, 181, 74);
                            e.CellStyle.SelectionBackColor = Color.FromArgb(201, 181, 74);
                            e.CellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
                            e.CellStyle.ForeColor = Color.FromArgb(255, 255, 255);
                        }

                        if (e.Value.ToString() == "???")
                        {
                            e.CellStyle.BackColor = Color.FromArgb(145, 145, 145);
                            e.CellStyle.SelectionBackColor = Color.FromArgb(145, 145, 145);
                            e.CellStyle.SelectionForeColor = Color.FromArgb(255, 255, 255);
                            e.CellStyle.ForeColor = Color.FromArgb(255, 255, 255);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region StockDataGrid_Layout()
        private void StockDataGrid_Layout(object sender, LayoutEventArgs e)
        {
            AxlDataGridViewLealt.DefaultLayoutDarkblue(StockDataGrid);
        }
        #endregion

        #endregion

        #region Label

        #region LblLimpar_LinkClicked()
        private void LblLimpar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataPagination.CurrentPage = 1;
            dataPagination.OffSetValue = 0;
            ResetControl();
            TimeStartSearch();
        }
        #endregion

        #endregion

        #region BindingNavigator

        #region NextPage_Click()
        private void NextPage_Click(object sender, EventArgs e)
        {
            if (dataPagination.CurrentPage < dataPagination.CountTotalPages())
            {
                dataPagination.CurrentPage += 1;
                dataPagination.OffSetValue += dataPagination.PageSize;
                TimeStartSearch();
            }

            SetInBadingNavigator();
        }
        #endregion

        #region BackPage_Click()
        private void BackPage_Click(object sender, EventArgs e)
        {
            if (dataPagination.CurrentPage > 1)
            {
                dataPagination.CurrentPage -= 1;
                dataPagination.OffSetValue -= dataPagination.PageSize;
                TimeStartSearch();
            }

            SetInBadingNavigator();
        }
        #endregion

        #region FinalPage_Click()
        private void FinalPage_Click(object sender, EventArgs e)
        {
            dataPagination.OffSetValue = dataPagination.PageSize * dataPagination.NumberOfPages;
            TimeStartSearch();
        }
        #endregion

        #region HomePage_Click()
        private void HomePage_Click(object sender, EventArgs e)
        {
            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
            TimeStartSearch();
        }
        #endregion

        #endregion

        #region Methods

        #region FetchData()
        private List<BllStockProduct> FetchData()
        {
            var stockProduct = new BllStockProduct();

            try
            {
                stockProduct.FetchData(TxtCode.Text, TxtSize.Text, TxtReference.Text, TxtDescription.Text,
                CboResume.Text, dataPagination.OffSetValue, dataPagination.PageSize);

                dataPagination.RecordCount = stockProduct.RecordCount;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

            return stockProduct.ListOfRecords;
        }
        #endregion

        #region ListDataGrid()
        private void ListDataGrid(List<BllStockProduct> listaDeEstoque)
        {
            try
            {
                StockDataGrid.Rows.Clear();

                var ls = listaDeEstoque;

                for (int i = 0; i < listaDeEstoque.Count; i++)
                {
                    StockDataGrid.Rows.Add(
                    ls[i].StockId,
                    ls[i].ProductId,
                    ls[i].ProductCode,
                    ls[i].ProductReference,
                    ls[i].ProductSize,
                    ls[i].ProductDescription,
                    ls[i].MinStock,
                    ls[i].MaxStock,
                    ls[i].StockQuantity,
                    ls[i].StockValue,
                    ls[i].StockResume,
                    ls[i].StockResult);
                }

                SetPhoto(ls);

                SetInBadingNavigator();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ListItemsInPageSize()
        private void ListItemsInPageSize()
        {

            List<string> itens = new List<string>
            {
                "20 Registros",
                "30 Registros",
                "70 Registros",
                "100 Registros"
            };

            CboPageSize.DataSource = itens;
            CboPageSize.Text = "20 Registros";
        }
        #endregion

        #region ListItemsInSummary()
        private void ListItemsInSummary()
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

                CboResume.DataSource = itens;
                CboResume.Text = "Todos";
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region SetPhoto()
        private void SetPhoto(List<BllStockProduct> listaDeRegistros)
        {
            try
            {
                var ls = listaDeRegistros;

                for (int i = 0; i < ls.Count; i++)
                {
                    if (BllProdutoFoto.EncontrarArquivo(ls[i].ProductPhotoName) == true)
                    {
                        using (FileStream file = new FileStream(ls[i].ProductPhotoName, FileMode.Open, FileAccess.Read))
                        {
                            StockDataGrid.Rows[i].Cells["ImgFotoColumn"].Value = Image.FromStream(file);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }
        #endregion

        #region CallAllResets()
        private void CallAllResets()
        {
            ResetVariables();
            ResetControl();
        }

        #endregion

        #region ResetVariables()
        private void ResetVariables()
        {
            dataPagination.PageSize = 10;
            dataPagination.OffSetValue = 0;
        }
        #endregion

        #region ResetControl()
        private void ResetControl()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;
                }

                TxtCode.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region CreateColumnsInTheDataGrid()
        private void CreateColumnsInTheDataGrid()
        {
            try
            {
                var IdEstoqueColumn = new DataGridViewTextBoxColumn();
                var IdProdutoColumn = new DataGridViewTextBoxColumn();
                var CodigoColumn = new DataGridViewTextBoxColumn();
                var ReferenciaColumn = new DataGridViewTextBoxColumn();
                var TamanhoColumn = new DataGridViewTextBoxColumn();
                var DescricaoColumn = new DataGridViewTextBoxColumn();
                var EstoqueMinColumn = new DataGridViewTextBoxColumn();
                var EstoqueMaxColumn = new DataGridViewTextBoxColumn();
                var QuantidadeColumn = new DataGridViewTextBoxColumn();
                var ValorColumn = new DataGridViewTextBoxColumn();
                var ResumoColumn = new DataGridViewTextBoxColumn();
                var ResultadoColumn = new DataGridViewTextBoxColumn();
                var ImgFotoColumn = new DataGridViewImageColumn();

                var dtg = StockDataGrid;

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
                dtg.Columns[2].HeaderText = "CÓDIGO";
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

                dtg.Columns.Add(ResumoColumn);
                dtg.Columns[10].Width = 100;
                dtg.Columns[10].Name = "ResumoColumn";
                dtg.Columns[10].HeaderText = "RESUMO";
                dtg.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[10].ReadOnly = true;

                dtg.Columns.Add(ResultadoColumn);
                dtg.Columns[11].Width = 100;
                dtg.Columns[11].Name = "ResultadoColumn";
                dtg.Columns[11].HeaderText = "RESULTADO";
                dtg.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[11].ReadOnly = true;

                dtg.Columns.Add(ImgFotoColumn);
                ImgFotoColumn.Image = Resources.FotoNothing;
                ImgFotoColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dtg.Columns[12].Name = "ImgFotoColumn";
                dtg.Columns[12].HeaderText = "FOTO";
                dtg.Columns[12].Width = 40;
                dtg.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dtg.Columns[12].DisplayIndex = 0;
                dtg.Columns[12].ReadOnly = true;


            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }
        #endregion

        #region ConfigureDataPagination()
        public void ConfigureDataPagination()
        {
            dataPagination.PageSize = 20;

            dataPagination.OffSetValue = 0;

            dataPagination.CurrentPage = 1;
        }
        #endregion

        #region SetInBadingNavigator()
        public void SetInBadingNavigator()
        {
            var legend = " Página " + dataPagination.CurrentPage + " de " + dataPagination.CountTotalPages().ToString();
            BindingNavigatorPaginacao.Items[2].Text = legend;

            legend = " Total de " + dataPagination.RecordCount + " registro(s)";
            BindingNavigatorPaginacao.Items[6].Text = legend;
        }
        #endregion

        #region TimeStartSearch()
        private void TimeStartSearch()
        {
            ImgGifLoading.Visible = true;
            Timer.Enabled = false;
            Timer.Enabled = true;
        }
        #endregion

        #region TimeStopSearch()
        public void TimeStopSearch()
        {
            ImgGifLoading.Visible = false;
            Timer.Enabled = false;
        }
        #endregion

        #endregion
    }
}
