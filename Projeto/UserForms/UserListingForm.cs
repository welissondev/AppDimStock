using DimStock.Auxiliarys;
using DimStock.Business;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class UserListingForm : Form
    {
        #region Variables
        private AxlDataPagination dataPagination = new AxlDataPagination();
        #endregion

        #region Constructs

        public UserListingForm()
        {
            InitializeComponent();
            InitializeSettings();
        }

        #endregion

        #region UserForm

        private void UserListingForm_Load(object sender, EventArgs e)
        {
            ListData();
        }

        #endregion

        #region Button

        private void RegisterNew_Click_1(object sender, EventArgs e)
        {
            var form = new UserResgistrationForm()
            {
                FormBorderStyle = FormBorderStyle.Sizable,
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            };

            form.ShowDialog();
        }

        private void DataList_Click(object sender, EventArgs e)
        {
            ListData();
        }

        #endregion

        #region TextBox

        private void SearchFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
            GifLoading.Visible = true;
        }

        #endregion 

        #region DataGrid

        private void UserDataList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = UserDataList.Columns[
                e.ColumnIndex].Name;

                int id = Convert.ToInt32(
                UserDataList.CurrentRow.Cells["id"].Value);

                switch (columnName)
                {
                    case "delete":

                        Delete(id);
                        break;

                    case "edit":

                        var form = new UserResgistrationForm()
                        {
                            FormBorderStyle = FormBorderStyle.Sizable,
                            MaximizeBox = false,
                            MinimizeBox = false,
                            ShowInTaskbar = false
                        };

                        form.ViewDetails(id);

                        form.ShowDialog();

                        break;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void UserDataList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                UserDataList.Rows[e.RowIndex].Selected = true;
            }
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

        #region MethodsAuxiliarys

        private void ListData()
        {
            try
            {
                UserDataList.Rows.Clear();

                var user = new User(dataPagination);
                user.ListData();

                for (int i = 0; i < user.ListOfRecords.Count; i++)
                {
                    UserDataList.Rows.Add(
                    user.ListOfRecords[i].Id,
                    user.ListOfRecords[i].Name,
                    user.ListOfRecords[i].Email);
                }

                UserDataList.ClearSelection();

                AxlDataGridLealt.SortColumnDesc(UserDataList, 0);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void SearchData()
        {
            try
            {
                UserDataList.Rows.Clear();

                var user = new User(dataPagination)
                {
                    SearchByName = SearchFields.Text,
                    SearchByEmail = SearchFields.Text,
                };

                user.SearchData();

                for (int i = 0; i < user.ListOfRecords.Count; i++)
                {
                    UserDataList.Rows.Add(
                    user.ListOfRecords[i].Id,
                    user.ListOfRecords[i].Name,
                    user.ListOfRecords[i].Email);
                }

                UserDataList.ClearSelection();

                AxlDataGridLealt.SortColumnDesc(UserDataList, 0);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void Delete(int id)
        {
            try
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var user = new User();

                    if (user.Delete(id) == true)
                    {
                        MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(AxlMessageNotifier.Message, "AVISO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void InitializeSettings()
        {
            CreateColumnInTheDataList();

            AxlDataGridLealt.SetDefaultStyle(UserDataList);
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

                var dataGrid = UserDataList;

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
                AxlException.Message.Show(ex);
            }
        }

        #endregion
    }
}
