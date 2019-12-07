namespace DimStock.View
{
    partial class FrmStockActivityRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockActivityRegister));
            this.TimerExecuteQuery = new System.Windows.Forms.Timer(this.components);
            this.LblSubTotalTitle = new System.Windows.Forms.Label();
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.BtnAddNewItem = new Syncfusion.WinForms.Controls.SfButton();
            this.TxtQuantity = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.LblTotalValue = new System.Windows.Forms.Label();
            this.TxtTotalValue = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.LblUnitaryValue = new System.Windows.Forms.Label();
            this.TxtUnitaryValue = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.LblQueryByDescription = new System.Windows.Forms.Label();
            this.LblQueryByReference = new System.Windows.Forms.Label();
            this.LblQueryBySize = new System.Windows.Forms.Label();
            this.TxtQueryByDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblQueryByCode = new System.Windows.Forms.Label();
            this.TxtQueryByCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtQueryByReference = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtQueryBySize = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblActivityNumberTitle = new System.Windows.Forms.Label();
            this.LblActivityNumber = new System.Windows.Forms.Label();
            this.LblActivityHour = new System.Windows.Forms.Label();
            this.LblActivityHourTitle = new System.Windows.Forms.Label();
            this.LblActivityDate = new System.Windows.Forms.Label();
            this.LblActivityDateTitle = new System.Windows.Forms.Label();
            this.LblActivitySituation = new System.Windows.Forms.Label();
            this.LblActivitySituationTitle = new System.Windows.Forms.Label();
            this.CardMain = new Bunifu.Framework.UI.BunifuCards();
            this.LbkClear = new System.Windows.Forms.LinkLabel();
            this.PicLoading = new System.Windows.Forms.PictureBox();
            this.LblTotalItems = new System.Windows.Forms.Label();
            this.LblTotalItemsTitle = new System.Windows.Forms.Label();
            this.GridMain = new DimStock.Auxiliary.AxlDataGridViewStockItem();
            this.BtnDelete = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnConfirm = new Syncfusion.WinForms.Controls.SfButton();
            this.GbxGeneralInformation = new System.Windows.Forms.GroupBox();
            this.LblActivityTypeTitle = new System.Windows.Forms.Label();
            this.LblActivityType = new System.Windows.Forms.Label();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.PnlUpperHorinzontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LblTodayIsDay = new System.Windows.Forms.Label();
            this.LblFormTitle = new System.Windows.Forms.Label();
            this.BtnNew = new Syncfusion.WinForms.Controls.SfButton();
            this.CboStockDestination = new System.Windows.Forms.ComboBox();
            this.LklRegisterNewStockDestination = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUnitaryValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryBySize)).BeginInit();
            this.CardMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).BeginInit();
            this.GbxGeneralInformation.SuspendLayout();
            this.PnlUpperHorinzontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerExecuteQuery
            // 
            this.TimerExecuteQuery.Interval = 1000;
            this.TimerExecuteQuery.Tick += new System.EventHandler(this.TimerExecuteQuery_Tick);
            // 
            // LblSubTotalTitle
            // 
            this.LblSubTotalTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblSubTotalTitle.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblSubTotalTitle.Location = new System.Drawing.Point(305, 325);
            this.LblSubTotalTitle.Name = "LblSubTotalTitle";
            this.LblSubTotalTitle.Size = new System.Drawing.Size(149, 32);
            this.LblSubTotalTitle.TabIndex = 115;
            this.LblSubTotalTitle.Text = "SUBTOTAL:";
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblSubTotal.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LblSubTotal.Location = new System.Drawing.Point(460, 325);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(224, 32);
            this.LblSubTotal.TabIndex = 116;
            this.LblSubTotal.Text = "R$0.00";
            // 
            // BtnAddNewItem
            // 
            this.BtnAddNewItem.AccessibleName = "Button";
            this.BtnAddNewItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAddNewItem.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddNewItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddNewItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.BtnAddNewItem.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewItem.Location = new System.Drawing.Point(838, 28);
            this.BtnAddNewItem.Name = "BtnAddNewItem";
            this.BtnAddNewItem.Size = new System.Drawing.Size(44, 26);
            this.BtnAddNewItem.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddNewItem.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnAddNewItem.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAddNewItem.Style.FocusedBackColor = System.Drawing.Color.Crimson;
            this.BtnAddNewItem.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnAddNewItem.Style.ForeColor = System.Drawing.Color.White;
            this.BtnAddNewItem.Style.HoverBackColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAddNewItem.Style.HoverForeColor = System.Drawing.Color.White;
            this.BtnAddNewItem.Style.PressedBackColor = System.Drawing.Color.Crimson;
            this.BtnAddNewItem.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnAddNewItem.TabIndex = 7;
            this.BtnAddNewItem.Text = "Add";
            this.BtnAddNewItem.UseVisualStyleBackColor = false;
            this.BtnAddNewItem.Click += new System.EventHandler(this.BtnAddNewItem_Click);
            // 
            // TxtQuantity
            // 
            this.TxtQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuantity.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.TxtQuantity.BorderColor = System.Drawing.Color.Gray;
            this.TxtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQuantity.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQuantity.IntegerValue = ((long)(0));
            this.TxtQuantity.Location = new System.Drawing.Point(640, 28);
            this.TxtQuantity.Metrocolor = System.Drawing.Color.Green;
            this.TxtQuantity.MinimumSize = new System.Drawing.Size(14, 10);
            this.TxtQuantity.Name = "TxtQuantity";
            this.TxtQuantity.NegativeSign = "";
            this.TxtQuantity.NumberGroupSeparator = "";
            this.TxtQuantity.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQuantity.Size = new System.Drawing.Size(65, 26);
            this.TxtQuantity.TabIndex = 5;
            this.TxtQuantity.ThemeName = "Default";
            this.TxtQuantity.WordWrap = false;
            this.TxtQuantity.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantity_KeyPress);
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
            // TxtTotalValue
            // 
            this.TxtTotalValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotalValue.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.TxtTotalValue.BorderColor = System.Drawing.Color.Gray;
            this.TxtTotalValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTotalValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtTotalValue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TxtTotalValue.Enabled = false;
            this.TxtTotalValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TxtTotalValue.Location = new System.Drawing.Point(711, 28);
            this.TxtTotalValue.Metrocolor = System.Drawing.Color.Green;
            this.TxtTotalValue.MinimumSize = new System.Drawing.Size(14, 10);
            this.TxtTotalValue.Name = "TxtTotalValue";
            this.TxtTotalValue.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TxtTotalValue.Size = new System.Drawing.Size(121, 26);
            this.TxtTotalValue.TabIndex = 6;
            this.TxtTotalValue.Text = "R$ 0,00";
            this.TxtTotalValue.ThemeName = "Default";
            this.TxtTotalValue.WordWrap = false;
            this.TxtTotalValue.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
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
            // TxtUnitaryValue
            // 
            this.TxtUnitaryValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtUnitaryValue.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.TxtUnitaryValue.BorderColor = System.Drawing.Color.Gray;
            this.TxtUnitaryValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUnitaryValue.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtUnitaryValue.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TxtUnitaryValue.Enabled = false;
            this.TxtUnitaryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUnitaryValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtUnitaryValue.Location = new System.Drawing.Point(510, 28);
            this.TxtUnitaryValue.Metrocolor = System.Drawing.Color.Green;
            this.TxtUnitaryValue.MinimumSize = new System.Drawing.Size(14, 10);
            this.TxtUnitaryValue.Name = "TxtUnitaryValue";
            this.TxtUnitaryValue.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtUnitaryValue.Size = new System.Drawing.Size(124, 26);
            this.TxtUnitaryValue.TabIndex = 4;
            this.TxtUnitaryValue.Text = "R$ 0,00";
            this.TxtUnitaryValue.ThemeName = "Default";
            this.TxtUnitaryValue.WordWrap = false;
            this.TxtUnitaryValue.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtUnitaryValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorUnitario_KeyPress);
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
            // LblQueryByDescription
            // 
            this.LblQueryByDescription.AutoSize = true;
            this.LblQueryByDescription.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQueryByDescription.Location = new System.Drawing.Point(324, 11);
            this.LblQueryByDescription.Name = "LblQueryByDescription";
            this.LblQueryByDescription.Size = new System.Drawing.Size(109, 15);
            this.LblQueryByDescription.TabIndex = 130;
            this.LblQueryByDescription.Text = "Descrição Produto:";
            // 
            // LblQueryByReference
            // 
            this.LblQueryByReference.AutoSize = true;
            this.LblQueryByReference.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQueryByReference.Location = new System.Drawing.Point(242, 11);
            this.LblQueryByReference.Name = "LblQueryByReference";
            this.LblQueryByReference.Size = new System.Drawing.Size(66, 15);
            this.LblQueryByReference.TabIndex = 129;
            this.LblQueryByReference.Text = "Referência:";
            // 
            // LblQueryBySize
            // 
            this.LblQueryBySize.AutoSize = true;
            this.LblQueryBySize.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQueryBySize.Location = new System.Drawing.Point(157, 11);
            this.LblQueryBySize.Name = "LblQueryBySize";
            this.LblQueryBySize.Size = new System.Drawing.Size(60, 15);
            this.LblQueryBySize.TabIndex = 128;
            this.LblQueryBySize.Text = "Tamanho:";
            // 
            // TxtQueryByDescription
            // 
            this.TxtQueryByDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQueryByDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.TxtQueryByDescription.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.TxtQueryByDescription.BorderColor = System.Drawing.Color.Gray;
            this.TxtQueryByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByDescription.CanOverrideStyle = true;
            this.TxtQueryByDescription.CausesValidation = false;
            this.TxtQueryByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByDescription.Location = new System.Drawing.Point(327, 28);
            this.TxtQueryByDescription.MaxLength = 50;
            this.TxtQueryByDescription.Metrocolor = System.Drawing.Color.Green;
            this.TxtQueryByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByDescription.Multiline = true;
            this.TxtQueryByDescription.Name = "TxtQueryByDescription";
            this.TxtQueryByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByDescription.Size = new System.Drawing.Size(177, 26);
            this.TxtQueryByDescription.TabIndex = 3;
            this.TxtQueryByDescription.Tag = "";
            this.TxtQueryByDescription.ThemeName = "Default";
            this.TxtQueryByDescription.WordWrap = false;
            this.TxtQueryByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTheQuery_ForTheSearchBox_KeyPress);
            // 
            // LblQueryByCode
            // 
            this.LblQueryByCode.AutoSize = true;
            this.LblQueryByCode.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQueryByCode.Location = new System.Drawing.Point(66, 11);
            this.LblQueryByCode.Name = "LblQueryByCode";
            this.LblQueryByCode.Size = new System.Drawing.Size(49, 15);
            this.LblQueryByCode.TabIndex = 127;
            this.LblQueryByCode.Text = "Código:";
            // 
            // TxtQueryByCode
            // 
            this.TxtQueryByCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.TxtQueryByCode.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.TxtQueryByCode.BorderColor = System.Drawing.Color.Gray;
            this.TxtQueryByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByCode.CanOverrideStyle = true;
            this.TxtQueryByCode.CausesValidation = false;
            this.TxtQueryByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByCode.Location = new System.Drawing.Point(69, 28);
            this.TxtQueryByCode.MaxLength = 50;
            this.TxtQueryByCode.Metrocolor = System.Drawing.Color.Green;
            this.TxtQueryByCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByCode.Multiline = true;
            this.TxtQueryByCode.Name = "TxtQueryByCode";
            this.TxtQueryByCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByCode.Size = new System.Drawing.Size(85, 26);
            this.TxtQueryByCode.TabIndex = 0;
            this.TxtQueryByCode.Tag = "";
            this.TxtQueryByCode.ThemeName = "Default";
            this.TxtQueryByCode.WordWrap = false;
            this.TxtQueryByCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTheQuery_ForTheSearchBox_KeyPress);
            // 
            // TxtQueryByReference
            // 
            this.TxtQueryByReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.TxtQueryByReference.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.TxtQueryByReference.BorderColor = System.Drawing.Color.Gray;
            this.TxtQueryByReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByReference.CanOverrideStyle = true;
            this.TxtQueryByReference.CausesValidation = false;
            this.TxtQueryByReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByReference.Location = new System.Drawing.Point(245, 28);
            this.TxtQueryByReference.MaxLength = 50;
            this.TxtQueryByReference.Metrocolor = System.Drawing.Color.Green;
            this.TxtQueryByReference.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByReference.Multiline = true;
            this.TxtQueryByReference.Name = "TxtQueryByReference";
            this.TxtQueryByReference.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByReference.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByReference.Size = new System.Drawing.Size(78, 26);
            this.TxtQueryByReference.TabIndex = 2;
            this.TxtQueryByReference.Tag = "";
            this.TxtQueryByReference.ThemeName = "Default";
            this.TxtQueryByReference.WordWrap = false;
            this.TxtQueryByReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTheQuery_ForTheSearchBox_KeyPress);
            // 
            // TxtQueryBySize
            // 
            this.TxtQueryBySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.TxtQueryBySize.BeforeTouchSize = new System.Drawing.Size(85, 26);
            this.TxtQueryBySize.BorderColor = System.Drawing.Color.Gray;
            this.TxtQueryBySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryBySize.CanOverrideStyle = true;
            this.TxtQueryBySize.CausesValidation = false;
            this.TxtQueryBySize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryBySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryBySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryBySize.Location = new System.Drawing.Point(160, 28);
            this.TxtQueryBySize.MaxLength = 50;
            this.TxtQueryBySize.Metrocolor = System.Drawing.Color.Green;
            this.TxtQueryBySize.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryBySize.Multiline = true;
            this.TxtQueryBySize.Name = "TxtQueryBySize";
            this.TxtQueryBySize.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryBySize.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryBySize.Size = new System.Drawing.Size(79, 26);
            this.TxtQueryBySize.TabIndex = 1;
            this.TxtQueryBySize.Tag = "";
            this.TxtQueryBySize.ThemeName = "Default";
            this.TxtQueryBySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTheQuery_ForTheSearchBox_KeyPress);
            // 
            // LblActivityNumberTitle
            // 
            this.LblActivityNumberTitle.AutoSize = true;
            this.LblActivityNumberTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivityNumberTitle.ForeColor = System.Drawing.Color.Black;
            this.LblActivityNumberTitle.Location = new System.Drawing.Point(30, 26);
            this.LblActivityNumberTitle.Name = "LblActivityNumberTitle";
            this.LblActivityNumberTitle.Size = new System.Drawing.Size(105, 19);
            this.LblActivityNumberTitle.TabIndex = 118;
            this.LblActivityNumberTitle.Text = "Atividade Nº:";
            // 
            // LblActivityNumber
            // 
            this.LblActivityNumber.AutoSize = true;
            this.LblActivityNumber.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivityNumber.ForeColor = System.Drawing.Color.Gray;
            this.LblActivityNumber.Location = new System.Drawing.Point(139, 26);
            this.LblActivityNumber.Name = "LblActivityNumber";
            this.LblActivityNumber.Size = new System.Drawing.Size(100, 19);
            this.LblActivityNumber.TabIndex = 119;
            this.LblActivityNumber.Text = "Atividade Nº";
            this.LblActivityNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblActivityHour
            // 
            this.LblActivityHour.AutoSize = true;
            this.LblActivityHour.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivityHour.ForeColor = System.Drawing.Color.Gray;
            this.LblActivityHour.Location = new System.Drawing.Point(398, 57);
            this.LblActivityHour.Name = "LblActivityHour";
            this.LblActivityHour.Size = new System.Drawing.Size(65, 19);
            this.LblActivityHour.TabIndex = 125;
            this.LblActivityHour.Text = "Horário";
            // 
            // LblActivityHourTitle
            // 
            this.LblActivityHourTitle.AutoSize = true;
            this.LblActivityHourTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivityHourTitle.ForeColor = System.Drawing.Color.Black;
            this.LblActivityHourTitle.Location = new System.Drawing.Point(322, 57);
            this.LblActivityHourTitle.Name = "LblActivityHourTitle";
            this.LblActivityHourTitle.Size = new System.Drawing.Size(70, 19);
            this.LblActivityHourTitle.TabIndex = 124;
            this.LblActivityHourTitle.Text = "Horário:";
            // 
            // LblActivityDate
            // 
            this.LblActivityDate.AutoSize = true;
            this.LblActivityDate.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivityDate.ForeColor = System.Drawing.Color.Gray;
            this.LblActivityDate.Location = new System.Drawing.Point(368, 27);
            this.LblActivityDate.Name = "LblActivityDate";
            this.LblActivityDate.Size = new System.Drawing.Size(43, 19);
            this.LblActivityDate.TabIndex = 123;
            this.LblActivityDate.Text = "Data";
            // 
            // LblActivityDateTitle
            // 
            this.LblActivityDateTitle.AutoSize = true;
            this.LblActivityDateTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivityDateTitle.ForeColor = System.Drawing.Color.Black;
            this.LblActivityDateTitle.Location = new System.Drawing.Point(322, 26);
            this.LblActivityDateTitle.Name = "LblActivityDateTitle";
            this.LblActivityDateTitle.Size = new System.Drawing.Size(48, 19);
            this.LblActivityDateTitle.TabIndex = 122;
            this.LblActivityDateTitle.Text = "Data:";
            // 
            // LblActivitySituation
            // 
            this.LblActivitySituation.AutoSize = true;
            this.LblActivitySituation.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivitySituation.ForeColor = System.Drawing.Color.Gray;
            this.LblActivitySituation.Location = new System.Drawing.Point(638, 26);
            this.LblActivitySituation.Name = "LblActivitySituation";
            this.LblActivitySituation.Size = new System.Drawing.Size(69, 19);
            this.LblActivitySituation.TabIndex = 127;
            this.LblActivitySituation.Text = "Situação";
            // 
            // LblActivitySituationTitle
            // 
            this.LblActivitySituationTitle.AutoSize = true;
            this.LblActivitySituationTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivitySituationTitle.ForeColor = System.Drawing.Color.Black;
            this.LblActivitySituationTitle.Location = new System.Drawing.Point(566, 26);
            this.LblActivitySituationTitle.Name = "LblActivitySituationTitle";
            this.LblActivitySituationTitle.Size = new System.Drawing.Size(74, 19);
            this.LblActivitySituationTitle.TabIndex = 126;
            this.LblActivitySituationTitle.Text = "Situação:";
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
            this.CardMain.Controls.Add(this.LbkClear);
            this.CardMain.Controls.Add(this.PicLoading);
            this.CardMain.Controls.Add(this.LblTotalItems);
            this.CardMain.Controls.Add(this.LblTotalItemsTitle);
            this.CardMain.Controls.Add(this.BtnAddNewItem);
            this.CardMain.Controls.Add(this.TxtQuantity);
            this.CardMain.Controls.Add(this.LblSubTotal);
            this.CardMain.Controls.Add(this.LblSubTotalTitle);
            this.CardMain.Controls.Add(this.LblTotalValue);
            this.CardMain.Controls.Add(this.TxtQueryByDescription);
            this.CardMain.Controls.Add(this.TxtTotalValue);
            this.CardMain.Controls.Add(this.TxtQueryBySize);
            this.CardMain.Controls.Add(this.LblUnitaryValue);
            this.CardMain.Controls.Add(this.TxtQueryByReference);
            this.CardMain.Controls.Add(this.TxtQueryByCode);
            this.CardMain.Controls.Add(this.TxtUnitaryValue);
            this.CardMain.Controls.Add(this.LblQueryByCode);
            this.CardMain.Controls.Add(this.LblQueryBySize);
            this.CardMain.Controls.Add(this.LblQuantity);
            this.CardMain.Controls.Add(this.LblQueryByReference);
            this.CardMain.Controls.Add(this.LblQueryByDescription);
            this.CardMain.Controls.Add(this.GridMain);
            this.CardMain.LeftSahddow = true;
            this.CardMain.Location = new System.Drawing.Point(31, 288);
            this.CardMain.Name = "CardMain";
            this.CardMain.RightSahddow = true;
            this.CardMain.ShadowDepth = 20;
            this.CardMain.Size = new System.Drawing.Size(902, 375);
            this.CardMain.TabIndex = 136;
            // 
            // LbkClear
            // 
            this.LbkClear.AutoSize = true;
            this.LbkClear.Location = new System.Drawing.Point(25, 34);
            this.LbkClear.Name = "LbkClear";
            this.LbkClear.Size = new System.Drawing.Size(38, 13);
            this.LbkClear.TabIndex = 141;
            this.LbkClear.TabStop = true;
            this.LbkClear.Text = "Limpar";
            this.LbkClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblClear_LinkClicked);
            // 
            // PicLoading
            // 
            this.PicLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLoading.Image = global::DimStock.Properties.Resources.Load;
            this.PicLoading.Location = new System.Drawing.Point(379, 121);
            this.PicLoading.Name = "PicLoading";
            this.PicLoading.Size = new System.Drawing.Size(129, 137);
            this.PicLoading.TabIndex = 139;
            this.PicLoading.TabStop = false;
            this.PicLoading.Visible = false;
            // 
            // LblTotalItems
            // 
            this.LblTotalItems.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalItems.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalItems.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LblTotalItems.Location = new System.Drawing.Point(109, 325);
            this.LblTotalItems.Name = "LblTotalItems";
            this.LblTotalItems.Size = new System.Drawing.Size(98, 32);
            this.LblTotalItems.TabIndex = 138;
            this.LblTotalItems.Text = "0";
            // 
            // LblTotalItemsTitle
            // 
            this.LblTotalItemsTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalItemsTitle.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalItemsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTotalItemsTitle.Location = new System.Drawing.Point(22, 325);
            this.LblTotalItemsTitle.Name = "LblTotalItemsTitle";
            this.LblTotalItemsTitle.Size = new System.Drawing.Size(94, 32);
            this.LblTotalItemsTitle.TabIndex = 137;
            this.LblTotalItemsTitle.Text = "ITENS:";
            // 
            // GridMain
            // 
            this.GridMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMain.ListIsItem = false;
            this.GridMain.ListIsStock = false;
            this.GridMain.Location = new System.Drawing.Point(21, 60);
            this.GridMain.Name = "GridMain";
            this.GridMain.Size = new System.Drawing.Size(861, 251);
            this.GridMain.TabIndex = 141;
            this.GridMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMain_CellClick);
            this.GridMain.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.GridMain_RowPrePaint);
            this.GridMain.DoubleClick += new System.EventHandler(this.GridMain_DoubleClick);
            // 
            // BtnDelete
            // 
            this.BtnDelete.AccessibleName = "Button";
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDelete.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(100, 47);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(80, 35);
            this.BtnDelete.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnDelete.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnDelete.Style.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDelete.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnDelete.Style.PressedBackColor = System.Drawing.Color.White;
            this.BtnDelete.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnDelete.TabIndex = 142;
            this.BtnDelete.Text = "Excluir";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.AccessibleName = "Button";
            this.BtnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnConfirm.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirm.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Location = new System.Drawing.Point(183, 47);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(80, 35);
            this.BtnConfirm.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirm.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirm.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirm.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirm.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Style.ForeColor = System.Drawing.Color.White;
            this.BtnConfirm.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnConfirm.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnConfirm.Style.PressedBackColor = System.Drawing.Color.White;
            this.BtnConfirm.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnConfirm.TabIndex = 140;
            this.BtnConfirm.Text = "Confirmar";
            this.BtnConfirm.UseVisualStyleBackColor = false;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // GbxGeneralInformation
            // 
            this.GbxGeneralInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GbxGeneralInformation.Controls.Add(this.LblActivityTypeTitle);
            this.GbxGeneralInformation.Controls.Add(this.LblActivityType);
            this.GbxGeneralInformation.Controls.Add(this.LblActivityDate);
            this.GbxGeneralInformation.Controls.Add(this.LblActivityNumberTitle);
            this.GbxGeneralInformation.Controls.Add(this.LblActivityNumber);
            this.GbxGeneralInformation.Controls.Add(this.LblActivitySituation);
            this.GbxGeneralInformation.Controls.Add(this.LblActivityDateTitle);
            this.GbxGeneralInformation.Controls.Add(this.LblActivitySituationTitle);
            this.GbxGeneralInformation.Controls.Add(this.LblActivityHour);
            this.GbxGeneralInformation.Controls.Add(this.LblActivityHourTitle);
            this.GbxGeneralInformation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GbxGeneralInformation.Location = new System.Drawing.Point(31, 108);
            this.GbxGeneralInformation.Name = "GbxGeneralInformation";
            this.GbxGeneralInformation.Size = new System.Drawing.Size(902, 96);
            this.GbxGeneralInformation.TabIndex = 140;
            this.GbxGeneralInformation.TabStop = false;
            this.GbxGeneralInformation.Text = "INFORMAÇÕES GERAIS";
            // 
            // LblActivityTypeTitle
            // 
            this.LblActivityTypeTitle.AutoSize = true;
            this.LblActivityTypeTitle.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivityTypeTitle.ForeColor = System.Drawing.Color.Black;
            this.LblActivityTypeTitle.Location = new System.Drawing.Point(31, 61);
            this.LblActivityTypeTitle.Name = "LblActivityTypeTitle";
            this.LblActivityTypeTitle.Size = new System.Drawing.Size(48, 19);
            this.LblActivityTypeTitle.TabIndex = 128;
            this.LblActivityTypeTitle.Text = "Tipo:";
            // 
            // LblActivityType
            // 
            this.LblActivityType.AutoSize = true;
            this.LblActivityType.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblActivityType.ForeColor = System.Drawing.Color.Gray;
            this.LblActivityType.Location = new System.Drawing.Point(85, 61);
            this.LblActivityType.Name = "LblActivityType";
            this.LblActivityType.Size = new System.Drawing.Size(43, 19);
            this.LblActivityType.TabIndex = 129;
            this.LblActivityType.Text = "Tipo";
            this.LblActivityType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // PnlUpperHorinzontal
            // 
            this.PnlUpperHorinzontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlUpperHorinzontal.BackgroundImage")));
            this.PnlUpperHorinzontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlUpperHorinzontal.Controls.Add(this.LblTodayIsDay);
            this.PnlUpperHorinzontal.Controls.Add(this.LblFormTitle);
            this.PnlUpperHorinzontal.Controls.Add(this.BtnNew);
            this.PnlUpperHorinzontal.Controls.Add(this.BtnConfirm);
            this.PnlUpperHorinzontal.Controls.Add(this.BtnDelete);
            this.PnlUpperHorinzontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUpperHorinzontal.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PnlUpperHorinzontal.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PnlUpperHorinzontal.GradientTopLeft = System.Drawing.Color.Black;
            this.PnlUpperHorinzontal.GradientTopRight = System.Drawing.Color.Black;
            this.PnlUpperHorinzontal.Location = new System.Drawing.Point(0, 0);
            this.PnlUpperHorinzontal.Name = "PnlUpperHorinzontal";
            this.PnlUpperHorinzontal.Quality = 10;
            this.PnlUpperHorinzontal.Size = new System.Drawing.Size(964, 97);
            this.PnlUpperHorinzontal.TabIndex = 139;
            // 
            // LblTodayIsDay
            // 
            this.LblTodayIsDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTodayIsDay.BackColor = System.Drawing.Color.Transparent;
            this.LblTodayIsDay.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTodayIsDay.ForeColor = System.Drawing.Color.White;
            this.LblTodayIsDay.Location = new System.Drawing.Point(467, 23);
            this.LblTodayIsDay.Name = "LblTodayIsDay";
            this.LblTodayIsDay.Size = new System.Drawing.Size(494, 40);
            this.LblTodayIsDay.TabIndex = 139;
            this.LblTodayIsDay.Text = "Entrada de Estoque";
            this.LblTodayIsDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblFormTitle
            // 
            this.LblFormTitle.AutoSize = true;
            this.LblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblFormTitle.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormTitle.ForeColor = System.Drawing.Color.White;
            this.LblFormTitle.Location = new System.Drawing.Point(12, 4);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(304, 40);
            this.LblFormTitle.TabIndex = 138;
            this.LblFormTitle.Text = "Entrada de Estoque";
            // 
            // BtnNew
            // 
            this.BtnNew.AccessibleName = "Button";
            this.BtnNew.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.ForeColor = System.Drawing.Color.White;
            this.BtnNew.Location = new System.Drawing.Point(17, 47);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(80, 35);
            this.BtnNew.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnNew.Style.ForeColor = System.Drawing.Color.White;
            this.BtnNew.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNew.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnNew.Style.PressedBackColor = System.Drawing.Color.White;
            this.BtnNew.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnNew.TabIndex = 137;
            this.BtnNew.Text = "Nova";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // CboStockDestination
            // 
            this.CboStockDestination.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboStockDestination.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboStockDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboStockDestination.FormattingEnabled = true;
            this.CboStockDestination.Location = new System.Drawing.Point(31, 239);
            this.CboStockDestination.Name = "CboStockDestination";
            this.CboStockDestination.Size = new System.Drawing.Size(370, 28);
            this.CboStockDestination.TabIndex = 145;
            this.CboStockDestination.DropDown += new System.EventHandler(this.CboStockDestination_DropDown);
            this.CboStockDestination.SelectedIndexChanged += new System.EventHandler(this.CboStockDestination_SelectedIndexChanged);
            // 
            // LklRegisterNewStockDestination
            // 
            this.LklRegisterNewStockDestination.AutoSize = true;
            this.LklRegisterNewStockDestination.Location = new System.Drawing.Point(320, 223);
            this.LklRegisterNewStockDestination.Name = "LklRegisterNewStockDestination";
            this.LklRegisterNewStockDestination.Size = new System.Drawing.Size(81, 13);
            this.LklRegisterNewStockDestination.TabIndex = 146;
            this.LklRegisterNewStockDestination.TabStop = true;
            this.LklRegisterNewStockDestination.Text = "Cadastrar Novo";
            this.LklRegisterNewStockDestination.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblRegisterNew_StockDestination_LinkClicked);
            // 
            // FrmStockActivityRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.LklRegisterNewStockDestination);
            this.Controls.Add(this.CboStockDestination);
            this.Controls.Add(this.GbxGeneralInformation);
            this.Controls.Add(this.LblStockDestination);
            this.Controls.Add(this.PnlUpperHorinzontal);
            this.Controls.Add(this.CardMain);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmStockActivityRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmStockActivityRegister_Load);
            this.Resize += new System.EventHandler(this.FrmStockActivityRegister_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtUnitaryValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryBySize)).EndInit();
            this.CardMain.ResumeLayout(false);
            this.CardMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridMain)).EndInit();
            this.GbxGeneralInformation.ResumeLayout(false);
            this.GbxGeneralInformation.PerformLayout();
            this.PnlUpperHorinzontal.ResumeLayout(false);
            this.PnlUpperHorinzontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerExecuteQuery;
        private System.Windows.Forms.Label LblSubTotalTitle;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label LblActivityHourTitle;
        private System.Windows.Forms.Label LblActivityDateTitle;
        private System.Windows.Forms.Label LblActivitySituationTitle;
        private Syncfusion.WinForms.Controls.SfButton BtnAddNewItem;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox TxtQuantity;
        private System.Windows.Forms.Label LblTotalValue;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TxtTotalValue;
        private System.Windows.Forms.Label LblUnitaryValue;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TxtUnitaryValue;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.Label LblQueryByDescription;
        private System.Windows.Forms.Label LblQueryByReference;
        private System.Windows.Forms.Label LblQueryBySize;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByDescription;
        private System.Windows.Forms.Label LblQueryByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByReference;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryBySize;
        public System.Windows.Forms.Label LblActivityNumber;
        public System.Windows.Forms.Label LblActivityHour;
        public System.Windows.Forms.Label LblActivityDate;
        public System.Windows.Forms.Label LblActivitySituation;
        private Bunifu.Framework.UI.BunifuCards CardMain;
        private System.Windows.Forms.Label LblTotalItems;
        private System.Windows.Forms.Label LblTotalItemsTitle;
        private System.Windows.Forms.PictureBox PicLoading;
        private Syncfusion.WinForms.Controls.SfButton BtnConfirm;
        private Syncfusion.WinForms.Controls.SfButton BtnNew;
        public System.Windows.Forms.Label LblActivityNumberTitle;
        private Bunifu.Framework.UI.BunifuGradientPanel PnlUpperHorinzontal;
        public System.Windows.Forms.Label LblFormTitle;
        private System.Windows.Forms.GroupBox GbxGeneralInformation;
        public System.Windows.Forms.Label LblActivityTypeTitle;
        public System.Windows.Forms.Label LblActivityType;
        public System.Windows.Forms.Label LblTodayIsDay;
        private System.Windows.Forms.LinkLabel LbkClear;
        private Syncfusion.WinForms.Controls.SfButton BtnDelete;
        public Auxiliary.AxlDataGridViewStockItem GridMain;
        public System.Windows.Forms.Label LblStockDestination;
        private System.Windows.Forms.ComboBox CboStockDestination;
        private System.Windows.Forms.LinkLabel LklRegisterNewStockDestination;
    }
}