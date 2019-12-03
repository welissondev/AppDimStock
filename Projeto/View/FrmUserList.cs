using DimStock.Auxiliary;
using System;
using System.Windows.Forms;
using DimStock.Business;
using DimStock.Properties;

namespace DimStock.View
{
    public partial class FrmUserList : Form
    {
        #region Variables
        private readonly int numberOfRecords = 100;
        #endregion

        #region Constructs

        #region FrmUserList()
        public FrmUserList()
        {
            InitializeComponent();

            CreateColumnInTheDataGrid();

            AxlDataGridViewLealt.DefaultLayoutDarkblue(GridUserList);

            LblTodayIsDay.Text = DateTime.Now.ToLongDateString();

        }
        #endregion

        #endregion

        #region UserForm

        #region FrmUserList_Load()
        private void FrmUserList_Load(object sender, EventArgs e)
        {
            ListAll();
        }
        #endregion

        #endregion

        #region Button

        #region BtnNew_Click()
        private void BtnNew_Click(object sender, EventArgs e)
        {
            using (var frmUserRegister = new FrmUserRegister())
            {
                frmUserRegister.ShowDialog();
            }
        }
        #endregion

        #region BtnUpdateList_Click()
        private void BtnUpdateList_Click(object sender, EventArgs e)
        {
            ListAll();
        }
        #endregion

        #endregion

        #region TextBox

        #region TxtQueryByUser_KeyPress()
        private void TxtQueryByUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            TimerExecuteQuery.Enabled = false;
            TimerExecuteQuery.Enabled = true;
            PicLoading.Visible = true;
        }
        #endregion

        #endregion 

        #region DataGrid

        #region GridUserList_CellMouseClick()
        private void GridUserList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = GridUserList.Columns[e.ColumnIndex].Name;

                if (GridUserList.Rows.Count > 0)
                {

                    int id = Convert.ToInt32(GridUserList.CurrentRow.Cells["id"].Value);

                    if (columnName == "btnDelete")
                    {

                        Delete(id);
                    }
                    else if (columnName == "btnEdit")
                    {
                        ViewData(id);
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GridUserList_CellMouseMove()
        private void GridUserList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = GridUserList.Columns[e.ColumnIndex].Name;
                if (columnName == "btnEdit" || columnName == "btnDelete")
                {
                    GridUserList.Cursor = Cursors.Hand;
                }
                else
                {
                    GridUserList.Cursor = Cursors.Arrow;
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #endregion 

        #region Timer

        #region TimeExecuteQuery_Tick()
        private void TimeExecuteQuery_Tick(object sender, EventArgs e)
        {
            PicLoading.Visible = false;
            TimerExecuteQuery.Enabled = false;
            FetchData();
        }
        #endregion

        #endregion

        #region Methods

        #region ListAll()
        private void ListAll()
        {
            try
            {
                GridUserList.Rows.Clear();

                var user = new BllUser();
                user.ListAll(numberOfRecords);

                for (int i = 0; i < user.ListOfRecords.Count; i++)
                {
                    GridUserList.Rows.Add(
                    user.ListOfRecords[i].Id,
                    user.ListOfRecords[i].YourName,
                    user.ListOfRecords[i].Email);
                }

                AxlDataGridViewLealt.SortcolumnDesc(GridUserList, 0);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ViewData()
        public void ViewData(int id)
        {
            try
            {
                var user = new BllUser();
                user.ViewData(id);

                using (var frmUserRegister = new FrmUserRegister(user.Id))
                {
                    frmUserRegister.TxtName.Text = user.YourName;
                    frmUserRegister.TxtEmail.Text = user.Email;
                    frmUserRegister.TxtEmail.Enabled = false;
                    frmUserRegister.TxtLogin.Text = user.Login;
                    frmUserRegister.TxtLogin.Enabled = false;
                    frmUserRegister.TxtPassWord.Text = user.PassWord;
                    frmUserRegister.TxtConfirmPassWord.Text = user.PassWord;
                    frmUserRegister.ChkPermissionToRegister.Checked = user.PermissionToRegister;
                    frmUserRegister.ChkPermissionToEdit.Checked = user.PermissionToEdit;
                    frmUserRegister.ChkPermissionToDelete.Checked = user.PermissionToDelete;
                    frmUserRegister.ChkPermissionToView.Checked = user.PermissionToView;
                    frmUserRegister.ChkAllPermissions.Checked = user.AllPermissions;

                    frmUserRegister.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region FetchData()
        private void FetchData()
        {
            try
            {
                GridUserList.Rows.Clear();

                var user = new BllUser();
                user.FetchData(TxtQueryByUser.Text, numberOfRecords);

                for (int i = 0; i < user.ListOfRecords.Count; i++)
                {
                    GridUserList.Rows.Add(
                    user.ListOfRecords[i].Id,
                    user.ListOfRecords[i].YourName,
                    user.ListOfRecords[i].Email);
                }

                AxlDataGridViewLealt.SortcolumnDesc(GridUserList, 0);
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region Delete()
        private void Delete(int id)
        {
            try
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var user = new BllUser();

                    if (user.Delete(id) == true)
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

        #region CreateColumnInTheDataGrid()
        private void CreateColumnInTheDataGrid()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var yourName = new DataGridViewTextBoxColumn();
                var email = new DataGridViewTextBoxColumn();
                var btnEdit = new DataGridViewImageColumn();
                var btnDelete = new DataGridViewImageColumn();

                var dataGrid = GridUserList;

                dataGrid.Columns.Add(id);
                dataGrid.Columns[0].Name = "id";
                dataGrid.Columns[0].HeaderText = "ID";
                dataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].ReadOnly = false;
                dataGrid.Columns[0].Visible = false;

                dataGrid.Columns.Add(yourName);
                dataGrid.Columns[1].Width = 250;
                dataGrid.Columns[1].Name = "yourName";
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

                dataGrid.Columns.Add(btnEdit);
                btnEdit.Image = Resources.Editar;
                btnEdit.ToolTipText = "Editar";
                btnEdit.ImageLayout = DataGridViewImageCellLayout.Normal;
                dataGrid.Columns[3].Name = "btnEdit";
                dataGrid.Columns[3].HeaderText = "";
                dataGrid.Columns[3].Width = 70;
                dataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].ReadOnly = true;

                dataGrid.Columns.Add(btnDelete);
                btnDelete.ToolTipText = "Deletar";
                btnDelete.Image = Resources.Deletar;
                btnDelete.ImageLayout = DataGridViewImageCellLayout.Normal;
                dataGrid.Columns[4].Name = "btnDelete";
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

        #endregion 
    }
}
