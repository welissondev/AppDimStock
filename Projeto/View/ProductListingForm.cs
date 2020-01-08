using System;
using Syncfusion.Windows.Forms.Tools;
using System.Collections.Generic;
using System.Windows.Forms;
using DimStock.Business;
using DimStock.Auxiliary;
using DimStock.Properties;

namespace DimStock.View
{
    public partial class ProductListingForm : Form
    {

        #region Variables
        public int Id = 0;
        private DataPagination dataPagination = new DataPagination();
        private ProductPhothoController photoController = new ProductPhothoController();
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
            WindowState = FormWindowState.Maximized;
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
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion

        #region Button

        private void RegisterNew_Click(object sender, EventArgs e)
        {
            using (var userForm = new ProductRegistrationForm())
            {
                userForm.ShowDialog();
            }
        }

        private void UpdateDataList_Click(object sender, EventArgs e)
        {
            CallAllResets();
            StartSearchTimer();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var product = new ProductController(dataPagination)
                {
                    SearchByCode = SearchByCode.Text,
                    SearchBySize = SearchBySize.Text,
                    SearchByReference = SearchByReference.Text,
                    SearchByDescription = SearchByDescription.Text
                };

                product.ListData();

                var path = "DimStock.Report.RpvProduct.rdlc";
                var description = "Relatório de Produtos";
                var dataset = "DataSetProduct";

                product.GenerateReport(product.ListOfRecords);

                ReportViewForm.ShowReport(path, description, true,
                new Dictionary<string, object>() {{dataset,
                product.ListOfRecords}});

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
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
                ExceptionAssistant.Message.Show(ex);
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

                    case "change":
                        ViewDetails();
                        break;

                    case "exclude":
                        Exclude();
                        break;
                }
            }
        }

        private void ProductDataList_CellMouseMove(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var columnName = ProductDataList.Columns[
                e.ColumnIndex].Name;

                var arrowCursor = Cursors.Arrow;
                var handCursor = Cursors.Hand;

                ProductDataList.Cursor = arrowCursor;

                switch (columnName)
                {
                    case "change":
                        ProductDataList.Cursor = handCursor;
                        break;

                    case "exclude":
                        ProductDataList.Cursor = handCursor;
                        break;

                    case "replicate":
                        ProductDataList.Cursor = handCursor;
                        break;
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void ProductDataList_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ViewDetails();
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
                var product = new ProductController(dataPagination)
                {
                    SearchByCode = SearchByCode.Text,
                    SearchBySize = SearchBySize.Text,
                    SearchByReference = SearchByReference.Text,
                    SearchByDescription = SearchByDescription.Text,
                };

                product.SearchData();

                ProductDataList.Rows.Clear();

                for (int i = 0; i < product.ListOfRecords.Count; i++)
                {
                    ProductDataList.Rows.Add(
                    product.ListOfRecords[i].Id,
                    product.ListOfRecords[i].Code,
                    product.ListOfRecords[i].Reference,
                    product.ListOfRecords[i].Size,
                    product.ListOfRecords[i].Supplier,
                    product.ListOfRecords[i].Description,
                    product.ListOfRecords[i].CostPrice,
                    product.ListOfRecords[i].SalePrice);
                }

                ProductDataList.ClearSelection();

                PauseSearchTimer();

                SetInBadingNavigator(dataPagination);
            }
            catch (Exception ex)
            {
                PauseSearchTimer();

                ExceptionAssistant.Message.Show(ex);
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

                var product = new ProductController();
                product.ViewDetails(Id);

                userForm.Id = product.Id;
                userForm.ProductCode.Text = product.Code.ToString();
                userForm.ProductSize.Text = product.Size.ToString();
                userForm.ProductReference.Text = product.Reference.ToString();
                userForm.Supplier.Text = product.Supplier;
                userForm.Description.Text = product.Description;
                userForm.MinStock.Text = product.MinStock.ToString();
                userForm.MaxStock.Text = product.MaxStock.ToString();
                userForm.CostPrice.Text = product.CostPrice.ToString();
                userForm.SalePrice.Text = product.SalePrice.ToString();
                userForm.BarCode.Text = product.BarCode;
                userForm.ReloadPhoto(product.PhotoName);
                userForm.ShowDialog();

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
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

        private void Exclude()
        {
            try
            {
                var user = new UserController();
                user.ViewDetails(LoginAssistant.Id);

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
                    var product = new ProductController();

                    if (product.Delete(Id) == false)
                    {
                        MessageBox.Show(NotificationController.Message, "ATENÇÃO",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        return;
                    }

                    var photoPath = photoController.GetDirectoryPeth() +
                    Convert.ToString(ProductDataList.CurrentRow.Cells
                    ["photoName"].Value);

                    photoController.DeleteFromDirectory(photoPath);

                    MessageBox.Show(NotificationController.Message, "SUCESSO",
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

            var userForm = new ProductRegistrationForm();

            try
            {
                var product = new ProductController();

                product.ViewDetails(Id);

                userForm.ProductCode.Text = product.Code.ToString();
                userForm.ProductSize.Text = product.Size.ToString();
                userForm.ProductReference.Text = product.Reference.ToString();
                userForm.Supplier.Text = product.Supplier;
                userForm.Description.Text = product.Description;
                userForm.MinStock.Text = product.MinStock.ToString();
                userForm.MaxStock.Text = product.MaxStock.ToString();
                userForm.CostPrice.Text = product.CostPrice.ToString();
                userForm.SalePrice.Text = product.SalePrice.ToString();
                userForm.BarCode.Text = product.BarCode;
                userForm.ReloadPhoto(product.PhotoName, true);
                userForm.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
            finally
            {
                userForm.Dispose();
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
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void CallAllResets()
        {
            ResetVariables();
            ResetControls();
        }

        private void InitializeSettings()
        {
            FormCaption.Text = @"Lista de Produtos";

            DayOfTheWeek.Text = DateTime.Now.ToLongDateString();

            DataGridLealt.SetDefaultStyle(ProductDataList);

            FillAllComboBoxes();

            CreateColumnsInTheDataList();
        }

        private void SetInBadingNavigator(DataPagination dataPagination)
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
                var code = new DataGridViewTextBoxColumn();
                var reference = new DataGridViewTextBoxColumn();
                var size = new DataGridViewTextBoxColumn();
                var supplier = new DataGridViewTextBoxColumn();
                var description = new DataGridViewTextBoxColumn();
                var costPrice = new DataGridViewTextBoxColumn();
                var salePrice = new DataGridViewTextBoxColumn();
                var photoName = new DataGridViewTextBoxColumn();
                var change = new DataGridViewImageColumn();
                var exclude = new DataGridViewImageColumn();
                var replicate = new DataGridViewImageColumn();

                var productDataList = ProductDataList;

                productDataList.Columns.Add(id);
                productDataList.Columns[0].Name = "id";
                productDataList.Columns[0].HeaderText = "ID";
                productDataList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[0].Visible = false;
                productDataList.Columns[0].ReadOnly = true;

                productDataList.Columns.Add(code);
                productDataList.Columns[1].Width = 80;
                productDataList.Columns[1].Name = "code";
                productDataList.Columns[1].HeaderText = "CÓD.";
                productDataList.Columns[1].ToolTipText = "Código do produto";
                productDataList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[1].ReadOnly = true;

                productDataList.Columns.Add(reference);
                productDataList.Columns[2].Width = 80;
                productDataList.Columns[2].Name = "reference";
                productDataList.Columns[2].HeaderText = "REF.";
                productDataList.Columns[2].ToolTipText = "Número de referência do produto";
                productDataList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[2].ReadOnly = true;

                productDataList.Columns.Add(size);
                productDataList.Columns[3].Name = "size";
                productDataList.Columns[3].HeaderText = "TAM.";
                productDataList.Columns[3].ToolTipText = "O tamanho do produto";
                productDataList.Columns[3].Width = 80;
                productDataList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[3].DisplayIndex = 2;
                productDataList.Columns[3].ReadOnly = true;
                productDataList.Columns[3].Visible = true;

                productDataList.Columns.Add(supplier);
                productDataList.Columns[4].Width = 250;
                productDataList.Columns[4].Name = "supplier";
                productDataList.Columns[4].HeaderText = "FORNECEDOR";
                productDataList.Columns[4].ReadOnly = true;
                productDataList.Columns[4].Visible = true;
                productDataList.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                productDataList.Columns.Add(description);
                productDataList.Columns[5].Name = "description";
                productDataList.Columns[5].HeaderText = "DESCRIÇÃO";
                productDataList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                productDataList.Columns[5].ReadOnly = true;

                productDataList.Columns.Add(costPrice);
                productDataList.Columns[6].Name = "costPrice";
                productDataList.Columns[6].HeaderText = "PREÇO CUSTO";
                productDataList.Columns[6].Width = 120;
                productDataList.Columns[6].DefaultCellStyle.Format = "c2";
                productDataList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                productDataList.Columns[6].ReadOnly = true;

                productDataList.Columns.Add(salePrice);
                productDataList.Columns[7].Name = "salePrice";
                productDataList.Columns[7].HeaderText = "PREÇO VENDA";
                productDataList.Columns[7].Width = 120;
                productDataList.Columns[7].DefaultCellStyle.Format = "c2";
                productDataList.Columns[7].ReadOnly = true;

                productDataList.Columns.Add(photoName);
                productDataList.Columns[8].Name = "photoName";
                productDataList.Columns[8].HeaderText = "Nome da Foto";
                productDataList.Columns[8].ReadOnly = true;
                productDataList.Columns[8].Visible = false;

                productDataList.Columns.Add(replicate);
                replicate.Image = Resources.Duplicar;
                replicate.ImageLayout = DataGridViewImageCellLayout.Normal;
                productDataList.Columns[9].Name = "replicate";
                productDataList.Columns[9].HeaderText = "";
                productDataList.Columns[9].Width = 70;
                productDataList.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[9].ReadOnly = true;

                productDataList.Columns.Add(change);
                productDataList.Columns[10].Name = "change";
                productDataList.Columns[10].HeaderText = "";
                productDataList.Columns[10].Width = 70;
                productDataList.Columns[10].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[10].ReadOnly = true;
                change.ImageLayout = DataGridViewImageCellLayout.Normal;
                change.Image = Resources.Editar;

                productDataList.Columns.Add(exclude);
                productDataList.Columns[11].Name = "exclude";
                productDataList.Columns[11].HeaderText = "";
                productDataList.Columns[11].Width = 70;
                productDataList.Columns[11].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                productDataList.Columns[11].ReadOnly = true;
                exclude.ImageLayout = DataGridViewImageCellLayout.Normal;
                exclude.Image = Resources.Deletar;

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion

    }
}


