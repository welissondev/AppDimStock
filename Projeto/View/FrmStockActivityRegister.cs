using Syncfusion.Windows.Forms.Tools;
using DimStock.Auxiliary;
using DimStock.Business;
using DimStock.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.View
{
    public partial class FrmStockActivityRegister : Form
    {
        #region Get e Set
        public string ActivityType { get; set; }
        public int StockActivityId { get; set; }
        #endregion

        #region Variables
        private string activitySituation;
        private int stockId;
        private int productId;
        private int stockQuantity;
        private AxlDataPagination dataPagination = new AxlDataPagination();
        #endregion

        #region Constructs

        #region FrmStockActivityRegister()
        public FrmStockActivityRegister()
        {
            InitializeComponent();

            DefineColumns_InMainGrid_ForListItems();
        }
        #endregion

        #endregion

        #region UserForm

        #region FrmStockActivityRegister_Load()
        private void FrmStockActivityRegister_Load(object sender, EventArgs e)
        {
            LblTodayIsDay.Text = DateTime.Now.ToLongDateString();
        }
        #endregion

        #region FrmStockActivityRegister_Resize()
        private void FrmStockActivityRegister_Resize(object sender, EventArgs e)
        {
            try
            {
                // Centraliza image gif carregando no formulário
                PicLoading.Left = GridMain.Width / 2 - PicLoading.Width / 2;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #endregion

        #region Button

        #region BtnNew_Click()
        private void BtnNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (AddActivity() == true)
                {
                    GetActivityDetails(StockActivityId);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region BtnAdcionarItem_Click()
        private void BtnAddNewItem_Click(object sender, EventArgs e)
        {
            if (LblActivitySituation.Text != "Finalizada")
            {
                AddItem();
            }
        }
        #endregion

        #region BtnConfirm_Click()
        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            AddStock();
        }
        #endregion

        #region BtnDelete_Click()
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DeleteActivity();
        }
        #endregion

        #endregion

        #region TextBox

        #region StartTheQuery_ForTheSearchBox_KeyPress()
        private void StartTheQuery_ForTheSearchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            PicLoading.Visible = true;
            TimerExecuteQuery.Enabled = false;
            TimerExecuteQuery.Enabled = true;
        }
        #endregion 

        #region TxtQuantity_KeyPress()
        private void TxtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            TotaCalculate();
        }
        #endregion

        #region TxtValorUnitario_KeyPress()
        private void TxtValorUnitario_KeyPress(object sender, KeyPressEventArgs e)
        {
            TotaCalculate();
        }
        #endregion

        #endregion

        #region ComboBox

        #region CboStockDestination_DropDown()
        private void CboStockDestination_DropDown(object sender, EventArgs e)
        {
            ListStockDestinations();
        }
        #endregion

        #region CboStockDestination_SelectedIndexChanged()
        private void CboStockDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (activitySituation == "Em Aberto")
                {
                    var atividade = new BllStockActivity();
                    atividade.Destination = ((ComboBox)sender).SelectedItem.ToString();

                    atividade.AddDestination(StockActivityId);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #endregion

        #region Time

        #region TimerExecuteQuery_Tick()
        private void TimerExecuteQuery_Tick(object sender, EventArgs e)
        {
            PicLoading.Visible = false;
            TimerExecuteQuery.Enabled = false;
            FetchData();
        }
        #endregion

        #endregion

        #region LabelLink

        #region LblRegisterNew_StockDestination_LinkClicked()
        private void LblRegisterNew_StockDestination_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                var frmStockDestinationRegister = new FrmStockDestinationRegister();
                frmStockDestinationRegister.ShowDialog();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region LblClear_LinkClicked()
        private void LblClear_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearSearchFields();
            ListItems();
        }
        #endregion

        #endregion

        #region DataGrid

        #region GridMain_DoubleClick()
        private void GridMain_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (GridMain.ListIsStock.Equals(true))
                {
                    productId = Convert.ToInt32(GridMain.CurrentRow.Cells["productId"].Value);
                    GetStockAndProductData(productId);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GridMain_CellClick()
        private void GridMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var columnName = GridMain.Columns[e.ColumnIndex].Name;

                if (columnName == "btnDelete")
                {
                    int id = Convert.ToInt32(GridMain.CurrentRow.Cells["itemId"].Value);
                    DeleteItem(id);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GridMain_RowPrePaint()
        private void GridMain_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }
        #endregion

        #endregion

        #region Methods

        #region FetchData()
        private void FetchData()
        {
            try
            {
                var stockProduct = new BllStockProduct(dataPagination)
                {
                    QueryByCode = TxtQueryByCode.Text,
                    QueryBySize = TxtQueryBySize.Text,
                    QueryByReference = TxtQueryByReference.Text,
                    QueryByDescription = TxtQueryByDescription.Text,
                    QueryByResume = "Todos",
                };

                stockProduct.FetchData();

                GridMain.Columns.Clear();

                DefineColumns_InMainGrid_ForStockList();

                for (var i = 0; i < stockProduct.ListOfRecords.Count; i++)
                {
                    GridMain.Rows.Add(
                    stockProduct.ListOfRecords[i].StockId,
                    stockProduct.ListOfRecords[i].ProductId,
                    stockProduct.ListOfRecords[i].ProductCode,
                    stockProduct.ListOfRecords[i].ProductDescription,
                    stockProduct.ListOfRecords[i].ProductCostPrice
                    );

                    var photoDirectoryPath = BllProductPhotho.GetPeth() + stockProduct.ListOfRecords[i].ProductPhotoName;
                    if (BllProductPhotho.FindFile(photoDirectoryPath).Equals(true))
                    {
                        using (var file = new FileStream(photoDirectoryPath, FileMode.Open, FileAccess.Read))
                        {
                            GridMain.Rows[i].Cells["fotoProdutoColumn"].Value = Image.FromStream(file);
                        }
                    }
                }

                GridMain.Visible = true;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ListItems()
        public void ListItems()
        {
            try
            {
                var stockItem = new BllStockItem();

                stockItem.ListItem(StockActivityId);

                GridMain.Columns.Clear();

                DefineColumns_InMainGrid_ForListItems();

                for (int i = 0; i < stockItem.ListOfRecords.Count; i++)
                {
                    GridMain.Rows.Add(
                    stockItem.ListOfRecords[i].Id,
                    stockItem.ListOfRecords[i].StockId,
                    stockItem.ListOfRecords[i].ProductCode,
                    stockItem.ListOfRecords[i].ProductDescription,
                    stockItem.ListOfRecords[i].Quantity,
                    stockItem.ListOfRecords[i].UnitaryValue,
                    stockItem.ListOfRecords[i].TotalValue
                    );
                }

                var totalValue = stockItem.ListOfRecords.Sum(item => item.TotalValue);
                var totalItems = stockItem.ListOfRecords.Count;

                LblSubTotal.Text = totalValue.ToString("c2");
                LblTotalItems.Text = totalItems.ToString();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region DefineColumns_InMainGrid_ForStockList()
        private void DefineColumns_InMainGrid_ForStockList()
        {
            try
            {
                var stockId = new DataGridViewTextBoxColumn();
                var productId = new DataGridViewTextBoxColumn();
                var productCode = new DataGridViewTextBoxColumn();
                var productDescription = new DataGridViewTextBoxColumn();
                var productCostPrice = new DataGridViewTextBoxColumn();
                var imgProduct = new DataGridViewImageColumn();

                var dataGrid = GridMain;

                dataGrid.ListIsStock = true;

                if (ActivityType == "Entrada")
                {
                    AxlDataGridViewLealt.DefaultLayoutDarkblue(dataGrid);
                }
                else
                {
                    AxlDataGridViewLealt.DefaultLayoutDarkblue(dataGrid);
                }

                dataGrid.Columns.Add(stockId);
                dataGrid.Columns[0].Width = 100;
                dataGrid.Columns[0].Name = "stockId";
                dataGrid.Columns[0].HeaderText = "ID ESTOQUE";
                dataGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[0].Visible = false;

                dataGrid.Columns.Add(productId);
                dataGrid.Columns[1].Width = 100;
                dataGrid.Columns[1].Name = "productId";
                dataGrid.Columns[1].HeaderText = "ID PRODUTO";
                dataGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[1].Visible = false;

                dataGrid.Columns.Add(productCode);
                dataGrid.Columns[2].Width = 80;
                dataGrid.Columns[2].Name = "productCode";
                dataGrid.Columns[2].HeaderText = "CÓDIGO PRODUTO";
                dataGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].ReadOnly = true;

                dataGrid.Columns.Add(productDescription);
                dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[3].Name = "productDescription";
                dataGrid.Columns[3].HeaderText = "DESCRIÇÃO PRODUTO";
                dataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[3].ReadOnly = true;

                dataGrid.Columns.Add(productCostPrice);
                dataGrid.Columns[4].Name = "productCostPrice";
                dataGrid.Columns[4].HeaderText = "PREÇO CUSTO";
                dataGrid.Columns[4].DefaultCellStyle.Format = "c2";
                dataGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[4].ReadOnly = true;

                dataGrid.Columns.Add(imgProduct);
                imgProduct.Image = Resources.FotoNothing;
                imgProduct.ImageLayout = DataGridViewImageCellLayout.Zoom;
                dataGrid.Columns[5].Name = "imgProduct";
                dataGrid.Columns[5].HeaderText = "FOTO";
                dataGrid.Columns[5].Width = 40;
                dataGrid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[5].DisplayIndex = 0;
                dataGrid.Columns[5].ReadOnly = true;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region DefineColumns_InMainGrid_ForListItems()
        private void DefineColumns_InMainGrid_ForListItems()
        {
            try
            {
                var itemId = new DataGridViewTextBoxColumn();
                var stockId = new DataGridViewTextBoxColumn();
                var productCode = new DataGridViewTextBoxColumn();
                var productDescription = new DataGridViewTextBoxColumn();
                var stockQuantity = new DataGridViewTextBoxColumn();
                var productCostPrice = new DataGridViewTextBoxColumn();
                var stockValue = new DataGridViewTextBoxColumn();
                var btnDelete = new DataGridViewImageColumn();

                var dataGrid = GridMain;

                dataGrid.ListIsItem = true;

                AxlDataGridViewLealt.DefaultLayoutDarkblue(dataGrid);

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
                dataGrid.Columns[2].HeaderText = "CÓDIGO PRODUTO";
                dataGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[2].ReadOnly = true;

                dataGrid.Columns.Add(productDescription);
                dataGrid.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGrid.Columns[3].Name = "productDescription";
                dataGrid.Columns[3].HeaderText = "DESCRIÇÃO PRODUTO";
                dataGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[3].ReadOnly = true;

                dataGrid.Columns.Add(stockQuantity);
                dataGrid.Columns[4].Width = 50;
                dataGrid.Columns[4].Name = "stockQuantity";
                dataGrid.Columns[4].HeaderText = "QTD.";
                dataGrid.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[4].ReadOnly = true;

                dataGrid.Columns.Add(productCostPrice);
                dataGrid.Columns[5].Name = "productCostPrice";
                dataGrid.Columns[5].HeaderText = "VALOR UNI.";
                dataGrid.Columns[5].DefaultCellStyle.Format = "c2";
                dataGrid.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[5].ReadOnly = true;

                dataGrid.Columns.Add(stockValue);
                dataGrid.Columns[6].Name = "stockValue";
                dataGrid.Columns[6].HeaderText = "VALOR TOTAL";
                dataGrid.Columns[6].DefaultCellStyle.Format = "c2";
                dataGrid.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                dataGrid.Columns[6].ReadOnly = true;

                dataGrid.Columns.Add(btnDelete);
                btnDelete.Image = Resources.deletar2;
                btnDelete.ImageLayout = DataGridViewImageCellLayout.Normal;
                dataGrid.Columns[7].Name = "btnDelete";
                dataGrid.Columns[7].HeaderText = "";
                dataGrid.Columns[7].Width = 40;
                dataGrid.Columns[7].DisplayIndex = 0;
                dataGrid.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGrid.Columns[7].ReadOnly = true;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region AddItem()
        public void AddItem()
        {
            try
            {
                if (CheckDataToAddItem().Equals(true))
                {
                    var stockItem = new BllStockItem()
                    {
                        StockActivityId = StockActivityId,
                        StockId = stockId,
                        ProductId = productId,
                        Quantity = Convert.ToInt32(TxtQuantity.Text),
                        UnitaryValue = Convert.ToDouble(TxtUnitaryValue.Text.Replace("R$", "").Replace("$", "")),
                        TotalValue = Convert.ToDouble(TxtTotalValue.Text.Replace("R$", "").Replace("$", ""))
                    };

                    stockItem.Add();

                    ListItems();

                    ClearSearchFields();
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region CheckDataToAddItem()
        private bool CheckDataToAddItem()
        {
            if (TxtQuantity.Text == "" || TxtQuantity.Text == null || Convert.ToInt32(TxtQuantity.Text) < 1)
            {
                MessageBox.Show("Informe a quantidade de estoque", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtQuantity.Select();

                return false;
            }
            else if (Convert.ToDouble(TxtUnitaryValue.Text.Replace("R$", "").Replace("$", "")) == 0)
            {
                MessageBox.Show("Informe o valor unitário!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TxtUnitaryValue.Select();

                return false;
            }
            else if (ActivityType == "Saída" && stockQuantity < 1)
            {
                MessageBox.Show("Não é possível adicionar esse produto, " +
                "porque ele não tem estoque!", "SEM ESTOQUE",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else if (ActivityType == "Saída" && Convert.ToInt32(TxtQuantity.Text) > stockQuantity)
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

        #endregion

        #region AddActivity()
        public bool AddActivity()
        {
            var stockActivity = new BllStockActivity();
            var activityState = false;

            if (ActivityType == "Entrada")
            {
                stockActivity.Type = "Entrada";
            }
            else if (ActivityType == "Saída")
            {
                stockActivity.Type = "Saída";
            }

            stockActivity.Date = Convert.ToDateTime(DateTime.Now.ToString("dd-MM-yyyy"));
            stockActivity.Hour = DateTime.Now.ToString("HH:mm:ss");
            stockActivity.Situation = "Em Aberto";

            if (stockActivity.Add() == true)
            {
                activityState = true;

                //Pega id Atividade
                StockActivityId = stockActivity.Id;
            }

            return activityState;
        }
        #endregion 

        #region AddStock()
        private void AddStock()
        {
            try
            {
                if (CheckDataToAddStock() == true)
                {
                    var stockList = GetDataGridItems();

                    var stock = new BllStock
                    {
                        Id = stockId
                    };

                    if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {

                        if (ActivityType == "Entrada")
                        {
                            if (stock.AddEntries(stockList, StockActivityId) == true)
                            {
                                MessageBox.Show(BllNotification.Message, "SUCESSO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LblActivitySituation.Text = "Finalizada";
                                activitySituation = "Finalizada";
                            }
                        }

                        else if (ActivityType == "Saída")
                        {
                            if (stock.AddOutPuts(stockList, StockActivityId).Equals(true))
                            {
                                MessageBox.Show(BllNotification.Message, "SUCESSO",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                                LblActivitySituation.Text = "Finalizada";
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region CheckDataToAddStock()
        private bool CheckDataToAddStock()
        {
            if (LblActivitySituation.Text == "Finalizada")
            {
                MessageBox.Show("Não é possível realizar essa operação pois a situação " +
                "do cadastro consta como finalizada!", "NÃO PERMITIDO", MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);

                return false;
            }
            else if (GetDataGridItems().Count == 0)
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
        #endregion

        #region CheckIfItemExists()
        private bool CheckIfItemExists()
        {
            try
            {
                var itemExists = false;

                for (int i = 0; i < GridMain.Rows.Count; i++)
                {
                    if (Convert.ToInt32(GridMain.Rows[i].Cells["stockId"].Value) == stockId)
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
        #endregion 

        #region GetDataGridItems()
        private List<BllStock> GetDataGridItems()
        {
            var stockList = new List<BllStock>();

            for (int i = 0; i < GridMain.Rows.Count; i++)
            {

                var stockId = GridMain.Rows[i].Cells["stockId"].Value;
                var stockQuantity = GridMain.Rows[i].Cells["stockQuantity"].Value;
                var stockValue = GridMain.Rows[i].Cells["stockValue"].Value;

                stockValue.ToString().Replace("R$", "").Replace("$", "");

                var stockItem = new BllStock()
                {
                    Id = Convert.ToInt32(stockId),
                    Quantity = Convert.ToInt32(stockQuantity),
                    TotalValue = Convert.ToDouble(stockValue)
                };

                stockList.Add(stockItem);
            }

            return stockList;
        }
        #endregion 

        #region GetStockAndProductData()
        private void GetStockAndProductData(int id)
        {
            var stockProduct = new BllStockProduct();

            stockProduct.GetRegistryData(id);

            TxtQueryByCode.Text = stockProduct.ProductCode;
            TxtQueryBySize.Text = stockProduct.ProductSize;
            TxtQueryByReference.Text = stockProduct.ProductReference;
            TxtQueryByDescription.Text = stockProduct.ProductDescription;
            TxtUnitaryValue.Text = stockProduct.ProductCostPrice.ToString();
            TxtQuantity.Text = "0";
            TxtQuantity.Select();
            productId = stockProduct.ProductId;
            stockId = stockProduct.StockId;
            stockQuantity = stockProduct.StockQuantity;

            GridMain.Columns.Clear();
            ListItems();
        }

        #endregion

        #region ListStockDestinations()
        public void ListStockDestinations()
        {
            try
            {
                var stockDestination = new BllStockDestination();
                stockDestination.ListAll();

                var stockDestinationList = new List<string>();

                for (int i = 0; i < stockDestination.ListOfRecords.Count; i++)
                {
                    stockDestinationList.Add(stockDestination.ListOfRecords[i].Location);
                }

                CboStockDestination.DataSource = stockDestinationList;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region TotaCalculate()
        private void TotaCalculate()
        {
            try
            {
                int stockQuantity = Convert.ToInt32(TxtQuantity.Text);
                double unitaryValue = Convert.ToDouble(TxtUnitaryValue.Text.Replace("R$", "").Replace("$", ""));
                double totalValue = stockQuantity * unitaryValue;

                TxtTotalValue.Text = totalValue.ToString();

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion 

        #region ClearSearchFields()
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

                TxtQueryByCode.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region ResetControl()
        private void ResetControl()
        {
            GridMain.Columns.Clear();
            DefineColumns_InMainGrid_ForListItems();

            LblTotalItems.Text = "0";
            LblSubTotal.Text = "R$0,00";
            TxtQueryByCode.Select();
        }
        #endregion

        #region DeleteItem()
        private void DeleteItem(int id)
        {
            if (LblActivitySituation.Text != "Finalizada")
            {
                var stockItem = new BllStockItem();
                stockItem.Delete(id);

                ListItems();
            }
        }
        #endregion

        #region DeleteActivity()
        private void DeleteActivity()
        {
            try
            {
                if (StockActivityId > 0 && activitySituation == "Finalizada")
                {
                    if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        var stockActivity = new BllStockActivity();

                        if (stockActivity.Delete(StockActivityId) == true)
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
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }
        #endregion

        #region GetActivityDetails()
        public void GetActivityDetails(int id)
        {
            try
            {
                var stockActivity = new BllStockActivity();
                stockActivity.GetActivityDetails(id);

                LblActivityNumber.Text = id.ToString();
                LblActivityType.Text = stockActivity.Type;
                LblActivityDate.Text = Convert.ToString(stockActivity.Date.ToString("dd-MM-yyyy"));
                LblActivityHour.Text = stockActivity.Hour;
                LblActivitySituation.Text = stockActivity.Situation;

                ListStockDestinations();
                if (stockActivity.Destination != "" || stockActivity.Destination != null)
                    CboStockDestination.Text = stockActivity.Destination;

                //Passa para variáveis no scopo
                StockActivityId = id;
                ActivityType = stockActivity.Type;
                activitySituation = stockActivity.Situation;

                if (stockActivity.Type == "Entrada")
                {
                    LblFormTitle.Text = "Entrada de Estoque";
                }
                else
                {
                    LblFormTitle.Text = "Saída de Estoque";
                }
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
