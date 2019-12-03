namespace DimStock.View
{
    partial class FrmUserHistoricList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserHistoricList));
            this.GridHistoricList = new System.Windows.Forms.DataGridView();
            this.LblQueryByLogin = new System.Windows.Forms.Label();
            this.TxtQueryByLogin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtStartDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.TxtBuscaTamanho = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblStartDate = new System.Windows.Forms.Label();
            this.LblFinalDate = new System.Windows.Forms.Label();
            this.textBoxExt2 = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtFinalDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.TimeExecuteQuery = new System.Windows.Forms.Timer(this.components);
            this.PicLoading = new System.Windows.Forms.PictureBox();
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnUpdateList = new Syncfusion.WinForms.Controls.SfButton();
            this.LblTodayIsDay = new System.Windows.Forms.Label();
            this.LblFormTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistoricList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoading)).BeginInit();
            this.PanelUpperHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridHistoricList
            // 
            this.GridHistoricList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHistoricList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHistoricList.Location = new System.Drawing.Point(29, 190);
            this.GridHistoricList.Name = "GridHistoricList";
            this.GridHistoricList.Size = new System.Drawing.Size(907, 464);
            this.GridHistoricList.TabIndex = 145;
            // 
            // LblQueryByLogin
            // 
            this.LblQueryByLogin.AutoSize = true;
            this.LblQueryByLogin.Location = new System.Drawing.Point(23, 141);
            this.LblQueryByLogin.Name = "LblQueryByLogin";
            this.LblQueryByLogin.Size = new System.Drawing.Size(72, 13);
            this.LblQueryByLogin.TabIndex = 147;
            this.LblQueryByLogin.Text = "Buscar Login:";
            // 
            // TxtQueryByLogin
            // 
            this.TxtQueryByLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryByLogin.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtQueryByLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryByLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByLogin.CanOverrideStyle = true;
            this.TxtQueryByLogin.CausesValidation = false;
            this.TxtQueryByLogin.CornerRadius = 4;
            this.TxtQueryByLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByLogin.Location = new System.Drawing.Point(26, 157);
            this.TxtQueryByLogin.MaxLength = 50;
            this.TxtQueryByLogin.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByLogin.Multiline = true;
            this.TxtQueryByLogin.Name = "TxtQueryByLogin";
            this.TxtQueryByLogin.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByLogin.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByLogin.Size = new System.Drawing.Size(136, 29);
            this.TxtQueryByLogin.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryByLogin.TabIndex = 146;
            this.TxtQueryByLogin.Tag = "";
            this.TxtQueryByLogin.ThemeName = "Office2016Colorful";
            this.TxtQueryByLogin.TextChanged += new System.EventHandler(this.TxtQueryByLogin_TextChanged);
            // 
            // TxtStartDate
            // 
            this.TxtStartDate.Location = new System.Drawing.Point(173, 161);
            this.TxtStartDate.Name = "TxtStartDate";
            this.TxtStartDate.Size = new System.Drawing.Size(124, 23);
            this.TxtStartDate.Style.BorderColor = System.Drawing.Color.White;
            this.TxtStartDate.Style.FocusedBorderColor = System.Drawing.Color.White;
            this.TxtStartDate.Style.ForeColor = System.Drawing.Color.Black;
            this.TxtStartDate.Style.HoverBorderColor = System.Drawing.Color.White;
            this.TxtStartDate.Style.UpDownForeColor = System.Drawing.Color.White;
            this.TxtStartDate.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.TxtStartDate.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.TxtStartDate.TabIndex = 148;
            this.TxtStartDate.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.TxtStartDate_ValueChanged);
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
            this.TxtBuscaTamanho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscaTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscaTamanho.Location = new System.Drawing.Point(168, 157);
            this.TxtBuscaTamanho.MaxLength = 50;
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
            // LblStartDate
            // 
            this.LblStartDate.AutoSize = true;
            this.LblStartDate.Location = new System.Drawing.Point(165, 141);
            this.LblStartDate.Name = "LblStartDate";
            this.LblStartDate.Size = new System.Drawing.Size(61, 13);
            this.LblStartDate.TabIndex = 144;
            this.LblStartDate.Text = "Data Inicio:";
            // 
            // LblFinalDate
            // 
            this.LblFinalDate.AutoSize = true;
            this.LblFinalDate.Location = new System.Drawing.Point(307, 141);
            this.LblFinalDate.Name = "LblFinalDate";
            this.LblFinalDate.Size = new System.Drawing.Size(58, 13);
            this.LblFinalDate.TabIndex = 150;
            this.LblFinalDate.Text = "Data Final:";
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
            this.textBoxExt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxExt2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.textBoxExt2.Location = new System.Drawing.Point(310, 157);
            this.textBoxExt2.MaxLength = 50;
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
            // TxtFinalDate
            // 
            this.TxtFinalDate.Location = new System.Drawing.Point(319, 159);
            this.TxtFinalDate.Name = "TxtFinalDate";
            this.TxtFinalDate.Size = new System.Drawing.Size(121, 25);
            this.TxtFinalDate.Style.BorderColor = System.Drawing.Color.White;
            this.TxtFinalDate.Style.DisabledForeColor = System.Drawing.Color.White;
            this.TxtFinalDate.Style.FocusedBorderColor = System.Drawing.Color.White;
            this.TxtFinalDate.Style.HoverBorderColor = System.Drawing.Color.White;
            this.TxtFinalDate.Style.UpDownForeColor = System.Drawing.Color.White;
            this.TxtFinalDate.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.TxtFinalDate.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.TxtFinalDate.TabIndex = 151;
            this.TxtFinalDate.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.TxtFinalData_ValueChanged);
            // 
            // TimeExecuteQuery
            // 
            this.TimeExecuteQuery.Interval = 1000;
            this.TimeExecuteQuery.Tick += new System.EventHandler(this.TimeExecuteQuery_Tick);
            // 
            // PicLoading
            // 
            this.PicLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLoading.Image = global::DimStock.Properties.Resources.Load;
            this.PicLoading.Location = new System.Drawing.Point(414, 358);
            this.PicLoading.Name = "PicLoading";
            this.PicLoading.Size = new System.Drawing.Size(129, 137);
            this.PicLoading.TabIndex = 152;
            this.PicLoading.TabStop = false;
            this.PicLoading.Visible = false;
            // 
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.BtnUpdateList);
            this.PanelUpperHorizontal.Controls.Add(this.LblTodayIsDay);
            this.PanelUpperHorizontal.Controls.Add(this.LblFormTitle);
            this.PanelUpperHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpperHorizontal.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.PanelUpperHorizontal.GradientTopLeft = System.Drawing.Color.Black;
            this.PanelUpperHorizontal.GradientTopRight = System.Drawing.Color.Black;
            this.PanelUpperHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PanelUpperHorizontal.Name = "PanelUpperHorizontal";
            this.PanelUpperHorizontal.Quality = 10;
            this.PanelUpperHorizontal.Size = new System.Drawing.Size(964, 95);
            this.PanelUpperHorizontal.TabIndex = 140;
            // 
            // BtnUpdateList
            // 
            this.BtnUpdateList.AccessibleName = "Button";
            this.BtnUpdateList.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateList.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Location = new System.Drawing.Point(17, 47);
            this.BtnUpdateList.Name = "BtnUpdateList";
            this.BtnUpdateList.Size = new System.Drawing.Size(80, 35);
            this.BtnUpdateList.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Style.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnUpdateList.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnUpdateList.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.TabIndex = 140;
            this.BtnUpdateList.Text = "Atualizar";
            this.BtnUpdateList.UseVisualStyleBackColor = false;
            this.BtnUpdateList.Click += new System.EventHandler(this.BtnUpdateList_Click);
            // 
            // LblTodayIsDay
            // 
            this.LblTodayIsDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTodayIsDay.BackColor = System.Drawing.Color.Transparent;
            this.LblTodayIsDay.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTodayIsDay.ForeColor = System.Drawing.Color.White;
            this.LblTodayIsDay.Location = new System.Drawing.Point(467, 23);
            this.LblTodayIsDay.Name = "LblTodayIsDay";
            this.LblTodayIsDay.Size = new System.Drawing.Size(494, 40);
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
            this.LblFormTitle.Location = new System.Drawing.Point(10, 4);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(349, 40);
            this.LblFormTitle.TabIndex = 138;
            this.LblFormTitle.Text = "Lista Histórico Usuário";
            // 
            // FrmUserHistoricList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.PicLoading);
            this.Controls.Add(this.TxtFinalDate);
            this.Controls.Add(this.LblFinalDate);
            this.Controls.Add(this.textBoxExt2);
            this.Controls.Add(this.TxtStartDate);
            this.Controls.Add(this.LblQueryByLogin);
            this.Controls.Add(this.TxtQueryByLogin);
            this.Controls.Add(this.GridHistoricList);
            this.Controls.Add(this.LblStartDate);
            this.Controls.Add(this.TxtBuscaTamanho);
            this.Controls.Add(this.PanelUpperHorizontal);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmUserHistoricList";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.FrmUserHistoricList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridHistoricList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textBoxExt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoading)).EndInit();
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        public System.Windows.Forms.Label LblTodayIsDay;
        public System.Windows.Forms.Label LblFormTitle;
        private System.Windows.Forms.DataGridView GridHistoricList;
        private System.Windows.Forms.Label LblQueryByLogin;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByLogin;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TxtStartDate;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscaTamanho;
        private System.Windows.Forms.Label LblStartDate;
        private System.Windows.Forms.Label LblFinalDate;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt textBoxExt2;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TxtFinalDate;
        private System.Windows.Forms.Timer TimeExecuteQuery;
        private System.Windows.Forms.PictureBox PicLoading;
        private Syncfusion.WinForms.Controls.SfButton BtnUpdateList;
    }
}