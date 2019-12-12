using System;
using System.Windows.Forms;
using DimStock.Auxiliary;
using DimStock.Business;

namespace DimStock.View
{
    public partial class FrmStockDestinationRegister : Form
    {
        #region Variables
        private int id = 0;
        #endregion 

        #region Constructs
        public FrmStockDestinationRegister()
        {
            InitializeComponent();

            InitializeSettings();
        }
        #endregion

        #region UserForm

        #region FrmStockDestinationRegister_Load()
        private void FrmStockDestinationRegister_Load(object sender, EventArgs e)
        {
            ListAll();
        }
        #endregion

        #endregion

        #region Button

        #region BtnRegister_Click()
        private void BtnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateInputData() == true)
                {
                    var stockDestination = new BllStockDestination
                    {
                        Location = TxtDestinationLocation.Text.TrimStart().TrimEnd()
                    };

                    if (stockDestination.Register() == true)
                    {
                        MessageBox.Show(BllNotification.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                        CallAllReset();
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

        #region BtnEdit_Click()
        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    var stockDestination = new BllStockDestination
                    {
                        Location = TxtDestinationLocation.Text.TrimStart().TrimEnd()
                    };

                    if (stockDestination.Edit(id) == true)
                    {
                        MessageBox.Show(BllNotification.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um registro para editar!", "SELECIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region BtnDelete_Click()
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id > 0)
                {
                    var stockDestination = new BllStockDestination();

                    if (stockDestination.Delete(id) == true)
                    {
                        MessageBox.Show(BllNotification.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Selecione um registro para deletar!", "SELECIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
            finally
            {
                CallAllReset();
            }
        }
        #endregion

        #region BtnUpdateList_Click()
        private void BtnUpdateList_Click(object sender, EventArgs e)
        {
            ListAll();
            CallAllReset();
        }
        #endregion 

        #endregion 

        #region DataGrid

        #region GridDestinationList_DoubleClick()
        private void GridDestinationList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (GridDestinationList.Rows.Count > 0)
                {
                    id = Convert.ToInt32(GridDestinationList.CurrentRow.Cells["id"].Value);

                    var stockDestination = new BllStockDestination();
                    stockDestination.ViewData(id);

                    TxtDestinationLocation.Text = stockDestination.Location;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #endregion

        #region Methods

        #region ValidateInputData()
        private bool ValidateInputData()
        {
            var validationState = false;

            if (TxtDestinationLocation.Text == "" || TxtDestinationLocation.Text == null)
            {
                MessageBox.Show("Informe o nome de um destino Ex: Loja1", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                validationState = true;
            }

            return validationState;
        }
        #endregion

        #region ListAll()
        private void ListAll()
        {
            try
            {
                var stockDestination = new BllStockDestination();
                stockDestination.ListAll();

                GridDestinationList.Rows.Clear();

                for (int i = 0; i < stockDestination.ListOfRecords.Count; i++)
                {
                    GridDestinationList.Rows.Add(
                    stockDestination.ListOfRecords[i].Id,
                    stockDestination.ListOfRecords[i].Location);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region CreateColumnInTheDataGrid()
        private void CreateColumnInTheDataGrid()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var destinationLocation = new DataGridViewTextBoxColumn();

                var dataGrid = GridDestinationList;

                dataGrid.Columns.Add(id);
                dataGrid.Columns[0].Name = "id";
                dataGrid.Columns[0].HeaderText = "ID";
                dataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].Visible = false;
                dataGrid.Columns[0].ReadOnly = true;

                dataGrid.Columns.Add(destinationLocation);
                dataGrid.Columns[1].Width = 400;
                dataGrid.Columns[1].Name = "destinationLocation";
                dataGrid.Columns[1].HeaderText = "NOME";
                dataGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[1].ReadOnly = true;

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
            CreateColumnInTheDataGrid();

            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridDestinationList);

        }
        #endregion

        #region ResetControls()
        private void ResetControls()
        {
            try
            {
                TxtDestinationLocation.Text = string.Empty;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ResetVariables()
        private void ResetVariables()
        {
            try
            {
                id = 0;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region CallAllReset()
        private void CallAllReset()
        {
            ResetControls();
            ResetVariables();
        }
        #endregion

        #endregion 
    }
}
