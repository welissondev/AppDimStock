namespace DimStock.View
{
    partial class FrmProdutoCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutoCadastro));
            this.BtnLimpar = new Syncfusion.WinForms.Controls.SfButton();
            this.TxtCodigoBarras = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtPrecoVenda = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TxtPrecoCusto = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TxtDescricao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtReferencia = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblCodigoBarras = new System.Windows.Forms.Label();
            this.LblPrecoVenda = new System.Windows.Forms.Label();
            this.LblPrecoCusto = new System.Windows.Forms.Label();
            this.LblDescricao = new System.Windows.Forms.Label();
            this.LblReferencia = new System.Windows.Forms.Label();
            this.LblTamanho = new System.Windows.Forms.Label();
            this.GbxFotoProduto = new System.Windows.Forms.GroupBox();
            this.PicFoto = new DimStock.Auxiliary.AxlPictureBox();
            this.BtnSalvar = new Syncfusion.WinForms.Controls.SfButton();
            this.TxtCodigo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.LblEstoqueMin = new System.Windows.Forms.Label();
            this.LblEstoqueMax = new System.Windows.Forms.Label();
            this.TxtEstoqueMin = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.TxtEstoqueMax = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.TxtTamanho = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.TxtFornecedor = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblFornecedor = new System.Windows.Forms.Label();
            this.PanelHorizontalSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LblDataLong = new System.Windows.Forms.Label();
            this.LblCaptionListaProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecoVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecoCusto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtReferencia)).BeginInit();
            this.GbxFotoProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEstoqueMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEstoqueMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFornecedor)).BeginInit();
            this.PanelHorizontalSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.AccessibleName = "Button";
            this.BtnLimpar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnLimpar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpar.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Location = new System.Drawing.Point(102, 50);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(80, 35);
            this.BtnLimpar.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnLimpar.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnLimpar.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnLimpar.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnLimpar.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Style.ForeColor = System.Drawing.Color.White;
            this.BtnLimpar.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnLimpar.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnLimpar.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnLimpar.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnLimpar.TabIndex = 11;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = false;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // TxtCodigoBarras
            // 
            this.TxtCodigoBarras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCodigoBarras.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtCodigoBarras.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtCodigoBarras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoBarras.CanOverrideStyle = true;
            this.TxtCodigoBarras.CausesValidation = false;
            this.TxtCodigoBarras.CornerRadius = 4;
            this.TxtCodigoBarras.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtCodigoBarras.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoBarras.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtCodigoBarras.Location = new System.Drawing.Point(246, 515);
            this.TxtCodigoBarras.MaxLength = 50;
            this.TxtCodigoBarras.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtCodigoBarras.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtCodigoBarras.Name = "TxtCodigoBarras";
            this.TxtCodigoBarras.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtCodigoBarras.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtCodigoBarras.Size = new System.Drawing.Size(599, 29);
            this.TxtCodigoBarras.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtCodigoBarras.TabIndex = 9;
            this.TxtCodigoBarras.ThemeName = "Office2016White";
            // 
            // TxtPrecoVenda
            // 
            this.TxtPrecoVenda.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtPrecoVenda.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtPrecoVenda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecoVenda.CanOverrideStyle = true;
            this.TxtPrecoVenda.CausesValidation = false;
            this.TxtPrecoVenda.CornerRadius = 4;
            this.TxtPrecoVenda.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtPrecoVenda.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TxtPrecoVenda.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoVenda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtPrecoVenda.Location = new System.Drawing.Point(246, 456);
            this.TxtPrecoVenda.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtPrecoVenda.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtPrecoVenda.Name = "TxtPrecoVenda";
            this.TxtPrecoVenda.NullString = "";
            this.TxtPrecoVenda.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtPrecoVenda.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtPrecoVenda.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtPrecoVenda.Size = new System.Drawing.Size(188, 29);
            this.TxtPrecoVenda.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtPrecoVenda.TabIndex = 8;
            this.TxtPrecoVenda.Text = "R$ 0,00";
            this.TxtPrecoVenda.ThemeName = "Office2016White";
            this.TxtPrecoVenda.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtPrecoCusto
            // 
            this.TxtPrecoCusto.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtPrecoCusto.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtPrecoCusto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPrecoCusto.CanOverrideStyle = true;
            this.TxtPrecoCusto.CausesValidation = false;
            this.TxtPrecoCusto.CornerRadius = 4;
            this.TxtPrecoCusto.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtPrecoCusto.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TxtPrecoCusto.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecoCusto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtPrecoCusto.Location = new System.Drawing.Point(246, 402);
            this.TxtPrecoCusto.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtPrecoCusto.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtPrecoCusto.Name = "TxtPrecoCusto";
            this.TxtPrecoCusto.NullString = "";
            this.TxtPrecoCusto.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtPrecoCusto.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtPrecoCusto.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtPrecoCusto.Size = new System.Drawing.Size(188, 29);
            this.TxtPrecoCusto.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtPrecoCusto.TabIndex = 7;
            this.TxtPrecoCusto.Text = "R$ 0,00";
            this.TxtPrecoCusto.ThemeName = "Office2016White";
            this.TxtPrecoCusto.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtDescricao.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDescricao.CanOverrideStyle = true;
            this.TxtDescricao.CausesValidation = false;
            this.TxtDescricao.CornerRadius = 4;
            this.TxtDescricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtDescricao.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtDescricao.Location = new System.Drawing.Point(246, 286);
            this.TxtDescricao.MaxLength = 2000;
            this.TxtDescricao.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtDescricao.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtDescricao.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtDescricao.Size = new System.Drawing.Size(599, 29);
            this.TxtDescricao.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtDescricao.TabIndex = 4;
            this.TxtDescricao.Tag = "";
            this.TxtDescricao.ThemeName = "Office2016White";
            // 
            // TxtReferencia
            // 
            this.TxtReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtReferencia.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtReferencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtReferencia.CanOverrideStyle = true;
            this.TxtReferencia.CausesValidation = false;
            this.TxtReferencia.CornerRadius = 4;
            this.TxtReferencia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtReferencia.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtReferencia.Location = new System.Drawing.Point(484, 160);
            this.TxtReferencia.MaxLength = 10;
            this.TxtReferencia.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtReferencia.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtReferencia.Name = "TxtReferencia";
            this.TxtReferencia.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtReferencia.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtReferencia.Size = new System.Drawing.Size(114, 29);
            this.TxtReferencia.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtReferencia.TabIndex = 2;
            this.TxtReferencia.Tag = "";
            this.TxtReferencia.ThemeName = "Office2016White";
            // 
            // LblCodigoBarras
            // 
            this.LblCodigoBarras.AutoSize = true;
            this.LblCodigoBarras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigoBarras.Location = new System.Drawing.Point(243, 496);
            this.LblCodigoBarras.Name = "LblCodigoBarras";
            this.LblCodigoBarras.Size = new System.Drawing.Size(117, 16);
            this.LblCodigoBarras.TabIndex = 64;
            this.LblCodigoBarras.Text = "Código de Barras:";
            // 
            // LblPrecoVenda
            // 
            this.LblPrecoVenda.AutoSize = true;
            this.LblPrecoVenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecoVenda.Location = new System.Drawing.Point(246, 440);
            this.LblPrecoVenda.Name = "LblPrecoVenda";
            this.LblPrecoVenda.Size = new System.Drawing.Size(90, 16);
            this.LblPrecoVenda.TabIndex = 63;
            this.LblPrecoVenda.Text = "Preço Venda:";
            // 
            // LblPrecoCusto
            // 
            this.LblPrecoCusto.AutoSize = true;
            this.LblPrecoCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecoCusto.Location = new System.Drawing.Point(246, 383);
            this.LblPrecoCusto.Name = "LblPrecoCusto";
            this.LblPrecoCusto.Size = new System.Drawing.Size(84, 16);
            this.LblPrecoCusto.TabIndex = 62;
            this.LblPrecoCusto.Text = "Preço Custo:";
            // 
            // LblDescricao
            // 
            this.LblDescricao.AutoSize = true;
            this.LblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescricao.Location = new System.Drawing.Point(246, 270);
            this.LblDescricao.Name = "LblDescricao";
            this.LblDescricao.Size = new System.Drawing.Size(73, 16);
            this.LblDescricao.TabIndex = 61;
            this.LblDescricao.Text = "Descrição:";
            // 
            // LblReferencia
            // 
            this.LblReferencia.AutoSize = true;
            this.LblReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReferencia.Location = new System.Drawing.Point(481, 144);
            this.LblReferencia.Name = "LblReferencia";
            this.LblReferencia.Size = new System.Drawing.Size(87, 16);
            this.LblReferencia.TabIndex = 60;
            this.LblReferencia.Text = "Referência**:";
            // 
            // LblTamanho
            // 
            this.LblTamanho.AutoSize = true;
            this.LblTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTamanho.Location = new System.Drawing.Point(360, 144);
            this.LblTamanho.Name = "LblTamanho";
            this.LblTamanho.Size = new System.Drawing.Size(104, 16);
            this.LblTamanho.TabIndex = 59;
            this.LblTamanho.Text = "Taman. Núm. **:";
            // 
            // GbxFotoProduto
            // 
            this.GbxFotoProduto.BackColor = System.Drawing.Color.White;
            this.GbxFotoProduto.Controls.Add(this.PicFoto);
            this.GbxFotoProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.GbxFotoProduto.Location = new System.Drawing.Point(41, 142);
            this.GbxFotoProduto.Name = "GbxFotoProduto";
            this.GbxFotoProduto.Size = new System.Drawing.Size(189, 210);
            this.GbxFotoProduto.TabIndex = 75;
            this.GbxFotoProduto.TabStop = false;
            this.GbxFotoProduto.Text = "Foto Produto";
            // 
            // PicFoto
            // 
            this.PicFoto.ArquivoDiretorioSelecionado = null;
            this.PicFoto.FotoNome = "";
            this.PicFoto.Image = global::DimStock.Properties.Resources.FotoNothing;
            this.PicFoto.Location = new System.Drawing.Point(7, 14);
            this.PicFoto.Name = "PicFoto";
            this.PicFoto.Size = new System.Drawing.Size(176, 188);
            this.PicFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicFoto.TabIndex = 82;
            this.PicFoto.TabStop = false;
            this.PicFoto.UltimaFoto = "";
            this.PicFoto.Click += new System.EventHandler(this.PicFoto_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.AccessibleName = "Button";
            this.BtnSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(19, 50);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(80, 35);
            this.BtnSalvar.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Style.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSalvar.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnSalvar.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnSalvar.TabIndex = 10;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtCodigo.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigo.CanOverrideStyle = true;
            this.TxtCodigo.CausesValidation = false;
            this.TxtCodigo.CornerRadius = 4;
            this.TxtCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtCodigo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtCodigo.Location = new System.Drawing.Point(246, 160);
            this.TxtCodigo.MaxLength = 20;
            this.TxtCodigo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtCodigo.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtCodigo.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtCodigo.Size = new System.Drawing.Size(112, 29);
            this.TxtCodigo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtCodigo.TabIndex = 0;
            this.TxtCodigo.Tag = "";
            this.TxtCodigo.ThemeName = "Office2016White";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(246, 144);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(71, 16);
            this.LblCodigo.TabIndex = 76;
            this.LblCodigo.Text = "Cód. Prod:";
            // 
            // LblEstoqueMin
            // 
            this.LblEstoqueMin.AutoSize = true;
            this.LblEstoqueMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstoqueMin.Location = new System.Drawing.Point(246, 326);
            this.LblEstoqueMin.Name = "LblEstoqueMin";
            this.LblEstoqueMin.Size = new System.Drawing.Size(53, 16);
            this.LblEstoqueMin.TabIndex = 80;
            this.LblEstoqueMin.Text = "QtdMin:";
            // 
            // LblEstoqueMax
            // 
            this.LblEstoqueMax.AutoSize = true;
            this.LblEstoqueMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEstoqueMax.Location = new System.Drawing.Point(338, 328);
            this.LblEstoqueMax.Name = "LblEstoqueMax";
            this.LblEstoqueMax.Size = new System.Drawing.Size(60, 16);
            this.LblEstoqueMax.TabIndex = 79;
            this.LblEstoqueMax.Text = "Qtd Max:";
            // 
            // TxtEstoqueMin
            // 
            this.TxtEstoqueMin.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtEstoqueMin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtEstoqueMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEstoqueMin.CornerRadius = 4;
            this.TxtEstoqueMin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtEstoqueMin.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstoqueMin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtEstoqueMin.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtEstoqueMin.IntegerValue = ((long)(0));
            this.TxtEstoqueMin.Location = new System.Drawing.Point(246, 343);
            this.TxtEstoqueMin.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtEstoqueMin.MinimumSize = new System.Drawing.Size(12, 8);
            this.TxtEstoqueMin.Name = "TxtEstoqueMin";
            this.TxtEstoqueMin.NullString = "";
            this.TxtEstoqueMin.NumberGroupSeparator = "";
            this.TxtEstoqueMin.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtEstoqueMin.Size = new System.Drawing.Size(90, 29);
            this.TxtEstoqueMin.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtEstoqueMin.TabIndex = 5;
            this.TxtEstoqueMin.ThemeName = "Office2016White";
            this.TxtEstoqueMin.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtEstoqueMax
            // 
            this.TxtEstoqueMax.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtEstoqueMax.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtEstoqueMax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEstoqueMax.CornerRadius = 4;
            this.TxtEstoqueMax.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtEstoqueMax.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstoqueMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtEstoqueMax.IntegerValue = ((long)(0));
            this.TxtEstoqueMax.Location = new System.Drawing.Point(342, 343);
            this.TxtEstoqueMax.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtEstoqueMax.MinimumSize = new System.Drawing.Size(12, 8);
            this.TxtEstoqueMax.Name = "TxtEstoqueMax";
            this.TxtEstoqueMax.NullString = "";
            this.TxtEstoqueMax.NumberGroupSeparator = "";
            this.TxtEstoqueMax.OnValidationFailed = Syncfusion.Windows.Forms.Tools.OnValidationFailed.SetNullString;
            this.TxtEstoqueMax.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtEstoqueMax.Size = new System.Drawing.Size(92, 29);
            this.TxtEstoqueMax.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtEstoqueMax.TabIndex = 6;
            this.TxtEstoqueMax.ThemeName = "Office2016White";
            this.TxtEstoqueMax.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtTamanho
            // 
            this.TxtTamanho.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtTamanho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTamanho.CornerRadius = 4;
            this.TxtTamanho.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtTamanho.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtTamanho.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtTamanho.IntegerValue = ((long)(0));
            this.TxtTamanho.Location = new System.Drawing.Point(363, 160);
            this.TxtTamanho.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtTamanho.MinimumSize = new System.Drawing.Size(12, 8);
            this.TxtTamanho.Name = "TxtTamanho";
            this.TxtTamanho.NegativeSign = "";
            this.TxtTamanho.NullString = "";
            this.TxtTamanho.NumberGroupSeparator = "";
            this.TxtTamanho.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtTamanho.Size = new System.Drawing.Size(115, 29);
            this.TxtTamanho.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtTamanho.TabIndex = 1;
            this.TxtTamanho.ThemeName = "Office2016White";
            this.TxtTamanho.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            // 
            // TxtFornecedor
            // 
            this.TxtFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtFornecedor.BeforeTouchSize = new System.Drawing.Size(114, 29);
            this.TxtFornecedor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtFornecedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtFornecedor.CanOverrideStyle = true;
            this.TxtFornecedor.CausesValidation = false;
            this.TxtFornecedor.CornerRadius = 4;
            this.TxtFornecedor.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtFornecedor.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFornecedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtFornecedor.Location = new System.Drawing.Point(246, 222);
            this.TxtFornecedor.MaxLength = 2000;
            this.TxtFornecedor.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtFornecedor.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtFornecedor.Name = "TxtFornecedor";
            this.TxtFornecedor.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtFornecedor.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtFornecedor.Size = new System.Drawing.Size(599, 29);
            this.TxtFornecedor.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtFornecedor.TabIndex = 3;
            this.TxtFornecedor.Tag = "";
            this.TxtFornecedor.ThemeName = "Office2016White";
            // 
            // LblFornecedor
            // 
            this.LblFornecedor.AutoSize = true;
            this.LblFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFornecedor.Location = new System.Drawing.Point(246, 206);
            this.LblFornecedor.Name = "LblFornecedor";
            this.LblFornecedor.Size = new System.Drawing.Size(81, 16);
            this.LblFornecedor.TabIndex = 81;
            this.LblFornecedor.Text = "Fornecedor:";
            // 
            // PanelHorizontalSuperior
            // 
            this.PanelHorizontalSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHorizontalSuperior.BackgroundImage")));
            this.PanelHorizontalSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHorizontalSuperior.Controls.Add(this.LblDataLong);
            this.PanelHorizontalSuperior.Controls.Add(this.LblCaptionListaProduto);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnLimpar);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnSalvar);
            this.PanelHorizontalSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontalSuperior.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientTopLeft = System.Drawing.Color.Black;
            this.PanelHorizontalSuperior.GradientTopRight = System.Drawing.Color.Black;
            this.PanelHorizontalSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelHorizontalSuperior.Name = "PanelHorizontalSuperior";
            this.PanelHorizontalSuperior.Quality = 10;
            this.PanelHorizontalSuperior.Size = new System.Drawing.Size(964, 99);
            this.PanelHorizontalSuperior.TabIndex = 141;
            // 
            // LblDataLong
            // 
            this.LblDataLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDataLong.BackColor = System.Drawing.Color.Transparent;
            this.LblDataLong.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataLong.ForeColor = System.Drawing.Color.White;
            this.LblDataLong.Location = new System.Drawing.Point(402, 26);
            this.LblDataLong.Name = "LblDataLong";
            this.LblDataLong.Size = new System.Drawing.Size(556, 40);
            this.LblDataLong.TabIndex = 139;
            this.LblDataLong.Text = "Entrada de Estoque";
            this.LblDataLong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCaptionListaProduto
            // 
            this.LblCaptionListaProduto.AutoSize = true;
            this.LblCaptionListaProduto.BackColor = System.Drawing.Color.Transparent;
            this.LblCaptionListaProduto.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaptionListaProduto.ForeColor = System.Drawing.Color.White;
            this.LblCaptionListaProduto.Location = new System.Drawing.Point(10, 11);
            this.LblCaptionListaProduto.Name = "LblCaptionListaProduto";
            this.LblCaptionListaProduto.Size = new System.Drawing.Size(332, 40);
            this.LblCaptionListaProduto.TabIndex = 138;
            this.LblCaptionListaProduto.Text = "Cadastro de Produtos";
            // 
            // FrmProdutoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.PanelHorizontalSuperior);
            this.Controls.Add(this.TxtFornecedor);
            this.Controls.Add(this.LblFornecedor);
            this.Controls.Add(this.TxtTamanho);
            this.Controls.Add(this.TxtEstoqueMin);
            this.Controls.Add(this.LblEstoqueMin);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.LblCodigo);
            this.Controls.Add(this.TxtCodigoBarras);
            this.Controls.Add(this.TxtPrecoVenda);
            this.Controls.Add(this.TxtPrecoCusto);
            this.Controls.Add(this.TxtDescricao);
            this.Controls.Add(this.LblCodigoBarras);
            this.Controls.Add(this.LblPrecoVenda);
            this.Controls.Add(this.LblPrecoCusto);
            this.Controls.Add(this.LblDescricao);
            this.Controls.Add(this.TxtEstoqueMax);
            this.Controls.Add(this.LblEstoqueMax);
            this.Controls.Add(this.GbxFotoProduto);
            this.Controls.Add(this.TxtReferencia);
            this.Controls.Add(this.LblReferencia);
            this.Controls.Add(this.LblTamanho);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmProdutoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigoBarras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecoVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecoCusto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtReferencia)).EndInit();
            this.GbxFotoProduto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEstoqueMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEstoqueMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFornecedor)).EndInit();
            this.PanelHorizontalSuperior.ResumeLayout(false);
            this.PanelHorizontalSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.WinForms.Controls.SfButton BtnLimpar;
        private Syncfusion.WinForms.Controls.SfButton BtnSalvar;
        private System.Windows.Forms.Label LblCodigoBarras;
        private System.Windows.Forms.Label LblPrecoVenda;
        private System.Windows.Forms.Label LblPrecoCusto;
        private System.Windows.Forms.Label LblDescricao;
        private System.Windows.Forms.Label LblReferencia;
        private System.Windows.Forms.Label LblTamanho;
        private System.Windows.Forms.GroupBox GbxFotoProduto;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtCodigoBarras;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TxtPrecoVenda;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TxtPrecoCusto;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtDescricao;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtReferencia;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtCodigo;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.Label LblEstoqueMin;
        private System.Windows.Forms.Label LblEstoqueMax;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox TxtEstoqueMin;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox TxtEstoqueMax;
        public Syncfusion.Windows.Forms.Tools.IntegerTextBox TxtTamanho;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtFornecedor;
        private System.Windows.Forms.Label LblFornecedor;
        public DimStock.Auxiliary.AxlPictureBox PicFoto;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelHorizontalSuperior;
        public System.Windows.Forms.Label LblDataLong;
        public System.Windows.Forms.Label LblCaptionListaProduto;
    }
}