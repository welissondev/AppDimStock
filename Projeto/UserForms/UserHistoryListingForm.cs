using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DimStock.Auxiliarys;
using DimStock.Business;
using Syncfusion.Windows.Forms.Tools;

namespace DimStock.UserForms
{
    public partial class UserHistoryListingForm : Form
    {
        #region Variables
        private AxlDataPagination dataPagination = new AxlDataPagination();
        #endregion 

        #region Constructs
        public UserHistoryListingForm()
        {
            InitializeComponent();
            InitializeSettings();
        }
        #endregion

        #region UserForm

        private void UserHistoryListingForm_Load(object sender, EventArgs e)
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

        #endregion

        #region TextBox

        private void SearchByLogin_TextChanged(object sender, EventArgs e)
        {
            GifLoading.Visible = true;
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
        }

        private void FinalDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            GifLoading.Visible = true;
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
        }

        #endregion 

        #region ComboBox

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
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            GifLoading.Visible = false;
            SearchTimer.Enabled = false;
            SearchData();
        }

        #endregion

        #region BadingNavigator

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

        #region MethodsAxiliarys

        private void ListData()
        {
            try
            {
                var historic = new UserHistory(dataPagination);
                historic.ListData();

                HistoryDataList.Rows.Clear();

                for (int i = 0; i < historic.ListOfRecords.Count; i++)
                {
                    HistoryDataList.Rows.Add(
                    historic.ListOfRecords[i].Id,
                    historic.ListOfRecords[i].Login,
                    historic.ListOfRecords[i].OperationType,
                    historic.ListOfRecords[i].OperationModule,
                    historic.ListOfRecords[i].OperationDate,
                    historic.ListOfRecords[i].OperationHour,
                    historic.ListOfRecords[i].AffectedFields);
                }

                HistoryDataList.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(dataPagination);

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void SearchData()
        {
            try
            {
                var historic = new UserHistory(dataPagination)
                {
                    SearchByLogin = SearchByLogin.Text,
                    SearchByStartDate = Convert.ToDateTime(StartDate.Value).ToString("dd-MM-yyyy"),
                    SearchByFinalDate = Convert.ToDateTime(FinalDate.Value).ToString("dd-MM-yyyy")
                };

                historic.SearchData();

                HistoryDataList.Rows.Clear();

                for (int i = 0; i < historic.ListOfRecords.Count; i++)
                {
                    HistoryDataList.Rows.Add(
                    historic.ListOfRecords[i].Id,
                    historic.ListOfRecords[i].Login,
                    historic.ListOfRecords[i].OperationType,
                    historic.ListOfRecords[i].OperationModule,
                    historic.ListOfRecords[i].OperationDate,
                    historic.ListOfRecords[i].OperationHour,
                    historic.ListOfRecords[i].AffectedFields);
                }

                HistoryDataList.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(dataPagination);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void InitializeSettings()
        {
            CreateColumnInTheDataList();

            AxlDataGridLealt.SetDefaultStyle(HistoryDataList);

            FillAllComboBoxes();

            var startDate = new DateTime(DateTime.Today.Year,
            DateTime.Today.Month, 1);

            var finalDate = new DateTime(DateTime.Today.Year,
            DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year,
            DateTime.Today.Month));

            StartDate.Text = startDate.ToString();

            FinalDate.Text = finalDate.ToString();
        }

        private void FillAllComboBoxes()
        {

            var itemList = new List<string>
            {
                "20 Registros",
                "30 Registros",
                "70 Registros",
                "100 Registros"
            };

            RecordsByPage.DataSource = itemList;
            RecordsByPage.Text = "20 Registros";

        }

        private void ResetControls()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;
                }

                SearchByLogin.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ResetVariables()
        {
            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
        }

        private void CallAllResets()
        {
            ResetVariables();
            ResetControls();
        }

        private void SetInBadingNavigator(AxlDataPagination dataPagination)
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
                var id = new DataGridViewTextBoxColumn();
                var login = new DataGridViewTextBoxColumn();
                var operationType = new DataGridViewTextBoxColumn();
                var operationModule = new DataGridViewTextBoxColumn();
                var operationDate = new DataGridViewTextBoxColumn();
                var operationHour = new DataGridViewTextBoxColumn();
                var affectedFields = new DataGridViewTextBoxColumn();


                var dataGrid = HistoryDataList;

                dataGrid.Columns.Add(id);
                dataGrid.Columns[0].Name = "id";
                dataGrid.Columns[0].HeaderText = "ID";
                dataGrid.Columns[0].ReadOnly = true;

                dataGrid.Columns.Add(login);
                dataGrid.Columns[1].Name = "login";
                dataGrid.Columns[1].Width = 130;
                dataGrid.Columns[1].HeaderText = "LOGIN";
                dataGrid.Columns[1].ReadOnly = true;

                dataGrid.Columns.Add(operationType);
                dataGrid.Columns[2].Name = "operationType";
                dataGrid.Columns[2].HeaderText = "OPERAÇÃO";
                dataGrid.Columns[2].ReadOnly = true;

                dataGrid.Columns.Add(operationModule);
                dataGrid.Columns[3].Name = "operationModule";
                dataGrid.Columns[3].HeaderText = "MÓDULO";
                dataGrid.Columns[3].ReadOnly = true;

                dataGrid.Columns.Add(operationDate);
                dataGrid.Columns[4].Name = "operationDate";
                dataGrid.Columns[4].HeaderText = "DATA";
                dataGrid.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
                dataGrid.Columns[4].ReadOnly = true;

                dataGrid.Columns.Add(operationHour);
                dataGrid.Columns[5].Name = "operationHour";
                dataGrid.Columns[5].HeaderText = "HÓRA";
                dataGrid.Columns[5].ReadOnly = true;

                dataGrid.Columns.Add(affectedFields);
                dataGrid.Columns[6].Name = "affectedFields";
                dataGrid.Columns[6].HeaderText = "CAMPOS AFETADOS";
                dataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[6].ReadOnly = false;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }

        #endregion
    }
}
