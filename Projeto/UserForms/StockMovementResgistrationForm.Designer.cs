namespace DimStock.UserForms
{
    partial class StockMovementRegistrationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMovementRegistrationForm));
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.SubTotalTitle = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.AddItem = new Syncfusion.WinForms.Controls.SfButton();
            this.Quantity = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.LblTotalValue = new System.Windows.Forms.Label();
            this.TotalValue = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.LblUnitaryValue = new System.Windows.Forms.Label();
            this.UnitaryValue = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.QueryTitleByDescription = new System.Windows.Forms.Label();
            this.QueryTitleByReference = new System.Windows.Forms.Label();
            this.QueryTitleBySize = new System.Windows.Forms.Label();
            this.QueryByDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.QueryTitleByCode = new System.Windows.Forms.Label();
            this.QueryByCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.QueryByReference = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.QueryBySize = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.StockMovementIdTitle = new System.Windows.Forms.Label();
            this.StockMovementId = new System.Windows.Forms.Label();
            this.OperationHour = new System.Windows.Forms.Label();
            this.OperationHourTitle = new System.Windows.Forms.Label();
            this.OperationDate = new System.Windows.Forms.Label();
            this.OperationDataTitle = new System.Windows.Forms.Label();
            this.OperationSituation = new System.Windows.Forms.Label();
            this.OperationSituationTitle = new System.Windows.Forms.Label();
            this.CardMain = new Bunifu.Framework.UI.BunifuCards();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitleOfTotalItems = new System.Windows.Forms.Label();
            this.TotalItems = new System.Windows.Forms.Label();
            this.ClearQueryFields = new System.Windows.Forms.LinkLabel();
            this.GifLoading = new System.Windows.Forms.PictureBox();
            this.MainDataList = new DimStock.Controls.CustomDataGridViewOne();
            this.GrupBoxGeneralInformation = new System.Windows.Forms.GroupBox();
            this.OperationTypeTitle = new System.Windows.Forms.Label();
            this.OperationType = new System.Windows.Forms.Label();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.StockDestinationList = new System.Windows.Forms.ComboBox();
            this.AddNewStockDestination = new System.Windows.Forms.LinkLabel();
            this.StockMovementMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MovementEntrie_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovementOutPut_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Confirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CloseForm = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitaryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryBySize)).BeginInit();
            this.CardMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataList)).BeginInit();
            this.GrupBoxGeneralInformation.SuspendLayout();
            this.StockMovementMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // SubTotalTitle
            // 
            this.SubTotalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubTotalTitle.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.SubTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubTotalTitle.Location = new System.Drawing.Point(202, 15);
            this.SubTotalTitle.Name = "SubTotalTitle";
            this.SubTotalTitle.Size = new System.Drawing.Size(90, 23);
            this.SubTotalTitle.TabIndex = 115;
            this.SubTotalTitle.Text = "SUBTOTAL:";
            this.SubTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubTotal
            // 
            this.SubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubTotal.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.SubTotal.Location = new System.Drawing.Point(293, 14);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(196, 23);
            this.SubTotal.TabIndex = 116;
            this.SubTotal.Text = "R$0.00";
            this.SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddItem
            // 
            this.AddItem.AccessibleName = "Button";
            this.AddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItem.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.AddItem.ForeColor = System.Drawing.Color.White;
            this.AddItem.Location = new System.Drawing.Point(859, 28);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(39, 27);
            this.AddItem.Style.BackColor = System.Drawing.Color.MediumAquamarine;
            this.AddItem.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.AddItem.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.AddItem.Style.FocusedBackColor = System.Drawing.Color.Crimson;
            this.AddItem.Style.FocusedForeColor = System.Drawing.Color.White;
            this.AddItem.Style.ForeColor = System.Drawing.Color.White;
            this.AddItem.Style.HoverBackColor = System.Drawing.Color.PaleVioletRed;
            this.AddItem.Style.HoverForeColor = System.Drawing.Color.White;
            this.AddItem.Style.PressedBackColor = System.Drawing.Color.Crimson;
            this.AddItem.Style.PressedForeColor = System.Drawing.Color.White;
            this.AddItem.TabIndex = 7;
            this.AddItem.Text = "ADD";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // Quantity
            // 
            this.Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantity.BeforeTouchSize = new System.Drawing.Size(200, 27);
            this.Quantity.BorderColor = System.Drawing.Color.DarkGray;
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Quantity.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Quantity.IntegerValue = ((long)(0));
            this.Quantity.Location = new System.Drawing.Point(656, 28);
            this.Quantity.MaxValue = ((long)(50000));
            this.Quantity.Metrocolor = System.Drawing.Color.Green;
            this.Quantity.MinimumSize = new System.Drawing.Size(14, 10);
            this.Quantity.MinValue = ((long)(0));
            this.Quantity.Name = "Quantity";
            this.Quantity.NegativeSign = "";
            this.Quantity.NumberGroupSeparator = "";
            this.Quantity.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Quantity.Size = new System.Drawing.Size(65, 27);
            this.Quantity.TabIndex = 5;
            this.Quantity.ThemeName = "Default";
            this.Quantity.WordWrap = false;
            this.Quantity.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // LblTotalValue
            // 
            this.LblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalValue.AutoSize = true;
            this.LblTotalValue.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblTotalValue.Location = new System.Drawing.Point(724, 11);
            this.LblTotalValue.Name = "LblTotalValue";
            this.LblTotalValue.Size = new System.Drawing.Size(40, 17);
            this.LblTotalValue.TabIndex = 135;
            this.LblTotalValue.Text = "Total:";
            // 
            // TotalValue
            // 
            this.TotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalValue.BeforeTouchSize = new System.Drawing.Size(200, 27);
            this.TotalValue.BorderColor = System.Drawing.Color.DarkGray;
            this.TotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TotalValue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TotalValue.Enabled = false;
            this.TotalValue.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TotalValue.Location = new System.Drawing.Point(727, 28);
            this.TotalValue.Metrocolor = System.Drawing.Color.Green;
            this.TotalValue.MinimumSize = new System.Drawing.Size(14, 10);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TotalValue.Size = new System.Drawing.Size(130, 27);
            this.TotalValue.TabIndex = 6;
            this.TotalValue.Text = "R$ 0,00";
            this.TotalValue.ThemeName = "Default";
            this.TotalValue.WordWrap = false;
            this.TotalValue.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // LblUnitaryValue
            // 
            this.LblUnitaryValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUnitaryValue.AutoSize = true;
            this.LblUnitaryValue.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblUnitaryValue.Location = new System.Drawing.Point(523, 11);
            this.LblUnitaryValue.Name = "LblUnitaryValue";
            this.LblUnitaryValue.Size = new System.Drawing.Size(63, 17);
            this.LblUnitaryValue.TabIndex = 133;
            this.LblUnitaryValue.Text = "Valor Uni:";
            // 
            // UnitaryValue
            // 
            this.UnitaryValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitaryValue.BeforeTouchSize = new System.Drawing.Size(200, 27);
            this.UnitaryValue.BorderColor = System.Drawing.Color.DarkGray;
            this.UnitaryValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitaryValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UnitaryValue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.UnitaryValue.Enabled = false;
            this.UnitaryValue.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.UnitaryValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.UnitaryValue.Location = new System.Drawing.Point(526, 28);
            this.UnitaryValue.Metrocolor = System.Drawing.Color.Green;
            this.UnitaryValue.MinimumSize = new System.Drawing.Size(14, 10);
            this.UnitaryValue.Name = "UnitaryValue";
            this.UnitaryValue.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.UnitaryValue.Size = new System.Drawing.Size(124, 27);
            this.UnitaryValue.TabIndex = 4;
            this.UnitaryValue.Text = "R$ 0,00";
            this.UnitaryValue.ThemeName = "Default";
            this.UnitaryValue.WordWrap = false;
            this.UnitaryValue.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // LblQuantity
            // 
            this.LblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblQuantity.Location = new System.Drawing.Point(655, 11);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(47, 17);
            this.LblQuantity.TabIndex = 131;
            this.LblQuantity.Text = "Quant:";
            // 
            // QueryTitleByDescription
            // 
            this.QueryTitleByDescription.AutoSize = true;
            this.QueryTitleByDescription.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.QueryTitleByDescription.Location = new System.Drawing.Point(317, 11);
            this.QueryTitleByDescription.Name = "QueryTitleByDescription";
            this.QueryTitleByDescription.Size = new System.Drawing.Size(115, 17);
            this.QueryTitleByDescription.TabIndex = 130;
            this.QueryTitleByDescription.Text = "Descrição Produto:";
            // 
            // QueryTitleByReference
            // 
            this.QueryTitleByReference.AutoSize = true;
            this.QueryTitleByReference.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.QueryTitleByReference.Location = new System.Drawing.Point(233, 11);
            this.QueryTitleByReference.Name = "QueryTitleByReference";
            this.QueryTitleByReference.Size = new System.Drawing.Size(72, 17);
            this.QueryTitleByReference.TabIndex = 129;
            this.QueryTitleByReference.Text = "Referência:";
            // 
            // QueryTitleBySize
            // 
            this.QueryTitleBySize.AutoSize = true;
            this.QueryTitleBySize.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.QueryTitleBySize.Location = new System.Drawing.Point(149, 11);
            this.QueryTitleBySize.Name = "QueryTitleBySize";
            this.QueryTitleBySize.Size = new System.Drawing.Size(64, 17);
            this.QueryTitleBySize.TabIndex = 128;
            this.QueryTitleBySize.Text = "Tamanho:";
            // 
            // QueryByDescription
            // 
            this.QueryByDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryByDescription.BackColor = System.Drawing.Color.White;
            this.QueryByDescription.BeforeTouchSize = new System.Drawing.Size(200, 27);
            this.QueryByDescription.BorderColor = System.Drawing.Color.DarkGray;
            this.QueryByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryByDescription.CanOverrideStyle = true;
            this.QueryByDescription.CausesValidation = false;
            this.QueryByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QueryByDescription.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.QueryByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.QueryByDescription.Location = new System.Drawing.Point(320, 28);
            this.QueryByDescription.MaxLength = 50;
            this.QueryByDescription.Metrocolor = System.Drawing.Color.Green;
            this.QueryByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.QueryByDescription.Multiline = true;
            this.QueryByDescription.Name = "QueryByDescription";
            this.QueryByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.QueryByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.QueryByDescription.Size = new System.Drawing.Size(200, 27);
            this.QueryByDescription.TabIndex = 3;
            this.QueryByDescription.Tag = "";
            this.QueryByDescription.ThemeName = "Default";
            this.QueryByDescription.WordWrap = false;
            this.QueryByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShearchFields_KeyPress);
            // 
            // QueryTitleByCode
            // 
            this.QueryTitleByCode.AutoSize = true;
            this.QueryTitleByCode.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.QueryTitleByCode.Location = new System.Drawing.Point(66, 11);
            this.QueryTitleByCode.Name = "QueryTitleByCode";
            this.QueryTitleByCode.Size = new System.Drawing.Size(51, 17);
            this.QueryTitleByCode.TabIndex = 127;
            this.QueryTitleByCode.Text = "Código:";
            // 
            // QueryByCode
            // 
            this.QueryByCode.BackColor = System.Drawing.Color.White;
            this.QueryByCode.BeforeTouchSize = new System.Drawing.Size(200, 27);
            this.QueryByCode.BorderColor = System.Drawing.Color.DarkGray;
            this.QueryByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryByCode.CanOverrideStyle = true;
            this.QueryByCode.CausesValidation = false;
            this.QueryByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QueryByCode.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.QueryByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.QueryByCode.Location = new System.Drawing.Point(69, 28);
            this.QueryByCode.MaxLength = 50;
            this.QueryByCode.Metrocolor = System.Drawing.Color.Green;
            this.QueryByCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.QueryByCode.Multiline = true;
            this.QueryByCode.Name = "QueryByCode";
            this.QueryByCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.QueryByCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.QueryByCode.Size = new System.Drawing.Size(78, 27);
            this.QueryByCode.TabIndex = 0;
            this.QueryByCode.Tag = "";
            this.QueryByCode.ThemeName = "Default";
            this.QueryByCode.WordWrap = false;
            this.QueryByCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShearchFields_KeyPress);
            // 
            // QueryByReference
            // 
            this.QueryByReference.BackColor = System.Drawing.Color.White;
            this.QueryByReference.BeforeTouchSize = new System.Drawing.Size(200, 27);
            this.QueryByReference.BorderColor = System.Drawing.Color.DarkGray;
            this.QueryByReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryByReference.CanOverrideStyle = true;
            this.QueryByReference.CausesValidation = false;
            this.QueryByReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QueryByReference.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.QueryByReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.QueryByReference.Location = new System.Drawing.Point(236, 28);
            this.QueryByReference.MaxLength = 50;
            this.QueryByReference.Metrocolor = System.Drawing.Color.Green;
            this.QueryByReference.MinimumSize = new System.Drawing.Size(16, 12);
            this.QueryByReference.Multiline = true;
            this.QueryByReference.Name = "QueryByReference";
            this.QueryByReference.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.QueryByReference.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.QueryByReference.Size = new System.Drawing.Size(78, 27);
            this.QueryByReference.TabIndex = 2;
            this.QueryByReference.Tag = "";
            this.QueryByReference.ThemeName = "Default";
            this.QueryByReference.WordWrap = false;
            this.QueryByReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShearchFields_KeyPress);
            // 
            // QueryBySize
            // 
            this.QueryBySize.BackColor = System.Drawing.Color.White;
            this.QueryBySize.BeforeTouchSize = new System.Drawing.Size(200, 27);
            this.QueryBySize.BorderColor = System.Drawing.Color.DarkGray;
            this.QueryBySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryBySize.CanOverrideStyle = true;
            this.QueryBySize.CausesValidation = false;
            this.QueryBySize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QueryBySize.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.QueryBySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.QueryBySize.Location = new System.Drawing.Point(152, 28);
            this.QueryBySize.MaxLength = 50;
            this.QueryBySize.Metrocolor = System.Drawing.Color.Green;
            this.QueryBySize.MinimumSize = new System.Drawing.Size(16, 12);
            this.QueryBySize.Multiline = true;
            this.QueryBySize.Name = "QueryBySize";
            this.QueryBySize.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.QueryBySize.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.QueryBySize.Size = new System.Drawing.Size(78, 27);
            this.QueryBySize.TabIndex = 1;
            this.QueryBySize.Tag = "";
            this.QueryBySize.ThemeName = "Default";
            this.QueryBySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShearchFields_KeyPress);
            // 
            // StockMovementIdTitle
            // 
            this.StockMovementIdTitle.AutoSize = true;
            this.StockMovementIdTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.StockMovementIdTitle.ForeColor = System.Drawing.Color.Black;
            this.StockMovementIdTitle.Location = new System.Drawing.Point(31, 27);
            this.StockMovementIdTitle.Name = "StockMovementIdTitle";
            this.StockMovementIdTitle.Size = new System.Drawing.Size(125, 18);
            this.StockMovementIdTitle.TabIndex = 118;
            this.StockMovementIdTitle.Text = "Movimentação Nº:";
            // 
            // StockMovementId
            // 
            this.StockMovementId.AutoSize = true;
            this.StockMovementId.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.StockMovementId.ForeColor = System.Drawing.Color.Gray;
            this.StockMovementId.Location = new System.Drawing.Point(154, 28);
            this.StockMovementId.Name = "StockMovementId";
            this.StockMovementId.Size = new System.Drawing.Size(16, 17);
            this.StockMovementId.TabIndex = 119;
            this.StockMovementId.Text = "--";
            this.StockMovementId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OperationHour
            // 
            this.OperationHour.AutoSize = true;
            this.OperationHour.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.OperationHour.ForeColor = System.Drawing.Color.Gray;
            this.OperationHour.Location = new System.Drawing.Point(345, 61);
            this.OperationHour.Name = "OperationHour";
            this.OperationHour.Size = new System.Drawing.Size(16, 17);
            this.OperationHour.TabIndex = 125;
            this.OperationHour.Text = "--";
            // 
            // OperationHourTitle
            // 
            this.OperationHourTitle.AutoSize = true;
            this.OperationHourTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.OperationHourTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationHourTitle.Location = new System.Drawing.Point(289, 60);
            this.OperationHourTitle.Name = "OperationHourTitle";
            this.OperationHourTitle.Size = new System.Drawing.Size(58, 18);
            this.OperationHourTitle.TabIndex = 124;
            this.OperationHourTitle.Text = "Horário:";
            // 
            // OperationDate
            // 
            this.OperationDate.AutoSize = true;
            this.OperationDate.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.OperationDate.ForeColor = System.Drawing.Color.Gray;
            this.OperationDate.Location = new System.Drawing.Point(326, 30);
            this.OperationDate.Name = "OperationDate";
            this.OperationDate.Size = new System.Drawing.Size(16, 17);
            this.OperationDate.TabIndex = 123;
            this.OperationDate.Text = "--";
            // 
            // OperationDataTitle
            // 
            this.OperationDataTitle.AutoSize = true;
            this.OperationDataTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.OperationDataTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationDataTitle.Location = new System.Drawing.Point(289, 29);
            this.OperationDataTitle.Name = "OperationDataTitle";
            this.OperationDataTitle.Size = new System.Drawing.Size(40, 18);
            this.OperationDataTitle.TabIndex = 122;
            this.OperationDataTitle.Text = "Data:";
            // 
            // OperationSituation
            // 
            this.OperationSituation.AutoSize = true;
            this.OperationSituation.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.OperationSituation.ForeColor = System.Drawing.Color.Gray;
            this.OperationSituation.Location = new System.Drawing.Point(540, 30);
            this.OperationSituation.Name = "OperationSituation";
            this.OperationSituation.Size = new System.Drawing.Size(16, 17);
            this.OperationSituation.TabIndex = 127;
            this.OperationSituation.Text = "--";
            // 
            // OperationSituationTitle
            // 
            this.OperationSituationTitle.AutoSize = true;
            this.OperationSituationTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.OperationSituationTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationSituationTitle.Location = new System.Drawing.Point(479, 29);
            this.OperationSituationTitle.Name = "OperationSituationTitle";
            this.OperationSituationTitle.Size = new System.Drawing.Size(64, 18);
            this.OperationSituationTitle.TabIndex = 126;
            this.OperationSituationTitle.Text = "Situação:";
            // 
            // CardMain
            // 
            this.CardMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardMain.BackColor = System.Drawing.Color.White;
            this.CardMain.BorderRadius = 5;
            this.CardMain.BottomSahddow = true;
            this.CardMain.color = System.Drawing.Color.SlateGray;
            this.CardMain.Controls.Add(this.groupBox1);
            this.CardMain.Controls.Add(this.ClearQueryFields);
            this.CardMain.Controls.Add(this.GifLoading);
            this.CardMain.Controls.Add(this.AddItem);
            this.CardMain.Controls.Add(this.Quantity);
            this.CardMain.Controls.Add(this.LblTotalValue);
            this.CardMain.Controls.Add(this.QueryByDescription);
            this.CardMain.Controls.Add(this.TotalValue);
            this.CardMain.Controls.Add(this.QueryBySize);
            this.CardMain.Controls.Add(this.LblUnitaryValue);
            this.CardMain.Controls.Add(this.QueryByReference);
            this.CardMain.Controls.Add(this.QueryByCode);
            this.CardMain.Controls.Add(this.UnitaryValue);
            this.CardMain.Controls.Add(this.QueryTitleByCode);
            this.CardMain.Controls.Add(this.QueryTitleBySize);
            this.CardMain.Controls.Add(this.LblQuantity);
            this.CardMain.Controls.Add(this.QueryTitleByReference);
            this.CardMain.Controls.Add(this.QueryTitleByDescription);
            this.CardMain.Controls.Add(this.MainDataList);
            this.CardMain.LeftSahddow = true;
            this.CardMain.Location = new System.Drawing.Point(31, 288);
            this.CardMain.Name = "CardMain";
            this.CardMain.RightSahddow = true;
            this.CardMain.ShadowDepth = 20;
            this.CardMain.Size = new System.Drawing.Size(918, 420);
            this.CardMain.TabIndex = 136;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.SubTotal);
            this.groupBox1.Controls.Add(this.SubTotalTitle);
            this.groupBox1.Controls.Add(this.TitleOfTotalItems);
            this.groupBox1.Controls.Add(this.TotalItems);
            this.groupBox1.Location = new System.Drawing.Point(21, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 50);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            // 
            // TitleOfTotalItems
            // 
            this.TitleOfTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TitleOfTotalItems.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.TitleOfTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleOfTotalItems.Location = new System.Drawing.Point(26, 15);
            this.TitleOfTotalItems.Name = "TitleOfTotalItems";
            this.TitleOfTotalItems.Size = new System.Drawing.Size(64, 23);
            this.TitleOfTotalItems.TabIndex = 137;
            this.TitleOfTotalItems.Text = "ITENS:";
            this.TitleOfTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalItems
            // 
            this.TotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalItems.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItems.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.TotalItems.Location = new System.Drawing.Point(86, 14);
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.Size = new System.Drawing.Size(98, 23);
            this.TotalItems.TabIndex = 138;
            this.TotalItems.Text = "0";
            this.TotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ClearQueryFields
            // 
            this.ClearQueryFields.AutoSize = true;
            this.ClearQueryFields.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ClearQueryFields.Location = new System.Drawing.Point(25, 34);
            this.ClearQueryFields.Name = "ClearQueryFields";
            this.ClearQueryFields.Size = new System.Drawing.Size(38, 13);
            this.ClearQueryFields.TabIndex = 141;
            this.ClearQueryFields.TabStop = true;
            this.ClearQueryFields.Text = "Limpar";
            this.ClearQueryFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearQueryFields_LinkClicked);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GifLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.GifLoading.Location = new System.Drawing.Point(380, 124);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(188, 172);
            this.GifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GifLoading.TabIndex = 139;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
            // 
            // MainDataList
            // 
            this.MainDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MainDataList.ListIsItem = false;
            this.MainDataList.ListIsStock = false;
            this.MainDataList.Location = new System.Drawing.Point(21, 60);
            this.MainDataList.Name = "MainDataList";
            this.MainDataList.Size = new System.Drawing.Size(877, 287);
            this.MainDataList.TabIndex = 141;
            this.MainDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataList_CellClick);
            this.MainDataList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataList_CellMouseEnter);
            this.MainDataList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.MainDataList_RowPrePaint);
            this.MainDataList.DoubleClick += new System.EventHandler(this.MainDataList_DoubleClick);
            // 
            // GrupBoxGeneralInformation
            // 
            this.GrupBoxGeneralInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationTypeTitle);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationType);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationDate);
            this.GrupBoxGeneralInformation.Controls.Add(this.StockMovementIdTitle);
            this.GrupBoxGeneralInformation.Controls.Add(this.StockMovementId);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationSituation);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationDataTitle);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationSituationTitle);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationHour);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationHourTitle);
            this.GrupBoxGeneralInformation.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.GrupBoxGeneralInformation.Location = new System.Drawing.Point(31, 108);
            this.GrupBoxGeneralInformation.Name = "GrupBoxGeneralInformation";
            this.GrupBoxGeneralInformation.Size = new System.Drawing.Size(918, 96);
            this.GrupBoxGeneralInformation.TabIndex = 140;
            this.GrupBoxGeneralInformation.TabStop = false;
            this.GrupBoxGeneralInformation.Text = "Informações Gerais";
            // 
            // OperationTypeTitle
            // 
            this.OperationTypeTitle.AutoSize = true;
            this.OperationTypeTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.OperationTypeTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationTypeTitle.Location = new System.Drawing.Point(31, 61);
            this.OperationTypeTitle.Name = "OperationTypeTitle";
            this.OperationTypeTitle.Size = new System.Drawing.Size(39, 18);
            this.OperationTypeTitle.TabIndex = 128;
            this.OperationTypeTitle.Text = "Tipo:";
            // 
            // OperationType
            // 
            this.OperationType.AutoSize = true;
            this.OperationType.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.OperationType.ForeColor = System.Drawing.Color.Gray;
            this.OperationType.Location = new System.Drawing.Point(68, 62);
            this.OperationType.Name = "OperationType";
            this.OperationType.Size = new System.Drawing.Size(16, 17);
            this.OperationType.TabIndex = 129;
            this.OperationType.Text = "--";
            this.OperationType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblStockDestination
            // 
            this.LblStockDestination.AutoSize = true;
            this.LblStockDestination.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblStockDestination.ForeColor = System.Drawing.Color.Black;
            this.LblStockDestination.Location = new System.Drawing.Point(29, 220);
            this.LblStockDestination.Name = "LblStockDestination";
            this.LblStockDestination.Size = new System.Drawing.Size(55, 17);
            this.LblStockDestination.TabIndex = 142;
            this.LblStockDestination.Text = "Destino:";
            // 
            // StockDestinationList
            // 
            this.StockDestinationList.BackColor = System.Drawing.Color.White;
            this.StockDestinationList.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.StockDestinationList.FormattingEnabled = true;
            this.StockDestinationList.Location = new System.Drawing.Point(31, 239);
            this.StockDestinationList.Name = "StockDestinationList";
            this.StockDestinationList.Size = new System.Drawing.Size(266, 27);
            this.StockDestinationList.TabIndex = 145;
            this.StockDestinationList.DropDown += new System.EventHandler(this.StockDestinationList_DropDown);
            this.StockDestinationList.SelectedIndexChanged += new System.EventHandler(this.StockDestinationList_SelectedIndexChanged);
            this.StockDestinationList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StockDestinationList_KeyPress);
            // 
            // AddNewStockDestination
            // 
            this.AddNewStockDestination.AutoSize = true;
            this.AddNewStockDestination.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.AddNewStockDestination.Location = new System.Drawing.Point(216, 223);
            this.AddNewStockDestination.Name = "AddNewStockDestination";
            this.AddNewStockDestination.Size = new System.Drawing.Size(81, 13);
            this.AddNewStockDestination.TabIndex = 146;
            this.AddNewStockDestination.TabStop = true;
            this.AddNewStockDestination.Text = "Cadastrar Novo";
            this.AddNewStockDestination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewStockDestination_LinkClicked);
            // 
            // StockMovementMenuStrip
            // 
            this.StockMovementMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovementEntrie_ToolStripMenuItem,
            this.MovementOutPut_ToolStripMenuItem});
            this.StockMovementMenuStrip.Name = "ContextMenuStrip";
            this.StockMovementMenuStrip.Size = new System.Drawing.Size(115, 48);
            // 
            // MovementEntrie_ToolStripMenuItem
            // 
            this.MovementEntrie_ToolStripMenuItem.Name = "MovementEntrie_ToolStripMenuItem";
            this.MovementEntrie_ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.MovementEntrie_ToolStripMenuItem.Text = "Entrada";
            this.MovementEntrie_ToolStripMenuItem.Click += new System.EventHandler(this.MovementEntrie_ToolStripMenuItem_Click);
            // 
            // MovementOutPut_ToolStripMenuItem
            // 
            this.MovementOutPut_ToolStripMenuItem.Name = "MovementOutPut_ToolStripMenuItem";
            this.MovementOutPut_ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.MovementOutPut_ToolStripMenuItem.Text = "Saída";
            this.MovementOutPut_ToolStripMenuItem.Click += new System.EventHandler(this.MovementOutPut_ToolStripMenuItem_Click);
            // 
            // RegisterNew
            // 
            this.RegisterNew.ActiveBorderThickness = 1;
            this.RegisterNew.ActiveCornerRadius = 10;
            this.RegisterNew.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.RegisterNew.ActiveForecolor = System.Drawing.Color.White;
            this.RegisterNew.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.RegisterNew.BackColor = System.Drawing.Color.White;
            this.RegisterNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterNew.BackgroundImage")));
            this.RegisterNew.ButtonText = "Nova";
            this.RegisterNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterNew.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.RegisterNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.IdleBorderThickness = 1;
            this.RegisterNew.IdleCornerRadius = 10;
            this.RegisterNew.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.RegisterNew.IdleForecolor = System.Drawing.Color.White;
            this.RegisterNew.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.RegisterNew.Location = new System.Drawing.Point(26, 29);
            this.RegisterNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterNew.Name = "RegisterNew";
            this.RegisterNew.Size = new System.Drawing.Size(97, 43);
            this.RegisterNew.TabIndex = 217;
            this.RegisterNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterNew.Click += new System.EventHandler(this.RegisterNew_Click);
            // 
            // Delete
            // 
            this.Delete.ActiveBorderThickness = 1;
            this.Delete.ActiveCornerRadius = 10;
            this.Delete.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.Delete.ActiveForecolor = System.Drawing.Color.White;
            this.Delete.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.Delete.BackColor = System.Drawing.Color.White;
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.ButtonText = "Excluir";
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.Delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.Delete.IdleBorderThickness = 1;
            this.Delete.IdleCornerRadius = 10;
            this.Delete.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.Delete.IdleForecolor = System.Drawing.Color.White;
            this.Delete.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.Delete.Location = new System.Drawing.Point(125, 29);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(97, 43);
            this.Delete.TabIndex = 218;
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Confirm
            // 
            this.Confirm.ActiveBorderThickness = 1;
            this.Confirm.ActiveCornerRadius = 10;
            this.Confirm.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.Confirm.ActiveForecolor = System.Drawing.Color.White;
            this.Confirm.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.Confirm.BackColor = System.Drawing.Color.White;
            this.Confirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Confirm.BackgroundImage")));
            this.Confirm.ButtonText = "Confirmar";
            this.Confirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.Confirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.Confirm.IdleBorderThickness = 1;
            this.Confirm.IdleCornerRadius = 10;
            this.Confirm.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.Confirm.IdleForecolor = System.Drawing.Color.White;
            this.Confirm.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.Confirm.Location = new System.Drawing.Point(224, 29);
            this.Confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(97, 43);
            this.Confirm.TabIndex = 219;
            this.Confirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.ActiveBorderThickness = 1;
            this.CloseForm.ActiveCornerRadius = 10;
            this.CloseForm.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.CloseForm.ActiveForecolor = System.Drawing.Color.White;
            this.CloseForm.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseForm.BackColor = System.Drawing.Color.White;
            this.CloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseForm.BackgroundImage")));
            this.CloseForm.ButtonText = "Sair";
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.CloseForm.ForeColor = System.Drawing.Color.SeaGreen;
            this.CloseForm.IdleBorderThickness = 1;
            this.CloseForm.IdleCornerRadius = 10;
            this.CloseForm.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.CloseForm.IdleForecolor = System.Drawing.Color.White;
            this.CloseForm.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.CloseForm.Location = new System.Drawing.Point(851, 29);
            this.CloseForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(97, 43);
            this.CloseForm.TabIndex = 220;
            this.CloseForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // StockMovementRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(980, 720);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.RegisterNew);
            this.Controls.Add(this.AddNewStockDestination);
            this.Controls.Add(this.StockDestinationList);
            this.Controls.Add(this.GrupBoxGeneralInformation);
            this.Controls.Add(this.LblStockDestination);
            this.Controls.Add(this.CardMain);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "StockMovementRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.StockMovementResgistrationForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitaryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryBySize)).EndInit();
            this.CardMain.ResumeLayout(false);
            this.CardMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataList)).EndInit();
            this.GrupBoxGeneralInformation.ResumeLayout(false);
            this.GrupBoxGeneralInformation.PerformLayout();
            this.StockMovementMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.Label SubTotalTitle;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label OperationHourTitle;
        private System.Windows.Forms.Label OperationDataTitle;
        private System.Windows.Forms.Label OperationSituationTitle;
        private Syncfusion.WinForms.Controls.SfButton AddItem;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox Quantity;
        private System.Windows.Forms.Label LblTotalValue;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TotalValue;
        private System.Windows.Forms.Label LblUnitaryValue;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox UnitaryValue;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label QueryTitleByDescription;
        private System.Windows.Forms.Label QueryTitleByReference;
        private System.Windows.Forms.Label QueryTitleBySize;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt QueryByDescription;
        private System.Windows.Forms.Label QueryTitleByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt QueryByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt QueryByReference;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt QueryBySize;
        public System.Windows.Forms.Label StockMovementId;
        public System.Windows.Forms.Label OperationHour;
        public System.Windows.Forms.Label OperationDate;
        public System.Windows.Forms.Label OperationSituation;
        private Bunifu.Framework.UI.BunifuCards CardMain;
        private System.Windows.Forms.Label TotalItems;
        private System.Windows.Forms.Label TitleOfTotalItems;
        private System.Windows.Forms.PictureBox GifLoading;
        public System.Windows.Forms.Label StockMovementIdTitle;
        private System.Windows.Forms.GroupBox GrupBoxGeneralInformation;
        public System.Windows.Forms.Label OperationTypeTitle;
        public System.Windows.Forms.Label OperationType;
        private System.Windows.Forms.LinkLabel ClearQueryFields;
        public Controls.CustomDataGridViewOne MainDataList;
        public System.Windows.Forms.Label LblStockDestination;
        private System.Windows.Forms.ComboBox StockDestinationList;
        private System.Windows.Forms.LinkLabel AddNewStockDestination;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip StockMovementMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MovementEntrie_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovementOutPut_ToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuThinButton2 RegisterNew;
        private Bunifu.Framework.UI.BunifuThinButton2 Delete;
        private Bunifu.Framework.UI.BunifuThinButton2 Confirm;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseForm;
    }
}