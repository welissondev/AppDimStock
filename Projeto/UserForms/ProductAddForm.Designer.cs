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
            this.ButtonShow_CategoryAddForm = new System.Windows.Forms.LinkLabel();
            this.BoxCategory = new System.Windows.Forms.ComboBox();
            this.LblStockDestination = new System.Windows.Forms.Label();
            this.TextInternalCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TextBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextDescription)).BeginInit();
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
            this.TextBarCode.Location = new System.Drawing.Point(156, 320);
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
            this.TextSalePrice.Location = new System.Drawing.Point(156, 264);
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
            this.TextCostPrice.Location = new System.Drawing.Point(156, 207);
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
            this.TextDescription.Location = new System.Drawing.Point(293, 91);
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
            this.BarCodeTitle.Location = new System.Drawing.Point(153, 302);
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
            this.SalePriceTitle.Location = new System.Drawing.Point(153, 247);
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
            this.CostPriceTitle.Location = new System.Drawing.Point(153, 190);
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
            this.DescriptionTitle.Location = new System.Drawing.Point(290, 74);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(67, 17);
            this.DescriptionTitle.TabIndex = 61;
            this.DescriptionTitle.Text = "Descrição:";
            // 
            // ButtonPresenter_ResetView
            // 
            this.ButtonPresenter_ResetView.ActiveBorderThickness = 1;
            this.ButtonPresenter_ResetView.ActiveCornerRadius = 10;
            this.ButtonPresenter_ResetView.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonPresenter_ResetView.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonPresenter_ResetView.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonPresenter_ResetView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonPresenter_ResetView.BackColor = System.Drawing.Color.White;
            this.ButtonPresenter_ResetView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonPresenter_ResetView.BackgroundImage")));
            this.ButtonPresenter_ResetView.ButtonText = "Limpar";
            this.ButtonPresenter_ResetView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonPresenter_ResetView.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPresenter_ResetView.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonPresenter_ResetView.IdleBorderThickness = 1;
            this.ButtonPresenter_ResetView.IdleCornerRadius = 10;
            this.ButtonPresenter_ResetView.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonPresenter_ResetView.IdleForecolor = System.Drawing.Color.White;
            this.ButtonPresenter_ResetView.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonPresenter_ResetView.Location = new System.Drawing.Point(256, 355);
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
            this.ButtonSave.Location = new System.Drawing.Point(157, 355);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 43);
            this.ButtonSave.TabIndex = 212;
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonShow_CategoryAddForm
            // 
            this.ButtonShow_CategoryAddForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonShow_CategoryAddForm.AutoSize = true;
            this.ButtonShow_CategoryAddForm.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.ButtonShow_CategoryAddForm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonShow_CategoryAddForm.Location = new System.Drawing.Point(664, 129);
            this.ButtonShow_CategoryAddForm.Name = "ButtonShow_CategoryAddForm";
            this.ButtonShow_CategoryAddForm.Size = new System.Drawing.Size(96, 17);
            this.ButtonShow_CategoryAddForm.TabIndex = 216;
            this.ButtonShow_CategoryAddForm.TabStop = true;
            this.ButtonShow_CategoryAddForm.Text = "Cadastrar Nova";
            this.ButtonShow_CategoryAddForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonShow_CategoryAddForm_LinkClicked);
            // 
            // BoxCategory
            // 
            this.BoxCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BoxCategory.BackColor = System.Drawing.Color.White;
            this.BoxCategory.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.BoxCategory.FormattingEnabled = true;
            this.BoxCategory.Location = new System.Drawing.Point(158, 148);
            this.BoxCategory.Name = "BoxCategory";
            this.BoxCategory.Size = new System.Drawing.Size(601, 27);
            this.BoxCategory.TabIndex = 215;
            this.BoxCategory.Click += new System.EventHandler(this.BoxCategory_Click);
            this.BoxCategory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxCategory_KeyPress);
            // 
            // LblStockDestination
            // 
            this.LblStockDestination.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LblStockDestination.AutoSize = true;
            this.LblStockDestination.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.LblStockDestination.ForeColor = System.Drawing.Color.Black;
            this.LblStockDestination.Location = new System.Drawing.Point(155, 129);
            this.LblStockDestination.Name = "LblStockDestination";
            this.LblStockDestination.Size = new System.Drawing.Size(68, 17);
            this.LblStockDestination.TabIndex = 214;
            this.LblStockDestination.Text = "Categoria:";
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
            this.TextInternalCode.Location = new System.Drawing.Point(157, 91);
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
            this.label1.Location = new System.Drawing.Point(155, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 220;
            this.label1.Text = "Código:";
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.TextInternalCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonShow_CategoryAddForm);
            this.Controls.Add(this.BoxCategory);
            this.Controls.Add(this.LblStockDestination);
            this.Controls.Add(this.ButtonPresenter_ResetView);
            this.Controls.Add(this.ButtonSave);
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
        private System.Windows.Forms.LinkLabel ButtonShow_CategoryAddForm;
        public System.Windows.Forms.Label LblStockDestination;
        public System.Windows.Forms.ComboBox BoxCategory;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextInternalCode;
        private System.Windows.Forms.Label label1;
    }
}