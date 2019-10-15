namespace SysEstoque.View
{
    partial class FrmEstoqueAtividade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueAtividade));
            this.TimerExecultaConsulta = new System.Windows.Forms.Timer(this.components);
            this.LblSubTotal = new System.Windows.Forms.Label();
            this.TxtSubTotal = new System.Windows.Forms.Label();
            this.BtnAdcionarItem = new Syncfusion.WinForms.Controls.SfButton();
            this.TxtQuantidade = new Syncfusion.Windows.Forms.Tools.IntegerTextBox();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.TxtValorTotal = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.LblValorUnitario = new System.Windows.Forms.Label();
            this.TxtValorUnitario = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.LblBuscaDescricao = new System.Windows.Forms.Label();
            this.LblBuscarReferencia = new System.Windows.Forms.Label();
            this.LblBuscaTamanho = new System.Windows.Forms.Label();
            this.TxtBuscarDescricao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblBuscaCodigo = new System.Windows.Forms.Label();
            this.TxtBuscarCodigo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscarReferencia = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscarTamanho = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblAtividadeNumero = new System.Windows.Forms.Label();
            this.TxtAtividadeNumero = new System.Windows.Forms.Label();
            this.TxtHorario = new System.Windows.Forms.Label();
            this.LblHorario = new System.Windows.Forms.Label();
            this.TxtData = new System.Windows.Forms.Label();
            this.LblData = new System.Windows.Forms.Label();
            this.TxtSituacao = new System.Windows.Forms.Label();
            this.LblSituacao = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.LblLimpar = new System.Windows.Forms.LinkLabel();
            this.PicCarregando = new System.Windows.Forms.PictureBox();
            this.TxtTotalItens = new System.Windows.Forms.Label();
            this.LblTotalItens = new System.Windows.Forms.Label();
            this.GridListaPrincipal = new SysEstoque.Auxiliary.AxlListEstoqueItem();
            this.BtnDeletarAtividade = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnConfirmar = new Syncfusion.WinForms.Controls.SfButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblAtividadeTipo = new System.Windows.Forms.Label();
            this.TxtAtividadeTipo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelHorizontalSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.LblDataLong = new System.Windows.Forms.Label();
            this.LblCaptionAtividade = new System.Windows.Forms.Label();
            this.BtnNovaAtividade = new Syncfusion.WinForms.Controls.SfButton();
            this.CboEstoqueDestino = new System.Windows.Forms.ComboBox();
            this.LblCadastrarNovo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValorTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValorUnitario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarTamanho)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaPrincipal)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.PanelHorizontalSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerExecultaConsulta
            // 
            this.TimerExecultaConsulta.Interval = 1000;
            this.TimerExecultaConsulta.Tick += new System.EventHandler(this.TimerExecultaConsulta_Tick);
            // 
            // LblSubTotal
            // 
            this.LblSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblSubTotal.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSubTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblSubTotal.Location = new System.Drawing.Point(305, 325);
            this.LblSubTotal.Name = "LblSubTotal";
            this.LblSubTotal.Size = new System.Drawing.Size(149, 32);
            this.LblSubTotal.TabIndex = 115;
            this.LblSubTotal.Text = "SUBTOTAL:";
            // 
            // TxtSubTotal
            // 
            this.TxtSubTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtSubTotal.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubTotal.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.TxtSubTotal.Location = new System.Drawing.Point(460, 325);
            this.TxtSubTotal.Name = "TxtSubTotal";
            this.TxtSubTotal.Size = new System.Drawing.Size(224, 32);
            this.TxtSubTotal.TabIndex = 116;
            this.TxtSubTotal.Text = "R$0.00";
            // 
            // BtnAdcionarItem
            // 
            this.BtnAdcionarItem.AccessibleName = "Button";
            this.BtnAdcionarItem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdcionarItem.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAdcionarItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdcionarItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.BtnAdcionarItem.ForeColor = System.Drawing.Color.White;
            this.BtnAdcionarItem.Location = new System.Drawing.Point(838, 28);
            this.BtnAdcionarItem.Name = "BtnAdcionarItem";
            this.BtnAdcionarItem.Size = new System.Drawing.Size(44, 28);
            this.BtnAdcionarItem.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAdcionarItem.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnAdcionarItem.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAdcionarItem.Style.FocusedBackColor = System.Drawing.Color.Crimson;
            this.BtnAdcionarItem.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnAdcionarItem.Style.ForeColor = System.Drawing.Color.White;
            this.BtnAdcionarItem.Style.HoverBackColor = System.Drawing.Color.PaleVioletRed;
            this.BtnAdcionarItem.Style.HoverForeColor = System.Drawing.Color.White;
            this.BtnAdcionarItem.Style.PressedBackColor = System.Drawing.Color.Crimson;
            this.BtnAdcionarItem.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnAdcionarItem.TabIndex = 7;
            this.BtnAdcionarItem.Text = "Add";
            this.BtnAdcionarItem.UseVisualStyleBackColor = false;
            this.BtnAdcionarItem.Click += new System.EventHandler(this.BtnAdcionarItem_Click);
            // 
            // TxtQuantidade
            // 
            this.TxtQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtQuantidade.BeforeTouchSize = new System.Drawing.Size(85, 29);
            this.TxtQuantidade.BorderColor = System.Drawing.Color.Gray;
            this.TxtQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQuantidade.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQuantidade.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQuantidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQuantidade.IntegerValue = ((long)(0));
            this.TxtQuantidade.Location = new System.Drawing.Point(640, 28);
            this.TxtQuantidade.Metrocolor = System.Drawing.Color.Green;
            this.TxtQuantidade.MinimumSize = new System.Drawing.Size(14, 10);
            this.TxtQuantidade.Name = "TxtQuantidade";
            this.TxtQuantidade.NegativeSign = "";
            this.TxtQuantidade.NullString = "";
            this.TxtQuantidade.NumberGroupSeparator = "";
            this.TxtQuantidade.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQuantidade.Size = new System.Drawing.Size(65, 29);
            this.TxtQuantidade.TabIndex = 5;
            this.TxtQuantidade.ThemeName = "Default";
            this.TxtQuantidade.WordWrap = false;
            this.TxtQuantidade.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQuantidade_KeyPress);
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTotal.Location = new System.Drawing.Point(708, 9);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(37, 15);
            this.LblValorTotal.TabIndex = 135;
            this.LblValorTotal.Text = "Total:";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValorTotal.BeforeTouchSize = new System.Drawing.Size(85, 29);
            this.TxtValorTotal.BorderColor = System.Drawing.Color.Gray;
            this.TxtValorTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValorTotal.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtValorTotal.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TxtValorTotal.Enabled = false;
            this.TxtValorTotal.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TxtValorTotal.Location = new System.Drawing.Point(711, 28);
            this.TxtValorTotal.Metrocolor = System.Drawing.Color.Green;
            this.TxtValorTotal.MinimumSize = new System.Drawing.Size(14, 10);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.NullString = "";
            this.TxtValorTotal.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TxtValorTotal.Size = new System.Drawing.Size(121, 29);
            this.TxtValorTotal.TabIndex = 6;
            this.TxtValorTotal.Text = "R$ 0,00";
            this.TxtValorTotal.ThemeName = "Default";
            this.TxtValorTotal.WordWrap = false;
            this.TxtValorTotal.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            // 
            // LblValorUnitario
            // 
            this.LblValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblValorUnitario.AutoSize = true;
            this.LblValorUnitario.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorUnitario.Location = new System.Drawing.Point(507, 9);
            this.LblValorUnitario.Name = "LblValorUnitario";
            this.LblValorUnitario.Size = new System.Drawing.Size(60, 15);
            this.LblValorUnitario.TabIndex = 133;
            this.LblValorUnitario.Text = "Valor Uni.";
            // 
            // TxtValorUnitario
            // 
            this.TxtValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtValorUnitario.BeforeTouchSize = new System.Drawing.Size(85, 29);
            this.TxtValorUnitario.BorderColor = System.Drawing.Color.Gray;
            this.TxtValorUnitario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtValorUnitario.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtValorUnitario.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TxtValorUnitario.Enabled = false;
            this.TxtValorUnitario.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtValorUnitario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtValorUnitario.Location = new System.Drawing.Point(510, 28);
            this.TxtValorUnitario.Metrocolor = System.Drawing.Color.Green;
            this.TxtValorUnitario.MinimumSize = new System.Drawing.Size(14, 10);
            this.TxtValorUnitario.Name = "TxtValorUnitario";
            this.TxtValorUnitario.NullString = "";
            this.TxtValorUnitario.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtValorUnitario.Size = new System.Drawing.Size(124, 29);
            this.TxtValorUnitario.TabIndex = 4;
            this.TxtValorUnitario.Text = "R$ 0,00";
            this.TxtValorUnitario.ThemeName = "Default";
            this.TxtValorUnitario.WordWrap = false;
            this.TxtValorUnitario.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtValorUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorUnitario_KeyPress);
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantidade.Location = new System.Drawing.Point(639, 9);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(45, 15);
            this.LblQuantidade.TabIndex = 131;
            this.LblQuantidade.Text = "Quant:";
            // 
            // LblBuscaDescricao
            // 
            this.LblBuscaDescricao.AutoSize = true;
            this.LblBuscaDescricao.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscaDescricao.Location = new System.Drawing.Point(324, 10);
            this.LblBuscaDescricao.Name = "LblBuscaDescricao";
            this.LblBuscaDescricao.Size = new System.Drawing.Size(109, 15);
            this.LblBuscaDescricao.TabIndex = 130;
            this.LblBuscaDescricao.Text = "Descrição Produto:";
            // 
            // LblBuscarReferencia
            // 
            this.LblBuscarReferencia.AutoSize = true;
            this.LblBuscarReferencia.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscarReferencia.Location = new System.Drawing.Point(242, 9);
            this.LblBuscarReferencia.Name = "LblBuscarReferencia";
            this.LblBuscarReferencia.Size = new System.Drawing.Size(66, 15);
            this.LblBuscarReferencia.TabIndex = 129;
            this.LblBuscarReferencia.Text = "Referência:";
            // 
            // LblBuscaTamanho
            // 
            this.LblBuscaTamanho.AutoSize = true;
            this.LblBuscaTamanho.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscaTamanho.Location = new System.Drawing.Point(157, 9);
            this.LblBuscaTamanho.Name = "LblBuscaTamanho";
            this.LblBuscaTamanho.Size = new System.Drawing.Size(60, 15);
            this.LblBuscaTamanho.TabIndex = 128;
            this.LblBuscaTamanho.Text = "Tamanho:";
            // 
            // TxtBuscarDescricao
            // 
            this.TxtBuscarDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtBuscarDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.TxtBuscarDescricao.BeforeTouchSize = new System.Drawing.Size(85, 29);
            this.TxtBuscarDescricao.BorderColor = System.Drawing.Color.Gray;
            this.TxtBuscarDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarDescricao.CanOverrideStyle = true;
            this.TxtBuscarDescricao.CausesValidation = false;
            this.TxtBuscarDescricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarDescricao.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarDescricao.Location = new System.Drawing.Point(327, 28);
            this.TxtBuscarDescricao.MaxLength = 50;
            this.TxtBuscarDescricao.Metrocolor = System.Drawing.Color.Green;
            this.TxtBuscarDescricao.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarDescricao.Multiline = true;
            this.TxtBuscarDescricao.Name = "TxtBuscarDescricao";
            this.TxtBuscarDescricao.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarDescricao.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarDescricao.Size = new System.Drawing.Size(177, 29);
            this.TxtBuscarDescricao.TabIndex = 3;
            this.TxtBuscarDescricao.Tag = "";
            this.TxtBuscarDescricao.ThemeName = "Default";
            this.TxtBuscarDescricao.WordWrap = false;
            this.TxtBuscarDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecutaFiltros_KeyPress);
            // 
            // LblBuscaCodigo
            // 
            this.LblBuscaCodigo.AutoSize = true;
            this.LblBuscaCodigo.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscaCodigo.Location = new System.Drawing.Point(66, 9);
            this.LblBuscaCodigo.Name = "LblBuscaCodigo";
            this.LblBuscaCodigo.Size = new System.Drawing.Size(49, 15);
            this.LblBuscaCodigo.TabIndex = 127;
            this.LblBuscaCodigo.Text = "Código:";
            // 
            // TxtBuscarCodigo
            // 
            this.TxtBuscarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.TxtBuscarCodigo.BeforeTouchSize = new System.Drawing.Size(85, 29);
            this.TxtBuscarCodigo.BorderColor = System.Drawing.Color.Gray;
            this.TxtBuscarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarCodigo.CanOverrideStyle = true;
            this.TxtBuscarCodigo.CausesValidation = false;
            this.TxtBuscarCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarCodigo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarCodigo.Location = new System.Drawing.Point(69, 28);
            this.TxtBuscarCodigo.MaxLength = 50;
            this.TxtBuscarCodigo.Metrocolor = System.Drawing.Color.Green;
            this.TxtBuscarCodigo.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarCodigo.Multiline = true;
            this.TxtBuscarCodigo.Name = "TxtBuscarCodigo";
            this.TxtBuscarCodigo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarCodigo.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarCodigo.Size = new System.Drawing.Size(85, 29);
            this.TxtBuscarCodigo.TabIndex = 0;
            this.TxtBuscarCodigo.Tag = "";
            this.TxtBuscarCodigo.ThemeName = "Default";
            this.TxtBuscarCodigo.WordWrap = false;
            this.TxtBuscarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecutaFiltros_KeyPress);
            // 
            // TxtBuscarReferencia
            // 
            this.TxtBuscarReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.TxtBuscarReferencia.BeforeTouchSize = new System.Drawing.Size(85, 29);
            this.TxtBuscarReferencia.BorderColor = System.Drawing.Color.Gray;
            this.TxtBuscarReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarReferencia.CanOverrideStyle = true;
            this.TxtBuscarReferencia.CausesValidation = false;
            this.TxtBuscarReferencia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarReferencia.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarReferencia.Location = new System.Drawing.Point(245, 28);
            this.TxtBuscarReferencia.MaxLength = 50;
            this.TxtBuscarReferencia.Metrocolor = System.Drawing.Color.Green;
            this.TxtBuscarReferencia.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarReferencia.Multiline = true;
            this.TxtBuscarReferencia.Name = "TxtBuscarReferencia";
            this.TxtBuscarReferencia.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarReferencia.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarReferencia.Size = new System.Drawing.Size(78, 29);
            this.TxtBuscarReferencia.TabIndex = 2;
            this.TxtBuscarReferencia.Tag = "";
            this.TxtBuscarReferencia.ThemeName = "Default";
            this.TxtBuscarReferencia.WordWrap = false;
            this.TxtBuscarReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecutaFiltros_KeyPress);
            // 
            // TxtBuscarTamanho
            // 
            this.TxtBuscarTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.TxtBuscarTamanho.BeforeTouchSize = new System.Drawing.Size(85, 29);
            this.TxtBuscarTamanho.BorderColor = System.Drawing.Color.Gray;
            this.TxtBuscarTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarTamanho.CanOverrideStyle = true;
            this.TxtBuscarTamanho.CausesValidation = false;
            this.TxtBuscarTamanho.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarTamanho.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarTamanho.Location = new System.Drawing.Point(160, 28);
            this.TxtBuscarTamanho.MaxLength = 50;
            this.TxtBuscarTamanho.Metrocolor = System.Drawing.Color.Green;
            this.TxtBuscarTamanho.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarTamanho.Multiline = true;
            this.TxtBuscarTamanho.Name = "TxtBuscarTamanho";
            this.TxtBuscarTamanho.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarTamanho.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarTamanho.Size = new System.Drawing.Size(79, 29);
            this.TxtBuscarTamanho.TabIndex = 1;
            this.TxtBuscarTamanho.Tag = "";
            this.TxtBuscarTamanho.ThemeName = "Default";
            this.TxtBuscarTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ExecutaFiltros_KeyPress);
            // 
            // LblAtividadeNumero
            // 
            this.LblAtividadeNumero.AutoSize = true;
            this.LblAtividadeNumero.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblAtividadeNumero.ForeColor = System.Drawing.Color.Black;
            this.LblAtividadeNumero.Location = new System.Drawing.Point(30, 26);
            this.LblAtividadeNumero.Name = "LblAtividadeNumero";
            this.LblAtividadeNumero.Size = new System.Drawing.Size(105, 19);
            this.LblAtividadeNumero.TabIndex = 118;
            this.LblAtividadeNumero.Text = "Atividade Nº:";
            // 
            // TxtAtividadeNumero
            // 
            this.TxtAtividadeNumero.AutoSize = true;
            this.TxtAtividadeNumero.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.TxtAtividadeNumero.ForeColor = System.Drawing.Color.Gray;
            this.TxtAtividadeNumero.Location = new System.Drawing.Point(139, 26);
            this.TxtAtividadeNumero.Name = "TxtAtividadeNumero";
            this.TxtAtividadeNumero.Size = new System.Drawing.Size(100, 19);
            this.TxtAtividadeNumero.TabIndex = 119;
            this.TxtAtividadeNumero.Text = "Atividade Nº";
            this.TxtAtividadeNumero.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TxtHorario
            // 
            this.TxtHorario.AutoSize = true;
            this.TxtHorario.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.TxtHorario.ForeColor = System.Drawing.Color.Gray;
            this.TxtHorario.Location = new System.Drawing.Point(398, 57);
            this.TxtHorario.Name = "TxtHorario";
            this.TxtHorario.Size = new System.Drawing.Size(65, 19);
            this.TxtHorario.TabIndex = 125;
            this.TxtHorario.Text = "Horário";
            // 
            // LblHorario
            // 
            this.LblHorario.AutoSize = true;
            this.LblHorario.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblHorario.ForeColor = System.Drawing.Color.Black;
            this.LblHorario.Location = new System.Drawing.Point(322, 57);
            this.LblHorario.Name = "LblHorario";
            this.LblHorario.Size = new System.Drawing.Size(70, 19);
            this.LblHorario.TabIndex = 124;
            this.LblHorario.Text = "Horário:";
            // 
            // TxtData
            // 
            this.TxtData.AutoSize = true;
            this.TxtData.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.TxtData.ForeColor = System.Drawing.Color.Gray;
            this.TxtData.Location = new System.Drawing.Point(368, 27);
            this.TxtData.Name = "TxtData";
            this.TxtData.Size = new System.Drawing.Size(43, 19);
            this.TxtData.TabIndex = 123;
            this.TxtData.Text = "Data";
            // 
            // LblData
            // 
            this.LblData.AutoSize = true;
            this.LblData.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblData.ForeColor = System.Drawing.Color.Black;
            this.LblData.Location = new System.Drawing.Point(322, 26);
            this.LblData.Name = "LblData";
            this.LblData.Size = new System.Drawing.Size(48, 19);
            this.LblData.TabIndex = 122;
            this.LblData.Text = "Data:";
            // 
            // TxtSituacao
            // 
            this.TxtSituacao.AutoSize = true;
            this.TxtSituacao.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.TxtSituacao.ForeColor = System.Drawing.Color.Gray;
            this.TxtSituacao.Location = new System.Drawing.Point(638, 26);
            this.TxtSituacao.Name = "TxtSituacao";
            this.TxtSituacao.Size = new System.Drawing.Size(69, 19);
            this.TxtSituacao.TabIndex = 127;
            this.TxtSituacao.Text = "Situação";
            // 
            // LblSituacao
            // 
            this.LblSituacao.AutoSize = true;
            this.LblSituacao.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblSituacao.ForeColor = System.Drawing.Color.Black;
            this.LblSituacao.Location = new System.Drawing.Point(566, 26);
            this.LblSituacao.Name = "LblSituacao";
            this.LblSituacao.Size = new System.Drawing.Size(74, 19);
            this.LblSituacao.TabIndex = 126;
            this.LblSituacao.Text = "Situação:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCards1.BackColor = System.Drawing.Color.AliceBlue;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SlateGray;
            this.bunifuCards1.Controls.Add(this.LblLimpar);
            this.bunifuCards1.Controls.Add(this.PicCarregando);
            this.bunifuCards1.Controls.Add(this.TxtTotalItens);
            this.bunifuCards1.Controls.Add(this.LblTotalItens);
            this.bunifuCards1.Controls.Add(this.BtnAdcionarItem);
            this.bunifuCards1.Controls.Add(this.TxtQuantidade);
            this.bunifuCards1.Controls.Add(this.TxtSubTotal);
            this.bunifuCards1.Controls.Add(this.LblSubTotal);
            this.bunifuCards1.Controls.Add(this.LblValorTotal);
            this.bunifuCards1.Controls.Add(this.TxtBuscarDescricao);
            this.bunifuCards1.Controls.Add(this.TxtValorTotal);
            this.bunifuCards1.Controls.Add(this.TxtBuscarTamanho);
            this.bunifuCards1.Controls.Add(this.LblValorUnitario);
            this.bunifuCards1.Controls.Add(this.TxtBuscarReferencia);
            this.bunifuCards1.Controls.Add(this.TxtBuscarCodigo);
            this.bunifuCards1.Controls.Add(this.TxtValorUnitario);
            this.bunifuCards1.Controls.Add(this.LblBuscaCodigo);
            this.bunifuCards1.Controls.Add(this.LblBuscaTamanho);
            this.bunifuCards1.Controls.Add(this.LblQuantidade);
            this.bunifuCards1.Controls.Add(this.LblBuscarReferencia);
            this.bunifuCards1.Controls.Add(this.LblBuscaDescricao);
            this.bunifuCards1.Controls.Add(this.GridListaPrincipal);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(31, 288);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(902, 375);
            this.bunifuCards1.TabIndex = 136;
            // 
            // LblLimpar
            // 
            this.LblLimpar.AutoSize = true;
            this.LblLimpar.Location = new System.Drawing.Point(25, 34);
            this.LblLimpar.Name = "LblLimpar";
            this.LblLimpar.Size = new System.Drawing.Size(38, 13);
            this.LblLimpar.TabIndex = 141;
            this.LblLimpar.TabStop = true;
            this.LblLimpar.Text = "Limpar";
            this.LblLimpar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLimpar_LinkClicked);
            // 
            // PicCarregando
            // 
            this.PicCarregando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicCarregando.Image = global::SysEstoque.Properties.Resources.Load;
            this.PicCarregando.Location = new System.Drawing.Point(379, 121);
            this.PicCarregando.Name = "PicCarregando";
            this.PicCarregando.Size = new System.Drawing.Size(129, 137);
            this.PicCarregando.TabIndex = 139;
            this.PicCarregando.TabStop = false;
            this.PicCarregando.Visible = false;
            // 
            // TxtTotalItens
            // 
            this.TxtTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTotalItens.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalItens.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.TxtTotalItens.Location = new System.Drawing.Point(109, 325);
            this.TxtTotalItens.Name = "TxtTotalItens";
            this.TxtTotalItens.Size = new System.Drawing.Size(98, 32);
            this.TxtTotalItens.TabIndex = 138;
            this.TxtTotalItens.Text = "0";
            // 
            // LblTotalItens
            // 
            this.LblTotalItens.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblTotalItens.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalItens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LblTotalItens.Location = new System.Drawing.Point(22, 325);
            this.LblTotalItens.Name = "LblTotalItens";
            this.LblTotalItens.Size = new System.Drawing.Size(94, 32);
            this.LblTotalItens.TabIndex = 137;
            this.LblTotalItens.Text = "ITENS:";
            // 
            // GridListaPrincipal
            // 
            this.GridListaPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridListaPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListaPrincipal.ListTypeEstoque = false;
            this.GridListaPrincipal.ListTypeItem = false;
            this.GridListaPrincipal.Location = new System.Drawing.Point(21, 63);
            this.GridListaPrincipal.Name = "GridListaPrincipal";
            this.GridListaPrincipal.Size = new System.Drawing.Size(861, 248);
            this.GridListaPrincipal.TabIndex = 141;
            this.GridListaPrincipal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListaPrincipal_CellClick);
            this.GridListaPrincipal.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.GridListaPrincipal_RowPrePaint);
            this.GridListaPrincipal.DoubleClick += new System.EventHandler(this.GridListaPrincipal_DoubleClick);
            // 
            // BtnDeletarAtividade
            // 
            this.BtnDeletarAtividade.AccessibleName = "Button";
            this.BtnDeletarAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnDeletarAtividade.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnDeletarAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDeletarAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeletarAtividade.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarAtividade.Location = new System.Drawing.Point(100, 47);
            this.BtnDeletarAtividade.Name = "BtnDeletarAtividade";
            this.BtnDeletarAtividade.Size = new System.Drawing.Size(80, 35);
            this.BtnDeletarAtividade.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnDeletarAtividade.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnDeletarAtividade.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnDeletarAtividade.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnDeletarAtividade.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnDeletarAtividade.Style.ForeColor = System.Drawing.Color.White;
            this.BtnDeletarAtividade.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnDeletarAtividade.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnDeletarAtividade.Style.PressedBackColor = System.Drawing.Color.White;
            this.BtnDeletarAtividade.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnDeletarAtividade.TabIndex = 142;
            this.BtnDeletarAtividade.Text = "Excluir";
            this.BtnDeletarAtividade.UseVisualStyleBackColor = false;
            this.BtnDeletarAtividade.Click += new System.EventHandler(this.BtnDeletarAtividade_Click);
            // 
            // BtnConfirmar
            // 
            this.BtnConfirmar.AccessibleName = "Button";
            this.BtnConfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnConfirmar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfirmar.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Location = new System.Drawing.Point(183, 47);
            this.BtnConfirmar.Name = "BtnConfirmar";
            this.BtnConfirmar.Size = new System.Drawing.Size(80, 35);
            this.BtnConfirmar.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirmar.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirmar.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirmar.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnConfirmar.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Style.ForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnConfirmar.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnConfirmar.Style.PressedBackColor = System.Drawing.Color.White;
            this.BtnConfirmar.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnConfirmar.TabIndex = 140;
            this.BtnConfirmar.Text = "Confirmar";
            this.BtnConfirmar.UseVisualStyleBackColor = false;
            this.BtnConfirmar.Click += new System.EventHandler(this.BtnConfirmar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.LblAtividadeTipo);
            this.groupBox2.Controls.Add(this.TxtAtividadeTipo);
            this.groupBox2.Controls.Add(this.TxtData);
            this.groupBox2.Controls.Add(this.LblAtividadeNumero);
            this.groupBox2.Controls.Add(this.TxtAtividadeNumero);
            this.groupBox2.Controls.Add(this.TxtSituacao);
            this.groupBox2.Controls.Add(this.LblData);
            this.groupBox2.Controls.Add(this.LblSituacao);
            this.groupBox2.Controls.Add(this.TxtHorario);
            this.groupBox2.Controls.Add(this.LblHorario);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(31, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(902, 96);
            this.groupBox2.TabIndex = 140;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "INFORMAÇÕES GERAIS";
            // 
            // LblAtividadeTipo
            // 
            this.LblAtividadeTipo.AutoSize = true;
            this.LblAtividadeTipo.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblAtividadeTipo.ForeColor = System.Drawing.Color.Black;
            this.LblAtividadeTipo.Location = new System.Drawing.Point(31, 61);
            this.LblAtividadeTipo.Name = "LblAtividadeTipo";
            this.LblAtividadeTipo.Size = new System.Drawing.Size(48, 19);
            this.LblAtividadeTipo.TabIndex = 128;
            this.LblAtividadeTipo.Text = "Tipo:";
            // 
            // TxtAtividadeTipo
            // 
            this.TxtAtividadeTipo.AutoSize = true;
            this.TxtAtividadeTipo.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.TxtAtividadeTipo.ForeColor = System.Drawing.Color.Gray;
            this.TxtAtividadeTipo.Location = new System.Drawing.Point(85, 61);
            this.TxtAtividadeTipo.Name = "TxtAtividadeTipo";
            this.TxtAtividadeTipo.Size = new System.Drawing.Size(43, 19);
            this.TxtAtividadeTipo.TabIndex = 129;
            this.TxtAtividadeTipo.Text = "Tipo";
            this.TxtAtividadeTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(26, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 142;
            this.label1.Text = "Destino:";
            // 
            // PanelHorizontalSuperior
            // 
            this.PanelHorizontalSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHorizontalSuperior.BackgroundImage")));
            this.PanelHorizontalSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHorizontalSuperior.Controls.Add(this.LblDataLong);
            this.PanelHorizontalSuperior.Controls.Add(this.LblCaptionAtividade);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnNovaAtividade);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnConfirmar);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnDeletarAtividade);
            this.PanelHorizontalSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontalSuperior.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientTopLeft = System.Drawing.Color.Black;
            this.PanelHorizontalSuperior.GradientTopRight = System.Drawing.Color.Black;
            this.PanelHorizontalSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelHorizontalSuperior.Name = "PanelHorizontalSuperior";
            this.PanelHorizontalSuperior.Quality = 10;
            this.PanelHorizontalSuperior.Size = new System.Drawing.Size(964, 97);
            this.PanelHorizontalSuperior.TabIndex = 139;
            // 
            // LblDataLong
            // 
            this.LblDataLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDataLong.BackColor = System.Drawing.Color.Transparent;
            this.LblDataLong.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataLong.ForeColor = System.Drawing.Color.White;
            this.LblDataLong.Location = new System.Drawing.Point(467, 23);
            this.LblDataLong.Name = "LblDataLong";
            this.LblDataLong.Size = new System.Drawing.Size(494, 40);
            this.LblDataLong.TabIndex = 139;
            this.LblDataLong.Text = "Entrada de Estoque";
            this.LblDataLong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCaptionAtividade
            // 
            this.LblCaptionAtividade.AutoSize = true;
            this.LblCaptionAtividade.BackColor = System.Drawing.Color.Transparent;
            this.LblCaptionAtividade.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaptionAtividade.ForeColor = System.Drawing.Color.White;
            this.LblCaptionAtividade.Location = new System.Drawing.Point(12, 4);
            this.LblCaptionAtividade.Name = "LblCaptionAtividade";
            this.LblCaptionAtividade.Size = new System.Drawing.Size(304, 40);
            this.LblCaptionAtividade.TabIndex = 138;
            this.LblCaptionAtividade.Text = "Entrada de Estoque";
            // 
            // BtnNovaAtividade
            // 
            this.BtnNovaAtividade.AccessibleName = "Button";
            this.BtnNovaAtividade.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNovaAtividade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovaAtividade.ForeColor = System.Drawing.Color.White;
            this.BtnNovaAtividade.Location = new System.Drawing.Point(17, 47);
            this.BtnNovaAtividade.Name = "BtnNovaAtividade";
            this.BtnNovaAtividade.Size = new System.Drawing.Size(80, 35);
            this.BtnNovaAtividade.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnNovaAtividade.Style.ForeColor = System.Drawing.Color.White;
            this.BtnNovaAtividade.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNovaAtividade.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnNovaAtividade.Style.PressedBackColor = System.Drawing.Color.White;
            this.BtnNovaAtividade.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnNovaAtividade.TabIndex = 137;
            this.BtnNovaAtividade.Text = "Nova";
            this.BtnNovaAtividade.UseVisualStyleBackColor = false;
            this.BtnNovaAtividade.Click += new System.EventHandler(this.BtnNovaAtividade_Click);
            // 
            // CboEstoqueDestino
            // 
            this.CboEstoqueDestino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboEstoqueDestino.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.CboEstoqueDestino.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboEstoqueDestino.FormattingEnabled = true;
            this.CboEstoqueDestino.Location = new System.Drawing.Point(31, 239);
            this.CboEstoqueDestino.Name = "CboEstoqueDestino";
            this.CboEstoqueDestino.Size = new System.Drawing.Size(370, 29);
            this.CboEstoqueDestino.TabIndex = 145;
            this.CboEstoqueDestino.DropDown += new System.EventHandler(this.CboEstoqueDestino_DropDown);
            this.CboEstoqueDestino.SelectedIndexChanged += new System.EventHandler(this.CboEstoqueDestino_SelectedIndexChanged);
            // 
            // LblCadastrarNovo
            // 
            this.LblCadastrarNovo.AutoSize = true;
            this.LblCadastrarNovo.Location = new System.Drawing.Point(320, 223);
            this.LblCadastrarNovo.Name = "LblCadastrarNovo";
            this.LblCadastrarNovo.Size = new System.Drawing.Size(81, 13);
            this.LblCadastrarNovo.TabIndex = 146;
            this.LblCadastrarNovo.TabStop = true;
            this.LblCadastrarNovo.Text = "Cadastrar Novo";
            this.LblCadastrarNovo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblCadastrarNovo_LinkClicked);
            // 
            // FrmEstoqueAtividade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.LblCadastrarNovo);
            this.Controls.Add(this.CboEstoqueDestino);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelHorizontalSuperior);
            this.Controls.Add(this.bunifuCards1);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmEstoqueAtividade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmEstoqueAtividade_Load);
            this.Resize += new System.EventHandler(this.FrmEstoqueAtividade_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TxtQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValorTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtValorUnitario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarTamanho)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaPrincipal)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.PanelHorizontalSuperior.ResumeLayout(false);
            this.PanelHorizontalSuperior.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerExecultaConsulta;
        private System.Windows.Forms.Label LblSubTotal;
        private System.Windows.Forms.Label TxtSubTotal;
        private System.Windows.Forms.Label LblHorario;
        private System.Windows.Forms.Label LblData;
        private System.Windows.Forms.Label LblSituacao;
        private Syncfusion.WinForms.Controls.SfButton BtnAdcionarItem;
        private Syncfusion.Windows.Forms.Tools.IntegerTextBox TxtQuantidade;
        private System.Windows.Forms.Label LblValorTotal;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TxtValorTotal;
        private System.Windows.Forms.Label LblValorUnitario;
        private Syncfusion.Windows.Forms.Tools.CurrencyTextBox TxtValorUnitario;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.Label LblBuscaDescricao;
        private System.Windows.Forms.Label LblBuscarReferencia;
        private System.Windows.Forms.Label LblBuscaTamanho;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarDescricao;
        private System.Windows.Forms.Label LblBuscaCodigo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarCodigo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarReferencia;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarTamanho;
        public System.Windows.Forms.Label TxtAtividadeNumero;
        public System.Windows.Forms.Label TxtHorario;
        public System.Windows.Forms.Label TxtData;
        public System.Windows.Forms.Label TxtSituacao;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label TxtTotalItens;
        private System.Windows.Forms.Label LblTotalItens;
        private System.Windows.Forms.PictureBox PicCarregando;
        private Syncfusion.WinForms.Controls.SfButton BtnConfirmar;
        private Syncfusion.WinForms.Controls.SfButton BtnNovaAtividade;
        public System.Windows.Forms.Label LblAtividadeNumero;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelHorizontalSuperior;
        public System.Windows.Forms.Label LblCaptionAtividade;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Label LblAtividadeTipo;
        public System.Windows.Forms.Label TxtAtividadeTipo;
        public System.Windows.Forms.Label LblDataLong;
        private System.Windows.Forms.LinkLabel LblLimpar;
        private Syncfusion.WinForms.Controls.SfButton BtnDeletarAtividade;
        public Auxiliary.AxlListEstoqueItem GridListaPrincipal;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CboEstoqueDestino;
        private System.Windows.Forms.LinkLabel LblCadastrarNovo;
    }
}