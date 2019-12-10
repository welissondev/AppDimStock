using System;
using System.Windows.Forms;
using DimStock.Business;
using DimStock.Auxiliary;
using DimStock.Properties;
using System.Linq;
using System.Collections.Generic;
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.ListView;

namespace DimStock.View
{
    public partial class FrmStockActivityList : Form
    {
        #region Variables
        private AxlDataPagination dataPagination = new AxlDataPagination();
        #endregion 

        #region Constructs
        public FrmStockActivityList()
        {
            InitializeComponent();

            InitializeSettings();
        }
        #endregion

        #region Form

        #region FrmStockActivityList_Load()
        private void FrmStockActivityList_Load(object sender, EventArgs e)
        {
            ConfigureDataPagination();
        }
        #endregion

        #endregion

        #region Button

        #region BtnUpdateList_Click()
        private void BtnUpdateList_Click(object sender, EventArgs e)
        {
            ListActivities();
        }
        #endregion

        #endregion

        #region TextBox

        #region TxtQueryByStartDate_ValueChanged()
        private void TxtQueryByStartDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            //TimerExecutaConsulta.Enabled = false;
            //TimerExecutaConsulta.Enabled = true;
        }
        #endregion

        #region TxtQueryByFinalDate_ValueChanged()
        private void TxtQueryByFinalDate_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            PicLoading.Visible = true;
            TimerExecuteQuery.Enabled = false;
            TimerExecuteQuery.Enabled = true;
        }
        #endregion

        #region TxtQueryByActivityNumber_TextChanged()
        private void TxtQueryByActivityNumber_TextChanged(object sender, EventArgs e)
        {
            TimerExecuteQuery.Enabled = false;
            TimerExecuteQuery.Enabled = true;
            PicLoading.Visible = true;
        }
        #endregion

        #endregion

        #region ComboBox

        #region CboActivityType_SelectedIndexChanged()
        private void CboActivityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicLoading.Visible = true;
            TimerExecuteQuery.Enabled = false;
            TimerExecuteQuery.Enabled = true;
        }
        #endregion

        #region CboActivitySituation_SelectedIndexChanged()
        private void CboActivitySituation_SelectedIndexChanged(object sender, EventArgs e)
        {
            PicLoading.Visible = true;
            TimerExecuteQuery.Enabled = false;
            TimerExecuteQuery.Enabled = true;
        }
        #endregion

        #endregion

        #region Label

        #region LblClear_LinkClicked()
        private void LblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

                TxtQueryByActvityNumber.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #endregion

        #region DataGridView

        #region GridActivityList_CellMouseMove()
        private void GridActivityList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = GridActivityList.Columns[e.ColumnIndex].Name;

                if (columnName == "btnViewData" || columnName == "btnDelete")
                {
                    GridActivityList.Cursor = Cursors.Hand;
                }
                else
                {
                    GridActivityList.Cursor = Cursors.Arrow;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region GridActivityList_CellClick()
        private void GridActivityList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridActivityList.Rows.Count > 0)
            {
                var columnName = GridActivityList.Columns[e.ColumnIndex].Name;

                if (columnName == "btnViewData" && e.RowIndex != -1)
                {
                    ViewData();
                }
                else if (columnName == "btnDelete" && e.RowIndex != -1)
                {
                    Delete();
                }
            }
        }
        #endregion

        #endregion

        #region Timer

        #region TimerExecuteQuery_Tick()
        private void TimerExecuteQuery_Tick(object sender, EventArgs e)
        {
            TimerExecuteQuery.Enabled = false;
            PicLoading.Visible = false;
            FetchData();
        }
        #endregion

        #endregion

        #region Methods

        #region ListActivities()
        private void ListActivities()
        {
            try
            {
                var stockActivity = new BllStockActivity(dataPagination);
                stockActivity.ListAll();

                GridActivityList.Rows.Clear();
                for (int i = 0; i < stockActivity.ListOfRecords.Count; i++)
                {
                    GridActivityList.Rows.Add(
                    stockActivity.ListOfRecords[i].Id,
                    stockActivity.ListOfRecords[i].Type,
                    stockActivity.ListOfRecords[i].Date,
                    stockActivity.ListOfRecords[i].Hour,
                    stockActivity.ListOfRecords[i].Situation
                    );
                }

                AxlDataGridViewLealt.SortcolumnDesc(GridActivityList, 0);

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
                var stockActivity = new BllStockActivity(dataPagination)
                {
                    QueryByStartDate = Convert.ToDateTime(TxtQueryByStartDate.Value).ToString("dd-MM-yyyy"),
                    QueryByFinalDate = Convert.ToDateTime(TxtQueryByFinalDate.Value).ToString("dd-MM-yyyy"),
                    QueryByType = CboActivityType.Text,
                    QueryByActivityNumber = TxtQueryByActvityNumber.Text,
                    QueryBySituation = CboActivitySituation.Text
                };

                stockActivity.FetchData();

                GridActivityList.Rows.Clear();

                for (int i = 0; i < stockActivity.ListOfRecords.Count; i++)
                {
                    GridActivityList.Rows.Add(
                    stockActivity.ListOfRecords[i].Id,
                    stockActivity.ListOfRecords[i].Type,
                    stockActivity.ListOfRecords[i].Date,
                    stockActivity.ListOfRecords[i].Hour,
                    stockActivity.ListOfRecords[i].Situation
                    );
                }

                SetInBadingNavigator(dataPagination);

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region Delete()
        private void Delete()
        {
            try
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(GridActivityList.CurrentRow.Cells["idColumn"].Value);

                    var stockActivity = new BllStockActivity();

                    if (stockActivity.Delete(id) == true)
                    {
                        MessageBox.Show(BllNotification.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(BllNotification.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ViewData()
        private void ViewData()
        {
            try
            {
                int id = Convert.ToInt32(
                GridActivityList.CurrentRow.Cells["id"].Value
                );

                var frmStockActivityRegister = new FrmStockActivityRegister();
                frmStockActivityRegister.GetActivityDetails(id);
                frmStockActivityRegister.ListItems();
                frmStockActivityRegister.ShowDialog();

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
                var id = new DataGridViewTextBoxColumn();
                var activityType = new DataGridViewTextBoxColumn();
                var actvityDate = new DataGridViewTextBoxColumn();
                var activityHour = new DataGridViewTextBoxColumn();
                var actvitySituation = new DataGridViewTextBoxColumn();
                var btnViewData = new DataGridViewImageColumn();
                var btnDelete = new DataGridViewImageColumn();

                var dataGrid = GridActivityList;

                dataGrid.Columns.Add(id);
                dataGrid.Columns[0].Name = "id";
                dataGrid.Columns[0].HeaderText = "ID";
                dataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].Visible = false;
                dataGrid.Columns[0].ReadOnly = true;

                dataGrid.Columns.Add(activityType);
                dataGrid.Columns[1].Width = 100;
                dataGrid.Columns[1].Name = "activityType";
                dataGrid.Columns[1].HeaderText = "TIPO";
                dataGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[1].ReadOnly = true;

                dataGrid.Columns.Add(actvityDate);
                dataGrid.Columns[2].Width = 100;
                dataGrid.Columns[2].Name = "actvityDate";
                dataGrid.Columns[2].HeaderText = "DATA";
                dataGrid.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                dataGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].ReadOnly = true;

                dataGrid.Columns.Add(activityHour);
                dataGrid.Columns[3].Name = "activityHour";
                dataGrid.Columns[3].HeaderText = "HÓRA";
                dataGrid.Columns[3].Width = 100;
                dataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].DisplayIndex = 2;
                dataGrid.Columns[3].ReadOnly = true;
                dataGrid.Columns[3].Visible = true;

                dataGrid.Columns.Add(actvitySituation);
                dataGrid.Columns[4].Width = 100;
                dataGrid.Columns[4].Name = "actvitySituation";
                dataGrid.Columns[4].HeaderText = "SITUAÇÃO";
                dataGrid.Columns[4].ReadOnly = true;
                dataGrid.Columns[4].Visible = true;

                dataGrid.Columns.Add(btnViewData);
                dataGrid.Columns[5].Name = "btnViewData";
                dataGrid.Columns[5].HeaderText = "";
                dataGrid.Columns[5].Width = 70;
                dataGrid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[5].ReadOnly = true;
                btnViewData.ImageLayout = DataGridViewImageCellLayout.Normal;
                btnViewData.Image = Resources.Visualizar2;

                dataGrid.Columns.Add(btnDelete);
                dataGrid.Columns[6].Name = "btnDelete";
                dataGrid.Columns[6].HeaderText = "";
                dataGrid.Columns[6].Width = 70;
                dataGrid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[6].ReadOnly = true;
                btnDelete.ImageLayout = DataGridViewImageCellLayout.Normal;
                btnDelete.Image = Resources.Deletar;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region ListAllComboBox()
        private void ListAllComboBox()
        {
            try
            {
                List<string> listaTipo = new List<string>()
                {
                    "Entrada",
                    "Saída"
                };

                CboActivityType.DataSource = listaTipo;


                List<string> listaSituacao = new List<string>()
                {
                    "Em Aberto",
                    "Finalizada"
                };

                CboActivitySituation.DataSource = listaSituacao;

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

            ListAllComboBox();

            //Defini o lealt do datagridviw
            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridActivityList);

            //Exibi a data atual para usuáio, no formato long
            LblToDayIsDay.Text = DateTime.Now.ToLongDateString();

            //Defini uma data inicial e final
            var firstDay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            var lastDay = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            var startDate = firstDay;
            var finalDate = lastDay + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year;

            TxtQueryByStartDate.Text = Convert.ToString(startDate);
            TxtQueryByFinalDate.Text = Convert.ToString(finalDate);
        }

        #endregion

        #region TimerStartQuery()
        private void TimerStartQuery()
        {
            PicLoading.Visible = true;
            TimerExecuteQuery.Enabled = false;
            TimerExecuteQuery.Enabled = true;
        }
        #endregion

        #region TimerStopQuery()
        public void TimerStopQuery()
        {
            PicLoading.Visible = false;
            TimerExecuteQuery.Enabled = false;
        }
        #endregion

        #region ConfigureDataPagination()
        private void ConfigureDataPagination()
        {
            dataPagination.OffSetValue = 0;
            dataPagination.PageSize = 20;
            dataPagination.CurrentPage = 1;
        }
        #endregion

        #region SetInBadingNavigator()

        private void SetInBadingNavigator(AxlDataPagination dataPagination)
        {
            var legend = " Página " + dataPagination.CurrentPage + " de " + dataPagination.NumberOfPages;
            BindingPagination.Items[2].Text = legend;

            legend = " Total de " + dataPagination.RecordCount + " registro(s)";
            BindingPagination.Items[6].Text = legend;
        }

        #endregion 

        #endregion
    }
}
