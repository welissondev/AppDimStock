using System;
using Syncfusion.Windows.Forms.Tools;
using DimStock.Auxiliarys;
using DimStock.Business;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class StockListingForm : Form
    {
        #region Properties
        private DataPagination dataPagination = new DataPagination();
        private string selectedSummary = "All";
        #endregion

        #region Constructors

        public StockListingForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region UserForm

        private void StockListingForm_Load(object sender, EventArgs e)
        {
            StartSearchTimer();
        }

        #endregion

        #region Button

        private void UpdateDataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var stockProduct = new StockProduct()
                {
                    SearchByCode = SearchByCode.Text,
                    SearchBySize = SearchBySize.Text,
                    SearchByReference = SearchByReference.Text,
                    SearchByDescription = SearchByDescription.Text,
                    SearchBySummary = selectedSummary
                };

                stockProduct.ListData();

                stockProduct.GenerateReport(
                stockProduct.ListOfRecords);

                var path = "DimStock.Report.StockProduct.rdlc";
                var description = "Relatório de estoque";
                var dataSet = "DataSetStockProduct";

                ReportViewForm.ShowReport(path, description, true,
                new Dictionary<string, object>() { {dataSet,
                stockProduct.ListOfRecords } });
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion

        #region TextBox

        private void SearchFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataPagination.CurrentPage = 1;
            dataPagination.OffSetValue = 0;
            StartSearchTimer();
        }

        #endregion

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            PauseSearchTimer();
            SearchData();
        }

        #endregion

        #region ComboBox

        private void Summaries_SelectedIndexChanged(object sender, EventArgs e)
        {

            var itemSelected = Summaries.SelectedIndex;

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

            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
            StartSearchTimer();
        }

        private void RecordsByPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = RecordsByPage.SelectedIndex;

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
                StartSearchTimer();

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion

        #region DataGridView

        private void StockDataList_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            try
            {
                if (StockDataList.Columns[e.ColumnIndex].Name == "stockSummary")
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
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion

        #region LabelLink

        private void ClearFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            dataPagination.CurrentPage = 1;
            dataPagination.OffSetValue = 0;
            ResetControl();
            StartSearchTimer();
        }

        #endregion

        #region BindingNavigator

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (dataPagination.CurrentPage < dataPagination.NumberOfPages)
            {
                dataPagination.CurrentPage += 1;
                dataPagination.OffSetValue += dataPagination.PageSize;
                StartSearchTimer();
            }

            SetInBadingNavigator(dataPagination);
        }

        private void BackPage_Click(object sender, EventArgs e)
        {
            if (dataPagination.CurrentPage > 1)
            {
                dataPagination.CurrentPage -= 1;
                dataPagination.OffSetValue -= dataPagination.PageSize;
                StartSearchTimer();
            }

            SetInBadingNavigator(dataPagination);
        }

        #endregion

        #region MethodsAuxiliarys

        private void SearchData()
        {
            try
            {
                var stockProduct = new StockProduct(dataPagination)
                {
                    SearchByCode = SearchByCode.Text,
                    SearchBySize = SearchBySize.Text,
                    SearchByReference = SearchByReference.Text,
                    SearchByDescription = SearchByDescription.Text,
                    SearchBySummary = selectedSummary
                };

                stockProduct.SearchData();

                StockDataList.Rows.Clear();

                for (int i = 0; i < stockProduct.ListOfRecords.Count; i++)
                {
                    StockDataList.Rows.Add(
                    stockProduct.ListOfRecords[i].StockId,
                    stockProduct.ListOfRecords[i].ProductId,
                    stockProduct.ListOfRecords[i].ProductCode,
                    stockProduct.ListOfRecords[i].ProductReference,
                    stockProduct.ListOfRecords[i].ProductSize,
                    stockProduct.ListOfRecords[i].ProductDescription,
                    stockProduct.ListOfRecords[i].MinStock,
                    stockProduct.ListOfRecords[i].MaxStock,
                    stockProduct.ListOfRecords[i].StockQuantity,
                    stockProduct.ListOfRecords[i].StockValue,
                    stockProduct.ListOfRecords[i].StockSummary,
                    stockProduct.ListOfRecords[i].StockResult);
                }

                StockDataList.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(dataPagination);

            }
            catch (Exception ex)
            {
                PauseSearchTimer();

                ExceptionAssistant.Message.Show(ex);
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

            RecordsByPage.DataSource = pageSizeItemList;
            RecordsByPage.Text = "20 Registros";


            var resumeListItem = new List<string>
            {
                "Todos",
                "Alto",
                "Baixo",
                "Ok",
                "Sem Resumo"
            };

            Summaries.DataSource = resumeListItem;
            Summaries.Text = "Todos";

        }

        private void CallAllResets()
        {
            ResetVariables();
            ResetControl();
        }

        private void ResetVariables()
        {
            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
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

                SearchByCode.Select();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void InitializeSettings()
        {
            CreateColumnInTheDataList();

            DataGridLealt.SetDefaultStyle(StockDataList);

            FillAllComboBoxes();
        }

        private void SetInBadingNavigator(DataPagination dataPagination)
        {
            if (dataPagination.RecordCount == 0)
                dataPagination.CurrentPage = 0;

            var legend = " Página " + dataPagination.CurrentPage + " de " + dataPagination.NumberOfPages;
            BindingPagination.Items[2].Text = legend;

            legend = " Total de " + dataPagination.RecordCount + " registro(s)";
            BindingPagination.Items[6].Text = legend;
        }

        private void StartSearchTimer()
        {
            GifLoading.Visible = true;
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
        }

        private void PauseSearchTimer()
        {
            GifLoading.Visible = false;
            SearchTimer.Enabled = false;
        }

        private void CreateColumnInTheDataList()
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
                var stockSummary = new DataGridViewTextBoxColumn();
                var stockResult = new DataGridViewTextBoxColumn();

                var dataGrid = StockDataList;

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
                dataGrid.Columns[2].HeaderText = "CÓD.";
                dataGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].Visible = true;
                dataGrid.Columns[2].ReadOnly = true;
                dataGrid.Columns[2].Width = 80;

                dataGrid.Columns.Add(productReference);
                dataGrid.Columns[3].Name = "productReference";
                dataGrid.Columns[3].HeaderText = "REF.";
                dataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].Visible = true;
                dataGrid.Columns[3].ReadOnly = true;
                dataGrid.Columns[3].Width = 80;

                dataGrid.Columns.Add(productSize);
                dataGrid.Columns[4].Name = "productSize";
                dataGrid.Columns[4].HeaderText = "TAM.";
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
                dataGrid.Columns[6].Width = 70;
                dataGrid.Columns[6].Name = "minStock";
                dataGrid.Columns[6].HeaderText = "MIN.";
                dataGrid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[6].ReadOnly = true;

                dataGrid.Columns.Add(maxStock);
                dataGrid.Columns[7].Width = 70;
                dataGrid.Columns[7].Name = "maxStock";
                dataGrid.Columns[7].HeaderText = "MAX.";
                dataGrid.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[7].ReadOnly = true;

                dataGrid.Columns.Add(stockQuantity);
                dataGrid.Columns[8].Width = 70;
                dataGrid.Columns[8].Name = "stockQuantity";
                dataGrid.Columns[8].HeaderText = "QTD.";
                dataGrid.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[8].ReadOnly = true;

                dataGrid.Columns.Add(stockValue);
                dataGrid.Columns[9].Width = 120;
                dataGrid.Columns[9].Name = "stockValue";
                dataGrid.Columns[9].HeaderText = "VALOR";
                dataGrid.Columns[9].DefaultCellStyle.Format = "c2";
                dataGrid.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[9].DisplayIndex = 6;
                dataGrid.Columns[9].ReadOnly = true;

                dataGrid.Columns.Add(stockSummary);
                dataGrid.Columns[10].Width = 80;
                dataGrid.Columns[10].Name = "stockSummary";
                dataGrid.Columns[10].HeaderText = "RESUMO";
                dataGrid.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[10].ReadOnly = true;
                dataGrid.Columns[10].DisplayIndex = 0;

                dataGrid.Columns.Add(stockResult);
                dataGrid.Columns[11].Width = 80;
                dataGrid.Columns[11].Name = "stockResult";
                dataGrid.Columns[11].HeaderText = "RESULTADO";
                dataGrid.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[11].ReadOnly = true;
                dataGrid.Columns[11].DisplayIndex = 1;
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }

        }

        #endregion
    }
}
