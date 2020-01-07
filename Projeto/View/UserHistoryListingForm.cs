using System;
using System.Windows.Forms;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class UserHistoryListingForm : Form
    {
        #region Variables
        private DataPagination dataPagination = new DataPagination();
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
            SearchData();
        }

        #endregion

        #region Button

        private void UpdateDataList_Click(object sender, EventArgs e)
        {
            ListData();
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

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            GifLoading.Visible = false;
            SearchTimer.Enabled = false;
            SearchData();
        }

        #endregion

        #region MethodsAxiliarys

        public void ListData()
        {
            try
            {
                var historic = new UserHistoryController();
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

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        public void SearchData()
        {
            try
            {
                var historic = new UserHistoryController(dataPagination)
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

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        public void InitializeSettings()
        {
            CreateColumnInTheDataList();

            DataGridLealt.SetDefaultStyle(HistoryDataList);

            DayOfTheWeek.Text = DateTime.Now.ToLongDateString();
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
                ExceptionAssistant.Message.Show(ex);
            }

        }

        #endregion
    }
}
