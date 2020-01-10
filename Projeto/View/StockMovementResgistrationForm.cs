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
    public partial class StockMovimentRegistrationForm : Form
    {
        #region Get e Set

        public int StockId { get; set; }
        public int StockQuantity { get; set; }
        public int ProductId { get; set; }

        #endregion

        #region Variables
        private DataPagination dataPagination = new DataPagination();
        #endregion

        #region Constructs

        public StockMovimentRegistrationForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region UserForm

        private void StockMovementResgistrationForm_Resize(object sender, EventArgs e)
        {
            try
            {
                // Centraliza imagem loading no formulário
                GifLoading.Left = MainDataList.Width / 2 - GifLoading.Width / 2;
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion

        #region Button

        private void AddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegisterStockMovement() == true)
                {
                    GetStockMovementDetails(Convert.ToInt32(StockMovementId.Text));
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            ExcludeStockMovement();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            if (OperationSituation.Text == "Em Aberto")
            {
                if (CheckDataToAddItem() == true)
                {
                    RegisterStockItem();
                    ListStockItems();
                    ClearSearchFields();
                }
            }
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            switch (OperationType.Text)
            {
                case "Entrada":

                    RegisterStockEntries();
                    break;

                case "Saída":

                    RegisterStockRemovals();
                    break;
            }
        }

        #endregion

        #region TextBox

        private void ShearchFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            GifLoading.Visible = true;
            QueryTimer.Enabled = false;
            QueryTimer.Enabled = true;
        }

        private void Quantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            TotalValue.Text = CalculateTotal(Convert.ToInt32(Quantity.Text),
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
                    var stockMovement = new StockMovement
                    {
                        StockDestinationLocation = ((ComboBox)sender).SelectedItem.ToString()
                    };

                    stockMovement.SetDestination(Convert.ToInt32(StockMovementId.Text));
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion

        #region Timer

        private void QueryTimer_Tick(object sender, EventArgs e)
        {
            GifLoading.Visible = false;
            QueryTimer.Enabled = false;
            SearchStock();
        }

        #endregion

        #region LabelLink

        private void AddNewStockDestination_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var destinationRegister = new StockDestinationRegistrationForm();
                destinationRegister.ShowDialog();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void ClearQueryFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearSearchFields();
            ResetControl();
            ListStockItems();
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
                    GetStockDetails(ProductId);
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
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
                    ExcludeItem(id);
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void MainDataList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }

        #endregion

        #region MethodsAuxiliarys

        private List<Stock> GetItems()
        {
            var itemList = new List<Stock>();

            for (int i = 0; i < MainDataList.Rows.Count; i++)
            {
                var id = MainDataList.Rows[i].Cells["stockId"].Value;
                var quantity = MainDataList.Rows[i].Cells["stockQuantity"].Value;
                var totalValue = MainDataList.Rows[i].Cells["stockTotalValue"].Value;
                totalValue.ToString().Replace("R$", "").Replace("$", "");

                var stock = new Stock()
                {
                    Id = Convert.ToInt32(id),
                    Quantity = Convert.ToInt32(quantity),
                    TotalValue = Convert.ToDouble(totalValue)
                };

                itemList.Add(stock);
            }

            return itemList;
        }

        private void SearchStock()
        {
            try
            {
                var stockProduct = new StockProduct(dataPagination)
                {
                    SearchByCode = QueryByCode.Text,
                    SearchBySize = QueryBySize.Text,
                    SearchByReference = QueryByReference.Text,
                    SearchByDescription = QueryByDescription.Text,
                    SearchBySummary = "All",
                };

                stockProduct.SearchData();

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

                MainDataList.ClearSelection();

                MainDataList.Visible = true;

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        public void FillStockDestinations()
        {
            try
            {
                var destination = new StockDestination();
                destination.ListData();

                var destinationList = new List<string>();

                for (int i = 0; i < destination.ListOfRecords.Count; i++)
                {
                    destinationList.Add(destination.ListOfRecords[i].Location);
                }

                StockDestinationList.DataSource = destinationList;
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void GetStockDetails(int id)
        {
            var stockProduct = new StockProduct();
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

            ListStockItems();
        }

        public void GetStockMovementDetails(int id)
        {
            try
            {
                var stockMovement = new StockMovement();
                stockMovement.ViewDetails(id);

                StockMovementId.Text = id.ToString();
                OperationType.Text = stockMovement.OperationType;
                OperationDate.Text = Convert.ToString(stockMovement.OperationDate.ToString("dd-MM-yyyy"));
                OperationHour.Text = stockMovement.OperationHour;
                OperationSituation.Text = stockMovement.OperationSituation;

                if (stockMovement.StockDestinationLocation != string.Empty)
                {
                    FillStockDestinations();
                    StockDestinationList.Text = stockMovement.StockDestinationLocation;
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        public bool RegisterStockMovement()
        {
            var stockMovement = new StockMovement();
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

        private void ExcludeStockMovement()
        {
            try
            {
                if (Convert.ToInt32(StockMovementId.Text) > 0 && OperationSituation.Text == "Finalizada")
                {
                    if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        var stockMovement = new StockMovement();

                        if (stockMovement.Delete(Convert.ToInt32(StockMovementId.Text)) == true)
                        {
                            MessageBox.Show(Notification.Message, "SUCESSO",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void RegisterStockEntries()
        {
            if (CheckDataToAddStock() == true)
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var stock = new Stock();

                    if (stock.RegisterEntries(GetItems(), Convert.ToInt32(StockMovementId.Text)) == true)
                    {
                        MessageBox.Show(Notification.Message, "SUCESSO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        OperationSituation.Text = "Finalizada";
                    }
                }
            }
        }

        private void RegisterStockRemovals()
        {
            if (CheckDataToAddStock() == true)
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var stock = new Stock();

                    if (stock.RegisterRemovals(GetItems(), Convert.ToInt32(StockMovementId.Text)) == true)
                    {
                        MessageBox.Show(Notification.Message, "SUCESSO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        OperationSituation.Text = "Finalizada";
                    }
                }
            }
        }

        public void ListStockItems()
        {
            try
            {
                var stockItem = new StockItem();
                stockItem.ListItem(Convert.ToInt32(StockMovementId.Text));

                MainDataList.Columns.Clear();

                CreateColumnForStockList();

                for (int i = 0; i < stockItem.ListOfRecords.Count; i++)
                {
                    MainDataList.Rows.Add(
                    stockItem.ListOfRecords[i].Id,
                    stockItem.ListOfRecords[i].StockId,
                    stockItem.ListOfRecords[i].ProductCode,
                    stockItem.ListOfRecords[i].ProductSize,
                    stockItem.ListOfRecords[i].ProductReference,
                    stockItem.ListOfRecords[i].ProductDescription,
                    stockItem.ListOfRecords[i].Quantity,
                    stockItem.ListOfRecords[i].UnitaryValue,
                    stockItem.ListOfRecords[i].TotalValue
                    );
                }

                MainDataList.ClearSelection();

                var totalValue = stockItem.ListOfRecords.Sum(x => x.TotalValue);
                var totalItems = stockItem.ListOfRecords.Count;

                SubTotal.Text = totalValue.ToString("c2");
                TotalItems.Text = totalItems.ToString();

                if (OperationSituation.Text == "Finalizada")
                    MainDataList.Columns["delete"].Visible = false;

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void RegisterStockItem()
        {
            try
            {
                var stockItem = new StockItem()
                {
                    StockMovementId = Convert.ToInt32(StockMovementId.Text),
                    StockId = StockId,
                    ProductId = ProductId,
                    Quantity = Convert.ToInt32(Quantity.Text),
                    UnitaryValue = Convert.ToDouble(UnitaryValue.DecimalValue),
                    TotalValue = Convert.ToDouble(TotalValue.DecimalValue)
                };

                stockItem.Add();
            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        private void ExcludeItem(int id)
        {
            if (OperationSituation.Text != "Finalizada")
            {
                var item = new StockItem();
                item.Remove(id);

                ListStockItems();
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
                ExceptionAssistant.Message.Show(ex);
                return false;
            }
        }

        private double CalculateTotal(int quantity, double unitaryValue)
        {
            return quantity * unitaryValue;
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
                ExceptionAssistant.Message.Show(ex);
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

        private void InitializeSettings()
        {
            CreateColumnForStockList();

            ResetControl();

            DayOfTheWeek.Text = DateTime.Now.ToLongDateString();
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

                DataGridLealt.SetDefaultStyle(mainDataList);

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
                ExceptionAssistant.Message.Show(ex);
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

                var mainDataList = MainDataList;
                mainDataList.ListIsItem = true;

                DataGridLealt.DefineStyleItem(mainDataList);

                mainDataList.Columns.Add(itemId);
                mainDataList.Columns[0].Width = 100;
                mainDataList.Columns[0].Name = "itemId";
                mainDataList.Columns[0].HeaderText = "ID ITEM";
                mainDataList.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[0].ReadOnly = true;
                mainDataList.Columns[0].Visible = false;

                mainDataList.Columns.Add(stockId);
                mainDataList.Columns[1].Width = 100;
                mainDataList.Columns[1].Name = "stockId";
                mainDataList.Columns[1].HeaderText = "ID ESTOQUE";
                mainDataList.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[1].ReadOnly = true;
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

                mainDataList.Columns.Add(stockQuantity);
                mainDataList.Columns[6].Width = 50;
                mainDataList.Columns[6].Name = "stockQuantity";
                mainDataList.Columns[6].HeaderText = "QTD.";
                mainDataList.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[6].ReadOnly = true;

                mainDataList.Columns.Add(productCostPrice);
                mainDataList.Columns[7].Name = "productCostPrice";
                mainDataList.Columns[7].HeaderText = "VALOR UNI.";
                mainDataList.Columns[7].DefaultCellStyle.Format = "c2";
                mainDataList.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[7].ReadOnly = true;

                mainDataList.Columns.Add(stockTotalValue);
                mainDataList.Columns[8].Name = "stockTotalValue";
                mainDataList.Columns[8].HeaderText = "TOTAL";
                mainDataList.Columns[8].DefaultCellStyle.Format = "c2";
                mainDataList.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[8].ReadOnly = true;

                mainDataList.Columns.Add(delete);
                delete.Image = Resources.deletar2;
                delete.ImageLayout = DataGridViewImageCellLayout.Normal;
                mainDataList.Columns[9].Name = "delete";
                mainDataList.Columns[9].HeaderText = "";
                mainDataList.Columns[9].Width = 40;
                mainDataList.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[9].ReadOnly = true;

            }
            catch (Exception ex)
            {
                ExceptionAssistant.Message.Show(ex);
            }
        }

        #endregion
    }
}
