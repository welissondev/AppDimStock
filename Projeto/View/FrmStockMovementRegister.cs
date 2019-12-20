using Syncfusion.Windows.Forms.Tools;
using DimStock.Auxiliary;
using DimStock.Business;
using DimStock.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.View
{
    public partial class FrmStockMovementRegister : Form
    {
        #region Get e Set
        public int StockId { get; set; }
        public int StockQuantity { get; set; }
        public int ProductId { get; set; }

        #endregion

        #region Variables
        private AxlDataPagination dataPagination = new AxlDataPagination();
        #endregion

        #region Constructs

        public FrmStockMovementRegister()
        {
            InitializeComponent();

            CreateColumnForStockList();

            ResetControl();

            FillStockDestinations();

            AxlDataGridViewLealt.DefaultLayoutDarkblue(MainDataList);
        }

        #endregion

        #region UserForm

        private void FrmStockMovementRegister_Load(object sender, EventArgs e)
        {
            TodayIsDay.Text = DateTime.Now.ToLongDateString();
        }

        private void FrmStockMovementRegister_Resize(object sender, EventArgs e)
        {
            try
            {
                // Centraliza image gif carregando no formulário
                ImageLoading.Left = MainDataList.Width / 2 - ImageLoading.Width / 2;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region Button

        private void AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddStockMovement() == true)
                {
                    GetStockMovementDetails(Convert.ToInt32(StockMovementId.Text));
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DeleteStockMovement();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            if (OperationSituation.Text == "Em Aberto")
            {
                if (CheckDataToAddItem() == true)
                {
                    RegisterItem();
                    ListItems();
                    ClearSearchFields();
                }
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            switch (OperationType.Text)
            {
                case "Entrada":

                    AllocateStock(); break;

                case "Saída":

                    DeallocateStock(); break;
            }
        }

        #endregion

        #region TextBox

        private void ShearchFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            ImageLoading.Visible = true;
            QueryTimer.Enabled = false;
            QueryTimer.Enabled = true;
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            TotalValue.Text = CalculateTotalValue(Convert.ToInt32(Quantity.Text), 
            Convert.ToDouble(UnitaryValue.DecimalValue)).ToString();
        }

        #endregion

        #region ComboBox

        private void StockDestinationList_DropDown(object sender, EventArgs e)
        {
            FillStockDestinations();
        }

        private void StockDestinationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (OperationSituation.Text == "Em Aberto")
                {
                    var stockMovement = new BllStockMovement
                    {
                        StockDestinationLocation = ((ComboBox)sender).SelectedItem.ToString()
                    };

                    stockMovement.AddDestination(Convert.ToInt32(StockMovementId.Text));
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region Timer

        private void QueryTimer_Tick(object sender, EventArgs e)
        {
            ImageLoading.Visible = false;
            QueryTimer.Enabled = false;
            StockQuery();
        }

        #endregion

        #region LabelLink

        private void AddNewStockDestination_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var form = new FrmStockDestinationRegister();
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ClearQueryFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearSearchFields();
            ResetControl();
            ListItems();
        }

        #endregion

        #region DataGridView

        private void MainDataList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (MainDataList.ListIsStock.Equals(true))
                {
                    ProductId = Convert.ToInt32(MainDataList.CurrentRow.Cells["productId"].Value);
                    ViewStockProductDetails(ProductId);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
    
        private void MainDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var columnName = MainDataList.Columns[e.ColumnIndex].Name;

                if (columnName == "delete")
                {
                    int id = Convert.ToInt32(MainDataList.CurrentRow.Cells["itemId"].Value);
                    DeleteItem(id);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void MainDataList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }

        #endregion

        #region MethodsAuxiliarys

        private void StockQuery()
        {
            try
            {
                var stockProduct = new BllStockProduct(dataPagination)
                {
                    QueryByCode = QueryByCode.Text,
                    QueryBySize = QueryBySize.Text,
                    QueryByReference = QueryByReference.Text,
                    QueryByDescription = QueryByDescription.Text,
                    QueryByResume = "All",
                };

                stockProduct.FetchData();

                MainDataList.Columns.Clear();

                CreateColumnForItemList();

                for (var i = 0; i < stockProduct.ListOfRecords.Count; i++)
                {
                    MainDataList.Rows.Add(
                    stockProduct.ListOfRecords[i].StockId,
                    stockProduct.ListOfRecords[i].ProductId,
                    stockProduct.ListOfRecords[i].ProductCode,
                    stockProduct.ListOfRecords[i].ProductSize,
                    stockProduct.ListOfRecords[i].ProductReference,
                    stockProduct.ListOfRecords[i].ProductDescription,
                    stockProduct.ListOfRecords[i].ProductCostPrice
                    );
                }

                MainDataList.Visible = true;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        public void ListItems()
        {
            try
            {
                var item = new BllStockItem();
                item.List(Convert.ToInt32(StockMovementId.Text));

                MainDataList.Columns.Clear();

                CreateColumnForStockList();

                for (int i = 0; i < item.ListOfRecords.Count; i++)
                {
                    MainDataList.Rows.Add(
                    item.ListOfRecords[i].Id,
                    item.ListOfRecords[i].StockId,
                    item.ListOfRecords[i].ProductCode,
                    item.ListOfRecords[i].ProductSize,
                    item.ListOfRecords[i].ProductReference,
                    item.ListOfRecords[i].ProductDescription,
                    item.ListOfRecords[i].Quantity,
                    item.ListOfRecords[i].UnitaryValue,
                    item.ListOfRecords[i].TotalValue
                    );
                }

                var totalValue = item.ListOfRecords.Sum(x => x.TotalValue);
                var totalItems = item.ListOfRecords.Count;

                SubTotal.Text = totalValue.ToString("c2");
                TotalItems.Text = totalItems.ToString();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private List<BllStock> GetItems()
        {
            var itemList = new List<BllStock>();

            for (int i = 0; i < MainDataList.Rows.Count; i++)
            {
                var id = MainDataList.Rows[i].Cells["stockId"].Value;
                var quantity = MainDataList.Rows[i].Cells["stockQuantity"].Value;
                var totalValue = MainDataList.Rows[i].Cells["stockTotalValue"].Value;
                totalValue.ToString().Replace("R$", "").Replace("$", "");

                var stock = new BllStock()
                {
                    Id = Convert.ToInt32(id),
                    Quantity = Convert.ToInt32(quantity),
                    TotalValue = Convert.ToDouble(totalValue)
                };

                itemList.Add(stock);
            }

            return itemList;
        }
        
        public void FillStockDestinations()
        {
            try
            {
                var destination = new BllStockDestination();
                destination.ListAll();

                var destinationList = new List<string>();

                for (int i = 0; i < destination.ListOfRecords.Count; i++)
                {
                    destinationList.Add(destination.ListOfRecords[i].Location);
                }

                StockDestinationList.DataSource = destinationList;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ViewStockProductDetails(int id)
        {
            var stockProduct = new BllStockProduct();
            stockProduct.ViewDetails(id);

            QueryByCode.Text = stockProduct.ProductCode.ToString();
            QueryBySize.Text = stockProduct.ProductSize.ToString();
            QueryByReference.Text = stockProduct.ProductReference.ToString();
            QueryByDescription.Text = stockProduct.ProductDescription;
            UnitaryValue.Text = stockProduct.ProductCostPrice.ToString();
            ProductId = stockProduct.ProductId;
            StockId = stockProduct.StockId;
            StockQuantity = stockProduct.StockQuantity;
            Quantity.Select();

            ListItems();
        }

        public bool AddStockMovement()
        {
            var stockMovement = new BllStockMovement();
            var addState = false;

            switch (OperationType.Text)
            {
                case "Entrada":
                    stockMovement.OperationType = OperationType.Text;
                    break;

                case "Saída":
                    stockMovement.OperationType = OperationType.Text;
                    break;
            }

            stockMovement.OperationDate = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));
            stockMovement.OperationHour = DateTime.Now.ToString("HH:mm:ss");
            stockMovement.OperationSituation = "Em Aberto";

            if (stockMovement.Register() == true)
            {
                addState = true;

                StockMovementId.Text = stockMovement.Id.ToString();
            }

            return addState;
        }
        
        public void GetStockMovementDetails(int id)
        {
            try
            {
                var stockMovement = new BllStockMovement();
                stockMovement.GetDetails(id);

                StockMovementId.Text = id.ToString();
                OperationType.Text = stockMovement.OperationType;
                OperationDate.Text = Convert.ToString(stockMovement.OperationDate.ToString("dd-MM-yyyy"));
                OperationHour.Text = stockMovement.OperationHour;
                OperationSituation.Text = stockMovement.OperationSituation;

                if (stockMovement.StockDestinationLocation != "" || stockMovement.StockDestinationLocation != null)
                    StockDestinationList.Text = stockMovement.StockDestinationLocation;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        
        private void DeleteStockMovement()
        {
            try
            {
                if (Convert.ToInt32(StockMovementId.Text) > 0 && OperationSituation.Text == "Finalizada")
                {
                    if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        var stockMovement = new BllStockMovement();

                        if (stockMovement.Delete(Convert.ToInt32(StockMovementId.Text)) == true)
                        {
                            MessageBox.Show(BllNotification.Message, "SUCESSO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        public void AllocateStock()
        {
            if (CheckDataToAddStock() == true)
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var stock = new BllStock();

                    if (stock.Allocate(GetItems(), Convert.ToInt32(StockMovementId.Text)) == true)
                    {
                        MessageBox.Show(BllNotification.Message, "SUCESSO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        OperationSituation.Text = "Finalizada";
                    }
                }
            }
        }
        
        public void DeallocateStock()
        {
            if (CheckDataToAddStock() == true)
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var stock = new BllStock();

                    if (stock.Deallocate(GetItems(), Convert.ToInt32(StockMovementId.Text)) == true)
                    {
                        MessageBox.Show(BllNotification.Message, "SUCESSO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        OperationSituation.Text = "Finalizada";
                    }
                }
            }
        }

        public void RegisterItem()
        {
            try
            {
                var stockItem = new BllStockItem()
                {
                    StockMovementId = Convert.ToInt32(StockMovementId.Text),
                    StockId = StockId,
                    ProductId = ProductId,
                    Quantity = Convert.ToInt32(Quantity.Text),
                    UnitaryValue = Convert.ToDouble(UnitaryValue.DecimalValue),
                    TotalValue = Convert.ToDouble(TotalValue.DecimalValue)
                };

                stockItem.Register();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        
        private double CalculateTotalValue(int quantity, double unitaryValue)
        {
            return quantity * unitaryValue;
        }
        
        private void DeleteItem(int id)
        {
            if (OperationSituation.Text != "Finalizada")
            {
                var item = new BllStockItem();
                item.Delete(id);

                ListItems();
            }
        }
        
        private bool CheckDataToAddItem()
        {
            if (Quantity.Text == "" || Quantity.Text == null || Convert.ToInt32(Quantity.Text) < 1)
            {
                MessageBox.Show("Informe a quantidade de estoque", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                Quantity.Select();

                return false;
            }

            else if (Convert.ToDouble(UnitaryValue.Text.Replace("R$", "").Replace("$", "")) == 0)
            {
                MessageBox.Show("Informe o valor unitário!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                UnitaryValue.Select();

                return false;
            }

            else if (OperationType.Text == "Saída" && StockQuantity < 1)
            {
                MessageBox.Show("Não é possível adicionar esse produto, " +
                "porque ele não tem estoque!", "SEM ESTOQUE",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else if (OperationType.Text == "Saída" && Convert.ToInt32(Quantity.Text) > StockQuantity)
            {
                MessageBox.Show("Esse produto não possui estoque suficiente, " +
                "atualize o estoque e tente novamente!", "ESTOQUE BAIXO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else if (CheckIfItemExists().Equals(true))
            {
                MessageBox.Show("Esse produto já foi adicionado!", "NÃO PERMITIDO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckDataToAddStock()
        {
            if (OperationSituation.Text == "Finalizada")
            {
                MessageBox.Show("Não é possível realizar essa operação pois a situação " +
                "do cadastro consta como finalizada!", "NÃO PERMITIDO", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                return false;
            }
            else if (GetItems().Count == 0)
            {
                MessageBox.Show("Nenhum estoque foi adicionado para essa operação!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CheckIfItemExists()
        {
            try
            {
                var itemExists = false;

                for (int i = 0; i < MainDataList.Rows.Count; i++)
                {
                    if (Convert.ToInt32(MainDataList.Rows[i].Cells["stockId"].Value) == StockId)
                    {
                        itemExists = true;
                    }
                }

                return itemExists;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
                return false;
            }
        }
        
        private void ClearSearchFields()
        {
            try
            {
                foreach (Control ctl in CardMain.Controls)
                {
                    if (ctl.GetType() == typeof(TextBoxExt))
                        ctl.Text = string.Empty;
                    if (ctl.GetType() == typeof(CurrencyTextBox))
                        ctl.Text = string.Empty;
                    if (ctl.GetType() == typeof(IntegerTextBox))
                        ctl.Text = string.Empty;
                }

                QueryByCode.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ResetControl()
        {
            MainDataList.Columns.Clear();
            CreateColumnForItemList();

            TotalItems.Text = "0";
            SubTotal.Text = "R$0,00";
            Quantity.Text = "0";
            QueryByCode.Select();
        }
        
        private void CreateColumnForItemList()
        {
            try
            {
                var stockId = new DataGridViewTextBoxColumn();
                var productId = new DataGridViewTextBoxColumn();
                var productCode = new DataGridViewTextBoxColumn();
                var productSize = new DataGridViewTextBoxColumn();
                var productReference = new DataGridViewTextBoxColumn();
                var productDescription = new DataGridViewTextBoxColumn();
                var productCostPrice = new DataGridViewTextBoxColumn();

                var mainDataList = MainDataList;
                mainDataList.ListIsStock = true;

                mainDataList.Columns.Add(stockId);
                mainDataList.Columns[0].Width = 100;
                mainDataList.Columns[0].Name = "stockId";
                mainDataList.Columns[0].HeaderText = "ID ESTOQUE";
                mainDataList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[0].Visible = false;

                mainDataList.Columns.Add(productId);
                mainDataList.Columns[1].Width = 100;
                mainDataList.Columns[1].Name = "productId";
                mainDataList.Columns[1].HeaderText = "ID PRODUTO";
                mainDataList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[1].Visible = false;

                mainDataList.Columns.Add(productCode);
                mainDataList.Columns[2].Width = 80;
                mainDataList.Columns[2].Name = "productCode";
                mainDataList.Columns[2].HeaderText = "CÓD.";
                mainDataList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[2].ReadOnly = true;

                mainDataList.Columns.Add(productSize);
                mainDataList.Columns[3].Width = 80;
                mainDataList.Columns[3].Name = "productSize";
                mainDataList.Columns[3].HeaderText = "TAM.";
                mainDataList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[3].ReadOnly = true;

                mainDataList.Columns.Add(productReference);
                mainDataList.Columns[4].Width = 80;
                mainDataList.Columns[4].Name = "productReference";
                mainDataList.Columns[4].HeaderText = "REF.";
                mainDataList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[4].ReadOnly = true;

                mainDataList.Columns.Add(productDescription);
                mainDataList.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                mainDataList.Columns[5].Name = "productDescription";
                mainDataList.Columns[5].HeaderText = "DESCRIÇÃO";
                mainDataList.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[5].ReadOnly = true;

                mainDataList.Columns.Add(productCostPrice);
                mainDataList.Columns[6].Name = "productCostPrice";
                mainDataList.Columns[6].HeaderText = "CUSTO";
                mainDataList.Columns[6].DefaultCellStyle.Format = "c2";
                mainDataList.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[6].ReadOnly = true;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void CreateColumnForStockList()
        {
            try
            {
                var itemId = new DataGridViewTextBoxColumn();
                var stockId = new DataGridViewTextBoxColumn();
                var productCode = new DataGridViewTextBoxColumn();
                var productSize = new DataGridViewTextBoxColumn();
                var productReference = new DataGridViewTextBoxColumn();
                var productDescription = new DataGridViewTextBoxColumn();
                var stockQuantity = new DataGridViewTextBoxColumn();
                var productCostPrice = new DataGridViewTextBoxColumn();
                var stockTotalValue = new DataGridViewTextBoxColumn();
                var delete = new DataGridViewImageColumn();

                var dataGrid = MainDataList;
                dataGrid.ListIsItem = true;

                dataGrid.Columns.Add(itemId);
                dataGrid.Columns[0].Width = 100;
                dataGrid.Columns[0].Name = "itemId";
                dataGrid.Columns[0].HeaderText = "ID ITEM";
                dataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[0].ReadOnly = true;
                dataGrid.Columns[0].Visible = false;

                dataGrid.Columns.Add(stockId);
                dataGrid.Columns[1].Width = 100;
                dataGrid.Columns[1].Name = "stockId";
                dataGrid.Columns[1].HeaderText = "ID ESTOQUE";
                dataGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[1].ReadOnly = true;
                dataGrid.Columns[1].Visible = false;

                dataGrid.Columns.Add(productCode);
                dataGrid.Columns[2].Width = 80;
                dataGrid.Columns[2].Name = "productCode";
                dataGrid.Columns[2].HeaderText = "CÓD.";
                dataGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].ReadOnly = true;

                dataGrid.Columns.Add(productSize);
                dataGrid.Columns[3].Width = 80;
                dataGrid.Columns[3].Name = "productSize";
                dataGrid.Columns[3].HeaderText = "TAM.";
                dataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[3].ReadOnly = true;

                dataGrid.Columns.Add(productReference);
                dataGrid.Columns[4].Width = 80;
                dataGrid.Columns[4].Name = "productReference";
                dataGrid.Columns[4].HeaderText = "REF.";
                dataGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[4].ReadOnly = true;

                dataGrid.Columns.Add(productDescription);
                dataGrid.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[5].Name = "productDescription";
                dataGrid.Columns[5].HeaderText = "DESCRIÇÃO";
                dataGrid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[5].ReadOnly = true;

                dataGrid.Columns.Add(stockQuantity);
                dataGrid.Columns[6].Width = 50;
                dataGrid.Columns[6].Name = "stockQuantity";
                dataGrid.Columns[6].HeaderText = "QTD.";
                dataGrid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[6].ReadOnly = true;

                dataGrid.Columns.Add(productCostPrice);
                dataGrid.Columns[7].Name = "productCostPrice";
                dataGrid.Columns[7].HeaderText = "VALOR UNI.";
                dataGrid.Columns[7].DefaultCellStyle.Format = "c2";
                dataGrid.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[7].ReadOnly = true;

                dataGrid.Columns.Add(stockTotalValue);
                dataGrid.Columns[8].Name = "stockTotalValue";
                dataGrid.Columns[8].HeaderText = "TOTAL";
                dataGrid.Columns[8].DefaultCellStyle.Format = "c2";
                dataGrid.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[8].ReadOnly = true;

                dataGrid.Columns.Add(delete);
                delete.Image = Resources.deletar2;
                delete.ImageLayout = DataGridViewImageCellLayout.Normal;
                dataGrid.Columns[9].Name = "delete";
                dataGrid.Columns[9].HeaderText = "";
                dataGrid.Columns[9].Width = 40;
                dataGrid.Columns[9].DisplayIndex = 0;
                dataGrid.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[9].ReadOnly = true;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion
    }
}
