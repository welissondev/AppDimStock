using DimStock.AuxilyTools.AuxilyClasses;
using DimStock.Models;
using System;
using System.Windows.Forms;

namespace DimStock.Screens
{
    public partial class DestinationAddScreen : Form
    {
        #region Builder

        public DestinationAddScreen()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region Properties

        private int id = 0;

        #endregion 

        #region Form

        private void StockDestinationAddForm_Load(object sender, EventArgs e)
        {
            ListData();
        }

        #endregion

        #region Button

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData() == false)
                {
                    return;
                }

                var stockDestination = new DestinationModel
                {
                    Location = TextDestinationLocation.Text.TrimStart().TrimEnd()
                };

                if (stockDestination.Insert() == true)
                {

                    MessageBox.Show(MessageNotifier.Message, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CallAllReset();
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Selecione um registro para editar!", "SELECIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var stockDestination = new DestinationModel
                {
                    Location = TextDestinationLocation.Text.TrimStart().TrimEnd()
                };

                if (stockDestination.Update(id) == true)
                {
                    MessageBox.Show(MessageNotifier.Message, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    MessageBox.Show("Selecione um registro para deletar!", "SELECIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                var stockDestination = new DestinationModel();

                if (stockDestination.Delete(id) == true)
                {
                    MessageBox.Show(MessageNotifier.Message, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CallAllReset();
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ButtonDataList_Click(object sender, EventArgs e)
        {
            ListData();

            CallAllReset();
        }

        #endregion

        #region DataGrid

        private void DatagridDestination_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                GetDetail();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void DatagridDestination_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridDestination.Rows[e.RowIndex].Selected = true;
            }
        }

        #endregion

        #region Function

        private bool ValidateData()
        {
            if (TextDestinationLocation.Text == "" || TextDestinationLocation.Text == null)
            {
                MessageBox.Show("Informe o nome de um destino Ex: Loja1", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }

            return true;
        }

        private void GetDetail()
        {
            if (DatagridDestination.Rows.Count > 0)
            {
                id = Convert.ToInt32(DatagridDestination.CurrentRow.Cells["id"].Value);

                var stockDestination = new DestinationModel();
                stockDestination.GetDetail(id);

                TextDestinationLocation.Text = stockDestination.Location;
            }
        }

        private void ListData()
        {
            try
            {
                var stockDestination = new DestinationModel();
                stockDestination.ListData();

                DatagridDestination.Rows.Clear();

                for (int i = 0; i < stockDestination.List.Count; i++)
                {
                    DatagridDestination.Rows.Add(
                    stockDestination.List[i].Id,
                    stockDestination.List[i].Location);
                }

                DatagridDestination.ClearSelection();
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ResetControls()
        {
            try
            {
                TextDestinationLocation.Text = string.Empty;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void ResetProperties()
        {
            try
            {
                id = 0;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void CallAllReset()
        {
            ResetControls();
            ResetProperties();
        }

        private void InitializeSettings()
        {
            CreateColumnInTheDataList();

            AuxiliaryDataGridLealt.SetDefaultStyle(DatagridDestination);
        }

        private void CreateColumnInTheDataList()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var destinationLocation = new DataGridViewTextBoxColumn();

                var dataGrid = DatagridDestination;

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
                dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[1].ReadOnly = true;

            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        #endregion
    }
}
