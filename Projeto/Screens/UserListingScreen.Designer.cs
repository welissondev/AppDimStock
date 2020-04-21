namespace DimStock.Screens
{
    partial class UserListingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserListingScreen));
            this.DatagridUser = new System.Windows.Forms.DataGridView();
            this.PictureLoading = new System.Windows.Forms.PictureBox();
            this.TextSearchFields = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchFieldTitle = new System.Windows.Forms.Label();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.ButtonDataList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonRegisterNew = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchFields)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridUser
            // 
            this.DatagridUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatagridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridUser.Location = new System.Drawing.Point(31, 136);
            this.DatagridUser.Name = "DatagridUser";
            this.DatagridUser.Size = new System.Drawing.Size(873, 403);
            this.DatagridUser.TabIndex = 142;
            this.DatagridUser.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatagridUser_CellMouseClick);
            this.DatagridUser.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridUser_CellMouseEnter);
            // 
            // PictureLoading
            // 
            this.PictureLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.PictureLoading.Location = new System.Drawing.Point(407, 269);
            this.PictureLoading.Name = "PictureLoading";
            this.PictureLoading.Size = new System.Drawing.Size(135, 135);
            this.PictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLoading.TabIndex = 143;
            this.PictureLoading.TabStop = false;
            this.PictureLoading.Visible = false;
            // 
            // TextSearchFields
            // 
            this.TextSearchFields.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextSearchFields.BeforeTouchSize = new System.Drawing.Size(413, 27);
            this.TextSearchFields.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TextSearchFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchFields.CanOverrideStyle = true;
            this.TextSearchFields.CausesValidation = false;
            this.TextSearchFields.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchFields.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchFields.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSearchFields.Location = new System.Drawing.Point(31, 103);
            this.TextSearchFields.MaxLength = 2000;
            this.TextSearchFields.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchFields.Multiline = true;
            this.TextSearchFields.Name = "TextSearchFields";
            this.TextSearchFields.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TextSearchFields.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TextSearchFields.Size = new System.Drawing.Size(413, 27);
            this.TextSearchFields.TabIndex = 144;
            this.TextSearchFields.Tag = "";
            this.TextSearchFields.ThemeName = "Default";
            this.TextSearchFields.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearchFields_KeyPress);
            // 
            // SearchFieldTitle
            // 
            this.SearchFieldTitle.AutoSize = true;
            this.SearchFieldTitle.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.SearchFieldTitle.Location = new System.Drawing.Point(28, 85);
            this.SearchFieldTitle.Name = "SearchFieldTitle";
            this.SearchFieldTitle.Size = new System.Drawing.Size(52, 18);
            this.SearchFieldTitle.TabIndex = 145;
            this.SearchFieldTitle.Text = "Buscar:";
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // ButtonDataList
            // 
            this.ButtonDataList.ActiveBorderThickness = 1;
            this.ButtonDataList.ActiveCornerRadius = 10;
            this.ButtonDataList.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDataList.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonDataList.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDataList.BackColor = System.Drawing.Color.White;
            this.ButtonDataList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDataList.BackgroundImage")));
            this.ButtonDataList.ButtonText = "Listar";
            this.ButtonDataList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDataList.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonDataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonDataList.IdleBorderThickness = 1;
            this.ButtonDataList.IdleCornerRadius = 10;
            this.ButtonDataList.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDataList.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.Location = new System.Drawing.Point(130, 23);
            this.ButtonDataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDataList.Name = "ButtonDataList";
            this.ButtonDataList.Size = new System.Drawing.Size(97, 43);
            this.ButtonDataList.TabIndex = 219;
            this.ButtonDataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDataList.Click += new System.EventHandler(this.ButtonDataList_Click);
            // 
            // ButtonRegisterNew
            // 
            this.ButtonRegisterNew.ActiveBorderThickness = 1;
            this.ButtonRegisterNew.ActiveCornerRadius = 10;
            this.ButtonRegisterNew.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonRegisterNew.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonRegisterNew.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonRegisterNew.BackColor = System.Drawing.Color.White;
            this.ButtonRegisterNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonRegisterNew.BackgroundImage")));
            this.ButtonRegisterNew.ButtonText = "Novo";
            this.ButtonRegisterNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRegisterNew.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonRegisterNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonRegisterNew.IdleBorderThickness = 1;
            this.ButtonRegisterNew.IdleCornerRadius = 10;
            this.ButtonRegisterNew.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonRegisterNew.IdleForecolor = System.Drawing.Color.White;
            this.ButtonRegisterNew.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonRegisterNew.Location = new System.Drawing.Point(31, 23);
            this.ButtonRegisterNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonRegisterNew.Name = "ButtonRegisterNew";
            this.ButtonRegisterNew.Size = new System.Drawing.Size(97, 43);
            this.ButtonRegisterNew.TabIndex = 220;
            this.ButtonRegisterNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonRegisterNew.Click += new System.EventHandler(this.ButtonRegisterNew_Click);
            // 
            // UserListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.ButtonRegisterNew);
            this.Controls.Add(this.ButtonDataList);
            this.Controls.Add(this.PictureLoading);
            this.Controls.Add(this.TextSearchFields);
            this.Controls.Add(this.SearchFieldTitle);
            this.Controls.Add(this.DatagridUser);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "UserListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UserListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DatagridUser;
        private System.Windows.Forms.PictureBox PictureLoading;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchFields;
        private System.Windows.Forms.Label SearchFieldTitle;
        private System.Windows.Forms.Timer SearchTimer;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDataList;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonRegisterNew;
    }
}