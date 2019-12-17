using System;
using System.Windows.Forms;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class FrmUserHistoricList : Form
    {
        #region Variables
        private int numberOfRecords = 100;
        private AxlDataPagination dataPagination = new AxlDataPagination();
        #endregion 

        #region Constructs
        public FrmUserHistoricList()
        {
            InitializeComponent();
            InitializeSettings();
        }
        #endregion

        #region UserForm

        #region FrmUserHistoricList_Load()
        private void FrmUserHistoricList_Load(object sender, EventArgs e)
        {
            ListAll();
        }
        #endregion

        #endregion

        #region Button

        #region BtnUpdateList_Click()
        private void BtnUpdateList_Click(object sender, EventArgs e)
        {
            ListAll();
        }
        #endregion

        #endregion

        #region TextBox

        #region TxtBuscarLogin_TextChanged()
        private void TxtQueryByLogin_TextChanged(object sender, EventArgs e)
        {
            PicLoading.Visible = true;
            TimeExecuteQuery.Enabled = false;
            TimeExecuteQuery.Enabled = true;
        }
        #endregion

        #region TxtStartDate_ValueChanged()
        private void TxtStartDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            //PicCarregando.Visible = true;
            //TimeExecultaConsulta.Enabled = false;
            //TimeExecultaConsulta.Enabled = true;
        }
        #endregion

        #region TxtFinalData_ValueChanged()
        private void TxtFinalData_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            PicLoading.Visible = true;
            TimeExecuteQuery.Enabled = false;
            TimeExecuteQuery.Enabled = true;
        }
        #endregion 

        #endregion 

        #region Timer

        #region TimeExecuteQuery_Tick()
        private void TimeExecuteQuery_Tick(object sender, EventArgs e)
        {
            PicLoading.Visible = false;
            TimeExecuteQuery.Enabled = false;
            FetchData();
        }
        #endregion

        #endregion

        #region Methods

        #region ListAll()
        public void ListAll()
        {
            try
            {
                var historic = new BllUserHistoric();
                historic.ListAll(numberOfRecords);

                GridHistoricList.Rows.Clear();

                for (int i = 0; i < historic.ListOfRecords.Count; i++)
                {
                    GridHistoricList.Rows.Add(
                    historic.ListOfRecords[i].Id,
                    historic.ListOfRecords[i].Login,
                    historic.ListOfRecords[i].OperationType,
                    historic.ListOfRecords[i].OperationModule,
                    historic.ListOfRecords[i].OperationDate,
                    historic.ListOfRecords[i].OperationHour,
                    historic.ListOfRecords[i].DataFromAffectedRecord);
                }

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region FetchData()
        public void FetchData()
        {
            try
            {
                var historic = new BllUserHistoric(dataPagination)
                {
                    QueryByLogin = TxtQueryByLogin.Text,
                    QueryByStartDate = Convert.ToDateTime(TxtStartDate.Value).ToString("dd-MM-yyyy"),
                    QueryByFinalDate = Convert.ToDateTime(TxtFinalDate.Value).ToString("dd-MM-yyyy")
                };

                historic.FetchData();

                GridHistoricList.Rows.Clear();

                for (int i = 0; i < historic.ListOfRecords.Count; i++)
                {
                    GridHistoricList.Rows.Add(
                    historic.ListOfRecords[i].Id,
                    historic.ListOfRecords[i].Login,
                    historic.ListOfRecords[i].OperationType,
                    historic.ListOfRecords[i].OperationModule,
                    historic.ListOfRecords[i].OperationDate,
                    historic.ListOfRecords[i].OperationHour,
                    historic.ListOfRecords[i].DataFromAffectedRecord);
                }

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region InitializeSettings()
        public void InitializeSettings()
        {
            CreateColumnsInTheDataGrid();

            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridHistoricList);

            LblTodayIsDay.Text = DateTime.Now.ToLongDateString();

        }
        #endregion

        #region CreateColumnsInTheDataGrid
        private void CreateColumnsInTheDataGrid()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var login = new DataGridViewTextBoxColumn();
                var operation = new DataGridViewTextBoxColumn();
                var module = new DataGridViewTextBoxColumn();
                var date = new DataGridViewTextBoxColumn();
                var hour = new DataGridViewTextBoxColumn();
                var dataFromAffectedRecord = new DataGridViewTextBoxColumn();


                var dataGrid = GridHistoricList;

                dataGrid.Columns.Add(id);
                dataGrid.Columns[0].Name = "id";
                dataGrid.Columns[0].HeaderText = "ID";
                dataGrid.Columns[0].ReadOnly = true;

                dataGrid.Columns.Add(login);
                dataGrid.Columns[1].Name = "login";
                dataGrid.Columns[1].Width = 130;
                dataGrid.Columns[1].HeaderText = "LOGIN";
                dataGrid.Columns[1].ReadOnly = true;

                dataGrid.Columns.Add(operation);
                dataGrid.Columns[2].Name = "operation";
                dataGrid.Columns[2].HeaderText = "OPERAÇÃO";
                dataGrid.Columns[2].ReadOnly = true;

                dataGrid.Columns.Add(module);
                dataGrid.Columns[3].Name = "module";
                dataGrid.Columns[3].HeaderText = "MÓDULO";
                dataGrid.Columns[3].ReadOnly = true;

                dataGrid.Columns.Add(date);
                dataGrid.Columns[4].Name = "date";
                dataGrid.Columns[4].HeaderText = "DATA";
                dataGrid.Columns[4].DefaultCellStyle.Format = "dd-MM-yyyy";
                dataGrid.Columns[4].ReadOnly = true;

                dataGrid.Columns.Add(hour);
                dataGrid.Columns[5].Name = "hour";
                dataGrid.Columns[5].HeaderText = "HÓRA";
                dataGrid.Columns[5].ReadOnly = true;

                dataGrid.Columns.Add(dataFromAffectedRecord);
                dataGrid.Columns[6].Name = "dataFromAffectedRecord";
                dataGrid.Columns[6].HeaderText = "DADOS DO REGISTRO AFETADO";
                dataGrid.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[6].ReadOnly = false;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }

        }
        #endregion

        #endregion
    }
}
