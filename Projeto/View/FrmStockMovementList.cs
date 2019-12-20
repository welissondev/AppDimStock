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
    public partial class FrmStockMovementList : Form
    {
        #region Variables

        private AxlDataPagination dataPagination = new AxlDataPagination();
        private string operationSituation = string.Empty;
        private string operationType = string.Empty;
        
        #endregion 

        #region Constructs

        public FrmStockMovementList()
        {
            InitializeComponent();

            InitializeSettings();
        }
        
        #endregion

        #region Form

        private void FrmStockMovementList_Load(object sender, EventArgs e)
        {
            ConfigureDataPagination();
            TimerStartQuery();
        }
        
        #endregion

        #region Button

        private void BtnUpdateList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
            TimerStartQuery();
        }
        
        #endregion

        #region TextBox

        private void QueryByStockMovementId_TextChanged(object sender, EventArgs e)
        {
            QueryTimer.Enabled = false;
            QueryTimer.Enabled = true;
            ImageLoading.Visible = true;
        }

        #endregion

        #region ComboBox

        private void OperationTypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = OperationTypeList.SelectedIndex;

                switch (itemSelected)
                {
                    case 0:
                        operationType = string.Empty;
                        break;

                    case 1:
                        operationType = "Entrada";
                        break;

                    case 2:
                        operationType = "Saída";
                        break;
                }

                dataPagination.OffSetValue = 0;
                dataPagination.CurrentPage = 1;
                TimerStartQuery();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        
        private void OperationSituationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = OperationSituationList.SelectedIndex;

                switch (itemSelected)
                {
                    case 0:
                        operationSituation = string.Empty;
                        break;

                    case 1:
                        operationSituation = "Em Aberto";
                        break;

                    case 2:
                        operationSituation = "Finalizada";
                        break;
                }

                dataPagination.OffSetValue = 0;
                dataPagination.CurrentPage = 1;
                TimerStartQuery();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        
        private void PageSizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = PageSizeList.SelectedIndex;

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
                TimerStartQuery();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        
        #endregion

        #region Label

        private void ClearSearchFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CallAllResets();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        
        #endregion

        #region DataGridView

        private void StockMovementList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = StockMovementList.Columns[e.ColumnIndex].Name;

                if (columnName == "details" || columnName == "delete")
                {
                    StockMovementList.Cursor = Cursors.Hand;
                }
                else
                {
                    StockMovementList.Cursor = Cursors.Arrow;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
         
        private void StockMovementList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (StockMovementList.Rows.Count > 0)
            {
                var columnName = StockMovementList.Columns[e.ColumnIndex].Name;

                if (columnName == "details" && e.RowIndex != -1)
                {
                    GetStockMovementDetails();
                }
                else if (columnName == "delete" && e.RowIndex != -1)
                {
                    Delete();
                }
            }
        }
       
        #endregion

        #region Timer

        private void QueryTimer_Tick(object sender, EventArgs e)
        {
            QueryTimer.Enabled = false;
            ImageLoading.Visible = false;
            FetchData();
        }
        
        #endregion

        #region BadingNavigator

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (dataPagination.CurrentPage < dataPagination.NumberOfPages)
            {
                dataPagination.CurrentPage += 1;
                dataPagination.OffSetValue += dataPagination.PageSize;
                TimerStartQuery();
            }
        }
        
        private void BackPage_Click(object sender, EventArgs e)
        {
            if (dataPagination.CurrentPage > 1)
            {
                dataPagination.CurrentPage -= 1;
                dataPagination.OffSetValue -= dataPagination.PageSize;
                TimerStartQuery();
            }
        }
        
        #endregion 

        #region MethodsAxiliarys

        public void FetchData()
        {
            try
            {
                var stockMovement = new BllStockMovement(dataPagination)
                {
                    QueryByType = operationType,
                    QueryByMovimentId = QueryByStockMovimentId.Text,
                    QueryBySituation = operationSituation
                };

                stockMovement.FetchData();

                StockMovementList.Rows.Clear();

                for (int i = 0; i < stockMovement.ListOfRecords.Count; i++)
                {
                    StockMovementList.Rows.Add(
                    stockMovement.ListOfRecords[i].Id,
                    stockMovement.ListOfRecords[i].OperationType,
                    stockMovement.ListOfRecords[i].OperationDate,
                    stockMovement.ListOfRecords[i].OperationHour,
                    stockMovement.ListOfRecords[i].OperationSituation
                    );
                }

                SetInBadingNavigator(dataPagination);

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
 
        private void Delete()
        {
            try
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(StockMovementList.CurrentRow.Cells["id"].Value);

                    var stockMovement = new BllStockMovement();

                    if (stockMovement.Delete(id) == true)
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

        private void GetStockMovementDetails()
        {
            try
            {
                int id = Convert.ToInt32(
                StockMovementList.CurrentRow.Cells["id"].Value
                );

                var form = new FrmStockMovementRegister();
                form.GetStockMovementDetails(id);
                form.ListItems();
                form.ShowDialog();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ListAllComboBox()
        {
            try
            {
                List<string> typeList = new List<string>()
                {
                    "Todos",
                    "Entrada",
                    "Saída"
                };

                OperationTypeList.DataSource = typeList;
                OperationTypeList.Text = "Todos";


                List<string> situationList = new List<string>()
                {
                    "Todos",
                    "Em Aberto",
                    "Finalizada"
                };

                OperationSituationList.DataSource = situationList;
                OperationSituationList.Text = "Todos";


                List<string> pageSizeList = new List<string>()
                {
                    "20 Registros",
                    "30 Registros",
                    "70 Registros",
                    "100 Registros"
                };

                PageSizeList.DataSource = pageSizeList;
                PageSizeList.Text = "20 Registros";

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        public void InitializeSettings()
        {

            CreateColumnsInTheDataGrid();

            ListAllComboBox();

            //Defini o lealt do datagridviw
            AxlDataGridViewLealt.DefaultLayoutDarkblue(StockMovementList);

            //Exibi a data atual para usuáio, no formato long
            TodayIsDay.Text = DateTime.Now.ToLongDateString();

        }

        private void TimerStartQuery()
        {
            ImageLoading.Visible = true;
            QueryTimer.Enabled = false;
            QueryTimer.Enabled = true;
        }

        public void TimerStopQuery()
        {
            ImageLoading.Visible = false;
            QueryTimer.Enabled = false;
        }

        private void ConfigureDataPagination()
        {
            dataPagination.OffSetValue = 0;
            dataPagination.PageSize = 20;
            dataPagination.CurrentPage = 1;
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

                OperationSituationList.Text = "Todos";
                OperationTypeList.Text = "Todos";
                PageSizeList.Text = dataPagination.PageSize + " Registros";

                QueryByStockMovimentId.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ResetVariables()
        {
            operationSituation = string.Empty;
            operationType = string.Empty;
        }

        private void CallAllResets()
        {
            ResetControls();
            ResetVariables();
        }

        private void CreateColumnsInTheDataGrid()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var operationType = new DataGridViewTextBoxColumn();
                var operationDate = new DataGridViewTextBoxColumn();
                var operationHour = new DataGridViewTextBoxColumn();
                var operationSituation = new DataGridViewTextBoxColumn();
                var details = new DataGridViewImageColumn();
                var delete = new DataGridViewImageColumn();

                var stockMovementList = StockMovementList;

                stockMovementList.Columns.Add(id);
                stockMovementList.Columns[0].Name = "id";
                stockMovementList.Columns[0].HeaderText = "ID";
                stockMovementList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[0].Visible = false;
                stockMovementList.Columns[0].ReadOnly = true;

                stockMovementList.Columns.Add(operationType);
                stockMovementList.Columns[1].Width = 100;
                stockMovementList.Columns[1].Name = "operationType";
                stockMovementList.Columns[1].HeaderText = "TIPO";
                stockMovementList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                stockMovementList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                stockMovementList.Columns[1].ReadOnly = true;

                stockMovementList.Columns.Add(operationDate);
                stockMovementList.Columns[2].Width = 100;
                stockMovementList.Columns[2].Name = "operationDate";
                stockMovementList.Columns[2].HeaderText = "DATA";
                stockMovementList.Columns[2].DefaultCellStyle.Format = "dd-MM-yyyy";
                stockMovementList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[2].ReadOnly = true;

                stockMovementList.Columns.Add(operationHour);
                stockMovementList.Columns[3].Name = "operationHour";
                stockMovementList.Columns[3].HeaderText = "HÓRA";
                stockMovementList.Columns[3].Width = 100;
                stockMovementList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[3].DisplayIndex = 2;
                stockMovementList.Columns[3].ReadOnly = true;
                stockMovementList.Columns[3].Visible = true;

                stockMovementList.Columns.Add(operationSituation);
                stockMovementList.Columns[4].Width = 100;
                stockMovementList.Columns[4].Name = "operationSituation";
                stockMovementList.Columns[4].HeaderText = "SITUAÇÃO";
                stockMovementList.Columns[4].ReadOnly = true;
                stockMovementList.Columns[4].Visible = true;

                stockMovementList.Columns.Add(details);
                stockMovementList.Columns[5].Name = "details";
                stockMovementList.Columns[5].HeaderText = "";
                stockMovementList.Columns[5].Width = 70;
                stockMovementList.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[5].ReadOnly = true;
                details.ImageLayout = DataGridViewImageCellLayout.Normal;
                details.Image = Resources.Visualizar2;

                stockMovementList.Columns.Add(delete);
                stockMovementList.Columns[6].Name = "delete";
                stockMovementList.Columns[6].HeaderText = "";
                stockMovementList.Columns[6].Width = 70;
                stockMovementList.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                stockMovementList.Columns[6].ReadOnly = true;
                delete.ImageLayout = DataGridViewImageCellLayout.Normal;
                delete.Image = Resources.Deletar;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion
    }
}
