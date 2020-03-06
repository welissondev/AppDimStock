using DimStock.Auxiliarys;
using DimStock.Models;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class ProductListingForm : Form
    {
        #region Builder

        public ProductListingForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region Properties

        public int Id = 0;
        private AxlDataPage pagination = new AxlDataPage();
        private ProductPhoto productPhoto = new ProductPhoto();

        #endregion

        #region Form

        private void ProductListingForm_Load(object sender, EventArgs e)
        {
            StartSearchTimer();
        }

        private void ProductListingForm_Resize(object sender, EventArgs e)
        {
            try
            {
                // Centraliza ImgGifLoading no formulário
                PictureLoading.Left = this.Width / 2 - PictureLoading.Width / 2;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region Button

        private void ButtonNewRegister_Click(object sender, EventArgs e)
        {
            var form = new ProductRegistrationForm()
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false
            };

            form.ShowDialog();
        }

        private void ButtonDataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product(pagination)
                {
                    InternalCode = TextSearchByCode.Text,
                    Description = TextSearchByDescription.Text
                };

                product.GenerateReport(product.List);

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region TextBox

        private void TextSearchByFields_KeyPress(object sender, KeyPressEventArgs e)
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

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            FetchData();
        }

        #endregion

        #region DataGrid

        private void DatagridProduct_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }

        private void DatagridProductt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DatagridProduct.Rows.Count != 0)
            {
                Id = Convert.ToInt32(
                DatagridProduct.CurrentRow.Cells["id"].Value);

                var columnName = DatagridProduct.Columns
                [e.ColumnIndex].Name;

                switch (columnName)
                {
                    case "replicate":
                        ReplicateRegistration();
                        break;

                    case "edit":
                        ViewDetails();
                        break;

                    case "delete":
                        Remove();
                        break;
                }
            }
        }

        private void DatagridProduct_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewDetails();
        }

        private void DatagridProduct_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DatagridProduct.Rows[e.RowIndex].Selected = true;
            }
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
                var product = new Product(pagination)
                {
                    InternalCode = TextSearchByCode.Text,
                    Description = TextSearchByDescription.Text
                };

                product.FetchData();

                DatagridProduct.Rows.Clear();

                for (int i = 0; i < product.List.Count; i++)
                {
                    DatagridProduct.Rows.Add(
                    product.List[i].Id,
                    product.List[i].InternalCode,
                    product.List[i].Description,
                    product.List[i].CostPrice,
                    product.List[i].SalePrice,
                    product.List[i].Photo);
                }

                DatagridProduct.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(pagination);
            }
            catch (Exception ex)
            {
                PauseSearchTimer();

                AxlException.Message.Show(ex);
            }
        }

        private void ViewDetails()
        {
            var userForm = new ProductRegistrationForm();

            try
            {
                if (Id == 0)
                {
                    MessageBox.Show("Selecione um item para visualizar!", "SELECIONE",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                var product = new Product();
                product.GetDetail(Id);

                userForm.Id = product.Id;
                userForm.CategoryId = product.Category.Id;
                userForm.ComboBoxCategoryList.Text = product.Category.Description.ToString();
                userForm.TextInternalCode.Text = product.InternalCode.ToString();
                userForm.TextDescription.Text = product.Description;
                userForm.TextCostPrice.Text = product.CostPrice.ToString();
                userForm.TextSalePrice.Text = product.SalePrice.ToString();
                userForm.TextBarCode.Text = product.BarCode;
                userForm.ReloadPhoto(product.Photo);
                userForm.ShowInTaskbar = false;
                userForm.ShowDialog();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
            finally
            {
                userForm.Dispose();
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

        private void Remove()
        {
            try
            {
                var user = new User();
                user.GetDetail(AxlLogin.Id);

                if (user.PermissionToDelete == false)
                {
                    MessageBox.Show("Você não tem permissão!", "NÃO PERMITIDO",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return;
                }

                if (MessageBox.Show("Confirma essa operação?", "IMPORTANTE",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var product = new Product();

                    if (product.Remove(Id) == false)
                    {
                        MessageBox.Show(AxlMessageNotifier.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }

                    var photoPath = productPhoto.GetDirectoryPeth() +
                    Convert.ToString(DatagridProduct.CurrentRow.Cells
                    ["Photo"].Value);

                    productPhoto.DeleteFromDirectory(photoPath);

                    MessageBox.Show(AxlMessageNotifier.Message, "SUCESSO",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CallAllResets();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERRO",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ReplicateRegistration()
        {
            var productForm = new ProductRegistrationForm();

            try
            {
                var product = new Product();
                product.GetDetail(Id);

                productForm.CategoryId = product.Category.Id;
                productForm.ComboBoxCategoryList.Text = product.Category.Description;
                productForm.TextInternalCode.Text = product.InternalCode;
                productForm.TextDescription.Text = product.Description;
                productForm.TextCostPrice.Text = product.CostPrice.ToString();
                productForm.TextSalePrice.Text = product.SalePrice.ToString();
                productForm.TextBarCode.Text = product.BarCode;
                productForm.ReloadPhoto(product.Photo, true);
                productForm.ShowInTaskbar = false;
                productForm.ShowDialog();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
            finally
            {
                productForm.Dispose();
            }
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

                TextSearchByCode.Select();
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

        private void InitializeSettings()
        {
            AxlDataGridLealt.SetDefaultStyle(DatagridProduct);

            FillAllComboBoxes();

            CreateColumnsInTheDataList();
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
                var internalCode = new DataGridViewTextBoxColumn();
                var description = new DataGridViewTextBoxColumn();
                var costPrice = new DataGridViewTextBoxColumn();
                var salePrice = new DataGridViewTextBoxColumn();
                var photo = new DataGridViewTextBoxColumn();
                var edit = new DataGridViewLinkColumn();
                var delete = new DataGridViewLinkColumn();
                var replicate = new DataGridViewLinkColumn();

                var productDataList = DatagridProduct;

                productDataList.Columns.Add(id);
                productDataList.Columns[0].Name = "id";
                productDataList.Columns[0].HeaderText = "ID";
                productDataList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[0].Visible = false;
                productDataList.Columns[0].ReadOnly = true;

                productDataList.Columns.Add(internalCode);
                productDataList.Columns[1].Width = 80;
                productDataList.Columns[1].Name = "internalCode";
                productDataList.Columns[1].HeaderText = "CÓDIGO";
                productDataList.Columns[1].ToolTipText = "Código do produto";
                productDataList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                productDataList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                productDataList.Columns[1].ReadOnly = true;

                productDataList.Columns.Add(description);
                productDataList.Columns[2].Name = "description";
                productDataList.Columns[2].HeaderText = "DESCRIÇÃO";
                productDataList.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                productDataList.Columns[2].ReadOnly = true;

                productDataList.Columns.Add(costPrice);
                productDataList.Columns[3].Name = "costPrice";
                productDataList.Columns[3].HeaderText = "PREÇO CUSTO";
                productDataList.Columns[3].Width = 120;
                productDataList.Columns[3].DefaultCellStyle.Format = "c2";
                productDataList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                productDataList.Columns[3].ReadOnly = true;

                productDataList.Columns.Add(salePrice);
                productDataList.Columns[4].Name = "salePrice";
                productDataList.Columns[4].HeaderText = "PREÇO VENDA";
                productDataList.Columns[4].Width = 120;
                productDataList.Columns[4].DefaultCellStyle.Format = "c2";
                productDataList.Columns[4].ReadOnly = true;

                productDataList.Columns.Add(photo);
                productDataList.Columns[5].Name = "photo";
                productDataList.Columns[5].HeaderText = "Nome da Foto";
                productDataList.Columns[5].ReadOnly = true;
                productDataList.Columns[5].Visible = false;

                replicate.Text = "Replicar";
                replicate.TrackVisitedState = false;
                replicate.UseColumnTextForLinkValue = true;
                replicate.LinkColor = Color.Black;
                replicate.ActiveLinkColor = Color.MediumAquamarine;
                productDataList.Columns.Add(replicate);
                productDataList.Columns[6].Name = "replicate";
                productDataList.Columns[6].HeaderText = "";
                productDataList.Columns[6].Width = 70;
                productDataList.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[6].ReadOnly = true;

                edit.Text = "Editar";
                edit.TrackVisitedState = false;
                edit.UseColumnTextForLinkValue = true;
                edit.LinkColor = Color.Black;
                edit.ActiveLinkColor = Color.MediumAquamarine;
                productDataList.Columns.Add(edit);
                productDataList.Columns[7].Name = "edit";
                productDataList.Columns[7].HeaderText = "";
                productDataList.Columns[7].Width = 70;
                productDataList.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[7].ReadOnly = true;

                delete.Text = "Deletar";
                delete.TrackVisitedState = false;
                delete.UseColumnTextForLinkValue = true;
                delete.LinkColor = Color.Black;
                delete.ActiveLinkColor = Color.MediumAquamarine;
                productDataList.Columns.Add(delete);
                productDataList.Columns[8].Name = "delete";
                productDataList.Columns[8].HeaderText = "";
                productDataList.Columns[8].Width = 70;
                productDataList.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[8].ReadOnly = true;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion
    }
}


