namespace DimStock.UserForms
{
    partial class ProductRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegistrationForm));
            this.BarCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SalePrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.CostPrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.Description = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.BarCodeTitle = new System.Windows.Forms.Label();
            this.SalePriceTitle = new System.Windows.Forms.Label();
            this.CostPriceTitle = new System.Windows.Forms.Label();
            this.DescriptionTitle = new System.Windows.Forms.Label();
            this.ReferenceTitle = new System.Windows.Forms.Label();
            this.SizeTitle = new System.Windows.Forms.Label();
            this.FrameProductPhoto = new System.Windows.Forms.GroupBox();
            this.CodeTitle = new System.Windows.Forms.Label();
            this.MinStockTitle = new System.Windows.Forms.Label();
            this.MaxStockTitle = new System.Windows.Forms.Label();
            this.MinStock = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.MaxStock = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.ProductSize = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.Supplier = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SupplierTitle = new System.Windows.Forms.Label();
            this.ProductCode = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.ProductReference = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.ClearFields = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddNewProductCategory = new System.Windows.Forms.LinkLabel();
            this.BoxProductCategoryList = new System.Windows.Forms.ComboBox();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.ImageProduct = new DimStock.Controls.CustomPictureBoxOne();
            ((System.ComponentModel.ISupportInitialize)(this.BarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).BeginInit();
            this.FrameProductPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // BarCode
            // 
            this.BarCode.BackColor = System.Drawing.Color.White;
            this.BarCode.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.BarCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarCode.CanOverrideStyle = true;
            this.BarCode.CausesValidation = false;
            this.BarCode.CornerRadius = 1;
            this.BarCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BarCode.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.BarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BarCode.Location = new System.Drawing.Point(288, 512);
            this.BarCode.MaxLength = 50;
            this.BarCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.BarCode.Name = "BarCode";
            this.BarCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.BarCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.BarCode.Size = new System.Drawing.Size(599, 25);
            this.BarCode.TabIndex = 9;
            this.BarCode.ThemeName = "Default";
            this.BarCode.ThemesEnabled = false;
            // 
            // SalePrice
            // 
            this.SalePrice.BackGroundColor = System.Drawing.Color.White;
            this.SalePrice.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.SalePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalePrice.CanOverrideStyle = true;
            this.SalePrice.CausesValidation = false;
            this.SalePrice.CornerRadius = 1;
            this.SalePrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SalePrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.SalePrice.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.SalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SalePrice.Location = new System.Drawing.Point(288, 456);
            this.SalePrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.SalePrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.SalePrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SalePrice.Size = new System.Drawing.Size(188, 25);
            this.SalePrice.TabIndex = 8;
            this.SalePrice.Text = "R$ 0,00";
            this.SalePrice.ThemeName = "Default";
            this.SalePrice.ThemesEnabled = false;
            this.SalePrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // CostPrice
            // 
            this.CostPrice.BackGroundColor = System.Drawing.Color.White;
            this.CostPrice.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.CostPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CostPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostPrice.CanOverrideStyle = true;
            this.CostPrice.CausesValidation = false;
            this.CostPrice.CornerRadius = 1;
            this.CostPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CostPrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.CostPrice.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.CostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CostPrice.Location = new System.Drawing.Point(288, 399);
            this.CostPrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.CostPrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.CostPrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CostPrice.Size = new System.Drawing.Size(188, 25);
            this.CostPrice.TabIndex = 7;
            this.CostPrice.Text = "R$ 0,00";
            this.CostPrice.ThemeName = "Default";
            this.CostPrice.ThemesEnabled = false;
            this.CostPrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.Description.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description.CanOverrideStyle = true;
            this.Description.CausesValidation = false;
            this.Description.CornerRadius = 1;
            this.Description.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Description.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Description.Location = new System.Drawing.Point(288, 291);
            this.Description.MaxLength = 2000;
            this.Description.MinimumSize = new System.Drawing.Size(16, 12);
            this.Description.Name = "Description";
            this.Description.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.Description.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.Description.Size = new System.Drawing.Size(602, 25);
            this.Description.TabIndex = 4;
            this.Description.Tag = "";
            this.Description.ThemeName = "Default";
            this.Description.ThemesEnabled = false;
            // 
            // BarCodeTitle
            // 
            this.BarCodeTitle.AutoSize = true;
            this.BarCodeTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.BarCodeTitle.Location = new System.Drawing.Point(285, 494);
            this.BarCodeTitle.Name = "BarCodeTitle";
            this.BarCodeTitle.Size = new System.Drawing.Size(108, 17);
            this.BarCodeTitle.TabIndex = 64;
            this.BarCodeTitle.Text = "Código de Barras:";
            // 
            // SalePriceTitle
            // 
            this.SalePriceTitle.AutoSize = true;
            this.SalePriceTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.SalePriceTitle.Location = new System.Drawing.Point(285, 439);
            this.SalePriceTitle.Name = "SalePriceTitle";
            this.SalePriceTitle.Size = new System.Drawing.Size(82, 17);
            this.SalePriceTitle.TabIndex = 63;
            this.SalePriceTitle.Text = "Preço Venda:";
            // 
            // CostPriceTitle
            // 
            this.CostPriceTitle.AutoSize = true;
            this.CostPriceTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.CostPriceTitle.Location = new System.Drawing.Point(285, 382);
            this.CostPriceTitle.Name = "CostPriceTitle";
            this.CostPriceTitle.Size = new System.Drawing.Size(79, 17);
            this.CostPriceTitle.TabIndex = 62;
            this.CostPriceTitle.Text = "Preço Custo:";
            // 
            // DescriptionTitle
            // 
            this.DescriptionTitle.AutoSize = true;
            this.DescriptionTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.DescriptionTitle.Location = new System.Drawing.Point(285, 274);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(67, 17);
            this.DescriptionTitle.TabIndex = 61;
            this.DescriptionTitle.Text = "Descrição:";
            // 
            // ReferenceTitle
            // 
            this.ReferenceTitle.AutoSize = true;
            this.ReferenceTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.ReferenceTitle.Location = new System.Drawing.Point(520, 116);
            this.ReferenceTitle.Name = "ReferenceTitle";
            this.ReferenceTitle.Size = new System.Drawing.Size(72, 17);
            this.ReferenceTitle.TabIndex = 60;
            this.ReferenceTitle.Text = "Referência:";
            // 
            // SizeTitle
            // 
            this.SizeTitle.AutoSize = true;
            this.SizeTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.SizeTitle.Location = new System.Drawing.Point(399, 116);
            this.SizeTitle.Name = "SizeTitle";
            this.SizeTitle.Size = new System.Drawing.Size(64, 17);
            this.SizeTitle.TabIndex = 59;
            this.SizeTitle.Text = "Tamanho:";
            // 
            // FrameProductPhoto
            // 
            this.FrameProductPhoto.BackColor = System.Drawing.Color.White;
            this.FrameProductPhoto.Controls.Add(this.ImageProduct);
            this.FrameProductPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FrameProductPhoto.Location = new System.Drawing.Point(77, 127);
            this.FrameProductPhoto.Name = "FrameProductPhoto";
            this.FrameProductPhoto.Size = new System.Drawing.Size(189, 210);
            this.FrameProductPhoto.TabIndex = 75;
            this.FrameProductPhoto.TabStop = false;
            // 
            // CodeTitle
            // 
            this.CodeTitle.AutoSize = true;
            this.CodeTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.CodeTitle.Location = new System.Drawing.Point(285, 116);
            this.CodeTitle.Name = "CodeTitle";
            this.CodeTitle.Size = new System.Drawing.Size(51, 17);
            this.CodeTitle.TabIndex = 76;
            this.CodeTitle.Text = "Código:";
            // 
            // MinStockTitle
            // 
            this.MinStockTitle.AutoSize = true;
            this.MinStockTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.MinStockTitle.Location = new System.Drawing.Point(285, 328);
            this.MinStockTitle.Name = "MinStockTitle";
            this.MinStockTitle.Size = new System.Drawing.Size(81, 17);
            this.MinStockTitle.TabIndex = 80;
            this.MinStockTitle.Text = "Estoque Min.";
            // 
            // MaxStockTitle
            // 
            this.MaxStockTitle.AutoSize = true;
            this.MaxStockTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.MaxStockTitle.Location = new System.Drawing.Point(379, 328);
            this.MaxStockTitle.Name = "MaxStockTitle";
            this.MaxStockTitle.Size = new System.Drawing.Size(84, 17);
            this.MaxStockTitle.TabIndex = 79;
            this.MaxStockTitle.Text = "Estoque Max.";
            // 
            // MinStock
            // 
            this.MinStock.BackGroundColor = System.Drawing.Color.White;
            this.MinStock.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.MinStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MinStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinStock.CornerRadius = 1;
            this.MinStock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinStock.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.MinStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.MinStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MinStock.IntegerValue = ((long)(0));
            this.MinStock.Location = new System.Drawing.Point(288, 344);
            this.MinStock.MaxValue = ((long)(50000));
            this.MinStock.MinimumSize = new System.Drawing.Size(12, 8);
            this.MinStock.Name = "MinStock";
            this.MinStock.NumberGroupSeparator = "";
            this.MinStock.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.MinStock.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.MinStock.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.MinStock.Size = new System.Drawing.Size(90, 25);
            this.MinStock.TabIndex = 5;
            this.MinStock.ThemeName = "Default";
            this.MinStock.ThemesEnabled = false;
            this.MinStock.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // MaxStock
            // 
            this.MaxStock.BackGroundColor = System.Drawing.Color.White;
            this.MaxStock.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.MaxStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MaxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxStock.CornerRadius = 1;
            this.MaxStock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaxStock.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.MaxStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.MaxStock.IntegerValue = ((long)(0));
            this.MaxStock.Location = new System.Drawing.Point(382, 344);
            this.MaxStock.MaxValue = ((long)(50000));
            this.MaxStock.MinimumSize = new System.Drawing.Size(12, 8);
            this.MaxStock.Name = "MaxStock";
            this.MaxStock.NumberGroupSeparator = "";
            this.MaxStock.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.MaxStock.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.MaxStock.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString;
            this.MaxStock.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.MaxStock.Size = new System.Drawing.Size(94, 25);
            this.MaxStock.TabIndex = 6;
            this.MaxStock.ThemeName = "Default";
            this.MaxStock.ThemesEnabled = false;
            this.MaxStock.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // ProductSize
            // 
            this.ProductSize.BackGroundColor = System.Drawing.Color.White;
            this.ProductSize.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.ProductSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductSize.CornerRadius = 1;
            this.ProductSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductSize.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.ProductSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProductSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductSize.IntegerValue = ((long)(0));
            this.ProductSize.Location = new System.Drawing.Point(403, 132);
            this.ProductSize.MaxValue = ((long)(100000));
            this.ProductSize.MinimumSize = new System.Drawing.Size(12, 8);
            this.ProductSize.MinValue = ((long)(0));
            this.ProductSize.Name = "ProductSize";
            this.ProductSize.NegativeSign = "";
            this.ProductSize.NumberGroupSeparator = "";
            this.ProductSize.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProductSize.Size = new System.Drawing.Size(115, 25);
            this.ProductSize.TabIndex = 1;
            this.ProductSize.ThemeName = "Default";
            this.ProductSize.ThemesEnabled = false;
            this.ProductSize.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // Supplier
            // 
            this.Supplier.BackColor = System.Drawing.Color.White;
            this.Supplier.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.Supplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Supplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Supplier.CanOverrideStyle = true;
            this.Supplier.CausesValidation = false;
            this.Supplier.CornerRadius = 1;
            this.Supplier.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Supplier.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.Supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Supplier.Location = new System.Drawing.Point(288, 237);
            this.Supplier.MaxLength = 2000;
            this.Supplier.MinimumSize = new System.Drawing.Size(16, 12);
            this.Supplier.Name = "Supplier";
            this.Supplier.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.Supplier.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.Supplier.Size = new System.Drawing.Size(602, 25);
            this.Supplier.TabIndex = 3;
            this.Supplier.Tag = "";
            this.Supplier.ThemeName = "Default";
            this.Supplier.ThemesEnabled = false;
            // 
            // SupplierTitle
            // 
            this.SupplierTitle.AutoSize = true;
            this.SupplierTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.SupplierTitle.Location = new System.Drawing.Point(285, 221);
            this.SupplierTitle.Name = "SupplierTitle";
            this.SupplierTitle.Size = new System.Drawing.Size(76, 17);
            this.SupplierTitle.TabIndex = 81;
            this.SupplierTitle.Text = "Fornecedor:";
            // 
            // ProductCode
            // 
            this.ProductCode.BackGroundColor = System.Drawing.Color.White;
            this.ProductCode.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.ProductCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCode.CornerRadius = 1;
            this.ProductCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductCode.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.ProductCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProductCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductCode.IntegerValue = ((long)(0));
            this.ProductCode.Location = new System.Drawing.Point(288, 132);
            this.ProductCode.MaxValue = ((long)(100000));
            this.ProductCode.MinimumSize = new System.Drawing.Size(12, 8);
            this.ProductCode.MinValue = ((long)(0));
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.NegativeSign = "";
            this.ProductCode.NumberGroupSeparator = "";
            this.ProductCode.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProductCode.Size = new System.Drawing.Size(111, 25);
            this.ProductCode.TabIndex = 0;
            this.ProductCode.ThemeName = "Default";
            this.ProductCode.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // ProductReference
            // 
            this.ProductReference.BackGroundColor = System.Drawing.Color.White;
            this.ProductReference.BeforeTouchSize = new System.Drawing.Size(94, 25);
            this.ProductReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ProductReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductReference.CornerRadius = 1;
            this.ProductReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductReference.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.ProductReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProductReference.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductReference.IntegerValue = ((long)(0));
            this.ProductReference.Location = new System.Drawing.Point(522, 132);
            this.ProductReference.MaxValue = ((long)(100000));
            this.ProductReference.MinimumSize = new System.Drawing.Size(12, 8);
            this.ProductReference.MinValue = ((long)(0));
            this.ProductReference.Name = "ProductReference";
            this.ProductReference.NegativeSign = "";
            this.ProductReference.NumberGroupSeparator = "";
            this.ProductReference.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ProductReference.Size = new System.Drawing.Size(115, 25);
            this.ProductReference.TabIndex = 2;
            this.ProductReference.ThemeName = "Default";
            this.ProductReference.ThemesEnabled = false;
            this.ProductReference.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // ClearFields
            // 
            this.ClearFields.ActiveBorderThickness = 1;
            this.ClearFields.ActiveCornerRadius = 10;
            this.ClearFields.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ClearFields.ActiveForecolor = System.Drawing.Color.White;
            this.ClearFields.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ClearFields.BackColor = System.Drawing.Color.White;
            this.ClearFields.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearFields.BackgroundImage")));
            this.ClearFields.ButtonText = "Limpar";
            this.ClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearFields.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.ForeColor = System.Drawing.Color.SeaGreen;
            this.ClearFields.IdleBorderThickness = 1;
            this.ClearFields.IdleCornerRadius = 10;
            this.ClearFields.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.ClearFields.IdleForecolor = System.Drawing.Color.White;
            this.ClearFields.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.ClearFields.Location = new System.Drawing.Point(387, 553);
            this.ClearFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(97, 43);
            this.ClearFields.TabIndex = 213;
            this.ClearFields.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click_1);
            // 
            // Save
            // 
            this.Save.ActiveBorderThickness = 1;
            this.Save.ActiveCornerRadius = 10;
            this.Save.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.Save.ActiveForecolor = System.Drawing.Color.White;
            this.Save.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.ButtonText = "Salvar";
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.Save.IdleBorderThickness = 1;
            this.Save.IdleCornerRadius = 10;
            this.Save.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.Save.IdleForecolor = System.Drawing.Color.White;
            this.Save.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.Save.Location = new System.Drawing.Point(288, 553);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 43);
            this.Save.TabIndex = 212;
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddNewProductCategory
            // 
            this.AddNewProductCategory.AutoSize = true;
            this.AddNewProductCategory.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.AddNewProductCategory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.AddNewProductCategory.Location = new System.Drawing.Point(794, 164);
            this.AddNewProductCategory.Name = "AddNewProductCategory";
            this.AddNewProductCategory.Size = new System.Drawing.Size(96, 17);
            this.AddNewProductCategory.TabIndex = 216;
            this.AddNewProductCategory.TabStop = true;
            this.AddNewProductCategory.Text = "Cadastrar Novo";
            this.AddNewProductCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewProductCategory_LinkClicked);
            // 
            // BoxProductCategoryList
            // 
            this.BoxProductCategoryList.BackColor = System.Drawing.Color.White;
            this.BoxProductCategoryList.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.BoxProductCategoryList.FormattingEnabled = true;
            this.BoxProductCategoryList.Location = new System.Drawing.Point(288, 184);
            this.BoxProductCategoryList.Name = "BoxProductCategoryList";
            this.BoxProductCategoryList.Size = new System.Drawing.Size(601, 26);
            this.BoxProductCategoryList.TabIndex = 215;
            // 
            // LblStockDestination
            // 
            this.LblStockDestination.AutoSize = true;
            this.LblStockDestination.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblStockDestination.ForeColor = System.Drawing.Color.Black;
            this.LblStockDestination.Location = new System.Drawing.Point(285, 165);
            this.LblStockDestination.Name = "LblStockDestination";
            this.LblStockDestination.Size = new System.Drawing.Size(68, 17);
            this.LblStockDestination.TabIndex = 214;
            this.LblStockDestination.Text = "Categoria:";
            // 
            // ImageProduct
            // 
            this.ImageProduct.Image = global::DimStock.Properties.Resources.FotoNothing;
            this.ImageProduct.IndentificationPhotoNumber = "";
            this.ImageProduct.Location = new System.Drawing.Point(7, 14);
            this.ImageProduct.Name = "ImageProduct";
            this.ImageProduct.PathOfLastSelectedPhoto = "";
            this.ImageProduct.SelectedDirectory = null;
            this.ImageProduct.Size = new System.Drawing.Size(176, 188);
            this.ImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageProduct.TabIndex = 82;
            this.ImageProduct.TabStop = false;
            this.ImageProduct.Click += new System.EventHandler(this.ImageProduct_Click);
            // 
            // ProductRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 681);
            this.Controls.Add(this.AddNewProductCategory);
            this.Controls.Add(this.BoxProductCategoryList);
            this.Controls.Add(this.LblStockDestination);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ProductReference);
            this.Controls.Add(this.ProductCode);
            this.Controls.Add(this.Supplier);
            this.Controls.Add(this.SupplierTitle);
            this.Controls.Add(this.ProductSize);
            this.Controls.Add(this.MinStock);
            this.Controls.Add(this.MinStockTitle);
            this.Controls.Add(this.CodeTitle);
            this.Controls.Add(this.BarCode);
            this.Controls.Add(this.SalePrice);
            this.Controls.Add(this.CostPrice);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.BarCodeTitle);
            this.Controls.Add(this.SalePriceTitle);
            this.Controls.Add(this.CostPriceTitle);
            this.Controls.Add(this.DescriptionTitle);
            this.Controls.Add(this.MaxStock);
            this.Controls.Add(this.MaxStockTitle);
            this.Controls.Add(this.FrameProductPhoto);
            this.Controls.Add(this.ReferenceTitle);
            this.Controls.Add(this.SizeTitle);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "ProductRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.BarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).EndInit();
            this.FrameProductPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BarCodeTitle;
        private System.Windows.Forms.Label SalePriceTitle;
        private System.Windows.Forms.Label CostPriceTitle;
        private System.Windows.Forms.Label DescriptionTitle;
        private System.Windows.Forms.Label ReferenceTitle;
        private System.Windows.Forms.Label SizeTitle;
        private System.Windows.Forms.GroupBox FrameProductPhoto;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt BarCode;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox SalePrice;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox CostPrice;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt Description;
        private System.Windows.Forms.Label CodeTitle;
        private System.Windows.Forms.Label MinStockTitle;
        private System.Windows.Forms.Label MaxStockTitle;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox MinStock;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox MaxStock;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox ProductSize;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt Supplier;
        private System.Windows.Forms.Label SupplierTitle;
        public DimStock.Controls.CustomPictureBoxOne ImageProduct;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox ProductCode;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox ProductReference;
        private Bunifu.Framework.UI.BunifuThinButton2 ClearFields;
        private Bunifu.Framework.UI.BunifuThinButton2 Save;
        private System.Windows.Forms.LinkLabel AddNewProductCategory;
        private System.Windows.Forms.ComboBox BoxProductCategoryList;
        public System.Windows.Forms.Label LblStockDestination;
    }
}