namespace SysEstoque.View
{
    partial class FrmEstoqueAtividadeLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEstoqueAtividadeLista));
            this.GridListaAtividade = new System.Windows.Forms.DataGridView();
            this.PanelHorizontalSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnAtualizar = new Syncfusion.WinForms.Controls.SfButton();
            this.LblDataLong = new System.Windows.Forms.Label();
            this.LblCaptionListaProduto = new System.Windows.Forms.Label();
            this.LblAtividadeNumero = new System.Windows.Forms.Label();
            this.TxtTotalAtividade = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblBuscaDataInicio = new System.Windows.Forms.Label();
            this.TxtBuscaTamanho = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtDataInicio = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.TxtDataFinal = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.TimerExecutaConsulta = new System.Windows.Forms.Timer(this.components);
            this.PicCarregando = new System.Windows.Forms.PictureBox();
            this.TxtTipo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSituacao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.CboSituacao = new Syncfusion.WinForms.ListView.SfComboBox();
            this.CboTipo = new Syncfusion.WinForms.ListView.SfComboBox();
            this.LblNumeroAtividade = new System.Windows.Forms.Label();
            this.TxtBuscaNumeroAtividade = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label4 = new System.Windows.Forms.Label();
            this.LblLimpar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaAtividade)).BeginInit();
            this.PanelHorizontalSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaNumeroAtividade)).BeginInit();
            this.SuspendLayout();
            // 
            // GridListaAtividade
            // 
            this.GridListaAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridListaAtividade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListaAtividade.Location = new System.Drawing.Point(19, 181);
            this.GridListaAtividade.Name = "GridListaAtividade";
            this.GridListaAtividade.Size = new System.Drawing.Size(992, 365);
            this.GridListaAtividade.TabIndex = 0;
            this.GridListaAtividade.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridListaAtividade_CellClick);
            this.GridListaAtividade.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridListaAtividade_CellMouseMove);
            // 
            // PanelHorizontalSuperior
            // 
            this.PanelHorizontalSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHorizontalSuperior.BackgroundImage")));
            this.PanelHorizontalSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            this.PanelHorizontalSuperior.Size = new System.Drawing.Size(1023, 101);
            this.PanelHorizontalSuperior.TabIndex = 141;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.AccessibleName = "Button";
            this.BtnAtualizar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(19, 52);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(80, 35);
            this.BtnAtualizar.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Style.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnAtualizar.Style.HoverForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.TabIndex = 140;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = false;
            this.BtnAtualizar.Click += new System.EventHandler(this.Btn_Click);
            // 
            // LblDataLong
            // 
            this.LblDataLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDataLong.BackColor = System.Drawing.Color.Transparent;
            this.LblDataLong.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataLong.ForeColor = System.Drawing.Color.White;
            this.LblDataLong.Location = new System.Drawing.Point(450, 27);
            this.LblDataLong.Name = "LblDataLong";
            this.LblDataLong.Size = new System.Drawing.Size(561, 40);
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
            this.LblCaptionListaProduto.Location = new System.Drawing.Point(12, 9);
            this.LblCaptionListaProduto.Name = "LblCaptionListaProduto";
            this.LblCaptionListaProduto.Size = new System.Drawing.Size(424, 40);
            this.LblCaptionListaProduto.TabIndex = 138;
            this.LblCaptionListaProduto.Text = "Lista Atividades No Estoque";
            // 
            // LblAtividadeNumero
            // 
            this.LblAtividadeNumero.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LblAtividadeNumero.AutoSize = true;
            this.LblAtividadeNumero.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.LblAtividadeNumero.ForeColor = System.Drawing.Color.Black;
            this.LblAtividadeNumero.Location = new System.Drawing.Point(13, 549);
            this.LblAtividadeNumero.Name = "LblAtividadeNumero";
            this.LblAtividadeNumero.Size = new System.Drawing.Size(149, 19);
            this.LblAtividadeNumero.TabIndex = 142;
            this.LblAtividadeNumero.Text = "Total de Atividades:";
            // 
            // TxtTotalAtividade
            // 
            this.TxtTotalAtividade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TxtTotalAtividade.Font = new System.Drawing.Font("Calisto MT", 12F);
            this.TxtTotalAtividade.ForeColor = System.Drawing.Color.Black;
            this.TxtTotalAtividade.Location = new System.Drawing.Point(168, 549);
            this.TxtTotalAtividade.Name = "TxtTotalAtividade";
            this.TxtTotalAtividade.Size = new System.Drawing.Size(149, 19);
            this.TxtTotalAtividade.TabIndex = 144;
            this.TxtTotalAtividade.Text = "Total de Atividades:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 156;
            this.label1.Text = "Data Final:";
            // 
            // textBoxExt2
            // 
            this.textBoxExt2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBoxExt2.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.textBoxExt2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.textBoxExt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxExt2.CanOverrideStyle = true;
            this.textBoxExt2.CausesValidation = false;
            this.textBoxExt2.CornerRadius = 4;
            this.textBoxExt2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxExt2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt2.Location = new System.Drawing.Point(153, 147);
            this.textBoxExt2.MaxLength = 50;
            this.textBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt2.MinimumSize = new System.Drawing.Size(16, 12);
            this.textBoxExt2.Multiline = true;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt2.Size = new System.Drawing.Size(136, 29);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt2.TabIndex = 155;
            this.textBoxExt2.Tag = "";
            this.textBoxExt2.ThemeName = "Office2016Colorful";
            // 
            // LblBuscaDataInicio
            // 
            this.LblBuscaDataInicio.AutoSize = true;
            this.LblBuscaDataInicio.Location = new System.Drawing.Point(12, 131);
            this.LblBuscaDataInicio.Name = "LblBuscaDataInicio";
            this.LblBuscaDataInicio.Size = new System.Drawing.Size(61, 13);
            this.LblBuscaDataInicio.TabIndex = 153;
            this.LblBuscaDataInicio.Text = "Data Inicio:";
            // 
            // TxtBuscaTamanho
            // 
            this.TxtBuscaTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscaTamanho.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtBuscaTamanho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscaTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscaTamanho.CanOverrideStyle = true;
            this.TxtBuscaTamanho.CausesValidation = false;
            this.TxtBuscaTamanho.CornerRadius = 4;
            this.TxtBuscaTamanho.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscaTamanho.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscaTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscaTamanho.Location = new System.Drawing.Point(15, 147);
            this.TxtBuscaTamanho.MaxLength = 50;
            this.TxtBuscaTamanho.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscaTamanho.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscaTamanho.Multiline = true;
            this.TxtBuscaTamanho.Name = "TxtBuscaTamanho";
            this.TxtBuscaTamanho.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscaTamanho.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscaTamanho.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscaTamanho.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscaTamanho.TabIndex = 152;
            this.TxtBuscaTamanho.Tag = "";
            this.TxtBuscaTamanho.ThemeName = "Office2016Colorful";
            // 
            // TxtDataInicio
            // 
            this.TxtDataInicio.Location = new System.Drawing.Point(20, 149);
            this.TxtDataInicio.Name = "TxtDataInicio";
            this.TxtDataInicio.Size = new System.Drawing.Size(123, 26);
            this.TxtDataInicio.Style.BorderColor = System.Drawing.Color.White;
            this.TxtDataInicio.Style.DisabledForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtDataInicio.Style.FocusedBorderColor = System.Drawing.Color.White;
            this.TxtDataInicio.Style.ForeColor = System.Drawing.Color.Black;
            this.TxtDataInicio.Style.HoverBorderColor = System.Drawing.Color.White;
            this.TxtDataInicio.Style.UpDownForeColor = System.Drawing.Color.White;
            this.TxtDataInicio.TabIndex = 157;
            this.TxtDataInicio.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.TxtDataInicio_ValueChanged);
            // 
            // TxtDataFinal
            // 
            this.TxtDataFinal.AllowDrop = true;
            this.TxtDataFinal.Location = new System.Drawing.Point(159, 149);
            this.TxtDataFinal.Name = "TxtDataFinal";
            this.TxtDataFinal.Size = new System.Drawing.Size(122, 26);
            this.TxtDataFinal.Style.BorderColor = System.Drawing.Color.White;
            this.TxtDataFinal.Style.DisabledForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TxtDataFinal.Style.FocusedBorderColor = System.Drawing.Color.White;
            this.TxtDataFinal.Style.ForeColor = System.Drawing.Color.Black;
            this.TxtDataFinal.Style.HoverBorderColor = System.Drawing.Color.White;
            this.TxtDataFinal.Style.UpDownForeColor = System.Drawing.Color.White;
            this.TxtDataFinal.TabIndex = 158;
            this.TxtDataFinal.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.TxtDataFinal_ValueChanged);
            // 
            // TimerExecutaConsulta
            // 
            this.TimerExecutaConsulta.Interval = 1000;
            this.TimerExecutaConsulta.Tick += new System.EventHandler(this.TimerExecutaConsulta_Tick);
            // 
            // PicCarregando
            // 
            this.PicCarregando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicCarregando.Image = global::SysEstoque.Properties.Resources.Load;
            this.PicCarregando.Location = new System.Drawing.Point(441, 299);
            this.PicCarregando.Name = "PicCarregando";
            this.PicCarregando.Size = new System.Drawing.Size(129, 137);
            this.PicCarregando.TabIndex = 159;
            this.PicCarregando.TabStop = false;
            this.PicCarregando.Visible = false;
            // 
            // TxtTipo
            // 
            this.TxtTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtTipo.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTipo.CanOverrideStyle = true;
            this.TxtTipo.CausesValidation = false;
            this.TxtTipo.CornerRadius = 4;
            this.TxtTipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtTipo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtTipo.Location = new System.Drawing.Point(291, 148);
            this.TxtTipo.MaxLength = 50;
            this.TxtTipo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtTipo.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtTipo.Multiline = true;
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtTipo.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtTipo.Size = new System.Drawing.Size(120, 29);
            this.TxtTipo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtTipo.TabIndex = 160;
            this.TxtTipo.Tag = "";
            this.TxtTipo.ThemeName = "Office2016Colorful";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 161;
            this.label2.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 163;
            this.label3.Text = "Situação:";
            // 
            // TxtSituacao
            // 
            this.TxtSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtSituacao.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtSituacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtSituacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSituacao.CanOverrideStyle = true;
            this.TxtSituacao.CausesValidation = false;
            this.TxtSituacao.CornerRadius = 4;
            this.TxtSituacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtSituacao.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtSituacao.Location = new System.Drawing.Point(412, 148);
            this.TxtSituacao.MaxLength = 50;
            this.TxtSituacao.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtSituacao.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtSituacao.Multiline = true;
            this.TxtSituacao.Name = "TxtSituacao";
            this.TxtSituacao.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtSituacao.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtSituacao.Size = new System.Drawing.Size(120, 29);
            this.TxtSituacao.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtSituacao.TabIndex = 162;
            this.TxtSituacao.Tag = "";
            this.TxtSituacao.ThemeName = "Office2016Colorful";
            // 
            // CboSituacao
            // 
            this.CboSituacao.BackColor = System.Drawing.Color.White;
            this.CboSituacao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboSituacao.Location = new System.Drawing.Point(420, 151);
            this.CboSituacao.Name = "CboSituacao";
            this.CboSituacao.Size = new System.Drawing.Size(109, 24);
            this.CboSituacao.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboSituacao.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.CboSituacao.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.CboSituacao.Style.EditorStyle.BorderColor = System.Drawing.Color.White;
            this.CboSituacao.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.CboSituacao.TabIndex = 165;
            this.CboSituacao.SelectedIndexChanged += new System.EventHandler(this.CboSituacao_SelectedIndexChanged);
            // 
            // CboTipo
            // 
            this.CboTipo.BackColor = System.Drawing.Color.White;
            this.CboTipo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboTipo.Location = new System.Drawing.Point(294, 150);
            this.CboTipo.Name = "CboTipo";
            this.CboTipo.Size = new System.Drawing.Size(115, 25);
            this.CboTipo.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboTipo.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.CboTipo.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.CboTipo.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.CboTipo.TabIndex = 166;
            this.CboTipo.SelectedIndexChanged += new System.EventHandler(this.CboTipo_SelectedIndexChanged);
            // 
            // LblNumeroAtividade
            // 
            this.LblNumeroAtividade.AutoSize = true;
            this.LblNumeroAtividade.Location = new System.Drawing.Point(562, 132);
            this.LblNumeroAtividade.Name = "LblNumeroAtividade";
            this.LblNumeroAtividade.Size = new System.Drawing.Size(66, 13);
            this.LblNumeroAtividade.TabIndex = 168;
            this.LblNumeroAtividade.Text = "Nº Atividade";
            // 
            // TxtBuscaNumeroAtividade
            // 
            this.TxtBuscaNumeroAtividade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscaNumeroAtividade.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtBuscaNumeroAtividade.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscaNumeroAtividade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscaNumeroAtividade.CanOverrideStyle = true;
            this.TxtBuscaNumeroAtividade.CausesValidation = false;
            this.TxtBuscaNumeroAtividade.CornerRadius = 4;
            this.TxtBuscaNumeroAtividade.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscaNumeroAtividade.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscaNumeroAtividade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscaNumeroAtividade.Location = new System.Drawing.Point(565, 148);
            this.TxtBuscaNumeroAtividade.MaxLength = 50;
            this.TxtBuscaNumeroAtividade.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscaNumeroAtividade.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscaNumeroAtividade.Multiline = true;
            this.TxtBuscaNumeroAtividade.Name = "TxtBuscaNumeroAtividade";
            this.TxtBuscaNumeroAtividade.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscaNumeroAtividade.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscaNumeroAtividade.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscaNumeroAtividade.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscaNumeroAtividade.TabIndex = 167;
            this.TxtBuscaNumeroAtividade.Tag = "";
            this.TxtBuscaNumeroAtividade.ThemeName = "Office2016Colorful";
            this.TxtBuscaNumeroAtividade.TextChanged += new System.EventHandler(this.TxtBuscaNumeroAtividade_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(538, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 169;
            this.label4.Text = "Ou";
            // 
            // LblLimpar
            // 
            this.LblLimpar.AutoSize = true;
            this.LblLimpar.Location = new System.Drawing.Point(711, 157);
            this.LblLimpar.Name = "LblLimpar";
            this.LblLimpar.Size = new System.Drawing.Size(38, 13);
            this.LblLimpar.TabIndex = 170;
            this.LblLimpar.TabStop = true;
            this.LblLimpar.Text = "Limpar";
            this.LblLimpar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLimpar_LinkClicked);
            // 
            // FrmEstoqueAtividadeLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 603);
            this.Controls.Add(this.LblLimpar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblNumeroAtividade);
            this.Controls.Add(this.TxtBuscaNumeroAtividade);
            this.Controls.Add(this.CboTipo);
            this.Controls.Add(this.CboSituacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtSituacao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.PicCarregando);
            this.Controls.Add(this.TxtDataFinal);
            this.Controls.Add(this.TxtDataInicio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExt2);
            this.Controls.Add(this.LblBuscaDataInicio);
            this.Controls.Add(this.TxtBuscaTamanho);
            this.Controls.Add(this.TxtTotalAtividade);
            this.Controls.Add(this.LblAtividadeNumero);
            this.Controls.Add(this.PanelHorizontalSuperior);
            this.Controls.Add(this.GridListaAtividade);
            this.Name = "FrmEstoqueAtividadeLista";
            this.Load += new System.EventHandler(this.FrmEstoqueAtividadeLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridListaAtividade)).EndInit();
            this.PanelHorizontalSuperior.ResumeLayout(false);
            this.PanelHorizontalSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaNumeroAtividade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridListaAtividade;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelHorizontalSuperior;
        public System.Windows.Forms.Label LblDataLong;
        public System.Windows.Forms.Label LblCaptionListaProduto;
        public System.Windows.Forms.Label LblAtividadeNumero;
        public System.Windows.Forms.Label TxtTotalAtividade;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private System.Windows.Forms.Label LblBuscaDataInicio;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscaTamanho;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TxtDataInicio;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TxtDataFinal;
        private System.Windows.Forms.Timer TimerExecutaConsulta;
        private System.Windows.Forms.PictureBox PicCarregando;
        private Syncfusion.WinForms.Controls.SfButton BtnAtualizar;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtSituacao;
        private Syncfusion.WinForms.ListView.SfComboBox CboSituacao;
        private Syncfusion.WinForms.ListView.SfComboBox CboTipo;
        private System.Windows.Forms.Label LblNumeroAtividade;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscaNumeroAtividade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel LblLimpar;
    }
}