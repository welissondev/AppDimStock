namespace SysEstoque.View
{
    partial class FrmEstoqueLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueLista));
            this.GridListaEstoque = new System.Windows.Forms.DataGridView();
            this.CboQuantidadeDeRegistros = new Syncfusion.WinForms.ListView.SfComboBox();
            this.textBoxExt1 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblNumeroDeRegistros = new System.Windows.Forms.Label();
            this.LblBuscaDescricao = new System.Windows.Forms.Label();
            this.LblBuscaReferencia = new System.Windows.Forms.Label();
            this.LblBuscaTamanho = new System.Windows.Forms.Label();
            this.LblBuscaCode = new System.Windows.Forms.Label();
            this.TxtBuscarReferencia = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscaTamanho = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscaCodigo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscarDescricao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TimerExecultaConsulta = new System.Windows.Forms.Timer(this.components);
            this.PanelHorizontalSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnRelatorio = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnAtualizar = new Syncfusion.WinForms.Controls.SfButton();
            this.LblDataLong = new System.Windows.Forms.Label();
            this.LblCaptionListaProduto = new System.Windows.Forms.Label();
            this.PicCarregando = new System.Windows.Forms.PictureBox();
            this.CboResumo = new Syncfusion.WinForms.ListView.SfComboBox();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblResumo = new System.Windows.Forms.Label();
            this.LblLimpar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaEstoque)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboQuantidadeDeRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).BeginInit();
            this.PanelHorizontalSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboResumo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            this.SuspendLayout();
            // 
            // GridListaEstoque
            // 
            this.GridListaEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridListaEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListaEstoque.Location = new System.Drawing.Point(28, 197);
            this.GridListaEstoque.Name = "GridListaEstoque";
            this.GridListaEstoque.Size = new System.Drawing.Size(1004, 459);
            this.GridListaEstoque.TabIndex = 70;
            this.GridListaEstoque.Layout += new System.Windows.Forms.LayoutEventHandler(this.GridListaEstoque_Layout);
            // 
            // CboQuantidadeDeRegistros
            // 
            this.CboQuantidadeDeRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboQuantidadeDeRegistros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboQuantidadeDeRegistros.Location = new System.Drawing.Point(701, 165);
            this.CboQuantidadeDeRegistros.Name = "CboQuantidadeDeRegistros";
            this.CboQuantidadeDeRegistros.Size = new System.Drawing.Size(174, 25);
            this.CboQuantidadeDeRegistros.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboQuantidadeDeRegistros.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CboQuantidadeDeRegistros.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboQuantidadeDeRegistros.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboQuantidadeDeRegistros.TabIndex = 101;
            this.CboQuantidadeDeRegistros.ToolTipOption.ShadowVisible = false;
            this.CboQuantidadeDeRegistros.SelectedIndexChanged += new System.EventHandler(this.CboNumeroDeRegistros_SelectedIndexChanged);
            this.CboQuantidadeDeRegistros.Click += new System.EventHandler(this.CboNumeroDeRegistros_SelectedIndexChanged);
            this.CboQuantidadeDeRegistros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecultarFiltros_KeyPress);
            // 
            // textBoxExt1
            // 
            this.textBoxExt1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt1.BeforeTouchSize = new System.Drawing.Size(208, 29);
            this.textBoxExt1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt1.CanOverrideStyle = true;
            this.textBoxExt1.CausesValidation = false;
            this.textBoxExt1.CornerRadius = 4;
            this.textBoxExt1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxExt1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt1.Location = new System.Drawing.Point(699, 163);
            this.textBoxExt1.MaxLength = 50;
            this.textBoxExt1.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
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
            // TxtBuscarReferencia
            // 
            this.TxtBuscarReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarReferencia.BeforeTouchSize = new System.Drawing.Size(208, 29);
            this.TxtBuscarReferencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarReferencia.CanOverrideStyle = true;
            this.TxtBuscarReferencia.CausesValidation = false;
            this.TxtBuscarReferencia.CornerRadius = 4;
            this.TxtBuscarReferencia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarReferencia.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarReferencia.Location = new System.Drawing.Point(378, 163);
            this.TxtBuscarReferencia.MaxLength = 50;
            this.TxtBuscarReferencia.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscarReferencia.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarReferencia.Multiline = true;
            this.TxtBuscarReferencia.Name = "TxtBuscarReferencia";
            this.TxtBuscarReferencia.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarReferencia.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarReferencia.Size = new System.Drawing.Size(105, 29);
            this.TxtBuscarReferencia.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarReferencia.TabIndex = 98;
            this.TxtBuscarReferencia.Tag = "";
            this.TxtBuscarReferencia.ThemeName = "Office2016Colorful";
            this.TxtBuscarReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecultarFiltros_KeyPress);
            // 
            // TxtBuscaTamanho
            // 
            this.TxtBuscaTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscaTamanho.BeforeTouchSize = new System.Drawing.Size(208, 29);
            this.TxtBuscaTamanho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscaTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscaTamanho.CanOverrideStyle = true;
            this.TxtBuscaTamanho.CausesValidation = false;
            this.TxtBuscaTamanho.CornerRadius = 4;
            this.TxtBuscaTamanho.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscaTamanho.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscaTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscaTamanho.Location = new System.Drawing.Point(275, 163);
            this.TxtBuscaTamanho.MaxLength = 50;
            this.TxtBuscaTamanho.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscaTamanho.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscaTamanho.Multiline = true;
            this.TxtBuscaTamanho.Name = "TxtBuscaTamanho";
            this.TxtBuscaTamanho.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscaTamanho.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscaTamanho.Size = new System.Drawing.Size(100, 29);
            this.TxtBuscaTamanho.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscaTamanho.TabIndex = 97;
            this.TxtBuscaTamanho.Tag = "";
            this.TxtBuscaTamanho.ThemeName = "Office2016Colorful";
            this.TxtBuscaTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecultarFiltros_KeyPress);
            // 
            // TxtBuscaCodigo
            // 
            this.TxtBuscaCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscaCodigo.BeforeTouchSize = new System.Drawing.Size(208, 29);
            this.TxtBuscaCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscaCodigo.CanOverrideStyle = true;
            this.TxtBuscaCodigo.CausesValidation = false;
            this.TxtBuscaCodigo.CornerRadius = 4;
            this.TxtBuscaCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscaCodigo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscaCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscaCodigo.Location = new System.Drawing.Point(163, 163);
            this.TxtBuscaCodigo.MaxLength = 50;
            this.TxtBuscaCodigo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscaCodigo.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscaCodigo.Multiline = true;
            this.TxtBuscaCodigo.Name = "TxtBuscaCodigo";
            this.TxtBuscaCodigo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscaCodigo.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscaCodigo.Size = new System.Drawing.Size(109, 29);
            this.TxtBuscaCodigo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscaCodigo.TabIndex = 96;
            this.TxtBuscaCodigo.Tag = "";
            this.TxtBuscaCodigo.ThemeName = "Office2016Colorful";
            this.TxtBuscaCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecultarFiltros_KeyPress);
            // 
            // TxtBuscarDescricao
            // 
            this.TxtBuscarDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarDescricao.BeforeTouchSize = new System.Drawing.Size(208, 29);
            this.TxtBuscarDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarDescricao.CanOverrideStyle = true;
            this.TxtBuscarDescricao.CausesValidation = false;
            this.TxtBuscarDescricao.CornerRadius = 4;
            this.TxtBuscarDescricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarDescricao.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarDescricao.Location = new System.Drawing.Point(487, 163);
            this.TxtBuscarDescricao.MaxLength = 50;
            this.TxtBuscarDescricao.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscarDescricao.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarDescricao.Multiline = true;
            this.TxtBuscarDescricao.Name = "TxtBuscarDescricao";
            this.TxtBuscarDescricao.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarDescricao.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarDescricao.Size = new System.Drawing.Size(208, 29);
            this.TxtBuscarDescricao.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarDescricao.TabIndex = 100;
            this.TxtBuscarDescricao.Tag = "";
            this.TxtBuscarDescricao.ThemeName = "Office2016Colorful";
            this.TxtBuscarDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecultarFiltros_KeyPress);
            // 
            // TimerExecultaConsulta
            // 
            this.TimerExecultaConsulta.Interval = 1000;
            this.TimerExecultaConsulta.Tick += new System.EventHandler(this.TimerExecultaConsulta_Tick);
            // 
            // PanelHorizontalSuperior
            // 
            this.PanelHorizontalSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHorizontalSuperior.BackgroundImage")));
            this.PanelHorizontalSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHorizontalSuperior.Controls.Add(this.BtnRelatorio);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnAtualizar);
            this.PanelHorizontalSuperior.Controls.Add(this.LblDataLong);
            this.PanelHorizontalSuperior.Controls.Add(this.LblCaptionListaProduto);
            this.PanelHorizontalSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontalSuperior.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientTopLeft = System.Drawing.SystemColors.ControlText;
            this.PanelHorizontalSuperior.GradientTopRight = System.Drawing.SystemColors.ControlText;
            this.PanelHorizontalSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelHorizontalSuperior.Name = "PanelHorizontalSuperior";
            this.PanelHorizontalSuperior.Quality = 10;
            this.PanelHorizontalSuperior.Size = new System.Drawing.Size(1057, 95);
            this.PanelHorizontalSuperior.TabIndex = 141;
            // 
            // BtnRelatorio
            // 
            this.BtnRelatorio.AccessibleName = "Button";
            this.BtnRelatorio.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnRelatorio.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelatorio.ForeColor = System.Drawing.Color.White;
            this.BtnRelatorio.Location = new System.Drawing.Point(103, 47);
            this.BtnRelatorio.Name = "BtnRelatorio";
            this.BtnRelatorio.Size = new System.Drawing.Size(80, 35);
            this.BtnRelatorio.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnRelatorio.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnRelatorio.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnRelatorio.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnRelatorio.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnRelatorio.Style.ForeColor = System.Drawing.Color.White;
            this.BtnRelatorio.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnRelatorio.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnRelatorio.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnRelatorio.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnRelatorio.TabIndex = 141;
            this.BtnRelatorio.Text = "Relatório";
            this.BtnRelatorio.UseVisualStyleBackColor = false;
            this.BtnRelatorio.Click += new System.EventHandler(this.BrnRelatorio_Click);
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
            // PicCarregando
            // 
            this.PicCarregando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicCarregando.Image = global::SysEstoque.Properties.Resources.Load;
            this.PicCarregando.Location = new System.Drawing.Point(465, 356);
            this.PicCarregando.Name = "PicCarregando";
            this.PicCarregando.Size = new System.Drawing.Size(129, 137);
            this.PicCarregando.TabIndex = 142;
            this.PicCarregando.TabStop = false;
            this.PicCarregando.Visible = false;
            // 
            // CboResumo
            // 
            this.CboResumo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboResumo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboResumo.Location = new System.Drawing.Point(30, 165);
            this.CboResumo.Name = "CboResumo";
            this.CboResumo.Size = new System.Drawing.Size(129, 25);
            this.CboResumo.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboResumo.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CboResumo.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboResumo.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboResumo.TabIndex = 143;
            this.CboResumo.ToolTipOption.ShadowVisible = false;
            this.CboResumo.SelectedIndexChanged += new System.EventHandler(this.CboResumo_SelectedIndexChanged);
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(208, 29);
            this.textBoxExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt2.CanOverrideStyle = true;
            this.textBoxExt2.CausesValidation = false;
            this.textBoxExt2.CornerRadius = 4;
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxExt2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt2.Location = new System.Drawing.Point(28, 163);
            this.textBoxExt2.MaxLength = 50;
            this.textBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
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
            // FrmEstoqueLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 681);
            this.Controls.Add(this.LblLimpar);
            this.Controls.Add(this.CboResumo);
            this.Controls.Add(this.textBoxExt2);
            this.Controls.Add(this.LblResumo);
            this.Controls.Add(this.PicCarregando);
            this.Controls.Add(this.PanelHorizontalSuperior);
            this.Controls.Add(this.CboQuantidadeDeRegistros);
            this.Controls.Add(this.textBoxExt1);
            this.Controls.Add(this.LblNumeroDeRegistros);
            this.Controls.Add(this.LblBuscaDescricao);
            this.Controls.Add(this.LblBuscaReferencia);
            this.Controls.Add(this.LblBuscaTamanho);
            this.Controls.Add(this.LblBuscaCode);
            this.Controls.Add(this.TxtBuscarReferencia);
            this.Controls.Add(this.TxtBuscaTamanho);
            this.Controls.Add(this.TxtBuscaCodigo);
            this.Controls.Add(this.TxtBuscarDescricao);
            this.Controls.Add(this.GridListaEstoque);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmEstoqueLista";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEstoqueLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaEstoque)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboQuantidadeDeRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).EndInit();
            this.PanelHorizontalSuperior.ResumeLayout(false);
            this.PanelHorizontalSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboResumo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridListaEstoque;
        private Syncfusion.WinForms.ListView.SfComboBox CboQuantidadeDeRegistros;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt1;
        private System.Windows.Forms.Label LblNumeroDeRegistros;
        private System.Windows.Forms.Label LblBuscaDescricao;
        private System.Windows.Forms.Label LblBuscaReferencia;
        private System.Windows.Forms.Label LblBuscaTamanho;
        private System.Windows.Forms.Label LblBuscaCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarReferencia;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscaTamanho;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscaCodigo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarDescricao;
        private System.Windows.Forms.Timer TimerExecultaConsulta;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelHorizontalSuperior;
        public System.Windows.Forms.Label LblDataLong;
        public System.Windows.Forms.Label LblCaptionListaProduto;
        private System.Windows.Forms.PictureBox PicCarregando;
        private Syncfusion.WinForms.Controls.SfButton BtnAtualizar;
        private Syncfusion.WinForms.Controls.SfButton BtnRelatorio;
        private Syncfusion.WinForms.ListView.SfComboBox CboResumo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private System.Windows.Forms.Label LblResumo;
        private System.Windows.Forms.LinkLabel LblLimpar;
    }
}