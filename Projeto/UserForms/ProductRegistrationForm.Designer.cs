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
            this.TextBarCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TextSalePrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextCostPrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.BarCodeTitle = new System.Windows.Forms.Label();
            this.SalePriceTitle = new System.Windows.Forms.Label();
            this.CostPriceTitle = new System.Windows.Forms.Label();
            this.DescriptionTitle = new System.Windows.Forms.Label();
            this.FrameProductPhoto = new System.Windows.Forms.GroupBox();
            this.PictureImageProduct = new DimStock.Controls.CustomPictureBoxOne();
            this.ButtonClearFields = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonShow_CategoryRegistrationForm = new System.Windows.Forms.LinkLabel();
            this.ComboBoxCategoryList = new System.Windows.Forms.ComboBox();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.ListviewCategory = new System.Windows.Forms.ListView();
            this.ColumnCategoryId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColumnProductCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.TextInternalCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TextBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextDescription)).BeginInit();
            this.FrameProductPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureImageProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextInternalCode)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBarCode
            // 
            this.TextBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBarCode.BackColor = System.Drawing.Color.White;
            this.TextBarCode.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextBarCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBarCode.CanOverrideStyle = true;
            this.TextBarCode.CausesValidation = false;
            this.TextBarCode.CornerRadius = 1;
            this.TextBarCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBarCode.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextBarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextBarCode.Location = new System.Drawing.Point(262, 277);
            this.TextBarCode.MaxLength = 50;
            this.TextBarCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextBarCode.Name = "TextBarCode";
            this.TextBarCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextBarCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextBarCode.Size = new System.Drawing.Size(599, 27);
            this.TextBarCode.TabIndex = 5;
            this.TextBarCode.ThemeName = "Default";
            this.TextBarCode.ThemesEnabled = false;
            // 
            // TextSalePrice
            // 
            this.TextSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextSalePrice.BackGroundColor = System.Drawing.Color.White;
            this.TextSalePrice.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextSalePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.TextSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextSalePrice.Location = new System.Drawing.Point(262, 221);
            this.TextSalePrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSalePrice.Name = "TextSalePrice";
            this.TextSalePrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextSalePrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextSalePrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextSalePrice.Size = new System.Drawing.Size(188, 27);
            this.TextSalePrice.TabIndex = 4;
            this.TextSalePrice.Text = "R$ 0,00";
            this.TextSalePrice.ThemeName = "Default";
            this.TextSalePrice.ThemesEnabled = false;
            this.TextSalePrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // TextCostPrice
            // 
            this.TextCostPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextCostPrice.BackGroundColor = System.Drawing.Color.White;
            this.TextCostPrice.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextCostPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            this.TextCostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextCostPrice.Location = new System.Drawing.Point(262, 164);
            this.TextCostPrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextCostPrice.Name = "TextCostPrice";
            this.TextCostPrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextCostPrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextCostPrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextCostPrice.Size = new System.Drawing.Size(188, 27);
            this.TextCostPrice.TabIndex = 3;
            this.TextCostPrice.Text = "R$ 0,00";
            this.TextCostPrice.ThemeName = "Default";
            this.TextCostPrice.ThemesEnabled = false;
            this.TextCostPrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // TextDescription
            // 
            this.TextDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextDescription.BackColor = System.Drawing.Color.White;
            this.TextDescription.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDescription.CanOverrideStyle = true;
            this.TextDescription.CausesValidation = false;
            this.TextDescription.CornerRadius = 1;
            this.TextDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextDescription.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextDescription.Location = new System.Drawing.Point(399, 48);
            this.TextDescription.MaxLength = 2000;
            this.TextDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextDescription.Size = new System.Drawing.Size(466, 27);
            this.TextDescription.TabIndex = 1;
            this.TextDescription.Tag = "";
            this.TextDescription.ThemeName = "Default";
            this.TextDescription.ThemesEnabled = false;
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
            this.FrameProductPhoto.Controls.Add(this.PictureImageProduct);
            this.FrameProductPhoto.Location = new System.Drawing.Point(53, 48);
            this.FrameProductPhoto.Name = "FrameProductPhoto";
            this.FrameProductPhoto.Size = new System.Drawing.Size(189, 210);
            this.FrameProductPhoto.TabIndex = 75;
            this.FrameProductPhoto.TabStop = false;
            // 
            // PictureImageProduct
            // 
            this.PictureImageProduct.Image = global::DimStock.Properties.Resources.FotoNothing;
            this.PictureImageProduct.ImageId = "";
            this.PictureImageProduct.Location = new System.Drawing.Point(7, 14);
            this.PictureImageProduct.Name = "PictureImageProduct";
            this.PictureImageProduct.PathOfLastSelectedImage = "";
            this.PictureImageProduct.SelectedDirectory = null;
            this.PictureImageProduct.Size = new System.Drawing.Size(176, 188);
            this.PictureImageProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureImageProduct.TabIndex = 82;
            this.PictureImageProduct.TabStop = false;
            this.PictureImageProduct.Click += new System.EventHandler(this.PictureImageProduct_Click);
            // 
            // ButtonClearFields
            // 
            this.ButtonClearFields.ActiveBorderThickness = 1;
            this.ButtonClearFields.ActiveCornerRadius = 10;
            this.ButtonClearFields.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonClearFields.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonClearFields.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonClearFields.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClearFields.BackColor = System.Drawing.Color.White;
            this.ButtonClearFields.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonClearFields.BackgroundImage")));
            this.ButtonClearFields.ButtonText = "Limpar";
            this.ButtonClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClearFields.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearFields.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonClearFields.IdleBorderThickness = 1;
            this.ButtonClearFields.IdleCornerRadius = 10;
            this.ButtonClearFields.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonClearFields.IdleForecolor = System.Drawing.Color.White;
            this.ButtonClearFields.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonClearFields.Location = new System.Drawing.Point(362, 312);
            this.ButtonClearFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonClearFields.Name = "ButtonClearFields";
            this.ButtonClearFields.Size = new System.Drawing.Size(97, 43);
            this.ButtonClearFields.TabIndex = 213;
            this.ButtonClearFields.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonClearFields.Click += new System.EventHandler(this.ButtonClearFields_Click_1);
            // 
            // ButtonSave
            // 
            this.ButtonSave.ActiveBorderThickness = 1;
            this.ButtonSave.ActiveCornerRadius = 10;
            this.ButtonSave.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonSave.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonSave.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSave.BackColor = System.Drawing.Color.White;
            this.ButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.BackgroundImage")));
            this.ButtonSave.ButtonText = "Salvar";
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonSave.IdleBorderThickness = 1;
            this.ButtonSave.IdleCornerRadius = 10;
            this.ButtonSave.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSave.IdleForecolor = System.Drawing.Color.White;
            this.ButtonSave.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSave.Location = new System.Drawing.Point(263, 312);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 43);
            this.ButtonSave.TabIndex = 212;
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonShow_CategoryRegistrationForm
            // 
            this.ButtonShow_CategoryRegistrationForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonShow_CategoryRegistrationForm.AutoSize = true;
            this.ButtonShow_CategoryRegistrationForm.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.ButtonShow_CategoryRegistrationForm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonShow_CategoryRegistrationForm.Location = new System.Drawing.Point(770, 86);
            this.ButtonShow_CategoryRegistrationForm.Name = "ButtonShow_CategoryRegistrationForm";
            this.ButtonShow_CategoryRegistrationForm.Size = new System.Drawing.Size(96, 17);
            this.ButtonShow_CategoryRegistrationForm.TabIndex = 216;
            this.ButtonShow_CategoryRegistrationForm.TabStop = true;
            this.ButtonShow_CategoryRegistrationForm.Text = "Cadastrar Nova";
            this.ButtonShow_CategoryRegistrationForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonShow_GategoryRegistrationForm_LinkClicked);
            // 
            // ComboBoxCategoryList
            // 
            this.ComboBoxCategoryList.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ComboBoxCategoryList.BackColor = System.Drawing.Color.White;
            this.ComboBoxCategoryList.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.ComboBoxCategoryList.FormattingEnabled = true;
            this.ComboBoxCategoryList.Location = new System.Drawing.Point(264, 105);
            this.ComboBoxCategoryList.Name = "ComboBoxCategoryList";
            this.ComboBoxCategoryList.Size = new System.Drawing.Size(601, 27);
            this.ComboBoxCategoryList.TabIndex = 215;
            this.ComboBoxCategoryList.Click += new System.EventHandler(this.ComboBoxCategoryList_Click);
            this.ComboBoxCategoryList.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxCategoryList_KeyPress);
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
            // TextInternalCode
            // 
            this.TextInternalCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextInternalCode.BackColor = System.Drawing.Color.White;
            this.TextInternalCode.BeforeTouchSize = new System.Drawing.Size(466, 27);
            this.TextInternalCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextInternalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextInternalCode.CanOverrideStyle = true;
            this.TextInternalCode.CausesValidation = false;
            this.TextInternalCode.CornerRadius = 1;
            this.TextInternalCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextInternalCode.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextInternalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextInternalCode.Location = new System.Drawing.Point(263, 48);
            this.TextInternalCode.MaxLength = 2000;
            this.TextInternalCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextInternalCode.Name = "TextInternalCode";
            this.TextInternalCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextInternalCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextInternalCode.Size = new System.Drawing.Size(130, 27);
            this.TextInternalCode.TabIndex = 0;
            this.TextInternalCode.Tag = "";
            this.TextInternalCode.ThemeName = "Default";
            this.TextInternalCode.ThemesEnabled = false;
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
            this.Controls.Add(this.TextInternalCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListviewCategory);
            this.Controls.Add(this.ButtonShow_CategoryRegistrationForm);
            this.Controls.Add(this.ComboBoxCategoryList);
            this.Controls.Add(this.LblStockDestination);
            this.Controls.Add(this.ButtonClearFields);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.TextBarCode);
            this.Controls.Add(this.TextSalePrice);
            this.Controls.Add(this.TextCostPrice);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.BarCodeTitle);
            this.Controls.Add(this.SalePriceTitle);
            this.Controls.Add(this.CostPriceTitle);
            this.Controls.Add(this.DescriptionTitle);
            this.Controls.Add(this.FrameProductPhoto);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "ProductRegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Click += new System.EventHandler(this.ProductRegistrationForm_Click);
            ((System.ComponentModel.ISupportInitialize)(this.TextBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextDescription)).EndInit();
            this.FrameProductPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureImageProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextInternalCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label BarCodeTitle;
        private System.Windows.Forms.Label SalePriceTitle;
        private System.Windows.Forms.Label CostPriceTitle;
        private System.Windows.Forms.Label DescriptionTitle;
        private System.Windows.Forms.GroupBox FrameProductPhoto;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextBarCode;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextSalePrice;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextCostPrice;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextDescription;
        public DimStock.Controls.CustomPictureBoxOne PictureImageProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonClearFields;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonSave;
        private System.Windows.Forms.LinkLabel ButtonShow_CategoryRegistrationForm;
        public System.Windows.Forms.Label LblStockDestination;
        private System.Windows.Forms.ListView ListviewCategory;
        private System.Windows.Forms.ColumnHeader ColumnProductCategory;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.ColumnHeader ColumnCategoryId;
        public System.Windows.Forms.ComboBox ComboBoxCategoryList;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextInternalCode;
        private System.Windows.Forms.Label label1;
    }
}