using DimStock.Auxiliarys;
using DimStock.Models;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class StockListingForm : Form
    {
        #region Builder

        public StockListingForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region Properties
        private AxlDataPage pagination = new AxlDataPage();
        private string selectedSummary = "All";
        #endregion

        #region Form

        private void StockListingForm_Load(object sender, EventArgs e)
        {
            StartSearchTimer();
        }

        #endregion

        #region Button

        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var stock = new StockModel()
                {
                    Summary = selectedSummary
                };

                stock.Product.InternalCode = TextSearchByCode.Text;
                stock.Product.Description = TextSearchByDescription.Text;

                stock.GenerateReport(stock.List);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ButtonDataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        #endregion

        #region TextBox

        private void TextSearchFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            pagination.CurrentPage = 1;
            pagination.OffSetValue = 0;
            StartSearchTimer();
        }

        #endregion

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            PauseSearchTimer();
            FetchData();
        }

        #endregion

        #region ComboBox

        private void ComboBoxSummaries_SelectedIndexChanged(object sender, EventArgs e)
        {

            var itemSelected = ComBoxSummaries.SelectedIndex;

            switch (itemSelected)
            {
                case 0:
                    selectedSummary = "All";
                    break;
                case 1:
                    selectedSummary = "High";
                    break;
                case 2:
                    selectedSummary = "Low";
                    break;

                case 3:
                    selectedSummary = "Ok";
                    break;
                case 4:
                    selectedSummary = "Nothing";
                    break;
            }

            pagination.OffSetValue = 0;
            pagination.CurrentPage = 1;
            StartSearchTimer();
        }

        private void ComboBoxRecordsByPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = ComboBoxRecordsByPage.SelectedIndex;

                switch (itemSelected)
                {
                    case 0:
                        pagination.PageSize = 20;
                        break;
                    case 1:
                        pagination.PageSize = 30;
                        break;
                    case 2:
                        pagination.PageSize = 70;
                        break;
                    case 3:
                        pagination.PageSize = 100;
                        break;
                }

                pagination.OffSetValue = 0;
                pagination.CurrentPage = 1;
                StartSearchTimer();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region DataGrid

        private void DatagridStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (DatagridStock.Columns[e.ColumnIndex].Name == "stockSummary")
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

        private void DatagridStock_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridStock.Rows[e.RowIndex].Selected = true;
            }
        }

        #endregion

        #region LabelLink

        private void ButtonClearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pagination.CurrentPage = 1;
            pagination.OffSetValue = 0;
            ResetControl();
            StartSearchTimer();
        }

        #endregion

        #region BindingNavigator

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (pagination.CurrentPage < pagination.NumberOfPages)
            {
                pagination.CurrentPage += 1;
                pagination.OffSetValue += pagination.PageSize;
                StartSearchTimer();
            }

            SetInBadingNavigator(pagination);
        }

        private void BackPage_Click(object sender, EventArgs e)
        {
            if (pagination.CurrentPage > 1)
            {
                pagination.CurrentPage -= 1;
                pagination.OffSetValue -= pagination.PageSize;
                StartSearchTimer();
            }

            SetInBadingNavigator(pagination);
        }

        #endregion

        #region Function

        private void FetchData()
        {
            try
            {
                var stock = new StockModel(pagination)
                {
                    Summary = selectedSummary
                };

                stock.Product.InternalCode = TextSearchByCode.Text;
                stock.Product.Description = TextSearchByDescription.Text;

                stock.FetchData();

                DatagridStock.Rows.Clear();

                for (int i = 0; i < stock.List.Count; i++)
                {
                    DatagridStock.Rows.Add(
                    stock.List[i].Id,
                    stock.List[i].Product.Id,
                    stock.List[i].Product.InternalCode,
                    stock.List[i].Product.Description,
                    stock.List[i].Min,
                    stock.List[i].Max,
                    stock.List[i].Quantity,
                    stock.List[i].TotalValue,
                    stock.List[i].Summary,
                    stock.List[i].Result);
                }

                DatagridStock.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(pagination);

            }
            catch (Exception ex)
            {
                PauseSearchTimer();

                AxlException.Message.Show(ex);
            }
        }

        private void FillAllComboBoxes()
        {

            var pageSizeItemList = new List<string>
            {
                "20 Registros",
                "30 Registros",
                "70 Registros",
                "100 Registros"
            };

            ComboBoxRecordsByPage.DataSource = pageSizeItemList;
            ComboBoxRecordsByPage.Text = "20 Registros";


            var resumeListItem = new List<string>
            {
                "Todos",
                "Alto",
                "Baixo",
                "Ok",
                "Sem Resumo"
            };

            ComBoxSummaries.DataSource = resumeListItem;
            ComBoxSummaries.Text = "Todos";

        }

        private void CallAllResets()
        {
            ResetProperties();
            ResetControl();
        }

        private void ResetProperties()
        {
            pagination.OffSetValue = 0;
            pagination.CurrentPage = 1;
        }

        private void ResetControl()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;
                }

                TextSearchByCode.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void InitializeSettings()
        {
            CreateColumnInTheDataList();

            AxlDataGridLealt.SetDefaultStyle(DatagridStock);

            FillAllComboBoxes();
        }

        private void SetInBadingNavigator(AxlDataPage pagination)
        {
            if (pagination.RecordCount == 0)
                pagination.CurrentPage = 0;

            var legend = " Página " + pagination.CurrentPage + " de " + pagination.NumberOfPages;
            BindingPagination.Items[2].Text = legend;

            legend = " Total de " + pagination.RecordCount + " registro(s)";
            BindingPagination.Items[6].Text = legend;
        }

        private void StartSearchTimer()
        {
            PictureLoading.Visible = true;
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
        }

        private void PauseSearchTimer()
        {
            PictureLoading.Visible = false;
            SearchTimer.Enabled = false;
        }

        private void CreateColumnInTheDataList()
        {
            try
            {
                var stockId = new DataGridViewTextBoxColumn();
                var productId = new DataGridViewTextBoxColumn();
                var internalCode = new DataGridViewTextBoxColumn();
                var productDescription = new DataGridViewTextBoxColumn();
                var minStock = new DataGridViewTextBoxColumn();
                var maxStock = new DataGridViewTextBoxColumn();
                var stockQuantity = new DataGridViewTextBoxColumn();
                var stockValue = new DataGridViewTextBoxColumn();
                var stockSummary = new DataGridViewTextBoxColumn();
                var stockResult = new DataGridViewTextBoxColumn();

                var dataGrid = DatagridStock;

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

                dataGrid.Columns.Add(internalCode);
                dataGrid.Columns[2].Name = "internalCode";
                dataGrid.Columns[2].HeaderText = "CÓDIGO.";
                dataGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[2].Visible = true;
                dataGrid.Columns[2].ReadOnly = true;
                dataGrid.Columns[2].Width = 80;

                dataGrid.Columns.Add(productDescription);
                dataGrid.Columns[3].Width = 200;
                dataGrid.Columns[3].Name = "productDescription";
                dataGrid.Columns[3].HeaderText = "DESCRIÇÃO";
                dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[3].ReadOnly = true;

                dataGrid.Columns.Add(minStock);
                dataGrid.Columns[4].Width = 70;
                dataGrid.Columns[4].Name = "minStock";
                dataGrid.Columns[4].HeaderText = "MIN.";
                dataGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].ReadOnly = true;

                dataGrid.Columns.Add(maxStock);
                dataGrid.Columns[5].Width = 70;
                dataGrid.Columns[5].Name = "maxStock";
                dataGrid.Columns[5].HeaderText = "MAX.";
                dataGrid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[5].ReadOnly = true;

                dataGrid.Columns.Add(stockQuantity);
                dataGrid.Columns[6].Width = 70;
                dataGrid.Columns[6].Name = "stockQuantity";
                dataGrid.Columns[6].HeaderText = "QTD.";
                dataGrid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[6].ReadOnly = true;

                dataGrid.Columns.Add(stockValue);
                dataGrid.Columns[7].Width = 120;
                dataGrid.Columns[7].Name = "stockValue";
                dataGrid.Columns[7].HeaderText = "VALOR";
                dataGrid.Columns[7].DefaultCellStyle.Format = "c2";
                dataGrid.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[7].DisplayIndex = 6;
                dataGrid.Columns[7].ReadOnly = true;

                dataGrid.Columns.Add(stockSummary);
                dataGrid.Columns[8].Width = 80;
                dataGrid.Columns[8].Name = "stockSummary";
                dataGrid.Columns[8].HeaderText = "RESUMO";
                dataGrid.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[8].ReadOnly = true;
                dataGrid.Columns[8].DisplayIndex = 0;

                dataGrid.Columns.Add(stockResult);
                dataGrid.Columns[9].Width = 80;
                dataGrid.Columns[9].Name = "stockResult";
                dataGrid.Columns[9].HeaderText = "RESULTADO";
                dataGrid.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[9].ReadOnly = true;
                dataGrid.Columns[9].DisplayIndex = 1;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }

        #endregion
    }
}
