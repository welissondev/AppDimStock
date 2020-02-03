namespace DimStock.UserForms
{
    partial class UserListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListingForm));
            this.UserDataList = new System.Windows.Forms.DataGridView();
            this.GifLoading = new System.Windows.Forms.PictureBox();
            this.SearchFields = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchFieldTitle = new System.Windows.Forms.Label();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.DataList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.RegisterNew = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.UserDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchFields)).BeginInit();
            this.SuspendLayout();
            // 
            // UserDataList
            // 
            this.UserDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UserDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UserDataList.Location = new System.Drawing.Point(31, 136);
            this.UserDataList.Name = "UserDataList";
            this.UserDataList.Size = new System.Drawing.Size(980, 481);
            this.UserDataList.TabIndex = 142;
            this.UserDataList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserDataList_CellMouseClick);
            this.UserDataList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserDataList_CellMouseEnter);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GifLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.GifLoading.Location = new System.Drawing.Point(455, 303);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(194, 198);
            this.GifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GifLoading.TabIndex = 143;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
            // 
            // SearchFields
            // 
            this.SearchFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchFields.BeforeTouchSize = new System.Drawing.Size(413, 27);
            this.SearchFields.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.SearchFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchFields.CanOverrideStyle = true;
            this.SearchFields.CausesValidation = false;
            this.SearchFields.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchFields.Location = new System.Drawing.Point(31, 103);
            this.SearchFields.MaxLength = 2000;
            this.SearchFields.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchFields.Multiline = true;
            this.SearchFields.Name = "SearchFields";
            this.SearchFields.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.SearchFields.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.SearchFields.Size = new System.Drawing.Size(413, 27);
            this.SearchFields.TabIndex = 144;
            this.SearchFields.Tag = "";
            this.SearchFields.ThemeName = "Default";
            this.SearchFields.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchFields_KeyPress);
            // 
            // SearchFieldTitle
            // 
            this.SearchFieldTitle.AutoSize = true;
            this.SearchFieldTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFieldTitle.Location = new System.Drawing.Point(28, 87);
            this.SearchFieldTitle.Name = "SearchFieldTitle";
            this.SearchFieldTitle.Size = new System.Drawing.Size(53, 16);
            this.SearchFieldTitle.TabIndex = 145;
            this.SearchFieldTitle.Text = "Buscar:";
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // DataList
            // 
            this.DataList.ActiveBorderThickness = 1;
            this.DataList.ActiveCornerRadius = 10;
            this.DataList.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.DataList.ActiveForecolor = System.Drawing.Color.White;
            this.DataList.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.DataList.BackColor = System.Drawing.Color.White;
            this.DataList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataList.BackgroundImage")));
            this.DataList.ButtonText = "Listar";
            this.DataList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataList.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.DataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.DataList.IdleBorderThickness = 1;
            this.DataList.IdleCornerRadius = 10;
            this.DataList.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.DataList.IdleForecolor = System.Drawing.Color.White;
            this.DataList.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.DataList.Location = new System.Drawing.Point(130, 23);
            this.DataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(97, 43);
            this.DataList.TabIndex = 219;
            this.DataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataList.Click += new System.EventHandler(this.DataList_Click);
            // 
            // RegisterNew
            // 
            this.RegisterNew.ActiveBorderThickness = 1;
            this.RegisterNew.ActiveCornerRadius = 10;
            this.RegisterNew.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.RegisterNew.ActiveForecolor = System.Drawing.Color.White;
            this.RegisterNew.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.RegisterNew.BackColor = System.Drawing.Color.White;
            this.RegisterNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RegisterNew.BackgroundImage")));
            this.RegisterNew.ButtonText = "Novo";
            this.RegisterNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterNew.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.RegisterNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.IdleBorderThickness = 1;
            this.RegisterNew.IdleCornerRadius = 10;
            this.RegisterNew.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.RegisterNew.IdleForecolor = System.Drawing.Color.White;
            this.RegisterNew.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.RegisterNew.Location = new System.Drawing.Point(31, 23);
            this.RegisterNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterNew.Name = "RegisterNew";
            this.RegisterNew.Size = new System.Drawing.Size(97, 43);
            this.RegisterNew.TabIndex = 220;
            this.RegisterNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterNew.Click += new System.EventHandler(this.RegisterNew_Click_1);
            // 
            // UserListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 629);
            this.Controls.Add(this.RegisterNew);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.GifLoading);
            this.Controls.Add(this.SearchFields);
            this.Controls.Add(this.SearchFieldTitle);
            this.Controls.Add(this.UserDataList);
            this.Name = "UserListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView UserDataList;
        private System.Windows.Forms.PictureBox GifLoading;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt SearchFields;
        private System.Windows.Forms.Label SearchFieldTitle;
        private System.Windows.Forms.Timer SearchTimer;
        private Bunifu.Framework.UI.BunifuThinButton2 DataList;
        private Bunifu.Framework.UI.BunifuThinButton2 RegisterNew;
    }
}