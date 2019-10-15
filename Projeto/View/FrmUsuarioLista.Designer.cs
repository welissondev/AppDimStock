namespace SysEstoque.View
{
    partial class FrmUsuarioLista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioLista));
            this.PanelHorizontalSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnAtualizar = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnNovo = new Syncfusion.WinForms.Controls.SfButton();
            this.LblDataLong = new System.Windows.Forms.Label();
            this.LblCaptionAtividade = new System.Windows.Forms.Label();
            this.BtnListaUsuario = new System.Windows.Forms.DataGridView();
            this.PicCarregando = new System.Windows.Forms.PictureBox();
            this.TxtBuscar = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblBuscar = new System.Windows.Forms.Label();
            this.TimerExecuteConsulta = new System.Windows.Forms.Timer(this.components);
            this.PanelHorizontalSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnListaUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelHorizontalSuperior
            // 
            this.PanelHorizontalSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHorizontalSuperior.BackgroundImage")));
            this.PanelHorizontalSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHorizontalSuperior.Controls.Add(this.BtnAtualizar);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnNovo);
            this.PanelHorizontalSuperior.Controls.Add(this.LblDataLong);
            this.PanelHorizontalSuperior.Controls.Add(this.LblCaptionAtividade);
            this.PanelHorizontalSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontalSuperior.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientTopLeft = System.Drawing.SystemColors.ControlText;
            this.PanelHorizontalSuperior.GradientTopRight = System.Drawing.SystemColors.ControlText;
            this.PanelHorizontalSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelHorizontalSuperior.Name = "PanelHorizontalSuperior";
            this.PanelHorizontalSuperior.Quality = 10;
            this.PanelHorizontalSuperior.Size = new System.Drawing.Size(1035, 100);
            this.PanelHorizontalSuperior.TabIndex = 141;
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.AccessibleName = "Button";
            this.BtnAtualizar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnAtualizar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAtualizar.ForeColor = System.Drawing.Color.White;
            this.BtnAtualizar.Location = new System.Drawing.Point(101, 50);
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
            this.BtnAtualizar.TabIndex = 143;
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
            this.BtnNovo.Location = new System.Drawing.Point(18, 50);
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
            this.BtnNovo.TabIndex = 142;
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
            this.LblDataLong.Location = new System.Drawing.Point(574, 24);
            this.LblDataLong.Name = "LblDataLong";
            this.LblDataLong.Size = new System.Drawing.Size(455, 40);
            this.LblDataLong.TabIndex = 139;
            this.LblDataLong.Text = "Data de hoje";
            this.LblDataLong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCaptionAtividade
            // 
            this.LblCaptionAtividade.AutoSize = true;
            this.LblCaptionAtividade.BackColor = System.Drawing.Color.Transparent;
            this.LblCaptionAtividade.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaptionAtividade.ForeColor = System.Drawing.Color.White;
            this.LblCaptionAtividade.Location = new System.Drawing.Point(10, 7);
            this.LblCaptionAtividade.Name = "LblCaptionAtividade";
            this.LblCaptionAtividade.Size = new System.Drawing.Size(267, 40);
            this.LblCaptionAtividade.TabIndex = 138;
            this.LblCaptionAtividade.Text = "Lista de Usuários";
            // 
            // BtnListaUsuario
            // 
            this.BtnListaUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnListaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BtnListaUsuario.Location = new System.Drawing.Point(31, 176);
            this.BtnListaUsuario.Name = "BtnListaUsuario";
            this.BtnListaUsuario.Size = new System.Drawing.Size(980, 441);
            this.BtnListaUsuario.TabIndex = 142;
            this.BtnListaUsuario.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridListaUsuario_CellMouseClick);
            this.BtnListaUsuario.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridListaUsuario_CellMouseMove);
            // 
            // PicCarregando
            // 
            this.PicCarregando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicCarregando.Image = global::SysEstoque.Properties.Resources.Load;
            this.PicCarregando.Location = new System.Drawing.Point(456, 313);
            this.PicCarregando.Name = "PicCarregando";
            this.PicCarregando.Size = new System.Drawing.Size(129, 133);
            this.PicCarregando.TabIndex = 143;
            this.PicCarregando.TabStop = false;
            this.PicCarregando.Visible = false;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscar.BeforeTouchSize = new System.Drawing.Size(304, 29);
            this.TxtBuscar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscar.CanOverrideStyle = true;
            this.TxtBuscar.CausesValidation = false;
            this.TxtBuscar.CornerRadius = 4;
            this.TxtBuscar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscar.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscar.Location = new System.Drawing.Point(31, 141);
            this.TxtBuscar.MaxLength = 2000;
            this.TxtBuscar.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscar.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscar.Multiline = true;
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtBuscar.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtBuscar.Size = new System.Drawing.Size(304, 29);
            this.TxtBuscar.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtBuscar.TabIndex = 144;
            this.TxtBuscar.Tag = "";
            this.TxtBuscar.ThemeName = "Office2016White";
            this.TxtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscar_KeyPress);
            // 
            // LblBuscar
            // 
            this.LblBuscar.AutoSize = true;
            this.LblBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBuscar.Location = new System.Drawing.Point(28, 122);
            this.LblBuscar.Name = "LblBuscar";
            this.LblBuscar.Size = new System.Drawing.Size(53, 16);
            this.LblBuscar.TabIndex = 145;
            this.LblBuscar.Text = "Buscar:";
            // 
            // TimerExecuteConsulta
            // 
            this.TimerExecuteConsulta.Interval = 1000;
            this.TimerExecuteConsulta.Tick += new System.EventHandler(this.TimerExecuteConsulta_Tick);
            // 
            // FrmUsuarioLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 629);
            this.Controls.Add(this.PicCarregando);
            this.Controls.Add(this.TxtBuscar);
            this.Controls.Add(this.LblBuscar);
            this.Controls.Add(this.BtnListaUsuario);
            this.Controls.Add(this.PanelHorizontalSuperior);
            this.Name = "FrmUsuarioLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUsuarioLista_Load);
            this.PanelHorizontalSuperior.ResumeLayout(false);
            this.PanelHorizontalSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnListaUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelHorizontalSuperior;
        public System.Windows.Forms.Label LblDataLong;
        public System.Windows.Forms.Label LblCaptionAtividade;
        private System.Windows.Forms.DataGridView BtnListaUsuario;
        private System.Windows.Forms.PictureBox PicCarregando;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscar;
        private System.Windows.Forms.Label LblBuscar;
        private System.Windows.Forms.Timer TimerExecuteConsulta;
        private Syncfusion.WinForms.Controls.SfButton BtnNovo;
        private Syncfusion.WinForms.Controls.SfButton BtnAtualizar;
    }
}