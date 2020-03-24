using DimStock.Auxiliarys;
using DimStock.Models;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DimStock.UserForms
{
    public partial class StockMovementAddForm : Form
    {
        #region Builder

        public StockMovementAddForm()
        {
            InitializeComponent();

            InitializeSettings();
        }

        #endregion

        #region Properties
        private AxlDataPage pagination = new AxlDataPage();
        #endregion

        #region Get e Set

        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int StockQuantity { get; set; }
        public string OperationDate { get; set; }
        public string OperationType { get; set; }
        public string OperationHour { get; set; }
        public string OperationSituation { get; set; }
        public string OperationCode { get; set; }

        #endregion

        #region Form

        private void StockMovementAddForm_Resize(object sender, EventArgs e)
        {
            try
            {
                // Centraliza imagem loading no formulário
                PictureLoading.Left = DataGridMainDataList.Width / 2 - PictureLoading.Width / 2;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion

        #region Button

        private void ButtonRegisterNew_Click(object sender, EventArgs e)
        {
            try
            {
                StockMovementMenuStrip.Show();
                StockMovementMenuStrip.Location = MousePosition;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            switch (TextOperationType.Text)
            {
                case "Entrada":

                    AddStockEntries();
                    break;

                case "Saída":

                    AddStockOutputs();
                    break;
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            DeleteMovement();
        }

        private void ButtonAddItem_Click(object sender, EventArgs e)
        {
            if (TextOperationSituation.Text == "Em Aberto")
            {
                if (CheckDataToAddItem() == true)
                {
                    AddStockItem();
                    ListStockItems();
                    ClearSearchFields();
                }
            }
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region TextBox

        private void TextShearchFields_KeyPress(object sender, KeyPressEventArgs e)
        {
            PictureLoading.Visible = true;
            SearchTimer.Enabled = false;
            SearchTimer.Enabled = true;
        }

        private void TextQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextTotalValue.Text = StockMovementItem.
            CalculeSubTotal(Convert.ToInt32(TextQuantity.Text),
            Convert.ToDouble(TextUnitaryValue.DecimalValue)
            ).ToString();
        }

        #endregion

        #region ComboBox

        private void ComboBoxStockDestinationList_DropDown(object sender, EventArgs e)
        {
            FillAllComboBox();
        }

        private void ComboBoxStockDestinationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (TextOperationSituation.Text == "Em Aberto")
                {
                    var movement = new StockMovement();
                    movement.Destination.Location =
                    ((ComboBox)sender).SelectedItem.ToString();

                    movement.RelateDestination(Convert.ToInt32(
                    TextStockMovementId.Text));
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ComboBoxStockDestinationList_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsLetter(e.KeyChar)) || (Char.IsWhiteSpace(e.KeyChar)))
                e.Handled = true;
        }

        #endregion

        #region Timer

        private void SearchTimer_Tick(object sender, EventArgs e)
        {
            PictureLoading.Visible = false;
            SearchTimer.Enabled = false;
            FetchData();
        }

        #endregion

        #region LabelLink

        private void ButtonShow_StockDestination_RegistrationForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var form = new StockDestinationAddForm()
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                ShowInTaskbar = false,
                MaximizeBox = false,
                MinimizeBox = false
            };

            form.ShowDialog();
        }

        private void ButtonClear_SearchFields_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ClearSearchFields();
            ResetControl();
            ListStockItems();
        }

        #endregion

        #region DataGridView

        private void DataGridMainDataList_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (DataGridMainDataList.ListIsStock.Equals(true))
                {
                    ProductId = Convert.ToInt32(DataGridMainDataList.CurrentRow.Cells["productId"].Value);
                    StockGetDetail(ProductId);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void DataGridMainDataList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var columnName = DataGridMainDataList.Columns[e.ColumnIndex].Name;

                if (columnName == "delete")
                {
                    int id = Convert.ToInt32(DataGridMainDataList.CurrentRow.Cells["itemId"].Value);
                    RemoveItem(id);
                }
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void DataGridMainDataList_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            //Remove o focus do controle datagriview
            e.PaintParts = DataGridViewPaintParts.All ^ DataGridViewPaintParts.Focus;
        }

        private void DataGridMainDataList_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridMainDataList.Rows[e.RowIndex].Selected = true;
            }
        }

        #endregion

        #region ToolStripMenu

        private void MovementEntrie_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewOperation("Entrada");
        }

        private void MovementOutPut_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartNewOperation("Saída");
        }

        #endregion

        #region Function

        private void FetchData()
        {
            try
            {
                var stock = new Stock(pagination);

                stock.Product.InternalCode = TextSearchByCode.Text;

                stock.FetchData();

                DataGridMainDataList.Columns.Clear();

                CreateColumnForItemList();

                for (var i = 0; i < stock.List.Count; i++)
                {
                    DataGridMainDataList.Rows.Add(
                    stock.List[i].Id,
                    stock.List[i].Product.Id,
                    stock.List[i].Product.InternalCode,
                    stock.List[i].Product.Description,
                    stock.List[i].Product.CostPrice
                    );
                }
                DataGridMainDataList.ClearSelection();
                DataGridMainDataList.Visible = true;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void FillAllComboBox()
        {
            try
            {
                var destination = new StockDestination();
                destination.ListData();

                var destinationList = new List<string>();

                for (int i = 0; i < destination.List.Count; i++)
                {
                    destinationList.Add(destination.List[i].Location);
                }

                ComboBoxStockDestinationList.DataSource = destinationList;
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void StockGetDetail(int id)
        {
            var stock = new Stock();
            stock.GetDetail(id);

            TextSearchByCode.Text = stock.Product.InternalCode;
            TextSearchByDescription.Text = stock.Product.Description;
            TextUnitaryValue.Text = stock.Product.CostPrice.ToString();
            ProductId = stock.Product.Id;
            StockId = stock.Id;
            StockQuantity = stock.Quantity;
            TextQuantity.Select();

            ListStockItems();
        }

        public void MovementGetDetail(int id)
        {
            try
            {
                var movement = new StockMovement();
                movement.GetDetail(id);

                TextStockMovementId.Text = id.ToString();
                TextOperationType.Text = movement.OperationType;
                TextOperationDate.Text = Convert.ToString(movement.OperationDate.ToString("dd-MM-yyyy"));
                TextOperationHour.Text = Convert.ToString(movement.OperationHour.ToString("HH:MM:ss"));
                TextOperationSituation.Text = movement.OperationSituation;

                if (movement.Destination.Id != 0)
                {
                    FillAllComboBox();

                    ComboBoxStockDestinationList.Text =
                    movement.Destination.Location;
                }

                ListStockItems();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        public void StartNewOperation(string operationType)
        {
            var movement = new StockMovement();

            movement.InitOperation(operationType);

            MovementGetDetail(movement.Id);

            ResetControl();

            ListStockItems();
        }

        private void DeleteMovement()
        {
            try
            {
                if (Convert.ToInt32(TextStockMovementId.Text) > 0)
                {
                    if (MessageBox.Show("Confirma essa operação?", "CONFIRME",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        var movement = new StockMovement
                        {
                            OperationType = TextOperationType.Text
                        };

                        if (movement.Remove(Convert.ToInt32(
                        TextStockMovementId.Text)) == true)
                        {
                            MessageBox.Show(MessageNotifier.Message, "SUCESSO",
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

        private void AddStockEntries()
        {
            if (CheckDataToAddStock() == true)
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var stock = new Stock();

                    if (stock.AddEntries(GetItems(), Convert.ToInt32(TextStockMovementId.Text)) == true)
                    {
                        MessageBox.Show(MessageNotifier.Message, "SUCESSO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        TextOperationSituation.Text = "Finalizada";
                    }
                }
            }
        }

        private void AddStockOutputs()
        {
            if (CheckDataToAddStock() == true)
            {
                if (MessageBox.Show("Confirma essa operação?", "CONFIRME", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    var stock = new Stock();

                    if (stock.AddOutputs(GetItems(), Convert.ToInt32(TextStockMovementId.Text)) == true)
                    {
                        MessageBox.Show(MessageNotifier.Message, "SUCESSO", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                        TextOperationSituation.Text = "Finalizada";
                    }
                }
            }
        }

        private List<Stock> GetItems()
        {
            var itemList = new List<Stock>();

            for (int i = 0; i < DataGridMainDataList.Rows.Count; i++)
            {
                var id = DataGridMainDataList.Rows[i].Cells["stockId"].Value;
                var quantity = DataGridMainDataList.Rows[i].Cells["stockQuantity"].Value;
                var totalValue = DataGridMainDataList.Rows[i].Cells["stockTotalValue"].Value;

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

        private void ListStockItems()
        {
            try
            {
                var item = new StockMovementItem();
                item.ListItems(Convert.ToInt32(TextStockMovementId.Text));

                DataGridMainDataList.Columns.Clear();

                CreateColumnForStockList();

                for (int i = 0; i < item.List.Count; i++)
                {
                    DataGridMainDataList.Rows.Add(
                    item.List[i].Id,
                    item.List[i].Stock.Id,
                    item.List[i].Product.InternalCode,
                    item.List[i].Product.Description,
                    item.List[i].Quantity,
                    item.List[i].UnitaryValue,
                    item.List[i].TotalValue
                    );
                }
                DataGridMainDataList.ClearSelection();

                if (TextOperationSituation.Text == "Finalizada")
                    DataGridMainDataList.Columns["delete"].Visible = false;

                var totalValue = item.List.Sum(x => x.TotalValue);
                var totalItems = item.List.Count;

                SubTotal.Text = totalValue.ToString("c2");
                TotalItems.Text = totalItems.ToString();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void AddStockItem()
        {
            try
            {
                var item = new StockMovementItem()
                {
                    Quantity = Convert.ToInt32(TextQuantity.Text),
                    UnitaryValue = Convert.ToDouble(TextUnitaryValue.DecimalValue),
                    TotalValue = Convert.ToDouble(TextTotalValue.DecimalValue)
                };

                item.StockMovement.Id = Convert.ToInt32(TextStockMovementId.Text);
                item.Stock.Id = StockId;
                item.Product.Id = ProductId;

                item.Add();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void RemoveItem(int id)
        {
            if (TextOperationSituation.Text != "Finalizada")
            {
                var item = new StockMovementItem();
                item.Remove(id);

                ListStockItems();
            }
        }

        private bool CheckDataToAddItem()
        {
            if (TextQuantity.Text == "" || TextQuantity.Text == null || Convert.ToInt32(TextQuantity.Text) < 1)
            {
                MessageBox.Show("Informe a quantidade de estoque", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TextQuantity.Select();

                return false;
            }

            else if (Convert.ToDouble(TextUnitaryValue.Text.Replace("R$", "").Replace("$", "")) == 0)
            {
                MessageBox.Show("Informe o valor unitário!", "OBRIGATÓRIO",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                TextUnitaryValue.Select();

                return false;
            }

            else if (TextOperationType.Text == "Saída" && StockQuantity < 1)
            {
                MessageBox.Show("Não é possível adicionar esse produto, " +
                "porque ele não tem estoque!", "SEM ESTOQUE",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return false;
            }
            else if (TextOperationType.Text == "Saída" && Convert.ToInt32(TextQuantity.Text) > StockQuantity)
            {
                MessageBox.Show("Esse produto não possui estoque suficiente, " +
                "atualize o estoque e tente novamente!", "ESTOQUE BAIXO",
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
            if (TextOperationSituation.Text == "Finalizada")
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

                for (int i = 0; i < DataGridMainDataList.Rows.Count; i++)
                {
                    if (Convert.ToInt32(DataGridMainDataList.Rows[i].Cells["stockId"].Value) == StockId)
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

                TextSearchByCode.Select();
            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        private void ResetControl()
        {
            DataGridMainDataList.Columns.Clear();
            CreateColumnForItemList();

            TotalItems.Text = "0";
            SubTotal.Text = "R$0,00";
            TextQuantity.Text = "0";
            TextSearchByCode.Select();

            var itemList = new List<string>();
            ComboBoxStockDestinationList.DataSource = itemList;
        }

        private void InitializeSettings()
        {
            CreateColumnForStockList();

            ResetControl();
        }

        private void CreateColumnForItemList()
        {
            try
            {
                var stockId = new DataGridViewTextBoxColumn();
                var productId = new DataGridViewTextBoxColumn();
                var productInternalCode = new DataGridViewTextBoxColumn();
                var productDescription = new DataGridViewTextBoxColumn();
                var productCostPrice = new DataGridViewTextBoxColumn();

                var mainDataList = DataGridMainDataList;
                mainDataList.ListIsStock = true;

                AxlDataGridLealt.SetDefaultStyle(mainDataList);

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

                mainDataList.Columns.Add(productInternalCode);
                mainDataList.Columns[2].Width = 80;
                mainDataList.Columns[2].Name = "productInternalCode";
                mainDataList.Columns[2].HeaderText = "CÓD.";
                mainDataList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[2].ReadOnly = true;

                mainDataList.Columns.Add(productDescription);
                mainDataList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                mainDataList.Columns[3].Name = "productDescription";
                mainDataList.Columns[3].HeaderText = "DESCRIÇÃO DO PRODUTO";
                mainDataList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[3].ReadOnly = true;

                mainDataList.Columns.Add(productCostPrice);
                mainDataList.Columns[4].Name = "productCostPrice";
                mainDataList.Columns[4].HeaderText = "CUSTO";
                mainDataList.Columns[4].DefaultCellStyle.Format = "c2";
                mainDataList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[4].ReadOnly = true;
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
                var productIntenalCode = new DataGridViewTextBoxColumn();
                var productDescription = new DataGridViewTextBoxColumn();
                var stockQuantity = new DataGridViewTextBoxColumn();
                var productCostPrice = new DataGridViewTextBoxColumn();
                var stockTotalValue = new DataGridViewTextBoxColumn();
                var delete = new DataGridViewLinkColumn();

                var mainDataList = DataGridMainDataList;
                mainDataList.ListIsItem = true;

                AxlDataGridLealt.DefineStyleItem(mainDataList);

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

                mainDataList.Columns.Add(productIntenalCode);
                mainDataList.Columns[2].Width = 100;
                mainDataList.Columns[2].Name = "productIntenalCode";
                mainDataList.Columns[2].HeaderText = "CÓDIGO";
                mainDataList.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[2].ReadOnly = true;

                mainDataList.Columns.Add(productDescription);
                mainDataList.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                mainDataList.Columns[3].Name = "productDescription";
                mainDataList.Columns[3].HeaderText = "DESCRIÇÃO DO PRODUTO";
                mainDataList.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[3].ReadOnly = true;

                mainDataList.Columns.Add(stockQuantity);
                mainDataList.Columns[4].Width = 50;
                mainDataList.Columns[4].Name = "stockQuantity";
                mainDataList.Columns[4].HeaderText = "QTD.";
                mainDataList.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[4].ReadOnly = true;

                mainDataList.Columns.Add(productCostPrice);
                mainDataList.Columns[5].Name = "productCostPrice";
                mainDataList.Columns[5].HeaderText = "VALOR UNI.";
                mainDataList.Columns[5].DefaultCellStyle.Format = "c2";
                mainDataList.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[5].ReadOnly = true;

                mainDataList.Columns.Add(stockTotalValue);
                mainDataList.Columns[6].Name = "stockTotalValue";
                mainDataList.Columns[6].HeaderText = "TOTAL";
                mainDataList.Columns[6].DefaultCellStyle.Format = "c2";
                mainDataList.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                mainDataList.Columns[6].ReadOnly = true;

                delete.Text = "Deletar";
                delete.TrackVisitedState = false;
                delete.UseColumnTextForLinkValue = true;
                delete.LinkColor = Color.Black;
                delete.ActiveLinkColor = Color.MediumAquamarine;
                mainDataList.Columns.Add(delete);
                mainDataList.Columns[7].Name = "delete";
                mainDataList.Columns[7].HeaderText = "";
                mainDataList.Columns[7].Width = 80;
                mainDataList.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                mainDataList.Columns[7].ReadOnly = true;
                mainDataList.Columns[7].DisplayIndex = 0;

            }
            catch (Exception ex)
            {
                AxlException.Message.Show(ex);
            }
        }

        #endregion
    }
}
