using DimStock.Auxiliarys;
using DimStock.Models;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class CategoryListingForm : Form
    {
        #region Builder

        public CategoryListingForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region Properties

        private AxlDataPage pagination = new AxlDataPage();
        public int Id = 0;

        #endregion

        #region Form

        private void ProductCategoryListingForm_Load(object sender, EventArgs e)
        {
            StartSearchTimer();
        }

        #endregion

        #region Button

        private void ButtonNewRegister_Click(object sender, EventArgs e)
        {
            var categoryForm = new CategoryAddForm()
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false
            };

            categoryForm.ShowDialog();
        }

        private void ButtonDataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        #endregion

        #region TextBox

        private void TextSearchByDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            pagination.OffSetValue = 0;
            pagination.CurrentPage = 1;
            StartSearchTimer();
        }

        #endregion

        #region ComboBox

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

        #region DataGrid

        private void DatagridCategory_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridCategory.Rows[e.RowIndex].Selected = true;
            }
        }

        private void DatagridCategory_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }

        private void DatagridCategory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatagridCategory.Rows.Count != 0)
            {
                Id = Convert.ToInt32(
                DatagridCategory.CurrentRow.Cells["id"].Value);

                var columnName = DatagridCategory.Columns
                [e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "edit":

                        Edit();

                        break;

                    case "delete":

                        Remove();

                        break;
                }
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

        #region Function

        private void FetchData()
        {
            try
            {
                var category = new ProductCategory(pagination)
                {
                    Description = TextSearchByDescription.Text,
                };

                category.FetchData();

                DatagridCategory.Rows.Clear();

                for (int i = 0; i < category.List.Count; i++)
                {
                    DatagridCategory.Rows.Add(
                    category.List[i].Id,
                    category.List[i].Description);
                }

                DatagridCategory.ClearSelection();

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
                if (Id == 0)
                {
                    MessageBox.Show("Selecione uma categoria " +
                    "para deletar!", "SELECIONE", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                    return;
                }

                if (MessageBox.Show("Confirma essa operação?", "IMPORTANTE",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var category = new ProductCategory();

                    if (category.Remove(Id) == false)
                    {
                        MessageBox.Show(AxlMessageNotifier.Message, "ERRO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }

                    MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void Edit()
        {
            try
            {
                var category = new ProductCategory();
                category.GetDetail(Id);

                var categoryForm = new CategoryAddForm()
                {
                    ShowInTaskbar = false,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                categoryForm.TextDescription.Text = category.Description;
                categoryForm.Id = Id;

                categoryForm.ShowDialog();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void FillAllComboBoxes()
        {
            var itemList = new List<string>
            {
                "20 Registros",
                "30 Registros",
                "70 Registros",
                "100 Registros"
            };

            ComboBoxRecordsByPage.DataSource = itemList;
            ComboBoxRecordsByPage.Text = "20 Registros";

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

        private void InitializeSettings()
        {
            AxlDataGridLealt.SetDefaultStyle(DatagridCategory);

            FillAllComboBoxes();

            CreateColumnsInTheDataList();
        }

        private void ResetProperties()
        {
            Id = 0;
            pagination.OffSetValue = 0;
            pagination.CurrentPage = 1;
        }

        private void ResetControls()
        {
            try
            {
                foreach (Control ctl in Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;
                }

                TextSearchByDescription.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void CallAllResets()
        {
            ResetProperties();
            ResetControls();
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

        private void CreateColumnsInTheDataList()
        {
            try
            {
                var id = new DataGridViewTextBoxColumn();
                var description = new DataGridViewTextBoxColumn();
                var edit = new DataGridViewLinkColumn();
                var delete = new DataGridViewLinkColumn();

                var categoryDataList = DatagridCategory;

                categoryDataList.Columns.Add(id);
                categoryDataList.Columns[0].Name = "id";
                categoryDataList.Columns[0].HeaderText = "ID";
                categoryDataList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                categoryDataList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                categoryDataList.Columns[0].Visible = false;
                categoryDataList.Columns[0].ReadOnly = true;

                description.Width = 600;
                categoryDataList.Columns.Add(description);
                categoryDataList.Columns[1].Name = "description";
                categoryDataList.Columns[1].HeaderText = "DESCRIÇÃO";
                categoryDataList.Columns[1].ReadOnly = true;

                edit.Text = "Editar";
                edit.TrackVisitedState = false;
                edit.UseColumnTextForLinkValue = true;
                edit.LinkColor = Color.Black;
                edit.ActiveLinkColor = Color.MediumAquamarine;
                categoryDataList.Columns.Add(edit);
                categoryDataList.Columns[2].Name = "edit";
                categoryDataList.Columns[2].HeaderText = "";
                categoryDataList.Columns[2].Width = 70;
                categoryDataList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                categoryDataList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                categoryDataList.Columns[2].ReadOnly = true;

                delete.Text = "Deletar";
                delete.TrackVisitedState = false;
                delete.UseColumnTextForLinkValue = true;
                delete.LinkColor = Color.Black;
                delete.ActiveLinkColor = Color.MediumAquamarine;
                categoryDataList.Columns.Add(delete);
                categoryDataList.Columns[3].Name = "delete";
                categoryDataList.Columns[3].HeaderText = "";
                categoryDataList.Columns[3].Width = 70;
                categoryDataList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                categoryDataList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                categoryDataList.Columns[3].ReadOnly = true;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion
    }
}
