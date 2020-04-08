using DimStock.AuxilyTools;
using DimStock.Models;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class UserListingForm : Form
    {
        #region Builder

        public UserListingForm()
        {
            InitializeComponent();
            InitializeSettings();
        }

        #endregion

        #region Properties
        private AuxiliaryDataPage pagination = new AuxiliaryDataPage();
        #endregion

        #region Form

        private void UserListingForm_Load(object sender, EventArgs e)
        {
            ListData();
        }

        #endregion

        #region Button

        private void ButtonRegisterNew_Click(object sender, EventArgs e)
        {
            var form = new UserLoginAddForm()
            {
                FormBorderStyle = FormBorderStyle.Sizable,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            };

            form.ShowDialog();
        }

        private void ButtonDataList_Click(object sender, EventArgs e)
        {
            ListData();
        }

        #endregion

        #region TextBox

        private void TextSearchFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
            PictureLoading.Visible = true;
        }

        #endregion 

        #region DataGrid

        private void DatagridUser_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = DatagridUser.Columns[
                e.ColumnIndex].Name;

                int id = Convert.ToInt32(
                DatagridUser.CurrentRow.Cells["id"].Value);

                switch (columnName)
                {
                    case "delete":

                        Remove(id);
                        break;

                    case "edit":

                        var form = new UserLoginAddForm()
                        {
                            FormBorderStyle = FormBorderStyle.Sizable,
                            MaximizeBox = false,
                            MinimizeBox = false,
                            ShowInTaskbar = false
                        };

                        form.GetDetail(id);

                        form.ShowDialog();

                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void DatagridUser_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridUser.Rows[e.RowIndex].Selected = true;
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

        #region Function

        private void ListData()
        {
            try
            {
                DatagridUser.Rows.Clear();

                var user = new UserLoginModel(pagination);
                user.ListData();

                for (int i = 0; i < user.List.Count; i++)
                {
                    DatagridUser.Rows.Add(
                    user.List[i].Id,
                    user.List[i].Name,
                    user.List[i].Email);
                }

                DatagridUser.ClearSelection();

                AuxiliaryDataGridLealt.SortColumnDesc(DatagridUser, 0);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void FetchData()
        {
            try
            {
                DatagridUser.Rows.Clear();

                var user = new UserLoginModel(pagination)
                {
                    Name = TextSearchFields.Text,
                    Email = TextSearchFields.Text,
                };

                user.FetchData();

                for (int i = 0; i < user.List.Count; i++)
                {
                    DatagridUser.Rows.Add(
                    user.List[i].Id,
                    user.List[i].Name,
                    user.List[i].Email);
                }

                DatagridUser.ClearSelection();

                AuxiliaryDataGridLealt.SortColumnDesc(DatagridUser, 0);
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void Remove(int id)
        {
            try
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var user = new UserLoginModel();

                    if (user.Remove(id) == true)
                    {
                        MessageBox.Show(MessageNotifier.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(MessageNotifier.Message, "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        private void InitializeSettings()
        {
            CreateColumnInTheDataList();

            AuxiliaryDataGridLealt.SetDefaultStyle(DatagridUser);
        }

        private void CreateColumnInTheDataList()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var userName = new DataGridViewTextBoxColumn();
                var email = new DataGridViewTextBoxColumn();
                var edit = new DataGridViewLinkColumn();
                var delete = new DataGridViewLinkColumn();

                var dataGrid = DatagridUser;

                dataGrid.Columns.Add(id);
                dataGrid.Columns[0].Name = "id";
                dataGrid.Columns[0].HeaderText = "ID";
                dataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].ReadOnly = false;
                dataGrid.Columns[0].Visible = false;

                dataGrid.Columns.Add(userName);
                dataGrid.Columns[1].Width = 250;
                dataGrid.Columns[1].Name = "userName";
                dataGrid.Columns[1].HeaderText = "Nome";
                dataGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[1].ReadOnly = true;

                dataGrid.Columns.Add(email);
                dataGrid.Columns[2].Name = "email";
                dataGrid.Columns[2].HeaderText = "Email";
                dataGrid.Columns[2].ReadOnly = true;
                dataGrid.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                edit.Text = "Editar";
                edit.TrackVisitedState = false;
                edit.UseColumnTextForLinkValue = true;
                edit.LinkColor = Color.Black;
                edit.ActiveLinkColor = Color.MediumAquamarine;
                dataGrid.Columns.Add(edit);
                edit.ToolTipText = "edit";
                dataGrid.Columns[3].Name = "edit";
                dataGrid.Columns[3].HeaderText = "";
                dataGrid.Columns[3].Width = 70;
                dataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].ReadOnly = true;

                delete.Text = "Deletar";
                delete.TrackVisitedState = false;
                delete.UseColumnTextForLinkValue = true;
                delete.LinkColor = Color.Black;
                delete.ActiveLinkColor = Color.MediumAquamarine;
                dataGrid.Columns.Add(delete);
                delete.ToolTipText = "delete";
                dataGrid.Columns[4].Name = "delete";
                dataGrid.Columns[4].HeaderText = "";
                dataGrid.Columns[4].Width = 70;
                dataGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].ReadOnly = true;
            }
            catch (Exception ex)
            {
                ExceptionNotifier.ShowMessage(ex);
            }
        }

        #endregion
    }
}
