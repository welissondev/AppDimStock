namespace DimStock.View
{
    partial class UserHistoryListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHistoryListingForm));
            this.HistoryDataList = new System.Windows.Forms.DataGridView();
            this.SearchTitleByLogin = new System.Windows.Forms.Label();
            this.SearchByLogin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.StartDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.StartDateTitle = new System.Windows.Forms.Label();
            this.FinalDateTitle = new System.Windows.Forms.Label();
            this.FinalDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.GifLoading = new System.Windows.Forms.PictureBox();
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.UpdateDataList = new Syncfusion.WinForms.Controls.SfButton();
            this.DayOfTheWeek = new System.Windows.Forms.Label();
            this.FormCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            this.PanelUpperHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // HistoryDataList
            // 
            this.HistoryDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryDataList.Location = new System.Drawing.Point(29, 190);
            this.HistoryDataList.Name = "HistoryDataList";
            this.HistoryDataList.Size = new System.Drawing.Size(907, 464);
            this.HistoryDataList.TabIndex = 145;
            // 
            // SearchTitleByLogin
            // 
            this.SearchTitleByLogin.AutoSize = true;
            this.SearchTitleByLogin.Location = new System.Drawing.Point(26, 143);
            this.SearchTitleByLogin.Name = "SearchTitleByLogin";
            this.SearchTitleByLogin.Size = new System.Drawing.Size(72, 13);
            this.SearchTitleByLogin.TabIndex = 147;
            this.SearchTitleByLogin.Text = "Buscar Login:";
            // 
            // SearchByLogin
            // 
            this.SearchByLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByLogin.BeforeTouchSize = new System.Drawing.Size(136, 27);
            this.SearchByLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchByLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByLogin.CanOverrideStyle = true;
            this.SearchByLogin.CausesValidation = false;
            this.SearchByLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByLogin.Location = new System.Drawing.Point(29, 157);
            this.SearchByLogin.MaxLength = 50;
            this.SearchByLogin.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchByLogin.Multiline = true;
            this.SearchByLogin.Name = "SearchByLogin";
            this.SearchByLogin.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchByLogin.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchByLogin.Size = new System.Drawing.Size(136, 27);
            this.SearchByLogin.TabIndex = 146;
            this.SearchByLogin.Tag = "";
            this.SearchByLogin.ThemeName = "Default";
            this.SearchByLogin.TextChanged += new System.EventHandler(this.SearchByLogin_TextChanged);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(168, 157);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(124, 27);
            this.StartDate.Style.BorderColor = System.Drawing.Color.Silver;
            this.StartDate.Style.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.StartDate.Style.ForeColor = System.Drawing.Color.Black;
            this.StartDate.Style.HoverBorderColor = System.Drawing.Color.Silver;
            this.StartDate.Style.UpDownForeColor = System.Drawing.Color.White;
            this.StartDate.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.StartDate.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.StartDate.TabIndex = 148;
            // 
            // StartDateTitle
            // 
            this.StartDateTitle.AutoSize = true;
            this.StartDateTitle.Location = new System.Drawing.Point(165, 143);
            this.StartDateTitle.Name = "StartDateTitle";
            this.StartDateTitle.Size = new System.Drawing.Size(61, 13);
            this.StartDateTitle.TabIndex = 144;
            this.StartDateTitle.Text = "Data Inicio:";
            // 
            // FinalDateTitle
            // 
            this.FinalDateTitle.AutoSize = true;
            this.FinalDateTitle.Location = new System.Drawing.Point(292, 143);
            this.FinalDateTitle.Name = "FinalDateTitle";
            this.FinalDateTitle.Size = new System.Drawing.Size(58, 13);
            this.FinalDateTitle.TabIndex = 150;
            this.FinalDateTitle.Text = "Data Final:";
            // 
            // FinalDate
            // 
            this.FinalDate.Location = new System.Drawing.Point(295, 157);
            this.FinalDate.Name = "FinalDate";
            this.FinalDate.Size = new System.Drawing.Size(121, 27);
            this.FinalDate.Style.BorderColor = System.Drawing.Color.Silver;
            this.FinalDate.Style.DisabledForeColor = System.Drawing.Color.White;
            this.FinalDate.Style.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.FinalDate.Style.HoverBorderColor = System.Drawing.Color.Silver;
            this.FinalDate.Style.UpDownForeColor = System.Drawing.Color.White;
            this.FinalDate.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.FinalDate.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.FinalDate.TabIndex = 151;
            this.FinalDate.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.FinalDate_ValueChanged);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GifLoading.Image = global::DimStock.Properties.Resources.GigLoading;
            this.GifLoading.Location = new System.Drawing.Point(394, 330);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(176, 175);
            this.GifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GifLoading.TabIndex = 152;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
            // 
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.UpdateDataList);
            this.PanelUpperHorizontal.Controls.Add(this.DayOfTheWeek);
            this.PanelUpperHorizontal.Controls.Add(this.FormCaption);
            this.PanelUpperHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpperHorizontal.GradientBottomLeft = System.Drawing.Color.Black;
            this.PanelUpperHorizontal.GradientBottomRight = System.Drawing.Color.Black;
            this.PanelUpperHorizontal.GradientTopLeft = System.Drawing.Color.Gray;
            this.PanelUpperHorizontal.GradientTopRight = System.Drawing.Color.Gray;
            this.PanelUpperHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PanelUpperHorizontal.Name = "PanelUpperHorizontal";
            this.PanelUpperHorizontal.Quality = 10;
            this.PanelUpperHorizontal.Size = new System.Drawing.Size(964, 95);
            this.PanelUpperHorizontal.TabIndex = 140;
            // 
            // UpdateDataList
            // 
            this.UpdateDataList.AccessibleName = "Button";
            this.UpdateDataList.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataList.ForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Location = new System.Drawing.Point(17, 47);
            this.UpdateDataList.Name = "UpdateDataList";
            this.UpdateDataList.Size = new System.Drawing.Size(80, 35);
            this.UpdateDataList.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.FocusedForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Style.ForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.HoverForeColor = System.Drawing.Color.Black;
            this.UpdateDataList.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.UpdateDataList.Style.PressedForeColor = System.Drawing.Color.White;
            this.UpdateDataList.TabIndex = 140;
            this.UpdateDataList.Text = "Atualizar";
            this.UpdateDataList.UseVisualStyleBackColor = false;
            this.UpdateDataList.Click += new System.EventHandler(this.UpdateDataList_Click);
            // 
            // DayOfTheWeek
            // 
            this.DayOfTheWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DayOfTheWeek.BackColor = System.Drawing.Color.Transparent;
            this.DayOfTheWeek.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayOfTheWeek.ForeColor = System.Drawing.Color.White;
            this.DayOfTheWeek.Location = new System.Drawing.Point(467, 23);
            this.DayOfTheWeek.Name = "DayOfTheWeek";
            this.DayOfTheWeek.Size = new System.Drawing.Size(494, 40);
            this.DayOfTheWeek.TabIndex = 139;
            this.DayOfTheWeek.Text = "DayOfTheWeek";
            this.DayOfTheWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCaption
            // 
            this.FormCaption.AutoSize = true;
            this.FormCaption.BackColor = System.Drawing.Color.Transparent;
            this.FormCaption.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCaption.ForeColor = System.Drawing.Color.White;
            this.FormCaption.Location = new System.Drawing.Point(10, 4);
            this.FormCaption.Name = "FormCaption";
            this.FormCaption.Size = new System.Drawing.Size(444, 40);
            this.FormCaption.TabIndex = 138;
            this.FormCaption.Text = "Lista De Histórico Do Usuário";
            // 
            // UserHistoryListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.GifLoading);
            this.Controls.Add(this.FinalDate);
            this.Controls.Add(this.FinalDateTitle);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.SearchTitleByLogin);
            this.Controls.Add(this.SearchByLogin);
            this.Controls.Add(this.HistoryDataList);
            this.Controls.Add(this.StartDateTitle);
            this.Controls.Add(this.PanelUpperHorizontal);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "UserHistoryListingForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.UserHistoryListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).EndInit();
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        public System.Windows.Forms.Label DayOfTheWeek;
        public System.Windows.Forms.Label FormCaption;
        private System.Windows.Forms.DataGridView HistoryDataList;
        private System.Windows.Forms.Label SearchTitleByLogin;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchByLogin;
        private Syncfusion.WinForms.Input.SfDateTimeEdit StartDate;
        private System.Windows.Forms.Label StartDateTitle;
        private System.Windows.Forms.Label FinalDateTitle;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FinalDate;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.PictureBox GifLoading;
        private Syncfusion.WinForms.Controls.SfButton UpdateDataList;
    }
}