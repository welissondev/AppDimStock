namespace DimStock.View
{
    partial class FrmStockList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockList));
            this.GridStockList = new System.Windows.Forms.DataGridView();
            this.CboPageSize = new Syncfusion.WinForms.ListView.SfComboBox();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblNumeroDeRegistros = new System.Windows.Forms.Label();
            this.LblBuscaDescricao = new System.Windows.Forms.Label();
            this.LblBuscaReferencia = new System.Windows.Forms.Label();
            this.LblBuscaTamanho = new System.Windows.Forms.Label();
            this.LblBuscaCode = new System.Windows.Forms.Label();
            this.TxtQueryByReference = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtQueryBySize = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtQueryByCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtQueryByDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnReport = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnAtualizar = new Syncfusion.WinForms.Controls.SfButton();
            this.LblDataLong = new System.Windows.Forms.Label();
            this.LblCaptionListaProduto = new System.Windows.Forms.Label();
            this.ImgGifLoading = new System.Windows.Forms.PictureBox();
            this.CboResume = new Syncfusion.WinForms.ListView.SfComboBox();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblResumo = new System.Windows.Forms.Label();
            this.LblLimpar = new System.Windows.Forms.LinkLabel();
            this.BindingNavigatorPaginacao = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridStockList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryBySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByDescription)).BeginInit();
            this.PanelUpperHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboResume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorPaginacao)).BeginInit();
            this.BindingNavigatorPaginacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridStockList
            // 
            this.GridStockList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridStockList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridStockList.Location = new System.Drawing.Point(30, 197);
            this.GridStockList.Name = "GridStockList";
            this.GridStockList.Size = new System.Drawing.Size(1002, 426);
            this.GridStockList.TabIndex = 70;
            this.GridStockList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StockDataGrid_CellFormatting);
            this.GridStockList.Layout += new System.Windows.Forms.LayoutEventHandler(this.StockDataGrid_Layout);
            // 
            // CboPageSize
            // 
            this.CboPageSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPageSize.Location = new System.Drawing.Point(701, 165);
            this.CboPageSize.Name = "CboPageSize";
            this.CboPageSize.Size = new System.Drawing.Size(174, 25);
            this.CboPageSize.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboPageSize.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CboPageSize.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPageSize.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPageSize.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboPageSize.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPageSize.TabIndex = 101;
            this.CboPageSize.ToolTipOption.ShadowVisible = false;
            this.CboPageSize.SelectedIndexChanged += new System.EventHandler(this.CboPageSize_SelectedIndexChanged);
            this.CboPageSize.Click += new System.EventHandler(this.CboPageSize_SelectedIndexChanged);
            this.CboPageSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RunSearch_KeyPress);
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(794, 26);
            this.textBoxExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt1.CanOverrideStyle = true;
            this.textBoxExt1.CausesValidation = false;
            this.textBoxExt1.CornerRadius = 4;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxExt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt1.Location = new System.Drawing.Point(699, 163);
            this.textBoxExt1.MaxLength = 50;
            this.textBoxExt1.MinimumSize = new System.Drawing.Size(16, 12);
            this.textBoxExt1.Multiline = true;
            this.textBoxExt1.Name = "textBoxExt1";
            this.textBoxExt1.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt1.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt1.Size = new System.Drawing.Size(177, 29);
            this.textBoxExt1.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt1.TabIndex = 107;
            this.textBoxExt1.Tag = "";
            this.textBoxExt1.ThemeName = "Office2016Colorful";
            // 
            // LblNumeroDeRegistros
            // 
            this.LblNumeroDeRegistros.AutoSize = true;
            this.LblNumeroDeRegistros.Location = new System.Drawing.Point(698, 147);
            this.LblNumeroDeRegistros.Name = "LblNumeroDeRegistros";
            this.LblNumeroDeRegistros.Size = new System.Drawing.Size(107, 13);
            this.LblNumeroDeRegistros.TabIndex = 106;
            this.LblNumeroDeRegistros.Text = "Registros por página:";
            // 
            // LblBuscaDescricao
            // 
            this.LblBuscaDescricao.AutoSize = true;
            this.LblBuscaDescricao.Location = new System.Drawing.Point(484, 147);
            this.LblBuscaDescricao.Name = "LblBuscaDescricao";
            this.LblBuscaDescricao.Size = new System.Drawing.Size(112, 13);
            this.LblBuscaDescricao.TabIndex = 105;
            this.LblBuscaDescricao.Text = "Descrição do produto:";
            // 
            // LblBuscaReferencia
            // 
            this.LblBuscaReferencia.AutoSize = true;
            this.LblBuscaReferencia.Location = new System.Drawing.Point(375, 147);
            this.LblBuscaReferencia.Name = "LblBuscaReferencia";
            this.LblBuscaReferencia.Size = new System.Drawing.Size(62, 13);
            this.LblBuscaReferencia.TabIndex = 104;
            this.LblBuscaReferencia.Text = "Referência:";
            // 
            // LblBuscaTamanho
            // 
            this.LblBuscaTamanho.AutoSize = true;
            this.LblBuscaTamanho.Location = new System.Drawing.Point(272, 147);
            this.LblBuscaTamanho.Name = "LblBuscaTamanho";
            this.LblBuscaTamanho.Size = new System.Drawing.Size(55, 13);
            this.LblBuscaTamanho.TabIndex = 103;
            this.LblBuscaTamanho.Text = "Tamanho:";
            // 
            // LblBuscaCode
            // 
            this.LblBuscaCode.AutoSize = true;
            this.LblBuscaCode.Location = new System.Drawing.Point(160, 147);
            this.LblBuscaCode.Name = "LblBuscaCode";
            this.LblBuscaCode.Size = new System.Drawing.Size(83, 13);
            this.LblBuscaCode.TabIndex = 102;
            this.LblBuscaCode.Text = "Código Produto:";
            // 
            // TxtQueryByReference
            // 
            this.TxtQueryByReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryByReference.BeforeTouchSize = new System.Drawing.Size(794, 26);
            this.TxtQueryByReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryByReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByReference.CanOverrideStyle = true;
            this.TxtQueryByReference.CausesValidation = false;
            this.TxtQueryByReference.CornerRadius = 4;
            this.TxtQueryByReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByReference.Location = new System.Drawing.Point(378, 163);
            this.TxtQueryByReference.MaxLength = 50;
            this.TxtQueryByReference.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByReference.Multiline = true;
            this.TxtQueryByReference.Name = "TxtQueryByReference";
            this.TxtQueryByReference.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByReference.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByReference.Size = new System.Drawing.Size(105, 29);
            this.TxtQueryByReference.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryByReference.TabIndex = 98;
            this.TxtQueryByReference.Tag = "";
            this.TxtQueryByReference.ThemeName = "Office2016Colorful";
            this.TxtQueryByReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RunSearch_KeyPress);
            // 
            // TxtQueryBySize
            // 
            this.TxtQueryBySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryBySize.BeforeTouchSize = new System.Drawing.Size(794, 26);
            this.TxtQueryBySize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryBySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryBySize.CanOverrideStyle = true;
            this.TxtQueryBySize.CausesValidation = false;
            this.TxtQueryBySize.CornerRadius = 4;
            this.TxtQueryBySize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryBySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryBySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryBySize.Location = new System.Drawing.Point(275, 163);
            this.TxtQueryBySize.MaxLength = 50;
            this.TxtQueryBySize.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryBySize.Multiline = true;
            this.TxtQueryBySize.Name = "TxtQueryBySize";
            this.TxtQueryBySize.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryBySize.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryBySize.Size = new System.Drawing.Size(100, 29);
            this.TxtQueryBySize.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryBySize.TabIndex = 97;
            this.TxtQueryBySize.Tag = "";
            this.TxtQueryBySize.ThemeName = "Office2016Colorful";
            this.TxtQueryBySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RunSearch_KeyPress);
            // 
            // TxtQueryByCode
            // 
            this.TxtQueryByCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryByCode.BeforeTouchSize = new System.Drawing.Size(794, 26);
            this.TxtQueryByCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByCode.CanOverrideStyle = true;
            this.TxtQueryByCode.CausesValidation = false;
            this.TxtQueryByCode.CornerRadius = 4;
            this.TxtQueryByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByCode.Location = new System.Drawing.Point(163, 163);
            this.TxtQueryByCode.MaxLength = 50;
            this.TxtQueryByCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByCode.Multiline = true;
            this.TxtQueryByCode.Name = "TxtQueryByCode";
            this.TxtQueryByCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByCode.Size = new System.Drawing.Size(109, 29);
            this.TxtQueryByCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryByCode.TabIndex = 96;
            this.TxtQueryByCode.Tag = "";
            this.TxtQueryByCode.ThemeName = "Office2016Colorful";
            this.TxtQueryByCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RunSearch_KeyPress);
            // 
            // TxtQueryByDescription
            // 
            this.TxtQueryByDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryByDescription.BeforeTouchSize = new System.Drawing.Size(794, 26);
            this.TxtQueryByDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByDescription.CanOverrideStyle = true;
            this.TxtQueryByDescription.CausesValidation = false;
            this.TxtQueryByDescription.CornerRadius = 4;
            this.TxtQueryByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByDescription.Location = new System.Drawing.Point(487, 163);
            this.TxtQueryByDescription.MaxLength = 50;
            this.TxtQueryByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByDescription.Multiline = true;
            this.TxtQueryByDescription.Name = "TxtQueryByDescription";
            this.TxtQueryByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByDescription.Size = new System.Drawing.Size(208, 29);
            this.TxtQueryByDescription.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryByDescription.TabIndex = 100;
            this.TxtQueryByDescription.Tag = "";
            this.TxtQueryByDescription.ThemeName = "Office2016Colorful";
            this.TxtQueryByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RunSearch_KeyPress);
            // 
            // Timer
            // 
            this.Timer.Interval = 500;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.BtnReport);
            this.PanelUpperHorizontal.Controls.Add(this.BtnAtualizar);
            this.PanelUpperHorizontal.Controls.Add(this.LblDataLong);
            this.PanelUpperHorizontal.Controls.Add(this.LblCaptionListaProduto);
            this.PanelUpperHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpperHorizontal.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientTopLeft = System.Drawing.SystemColors.ControlText;
            this.PanelUpperHorizontal.GradientTopRight = System.Drawing.SystemColors.ControlText;
            this.PanelUpperHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PanelUpperHorizontal.Name = "PanelUpperHorizontal";
            this.PanelUpperHorizontal.Quality = 10;
            this.PanelUpperHorizontal.Size = new System.Drawing.Size(1057, 95);
            this.PanelUpperHorizontal.TabIndex = 141;
            // 
            // BtnReport
            // 
            this.BtnReport.AccessibleName = "Button";
            this.BtnReport.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReport.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(103, 47);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(83, 35);
            this.BtnReport.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReport.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnReport.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnReport.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnReport.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnReport.Style.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnReport.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnReport.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnReport.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnReport.TabIndex = 141;
            this.BtnReport.Text = "Relatório";
            this.BtnReport.UseVisualStyleBackColor = false;
            this.BtnReport.Click += new System.EventHandler(this.BtnReport_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.AccessibleName = "Button";
            this.BtnAtualizar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(17, 47);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(80, 35);
            this.BtnAtualizar.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Style.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAtualizar.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnAtualizar.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.TabIndex = 140;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // LblDataLong
            // 
            this.LblDataLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDataLong.BackColor = System.Drawing.Color.Transparent;
            this.LblDataLong.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataLong.ForeColor = System.Drawing.Color.White;
            this.LblDataLong.Location = new System.Drawing.Point(488, 25);
            this.LblDataLong.Name = "LblDataLong";
            this.LblDataLong.Size = new System.Drawing.Size(563, 40);
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
            this.LblCaptionListaProduto.Location = new System.Drawing.Point(10, 4);
            this.LblCaptionListaProduto.Name = "LblCaptionListaProduto";
            this.LblCaptionListaProduto.Size = new System.Drawing.Size(273, 40);
            this.LblCaptionListaProduto.TabIndex = 138;
            this.LblCaptionListaProduto.Text = "Lista de Estoques";
            // 
            // ImgGifLoading
            // 
            this.ImgGifLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImgGifLoading.Image = global::DimStock.Properties.Resources.Load;
            this.ImgGifLoading.Location = new System.Drawing.Point(465, 356);
            this.ImgGifLoading.Name = "ImgGifLoading";
            this.ImgGifLoading.Size = new System.Drawing.Size(129, 137);
            this.ImgGifLoading.TabIndex = 142;
            this.ImgGifLoading.TabStop = false;
            this.ImgGifLoading.Visible = false;
            // 
            // CboResume
            // 
            this.CboResume.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboResume.Location = new System.Drawing.Point(30, 165);
            this.CboResume.Name = "CboResume";
            this.CboResume.Size = new System.Drawing.Size(129, 25);
            this.CboResume.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboResume.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CboResume.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboResume.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboResume.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboResume.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboResume.TabIndex = 143;
            this.CboResume.ToolTipOption.ShadowVisible = false;
            this.CboResume.SelectedIndexChanged += new System.EventHandler(this.CboResume_SelectedIndexChanged);
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(794, 26);
            this.textBoxExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt2.CanOverrideStyle = true;
            this.textBoxExt2.CausesValidation = false;
            this.textBoxExt2.CornerRadius = 4;
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxExt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt2.Location = new System.Drawing.Point(28, 163);
            this.textBoxExt2.MaxLength = 50;
            this.textBoxExt2.MinimumSize = new System.Drawing.Size(16, 12);
            this.textBoxExt2.Multiline = true;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt2.Size = new System.Drawing.Size(132, 29);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt2.TabIndex = 145;
            this.textBoxExt2.Tag = "";
            this.textBoxExt2.ThemeName = "Office2016Colorful";
            // 
            // LblResumo
            // 
            this.LblResumo.AutoSize = true;
            this.LblResumo.Location = new System.Drawing.Point(27, 147);
            this.LblResumo.Name = "LblResumo";
            this.LblResumo.Size = new System.Drawing.Size(49, 13);
            this.LblResumo.TabIndex = 144;
            this.LblResumo.Text = "Resumo:";
            // 
            // LblLimpar
            // 
            this.LblLimpar.AutoSize = true;
            this.LblLimpar.Location = new System.Drawing.Point(879, 171);
            this.LblLimpar.Name = "LblLimpar";
            this.LblLimpar.Size = new System.Drawing.Size(38, 13);
            this.LblLimpar.TabIndex = 171;
            this.LblLimpar.TabStop = true;
            this.LblLimpar.Text = "Limpar";
            this.LblLimpar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLimpar_LinkClicked);
            // 
            // BindingNavigatorPaginacao
            // 
            this.BindingNavigatorPaginacao.AddNewItem = null;
            this.BindingNavigatorPaginacao.CountItem = null;
            this.BindingNavigatorPaginacao.DeleteItem = null;
            this.BindingNavigatorPaginacao.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingNavigatorPaginacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackPage,
            this.toolStripSeparator1,
            this.LblPaginationState,
            this.toolStripSeparator2,
            this.NextPage,
            this.toolStripSeparator3,
            this.LblRecordsState});
            this.BindingNavigatorPaginacao.Location = new System.Drawing.Point(0, 656);
            this.BindingNavigatorPaginacao.MoveFirstItem = null;
            this.BindingNavigatorPaginacao.MoveLastItem = null;
            this.BindingNavigatorPaginacao.MoveNextItem = null;
            this.BindingNavigatorPaginacao.MovePreviousItem = null;
            this.BindingNavigatorPaginacao.Name = "BindingNavigatorPaginacao";
            this.BindingNavigatorPaginacao.PositionItem = null;
            this.BindingNavigatorPaginacao.Size = new System.Drawing.Size(1057, 25);
            this.BindingNavigatorPaginacao.TabIndex = 177;
            this.BindingNavigatorPaginacao.Text = "bindingNavigator1";
            // 
            // BackPage
            // 
            this.BackPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackPage.Image = ((System.Drawing.Image)(resources.GetObject("BackPage.Image")));
            this.BackPage.Name = "BackPage";
            this.BackPage.RightToLeftAutoMirrorImage = true;
            this.BackPage.Size = new System.Drawing.Size(23, 22);
            this.BackPage.Click += new System.EventHandler(this.BackPage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // LblPaginationState
            // 
            this.LblPaginationState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaginationState.Name = "LblPaginationState";
            this.LblPaginationState.Size = new System.Drawing.Size(77, 22);
            this.LblPaginationState.Text = "Página 0 de 0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // NextPage
            // 
            this.NextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextPage.Image = ((System.Drawing.Image)(resources.GetObject("NextPage.Image")));
            this.NextPage.Name = "NextPage";
            this.NextPage.RightToLeftAutoMirrorImage = true;
            this.NextPage.Size = new System.Drawing.Size(23, 22);
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // LblRecordsState
            // 
            this.LblRecordsState.Name = "LblRecordsState";
            this.LblRecordsState.Size = new System.Drawing.Size(86, 22);
            this.LblRecordsState.Text = "0 de 0 registros";
            // 
            // FrmStockList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 681);
            this.Controls.Add(this.BindingNavigatorPaginacao);
            this.Controls.Add(this.ImgGifLoading);
            this.Controls.Add(this.LblLimpar);
            this.Controls.Add(this.CboResume);
            this.Controls.Add(this.textBoxExt2);
            this.Controls.Add(this.LblResumo);
            this.Controls.Add(this.PanelUpperHorizontal);
            this.Controls.Add(this.CboPageSize);
            this.Controls.Add(this.textBoxExt1);
            this.Controls.Add(this.LblNumeroDeRegistros);
            this.Controls.Add(this.LblBuscaDescricao);
            this.Controls.Add(this.LblBuscaReferencia);
            this.Controls.Add(this.LblBuscaTamanho);
            this.Controls.Add(this.LblBuscaCode);
            this.Controls.Add(this.TxtQueryByReference);
            this.Controls.Add(this.TxtQueryBySize);
            this.Controls.Add(this.TxtQueryByCode);
            this.Controls.Add(this.TxtQueryByDescription);
            this.Controls.Add(this.GridStockList);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmStockList";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmStockList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridStockList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryBySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByDescription)).EndInit();
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboResume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingNavigatorPaginacao)).EndInit();
            this.BindingNavigatorPaginacao.ResumeLayout(false);
            this.BindingNavigatorPaginacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridStockList;
        private Syncfusion.WinForms.ListView.SfComboBox CboPageSize;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private System.Windows.Forms.Label LblNumeroDeRegistros;
        private System.Windows.Forms.Label LblBuscaDescricao;
        private System.Windows.Forms.Label LblBuscaReferencia;
        private System.Windows.Forms.Label LblBuscaTamanho;
        private System.Windows.Forms.Label LblBuscaCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByReference;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryBySize;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByDescription;
        private System.Windows.Forms.Timer Timer;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        public System.Windows.Forms.Label LblDataLong;
        public System.Windows.Forms.Label LblCaptionListaProduto;
        private System.Windows.Forms.PictureBox ImgGifLoading;
        private Syncfusion.WinForms.Controls.SfButton BtnAtualizar;
        private Syncfusion.WinForms.Controls.SfButton BtnReport;
        private Syncfusion.WinForms.ListView.SfComboBox CboResume;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private System.Windows.Forms.Label LblResumo;
        private System.Windows.Forms.LinkLabel LblLimpar;
        private System.Windows.Forms.BindingNavigator BindingNavigatorPaginacao;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripButton NextPage;
    }
}