namespace DimStock.View
{
    partial class FrmStockMovementRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockMovementRegister));
            this.QueryTimer = new System.Windows.Forms.Timer(this.components);
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
            this.ClearQueryFields = new System.Windows.Forms.LinkLabel();
            this.ImageLoading = new System.Windows.Forms.PictureBox();
            this.TotalItems = new System.Windows.Forms.Label();
            this.TitleOfTotalItems = new System.Windows.Forms.Label();
            this.Delete = new Syncfusion.WinForms.Controls.SfButton();
            this.Confirm = new Syncfusion.WinForms.Controls.SfButton();
            this.GrupBoxGeneralInformation = new System.Windows.Forms.GroupBox();
            this.OperationTypeTitle = new System.Windows.Forms.Label();
            this.OperationType = new System.Windows.Forms.Label();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.PanelUpperHorinzontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.TodayIsDay = new System.Windows.Forms.Label();
            this.FormTitle = new System.Windows.Forms.Label();
            this.AddNew = new Syncfusion.WinForms.Controls.SfButton();
            this.StockDestinationList = new System.Windows.Forms.ComboBox();
            this.AddNewStockDestination = new System.Windows.Forms.LinkLabel();
            this.MainDataList = new DimStock.Auxiliary.AxlDataGridViewStockItem();
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitaryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryBySize)).BeginInit();
            this.CardMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLoading)).BeginInit();
            this.GrupBoxGeneralInformation.SuspendLayout();
            this.PanelUpperHorinzontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // QueryTimer
            // 
            this.QueryTimer.Interval = 1000;
            this.QueryTimer.Tick += new System.EventHandler(this.QueryTimer_Tick);
            // 
            // SubTotalTitle
            // 
            this.SubTotalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubTotalTitle.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SubTotalTitle.Location = new System.Drawing.Point(305, 325);
            this.SubTotalTitle.Name = "SubTotalTitle";
            this.SubTotalTitle.Size = new System.Drawing.Size(149, 32);
            this.SubTotalTitle.TabIndex = 115;
            this.SubTotalTitle.Text = "SUBTOTAL:";
            // 
            // SubTotal
            // 
            this.SubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SubTotal.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.SubTotal.Location = new System.Drawing.Point(460, 325);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(224, 32);
            this.SubTotal.TabIndex = 116;
            this.SubTotal.Text = "R$0.00";
            // 
            // AddItem
            // 
            this.AddItem.AccessibleName = "Button";
            this.AddItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddItem.BackColor = System.Drawing.Color.SeaGreen;
            this.AddItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.AddItem.ForeColor = System.Drawing.Color.White;
            this.AddItem.Location = new System.Drawing.Point(838, 28);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(44, 26);
            this.AddItem.Style.BackColor = System.Drawing.Color.SeaGreen;
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
            this.AddItem.Text = "Add";
            this.AddItem.UseVisualStyleBackColor = false;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // Quantity
            // 
            this.Quantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quantity.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.Quantity.BorderColor = System.Drawing.Color.Gray;
            this.Quantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Quantity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Quantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Quantity.IntegerValue = ((long)(0));
            this.Quantity.Location = new System.Drawing.Point(640, 28);
            this.Quantity.MaxValue = ((long)(50000));
            this.Quantity.Metrocolor = System.Drawing.Color.Green;
            this.Quantity.MinimumSize = new System.Drawing.Size(14, 10);
            this.Quantity.MinValue = ((long)(0));
            this.Quantity.Name = "Quantity";
            this.Quantity.NegativeSign = "";
            this.Quantity.NumberGroupSeparator = "";
            this.Quantity.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Quantity.Size = new System.Drawing.Size(65, 26);
            this.Quantity.TabIndex = 5;
            this.Quantity.Text = "0";
            this.Quantity.ThemeName = "Default";
            this.Quantity.WordWrap = false;
            this.Quantity.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Quantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Quantity_KeyPress);
            // 
            // LblTotalValue
            // 
            this.LblTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTotalValue.AutoSize = true;
            this.LblTotalValue.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalValue.Location = new System.Drawing.Point(708, 11);
            this.LblTotalValue.Name = "LblTotalValue";
            this.LblTotalValue.Size = new System.Drawing.Size(37, 15);
            this.LblTotalValue.TabIndex = 135;
            this.LblTotalValue.Text = "Total:";
            // 
            // TotalValue
            // 
            this.TotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalValue.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.TotalValue.BorderColor = System.Drawing.Color.Gray;
            this.TotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TotalValue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TotalValue.Enabled = false;
            this.TotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TotalValue.Location = new System.Drawing.Point(711, 28);
            this.TotalValue.Metrocolor = System.Drawing.Color.Green;
            this.TotalValue.MinimumSize = new System.Drawing.Size(14, 10);
            this.TotalValue.Name = "TotalValue";
            this.TotalValue.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TotalValue.Size = new System.Drawing.Size(121, 26);
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
            this.LblUnitaryValue.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUnitaryValue.Location = new System.Drawing.Point(507, 11);
            this.LblUnitaryValue.Name = "LblUnitaryValue";
            this.LblUnitaryValue.Size = new System.Drawing.Size(60, 15);
            this.LblUnitaryValue.TabIndex = 133;
            this.LblUnitaryValue.Text = "Valor Uni.";
            // 
            // UnitaryValue
            // 
            this.UnitaryValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UnitaryValue.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.UnitaryValue.BorderColor = System.Drawing.Color.Gray;
            this.UnitaryValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UnitaryValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UnitaryValue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.UnitaryValue.Enabled = false;
            this.UnitaryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnitaryValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.UnitaryValue.Location = new System.Drawing.Point(510, 28);
            this.UnitaryValue.Metrocolor = System.Drawing.Color.Green;
            this.UnitaryValue.MinimumSize = new System.Drawing.Size(14, 10);
            this.UnitaryValue.Name = "UnitaryValue";
            this.UnitaryValue.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.UnitaryValue.Size = new System.Drawing.Size(124, 26);
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
            this.LblQuantity.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(639, 11);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(45, 15);
            this.LblQuantity.TabIndex = 131;
            this.LblQuantity.Text = "Quant:";
            // 
            // QueryTitleByDescription
            // 
            this.QueryTitleByDescription.AutoSize = true;
            this.QueryTitleByDescription.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTitleByDescription.Location = new System.Drawing.Point(324, 11);
            this.QueryTitleByDescription.Name = "QueryTitleByDescription";
            this.QueryTitleByDescription.Size = new System.Drawing.Size(109, 15);
            this.QueryTitleByDescription.TabIndex = 130;
            this.QueryTitleByDescription.Text = "Descrição Produto:";
            // 
            // QueryTitleByReference
            // 
            this.QueryTitleByReference.AutoSize = true;
            this.QueryTitleByReference.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTitleByReference.Location = new System.Drawing.Point(242, 11);
            this.QueryTitleByReference.Name = "QueryTitleByReference";
            this.QueryTitleByReference.Size = new System.Drawing.Size(66, 15);
            this.QueryTitleByReference.TabIndex = 129;
            this.QueryTitleByReference.Text = "Referência:";
            // 
            // QueryTitleBySize
            // 
            this.QueryTitleBySize.AutoSize = true;
            this.QueryTitleBySize.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTitleBySize.Location = new System.Drawing.Point(157, 11);
            this.QueryTitleBySize.Name = "QueryTitleBySize";
            this.QueryTitleBySize.Size = new System.Drawing.Size(60, 15);
            this.QueryTitleBySize.TabIndex = 128;
            this.QueryTitleBySize.Text = "Tamanho:";
            // 
            // QueryByDescription
            // 
            this.QueryByDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.QueryByDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.QueryByDescription.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.QueryByDescription.BorderColor = System.Drawing.Color.Gray;
            this.QueryByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryByDescription.CanOverrideStyle = true;
            this.QueryByDescription.CausesValidation = false;
            this.QueryByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QueryByDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.QueryByDescription.Location = new System.Drawing.Point(327, 28);
            this.QueryByDescription.MaxLength = 50;
            this.QueryByDescription.Metrocolor = System.Drawing.Color.Green;
            this.QueryByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.QueryByDescription.Multiline = true;
            this.QueryByDescription.Name = "QueryByDescription";
            this.QueryByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.QueryByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.QueryByDescription.Size = new System.Drawing.Size(177, 26);
            this.QueryByDescription.TabIndex = 3;
            this.QueryByDescription.Tag = "";
            this.QueryByDescription.ThemeName = "Default";
            this.QueryByDescription.WordWrap = false;
            this.QueryByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShearchFields_KeyPress);
            // 
            // QueryTitleByCode
            // 
            this.QueryTitleByCode.AutoSize = true;
            this.QueryTitleByCode.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryTitleByCode.Location = new System.Drawing.Point(66, 11);
            this.QueryTitleByCode.Name = "QueryTitleByCode";
            this.QueryTitleByCode.Size = new System.Drawing.Size(49, 15);
            this.QueryTitleByCode.TabIndex = 127;
            this.QueryTitleByCode.Text = "Código:";
            // 
            // QueryByCode
            // 
            this.QueryByCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.QueryByCode.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.QueryByCode.BorderColor = System.Drawing.Color.Gray;
            this.QueryByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryByCode.CanOverrideStyle = true;
            this.QueryByCode.CausesValidation = false;
            this.QueryByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QueryByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.QueryByCode.Location = new System.Drawing.Point(69, 28);
            this.QueryByCode.MaxLength = 50;
            this.QueryByCode.Metrocolor = System.Drawing.Color.Green;
            this.QueryByCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.QueryByCode.Multiline = true;
            this.QueryByCode.Name = "QueryByCode";
            this.QueryByCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.QueryByCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.QueryByCode.Size = new System.Drawing.Size(85, 26);
            this.QueryByCode.TabIndex = 0;
            this.QueryByCode.Tag = "";
            this.QueryByCode.ThemeName = "Default";
            this.QueryByCode.WordWrap = false;
            this.QueryByCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShearchFields_KeyPress);
            // 
            // QueryByReference
            // 
            this.QueryByReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.QueryByReference.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.QueryByReference.BorderColor = System.Drawing.Color.Gray;
            this.QueryByReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryByReference.CanOverrideStyle = true;
            this.QueryByReference.CausesValidation = false;
            this.QueryByReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QueryByReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryByReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.QueryByReference.Location = new System.Drawing.Point(245, 28);
            this.QueryByReference.MaxLength = 50;
            this.QueryByReference.Metrocolor = System.Drawing.Color.Green;
            this.QueryByReference.MinimumSize = new System.Drawing.Size(16, 12);
            this.QueryByReference.Multiline = true;
            this.QueryByReference.Name = "QueryByReference";
            this.QueryByReference.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.QueryByReference.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.QueryByReference.Size = new System.Drawing.Size(78, 26);
            this.QueryByReference.TabIndex = 2;
            this.QueryByReference.Tag = "";
            this.QueryByReference.ThemeName = "Default";
            this.QueryByReference.WordWrap = false;
            this.QueryByReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShearchFields_KeyPress);
            // 
            // QueryBySize
            // 
            this.QueryBySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.QueryBySize.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.QueryBySize.BorderColor = System.Drawing.Color.Gray;
            this.QueryBySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryBySize.CanOverrideStyle = true;
            this.QueryBySize.CausesValidation = false;
            this.QueryBySize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QueryBySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryBySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.QueryBySize.Location = new System.Drawing.Point(160, 28);
            this.QueryBySize.MaxLength = 50;
            this.QueryBySize.Metrocolor = System.Drawing.Color.Green;
            this.QueryBySize.MinimumSize = new System.Drawing.Size(16, 12);
            this.QueryBySize.Multiline = true;
            this.QueryBySize.Name = "QueryBySize";
            this.QueryBySize.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.QueryBySize.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.QueryBySize.Size = new System.Drawing.Size(79, 26);
            this.QueryBySize.TabIndex = 1;
            this.QueryBySize.Tag = "";
            this.QueryBySize.ThemeName = "Default";
            this.QueryBySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ShearchFields_KeyPress);
            // 
            // StockMovementIdTitle
            // 
            this.StockMovementIdTitle.AutoSize = true;
            this.StockMovementIdTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.StockMovementIdTitle.ForeColor = System.Drawing.Color.Black;
            this.StockMovementIdTitle.Location = new System.Drawing.Point(30, 26);
            this.StockMovementIdTitle.Name = "StockMovementIdTitle";
            this.StockMovementIdTitle.Size = new System.Drawing.Size(142, 19);
            this.StockMovementIdTitle.TabIndex = 118;
            this.StockMovementIdTitle.Text = "Movimentação Nº:";
            // 
            // StockMovementId
            // 
            this.StockMovementId.AutoSize = true;
            this.StockMovementId.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.StockMovementId.ForeColor = System.Drawing.Color.Gray;
            this.StockMovementId.Location = new System.Drawing.Point(169, 26);
            this.StockMovementId.Name = "StockMovementId";
            this.StockMovementId.Size = new System.Drawing.Size(19, 19);
            this.StockMovementId.TabIndex = 119;
            this.StockMovementId.Text = "--";
            this.StockMovementId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // OperationHour
            // 
            this.OperationHour.AutoSize = true;
            this.OperationHour.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.OperationHour.ForeColor = System.Drawing.Color.Gray;
            this.OperationHour.Location = new System.Drawing.Point(398, 57);
            this.OperationHour.Name = "OperationHour";
            this.OperationHour.Size = new System.Drawing.Size(19, 19);
            this.OperationHour.TabIndex = 125;
            this.OperationHour.Text = "--";
            // 
            // OperationHourTitle
            // 
            this.OperationHourTitle.AutoSize = true;
            this.OperationHourTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.OperationHourTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationHourTitle.Location = new System.Drawing.Point(322, 57);
            this.OperationHourTitle.Name = "OperationHourTitle";
            this.OperationHourTitle.Size = new System.Drawing.Size(70, 19);
            this.OperationHourTitle.TabIndex = 124;
            this.OperationHourTitle.Text = "Horário:";
            // 
            // OperationDate
            // 
            this.OperationDate.AutoSize = true;
            this.OperationDate.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.OperationDate.ForeColor = System.Drawing.Color.Gray;
            this.OperationDate.Location = new System.Drawing.Point(368, 27);
            this.OperationDate.Name = "OperationDate";
            this.OperationDate.Size = new System.Drawing.Size(19, 19);
            this.OperationDate.TabIndex = 123;
            this.OperationDate.Text = "--";
            // 
            // OperationDataTitle
            // 
            this.OperationDataTitle.AutoSize = true;
            this.OperationDataTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.OperationDataTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationDataTitle.Location = new System.Drawing.Point(322, 26);
            this.OperationDataTitle.Name = "OperationDataTitle";
            this.OperationDataTitle.Size = new System.Drawing.Size(48, 19);
            this.OperationDataTitle.TabIndex = 122;
            this.OperationDataTitle.Text = "Data:";
            // 
            // OperationSituation
            // 
            this.OperationSituation.AutoSize = true;
            this.OperationSituation.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.OperationSituation.ForeColor = System.Drawing.Color.Gray;
            this.OperationSituation.Location = new System.Drawing.Point(638, 26);
            this.OperationSituation.Name = "OperationSituation";
            this.OperationSituation.Size = new System.Drawing.Size(19, 19);
            this.OperationSituation.TabIndex = 127;
            this.OperationSituation.Text = "--";
            // 
            // OperationSituationTitle
            // 
            this.OperationSituationTitle.AutoSize = true;
            this.OperationSituationTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.OperationSituationTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationSituationTitle.Location = new System.Drawing.Point(566, 26);
            this.OperationSituationTitle.Name = "OperationSituationTitle";
            this.OperationSituationTitle.Size = new System.Drawing.Size(74, 19);
            this.OperationSituationTitle.TabIndex = 126;
            this.OperationSituationTitle.Text = "Situação:";
            // 
            // CardMain
            // 
            this.CardMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CardMain.BackColor = System.Drawing.Color.AliceBlue;
            this.CardMain.BorderRadius = 5;
            this.CardMain.BottomSahddow = true;
            this.CardMain.color = System.Drawing.Color.SlateGray;
            this.CardMain.Controls.Add(this.ClearQueryFields);
            this.CardMain.Controls.Add(this.ImageLoading);
            this.CardMain.Controls.Add(this.TotalItems);
            this.CardMain.Controls.Add(this.TitleOfTotalItems);
            this.CardMain.Controls.Add(this.AddItem);
            this.CardMain.Controls.Add(this.Quantity);
            this.CardMain.Controls.Add(this.SubTotal);
            this.CardMain.Controls.Add(this.SubTotalTitle);
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
            this.CardMain.Size = new System.Drawing.Size(902, 375);
            this.CardMain.TabIndex = 136;
            // 
            // ClearQueryFields
            // 
            this.ClearQueryFields.AutoSize = true;
            this.ClearQueryFields.Location = new System.Drawing.Point(25, 34);
            this.ClearQueryFields.Name = "ClearQueryFields";
            this.ClearQueryFields.Size = new System.Drawing.Size(38, 13);
            this.ClearQueryFields.TabIndex = 141;
            this.ClearQueryFields.TabStop = true;
            this.ClearQueryFields.Text = "Limpar";
            this.ClearQueryFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearQueryFields_LinkClicked);
            // 
            // ImageLoading
            // 
            this.ImageLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageLoading.Image = global::DimStock.Properties.Resources.Load;
            this.ImageLoading.Location = new System.Drawing.Point(379, 121);
            this.ImageLoading.Name = "ImageLoading";
            this.ImageLoading.Size = new System.Drawing.Size(129, 137);
            this.ImageLoading.TabIndex = 139;
            this.ImageLoading.TabStop = false;
            this.ImageLoading.Visible = false;
            // 
            // TotalItems
            // 
            this.TotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalItems.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItems.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.TotalItems.Location = new System.Drawing.Point(109, 325);
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.Size = new System.Drawing.Size(98, 32);
            this.TotalItems.TabIndex = 138;
            this.TotalItems.Text = "0";
            // 
            // TitleOfTotalItems
            // 
            this.TitleOfTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TitleOfTotalItems.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleOfTotalItems.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TitleOfTotalItems.Location = new System.Drawing.Point(22, 325);
            this.TitleOfTotalItems.Name = "TitleOfTotalItems";
            this.TitleOfTotalItems.Size = new System.Drawing.Size(94, 32);
            this.TitleOfTotalItems.TabIndex = 137;
            this.TitleOfTotalItems.Text = "ITENS:";
            // 
            // Delete
            // 
            this.Delete.AccessibleName = "Button";
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete.BackColor = System.Drawing.Color.SeaGreen;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(100, 47);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(80, 35);
            this.Delete.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.Delete.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.Delete.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.Delete.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.Delete.Style.FocusedForeColor = System.Drawing.Color.White;
            this.Delete.Style.ForeColor = System.Drawing.Color.White;
            this.Delete.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Delete.Style.HoverForeColor = System.Drawing.Color.Black;
            this.Delete.Style.PressedBackColor = System.Drawing.Color.White;
            this.Delete.Style.PressedForeColor = System.Drawing.Color.White;
            this.Delete.TabIndex = 142;
            this.Delete.Text = "Excluir";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Confirm
            // 
            this.Confirm.AccessibleName = "Button";
            this.Confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Confirm.BackColor = System.Drawing.Color.SeaGreen;
            this.Confirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confirm.ForeColor = System.Drawing.Color.White;
            this.Confirm.Location = new System.Drawing.Point(183, 47);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(80, 35);
            this.Confirm.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.Confirm.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.Confirm.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.Confirm.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.Confirm.Style.FocusedForeColor = System.Drawing.Color.White;
            this.Confirm.Style.ForeColor = System.Drawing.Color.White;
            this.Confirm.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Confirm.Style.HoverForeColor = System.Drawing.Color.Black;
            this.Confirm.Style.PressedBackColor = System.Drawing.Color.White;
            this.Confirm.Style.PressedForeColor = System.Drawing.Color.White;
            this.Confirm.TabIndex = 140;
            this.Confirm.Text = "Confirmar";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
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
            this.GrupBoxGeneralInformation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrupBoxGeneralInformation.Location = new System.Drawing.Point(31, 108);
            this.GrupBoxGeneralInformation.Name = "GrupBoxGeneralInformation";
            this.GrupBoxGeneralInformation.Size = new System.Drawing.Size(902, 96);
            this.GrupBoxGeneralInformation.TabIndex = 140;
            this.GrupBoxGeneralInformation.TabStop = false;
            this.GrupBoxGeneralInformation.Text = "INFORMAÇÕES GERAIS";
            // 
            // OperationTypeTitle
            // 
            this.OperationTypeTitle.AutoSize = true;
            this.OperationTypeTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.OperationTypeTitle.ForeColor = System.Drawing.Color.Black;
            this.OperationTypeTitle.Location = new System.Drawing.Point(31, 61);
            this.OperationTypeTitle.Name = "OperationTypeTitle";
            this.OperationTypeTitle.Size = new System.Drawing.Size(48, 19);
            this.OperationTypeTitle.TabIndex = 128;
            this.OperationTypeTitle.Text = "Tipo:";
            // 
            // OperationType
            // 
            this.OperationType.AutoSize = true;
            this.OperationType.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.OperationType.ForeColor = System.Drawing.Color.Gray;
            this.OperationType.Location = new System.Drawing.Point(85, 61);
            this.OperationType.Name = "OperationType";
            this.OperationType.Size = new System.Drawing.Size(19, 19);
            this.OperationType.TabIndex = 129;
            this.OperationType.Text = "--";
            this.OperationType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LblStockDestination
            // 
            this.LblStockDestination.AutoSize = true;
            this.LblStockDestination.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblStockDestination.ForeColor = System.Drawing.Color.Black;
            this.LblStockDestination.Location = new System.Drawing.Point(26, 219);
            this.LblStockDestination.Name = "LblStockDestination";
            this.LblStockDestination.Size = new System.Drawing.Size(68, 19);
            this.LblStockDestination.TabIndex = 142;
            this.LblStockDestination.Text = "Destino:";
            // 
            // PanelUpperHorinzontal
            // 
            this.PanelUpperHorinzontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorinzontal.BackgroundImage")));
            this.PanelUpperHorinzontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorinzontal.Controls.Add(this.TodayIsDay);
            this.PanelUpperHorinzontal.Controls.Add(this.FormTitle);
            this.PanelUpperHorinzontal.Controls.Add(this.AddNew);
            this.PanelUpperHorinzontal.Controls.Add(this.Confirm);
            this.PanelUpperHorinzontal.Controls.Add(this.Delete);
            this.PanelUpperHorinzontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpperHorinzontal.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorinzontal.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorinzontal.GradientTopLeft = System.Drawing.Color.Black;
            this.PanelUpperHorinzontal.GradientTopRight = System.Drawing.Color.Black;
            this.PanelUpperHorinzontal.Location = new System.Drawing.Point(0, 0);
            this.PanelUpperHorinzontal.Name = "PanelUpperHorinzontal";
            this.PanelUpperHorinzontal.Quality = 10;
            this.PanelUpperHorinzontal.Size = new System.Drawing.Size(964, 97);
            this.PanelUpperHorinzontal.TabIndex = 139;
            // 
            // TodayIsDay
            // 
            this.TodayIsDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayIsDay.BackColor = System.Drawing.Color.Transparent;
            this.TodayIsDay.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayIsDay.ForeColor = System.Drawing.Color.White;
            this.TodayIsDay.Location = new System.Drawing.Point(467, 23);
            this.TodayIsDay.Name = "TodayIsDay";
            this.TodayIsDay.Size = new System.Drawing.Size(494, 40);
            this.TodayIsDay.TabIndex = 139;
            this.TodayIsDay.Text = "Entrada de Estoque";
            this.TodayIsDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.BackColor = System.Drawing.Color.Transparent;
            this.FormTitle.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Location = new System.Drawing.Point(12, 4);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(399, 40);
            this.FormTitle.TabIndex = 138;
            this.FormTitle.Text = "Movimentação de estoque";
            // 
            // AddNew
            // 
            this.AddNew.AccessibleName = "Button";
            this.AddNew.BackColor = System.Drawing.Color.SeaGreen;
            this.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddNew.ForeColor = System.Drawing.Color.White;
            this.AddNew.Location = new System.Drawing.Point(17, 47);
            this.AddNew.Name = "AddNew";
            this.AddNew.Size = new System.Drawing.Size(80, 35);
            this.AddNew.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.AddNew.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.AddNew.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.AddNew.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.AddNew.Style.FocusedForeColor = System.Drawing.Color.White;
            this.AddNew.Style.ForeColor = System.Drawing.Color.White;
            this.AddNew.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.AddNew.Style.HoverForeColor = System.Drawing.Color.Black;
            this.AddNew.Style.PressedBackColor = System.Drawing.Color.White;
            this.AddNew.Style.PressedForeColor = System.Drawing.Color.White;
            this.AddNew.TabIndex = 137;
            this.AddNew.Text = "Nova";
            this.AddNew.UseVisualStyleBackColor = false;
            this.AddNew.Click += new System.EventHandler(this.AddNew_Click);
            // 
            // StockDestinationList
            // 
            this.StockDestinationList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StockDestinationList.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.StockDestinationList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockDestinationList.FormattingEnabled = true;
            this.StockDestinationList.Location = new System.Drawing.Point(31, 239);
            this.StockDestinationList.Name = "StockDestinationList";
            this.StockDestinationList.Size = new System.Drawing.Size(370, 28);
            this.StockDestinationList.TabIndex = 145;
            this.StockDestinationList.DropDown += new System.EventHandler(this.StockDestinationList_DropDown);
            this.StockDestinationList.SelectedIndexChanged += new System.EventHandler(this.StockDestinationList_SelectedIndexChanged);
            // 
            // AddNewStockDestination
            // 
            this.AddNewStockDestination.AutoSize = true;
            this.AddNewStockDestination.Location = new System.Drawing.Point(320, 223);
            this.AddNewStockDestination.Name = "AddNewStockDestination";
            this.AddNewStockDestination.Size = new System.Drawing.Size(81, 13);
            this.AddNewStockDestination.TabIndex = 146;
            this.AddNewStockDestination.TabStop = true;
            this.AddNewStockDestination.Text = "Cadastrar Novo";
            this.AddNewStockDestination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewStockDestination_LinkClicked);
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
            this.MainDataList.Size = new System.Drawing.Size(861, 251);
            this.MainDataList.TabIndex = 141;
            this.MainDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MainDataList_CellClick);
            this.MainDataList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.MainDataList_RowPrePaint);
            this.MainDataList.DoubleClick += new System.EventHandler(this.MainDataList_DoubleClick);
            // 
            // FrmStockMovementRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.AddNewStockDestination);
            this.Controls.Add(this.StockDestinationList);
            this.Controls.Add(this.GrupBoxGeneralInformation);
            this.Controls.Add(this.LblStockDestination);
            this.Controls.Add(this.PanelUpperHorinzontal);
            this.Controls.Add(this.CardMain);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmStockMovementRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmStockMovementRegister_Load);
            this.Resize += new System.EventHandler(this.FrmStockMovementRegister_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.Quantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnitaryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryBySize)).EndInit();
            this.CardMain.ResumeLayout(false);
            this.CardMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLoading)).EndInit();
            this.GrupBoxGeneralInformation.ResumeLayout(false);
            this.GrupBoxGeneralInformation.PerformLayout();
            this.PanelUpperHorinzontal.ResumeLayout(false);
            this.PanelUpperHorinzontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer QueryTimer;
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
        private System.Windows.Forms.PictureBox ImageLoading;
        private Syncfusion.WinForms.Controls.SfButton Confirm;
        private Syncfusion.WinForms.Controls.SfButton AddNew;
        public System.Windows.Forms.Label StockMovementIdTitle;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorinzontal;
        public System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.GroupBox GrupBoxGeneralInformation;
        public System.Windows.Forms.Label OperationTypeTitle;
        public System.Windows.Forms.Label OperationType;
        public System.Windows.Forms.Label TodayIsDay;
        private System.Windows.Forms.LinkLabel ClearQueryFields;
        private Syncfusion.WinForms.Controls.SfButton Delete;
        public Auxiliary.AxlDataGridViewStockItem MainDataList;
        public System.Windows.Forms.Label LblStockDestination;
        private System.Windows.Forms.ComboBox StockDestinationList;
        private System.Windows.Forms.LinkLabel AddNewStockDestination;
    }
}