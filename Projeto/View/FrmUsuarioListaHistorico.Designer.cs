namespace DimStock.View
{
    partial class FrmUsuarioListaHistorico
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioListaHistorico));
            this.PanelHorizontalSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnAtualizar = new Syncfusion.WinForms.Controls.SfButton();
            this.LblDataLong = new System.Windows.Forms.Label();
            this.LblCaptionAtividade = new System.Windows.Forms.Label();
            this.GridListaHistorico = new System.Windows.Forms.DataGridView();
            this.LblBuscarLogin = new System.Windows.Forms.Label();
            this.TxtBuscarLogin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscaDataInicio = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.TxtBuscaTamanho = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblBuscaDataInicio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscaDataFinal = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.TimeExecultaConsulta = new System.Windows.Forms.Timer(this.components);
            this.PicCarregando = new System.Windows.Forms.PictureBox();
            this.PanelHorizontalSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaHistorico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHorizontalSuperior
            // 
            this.PanelHorizontalSuperior.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelHorizontalSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHorizontalSuperior.BackgroundImage")));
            this.PanelHorizontalSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHorizontalSuperior.Controls.Add(this.BtnAtualizar);
            this.PanelHorizontalSuperior.Controls.Add(this.LblDataLong);
            this.PanelHorizontalSuperior.Controls.Add(this.LblCaptionAtividade);
            this.PanelHorizontalSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontalSuperior.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.PanelHorizontalSuperior.GradientTopLeft = System.Drawing.Color.Black;
            this.PanelHorizontalSuperior.GradientTopRight = System.Drawing.Color.Black;
            this.PanelHorizontalSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelHorizontalSuperior.Name = "PanelHorizontalSuperior";
            this.PanelHorizontalSuperior.Quality = 10;
            this.PanelHorizontalSuperior.Size = new System.Drawing.Size(964, 95);
            this.PanelHorizontalSuperior.TabIndex = 140;
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
            this.LblCaptionAtividade.Location = new System.Drawing.Point(10, 4);
            this.LblCaptionAtividade.Name = "LblCaptionAtividade";
            this.LblCaptionAtividade.Size = new System.Drawing.Size(349, 40);
            this.LblCaptionAtividade.TabIndex = 138;
            this.LblCaptionAtividade.Text = "Lista Histórico Usuário";
            // 
            // GridListaHistorico
            // 
            this.GridListaHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridListaHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListaHistorico.Location = new System.Drawing.Point(29, 190);
            this.GridListaHistorico.Name = "GridListaHistorico";
            this.GridListaHistorico.Size = new System.Drawing.Size(907, 464);
            this.GridListaHistorico.TabIndex = 145;
            // 
            // LblBuscarLogin
            // 
            this.LblBuscarLogin.AutoSize = true;
            this.LblBuscarLogin.Location = new System.Drawing.Point(23, 141);
            this.LblBuscarLogin.Name = "LblBuscarLogin";
            this.LblBuscarLogin.Size = new System.Drawing.Size(72, 13);
            this.LblBuscarLogin.TabIndex = 147;
            this.LblBuscarLogin.Text = "Buscar Login:";
            // 
            // TxtBuscarLogin
            // 
            this.TxtBuscarLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarLogin.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtBuscarLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarLogin.CanOverrideStyle = true;
            this.TxtBuscarLogin.CausesValidation = false;
            this.TxtBuscarLogin.CornerRadius = 4;
            this.TxtBuscarLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarLogin.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarLogin.Location = new System.Drawing.Point(26, 157);
            this.TxtBuscarLogin.MaxLength = 50;
            this.TxtBuscarLogin.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscarLogin.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarLogin.Multiline = true;
            this.TxtBuscarLogin.Name = "TxtBuscarLogin";
            this.TxtBuscarLogin.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarLogin.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarLogin.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscarLogin.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarLogin.TabIndex = 146;
            this.TxtBuscarLogin.Tag = "";
            this.TxtBuscarLogin.ThemeName = "Office2016Colorful";
            this.TxtBuscarLogin.TextChanged += new System.EventHandler(this.TxtBuscarLogin_TextChanged);
            // 
            // TxtBuscaDataInicio
            // 
            this.TxtBuscaDataInicio.Location = new System.Drawing.Point(173, 161);
            this.TxtBuscaDataInicio.Name = "TxtBuscaDataInicio";
            this.TxtBuscaDataInicio.Size = new System.Drawing.Size(124, 23);
            this.TxtBuscaDataInicio.Style.BorderColor = System.Drawing.Color.White;
            this.TxtBuscaDataInicio.Style.FocusedBorderColor = System.Drawing.Color.White;
            this.TxtBuscaDataInicio.Style.ForeColor = System.Drawing.Color.Black;
            this.TxtBuscaDataInicio.Style.HoverBorderColor = System.Drawing.Color.White;
            this.TxtBuscaDataInicio.Style.UpDownForeColor = System.Drawing.Color.White;
            this.TxtBuscaDataInicio.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.TxtBuscaDataInicio.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.TxtBuscaDataInicio.TabIndex = 148;
            this.TxtBuscaDataInicio.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.TxtBuscaDataInicio_ValueChanged);
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
            this.TxtBuscaTamanho.Location = new System.Drawing.Point(168, 157);
            this.TxtBuscaTamanho.MaxLength = 50;
            this.TxtBuscaTamanho.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscaTamanho.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscaTamanho.Multiline = true;
            this.TxtBuscaTamanho.Name = "TxtBuscaTamanho";
            this.TxtBuscaTamanho.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscaTamanho.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscaTamanho.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscaTamanho.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscaTamanho.TabIndex = 142;
            this.TxtBuscaTamanho.Tag = "";
            this.TxtBuscaTamanho.ThemeName = "Office2016Colorful";
            // 
            // LblBuscaDataInicio
            // 
            this.LblBuscaDataInicio.AutoSize = true;
            this.LblBuscaDataInicio.Location = new System.Drawing.Point(165, 141);
            this.LblBuscaDataInicio.Name = "LblBuscaDataInicio";
            this.LblBuscaDataInicio.Size = new System.Drawing.Size(61, 13);
            this.LblBuscaDataInicio.TabIndex = 144;
            this.LblBuscaDataInicio.Text = "Data Inicio:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(307, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 150;
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
            this.textBoxExt2.Location = new System.Drawing.Point(310, 157);
            this.textBoxExt2.MaxLength = 50;
            this.textBoxExt2.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.textBoxExt2.MinimumSize = new System.Drawing.Size(16, 12);
            this.textBoxExt2.Multiline = true;
            this.textBoxExt2.Name = "textBoxExt2";
            this.textBoxExt2.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.textBoxExt2.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.textBoxExt2.Size = new System.Drawing.Size(136, 29);
            this.textBoxExt2.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.textBoxExt2.TabIndex = 149;
            this.textBoxExt2.Tag = "";
            this.textBoxExt2.ThemeName = "Office2016Colorful";
            // 
            // TxtBuscaDataFinal
            // 
            this.TxtBuscaDataFinal.Location = new System.Drawing.Point(319, 159);
            this.TxtBuscaDataFinal.Name = "TxtBuscaDataFinal";
            this.TxtBuscaDataFinal.Size = new System.Drawing.Size(121, 25);
            this.TxtBuscaDataFinal.Style.BorderColor = System.Drawing.Color.White;
            this.TxtBuscaDataFinal.Style.DisabledForeColor = System.Drawing.Color.White;
            this.TxtBuscaDataFinal.Style.FocusedBorderColor = System.Drawing.Color.White;
            this.TxtBuscaDataFinal.Style.HoverBorderColor = System.Drawing.Color.White;
            this.TxtBuscaDataFinal.Style.UpDownForeColor = System.Drawing.Color.White;
            this.TxtBuscaDataFinal.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.TxtBuscaDataFinal.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.TxtBuscaDataFinal.TabIndex = 151;
            this.TxtBuscaDataFinal.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.TxtBuscaDataFinal_ValueChanged);
            // 
            // TimeExecultaConsulta
            // 
            this.TimeExecultaConsulta.Interval = 1000;
            this.TimeExecultaConsulta.Tick += new System.EventHandler(this.TimeExecultaConsulta_Tick);
            // 
            // PicCarregando
            // 
            this.PicCarregando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicCarregando.Image = global::DimStock.Properties.Resources.Load;
            this.PicCarregando.Location = new System.Drawing.Point(414, 358);
            this.PicCarregando.Name = "PicCarregando";
            this.PicCarregando.Size = new System.Drawing.Size(129, 137);
            this.PicCarregando.TabIndex = 152;
            this.PicCarregando.TabStop = false;
            this.PicCarregando.Visible = false;
            // 
            // FrmUsuarioListaHistorico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.PicCarregando);
            this.Controls.Add(this.TxtBuscaDataFinal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxExt2);
            this.Controls.Add(this.TxtBuscaDataInicio);
            this.Controls.Add(this.LblBuscarLogin);
            this.Controls.Add(this.TxtBuscarLogin);
            this.Controls.Add(this.GridListaHistorico);
            this.Controls.Add(this.LblBuscaDataInicio);
            this.Controls.Add(this.TxtBuscaTamanho);
            this.Controls.Add(this.PanelHorizontalSuperior);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmUsuarioListaHistorico";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FrmUsuarioHistorico_Load);
            this.PanelHorizontalSuperior.ResumeLayout(false);
            this.PanelHorizontalSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaHistorico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelHorizontalSuperior;
        public System.Windows.Forms.Label LblDataLong;
        public System.Windows.Forms.Label LblCaptionAtividade;
        private System.Windows.Forms.DataGridView GridListaHistorico;
        private System.Windows.Forms.Label LblBuscarLogin;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarLogin;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TxtBuscaDataInicio;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscaTamanho;
        private System.Windows.Forms.Label LblBuscaDataInicio;
        private System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TxtBuscaDataFinal;
        private System.Windows.Forms.Timer TimeExecultaConsulta;
        private System.Windows.Forms.PictureBox PicCarregando;
        private Syncfusion.WinForms.Controls.SfButton BtnAtualizar;
    }
}