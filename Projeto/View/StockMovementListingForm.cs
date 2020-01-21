using System;
using System.Windows.Forms;
using DimStock.Business;
using DimStock.Auxiliary;
using DimStock.Properties;
using System.Collections.Generic;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.ListView;

namespace DimStock.View
{
    public partial class StockMovementListingForm : Form
    {
        #region Variables

        private DataPagination dataPagination = new DataPagination();
        private string selectedSituation = string.Empty;
        private string selectedType = string.Empty;

        #endregion

        #region Constructs

        public StockMovementListingForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region Form

        private void StockMovementListingForm_Load(object sender, EventArgs e)
        {
            StartSearchTimer();
        }

        #endregion

        #region Button


        private void AddNew_Click(object sender, EventArgs e)
        {
            StockMovementMenuStrip.Show();
            StockMovementMenuStrip.Location = MousePosition;
        }

        private void UpdateDataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        #endregion

        #region TextBox

        private void QueryByStockMovementId_TextChanged(object sender, EventArgs e)
        {
            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
            StartSearchTimer();
        }

        #endregion

        #region ComboBox

        private void OperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = OperationType.SelectedIndex;

                switch (itemSelected)
                {
                    case 0:
                        selectedType = string.Empty;
                        break;

                    case 1:
                        selectedType = "Entrada";
                        break;

                    case 2:
                        selectedType = "Saída";
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

        private void OperationSituation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = OperationSituation.SelectedIndex;

                switch (itemSelected)
                {
                    case 0:
                        selectedSituation = string.Empty;
                        break;

                    case 1:
                        selectedSituation = "Em Aberto";
                        break;

                    case 2:
                        selectedSituation = "Finalizada";
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

        #region LabelLink

        private void ClearSearchFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CallAllResets();
                StartSearchTimer();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion

        #region DataGridView

        private void MovementStockDataList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = MovementStockDataList.Columns[
                e.ColumnIndex].Name;

                var defaultCursor = Cursors.Arrow;
                MovementStockDataList.Cursor = defaultCursor;

                switch (columnName)
                {
                    case "viewDetails":
                        MovementStockDataList.Cursor = Cursors.Hand;
                        break;

                    case "delete":
                        MovementStockDataList.Cursor = Cursors.Hand;
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void MovementStockDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MovementStockDataList.Rows.Count > 0)
            {
                var columnName = MovementStockDataList.Columns[
                e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "viewDetails":
                        GetStockMovementDetails();
                        break;

                    case "delete":
                        Delete();
                        break;
                }
            }
        }

        #endregion

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
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

        #region MenuStrip

        private void MovementEntrie_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new StockMovementRegistrationForm()
            {
                MinimizeBox = false,
                ShowInTaskbar = false
            };
            form.InitializeNewMovement("Entrada");
            form.ShowDialog();
        }

        private void MovementOutPut_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new StockMovementRegistrationForm()
            {
                MinimizeBox = false,
                ShowInTaskbar = false
            };
            form.InitializeNewMovement("Saída");
            form.ShowDialog();
        }

        #endregion

        #region MethodsAxiliarys

        private void SearchData()
        {
            try
            {
                var stockMovement = new StockMovement(dataPagination)
                {
                    SearchByType = selectedType,
                    SearchByMovimentId = SearchByStockMovimentId.Text,
                    SearchBySituation = selectedSituation
                };

                stockMovement.SearchData();

                MovementStockDataList.Rows.Clear();

                for (int i = 0; i < stockMovement.ListOfRecords.Count; i++)
                {
                    MovementStockDataList.Rows.Add(
                    stockMovement.ListOfRecords[i].OperationSituation,
                    stockMovement.ListOfRecords[i].OperationType,
                    stockMovement.ListOfRecords[i].Id,
                    stockMovement.ListOfRecords[i].OperationDate,
                    stockMovement.ListOfRecords[i].OperationHour,
                    stockMovement.ListOfRecords[i].StockDestinationLocation
                    );
                }

                MovementStockDataList.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(dataPagination);

            }
            catch (Exception ex)
            {
                PauseSearchTimer();
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void Delete()
        {
            try
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(
                    MovementStockDataList.CurrentRow.Cells[
                    "id"].Value);

                    var operationType = Convert.ToString(
                    MovementStockDataList.CurrentRow.Cells[
                    "operationType"].Value);

                    var stockMovement = new StockMovement
                    {
                        OperationType = operationType
                    };

                    if (stockMovement.Delete(id) == true)
                    {
                        MessageBox.Show(MessageNotifier.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(MessageNotifier.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void GetStockMovementDetails()
        {
            try
            {
                int id = Convert.ToInt32(
                MovementStockDataList.CurrentRow.Cells["id"].Value);

                var form = new StockMovementRegistrationForm()
                {
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    ShowInTaskbar = false,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                form.GetStockMovementDetails(id);
                form.ListStockItems();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void FillAllComboBox()
        {
            try
            {
                List<string> typeList = new List<string>()
                {
                    "Todos",
                    "Entrada",
                    "Saída"
                };

                OperationType.DataSource = typeList;
                OperationType.Text = "Todos";


                List<string> situationList = new List<string>()
                {
                    "Todos",
                    "Em Aberto",
                    "Finalizada"
                };

                OperationSituation.DataSource = situationList;
                OperationSituation.Text = "Todos";


                List<string> pageSizeList = new List<string>()
                {
                    "20 Registros",
                    "30 Registros",
                    "70 Registros",
                    "100 Registros"
                };

                RecordsByPage.DataSource = pageSizeList;
                RecordsByPage.Text = "20 Registros";

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void InitializeSettings()
        {

            CreateColumnsInTheDataList();

            FillAllComboBox();

            //Defini o lealt do datagridviw
            DataGridLealt.SetDefaultStyle(MovementStockDataList);

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

        private void SetInBadingNavigator(DataPagination dataPagination)
        {
            if (dataPagination.RecordCount == 0)
                dataPagination.CurrentPage = 0;

            var legend = " Página " + dataPagination.CurrentPage + " de " + dataPagination.NumberOfPages;
            BindingPagination.Items[2].Text = legend;

            legend = " Total de " + dataPagination.RecordCount + " registro(s)";
            BindingPagination.Items[6].Text = legend;
        }

        private void ResetControls()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;

                    if (ctl.GetType() == typeof(SfComboBox))
                        ctl.Text = string.Empty;
                }

                OperationSituation.Text = "Todos";

                OperationType.Text = "Todos";

                RecordsByPage.Text = dataPagination.PageSize + " Registros ";

                SearchByStockMovimentId.Select();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void ResetVariables()
        {
            selectedSituation = string.Empty;
            selectedType = string.Empty;
            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
        }

        private void CallAllResets()
        {
            ResetControls();
            ResetVariables();
        }

        private void CreateColumnsInTheDataList()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var operationType = new DataGridViewTextBoxColumn();
                var operationDate = new DataGridViewTextBoxColumn();
                var operationHour = new DataGridViewTextBoxColumn();
                var operationSituation = new DataGridViewTextBoxColumn();
                var stockDestinationLocation = new DataGridViewTextBoxColumn();
                var viewDetails = new DataGridViewButtonColumn();
                var delete = new DataGridViewButtonColumn();

                var stockMovementList = MovementStockDataList;

                stockMovementList.Columns.Add(operationSituation);
                stockMovementList.Columns[0].Width = 100;
                stockMovementList.Columns[0].Name = "operationSituation";
                stockMovementList.Columns[0].HeaderText = "SITUAÇÃO";
                stockMovementList.Columns[0].ReadOnly = true;
                stockMovementList.Columns[0].Visible = true;

                stockMovementList.Columns.Add(operationType);
                stockMovementList.Columns[1].Width = 100;
                stockMovementList.Columns[1].Name = "operationType";
                stockMovementList.Columns[1].HeaderText = "TIPO";
                stockMovementList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                stockMovementList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                stockMovementList.Columns[1].ReadOnly = true;

                stockMovementList.Columns.Add(id);
                stockMovementList.Columns[2].Name = "id";
                stockMovementList.Columns[2].HeaderText = "NÚMERO";
                stockMovementList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[2].Visible = true;
                stockMovementList.Columns[2].ReadOnly = true;

                stockMovementList.Columns.Add(operationDate);
                stockMovementList.Columns[3].Width = 100;
                stockMovementList.Columns[3].Name = "operationDate";
                stockMovementList.Columns[3].HeaderText = "DATA";
                stockMovementList.Columns[3].DefaultCellStyle.Format = "dd-MM-yyyy";
                stockMovementList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[3].ReadOnly = true;

                stockMovementList.Columns.Add(operationHour);
                stockMovementList.Columns[4].Name = "operationHour";
                stockMovementList.Columns[4].HeaderText = "HÓRA";
                stockMovementList.Columns[4].Width = 100;
                stockMovementList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[4].ReadOnly = true;
                stockMovementList.Columns[4].Visible = true;

                stockMovementList.Columns.Add(stockDestinationLocation);
                stockMovementList.Columns[5].Width = 250;
                stockMovementList.Columns[5].Name = "stockDestinationLocation";
                stockMovementList.Columns[5].HeaderText = "DESTINO";
                stockMovementList.Columns[5].ReadOnly = true;
                stockMovementList.Columns[5].Visible = true;

                viewDetails.Text = "Visualizar";
                viewDetails.UseColumnTextForButtonValue = true;
                viewDetails.FlatStyle = FlatStyle.Popup;
                stockMovementList.Columns.Add(viewDetails);
                stockMovementList.Columns[6].Name = "viewDetails";
                stockMovementList.Columns[6].HeaderText = "";
                stockMovementList.Columns[6].Width = 70;
                stockMovementList.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[6].ReadOnly = true;

                delete.Text = "Deletar";
                delete.UseColumnTextForButtonValue = true;
                delete.FlatStyle = FlatStyle.Popup;
                stockMovementList.Columns.Add(delete);
                stockMovementList.Columns[7].Name = "delete";
                stockMovementList.Columns[7].HeaderText = "";
                stockMovementList.Columns[7].Width = 70;
                stockMovementList.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[7].ReadOnly = true;

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion
    }
}
