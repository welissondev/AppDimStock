namespace DimStock.View
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
            this.ClearFields = new Syncfusion.WinForms.Controls.SfButton();
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
            this.ProductPhoto = new DimStock.Auxiliary.AxlPictureBox();
            this.RegisterNew = new Syncfusion.WinForms.Controls.SfButton();
            this.CodeTitle = new System.Windows.Forms.Label();
            this.MinStockTitle = new System.Windows.Forms.Label();
            this.MaxStockTitle = new System.Windows.Forms.Label();
            this.MinStock = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.MaxStock = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.ProductSize = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.Supplier = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SupplierTitle = new System.Windows.Forms.Label();
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DayOfTheWeek = new System.Windows.Forms.Label();
            this.FormCaption = new System.Windows.Forms.Label();
            this.ProductCode = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.ProductReference = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).BeginInit();
            this.FrameProductPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier)).BeginInit();
            this.PanelUpperHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductReference)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearFields
            // 
            this.ClearFields.AccessibleName = "Button";
            this.ClearFields.BackColor = System.Drawing.Color.SeaGreen;
            this.ClearFields.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.ForeColor = System.Drawing.Color.White;
            this.ClearFields.Location = new System.Drawing.Point(102, 50);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(80, 35);
            this.ClearFields.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.ClearFields.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.ClearFields.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.ClearFields.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.ClearFields.Style.FocusedForeColor = System.Drawing.Color.White;
            this.ClearFields.Style.ForeColor = System.Drawing.Color.White;
            this.ClearFields.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ClearFields.Style.HoverForeColor = System.Drawing.Color.Black;
            this.ClearFields.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.ClearFields.Style.PressedForeColor = System.Drawing.Color.White;
            this.ClearFields.TabIndex = 11;
            this.ClearFields.Text = "Limpar";
            this.ClearFields.UseVisualStyleBackColor = false;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // BarCode
            // 
            this.BarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BarCode.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.BarCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.BarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarCode.CanOverrideStyle = true;
            this.BarCode.CausesValidation = false;
            this.BarCode.CornerRadius = 4;
            this.BarCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BarCode.Location = new System.Drawing.Point(246, 515);
            this.BarCode.MaxLength = 50;
            this.BarCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.BarCode.Name = "BarCode";
            this.BarCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.BarCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.BarCode.Size = new System.Drawing.Size(599, 26);
            this.BarCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.BarCode.TabIndex = 9;
            this.BarCode.ThemeName = "Office2016White";
            // 
            // SalePrice
            // 
            this.SalePrice.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SalePrice.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.SalePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.SalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SalePrice.CanOverrideStyle = true;
            this.SalePrice.CausesValidation = false;
            this.SalePrice.CornerRadius = 4;
            this.SalePrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SalePrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.SalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SalePrice.Location = new System.Drawing.Point(246, 456);
            this.SalePrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.SalePrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.SalePrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SalePrice.Size = new System.Drawing.Size(188, 26);
            this.SalePrice.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.SalePrice.TabIndex = 8;
            this.SalePrice.Text = "R$ 0,00";
            this.SalePrice.ThemeName = "Office2016White";
            this.SalePrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // CostPrice
            // 
            this.CostPrice.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CostPrice.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.CostPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.CostPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CostPrice.CanOverrideStyle = true;
            this.CostPrice.CausesValidation = false;
            this.CostPrice.CornerRadius = 4;
            this.CostPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CostPrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.CostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CostPrice.Location = new System.Drawing.Point(246, 402);
            this.CostPrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.CostPrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.CostPrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CostPrice.Size = new System.Drawing.Size(188, 26);
            this.CostPrice.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.CostPrice.TabIndex = 7;
            this.CostPrice.Text = "R$ 0,00";
            this.CostPrice.ThemeName = "Office2016White";
            this.CostPrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Description.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.Description.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description.CanOverrideStyle = true;
            this.Description.CausesValidation = false;
            this.Description.CornerRadius = 4;
            this.Description.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Description.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Description.Location = new System.Drawing.Point(246, 286);
            this.Description.MaxLength = 2000;
            this.Description.MinimumSize = new System.Drawing.Size(16, 12);
            this.Description.Name = "Description";
            this.Description.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.Description.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Description.Size = new System.Drawing.Size(599, 26);
            this.Description.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.Description.TabIndex = 4;
            this.Description.Tag = "";
            this.Description.ThemeName = "Office2016White";
            // 
            // BarCodeTitle
            // 
            this.BarCodeTitle.AutoSize = true;
            this.BarCodeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BarCodeTitle.Location = new System.Drawing.Point(243, 496);
            this.BarCodeTitle.Name = "BarCodeTitle";
            this.BarCodeTitle.Size = new System.Drawing.Size(117, 16);
            this.BarCodeTitle.TabIndex = 64;
            this.BarCodeTitle.Text = "Código de Barras:";
            // 
            // SalePriceTitle
            // 
            this.SalePriceTitle.AutoSize = true;
            this.SalePriceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalePriceTitle.Location = new System.Drawing.Point(246, 440);
            this.SalePriceTitle.Name = "SalePriceTitle";
            this.SalePriceTitle.Size = new System.Drawing.Size(90, 16);
            this.SalePriceTitle.TabIndex = 63;
            this.SalePriceTitle.Text = "Preço Venda:";
            // 
            // CostPriceTitle
            // 
            this.CostPriceTitle.AutoSize = true;
            this.CostPriceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostPriceTitle.Location = new System.Drawing.Point(246, 383);
            this.CostPriceTitle.Name = "CostPriceTitle";
            this.CostPriceTitle.Size = new System.Drawing.Size(84, 16);
            this.CostPriceTitle.TabIndex = 62;
            this.CostPriceTitle.Text = "Preço Custo:";
            // 
            // DescriptionTitle
            // 
            this.DescriptionTitle.AutoSize = true;
            this.DescriptionTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTitle.Location = new System.Drawing.Point(246, 270);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(73, 16);
            this.DescriptionTitle.TabIndex = 61;
            this.DescriptionTitle.Text = "Descrição:";
            // 
            // ReferenceTitle
            // 
            this.ReferenceTitle.AutoSize = true;
            this.ReferenceTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReferenceTitle.Location = new System.Drawing.Point(481, 144);
            this.ReferenceTitle.Name = "ReferenceTitle";
            this.ReferenceTitle.Size = new System.Drawing.Size(87, 16);
            this.ReferenceTitle.TabIndex = 60;
            this.ReferenceTitle.Text = "Referência**:";
            // 
            // SizeTitle
            // 
            this.SizeTitle.AutoSize = true;
            this.SizeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SizeTitle.Location = new System.Drawing.Point(360, 144);
            this.SizeTitle.Name = "SizeTitle";
            this.SizeTitle.Size = new System.Drawing.Size(104, 16);
            this.SizeTitle.TabIndex = 59;
            this.SizeTitle.Text = "Taman. Núm. **:";
            // 
            // FrameProductPhoto
            // 
            this.FrameProductPhoto.BackColor = System.Drawing.Color.White;
            this.FrameProductPhoto.Controls.Add(this.ProductPhoto);
            this.FrameProductPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FrameProductPhoto.Location = new System.Drawing.Point(41, 142);
            this.FrameProductPhoto.Name = "FrameProductPhoto";
            this.FrameProductPhoto.Size = new System.Drawing.Size(189, 210);
            this.FrameProductPhoto.TabIndex = 75;
            this.FrameProductPhoto.TabStop = false;
            this.FrameProductPhoto.Text = "Foto Produto";
            // 
            // ProductPhoto
            // 
            this.ProductPhoto.Image = global::DimStock.Properties.Resources.FotoNothing;
            this.ProductPhoto.IndentificationPhotoNumber = "";
            this.ProductPhoto.Location = new System.Drawing.Point(7, 14);
            this.ProductPhoto.Name = "ProductPhoto";
            this.ProductPhoto.PathOfLastSelectedPhoto = "";
            this.ProductPhoto.SelectedDirectory = null;
            this.ProductPhoto.Size = new System.Drawing.Size(176, 188);
            this.ProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProductPhoto.TabIndex = 82;
            this.ProductPhoto.TabStop = false;
            this.ProductPhoto.Click += new System.EventHandler(this.ProductPhoto_Click);
            // 
            // RegisterNew
            // 
            this.RegisterNew.AccessibleName = "Button";
            this.RegisterNew.BackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNew.ForeColor = System.Drawing.Color.White;
            this.RegisterNew.Location = new System.Drawing.Point(19, 50);
            this.RegisterNew.Name = "RegisterNew";
            this.RegisterNew.Size = new System.Drawing.Size(80, 35);
            this.RegisterNew.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.FocusedForeColor = System.Drawing.Color.White;
            this.RegisterNew.Style.ForeColor = System.Drawing.Color.White;
            this.RegisterNew.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Style.HoverForeColor = System.Drawing.Color.Black;
            this.RegisterNew.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.PressedForeColor = System.Drawing.Color.White;
            this.RegisterNew.TabIndex = 10;
            this.RegisterNew.Text = "Salvar";
            this.RegisterNew.UseVisualStyleBackColor = false;
            this.RegisterNew.Click += new System.EventHandler(this.RegisterNew_Click);
            // 
            // CodeTitle
            // 
            this.CodeTitle.AutoSize = true;
            this.CodeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeTitle.Location = new System.Drawing.Point(246, 144);
            this.CodeTitle.Name = "CodeTitle";
            this.CodeTitle.Size = new System.Drawing.Size(71, 16);
            this.CodeTitle.TabIndex = 76;
            this.CodeTitle.Text = "Cód. Prod:";
            // 
            // MinStockTitle
            // 
            this.MinStockTitle.AutoSize = true;
            this.MinStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinStockTitle.Location = new System.Drawing.Point(246, 326);
            this.MinStockTitle.Name = "MinStockTitle";
            this.MinStockTitle.Size = new System.Drawing.Size(59, 16);
            this.MinStockTitle.TabIndex = 80;
            this.MinStockTitle.Text = "Qtd. Min:";
            // 
            // MaxStockTitle
            // 
            this.MaxStockTitle.AutoSize = true;
            this.MaxStockTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxStockTitle.Location = new System.Drawing.Point(338, 328);
            this.MaxStockTitle.Name = "MaxStockTitle";
            this.MaxStockTitle.Size = new System.Drawing.Size(63, 16);
            this.MaxStockTitle.TabIndex = 79;
            this.MaxStockTitle.Text = "Qtd. Max:";
            // 
            // MinStock
            // 
            this.MinStock.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MinStock.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.MinStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.MinStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MinStock.CornerRadius = 4;
            this.MinStock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MinStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MinStock.IntegerValue = ((long)(0));
            this.MinStock.Location = new System.Drawing.Point(246, 343);
            this.MinStock.MaxValue = ((long)(50000));
            this.MinStock.MinimumSize = new System.Drawing.Size(12, 8);
            this.MinStock.Name = "MinStock";
            this.MinStock.NumberGroupSeparator = "";
            this.MinStock.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MinStock.Size = new System.Drawing.Size(90, 26);
            this.MinStock.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.MinStock.TabIndex = 5;
            this.MinStock.ThemeName = "Office2016White";
            this.MinStock.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // MaxStock
            // 
            this.MaxStock.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MaxStock.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.MaxStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.MaxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MaxStock.CornerRadius = 4;
            this.MaxStock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MaxStock.IntegerValue = ((long)(0));
            this.MaxStock.Location = new System.Drawing.Point(342, 343);
            this.MaxStock.MaxValue = ((long)(50000));
            this.MaxStock.MinimumSize = new System.Drawing.Size(12, 8);
            this.MaxStock.Name = "MaxStock";
            this.MaxStock.NumberGroupSeparator = "";
            this.MaxStock.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString;
            this.MaxStock.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MaxStock.Size = new System.Drawing.Size(92, 26);
            this.MaxStock.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.MaxStock.TabIndex = 6;
            this.MaxStock.ThemeName = "Office2016White";
            this.MaxStock.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // ProductSize
            // 
            this.ProductSize.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductSize.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.ProductSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ProductSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductSize.CornerRadius = 4;
            this.ProductSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ProductSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductSize.IntegerValue = ((long)(0));
            this.ProductSize.Location = new System.Drawing.Point(364, 160);
            this.ProductSize.MaxValue = ((long)(100000));
            this.ProductSize.MinimumSize = new System.Drawing.Size(12, 8);
            this.ProductSize.MinValue = ((long)(0));
            this.ProductSize.Name = "ProductSize";
            this.ProductSize.NegativeSign = "";
            this.ProductSize.NumberGroupSeparator = "";
            this.ProductSize.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ProductSize.Size = new System.Drawing.Size(115, 26);
            this.ProductSize.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.ProductSize.TabIndex = 1;
            this.ProductSize.ThemeName = "Office2016White";
            this.ProductSize.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // Supplier
            // 
            this.Supplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Supplier.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.Supplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.Supplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Supplier.CanOverrideStyle = true;
            this.Supplier.CausesValidation = false;
            this.Supplier.CornerRadius = 4;
            this.Supplier.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Supplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Supplier.Location = new System.Drawing.Point(249, 222);
            this.Supplier.MaxLength = 2000;
            this.Supplier.MinimumSize = new System.Drawing.Size(16, 12);
            this.Supplier.Name = "Supplier";
            this.Supplier.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.Supplier.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Supplier.Size = new System.Drawing.Size(599, 26);
            this.Supplier.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.Supplier.TabIndex = 3;
            this.Supplier.Tag = "";
            this.Supplier.ThemeName = "Office2016White";
            // 
            // SupplierTitle
            // 
            this.SupplierTitle.AutoSize = true;
            this.SupplierTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SupplierTitle.Location = new System.Drawing.Point(246, 206);
            this.SupplierTitle.Name = "SupplierTitle";
            this.SupplierTitle.Size = new System.Drawing.Size(81, 16);
            this.SupplierTitle.TabIndex = 81;
            this.SupplierTitle.Text = "Fornecedor:";
            // 
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.DayOfTheWeek);
            this.PanelUpperHorizontal.Controls.Add(this.FormCaption);
            this.PanelUpperHorizontal.Controls.Add(this.ClearFields);
            this.PanelUpperHorizontal.Controls.Add(this.RegisterNew);
            this.PanelUpperHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpperHorizontal.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientTopLeft = System.Drawing.Color.Black;
            this.PanelUpperHorizontal.GradientTopRight = System.Drawing.Color.Black;
            this.PanelUpperHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PanelUpperHorizontal.Name = "PanelUpperHorizontal";
            this.PanelUpperHorizontal.Quality = 10;
            this.PanelUpperHorizontal.Size = new System.Drawing.Size(964, 99);
            this.PanelUpperHorizontal.TabIndex = 141;
            // 
            // DayOfTheWeek
            // 
            this.DayOfTheWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DayOfTheWeek.BackColor = System.Drawing.Color.Transparent;
            this.DayOfTheWeek.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayOfTheWeek.ForeColor = System.Drawing.Color.White;
            this.DayOfTheWeek.Location = new System.Drawing.Point(402, 26);
            this.DayOfTheWeek.Name = "DayOfTheWeek";
            this.DayOfTheWeek.Size = new System.Drawing.Size(556, 40);
            this.DayOfTheWeek.TabIndex = 139;
            this.DayOfTheWeek.Text = "DayOfTheWeek";
            this.DayOfTheWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCaption
            // 
            this.FormCaption.AutoSize = true;
            this.FormCaption.BackColor = System.Drawing.Color.Transparent;
            this.FormCaption.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCaption.ForeColor = System.Drawing.Color.White;
            this.FormCaption.Location = new System.Drawing.Point(10, 11);
            this.FormCaption.Name = "FormCaption";
            this.FormCaption.Size = new System.Drawing.Size(332, 40);
            this.FormCaption.TabIndex = 138;
            this.FormCaption.Text = "Cadastro de Produtos";
            // 
            // ProductCode
            // 
            this.ProductCode.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductCode.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.ProductCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ProductCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductCode.CornerRadius = 4;
            this.ProductCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ProductCode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductCode.IntegerValue = ((long)(0));
            this.ProductCode.Location = new System.Drawing.Point(249, 160);
            this.ProductCode.MaxValue = ((long)(100000));
            this.ProductCode.MinimumSize = new System.Drawing.Size(12, 8);
            this.ProductCode.MinValue = ((long)(0));
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.NegativeSign = "";
            this.ProductCode.NumberGroupSeparator = "";
            this.ProductCode.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ProductCode.Size = new System.Drawing.Size(111, 26);
            this.ProductCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.ProductCode.TabIndex = 0;
            this.ProductCode.ThemeName = "Office2016White";
            this.ProductCode.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // ProductReference
            // 
            this.ProductReference.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ProductReference.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.ProductReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.ProductReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ProductReference.CornerRadius = 4;
            this.ProductReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ProductReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ProductReference.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ProductReference.IntegerValue = ((long)(0));
            this.ProductReference.Location = new System.Drawing.Point(483, 160);
            this.ProductReference.MaxValue = ((long)(100000));
            this.ProductReference.MinimumSize = new System.Drawing.Size(12, 8);
            this.ProductReference.MinValue = ((long)(0));
            this.ProductReference.Name = "ProductReference";
            this.ProductReference.NegativeSign = "";
            this.ProductReference.NumberGroupSeparator = "";
            this.ProductReference.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ProductReference.Size = new System.Drawing.Size(115, 26);
            this.ProductReference.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.ProductReference.TabIndex = 2;
            this.ProductReference.ThemeName = "Office2016White";
            this.ProductReference.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // ProductRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.ProductReference);
            this.Controls.Add(this.ProductCode);
            this.Controls.Add(this.PanelUpperHorizontal);
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
            ((System.ComponentModel.ISupportInitialize)(this.ProductPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MaxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Supplier)).EndInit();
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductReference)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton ClearFields;
        private Syncfusion.WinForms.Controls.SfButton RegisterNew;
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
        public DimStock.Auxiliary.AxlPictureBox ProductPhoto;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        public System.Windows.Forms.Label DayOfTheWeek;
        public System.Windows.Forms.Label FormCaption;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox ProductCode;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox ProductReference;
    }
}