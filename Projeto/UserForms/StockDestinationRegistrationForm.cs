using DimStock.Auxiliarys;
using DimStock.Business;
using System;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class StockDestinationRegistrationForm : Form
    {
        #region Variables

        private int id = 0;

        #endregion 

        #region Constructs

        public StockDestinationRegistrationForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region UserForm

        private void StockDestinationRegistrationForm_Load(object sender, EventArgs e)
        {
            ListData();
        }

        #endregion

        #region Button

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() == false)
                {
                    return;
                }

                var stockDestination = new StockDestination
                {
                    Location = DestinationLocation.Text.TrimStart().TrimEnd()
                };

                if (stockDestination.Register() == true)
                {

                    MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CallAllReset();
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Selecione um registro para editar!", "SELECIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var stockDestination = new StockDestination
                {
                    Location = DestinationLocation.Text.TrimStart().TrimEnd()
                };

                if (stockDestination.Edit(id) == true)
                {
                    MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Selecione um registro para deletar!", "SELECIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var stockDestination = new StockDestination();

                if (stockDestination.Delete(id) == true)
                {
                    MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CallAllReset();
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void DataList_Click(object sender, EventArgs e)
        {
            ListData();

            CallAllReset();
        }

        #endregion

        #region DataGrid

        private void DestinationDataList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                ViewDetails();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void DestinationDataList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DestinationDataList.Rows[e.RowIndex].Selected = true;
            }
        }

        #endregion

        #region Methods

        private bool ValidateData()
        {
            if (DestinationLocation.Text == "" || DestinationLocation.Text == null)
            {
                MessageBox.Show("Informe o nome de um destino Ex: Loja1", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        private void ViewDetails()
        {
            if (DestinationDataList.Rows.Count > 0)
            {
                id = Convert.ToInt32(DestinationDataList.CurrentRow.Cells["id"].Value);

                var stockDestination = new StockDestination();
                stockDestination.ViewDetails(id);

                DestinationLocation.Text = stockDestination.Location;
            }
        }

        private void ListData()
        {
            try
            {
                var stockDestination = new StockDestination();
                stockDestination.ListData();

                DestinationDataList.Rows.Clear();

                for (int i = 0; i < stockDestination.ListOfRecords.Count; i++)
                {
                    DestinationDataList.Rows.Add(
                    stockDestination.ListOfRecords[i].Id,
                    stockDestination.ListOfRecords[i].Location);
                }

                DestinationDataList.ClearSelection();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ResetControls()
        {
            try
            {
                DestinationLocation.Text = string.Empty;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

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

        private void CallAllReset()
        {
            ResetControls();
            ResetVariables();
        }

        private void InitializeSettings()
        {
            CreateColumnInTheDataList();

            AxlDataGridLealt.SetDefaultStyle(DestinationDataList);
        }

        private void CreateColumnInTheDataList()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var destinationLocation = new DataGridViewTextBoxColumn();

                var dataGrid = DestinationDataList;

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
                dataGrid.Columns[1].HeaderText = "DESTINO";
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
    }
}
