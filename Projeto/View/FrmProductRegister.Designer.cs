namespace DimStock.View
{
    partial class FrmProductRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductRegister));
            this.BtnClear = new Syncfusion.WinForms.Controls.SfButton();
            this.TxtBarCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtSalePrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TxtCostPrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TxtDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtReference = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblBarCode = new System.Windows.Forms.Label();
            this.LblSalePrice = new System.Windows.Forms.Label();
            this.LblCostPrice = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblReference = new System.Windows.Forms.Label();
            this.LblSize = new System.Windows.Forms.Label();
            this.GbxProductPhoto = new System.Windows.Forms.GroupBox();
            this.PicProductPhoto = new DimStock.Auxiliary.AxlPictureBox();
            this.BtnSave = new Syncfusion.WinForms.Controls.SfButton();
            this.TxtCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblCode = new System.Windows.Forms.Label();
            this.LblMinStock = new System.Windows.Forms.Label();
            this.LblMaxStock = new System.Windows.Forms.Label();
            this.TxtMinStock = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.TxtMaxStock = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.TxtSize = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.TxtSupplier = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblSupplier = new System.Windows.Forms.Label();
            this.PnlUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LblTodayIsDay = new System.Windows.Forms.Label();
            this.LblFormTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtReference)).BeginInit();
            this.GbxProductPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicProductPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMinStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaxStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSupplier)).BeginInit();
            this.PnlUpperHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnClear
            // 
            this.BtnClear.AccessibleName = "Button";
            this.BtnClear.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(102, 50);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(80, 35);
            this.BtnClear.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnClear.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnClear.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnClear.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnClear.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnClear.Style.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnClear.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnClear.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnClear.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnClear.TabIndex = 11;
            this.BtnClear.Text = "Limpar";
            this.BtnClear.UseVisualStyleBackColor = false;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // TxtBarCode
            // 
            this.TxtBarCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBarCode.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtBarCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBarCode.CanOverrideStyle = true;
            this.TxtBarCode.CausesValidation = false;
            this.TxtBarCode.CornerRadius = 4;
            this.TxtBarCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBarCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBarCode.Location = new System.Drawing.Point(246, 515);
            this.TxtBarCode.MaxLength = 50;
            this.TxtBarCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBarCode.Name = "TxtBarCode";
            this.TxtBarCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtBarCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtBarCode.Size = new System.Drawing.Size(599, 26);
            this.TxtBarCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtBarCode.TabIndex = 9;
            this.TxtBarCode.ThemeName = "Office2016White";
            // 
            // TxtSalePrice
            // 
            this.TxtSalePrice.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtSalePrice.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtSalePrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSalePrice.CanOverrideStyle = true;
            this.TxtSalePrice.CausesValidation = false;
            this.TxtSalePrice.CornerRadius = 4;
            this.TxtSalePrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtSalePrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TxtSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtSalePrice.Location = new System.Drawing.Point(246, 456);
            this.TxtSalePrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtSalePrice.Name = "TxtSalePrice";
            this.TxtSalePrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtSalePrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtSalePrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtSalePrice.Size = new System.Drawing.Size(188, 26);
            this.TxtSalePrice.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtSalePrice.TabIndex = 8;
            this.TxtSalePrice.Text = "R$ 0,00";
            this.TxtSalePrice.ThemeName = "Office2016White";
            this.TxtSalePrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtCostPrice
            // 
            this.TxtCostPrice.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCostPrice.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtCostPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtCostPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCostPrice.CanOverrideStyle = true;
            this.TxtCostPrice.CausesValidation = false;
            this.TxtCostPrice.CornerRadius = 4;
            this.TxtCostPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtCostPrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TxtCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtCostPrice.Location = new System.Drawing.Point(246, 402);
            this.TxtCostPrice.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtCostPrice.Name = "TxtCostPrice";
            this.TxtCostPrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtCostPrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtCostPrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtCostPrice.Size = new System.Drawing.Size(188, 26);
            this.TxtCostPrice.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtCostPrice.TabIndex = 7;
            this.TxtCostPrice.Text = "R$ 0,00";
            this.TxtCostPrice.ThemeName = "Office2016White";
            this.TxtCostPrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtDescription
            // 
            this.TxtDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtDescription.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescription.CanOverrideStyle = true;
            this.TxtDescription.CausesValidation = false;
            this.TxtDescription.CornerRadius = 4;
            this.TxtDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtDescription.Location = new System.Drawing.Point(246, 286);
            this.TxtDescription.MaxLength = 2000;
            this.TxtDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtDescription.Size = new System.Drawing.Size(599, 26);
            this.TxtDescription.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtDescription.TabIndex = 4;
            this.TxtDescription.Tag = "";
            this.TxtDescription.ThemeName = "Office2016White";
            // 
            // TxtReference
            // 
            this.TxtReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtReference.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReference.CanOverrideStyle = true;
            this.TxtReference.CausesValidation = false;
            this.TxtReference.CornerRadius = 4;
            this.TxtReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtReference.Location = new System.Drawing.Point(484, 160);
            this.TxtReference.MaxLength = 10;
            this.TxtReference.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtReference.Name = "TxtReference";
            this.TxtReference.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtReference.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtReference.Size = new System.Drawing.Size(114, 26);
            this.TxtReference.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtReference.TabIndex = 2;
            this.TxtReference.Tag = "";
            this.TxtReference.ThemeName = "Office2016White";
            // 
            // LblBarCode
            // 
            this.LblBarCode.AutoSize = true;
            this.LblBarCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBarCode.Location = new System.Drawing.Point(243, 496);
            this.LblBarCode.Name = "LblBarCode";
            this.LblBarCode.Size = new System.Drawing.Size(117, 16);
            this.LblBarCode.TabIndex = 64;
            this.LblBarCode.Text = "Código de Barras:";
            // 
            // LblSalePrice
            // 
            this.LblSalePrice.AutoSize = true;
            this.LblSalePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalePrice.Location = new System.Drawing.Point(246, 440);
            this.LblSalePrice.Name = "LblSalePrice";
            this.LblSalePrice.Size = new System.Drawing.Size(90, 16);
            this.LblSalePrice.TabIndex = 63;
            this.LblSalePrice.Text = "Preço Venda:";
            // 
            // LblCostPrice
            // 
            this.LblCostPrice.AutoSize = true;
            this.LblCostPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCostPrice.Location = new System.Drawing.Point(246, 383);
            this.LblCostPrice.Name = "LblCostPrice";
            this.LblCostPrice.Size = new System.Drawing.Size(84, 16);
            this.LblCostPrice.TabIndex = 62;
            this.LblCostPrice.Text = "Preço Custo:";
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(246, 270);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(73, 16);
            this.LblDescription.TabIndex = 61;
            this.LblDescription.Text = "Descrição:";
            // 
            // LblReference
            // 
            this.LblReference.AutoSize = true;
            this.LblReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReference.Location = new System.Drawing.Point(481, 144);
            this.LblReference.Name = "LblReference";
            this.LblReference.Size = new System.Drawing.Size(87, 16);
            this.LblReference.TabIndex = 60;
            this.LblReference.Text = "Referência**:";
            // 
            // LblSize
            // 
            this.LblSize.AutoSize = true;
            this.LblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSize.Location = new System.Drawing.Point(360, 144);
            this.LblSize.Name = "LblSize";
            this.LblSize.Size = new System.Drawing.Size(104, 16);
            this.LblSize.TabIndex = 59;
            this.LblSize.Text = "Taman. Núm. **:";
            // 
            // GbxProductPhoto
            // 
            this.GbxProductPhoto.BackColor = System.Drawing.Color.White;
            this.GbxProductPhoto.Controls.Add(this.PicProductPhoto);
            this.GbxProductPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GbxProductPhoto.Location = new System.Drawing.Point(41, 142);
            this.GbxProductPhoto.Name = "GbxProductPhoto";
            this.GbxProductPhoto.Size = new System.Drawing.Size(189, 210);
            this.GbxProductPhoto.TabIndex = 75;
            this.GbxProductPhoto.TabStop = false;
            this.GbxProductPhoto.Text = "Foto Produto";
            // 
            // PicProductPhoto
            // 
            this.PicProductPhoto.ArquivoDiretorioSelecionado = null;
            this.PicProductPhoto.FotoNome = "";
            this.PicProductPhoto.Image = global::DimStock.Properties.Resources.FotoNothing;
            this.PicProductPhoto.Location = new System.Drawing.Point(7, 14);
            this.PicProductPhoto.Name = "PicProductPhoto";
            this.PicProductPhoto.Size = new System.Drawing.Size(176, 188);
            this.PicProductPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicProductPhoto.TabIndex = 82;
            this.PicProductPhoto.TabStop = false;
            this.PicProductPhoto.UltimaFoto = "";
            this.PicProductPhoto.Click += new System.EventHandler(this.PicProductPhoto_Click);
            // 
            // BtnSave
            // 
            this.BtnSave.AccessibleName = "Button";
            this.BtnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(19, 50);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(80, 35);
            this.BtnSave.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnSave.Style.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSave.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnSave.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSave.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnSave.TabIndex = 10;
            this.BtnSave.Text = "Salvar";
            this.BtnSave.UseVisualStyleBackColor = false;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TxtCode
            // 
            this.TxtCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCode.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCode.CanOverrideStyle = true;
            this.TxtCode.CausesValidation = false;
            this.TxtCode.CornerRadius = 4;
            this.TxtCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtCode.Location = new System.Drawing.Point(246, 160);
            this.TxtCode.MaxLength = 20;
            this.TxtCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtCode.Name = "TxtCode";
            this.TxtCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtCode.Size = new System.Drawing.Size(112, 26);
            this.TxtCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtCode.TabIndex = 0;
            this.TxtCode.Tag = "";
            this.TxtCode.ThemeName = "Office2016White";
            // 
            // LblCode
            // 
            this.LblCode.AutoSize = true;
            this.LblCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCode.Location = new System.Drawing.Point(246, 144);
            this.LblCode.Name = "LblCode";
            this.LblCode.Size = new System.Drawing.Size(71, 16);
            this.LblCode.TabIndex = 76;
            this.LblCode.Text = "Cód. Prod:";
            // 
            // LblMinStock
            // 
            this.LblMinStock.AutoSize = true;
            this.LblMinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinStock.Location = new System.Drawing.Point(246, 326);
            this.LblMinStock.Name = "LblMinStock";
            this.LblMinStock.Size = new System.Drawing.Size(53, 16);
            this.LblMinStock.TabIndex = 80;
            this.LblMinStock.Text = "QtdMin:";
            // 
            // LblMaxStock
            // 
            this.LblMaxStock.AutoSize = true;
            this.LblMaxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMaxStock.Location = new System.Drawing.Point(338, 328);
            this.LblMaxStock.Name = "LblMaxStock";
            this.LblMaxStock.Size = new System.Drawing.Size(60, 16);
            this.LblMaxStock.TabIndex = 79;
            this.LblMaxStock.Text = "Qtd Max:";
            // 
            // TxtMinStock
            // 
            this.TxtMinStock.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtMinStock.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtMinStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtMinStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMinStock.CornerRadius = 4;
            this.TxtMinStock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtMinStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMinStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtMinStock.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtMinStock.IntegerValue = ((long)(0));
            this.TxtMinStock.Location = new System.Drawing.Point(246, 343);
            this.TxtMinStock.MinimumSize = new System.Drawing.Size(12, 8);
            this.TxtMinStock.Name = "TxtMinStock";
            this.TxtMinStock.NumberGroupSeparator = "";
            this.TxtMinStock.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtMinStock.Size = new System.Drawing.Size(90, 26);
            this.TxtMinStock.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtMinStock.TabIndex = 5;
            this.TxtMinStock.ThemeName = "Office2016White";
            this.TxtMinStock.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtMaxStock
            // 
            this.TxtMaxStock.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtMaxStock.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtMaxStock.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtMaxStock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtMaxStock.CornerRadius = 4;
            this.TxtMaxStock.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtMaxStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMaxStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtMaxStock.IntegerValue = ((long)(0));
            this.TxtMaxStock.Location = new System.Drawing.Point(342, 343);
            this.TxtMaxStock.MinimumSize = new System.Drawing.Size(12, 8);
            this.TxtMaxStock.Name = "TxtMaxStock";
            this.TxtMaxStock.NumberGroupSeparator = "";
            this.TxtMaxStock.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString;
            this.TxtMaxStock.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtMaxStock.Size = new System.Drawing.Size(92, 26);
            this.TxtMaxStock.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtMaxStock.TabIndex = 6;
            this.TxtMaxStock.ThemeName = "Office2016White";
            this.TxtMaxStock.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtSize
            // 
            this.TxtSize.BackGroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtSize.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtSize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSize.CornerRadius = 4;
            this.TxtSize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtSize.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtSize.IntegerValue = ((long)(0));
            this.TxtSize.Location = new System.Drawing.Point(363, 160);
            this.TxtSize.MinimumSize = new System.Drawing.Size(12, 8);
            this.TxtSize.Name = "TxtSize";
            this.TxtSize.NegativeSign = "";
            this.TxtSize.NumberGroupSeparator = "";
            this.TxtSize.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtSize.Size = new System.Drawing.Size(115, 26);
            this.TxtSize.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtSize.TabIndex = 1;
            this.TxtSize.ThemeName = "Office2016White";
            this.TxtSize.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtSupplier
            // 
            this.TxtSupplier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtSupplier.BeforeTouchSize = new System.Drawing.Size(114, 26);
            this.TxtSupplier.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtSupplier.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSupplier.CanOverrideStyle = true;
            this.TxtSupplier.CausesValidation = false;
            this.TxtSupplier.CornerRadius = 4;
            this.TxtSupplier.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSupplier.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtSupplier.Location = new System.Drawing.Point(246, 222);
            this.TxtSupplier.MaxLength = 2000;
            this.TxtSupplier.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtSupplier.Name = "TxtSupplier";
            this.TxtSupplier.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtSupplier.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtSupplier.Size = new System.Drawing.Size(599, 26);
            this.TxtSupplier.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtSupplier.TabIndex = 3;
            this.TxtSupplier.Tag = "";
            this.TxtSupplier.ThemeName = "Office2016White";
            // 
            // LblSupplier
            // 
            this.LblSupplier.AutoSize = true;
            this.LblSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSupplier.Location = new System.Drawing.Point(246, 206);
            this.LblSupplier.Name = "LblSupplier";
            this.LblSupplier.Size = new System.Drawing.Size(81, 16);
            this.LblSupplier.TabIndex = 81;
            this.LblSupplier.Text = "Fornecedor:";
            // 
            // PnlUpperHorizontal
            // 
            this.PnlUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PnlUpperHorizontal.BackgroundImage")));
            this.PnlUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlUpperHorizontal.Controls.Add(this.LblTodayIsDay);
            this.PnlUpperHorizontal.Controls.Add(this.LblFormTitle);
            this.PnlUpperHorizontal.Controls.Add(this.BtnClear);
            this.PnlUpperHorizontal.Controls.Add(this.BtnSave);
            this.PnlUpperHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlUpperHorizontal.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PnlUpperHorizontal.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PnlUpperHorizontal.GradientTopLeft = System.Drawing.Color.Black;
            this.PnlUpperHorizontal.GradientTopRight = System.Drawing.Color.Black;
            this.PnlUpperHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PnlUpperHorizontal.Name = "PnlUpperHorizontal";
            this.PnlUpperHorizontal.Quality = 10;
            this.PnlUpperHorizontal.Size = new System.Drawing.Size(964, 99);
            this.PnlUpperHorizontal.TabIndex = 141;
            // 
            // LblTodayIsDay
            // 
            this.LblTodayIsDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTodayIsDay.BackColor = System.Drawing.Color.Transparent;
            this.LblTodayIsDay.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTodayIsDay.ForeColor = System.Drawing.Color.White;
            this.LblTodayIsDay.Location = new System.Drawing.Point(402, 26);
            this.LblTodayIsDay.Name = "LblTodayIsDay";
            this.LblTodayIsDay.Size = new System.Drawing.Size(556, 40);
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
            this.LblFormTitle.Location = new System.Drawing.Point(10, 11);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(332, 40);
            this.LblFormTitle.TabIndex = 138;
            this.LblFormTitle.Text = "Cadastro de Produtos";
            // 
            // FrmProductRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.PnlUpperHorizontal);
            this.Controls.Add(this.TxtSupplier);
            this.Controls.Add(this.LblSupplier);
            this.Controls.Add(this.TxtSize);
            this.Controls.Add(this.TxtMinStock);
            this.Controls.Add(this.LblMinStock);
            this.Controls.Add(this.TxtCode);
            this.Controls.Add(this.LblCode);
            this.Controls.Add(this.TxtBarCode);
            this.Controls.Add(this.TxtSalePrice);
            this.Controls.Add(this.TxtCostPrice);
            this.Controls.Add(this.TxtDescription);
            this.Controls.Add(this.LblBarCode);
            this.Controls.Add(this.LblSalePrice);
            this.Controls.Add(this.LblCostPrice);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.TxtMaxStock);
            this.Controls.Add(this.LblMaxStock);
            this.Controls.Add(this.GbxProductPhoto);
            this.Controls.Add(this.TxtReference);
            this.Controls.Add(this.LblReference);
            this.Controls.Add(this.LblSize);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmProductRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TxtBarCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtReference)).EndInit();
            this.GbxProductPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicProductPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMinStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaxStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSupplier)).EndInit();
            this.PnlUpperHorizontal.ResumeLayout(false);
            this.PnlUpperHorizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton BtnClear;
        private Syncfusion.WinForms.Controls.SfButton BtnSave;
        private System.Windows.Forms.Label LblBarCode;
        private System.Windows.Forms.Label LblSalePrice;
        private System.Windows.Forms.Label LblCostPrice;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblReference;
        private System.Windows.Forms.Label LblSize;
        private System.Windows.Forms.GroupBox GbxProductPhoto;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBarCode;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TxtSalePrice;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TxtCostPrice;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtDescription;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtReference;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtCode;
        private System.Windows.Forms.Label LblCode;
        private System.Windows.Forms.Label LblMinStock;
        private System.Windows.Forms.Label LblMaxStock;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox TxtMinStock;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox TxtMaxStock;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox TxtSize;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtSupplier;
        private System.Windows.Forms.Label LblSupplier;
        public DimStock.Auxiliary.AxlPictureBox PicProductPhoto;
        private Bunifu.Framework.UI.BunifuGradientPanel PnlUpperHorizontal;
        public System.Windows.Forms.Label LblTodayIsDay;
        public System.Windows.Forms.Label LblFormTitle;
    }
}