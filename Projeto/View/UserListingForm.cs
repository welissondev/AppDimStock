using DimStock.Auxiliary;
using System;
using System.Windows.Forms;
using DimStock.Business;
using DimStock.Properties;

namespace DimStock.View
{
    public partial class UserListingForm : Form
    {

        #region Variables
        private DataPagination dataPagination = new DataPagination();
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

        private void RegisterNew_Click(object sender, EventArgs e)
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

        private void UpdateDataList_Click(object sender, EventArgs e)
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
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void UserDataList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = UserDataList.Columns
                [e.ColumnIndex].Name;

                var arrowCursor = Cursors.Arrow;
                var handCursor = Cursors.Hand;

                UserDataList.Cursor = arrowCursor;

                switch (columnName)
                {
                    case "edit":
                        UserDataList.Cursor = handCursor;
                        break;

                    case "delete":
                        UserDataList.Cursor = handCursor;
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
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

                DataGridLealt.SortColumnDesc(UserDataList, 0);
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
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

                DataGridLealt.SortColumnDesc(UserDataList, 0);
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
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
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void InitializeSettings()
        {
            CreateColumnInTheDataList();

            DataGridLealt.SetDefaultStyle(UserDataList);

            DayOfTheWeek.Text = DateTime.Now.ToLongDateString();
        }

        private void CreateColumnInTheDataList()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var userName = new DataGridViewTextBoxColumn();
                var email = new DataGridViewTextBoxColumn();
                var edit = new DataGridViewImageColumn();
                var delete = new DataGridViewImageColumn();

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

                dataGrid.Columns.Add(edit);
                edit.Image = Resources.Editar;
                edit.ToolTipText = "edit";
                edit.ImageLayout = DataGridViewImageCellLayout.Normal;
                dataGrid.Columns[3].Name = "edit";
                dataGrid.Columns[3].HeaderText = "";
                dataGrid.Columns[3].Width = 70;
                dataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].ReadOnly = true;

                dataGrid.Columns.Add(delete);
                delete.ToolTipText = "delete";
                delete.Image = Resources.Deletar;
                delete.ImageLayout = DataGridViewImageCellLayout.Normal;
                dataGrid.Columns[4].Name = "delete";
                dataGrid.Columns[4].HeaderText = "";
                dataGrid.Columns[4].Width = 70;
                dataGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].ReadOnly = true;
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion
    }
}
