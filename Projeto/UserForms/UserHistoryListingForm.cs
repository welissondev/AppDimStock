using DimStock.Auxiliarys;
using DimStock.Business;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class UserHistoryListingForm : Form
    {
        #region Builder
        public UserHistoryListingForm()
        {
            InitializeComponent();
            InitializeSettings();
        }
        #endregion

        #region Properties
        private AxlDataPage pagination = new AxlDataPage();
        #endregion 

        #region Form

        private void UserHistoryListingForm_Load(object sender, EventArgs e)
        {
            StartSearchTimer();
        }

        #endregion

        #region Button

        private void ButtonDataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        #endregion

        #region TextBox

        private void TextSearchByLogin_TextChanged(object sender, EventArgs e)
        {
            PictureLoading.Visible = true;
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
        }

        private void TextFinalDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            PictureLoading.Visible = true;
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
        }

        #endregion 

        #region ComboBox

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

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            PictureLoading.Visible = false;
            SearchTimer.Enabled = false;
            FetchData();
        }

        #endregion

        #region DataGrid

        private void DatagridUserHistory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridUserHistory.Rows[e.RowIndex].Selected = true;
            }
        }

        #endregion

        #region BadingNavigator

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

        private void ListData()
        {
            try
            {
                var historic = new UserHistory(pagination);
                historic.ListData();

                DatagridUserHistory.Rows.Clear();

                for (int i = 0; i < historic.List.Count; i++)
                {
                    DatagridUserHistory.Rows.Add(
                    historic.List[i].Id,
                    historic.List[i].User.Login,
                    historic.List[i].OperationType,
                    historic.List[i].OperationModule,
                    historic.List[i].OperationDate,
                    historic.List[i].OperationHour,
                    historic.List[i].AffectedFields);
                }

                DatagridUserHistory.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(pagination);

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void FetchData()
        {
            try
            {
                var history = new UserHistory(pagination);
                history.User.Login = TextSearchByLogin.Text;

                history.FetchData(
                Convert.ToDateTime(TextStartDate.Value).
                ToString("dd-MM-yyyy"),

                Convert.ToDateTime(TextFinalDate.Value).
                ToString("dd-MM-yyyy"));

                DatagridUserHistory.Rows.Clear();

                for (int i = 0; i < history.List.Count; i++)
                {
                    DatagridUserHistory.Rows.Add(
                    history.List[i].Id,
                    history.List[i].User.Login,
                    history.List[i].OperationType,
                    history.List[i].OperationModule,
                    history.List[i].OperationDate,
                    history.List[i].OperationHour,
                    history.List[i].AffectedFields);
                }

                DatagridUserHistory.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(pagination);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void InitializeSettings()
        {
            CreateColumnInTheDataList();

            AxlDataGridLealt.SetDefaultStyle(DatagridUserHistory);

            FillAllComboBoxes();

            var startDate = new DateTime(DateTime.Today.Year,
            DateTime.Today.Month, 1);

            var finalDate = new DateTime(DateTime.Today.Year,
            DateTime.Today.Month, DateTime.DaysInMonth(DateTime.Today.Year,
            DateTime.Today.Month));

            TextStartDate.Text = startDate.ToString();

            TextFinalDate.Text = finalDate.ToString();
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

            ComboBoxRecordsByPage.DataSource = itemList;
            ComboBoxRecordsByPage.Text = "20 Registros";

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

                TextSearchByLogin.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ResetProperties()
        {
            pagination.OffSetValue = 0;
            pagination.CurrentPage = 1;
        }

        private void CallAllResets()
        {
            ResetProperties();
            ResetControls();
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
                var id = new DataGridViewTextBoxColumn();
                var login = new DataGridViewTextBoxColumn();
                var operationType = new DataGridViewTextBoxColumn();
                var operationModule = new DataGridViewTextBoxColumn();
                var operationDate = new DataGridViewTextBoxColumn();
                var operationHour = new DataGridViewTextBoxColumn();
                var affectedFields = new DataGridViewTextBoxColumn();


                var dataGrid = DatagridUserHistory;

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
