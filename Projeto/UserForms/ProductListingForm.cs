using DimStock.Auxiliarys;
using DimStock.Business;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class ProductListingForm : Form
    {
        #region Variables

        public int Id = 0;
        private AxlDataPagination dataPagination = new AxlDataPagination();
        private ProductPhoto productPhoto = new ProductPhoto();

        #endregion

        #region Constructs

        public ProductListingForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

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
                GifLoading.Left = this.Width / 2 - GifLoading.Width / 2;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region Button

        private void NewRegister_Click(object sender, EventArgs e)
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

        private void DataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new Product(dataPagination)
                {
                    InternalCode = SearchByCode.Text,
                    Description = SearchByDescription.Text
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

        private void SearchByFields_KeyPress(object sender, KeyPressEventArgs e)
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

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            SearchData();
        }

        #endregion

        #region DataGridView

        private void ProductDataList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }

        private void ProductDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ProductDataList.Rows.Count != 0)
            {
                Id = Convert.ToInt32(
                ProductDataList.CurrentRow.Cells["id"].Value);

                var columnName = ProductDataList.Columns
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
                        Delete();
                        break;
                }
            }
        }

        private void ProductDataList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewDetails();
        }

        private void ProductDataList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                ProductDataList.Rows[e.RowIndex].Selected = true;
            }
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

        #region MethodsAxiliarys

        private void SearchData()
        {
            try
            {
                var product = new Product(dataPagination)
                {
                    InternalCode = SearchByCode.Text,
                    Description = SearchByDescription.Text
                };

                product.SearchData();

                ProductDataList.Rows.Clear();

                for (int i = 0; i < product.List.Count; i++)
                {
                    ProductDataList.Rows.Add(
                    product.List[i].Id,
                    product.List[i].InternalCode,
                    product.List[i].Description,
                    product.List[i].CostPrice,
                    product.List[i].SalePrice,
                    product.List[i].Photo);
                }

                ProductDataList.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(dataPagination);
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
                userForm.BoxProductCategoryList.Text = product.Category.Description.ToString();
                userForm.InternalCode.Text = product.InternalCode.ToString();
                userForm.Description.Text = product.Description;
                userForm.CostPrice.Text = product.CostPrice.ToString();
                userForm.SalePrice.Text = product.SalePrice.ToString();
                userForm.BarCode.Text = product.BarCode;
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

            RecordsByPage.DataSource = itemList;
            RecordsByPage.Text = "20 Registros";

        }

        private void Delete()
        {
            try
            {
                var user = new User();
                user.ViewDetails(AxlLogin.Id);

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
                    Convert.ToString(ProductDataList.CurrentRow.Cells
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
                productForm.BoxProductCategoryList.Text = product.Category.Description;
                productForm.InternalCode.Text = product.InternalCode;
                productForm.Description.Text = product.Description;
                productForm.CostPrice.Text = product.CostPrice.ToString();
                productForm.SalePrice.Text = product.SalePrice.ToString();
                productForm.BarCode.Text = product.BarCode;
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

                SearchByCode.Select();
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

        private void InitializeSettings()
        {
            AxlDataGridLealt.SetDefaultStyle(ProductDataList);

            FillAllComboBoxes();

            CreateColumnsInTheDataList();
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
                var internalCode = new DataGridViewTextBoxColumn();
                var description = new DataGridViewTextBoxColumn();
                var costPrice = new DataGridViewTextBoxColumn();
                var salePrice = new DataGridViewTextBoxColumn();
                var photo = new DataGridViewTextBoxColumn();
                var edit = new DataGridViewLinkColumn();
                var delete = new DataGridViewLinkColumn();
                var replicate = new DataGridViewLinkColumn();

                var productDataList = ProductDataList;

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


