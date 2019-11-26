namespace DimStock.View
{
    partial class FrmProdutoLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutoLista));
            this.TxtBuscarDescricao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.GridListaProduto = new System.Windows.Forms.DataGridView();
            this.PicCarregando = new System.Windows.Forms.PictureBox();
            this.CboNumeroDeRegistros = new Syncfusion.WinForms.ListView.SfComboBox();
            this.TxtOcultNumberOfRecords = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblNumeroDeRegistros = new System.Windows.Forms.Label();
            this.LblBuscarDescricao = new System.Windows.Forms.Label();
            this.LblBuscarReferencia = new System.Windows.Forms.Label();
            this.LblBuscarTamanho = new System.Windows.Forms.Label();
            this.LblBuscarCodigo = new System.Windows.Forms.Label();
            this.TxtBuscarReferencia = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscarTamanho = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscarCodigo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TimeExecutaConsulta = new System.Windows.Forms.Timer(this.components);
            this.PanelHorizontalSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnReport = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnAtualizar = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnNovo = new Syncfusion.WinForms.Controls.SfButton();
            this.LblDataLong = new System.Windows.Forms.Label();
            this.LblCaptionListaProduto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboNumeroDeRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOcultNumberOfRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCodigo)).BeginInit();
            this.PanelHorizontalSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtBuscarDescricao
            // 
            this.TxtBuscarDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarDescricao.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtBuscarDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarDescricao.CanOverrideStyle = true;
            this.TxtBuscarDescricao.CausesValidation = false;
            this.TxtBuscarDescricao.CornerRadius = 4;
            this.TxtBuscarDescricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarDescricao.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarDescricao.Location = new System.Drawing.Point(444, 139);
            this.TxtBuscarDescricao.MaxLength = 50;
            this.TxtBuscarDescricao.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtBuscarDescricao.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarDescricao.Multiline = true;
            this.TxtBuscarDescricao.Name = "TxtBuscarDescricao";
            this.TxtBuscarDescricao.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarDescricao.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarDescricao.Size = new System.Drawing.Size(211, 29);
            this.TxtBuscarDescricao.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarDescricao.TabIndex = 4;
            this.TxtBuscarDescricao.Tag = "";
            this.TxtBuscarDescricao.ThemeName = "Office2016Colorful";
            this.TxtBuscarDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecutaFiltros_KeyPress);
            // 
            // GridListaProduto
            // 
            this.GridListaProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridListaProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListaProduto.Location = new System.Drawing.Point(17, 187);
            this.GridListaProduto.Name = "GridListaProduto";
            this.GridListaProduto.Size = new System.Drawing.Size(935, 471);
            this.GridListaProduto.TabIndex = 69;
            this.GridListaProduto.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListaProduto_CellClick);
            this.GridListaProduto.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridListaProduto_CellMouseDoubleClick);
            this.GridListaProduto.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridListaProduto_CellMouseMove);
            this.GridListaProduto.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.GridListaProduto_RowPrePaint);
            this.GridListaProduto.Layout += new System.Windows.Forms.LayoutEventHandler(this.GridListaProduto_Layout);
            // 
            // PicCarregando
            // 
            this.PicCarregando.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PicCarregando.Image = global::DimStock.Properties.Resources.Load;
            this.PicCarregando.Location = new System.Drawing.Point(431, 365);
            this.PicCarregando.Name = "PicCarregando";
            this.PicCarregando.Size = new System.Drawing.Size(138, 131);
            this.PicCarregando.TabIndex = 85;
            this.PicCarregando.TabStop = false;
            this.PicCarregando.Visible = false;
            // 
            // CboNumeroDeRegistros
            // 
            this.CboNumeroDeRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboNumeroDeRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboNumeroDeRegistros.Location = new System.Drawing.Point(665, 142);
            this.CboNumeroDeRegistros.Name = "CboNumeroDeRegistros";
            this.CboNumeroDeRegistros.Size = new System.Drawing.Size(165, 25);
            this.CboNumeroDeRegistros.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboNumeroDeRegistros.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CboNumeroDeRegistros.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboNumeroDeRegistros.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboNumeroDeRegistros.TabIndex = 6;
            this.CboNumeroDeRegistros.ToolTipOption.ShadowVisible = false;
            this.CboNumeroDeRegistros.SelectedIndexChanged += new System.EventHandler(this.CboNumeroDeRegistros_SelectedIndexChanged);
            // 
            // TxtOcultNumberOfRecords
            // 
            this.TxtOcultNumberOfRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtOcultNumberOfRecords.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtOcultNumberOfRecords.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtOcultNumberOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOcultNumberOfRecords.CanOverrideStyle = true;
            this.TxtOcultNumberOfRecords.CausesValidation = false;
            this.TxtOcultNumberOfRecords.CornerRadius = 4;
            this.TxtOcultNumberOfRecords.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtOcultNumberOfRecords.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOcultNumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtOcultNumberOfRecords.Location = new System.Drawing.Point(659, 139);
            this.TxtOcultNumberOfRecords.MaxLength = 50;
            this.TxtOcultNumberOfRecords.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtOcultNumberOfRecords.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtOcultNumberOfRecords.Multiline = true;
            this.TxtOcultNumberOfRecords.Name = "TxtOcultNumberOfRecords";
            this.TxtOcultNumberOfRecords.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtOcultNumberOfRecords.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtOcultNumberOfRecords.Size = new System.Drawing.Size(174, 29);
            this.TxtOcultNumberOfRecords.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtOcultNumberOfRecords.TabIndex = 92;
            this.TxtOcultNumberOfRecords.Tag = "";
            this.TxtOcultNumberOfRecords.ThemeName = "Office2016Colorful";
            // 
            // LblNumeroDeRegistros
            // 
            this.LblNumeroDeRegistros.AutoSize = true;
            this.LblNumeroDeRegistros.Location = new System.Drawing.Point(658, 125);
            this.LblNumeroDeRegistros.Name = "LblNumeroDeRegistros";
            this.LblNumeroDeRegistros.Size = new System.Drawing.Size(107, 13);
            this.LblNumeroDeRegistros.TabIndex = 91;
            this.LblNumeroDeRegistros.Text = "Registros por página:";
            // 
            // LblBuscarDescricao
            // 
            this.LblBuscarDescricao.AutoSize = true;
            this.LblBuscarDescricao.Location = new System.Drawing.Point(441, 123);
            this.LblBuscarDescricao.Name = "LblBuscarDescricao";
            this.LblBuscarDescricao.Size = new System.Drawing.Size(112, 13);
            this.LblBuscarDescricao.TabIndex = 90;
            this.LblBuscarDescricao.Text = "Descrição do produto:";
            // 
            // LblBuscarReferencia
            // 
            this.LblBuscarReferencia.AutoSize = true;
            this.LblBuscarReferencia.Location = new System.Drawing.Point(299, 123);
            this.LblBuscarReferencia.Name = "LblBuscarReferencia";
            this.LblBuscarReferencia.Size = new System.Drawing.Size(62, 13);
            this.LblBuscarReferencia.TabIndex = 89;
            this.LblBuscarReferencia.Text = "Referência:";
            // 
            // LblBuscarTamanho
            // 
            this.LblBuscarTamanho.AutoSize = true;
            this.LblBuscarTamanho.Location = new System.Drawing.Point(157, 123);
            this.LblBuscarTamanho.Name = "LblBuscarTamanho";
            this.LblBuscarTamanho.Size = new System.Drawing.Size(55, 13);
            this.LblBuscarTamanho.TabIndex = 88;
            this.LblBuscarTamanho.Text = "Tamanho:";
            // 
            // LblBuscarCodigo
            // 
            this.LblBuscarCodigo.AutoSize = true;
            this.LblBuscarCodigo.Location = new System.Drawing.Point(15, 123);
            this.LblBuscarCodigo.Name = "LblBuscarCodigo";
            this.LblBuscarCodigo.Size = new System.Drawing.Size(83, 13);
            this.LblBuscarCodigo.TabIndex = 87;
            this.LblBuscarCodigo.Text = "Código Produto:";
            // 
            // TxtBuscarReferencia
            // 
            this.TxtBuscarReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarReferencia.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtBuscarReferencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarReferencia.CanOverrideStyle = true;
            this.TxtBuscarReferencia.CausesValidation = false;
            this.TxtBuscarReferencia.CornerRadius = 4;
            this.TxtBuscarReferencia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarReferencia.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarReferencia.Location = new System.Drawing.Point(302, 139);
            this.TxtBuscarReferencia.MaxLength = 50;
            this.TxtBuscarReferencia.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtBuscarReferencia.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarReferencia.Multiline = true;
            this.TxtBuscarReferencia.Name = "TxtBuscarReferencia";
            this.TxtBuscarReferencia.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarReferencia.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarReferencia.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscarReferencia.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarReferencia.TabIndex = 2;
            this.TxtBuscarReferencia.Tag = "";
            this.TxtBuscarReferencia.ThemeName = "Office2016Colorful";
            this.TxtBuscarReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecutaFiltros_KeyPress);
            // 
            // TxtBuscarTamanho
            // 
            this.TxtBuscarTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarTamanho.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtBuscarTamanho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarTamanho.CanOverrideStyle = true;
            this.TxtBuscarTamanho.CausesValidation = false;
            this.TxtBuscarTamanho.CornerRadius = 4;
            this.TxtBuscarTamanho.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarTamanho.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarTamanho.Location = new System.Drawing.Point(160, 139);
            this.TxtBuscarTamanho.MaxLength = 50;
            this.TxtBuscarTamanho.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtBuscarTamanho.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarTamanho.Multiline = true;
            this.TxtBuscarTamanho.Name = "TxtBuscarTamanho";
            this.TxtBuscarTamanho.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarTamanho.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarTamanho.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscarTamanho.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarTamanho.TabIndex = 1;
            this.TxtBuscarTamanho.Tag = "";
            this.TxtBuscarTamanho.ThemeName = "Office2016Colorful";
            this.TxtBuscarTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecutaFiltros_KeyPress);
            // 
            // TxtBuscarCodigo
            // 
            this.TxtBuscarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarCodigo.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtBuscarCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarCodigo.CanOverrideStyle = true;
            this.TxtBuscarCodigo.CausesValidation = false;
            this.TxtBuscarCodigo.CornerRadius = 4;
            this.TxtBuscarCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarCodigo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarCodigo.Location = new System.Drawing.Point(18, 139);
            this.TxtBuscarCodigo.MaxLength = 50;
            this.TxtBuscarCodigo.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtBuscarCodigo.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarCodigo.Multiline = true;
            this.TxtBuscarCodigo.Name = "TxtBuscarCodigo";
            this.TxtBuscarCodigo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarCodigo.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarCodigo.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscarCodigo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarCodigo.TabIndex = 0;
            this.TxtBuscarCodigo.Tag = "";
            this.TxtBuscarCodigo.ThemeName = "Office2016Colorful";
            this.TxtBuscarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecutaFiltros_KeyPress);
            // 
            // TimeExecutaConsulta
            // 
            this.TimeExecutaConsulta.Interval = 1000;
            this.TimeExecutaConsulta.Tick += new System.EventHandler(this.TimeExecutaConsulta_Tick);
            // 
            // PanelHorizontalSuperior
            // 
            this.PanelHorizontalSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHorizontalSuperior.BackgroundImage")));
            this.PanelHorizontalSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHorizontalSuperior.Controls.Add(this.BtnReport);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnAtualizar);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnNovo);
            this.PanelHorizontalSuperior.Controls.Add(this.LblDataLong);
            this.PanelHorizontalSuperior.Controls.Add(this.LblCaptionListaProduto);
            this.PanelHorizontalSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontalSuperior.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.PanelHorizontalSuperior.GradientTopLeft = System.Drawing.SystemColors.ControlText;
            this.PanelHorizontalSuperior.GradientTopRight = System.Drawing.SystemColors.InactiveCaptionText;
            this.PanelHorizontalSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelHorizontalSuperior.Name = "PanelHorizontalSuperior";
            this.PanelHorizontalSuperior.Quality = 10;
            this.PanelHorizontalSuperior.Size = new System.Drawing.Size(964, 93);
            this.PanelHorizontalSuperior.TabIndex = 140;
            // 
            // BtnReport
            // 
            this.BtnReport.AccessibleName = "Button";
            this.BtnReport.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnReport.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReport.ForeColor = System.Drawing.Color.White;
            this.BtnReport.Location = new System.Drawing.Point(184, 46);
            this.BtnReport.Name = "BtnReport";
            this.BtnReport.Size = new System.Drawing.Size(80, 35);
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
            this.BtnReport.TabIndex = 143;
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
            this.BtnAtualizar.Location = new System.Drawing.Point(101, 46);
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
            this.BtnAtualizar.TabIndex = 142;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // BtnNovo
            // 
            this.BtnNovo.AccessibleName = "Button";
            this.BtnNovo.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovo.ForeColor = System.Drawing.Color.White;
            this.BtnNovo.Location = new System.Drawing.Point(18, 46);
            this.BtnNovo.Name = "BtnNovo";
            this.BtnNovo.Size = new System.Drawing.Size(80, 35);
            this.BtnNovo.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovo.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovo.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnNovo.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovo.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnNovo.Style.ForeColor = System.Drawing.Color.White;
            this.BtnNovo.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNovo.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnNovo.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovo.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnNovo.TabIndex = 141;
            this.BtnNovo.Text = "Novo";
            this.BtnNovo.UseVisualStyleBackColor = false;
            this.BtnNovo.Click += new System.EventHandler(this.BtnNovo_Click);
            // 
            // LblDataLong
            // 
            this.LblDataLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDataLong.BackColor = System.Drawing.Color.Transparent;
            this.LblDataLong.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataLong.ForeColor = System.Drawing.Color.White;
            this.LblDataLong.Location = new System.Drawing.Point(442, 24);
            this.LblDataLong.Name = "LblDataLong";
            this.LblDataLong.Size = new System.Drawing.Size(517, 40);
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
            this.LblCaptionListaProduto.Size = new System.Drawing.Size(272, 40);
            this.LblCaptionListaProduto.TabIndex = 138;
            this.LblCaptionListaProduto.Text = "Lista de Produtos";
            // 
            // FrmProdutoLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.PicCarregando);
            this.Controls.Add(this.PanelHorizontalSuperior);
            this.Controls.Add(this.CboNumeroDeRegistros);
            this.Controls.Add(this.TxtBuscarDescricao);
            this.Controls.Add(this.GridListaProduto);
            this.Controls.Add(this.TxtBuscarCodigo);
            this.Controls.Add(this.TxtBuscarTamanho);
            this.Controls.Add(this.TxtBuscarReferencia);
            this.Controls.Add(this.TxtOcultNumberOfRecords);
            this.Controls.Add(this.LblBuscarCodigo);
            this.Controls.Add(this.LblNumeroDeRegistros);
            this.Controls.Add(this.LblBuscarTamanho);
            this.Controls.Add(this.LblBuscarDescricao);
            this.Controls.Add(this.LblBuscarReferencia);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmProdutoLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProdutoLista_Load);
            this.Resize += new System.EventHandler(this.FrmProdutoLista_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboNumeroDeRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOcultNumberOfRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCodigo)).EndInit();
            this.PanelHorizontalSuperior.ResumeLayout(false);
            this.PanelHorizontalSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarDescricao;
        private System.Windows.Forms.DataGridView GridListaProduto;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarReferencia;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarTamanho;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarCodigo;
        private System.Windows.Forms.Label LblBuscarDescricao;
        private System.Windows.Forms.Label LblBuscarReferencia;
        private System.Windows.Forms.Label LblBuscarTamanho;
        private System.Windows.Forms.Label LblBuscarCodigo;
        private System.Windows.Forms.Label LblNumeroDeRegistros;
        private System.Windows.Forms.Timer TimeExecutaConsulta;
        private System.Windows.Forms.PictureBox PicCarregando;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtOcultNumberOfRecords;
        private Syncfusion.WinForms.ListView.SfComboBox CboNumeroDeRegistros;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelHorizontalSuperior;
        public System.Windows.Forms.Label LblDataLong;
        public System.Windows.Forms.Label LblCaptionListaProduto;
        private Syncfusion.WinForms.Controls.SfButton BtnNovo;
        private Syncfusion.WinForms.Controls.SfButton BtnAtualizar;
        private Syncfusion.WinForms.Controls.SfButton BtnReport;
    }
}