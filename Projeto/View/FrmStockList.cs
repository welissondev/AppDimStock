﻿using System;
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

        #region FrmStockList()
        public FrmStockList()
        {
            InitializeComponent();

            ConfigureDataPagination();

            CreateColumnsInTheDataGrid();

            LblDataLong.Text = DateTime.Now.ToLongDateString();

        }
        #endregion

        #endregion

        #region UserForm

        #region FrmStockList_Load()
        private void FrmStockList_Load(object sender, EventArgs e)
        {
            ListItemsInSummary();

            ListItemsInPageSize();

            ListDataGrid(FetchData());

            WindowState = FormWindowState.Maximized;

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

        #region BtnReport_Click()
        private void BtnReport_Click(object sender, EventArgs e)
        {
            try
            {
                var stockProduct = new BllStockProduct()
                {
                    ProductCode = TxtQueryByCode.Text,
                    ProductSize = TxtQueryBySize.Text,
                    ProductReference = TxtQueryByReference.Text,
                    ProductDescription = TxtQueryByDescription.Text,
                    StockResume = CboResume.Text
                };

                stockProduct.ListAll(); 
                stockProduct.GenerateReport(stockProduct.ListOfRecords);

                var reportPath = "DimStock.Report.RpvStockProduct.rdlc";
                var reportName = "Relatório de estoque";
                var reportDataSet = "DataSetStockProduct";

                FrmReportView.ShowReport(reportPath, reportName, true, 
                new Dictionary<string, object>() { {reportDataSet, 
                stockProduct.ListOfRecords } });
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
                if (GridStockList.Columns[e.ColumnIndex].Name == "stockResume")
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
            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridStockList);
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
            if (dataPagination.CurrentPage < dataPagination.NumberOfPages)
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
                stockProduct.ProductCode = TxtQueryByCode.Text;
                stockProduct.ProductSize = TxtQueryBySize.Text;
                stockProduct.ProductReference = TxtQueryByReference.Text;
                stockProduct.ProductDescription = TxtQueryByDescription.Text;
                stockProduct.StockResume = CboResume.Text;
                stockProduct.DataPagination = dataPagination;

                stockProduct.FetchData();
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
                GridStockList.Rows.Clear();

                var ls = listaDeEstoque;

                for (int i = 0; i < listaDeEstoque.Count; i++)
                {
                    GridStockList.Rows.Add(
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
                    if (BllProductPhotho.FindFile(ls[i].ProductPhotoName) == true)
                    {
                        using (FileStream file = new FileStream(ls[i].ProductPhotoName, FileMode.Open, FileAccess.Read))
                        {
                            GridStockList.Rows[i].Cells["photoName"].Value = Image.FromStream(file);
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

                TxtQueryByCode.Select();
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
                var stockId = new DataGridViewTextBoxColumn();
                var productId = new DataGridViewTextBoxColumn();
                var productCode = new DataGridViewTextBoxColumn();
                var productSize = new DataGridViewTextBoxColumn();
                var productReference = new DataGridViewTextBoxColumn();
                var productDescription = new DataGridViewTextBoxColumn();
                var minStock = new DataGridViewTextBoxColumn();
                var maxStock = new DataGridViewTextBoxColumn();
                var stockQuantity = new DataGridViewTextBoxColumn();
                var stockValue = new DataGridViewTextBoxColumn();
                var stockResume = new DataGridViewTextBoxColumn();
                var stockResult = new DataGridViewTextBoxColumn();
                var fothoName = new DataGridViewImageColumn();

                var dataGrid = GridStockList;

                dataGrid.Columns.Add(stockId);
                dataGrid.Columns[0].Name = "stockId";
                dataGrid.Columns[0].HeaderText = "ID";
                dataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].Visible = false;
                dataGrid.Columns[0].ReadOnly = true;

                dataGrid.Columns.Add(productId);
                dataGrid.Columns[1].Name = "productId";
                dataGrid.Columns[1].HeaderText = "ID PRODUTO";
                dataGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[1].Visible = false;
                dataGrid.Columns[1].ReadOnly = true;

                dataGrid.Columns.Add(productCode);
                dataGrid.Columns[2].Name = "productCode";
                dataGrid.Columns[2].HeaderText = "CÓDIGO";
                dataGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].Visible = true;
                dataGrid.Columns[2].ReadOnly = true;
                dataGrid.Columns[2].Width = 80;

                dataGrid.Columns.Add(productReference);
                dataGrid.Columns[3].Name = "productReference";
                dataGrid.Columns[3].HeaderText = "REFERÊNCIA";
                dataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].Visible = true;
                dataGrid.Columns[3].ReadOnly = true;
                dataGrid.Columns[3].Width = 80;

                dataGrid.Columns.Add(productSize);
                dataGrid.Columns[4].Name = "productSize";
                dataGrid.Columns[4].HeaderText = "TAMANHO";
                dataGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].Visible = true;
                dataGrid.Columns[4].ReadOnly = true;
                dataGrid.Columns[4].DisplayIndex = 3;
                dataGrid.Columns[4].Width = 80;

                dataGrid.Columns.Add(productDescription);
                dataGrid.Columns[5].Width = 200;
                dataGrid.Columns[5].Name = "productDescription";
                dataGrid.Columns[5].HeaderText = "DESCRIÇÃO";
                dataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[5].ReadOnly = true;

                dataGrid.Columns.Add(minStock);
                dataGrid.Columns[6].Width = 100;
                dataGrid.Columns[6].Name = "minStock";
                dataGrid.Columns[6].HeaderText = "ESTOQUE MIN.";
                dataGrid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[6].ReadOnly = true;

                dataGrid.Columns.Add(maxStock);
                dataGrid.Columns[7].Width = 100;
                dataGrid.Columns[7].Name = "maxStock";
                dataGrid.Columns[7].HeaderText = "ESTOQUE MAX.";
                dataGrid.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[7].ReadOnly = true;

                dataGrid.Columns.Add(stockQuantity);
                dataGrid.Columns[8].Width = 100;
                dataGrid.Columns[8].Name = "stockQuantity";
                dataGrid.Columns[8].HeaderText = "QTD. ESTOQUE";
                dataGrid.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[8].ReadOnly = true;

                dataGrid.Columns.Add(stockValue);
                dataGrid.Columns[9].Width = 100;
                dataGrid.Columns[9].Name = "stockValue";
                dataGrid.Columns[9].HeaderText = "VALOR";
                dataGrid.Columns[9].DefaultCellStyle.Format = "c2";
                dataGrid.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[9].DisplayIndex = 6;
                dataGrid.Columns[9].ReadOnly = true;

                dataGrid.Columns.Add(stockResume);
                dataGrid.Columns[10].Width = 100;
                dataGrid.Columns[10].Name = "stockResume";
                dataGrid.Columns[10].HeaderText = "RESUMO";
                dataGrid.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[10].ReadOnly = true;

                dataGrid.Columns.Add(stockResult);
                dataGrid.Columns[11].Width = 100;
                dataGrid.Columns[11].Name = "stockResult";
                dataGrid.Columns[11].HeaderText = "RESULTADO";
                dataGrid.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[11].ReadOnly = true;

                dataGrid.Columns.Add(fothoName);
                fothoName.Image = Resources.FotoNothing;
                fothoName.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGrid.Columns[12].Name = "fothoName";
                dataGrid.Columns[12].HeaderText = "FOTO";
                dataGrid.Columns[12].Width = 40;
                dataGrid.Columns[12].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[12].DisplayIndex = 0;
                dataGrid.Columns[12].ReadOnly = true;
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
            var legend = " Página " + dataPagination.CurrentPage + " de " + dataPagination.NumberOfPages;
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
