using DimStock.Auxiliarys;
using DimStock.Business;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.ListView;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class StockMovementListingForm : Form
    {
        #region Builder

        public StockMovementListingForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region Properties

        private AxlDataPage pagination = new AxlDataPage();
        private string selectedSituation = string.Empty;
        private string selectedType = string.Empty;

        #endregion

        #region Form

        private void StockMovementListingForm_Load(object sender, EventArgs e)
        {
            StartSearchTimer();
        }

        #endregion

        #region Button

        private void ButtonRegisterNew_Click(object sender, EventArgs e)
        {
            StockMovementMenuStrip.Show();
            StockMovementMenuStrip.Location = MousePosition;
        }

        private void ButtonDataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        #endregion

        #region TextBox

        private void TextSearchByOperationCode_TextChanged(object sender, EventArgs e)
        {
            pagination.OffSetValue = 0;
            pagination.CurrentPage = 1;
            StartSearchTimer();
        }

        #endregion

        #region ComboBox

        private void ComboBoxOperationType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = ComboBoxOperationType.SelectedIndex;

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

                pagination.OffSetValue = 0;
                pagination.CurrentPage = 1;
                StartSearchTimer();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ComboBoxOperationSituation_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = ComboBoxOperationSituation.SelectedIndex;

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

                pagination.OffSetValue = 0;
                pagination.CurrentPage = 1;
                StartSearchTimer();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
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

        #region LabelLink

        private void ButtonClearSearchFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CallAllResets();
                StartSearchTimer();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region DataGrid

        private void DatagridMovement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatagridMovement.Rows.Count > 0)
            {
                var columnName = DatagridMovement.Columns[
                e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "viewDetails":
                        GetDetail();
                        break;

                    case "delete":
                        Remove();
                        break;
                }
            }
        }

        private void DatagridMovement_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridMovement.Rows[e.RowIndex].Selected = true;
            }
        }

        #endregion

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            FetchData();
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

        #region MenuStrip

        private void MovementEntrie_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new StockMovementRegistrationForm()
            {
                MdiParent = HomeScreenForm.He,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ShowInTaskbar = false
            };
            form.StartNewOperation("Entrada");
            form.Show();
        }

        private void MovementOutPut_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new StockMovementRegistrationForm()
            {
                MdiParent = HomeScreenForm.He,
                FormBorderStyle = FormBorderStyle.None,
                Dock = DockStyle.Fill,
                ShowInTaskbar = false
            };
            form.StartNewOperation("Saída");
            form.Show();
        }

        #endregion

        #region Function

        private void FetchData()
        {
            try
            {
                var movement = new StockMovement(pagination)
                {
                    OperationType = selectedType,
                    OperationCode = TextSearchByOperationCode.Text,
                    OperationSituation = selectedSituation
                };

                movement.FetchData();

                DatagridMovement.Rows.Clear();

                for (int i = 0; i < movement.List.Count; i++)
                {
                    DatagridMovement.Rows.Add(
                    movement.List[i].OperationSituation,
                    movement.List[i].OperationType,
                    movement.List[i].OperationCode,
                    movement.List[i].OperationDate,
                    Convert.ToString(movement.List[i].OperationHour.ToString("HH:MM:ss")),
                    movement.List[i].Destination.Location
                    );
                }

                DatagridMovement.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(pagination);

            }
            catch (Exception ex)
            {
                PauseSearchTimer();
                AxlException.Message.Show(ex);
            }
        }

        private void Remove()
        {
            try
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(
                    DatagridMovement.CurrentRow.Cells[
                    "id"].Value);

                    var operationType = Convert.ToString(
                    DatagridMovement.CurrentRow.Cells[
                    "operationType"].Value);

                    var stockMovement = new StockMovement
                    {
                        OperationType = operationType
                    };

                    if (stockMovement.Remove(id) == true)
                    {
                        MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(AxlMessageNotifier.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void GetDetail()
        {
            try
            {
                int id = Convert.ToInt32(
                DatagridMovement.CurrentRow.Cells["id"].Value);

                var form = new StockMovementRegistrationForm()
                {
                    MdiParent = HomeScreenForm.He,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                    ShowInTaskbar = false,
                    MaximizeBox = true,
                    MinimizeBox = false,
                };

                form.MovementGetDetail(id);
                form.Show();

                HomeScreenForm.He.LabelNavegationDescription.Text =
                @"Cadastro De Movimentações";
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
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

                ComboBoxOperationType.DataSource = typeList;
                ComboBoxOperationType.Text = "Todos";


                List<string> situationList = new List<string>()
                {
                    "Todos",
                    "Em Aberto",
                    "Finalizada"
                };

                ComboBoxOperationSituation.DataSource = situationList;
                ComboBoxOperationSituation.Text = "Todos";


                List<string> pageSizeList = new List<string>()
                {
                    "20 Registros",
                    "30 Registros",
                    "70 Registros",
                    "100 Registros"
                };

                ComboBoxRecordsByPage.DataSource = pageSizeList;
                ComboBoxRecordsByPage.Text = "20 Registros";

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void InitializeSettings()
        {

            CreateColumnsInTheDataList();

            FillAllComboBox();

            //Defini o lealt do datagridviw
            AxlDataGridLealt.SetDefaultStyle(DatagridMovement);

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

        private void SetInBadingNavigator(AxlDataPage pagination)
        {
            if (pagination.RecordCount == 0)
                pagination.CurrentPage = 0;

            var legend = " Página " + pagination.CurrentPage + " de " + pagination.NumberOfPages;
            BindingPagination.Items[2].Text = legend;

            legend = " Total de " + pagination.RecordCount + " registro(s)";
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

                ComboBoxOperationSituation.Text = "Todos";

                ComboBoxOperationType.Text = "Todos";

                ComboBoxRecordsByPage.Text = pagination.PageSize + " Registros ";

                TextSearchByOperationCode.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ResetProperties()
        {
            selectedSituation = string.Empty;
            selectedType = string.Empty;
            pagination.OffSetValue = 0;
            pagination.CurrentPage = 1;
        }

        private void CallAllResets()
        {
            ResetControls();
            ResetProperties();
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
                var viewDetails = new DataGridViewLinkColumn();
                var delete = new DataGridViewLinkColumn();

                var stockMovementList = DatagridMovement;

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
                stockMovementList.Columns[4].DefaultCellStyle.Format = "HH:MM:ss";
                stockMovementList.Columns[4].ReadOnly = true;
                stockMovementList.Columns[4].Visible = true;

                stockMovementList.Columns.Add(stockDestinationLocation);
                stockMovementList.Columns[5].Width = 200;
                stockMovementList.Columns[5].Name = "stockDestinationLocation";
                stockMovementList.Columns[5].HeaderText = "DESTINO";
                stockMovementList.Columns[5].ReadOnly = true;
                stockMovementList.Columns[5].Visible = true;

                viewDetails.Text = "Visualizar";
                viewDetails.TrackVisitedState = false;
                viewDetails.UseColumnTextForLinkValue = true;
                viewDetails.LinkColor = Color.Black;
                viewDetails.ActiveLinkColor = Color.MediumAquamarine;
                stockMovementList.Columns.Add(viewDetails);
                stockMovementList.Columns[6].Name = "viewDetails";
                stockMovementList.Columns[6].HeaderText = "";
                stockMovementList.Columns[6].Width = 70;
                stockMovementList.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[6].ReadOnly = true;

                delete.Text = "Deletar";
                delete.TrackVisitedState = false;
                delete.UseColumnTextForLinkValue = true;
                delete.LinkColor = Color.Black;
                delete.ActiveLinkColor = Color.MediumAquamarine;
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
                AxlException.Message.Show(ex);
            }
        }

        #endregion
    }
}
