using DimStock.Auxiliarys;
using DimStock.Business;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class ProductCategoryListingForm : Form
    {
        #region Variables

        private AxlDataPagination dataPagination = new AxlDataPagination();
        public int Id = 0;

        #endregion

        #region Constructs

        public ProductCategoryListingForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region UserForm

        private void ProductCategoryListingForm_Load(object sender, EventArgs e)
        {
            StartSearchTimer();
        }

        #endregion

        #region Buttons

        private void NewRegister_Click(object sender, EventArgs e)
        {
            var categoryForm = new ProductCategoryRegistrationForm()
            {
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false
            };

            categoryForm.ShowDialog();
        }

        private void DataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        #endregion

        #region TextBox

        private void SearchByDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
            StartSearchTimer();
        }

        #endregion

        #region ComboBox

        private void RecordsByPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var itemSelected = RecordsByPage.SelectedIndex;

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
                StartSearchTimer();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region DataGrid

        private void CategoryDataList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                CategoryDataList.Rows[e.RowIndex].Selected = true;
            }
        }

        private void CategoryDataList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }

        private void CategoryDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CategoryDataList.Rows.Count != 0)
            {
                Id = Convert.ToInt32(
                CategoryDataList.CurrentRow.Cells["id"].Value);

                var columnName = CategoryDataList.Columns
                [e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "edit":

                        Modify();

                        break;

                    case "delete":

                        Delete();

                        break;
                }
            }
        }

        #endregion

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            SearchData();
        }

        #endregion

        #region BadingNavigator

        private void NextPage_Click(object sender, EventArgs e)
        {
            if (dataPagination.CurrentPage < dataPagination.NumberOfPages)
            {
                dataPagination.CurrentPage += 1;
                dataPagination.OffSetValue += dataPagination.PageSize;
                StartSearchTimer();
            }

            SetInBadingNavigator(dataPagination);
        }

        private void BackPage_Click(object sender, EventArgs e)
        {
            if (dataPagination.CurrentPage > 1)
            {
                dataPagination.CurrentPage -= 1;
                dataPagination.OffSetValue -= dataPagination.PageSize;
                StartSearchTimer();
            }

            SetInBadingNavigator(dataPagination);
        }

        #endregion

        #region MethodsAuxiliarys

        private void SearchData()
        {
            try
            {
                var category = new ProductCategory(dataPagination)
                {
                    Description = SearchByDescription.Text,
                };

                category.SearchData();

                CategoryDataList.Rows.Clear();

                for (int i = 0; i < category.ListOfRecords.Count; i++)
                {
                    CategoryDataList.Rows.Add(
                    category.ListOfRecords[i].Id,
                    category.ListOfRecords[i].Description);
                }

                CategoryDataList.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(dataPagination);
            }
            catch (Exception ex)
            {
                PauseSearchTimer();

                AxlException.Message.Show(ex);
            }
        }

        private void Delete()
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

                    if (category.Delete(Id) == false)
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

        private void Modify()
        {
            try
            {
                var category = new ProductCategory();
                category.ViewDetails(Id);

                var categoryForm = new ProductCategoryRegistrationForm()
                {
                    ShowInTaskbar = false,
                    MaximizeBox = false,
                    MinimizeBox = false
                };

                categoryForm.Description.Text = category.Description;
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

            RecordsByPage.DataSource = itemList;
            RecordsByPage.Text = "20 Registros";

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

        private void InitializeSettings()
        {
            AxlDataGridLealt.SetDefaultStyle(CategoryDataList);

            FillAllComboBoxes();

            CreateColumnsInTheDataList();
        }

        private void ResetVariables()
        {
            Id = 0;
            dataPagination.OffSetValue = 0;
            dataPagination.CurrentPage = 1;
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

                SearchByDescription.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void CallAllResets()
        {
            ResetVariables();
            ResetControls();
        }

        private void StartSearchTimer()
        {
            GifLoading.Visible = true;
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
        }

        private void PauseSearchTimer()
        {
            GifLoading.Visible = false;
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

                var categoryDataList = CategoryDataList;

                categoryDataList.Columns.Add(id);
                categoryDataList.Columns[0].Name = "id";
                categoryDataList.Columns[0].HeaderText = "ID";
                categoryDataList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                categoryDataList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                categoryDataList.Columns[0].Visible = false;
                categoryDataList.Columns[0].ReadOnly = true;

                categoryDataList.Columns.Add(description);
                categoryDataList.Columns[1].Name = "description";
                categoryDataList.Columns[1].HeaderText = "DESCRIÇÃO";
                categoryDataList.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
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
