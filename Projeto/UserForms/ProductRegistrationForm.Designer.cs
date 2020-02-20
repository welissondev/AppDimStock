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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductRegistrationForm));
            this.BarCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SalePrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.CostPrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.Description = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.BarCodeTitle = new System.Windows.Forms.Label();
            this.SalePriceTitle = new System.Windows.Forms.Label();
            this.CostPriceTitle = new System.Windows.Forms.Label();
            this.DescriptionTitle = new System.Windows.Forms.Label();
            this.FrameProductPhoto = new System.Windows.Forms.GroupBox();
            this.ImageProduct = new DimStock.Controls.CustomPictureBoxOne();
            this.ClearFields = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddNewProductCategory = new System.Windows.Forms.LinkLabel();
            this.BoxProductCategoryList = new System.Windows.Forms.ComboBox();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.ListviewCategory = new System.Windows.Forms.ListView();
            this.ColumnCategoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnProductCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.InternalCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).BeginInit();
            this.FrameProductPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternalCode)).BeginInit();
            this.SuspendLayout();
            // 
            // BarCode
            // 
            this.BarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarCode.BackColor = System.Drawing.Color.White;
            this.BarCode.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.BarCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarCode.CanOverrideStyle = true;
            this.BarCode.CausesValidation = false;
            this.BarCode.CornerRadius = 1;
            this.BarCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BarCode.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.BarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.BarCode.Location = new System.Drawing.Point(262, 277);
            this.BarCode.MaxLength = 50;
            this.BarCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.BarCode.Name = "BarCode";
            this.BarCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.BarCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.BarCode.Size = new System.Drawing.Size(599, 27);
            this.BarCode.TabIndex = 5;
            this.BarCode.ThemeName = "Default";
            this.BarCode.ThemesEnabled = false;
            // 
            // SalePrice
            // 
            this.SalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalePrice.BackGroundColor = System.Drawing.Color.White;
            this.SalePrice.BeforeTouchSize = new System.Drawing.Size(466, 27);
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
            this.SalePrice.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.SalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SalePrice.Location = new System.Drawing.Point(262, 221);
            this.SalePrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.SalePrice.Name = "SalePrice";
            this.SalePrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.SalePrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.SalePrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.SalePrice.Size = new System.Drawing.Size(188, 27);
            this.SalePrice.TabIndex = 4;
            this.SalePrice.Text = "R$ 0,00";
            this.SalePrice.ThemeName = "Default";
            this.SalePrice.ThemesEnabled = false;
            this.SalePrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // CostPrice
            // 
            this.CostPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CostPrice.BackGroundColor = System.Drawing.Color.White;
            this.CostPrice.BeforeTouchSize = new System.Drawing.Size(466, 27);
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
            this.CostPrice.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.CostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CostPrice.Location = new System.Drawing.Point(262, 164);
            this.CostPrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.CostPrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.CostPrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.CostPrice.Size = new System.Drawing.Size(188, 27);
            this.CostPrice.TabIndex = 3;
            this.CostPrice.Text = "R$ 0,00";
            this.CostPrice.ThemeName = "Default";
            this.CostPrice.ThemesEnabled = false;
            this.CostPrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.Description.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description.CanOverrideStyle = true;
            this.Description.CausesValidation = false;
            this.Description.CornerRadius = 1;
            this.Description.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Description.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Description.Location = new System.Drawing.Point(399, 48);
            this.Description.MaxLength = 2000;
            this.Description.MinimumSize = new System.Drawing.Size(16, 12);
            this.Description.Name = "Description";
            this.Description.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.Description.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.Description.Size = new System.Drawing.Size(466, 27);
            this.Description.TabIndex = 1;
            this.Description.Tag = "";
            this.Description.ThemeName = "Default";
            this.Description.ThemesEnabled = false;
            // 
            // BarCodeTitle
            // 
            this.BarCodeTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BarCodeTitle.AutoSize = true;
            this.BarCodeTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.BarCodeTitle.Location = new System.Drawing.Point(259, 259);
            this.BarCodeTitle.Name = "BarCodeTitle";
            this.BarCodeTitle.Size = new System.Drawing.Size(108, 17);
            this.BarCodeTitle.TabIndex = 64;
            this.BarCodeTitle.Text = "Código de Barras:";
            // 
            // SalePriceTitle
            // 
            this.SalePriceTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SalePriceTitle.AutoSize = true;
            this.SalePriceTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.SalePriceTitle.Location = new System.Drawing.Point(259, 204);
            this.SalePriceTitle.Name = "SalePriceTitle";
            this.SalePriceTitle.Size = new System.Drawing.Size(82, 17);
            this.SalePriceTitle.TabIndex = 63;
            this.SalePriceTitle.Text = "Preço Venda:";
            // 
            // CostPriceTitle
            // 
            this.CostPriceTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CostPriceTitle.AutoSize = true;
            this.CostPriceTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.CostPriceTitle.Location = new System.Drawing.Point(259, 147);
            this.CostPriceTitle.Name = "CostPriceTitle";
            this.CostPriceTitle.Size = new System.Drawing.Size(79, 17);
            this.CostPriceTitle.TabIndex = 62;
            this.CostPriceTitle.Text = "Preço Custo:";
            // 
            // DescriptionTitle
            // 
            this.DescriptionTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionTitle.AutoSize = true;
            this.DescriptionTitle.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.DescriptionTitle.Location = new System.Drawing.Point(396, 31);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(67, 17);
            this.DescriptionTitle.TabIndex = 61;
            this.DescriptionTitle.Text = "Descrição:";
            // 
            // FrameProductPhoto
            // 
            this.FrameProductPhoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FrameProductPhoto.BackColor = System.Drawing.Color.White;
            this.FrameProductPhoto.Controls.Add(this.ImageProduct);
            this.FrameProductPhoto.Location = new System.Drawing.Point(53, 48);
            this.FrameProductPhoto.Name = "FrameProductPhoto";
            this.FrameProductPhoto.Size = new System.Drawing.Size(189, 210);
            this.FrameProductPhoto.TabIndex = 75;
            this.FrameProductPhoto.TabStop = false;
            // 
            // ImageProduct
            // 
            this.ImageProduct.Image = global::DimStock.Properties.Resources.FotoNothing;
            this.ImageProduct.ImageId = "";
            this.ImageProduct.Location = new System.Drawing.Point(7, 14);
            this.ImageProduct.Name = "ImageProduct";
            this.ImageProduct.PathOfLastSelectedImage = "";
            this.ImageProduct.SelectedDirectory = null;
            this.ImageProduct.Size = new System.Drawing.Size(176, 188);
            this.ImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageProduct.TabIndex = 82;
            this.ImageProduct.TabStop = false;
            this.ImageProduct.Click += new System.EventHandler(this.ImageProduct_Click);
            // 
            // ClearFields
            // 
            this.ClearFields.ActiveBorderThickness = 1;
            this.ClearFields.ActiveCornerRadius = 10;
            this.ClearFields.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ClearFields.ActiveForecolor = System.Drawing.Color.White;
            this.ClearFields.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ClearFields.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearFields.BackColor = System.Drawing.Color.White;
            this.ClearFields.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearFields.BackgroundImage")));
            this.ClearFields.ButtonText = "Limpar";
            this.ClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearFields.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.ForeColor = System.Drawing.Color.SeaGreen;
            this.ClearFields.IdleBorderThickness = 1;
            this.ClearFields.IdleCornerRadius = 10;
            this.ClearFields.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ClearFields.IdleForecolor = System.Drawing.Color.White;
            this.ClearFields.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ClearFields.Location = new System.Drawing.Point(362, 312);
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
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.ButtonText = "Salvar";
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.Save.IdleBorderThickness = 1;
            this.Save.IdleCornerRadius = 10;
            this.Save.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.Save.IdleForecolor = System.Drawing.Color.White;
            this.Save.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.Save.Location = new System.Drawing.Point(263, 312);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 43);
            this.Save.TabIndex = 212;
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // AddNewProductCategory
            // 
            this.AddNewProductCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddNewProductCategory.AutoSize = true;
            this.AddNewProductCategory.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.AddNewProductCategory.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.AddNewProductCategory.Location = new System.Drawing.Point(770, 86);
            this.AddNewProductCategory.Name = "AddNewProductCategory";
            this.AddNewProductCategory.Size = new System.Drawing.Size(96, 17);
            this.AddNewProductCategory.TabIndex = 216;
            this.AddNewProductCategory.TabStop = true;
            this.AddNewProductCategory.Text = "Cadastrar Nova";
            this.AddNewProductCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AddNewProductCategory_LinkClicked);
            // 
            // BoxProductCategoryList
            // 
            this.BoxProductCategoryList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxProductCategoryList.BackColor = System.Drawing.Color.White;
            this.BoxProductCategoryList.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.BoxProductCategoryList.FormattingEnabled = true;
            this.BoxProductCategoryList.Location = new System.Drawing.Point(264, 105);
            this.BoxProductCategoryList.Name = "BoxProductCategoryList";
            this.BoxProductCategoryList.Size = new System.Drawing.Size(601, 27);
            this.BoxProductCategoryList.TabIndex = 215;
            this.BoxProductCategoryList.Click += new System.EventHandler(this.BoxProductCategoryList_Click);
            this.BoxProductCategoryList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxProductCategoryList_KeyPress);
            // 
            // LblStockDestination
            // 
            this.LblStockDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblStockDestination.AutoSize = true;
            this.LblStockDestination.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblStockDestination.ForeColor = System.Drawing.Color.Black;
            this.LblStockDestination.Location = new System.Drawing.Point(261, 86);
            this.LblStockDestination.Name = "LblStockDestination";
            this.LblStockDestination.Size = new System.Drawing.Size(68, 17);
            this.LblStockDestination.TabIndex = 214;
            this.LblStockDestination.Text = "Categoria:";
            // 
            // ListviewCategory
            // 
            this.ListviewCategory.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListviewCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ListviewCategory.BackColor = System.Drawing.Color.White;
            this.ListviewCategory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListviewCategory.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnCategoryId,
            this.ColumnProductCategory});
            this.ListviewCategory.Font = new System.Drawing.Font("Calibri Light", 12.25F);
            this.ListviewCategory.FullRowSelect = true;
            this.ListviewCategory.GridLines = true;
            this.ListviewCategory.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ListviewCategory.HideSelection = false;
            this.ListviewCategory.HotTracking = true;
            this.ListviewCategory.HoverSelection = true;
            this.ListviewCategory.Location = new System.Drawing.Point(264, 130);
            this.ListviewCategory.MultiSelect = false;
            this.ListviewCategory.Name = "ListviewCategory";
            this.ListviewCategory.Size = new System.Drawing.Size(601, 10);
            this.ListviewCategory.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.ListviewCategory.TabIndex = 218;
            this.ListviewCategory.UseCompatibleStateImageBehavior = false;
            this.ListviewCategory.View = System.Windows.Forms.View.Details;
            this.ListviewCategory.Visible = false;
            this.ListviewCategory.DoubleClick += new System.EventHandler(this.ListviewCategory_DoubleClick);
            // 
            // ColumnCategoryId
            // 
            this.ColumnCategoryId.Width = 0;
            // 
            // ColumnProductCategory
            // 
            this.ColumnProductCategory.Text = "";
            this.ColumnProductCategory.Width = 580;
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 500;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // InternalCode
            // 
            this.InternalCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InternalCode.BackColor = System.Drawing.Color.White;
            this.InternalCode.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.InternalCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.InternalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.InternalCode.CanOverrideStyle = true;
            this.InternalCode.CausesValidation = false;
            this.InternalCode.CornerRadius = 1;
            this.InternalCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.InternalCode.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.InternalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.InternalCode.Location = new System.Drawing.Point(263, 48);
            this.InternalCode.MaxLength = 2000;
            this.InternalCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.InternalCode.Name = "InternalCode";
            this.InternalCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.InternalCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.InternalCode.Size = new System.Drawing.Size(130, 27);
            this.InternalCode.TabIndex = 0;
            this.InternalCode.Tag = "";
            this.InternalCode.ThemeName = "Default";
            this.InternalCode.ThemesEnabled = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.label1.Location = new System.Drawing.Point(261, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 220;
            this.label1.Text = "Código:";
            // 
            // ProductRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.InternalCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListviewCategory);
            this.Controls.Add(this.AddNewProductCategory);
            this.Controls.Add(this.BoxProductCategoryList);
            this.Controls.Add(this.LblStockDestination);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.BarCode);
            this.Controls.Add(this.SalePrice);
            this.Controls.Add(this.CostPrice);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.BarCodeTitle);
            this.Controls.Add(this.SalePriceTitle);
            this.Controls.Add(this.CostPriceTitle);
            this.Controls.Add(this.DescriptionTitle);
            this.Controls.Add(this.FrameProductPhoto);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "ProductRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.ProductRegistrationForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.BarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).EndInit();
            this.FrameProductPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternalCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BarCodeTitle;
        private System.Windows.Forms.Label SalePriceTitle;
        private System.Windows.Forms.Label CostPriceTitle;
        private System.Windows.Forms.Label DescriptionTitle;
        private System.Windows.Forms.GroupBox FrameProductPhoto;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt BarCode;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox SalePrice;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox CostPrice;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt Description;
        public DimStock.Controls.CustomPictureBoxOne ImageProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 ClearFields;
        private Bunifu.Framework.UI.BunifuThinButton2 Save;
        private System.Windows.Forms.LinkLabel AddNewProductCategory;
        public System.Windows.Forms.Label LblStockDestination;
        private System.Windows.Forms.ListView ListviewCategory;
        private System.Windows.Forms.ColumnHeader ColumnProductCategory;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.ColumnHeader ColumnCategoryId;
        public System.Windows.Forms.ComboBox BoxProductCategoryList;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt InternalCode;
        private System.Windows.Forms.Label label1;
    }
}