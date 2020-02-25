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
            this.ButtonAddItem = new Syncfusion.WinForms.Controls.SfButton();
            this.TextQuantity = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.LblTotalValue = new System.Windows.Forms.Label();
            this.TextTotalValue = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.LblUnitaryValue = new System.Windows.Forms.Label();
            this.TextUnitaryValue = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.QueryTitleByDescription = new System.Windows.Forms.Label();
            this.TextSearchByDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.QueryTitleByCode = new System.Windows.Forms.Label();
            this.TextSearchByCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.StockMovementIdTitle = new System.Windows.Forms.Label();
            this.TextStockMovementId = new System.Windows.Forms.Label();
            this.TextOperationHour = new System.Windows.Forms.Label();
            this.OperationHourTitle = new System.Windows.Forms.Label();
            this.TextOperationDate = new System.Windows.Forms.Label();
            this.OperationDataTitle = new System.Windows.Forms.Label();
            this.TextOperationSituation = new System.Windows.Forms.Label();
            this.OperationSituationTitle = new System.Windows.Forms.Label();
            this.CardMain = new Bunifu.Framework.UI.BunifuCards();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TitleOfTotalItems = new System.Windows.Forms.Label();
            this.TotalItems = new System.Windows.Forms.Label();
            this.ButtonClear_SearchFields = new System.Windows.Forms.LinkLabel();
            this.PictureLoading = new System.Windows.Forms.PictureBox();
            this.DataGridMainDataList = new DimStock.Controls.CustomDataGridViewOne();
            this.GrupBoxGeneralInformation = new System.Windows.Forms.GroupBox();
            this.OperationTypeTitle = new System.Windows.Forms.Label();
            this.TextOperationType = new System.Windows.Forms.Label();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.ComboBoxStockDestinationList = new System.Windows.Forms.ComboBox();
            this.ButtonShow_StockDestination_RegistrationForm = new System.Windows.Forms.LinkLabel();
            this.StockMovementMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MovementEntrie_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovementOutPut_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButtonRegisterNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonConfirm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonCloseForm = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.TextQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextTotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextUnitaryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByCode)).BeginInit();
            this.CardMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMainDataList)).BeginInit();
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
            this.SubTotalTitle.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.SubTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubTotalTitle.Location = new System.Drawing.Point(202, 14);
            this.SubTotalTitle.Name = "SubTotalTitle";
            this.SubTotalTitle.Size = new System.Drawing.Size(106, 23);
            this.SubTotalTitle.TabIndex = 115;
            this.SubTotalTitle.Text = "SubTotal:";
            this.SubTotalTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SubTotal
            // 
            this.SubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubTotal.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.SubTotal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.SubTotal.Location = new System.Drawing.Point(289, 14);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(196, 23);
            this.SubTotal.TabIndex = 116;
            this.SubTotal.Text = "R$0.00";
            this.SubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonAddItem
            // 
            this.ButtonAddItem.AccessibleName = "Button";
            this.ButtonAddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonAddItem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonAddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddItem.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddItem.ForeColor = System.Drawing.Color.White;
            this.ButtonAddItem.Location = new System.Drawing.Point(802, 28);
            this.ButtonAddItem.Name = "ButtonAddItem";
            this.ButtonAddItem.Size = new System.Drawing.Size(44, 27);
            this.ButtonAddItem.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonAddItem.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.ButtonAddItem.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonAddItem.Style.FocusedBackColor = System.Drawing.Color.Crimson;
            this.ButtonAddItem.Style.FocusedForeColor = System.Drawing.Color.White;
            this.ButtonAddItem.Style.ForeColor = System.Drawing.Color.White;
            this.ButtonAddItem.Style.HoverBackColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonAddItem.Style.HoverForeColor = System.Drawing.Color.White;
            this.ButtonAddItem.Style.PressedBackColor = System.Drawing.Color.Crimson;
            this.ButtonAddItem.Style.PressedForeColor = System.Drawing.Color.White;
            this.ButtonAddItem.TabIndex = 7;
            this.ButtonAddItem.Text = "Add";
            this.ButtonAddItem.UseVisualStyleBackColor = false;
            this.ButtonAddItem.Click += new System.EventHandler(this.ButtonAddItem_Click);
            // 
            // TextQuantity
            // 
            this.TextQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextQuantity.BeforeTouchSize = new System.Drawing.Size(95, 27);
            this.TextQuantity.BorderColor = System.Drawing.Color.Gray;
            this.TextQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextQuantity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextQuantity.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextQuantity.IntegerValue = ((long)(0));
            this.TextQuantity.Location = new System.Drawing.Point(604, 28);
            this.TextQuantity.MaxValue = ((long)(50000));
            this.TextQuantity.Metrocolor = System.Drawing.Color.Green;
            this.TextQuantity.MinimumSize = new System.Drawing.Size(14, 10);
            this.TextQuantity.MinValue = ((long)(0));
            this.TextQuantity.Name = "TextQuantity";
            this.TextQuantity.NegativeSign = "";
            this.TextQuantity.NumberGroupSeparator = "";
            this.TextQuantity.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextQuantity.Size = new System.Drawing.Size(65, 27);
            this.TextQuantity.TabIndex = 5;
            this.TextQuantity.ThemeName = "Default";
            this.TextQuantity.WordWrap = false;
            this.TextQuantity.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextQuantity_KeyPress);
            // 
            // LblTotalValue
            // 
            this.LblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalValue.AutoSize = true;
            this.LblTotalValue.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblTotalValue.Location = new System.Drawing.Point(672, 11);
            this.LblTotalValue.Name = "LblTotalValue";
            this.LblTotalValue.Size = new System.Drawing.Size(40, 17);
            this.LblTotalValue.TabIndex = 135;
            this.LblTotalValue.Text = "Total:";
            // 
            // TextTotalValue
            // 
            this.TextTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextTotalValue.BeforeTouchSize = new System.Drawing.Size(95, 27);
            this.TextTotalValue.BorderColor = System.Drawing.Color.Gray;
            this.TextTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextTotalValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextTotalValue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextTotalValue.Enabled = false;
            this.TextTotalValue.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextTotalValue.Location = new System.Drawing.Point(675, 28);
            this.TextTotalValue.Metrocolor = System.Drawing.Color.Green;
            this.TextTotalValue.MinimumSize = new System.Drawing.Size(14, 10);
            this.TextTotalValue.Name = "TextTotalValue";
            this.TextTotalValue.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextTotalValue.Size = new System.Drawing.Size(126, 27);
            this.TextTotalValue.TabIndex = 6;
            this.TextTotalValue.Text = "R$ 0,00";
            this.TextTotalValue.ThemeName = "Default";
            this.TextTotalValue.WordWrap = false;
            this.TextTotalValue.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // LblUnitaryValue
            // 
            this.LblUnitaryValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblUnitaryValue.AutoSize = true;
            this.LblUnitaryValue.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblUnitaryValue.Location = new System.Drawing.Point(471, 11);
            this.LblUnitaryValue.Name = "LblUnitaryValue";
            this.LblUnitaryValue.Size = new System.Drawing.Size(63, 17);
            this.LblUnitaryValue.TabIndex = 133;
            this.LblUnitaryValue.Text = "Valor Uni:";
            // 
            // TextUnitaryValue
            // 
            this.TextUnitaryValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TextUnitaryValue.BeforeTouchSize = new System.Drawing.Size(95, 27);
            this.TextUnitaryValue.BorderColor = System.Drawing.Color.Gray;
            this.TextUnitaryValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextUnitaryValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextUnitaryValue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextUnitaryValue.Enabled = false;
            this.TextUnitaryValue.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextUnitaryValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextUnitaryValue.Location = new System.Drawing.Point(474, 28);
            this.TextUnitaryValue.Metrocolor = System.Drawing.Color.Green;
            this.TextUnitaryValue.MinimumSize = new System.Drawing.Size(14, 10);
            this.TextUnitaryValue.Name = "TextUnitaryValue";
            this.TextUnitaryValue.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextUnitaryValue.Size = new System.Drawing.Size(124, 27);
            this.TextUnitaryValue.TabIndex = 4;
            this.TextUnitaryValue.Text = "R$ 0,00";
            this.TextUnitaryValue.ThemeName = "Default";
            this.TextUnitaryValue.WordWrap = false;
            this.TextUnitaryValue.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // LblQuantity
            // 
            this.LblQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblQuantity.Location = new System.Drawing.Point(603, 11);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(47, 17);
            this.LblQuantity.TabIndex = 131;
            this.LblQuantity.Text = "Quant:";
            // 
            // QueryTitleByDescription
            // 
            this.QueryTitleByDescription.AutoSize = true;
            this.QueryTitleByDescription.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.QueryTitleByDescription.Location = new System.Drawing.Point(167, 11);
            this.QueryTitleByDescription.Name = "QueryTitleByDescription";
            this.QueryTitleByDescription.Size = new System.Drawing.Size(115, 17);
            this.QueryTitleByDescription.TabIndex = 130;
            this.QueryTitleByDescription.Text = "Descrição Produto:";
            // 
            // TextSearchByDescription
            // 
            this.TextSearchByDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSearchByDescription.BackColor = System.Drawing.Color.White;
            this.TextSearchByDescription.BeforeTouchSize = new System.Drawing.Size(95, 27);
            this.TextSearchByDescription.BorderColor = System.Drawing.Color.Gray;
            this.TextSearchByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchByDescription.CanOverrideStyle = true;
            this.TextSearchByDescription.CausesValidation = false;
            this.TextSearchByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchByDescription.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextSearchByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSearchByDescription.Location = new System.Drawing.Point(170, 28);
            this.TextSearchByDescription.MaxLength = 50;
            this.TextSearchByDescription.Metrocolor = System.Drawing.Color.Green;
            this.TextSearchByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchByDescription.Multiline = true;
            this.TextSearchByDescription.Name = "TextSearchByDescription";
            this.TextSearchByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextSearchByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextSearchByDescription.Size = new System.Drawing.Size(298, 27);
            this.TextSearchByDescription.TabIndex = 3;
            this.TextSearchByDescription.Tag = "";
            this.TextSearchByDescription.ThemeName = "Default";
            this.TextSearchByDescription.WordWrap = false;
            this.TextSearchByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextShearchFields_KeyPress);
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
            // TextSearchByCode
            // 
            this.TextSearchByCode.BackColor = System.Drawing.Color.White;
            this.TextSearchByCode.BeforeTouchSize = new System.Drawing.Size(95, 27);
            this.TextSearchByCode.BorderColor = System.Drawing.Color.Gray;
            this.TextSearchByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchByCode.CanOverrideStyle = true;
            this.TextSearchByCode.CausesValidation = false;
            this.TextSearchByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchByCode.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextSearchByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSearchByCode.Location = new System.Drawing.Point(69, 28);
            this.TextSearchByCode.MaxLength = 50;
            this.TextSearchByCode.Metrocolor = System.Drawing.Color.Green;
            this.TextSearchByCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchByCode.Multiline = true;
            this.TextSearchByCode.Name = "TextSearchByCode";
            this.TextSearchByCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextSearchByCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextSearchByCode.Size = new System.Drawing.Size(95, 27);
            this.TextSearchByCode.TabIndex = 0;
            this.TextSearchByCode.Tag = "";
            this.TextSearchByCode.ThemeName = "Default";
            this.TextSearchByCode.WordWrap = false;
            this.TextSearchByCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextShearchFields_KeyPress);
            // 
            // StockMovementIdTitle
            // 
            this.StockMovementIdTitle.AutoSize = true;
            this.StockMovementIdTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.StockMovementIdTitle.ForeColor = System.Drawing.Color.Black;
            this.StockMovementIdTitle.Location = new System.Drawing.Point(31, 24);
            this.StockMovementIdTitle.Name = "StockMovementIdTitle";
            this.StockMovementIdTitle.Size = new System.Drawing.Size(125, 18);
            this.StockMovementIdTitle.TabIndex = 118;
            this.StockMovementIdTitle.Text = "Movimentação Nº:";
            // 
            // TextStockMovementId
            // 
            this.TextStockMovementId.AutoSize = true;
            this.TextStockMovementId.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.TextStockMovementId.ForeColor = System.Drawing.Color.Gray;
            this.TextStockMovementId.Location = new System.Drawing.Point(154, 25);
            this.TextStockMovementId.Name = "TextStockMovementId";
            this.TextStockMovementId.Size = new System.Drawing.Size(16, 17);
            this.TextStockMovementId.TabIndex = 119;
            this.TextStockMovementId.Text = "--";
            this.TextStockMovementId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TextOperationHour
            // 
            this.TextOperationHour.AutoSize = true;
            this.TextOperationHour.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.TextOperationHour.ForeColor = System.Drawing.Color.Gray;
            this.TextOperationHour.Location = new System.Drawing.Point(345, 53);
            this.TextOperationHour.Name = "TextOperationHour";
            this.TextOperationHour.Size = new System.Drawing.Size(16, 17);
            this.TextOperationHour.TabIndex = 125;
            this.TextOperationHour.Text = "--";
            // 
            // OperationHourTitle
            // 
            this.OperationHourTitle.AutoSize = true;
            this.OperationHourTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.OperationHourTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationHourTitle.Location = new System.Drawing.Point(289, 52);
            this.OperationHourTitle.Name = "OperationHourTitle";
            this.OperationHourTitle.Size = new System.Drawing.Size(58, 18);
            this.OperationHourTitle.TabIndex = 124;
            this.OperationHourTitle.Text = "Horário:";
            // 
            // TextOperationDate
            // 
            this.TextOperationDate.AutoSize = true;
            this.TextOperationDate.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.TextOperationDate.ForeColor = System.Drawing.Color.Gray;
            this.TextOperationDate.Location = new System.Drawing.Point(326, 27);
            this.TextOperationDate.Name = "TextOperationDate";
            this.TextOperationDate.Size = new System.Drawing.Size(16, 17);
            this.TextOperationDate.TabIndex = 123;
            this.TextOperationDate.Text = "--";
            // 
            // OperationDataTitle
            // 
            this.OperationDataTitle.AutoSize = true;
            this.OperationDataTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.OperationDataTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationDataTitle.Location = new System.Drawing.Point(289, 26);
            this.OperationDataTitle.Name = "OperationDataTitle";
            this.OperationDataTitle.Size = new System.Drawing.Size(40, 18);
            this.OperationDataTitle.TabIndex = 122;
            this.OperationDataTitle.Text = "Data:";
            // 
            // TextOperationSituation
            // 
            this.TextOperationSituation.AutoSize = true;
            this.TextOperationSituation.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.TextOperationSituation.ForeColor = System.Drawing.Color.Gray;
            this.TextOperationSituation.Location = new System.Drawing.Point(540, 27);
            this.TextOperationSituation.Name = "TextOperationSituation";
            this.TextOperationSituation.Size = new System.Drawing.Size(16, 17);
            this.TextOperationSituation.TabIndex = 127;
            this.TextOperationSituation.Text = "--";
            // 
            // OperationSituationTitle
            // 
            this.OperationSituationTitle.AutoSize = true;
            this.OperationSituationTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.OperationSituationTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationSituationTitle.Location = new System.Drawing.Point(479, 26);
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
            this.CardMain.Controls.Add(this.ButtonClear_SearchFields);
            this.CardMain.Controls.Add(this.PictureLoading);
            this.CardMain.Controls.Add(this.ButtonAddItem);
            this.CardMain.Controls.Add(this.TextQuantity);
            this.CardMain.Controls.Add(this.LblTotalValue);
            this.CardMain.Controls.Add(this.TextSearchByDescription);
            this.CardMain.Controls.Add(this.TextTotalValue);
            this.CardMain.Controls.Add(this.LblUnitaryValue);
            this.CardMain.Controls.Add(this.TextSearchByCode);
            this.CardMain.Controls.Add(this.TextUnitaryValue);
            this.CardMain.Controls.Add(this.QueryTitleByCode);
            this.CardMain.Controls.Add(this.LblQuantity);
            this.CardMain.Controls.Add(this.QueryTitleByDescription);
            this.CardMain.Controls.Add(this.DataGridMainDataList);
            this.CardMain.LeftSahddow = true;
            this.CardMain.Location = new System.Drawing.Point(31, 224);
            this.CardMain.Name = "CardMain";
            this.CardMain.RightSahddow = true;
            this.CardMain.ShadowDepth = 20;
            this.CardMain.Size = new System.Drawing.Size(866, 309);
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
            this.groupBox1.Location = new System.Drawing.Point(21, 236);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(825, 50);
            this.groupBox1.TabIndex = 142;
            this.groupBox1.TabStop = false;
            // 
            // TitleOfTotalItems
            // 
            this.TitleOfTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TitleOfTotalItems.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.TitleOfTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleOfTotalItems.Location = new System.Drawing.Point(26, 14);
            this.TitleOfTotalItems.Name = "TitleOfTotalItems";
            this.TitleOfTotalItems.Size = new System.Drawing.Size(70, 23);
            this.TitleOfTotalItems.TabIndex = 137;
            this.TitleOfTotalItems.Text = "Itens:";
            this.TitleOfTotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TotalItems
            // 
            this.TotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalItems.Font = new System.Drawing.Font("Calibri Light", 16F);
            this.TotalItems.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.TotalItems.Location = new System.Drawing.Point(95, 16);
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.Size = new System.Drawing.Size(98, 23);
            this.TotalItems.TabIndex = 138;
            this.TotalItems.Text = "0";
            this.TotalItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonClear_SearchFields
            // 
            this.ButtonClear_SearchFields.AutoSize = true;
            this.ButtonClear_SearchFields.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear_SearchFields.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonClear_SearchFields.Location = new System.Drawing.Point(18, 30);
            this.ButtonClear_SearchFields.Name = "ButtonClear_SearchFields";
            this.ButtonClear_SearchFields.Size = new System.Drawing.Size(49, 18);
            this.ButtonClear_SearchFields.TabIndex = 141;
            this.ButtonClear_SearchFields.TabStop = true;
            this.ButtonClear_SearchFields.Text = "Limpar";
            this.ButtonClear_SearchFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonClear_SearchFields_LinkClicked);
            // 
            // PictureLoading
            // 
            this.PictureLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.PictureLoading.Location = new System.Drawing.Point(371, 80);
            this.PictureLoading.Name = "PictureLoading";
            this.PictureLoading.Size = new System.Drawing.Size(135, 135);
            this.PictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLoading.TabIndex = 139;
            this.PictureLoading.TabStop = false;
            this.PictureLoading.Visible = false;
            // 
            // DataGridMainDataList
            // 
            this.DataGridMainDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridMainDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridMainDataList.ListIsItem = false;
            this.DataGridMainDataList.ListIsStock = false;
            this.DataGridMainDataList.Location = new System.Drawing.Point(21, 60);
            this.DataGridMainDataList.Name = "DataGridMainDataList";
            this.DataGridMainDataList.Size = new System.Drawing.Size(825, 176);
            this.DataGridMainDataList.TabIndex = 141;
            this.DataGridMainDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMainDataList_CellClick);
            this.DataGridMainDataList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridMainDataList_CellMouseEnter);
            this.DataGridMainDataList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DataGridMainDataList_RowPrePaint);
            this.DataGridMainDataList.DoubleClick += new System.EventHandler(this.DataGridMainDataList_DoubleClick);
            // 
            // GrupBoxGeneralInformation
            // 
            this.GrupBoxGeneralInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationTypeTitle);
            this.GrupBoxGeneralInformation.Controls.Add(this.TextOperationType);
            this.GrupBoxGeneralInformation.Controls.Add(this.TextOperationDate);
            this.GrupBoxGeneralInformation.Controls.Add(this.StockMovementIdTitle);
            this.GrupBoxGeneralInformation.Controls.Add(this.TextStockMovementId);
            this.GrupBoxGeneralInformation.Controls.Add(this.TextOperationSituation);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationDataTitle);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationSituationTitle);
            this.GrupBoxGeneralInformation.Controls.Add(this.TextOperationHour);
            this.GrupBoxGeneralInformation.Controls.Add(this.OperationHourTitle);
            this.GrupBoxGeneralInformation.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.GrupBoxGeneralInformation.Location = new System.Drawing.Point(31, 64);
            this.GrupBoxGeneralInformation.Name = "GrupBoxGeneralInformation";
            this.GrupBoxGeneralInformation.Size = new System.Drawing.Size(866, 83);
            this.GrupBoxGeneralInformation.TabIndex = 140;
            this.GrupBoxGeneralInformation.TabStop = false;
            this.GrupBoxGeneralInformation.Text = "Informações Gerais";
            // 
            // OperationTypeTitle
            // 
            this.OperationTypeTitle.AutoSize = true;
            this.OperationTypeTitle.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.OperationTypeTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationTypeTitle.Location = new System.Drawing.Point(31, 53);
            this.OperationTypeTitle.Name = "OperationTypeTitle";
            this.OperationTypeTitle.Size = new System.Drawing.Size(39, 18);
            this.OperationTypeTitle.TabIndex = 128;
            this.OperationTypeTitle.Text = "Tipo:";
            // 
            // TextOperationType
            // 
            this.TextOperationType.AutoSize = true;
            this.TextOperationType.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.TextOperationType.ForeColor = System.Drawing.Color.Gray;
            this.TextOperationType.Location = new System.Drawing.Point(68, 54);
            this.TextOperationType.Name = "TextOperationType";
            this.TextOperationType.Size = new System.Drawing.Size(16, 17);
            this.TextOperationType.TabIndex = 129;
            this.TextOperationType.Text = "--";
            this.TextOperationType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblStockDestination
            // 
            this.LblStockDestination.AutoSize = true;
            this.LblStockDestination.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblStockDestination.ForeColor = System.Drawing.Color.Black;
            this.LblStockDestination.Location = new System.Drawing.Point(29, 162);
            this.LblStockDestination.Name = "LblStockDestination";
            this.LblStockDestination.Size = new System.Drawing.Size(55, 17);
            this.LblStockDestination.TabIndex = 142;
            this.LblStockDestination.Text = "Destino:";
            // 
            // ComboBoxStockDestinationList
            // 
            this.ComboBoxStockDestinationList.BackColor = System.Drawing.Color.White;
            this.ComboBoxStockDestinationList.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ComboBoxStockDestinationList.FormattingEnabled = true;
            this.ComboBoxStockDestinationList.Location = new System.Drawing.Point(31, 181);
            this.ComboBoxStockDestinationList.Name = "ComboBoxStockDestinationList";
            this.ComboBoxStockDestinationList.Size = new System.Drawing.Size(314, 27);
            this.ComboBoxStockDestinationList.TabIndex = 145;
            this.ComboBoxStockDestinationList.DropDown += new System.EventHandler(this.ComboBoxStockDestinationList_DropDown);
            this.ComboBoxStockDestinationList.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStockDestinationList_SelectedIndexChanged);
            this.ComboBoxStockDestinationList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxStockDestinationList_KeyPress);
            // 
            // ButtonShow_StockDestination_RegistrationForm
            // 
            this.ButtonShow_StockDestination_RegistrationForm.AutoSize = true;
            this.ButtonShow_StockDestination_RegistrationForm.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.ButtonShow_StockDestination_RegistrationForm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonShow_StockDestination_RegistrationForm.Location = new System.Drawing.Point(248, 159);
            this.ButtonShow_StockDestination_RegistrationForm.Name = "ButtonShow_StockDestination_RegistrationForm";
            this.ButtonShow_StockDestination_RegistrationForm.Size = new System.Drawing.Size(102, 18);
            this.ButtonShow_StockDestination_RegistrationForm.TabIndex = 146;
            this.ButtonShow_StockDestination_RegistrationForm.TabStop = true;
            this.ButtonShow_StockDestination_RegistrationForm.Text = "Cadastrar Novo";
            this.ButtonShow_StockDestination_RegistrationForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonShow_StockDestination_RegistrationForm_LinkClicked);
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
            // ButtonRegisterNew
            // 
            this.ButtonRegisterNew.ActiveBorderThickness = 1;
            this.ButtonRegisterNew.ActiveCornerRadius = 10;
            this.ButtonRegisterNew.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonRegisterNew.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonRegisterNew.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonRegisterNew.BackColor = System.Drawing.Color.White;
            this.ButtonRegisterNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRegisterNew.BackgroundImage")));
            this.ButtonRegisterNew.ButtonText = "Nova";
            this.ButtonRegisterNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegisterNew.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonRegisterNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonRegisterNew.IdleBorderThickness = 1;
            this.ButtonRegisterNew.IdleCornerRadius = 10;
            this.ButtonRegisterNew.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonRegisterNew.IdleForecolor = System.Drawing.Color.White;
            this.ButtonRegisterNew.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonRegisterNew.Location = new System.Drawing.Point(26, 9);
            this.ButtonRegisterNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonRegisterNew.Name = "ButtonRegisterNew";
            this.ButtonRegisterNew.Size = new System.Drawing.Size(97, 43);
            this.ButtonRegisterNew.TabIndex = 217;
            this.ButtonRegisterNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonRegisterNew.Click += new System.EventHandler(this.ButtonRegisterNew_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.ActiveBorderThickness = 1;
            this.ButtonDelete.ActiveCornerRadius = 10;
            this.ButtonDelete.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDelete.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonDelete.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDelete.BackColor = System.Drawing.Color.White;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.ButtonText = "Excluir";
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonDelete.IdleBorderThickness = 1;
            this.ButtonDelete.IdleCornerRadius = 10;
            this.ButtonDelete.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDelete.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDelete.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDelete.Location = new System.Drawing.Point(125, 9);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(97, 43);
            this.ButtonDelete.TabIndex = 218;
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.ActiveBorderThickness = 1;
            this.ButtonConfirm.ActiveCornerRadius = 10;
            this.ButtonConfirm.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonConfirm.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonConfirm.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonConfirm.BackColor = System.Drawing.Color.White;
            this.ButtonConfirm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonConfirm.BackgroundImage")));
            this.ButtonConfirm.ButtonText = "Confirmar";
            this.ButtonConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonConfirm.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonConfirm.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonConfirm.IdleBorderThickness = 1;
            this.ButtonConfirm.IdleCornerRadius = 10;
            this.ButtonConfirm.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonConfirm.IdleForecolor = System.Drawing.Color.White;
            this.ButtonConfirm.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonConfirm.Location = new System.Drawing.Point(224, 9);
            this.ButtonConfirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(97, 43);
            this.ButtonConfirm.TabIndex = 219;
            this.ButtonConfirm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.ActiveBorderThickness = 1;
            this.ButtonCloseForm.ActiveCornerRadius = 10;
            this.ButtonCloseForm.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonCloseForm.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonCloseForm.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCloseForm.BackColor = System.Drawing.Color.White;
            this.ButtonCloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCloseForm.BackgroundImage")));
            this.ButtonCloseForm.ButtonText = "Sair";
            this.ButtonCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseForm.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonCloseForm.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonCloseForm.IdleBorderThickness = 1;
            this.ButtonCloseForm.IdleCornerRadius = 10;
            this.ButtonCloseForm.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonCloseForm.IdleForecolor = System.Drawing.Color.White;
            this.ButtonCloseForm.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonCloseForm.Location = new System.Drawing.Point(799, 9);
            this.ButtonCloseForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(97, 43);
            this.ButtonCloseForm.TabIndex = 220;
            this.ButtonCloseForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // StockMovementRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.ButtonCloseForm);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonRegisterNew);
            this.Controls.Add(this.ButtonShow_StockDestination_RegistrationForm);
            this.Controls.Add(this.ComboBoxStockDestinationList);
            this.Controls.Add(this.GrupBoxGeneralInformation);
            this.Controls.Add(this.LblStockDestination);
            this.Controls.Add(this.CardMain);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "StockMovementRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Resize += new System.EventHandler(this.StockMovementResgistrationForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TextQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextTotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextUnitaryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByCode)).EndInit();
            this.CardMain.ResumeLayout(false);
            this.CardMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridMainDataList)).EndInit();
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
        private Syncfusion.WinForms.Controls.SfButton ButtonAddItem;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox TextQuantity;
        private System.Windows.Forms.Label LblTotalValue;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextTotalValue;
        private System.Windows.Forms.Label LblUnitaryValue;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextUnitaryValue;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label QueryTitleByDescription;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchByDescription;
        private System.Windows.Forms.Label QueryTitleByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchByCode;
        public System.Windows.Forms.Label TextStockMovementId;
        public System.Windows.Forms.Label TextOperationHour;
        public System.Windows.Forms.Label TextOperationDate;
        public System.Windows.Forms.Label TextOperationSituation;
        private Bunifu.Framework.UI.BunifuCards CardMain;
        private System.Windows.Forms.Label TotalItems;
        private System.Windows.Forms.Label TitleOfTotalItems;
        private System.Windows.Forms.PictureBox PictureLoading;
        public System.Windows.Forms.Label StockMovementIdTitle;
        private System.Windows.Forms.GroupBox GrupBoxGeneralInformation;
        public System.Windows.Forms.Label OperationTypeTitle;
        public System.Windows.Forms.Label TextOperationType;
        private System.Windows.Forms.LinkLabel ButtonClear_SearchFields;
        public Controls.CustomDataGridViewOne DataGridMainDataList;
        public System.Windows.Forms.Label LblStockDestination;
        private System.Windows.Forms.ComboBox ComboBoxStockDestinationList;
        private System.Windows.Forms.LinkLabel ButtonShow_StockDestination_RegistrationForm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip StockMovementMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MovementEntrie_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovementOutPut_ToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonRegisterNew;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDelete;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonConfirm;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonCloseForm;
    }
}