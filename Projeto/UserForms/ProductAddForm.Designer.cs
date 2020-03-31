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
            this.ButtonClear_View = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.TextInternalCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonFetch_CategoryData = new System.Windows.Forms.LinkLabel();
            this.ButtonDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextCategoryDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.BuniCard = new Bunifu.Framework.UI.BunifuCards();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.LabelNavegationDescription = new System.Windows.Forms.Label();
            this.DataGridCategory = new DimStock.Controls.CustomDataGridViewTwo();
            ((System.ComponentModel.ISupportInitialize)(this.TextBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextInternalCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCategoryDescription)).BeginInit();
            this.BuniCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBarCode
            // 
            this.TextBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextBarCode.BeforeTouchSize = new System.Drawing.Size(169, 27);
            this.TextBarCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBarCode.CanOverrideStyle = true;
            this.TextBarCode.CausesValidation = false;
            this.TextBarCode.CornerRadius = 1;
            this.TextBarCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBarCode.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextBarCode.Location = new System.Drawing.Point(89, 332);
            this.TextBarCode.MaxLength = 50;
            this.TextBarCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextBarCode.Name = "TextBarCode";
            this.TextBarCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextBarCode.Size = new System.Drawing.Size(602, 27);
            this.TextBarCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextBarCode.TabIndex = 5;
            this.TextBarCode.ThemeName = "Office2016White";
            this.TextBarCode.ThemesEnabled = false;
            // 
            // TextSalePrice
            // 
            this.TextSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextSalePrice.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextSalePrice.BeforeTouchSize = new System.Drawing.Size(169, 27);
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
            this.TextSalePrice.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSalePrice.Location = new System.Drawing.Point(89, 278);
            this.TextSalePrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSalePrice.Name = "TextSalePrice";
            this.TextSalePrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextSalePrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSalePrice.Size = new System.Drawing.Size(169, 27);
            this.TextSalePrice.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextSalePrice.TabIndex = 4;
            this.TextSalePrice.Text = "R$ 0,00";
            this.TextSalePrice.ThemeName = "Office2016White";
            this.TextSalePrice.ThemesEnabled = false;
            this.TextSalePrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TextCostPrice
            // 
            this.TextCostPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextCostPrice.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextCostPrice.BeforeTouchSize = new System.Drawing.Size(169, 27);
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
            this.TextCostPrice.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextCostPrice.Location = new System.Drawing.Point(89, 225);
            this.TextCostPrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextCostPrice.Name = "TextCostPrice";
            this.TextCostPrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextCostPrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextCostPrice.Size = new System.Drawing.Size(169, 27);
            this.TextCostPrice.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextCostPrice.TabIndex = 3;
            this.TextCostPrice.Tag = "required";
            this.TextCostPrice.Text = "R$ 0,00";
            this.TextCostPrice.ThemeName = "Office2016White";
            this.TextCostPrice.ThemesEnabled = false;
            this.TextCostPrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TextDescription
            // 
            this.TextDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextDescription.BeforeTouchSize = new System.Drawing.Size(169, 27);
            this.TextDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDescription.CanOverrideStyle = true;
            this.TextDescription.CausesValidation = false;
            this.TextDescription.CornerRadius = 1;
            this.TextDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextDescription.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextDescription.Location = new System.Drawing.Point(89, 118);
            this.TextDescription.MaxLength = 2000;
            this.TextDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextDescription.Size = new System.Drawing.Size(602, 27);
            this.TextDescription.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextDescription.TabIndex = 1;
            this.TextDescription.Tag = "required";
            this.TextDescription.ThemeName = "Office2016White";
            this.TextDescription.ThemesEnabled = false;
            // 
            // BarCodeTitle
            // 
            this.BarCodeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarCodeTitle.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCodeTitle.ForeColor = System.Drawing.Color.Gray;
            this.BarCodeTitle.Location = new System.Drawing.Point(87, 314);
            this.BarCodeTitle.Name = "BarCodeTitle";
            this.BarCodeTitle.Size = new System.Drawing.Size(135, 20);
            this.BarCodeTitle.TabIndex = 64;
            this.BarCodeTitle.Text = "Código de Barras:";
            // 
            // SalePriceTitle
            // 
            this.SalePriceTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalePriceTitle.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalePriceTitle.ForeColor = System.Drawing.Color.Gray;
            this.SalePriceTitle.Location = new System.Drawing.Point(87, 260);
            this.SalePriceTitle.Name = "SalePriceTitle";
            this.SalePriceTitle.Size = new System.Drawing.Size(103, 20);
            this.SalePriceTitle.TabIndex = 63;
            this.SalePriceTitle.Text = "Preço Venda:";
            // 
            // CostPriceTitle
            // 
            this.CostPriceTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CostPriceTitle.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostPriceTitle.ForeColor = System.Drawing.Color.Gray;
            this.CostPriceTitle.Location = new System.Drawing.Point(87, 207);
            this.CostPriceTitle.Name = "CostPriceTitle";
            this.CostPriceTitle.Size = new System.Drawing.Size(99, 20);
            this.CostPriceTitle.TabIndex = 62;
            this.CostPriceTitle.Text = "Preço Custo:";
            // 
            // DescriptionTitle
            // 
            this.DescriptionTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionTitle.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTitle.ForeColor = System.Drawing.Color.Gray;
            this.DescriptionTitle.Location = new System.Drawing.Point(87, 100);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(83, 20);
            this.DescriptionTitle.TabIndex = 61;
            this.DescriptionTitle.Text = "Descrição:";
            // 
            // ButtonClear_View
            // 
            this.ButtonClear_View.ActiveBorderThickness = 1;
            this.ButtonClear_View.ActiveCornerRadius = 1;
            this.ButtonClear_View.ActiveFillColor = System.Drawing.Color.YellowGreen;
            this.ButtonClear_View.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonClear_View.ActiveLineColor = System.Drawing.Color.White;
            this.ButtonClear_View.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClear_View.BackColor = System.Drawing.Color.White;
            this.ButtonClear_View.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonClear_View.BackgroundImage")));
            this.ButtonClear_View.ButtonText = "Limpar";
            this.ButtonClear_View.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClear_View.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear_View.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonClear_View.IdleBorderThickness = 1;
            this.ButtonClear_View.IdleCornerRadius = 1;
            this.ButtonClear_View.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(63)))));
            this.ButtonClear_View.IdleForecolor = System.Drawing.Color.White;
            this.ButtonClear_View.IdleLineColor = System.Drawing.Color.FloralWhite;
            this.ButtonClear_View.Location = new System.Drawing.Point(480, 382);
            this.ButtonClear_View.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonClear_View.Name = "ButtonClear_View";
            this.ButtonClear_View.Size = new System.Drawing.Size(107, 48);
            this.ButtonClear_View.TabIndex = 213;
            this.ButtonClear_View.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonClear_View.Click += new System.EventHandler(this.ButtonClear_View_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.ActiveBorderThickness = 1;
            this.ButtonSave.ActiveCornerRadius = 1;
            this.ButtonSave.ActiveFillColor = System.Drawing.Color.YellowGreen;
            this.ButtonSave.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonSave.ActiveLineColor = System.Drawing.Color.White;
            this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSave.BackColor = System.Drawing.Color.White;
            this.ButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.BackgroundImage")));
            this.ButtonSave.ButtonText = "Salvar";
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonSave.IdleBorderThickness = 1;
            this.ButtonSave.IdleCornerRadius = 1;
            this.ButtonSave.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(63)))));
            this.ButtonSave.IdleForecolor = System.Drawing.Color.White;
            this.ButtonSave.IdleLineColor = System.Drawing.Color.FloralWhite;
            this.ButtonSave.Location = new System.Drawing.Point(373, 382);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(107, 48);
            this.ButtonSave.TabIndex = 212;
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // LblStockDestination
            // 
            this.LblStockDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblStockDestination.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStockDestination.ForeColor = System.Drawing.Color.Gray;
            this.LblStockDestination.Location = new System.Drawing.Point(87, 154);
            this.LblStockDestination.Name = "LblStockDestination";
            this.LblStockDestination.Size = new System.Drawing.Size(83, 20);
            this.LblStockDestination.TabIndex = 214;
            this.LblStockDestination.Text = "Categoria:";
            // 
            // TextInternalCode
            // 
            this.TextInternalCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextInternalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextInternalCode.BeforeTouchSize = new System.Drawing.Size(169, 27);
            this.TextInternalCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextInternalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextInternalCode.CanOverrideStyle = true;
            this.TextInternalCode.CausesValidation = false;
            this.TextInternalCode.CornerRadius = 1;
            this.TextInternalCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextInternalCode.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextInternalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextInternalCode.Location = new System.Drawing.Point(89, 67);
            this.TextInternalCode.MaxLength = 2000;
            this.TextInternalCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextInternalCode.Name = "TextInternalCode";
            this.TextInternalCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextInternalCode.Size = new System.Drawing.Size(169, 27);
            this.TextInternalCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextInternalCode.TabIndex = 0;
            this.TextInternalCode.Tag = "required";
            this.TextInternalCode.ThemeName = "Office2016White";
            this.TextInternalCode.ThemesEnabled = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(87, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 220;
            this.label1.Text = "Código:";
            // 
            // ButtonFetch_CategoryData
            // 
            this.ButtonFetch_CategoryData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonFetch_CategoryData.AutoSize = true;
            this.ButtonFetch_CategoryData.BackColor = System.Drawing.Color.Transparent;
            this.ButtonFetch_CategoryData.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.ButtonFetch_CategoryData.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonFetch_CategoryData.Location = new System.Drawing.Point(642, 176);
            this.ButtonFetch_CategoryData.Name = "ButtonFetch_CategoryData";
            this.ButtonFetch_CategoryData.Size = new System.Drawing.Size(46, 17);
            this.ButtonFetch_CategoryData.TabIndex = 221;
            this.ButtonFetch_CategoryData.TabStop = true;
            this.ButtonFetch_CategoryData.Text = "Buscar";
            this.ButtonFetch_CategoryData.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonFetch_CategoryData_LinkClicked);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.ActiveBorderThickness = 1;
            this.ButtonDelete.ActiveCornerRadius = 1;
            this.ButtonDelete.ActiveFillColor = System.Drawing.Color.YellowGreen;
            this.ButtonDelete.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonDelete.ActiveLineColor = System.Drawing.Color.White;
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDelete.BackColor = System.Drawing.Color.White;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.ButtonText = "Deletar";
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.IdleBorderThickness = 1;
            this.ButtonDelete.IdleCornerRadius = 1;
            this.ButtonDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(185)))), ((int)(((byte)(63)))));
            this.ButtonDelete.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDelete.IdleLineColor = System.Drawing.Color.FloralWhite;
            this.ButtonDelete.Location = new System.Drawing.Point(586, 382);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(105, 48);
            this.ButtonDelete.TabIndex = 226;
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TextCategoryDescription
            // 
            this.TextCategoryDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextCategoryDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextCategoryDescription.BeforeTouchSize = new System.Drawing.Size(169, 27);
            this.TextCategoryDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextCategoryDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextCategoryDescription.CanOverrideStyle = true;
            this.TextCategoryDescription.CausesValidation = false;
            this.TextCategoryDescription.CornerRadius = 1;
            this.TextCategoryDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextCategoryDescription.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextCategoryDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextCategoryDescription.Location = new System.Drawing.Point(89, 171);
            this.TextCategoryDescription.MaxLength = 2000;
            this.TextCategoryDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextCategoryDescription.Name = "TextCategoryDescription";
            this.TextCategoryDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextCategoryDescription.Size = new System.Drawing.Size(602, 27);
            this.TextCategoryDescription.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TextCategoryDescription.TabIndex = 2;
            this.TextCategoryDescription.Tag = "required";
            this.TextCategoryDescription.ThemeName = "Office2016White";
            this.TextCategoryDescription.ThemesEnabled = false;
            this.TextCategoryDescription.Click += new System.EventHandler(this.TextCategoryDescription_Click);
            this.TextCategoryDescription.TextChanged += new System.EventHandler(this.TextCategoryDescription_TextChanged);
            // 
            // BuniCard
            // 
            this.BuniCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BuniCard.BackColor = System.Drawing.Color.White;
            this.BuniCard.BorderRadius = 5;
            this.BuniCard.BottomSahddow = true;
            this.BuniCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BuniCard.Controls.Add(this.ButtonClose);
            this.BuniCard.Controls.Add(this.DataGridCategory);
            this.BuniCard.Controls.Add(this.TextBarCode);
            this.BuniCard.Controls.Add(this.BarCodeTitle);
            this.BuniCard.Controls.Add(this.TextSalePrice);
            this.BuniCard.Controls.Add(this.TextCostPrice);
            this.BuniCard.Controls.Add(this.TextDescription);
            this.BuniCard.Controls.Add(this.LabelNavegationDescription);
            this.BuniCard.Controls.Add(this.ButtonFetch_CategoryData);
            this.BuniCard.Controls.Add(this.ButtonDelete);
            this.BuniCard.Controls.Add(this.ButtonClear_View);
            this.BuniCard.Controls.Add(this.ButtonSave);
            this.BuniCard.Controls.Add(this.TextCategoryDescription);
            this.BuniCard.Controls.Add(this.DescriptionTitle);
            this.BuniCard.Controls.Add(this.TextInternalCode);
            this.BuniCard.Controls.Add(this.CostPriceTitle);
            this.BuniCard.Controls.Add(this.label1);
            this.BuniCard.Controls.Add(this.SalePriceTitle);
            this.BuniCard.Controls.Add(this.LblStockDestination);
            this.BuniCard.LeftSahddow = true;
            this.BuniCard.Location = new System.Drawing.Point(73, 47);
            this.BuniCard.Name = "BuniCard";
            this.BuniCard.RightSahddow = true;
            this.BuniCard.ShadowDepth = 22;
            this.BuniCard.Size = new System.Drawing.Size(778, 476);
            this.BuniCard.TabIndex = 229;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Image = global::DimStock.Properties.Resources.IconExit;
            this.ButtonClose.Location = new System.Drawing.Point(737, 13);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(30, 30);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ButtonClose.TabIndex = 230;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelNavegationDescription
            // 
            this.LabelNavegationDescription.BackColor = System.Drawing.Color.Transparent;
            this.LabelNavegationDescription.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNavegationDescription.ForeColor = System.Drawing.Color.DimGray;
            this.LabelNavegationDescription.Location = new System.Drawing.Point(16, 11);
            this.LabelNavegationDescription.Name = "LabelNavegationDescription";
            this.LabelNavegationDescription.Size = new System.Drawing.Size(355, 27);
            this.LabelNavegationDescription.TabIndex = 229;
            this.LabelNavegationDescription.Text = "Inicio > Cadastro de Produtos";
            this.LabelNavegationDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DataGridCategory
            // 
            this.DataGridCategory.AllowUserToAddRows = false;
            this.DataGridCategory.AllowUserToResizeRows = false;
            this.DataGridCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridCategory.BackgroundColor = System.Drawing.Color.White;
            this.DataGridCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCategory.ColumnHeadersVisible = false;
            this.DataGridCategory.CustomSettings = false;
            this.DataGridCategory.Location = new System.Drawing.Point(90, 197);
            this.DataGridCategory.MultiSelect = false;
            this.DataGridCategory.Name = "DataGridCategory";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.DataGridCategory.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCategory.Size = new System.Drawing.Size(601, 10);
            this.DataGridCategory.TabIndex = 228;
            this.DataGridCategory.Visible = false;
            this.DataGridCategory.DataSourceChanged += new System.EventHandler(this.DataGridCategory_DataSourceChanged);
            this.DataGridCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCategory_CellClick);
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(244)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(928, 569);
            this.Controls.Add(this.BuniCard);
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
            this.BuniCard.ResumeLayout(false);
            this.BuniCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategory)).EndInit();
            this.ResumeLayout(false);

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
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonClear_View;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonSave;
        public System.Windows.Forms.Label LblStockDestination;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextInternalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel ButtonFetch_CategoryData;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDelete;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextCategoryDescription;
        private Controls.CustomDataGridViewTwo DataGridCategory;
        private Bunifu.Framework.UI.BunifuCards BuniCard;
        public System.Windows.Forms.Label LabelNavegationDescription;
        private System.Windows.Forms.PictureBox ButtonClose;
    }
}