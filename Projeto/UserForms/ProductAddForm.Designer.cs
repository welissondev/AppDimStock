namespace DimStock.UserForms
{
    partial class ProductAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductAddForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TextBarCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TextSalePrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextCostPrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.BarCodeTitle = new System.Windows.Forms.Label();
            this.SalePriceTitle = new System.Windows.Forms.Label();
            this.CostPriceTitle = new System.Windows.Forms.Label();
            this.DescriptionTitle = new System.Windows.Forms.Label();
            this.ButtonPresenter_ResetView = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.TextInternalCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonSearch_Category = new System.Windows.Forms.LinkLabel();
            this.ButtonDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextCategoryDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.doubleBitmapControl1 = new BunifuAnimatorNS.DoubleBitmapControl();
            this.DataGridCategory = new DimStock.Controls.CustomDataGridViewTwo();
            ((System.ComponentModel.ISupportInitialize)(this.TextBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextInternalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCategoryDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBarCode
            // 
            this.TextBarCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextBarCode.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextBarCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBarCode.CanOverrideStyle = true;
            this.TextBarCode.CausesValidation = false;
            this.TextBarCode.CornerRadius = 1;
            this.TextBarCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBarCode.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextBarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextBarCode.Location = new System.Drawing.Point(157, 311);
            this.TextBarCode.MaxLength = 50;
            this.TextBarCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextBarCode.Name = "TextBarCode";
            this.TextBarCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextBarCode.Size = new System.Drawing.Size(599, 27);
            this.TextBarCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextBarCode.TabIndex = 5;
            this.TextBarCode.ThemeName = "Office2016White";
            this.TextBarCode.ThemesEnabled = false;
            // 
            // TextSalePrice
            // 
            this.TextSalePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextSalePrice.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextSalePrice.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextSalePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSalePrice.CanOverrideStyle = true;
            this.TextSalePrice.CausesValidation = false;
            this.TextSalePrice.CornerRadius = 1;
            this.TextSalePrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSalePrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextSalePrice.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSalePrice.Location = new System.Drawing.Point(157, 255);
            this.TextSalePrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSalePrice.Name = "TextSalePrice";
            this.TextSalePrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextSalePrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSalePrice.Size = new System.Drawing.Size(188, 27);
            this.TextSalePrice.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextSalePrice.TabIndex = 4;
            this.TextSalePrice.Text = "R$ 0,00";
            this.TextSalePrice.ThemeName = "Office2016White";
            this.TextSalePrice.ThemesEnabled = false;
            this.TextSalePrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TextCostPrice
            // 
            this.TextCostPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextCostPrice.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextCostPrice.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextCostPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextCostPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextCostPrice.CanOverrideStyle = true;
            this.TextCostPrice.CausesValidation = false;
            this.TextCostPrice.CornerRadius = 1;
            this.TextCostPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextCostPrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextCostPrice.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextCostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextCostPrice.Location = new System.Drawing.Point(157, 198);
            this.TextCostPrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextCostPrice.Name = "TextCostPrice";
            this.TextCostPrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextCostPrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextCostPrice.Size = new System.Drawing.Size(188, 27);
            this.TextCostPrice.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextCostPrice.TabIndex = 3;
            this.TextCostPrice.Text = "R$ 0,00";
            this.TextCostPrice.ThemeName = "Office2016White";
            this.TextCostPrice.ThemesEnabled = false;
            this.TextCostPrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TextDescription
            // 
            this.TextDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextDescription.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDescription.CanOverrideStyle = true;
            this.TextDescription.CausesValidation = false;
            this.TextDescription.CornerRadius = 1;
            this.TextDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextDescription.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextDescription.Location = new System.Drawing.Point(293, 91);
            this.TextDescription.MaxLength = 2000;
            this.TextDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextDescription.Size = new System.Drawing.Size(466, 27);
            this.TextDescription.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextDescription.TabIndex = 1;
            this.TextDescription.Tag = "";
            this.TextDescription.ThemeName = "Office2016White";
            this.TextDescription.ThemesEnabled = false;
            // 
            // BarCodeTitle
            // 
            this.BarCodeTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BarCodeTitle.AutoSize = true;
            this.BarCodeTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.BarCodeTitle.Location = new System.Drawing.Point(155, 293);
            this.BarCodeTitle.Name = "BarCodeTitle";
            this.BarCodeTitle.Size = new System.Drawing.Size(108, 17);
            this.BarCodeTitle.TabIndex = 64;
            this.BarCodeTitle.Text = "Código de Barras:";
            // 
            // SalePriceTitle
            // 
            this.SalePriceTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SalePriceTitle.AutoSize = true;
            this.SalePriceTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.SalePriceTitle.Location = new System.Drawing.Point(155, 238);
            this.SalePriceTitle.Name = "SalePriceTitle";
            this.SalePriceTitle.Size = new System.Drawing.Size(82, 17);
            this.SalePriceTitle.TabIndex = 63;
            this.SalePriceTitle.Text = "Preço Venda:";
            // 
            // CostPriceTitle
            // 
            this.CostPriceTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CostPriceTitle.AutoSize = true;
            this.CostPriceTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.CostPriceTitle.Location = new System.Drawing.Point(155, 182);
            this.CostPriceTitle.Name = "CostPriceTitle";
            this.CostPriceTitle.Size = new System.Drawing.Size(79, 17);
            this.CostPriceTitle.TabIndex = 62;
            this.CostPriceTitle.Text = "Preço Custo:";
            // 
            // DescriptionTitle
            // 
            this.DescriptionTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DescriptionTitle.AutoSize = true;
            this.DescriptionTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.DescriptionTitle.Location = new System.Drawing.Point(290, 74);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(67, 17);
            this.DescriptionTitle.TabIndex = 61;
            this.DescriptionTitle.Text = "Descrição:";
            // 
            // ButtonPresenter_ResetView
            // 
            this.ButtonPresenter_ResetView.ActiveBorderThickness = 1;
            this.ButtonPresenter_ResetView.ActiveCornerRadius = 5;
            this.ButtonPresenter_ResetView.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonPresenter_ResetView.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonPresenter_ResetView.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonPresenter_ResetView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonPresenter_ResetView.BackColor = System.Drawing.Color.White;
            this.ButtonPresenter_ResetView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPresenter_ResetView.BackgroundImage")));
            this.ButtonPresenter_ResetView.ButtonText = "Limpar";
            this.ButtonPresenter_ResetView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPresenter_ResetView.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPresenter_ResetView.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonPresenter_ResetView.IdleBorderThickness = 1;
            this.ButtonPresenter_ResetView.IdleCornerRadius = 5;
            this.ButtonPresenter_ResetView.IdleFillColor = System.Drawing.Color.Gray;
            this.ButtonPresenter_ResetView.IdleForecolor = System.Drawing.Color.White;
            this.ButtonPresenter_ResetView.IdleLineColor = System.Drawing.Color.FloralWhite;
            this.ButtonPresenter_ResetView.Location = new System.Drawing.Point(563, 346);
            this.ButtonPresenter_ResetView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonPresenter_ResetView.Name = "ButtonPresenter_ResetView";
            this.ButtonPresenter_ResetView.Size = new System.Drawing.Size(97, 43);
            this.ButtonPresenter_ResetView.TabIndex = 213;
            this.ButtonPresenter_ResetView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonPresenter_ResetView.Click += new System.EventHandler(this.ButtonPresenter_ResetView_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.ActiveBorderThickness = 1;
            this.ButtonSave.ActiveCornerRadius = 5;
            this.ButtonSave.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonSave.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonSave.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonSave.BackColor = System.Drawing.Color.White;
            this.ButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.BackgroundImage")));
            this.ButtonSave.ButtonText = "Salvar";
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonSave.IdleBorderThickness = 1;
            this.ButtonSave.IdleCornerRadius = 5;
            this.ButtonSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ButtonSave.IdleForecolor = System.Drawing.Color.White;
            this.ButtonSave.IdleLineColor = System.Drawing.Color.FloralWhite;
            this.ButtonSave.Location = new System.Drawing.Point(464, 346);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 43);
            this.ButtonSave.TabIndex = 212;
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LblStockDestination
            // 
            this.LblStockDestination.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblStockDestination.AutoSize = true;
            this.LblStockDestination.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblStockDestination.ForeColor = System.Drawing.Color.Black;
            this.LblStockDestination.Location = new System.Drawing.Point(154, 129);
            this.LblStockDestination.Name = "LblStockDestination";
            this.LblStockDestination.Size = new System.Drawing.Size(68, 17);
            this.LblStockDestination.TabIndex = 214;
            this.LblStockDestination.Text = "Categoria:";
            // 
            // TextInternalCode
            // 
            this.TextInternalCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextInternalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextInternalCode.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextInternalCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextInternalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextInternalCode.CanOverrideStyle = true;
            this.TextInternalCode.CausesValidation = false;
            this.TextInternalCode.CornerRadius = 1;
            this.TextInternalCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextInternalCode.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextInternalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextInternalCode.Location = new System.Drawing.Point(157, 91);
            this.TextInternalCode.MaxLength = 2000;
            this.TextInternalCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextInternalCode.Name = "TextInternalCode";
            this.TextInternalCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextInternalCode.Size = new System.Drawing.Size(130, 27);
            this.TextInternalCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextInternalCode.TabIndex = 0;
            this.TextInternalCode.Tag = "";
            this.TextInternalCode.ThemeName = "Office2016White";
            this.TextInternalCode.ThemesEnabled = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.Location = new System.Drawing.Point(155, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 220;
            this.label1.Text = "Código:";
            // 
            // ButtonSearch_Category
            // 
            this.ButtonSearch_Category.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonSearch_Category.AutoSize = true;
            this.ButtonSearch_Category.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSearch_Category.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.ButtonSearch_Category.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonSearch_Category.Location = new System.Drawing.Point(710, 150);
            this.ButtonSearch_Category.Name = "ButtonSearch_Category";
            this.ButtonSearch_Category.Size = new System.Drawing.Size(46, 17);
            this.ButtonSearch_Category.TabIndex = 221;
            this.ButtonSearch_Category.TabStop = true;
            this.ButtonSearch_Category.Text = "Buscar";
            this.ButtonSearch_Category.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonSearch_Category_LinkClicked);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.ActiveBorderThickness = 1;
            this.ButtonDelete.ActiveCornerRadius = 5;
            this.ButtonDelete.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDelete.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonDelete.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonDelete.BackColor = System.Drawing.Color.White;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.ButtonText = "Deletar";
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.IdleBorderThickness = 1;
            this.ButtonDelete.IdleCornerRadius = 5;
            this.ButtonDelete.IdleFillColor = System.Drawing.Color.Gray;
            this.ButtonDelete.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDelete.IdleLineColor = System.Drawing.Color.FloralWhite;
            this.ButtonDelete.Location = new System.Drawing.Point(662, 346);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(97, 43);
            this.ButtonDelete.TabIndex = 226;
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextCategoryDescription
            // 
            this.TextCategoryDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextCategoryDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextCategoryDescription.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextCategoryDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextCategoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextCategoryDescription.CanOverrideStyle = true;
            this.TextCategoryDescription.CausesValidation = false;
            this.TextCategoryDescription.CornerRadius = 1;
            this.TextCategoryDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextCategoryDescription.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextCategoryDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextCategoryDescription.Location = new System.Drawing.Point(157, 145);
            this.TextCategoryDescription.MaxLength = 2000;
            this.TextCategoryDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextCategoryDescription.Name = "TextCategoryDescription";
            this.TextCategoryDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextCategoryDescription.Size = new System.Drawing.Size(602, 27);
            this.TextCategoryDescription.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextCategoryDescription.TabIndex = 2;
            this.TextCategoryDescription.Tag = "";
            this.TextCategoryDescription.ThemeName = "Office2016White";
            this.TextCategoryDescription.ThemesEnabled = false;
            this.TextCategoryDescription.Click += new System.EventHandler(this.TextCategoryDescription_Click);
            this.TextCategoryDescription.TextChanged += new System.EventHandler(this.TextCategoryDescription_TextChanged);
            // 
            // doubleBitmapControl1
            // 
            this.doubleBitmapControl1.Location = new System.Drawing.Point(868, 499);
            this.doubleBitmapControl1.Name = "doubleBitmapControl1";
            this.doubleBitmapControl1.Size = new System.Drawing.Size(75, 23);
            this.doubleBitmapControl1.TabIndex = 229;
            this.doubleBitmapControl1.Text = "doubleBitmapControl1";
            this.doubleBitmapControl1.Visible = false;
            // 
            // DataGridCategory
            // 
            this.DataGridCategory.AllowUserToAddRows = false;
            this.DataGridCategory.AllowUserToResizeRows = false;
            this.DataGridCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridCategory.BackgroundColor = System.Drawing.Color.White;
            this.DataGridCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCategory.ColumnHeadersVisible = false;
            this.DataGridCategory.CustomSettings = false;
            this.DataGridCategory.Location = new System.Drawing.Point(158, 171);
            this.DataGridCategory.MultiSelect = false;
            this.DataGridCategory.Name = "DataGridCategory";
            this.DataGridCategory.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.DataGridCategory.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCategory.Size = new System.Drawing.Size(601, 13);
            this.DataGridCategory.TabIndex = 228;
            this.DataGridCategory.Visible = false;
            this.DataGridCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCategory_CellClick);
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.ButtonSearch_Category);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonPresenter_ResetView);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.doubleBitmapControl1);
            this.Controls.Add(this.DataGridCategory);
            this.Controls.Add(this.TextCategoryDescription);
            this.Controls.Add(this.TextInternalCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LblStockDestination);
            this.Controls.Add(this.TextBarCode);
            this.Controls.Add(this.TextSalePrice);
            this.Controls.Add(this.TextCostPrice);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.BarCodeTitle);
            this.Controls.Add(this.SalePriceTitle);
            this.Controls.Add(this.CostPriceTitle);
            this.Controls.Add(this.DescriptionTitle);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "ProductAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.ProductAddForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.TextBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextInternalCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCategoryDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BarCodeTitle;
        private System.Windows.Forms.Label SalePriceTitle;
        private System.Windows.Forms.Label CostPriceTitle;
        private System.Windows.Forms.Label DescriptionTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextBarCode;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextSalePrice;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextCostPrice;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonPresenter_ResetView;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonSave;
        public System.Windows.Forms.Label LblStockDestination;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextInternalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ButtonSearch_Category;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDelete;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextCategoryDescription;
        private Controls.CustomDataGridViewTwo DataGridCategory;
        private BunifuAnimatorNS.DoubleBitmapControl doubleBitmapControl1;
    }
}