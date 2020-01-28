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
            this.UpdateDataList = new Syncfusion.WinForms.Controls.SfButton();
            this.RegisterNew = new Syncfusion.WinForms.Controls.SfButton();
            this.UserDataList = new System.Windows.Forms.DataGridView();
            this.GifLoading = new System.Windows.Forms.PictureBox();
            this.SearchFields = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchFieldTitle = new System.Windows.Forms.Label();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UserDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchFields)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateDataList
            // 
            this.UpdateDataList.AccessibleName = "Button";
            this.UpdateDataList.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataList.ForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Location = new System.Drawing.Point(117, 31);
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
            this.UpdateDataList.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.PressedForeColor = System.Drawing.Color.White;
            this.UpdateDataList.TabIndex = 143;
            this.UpdateDataList.Text = "Atualizar";
            this.UpdateDataList.UseVisualStyleBackColor = false;
            this.UpdateDataList.Click += new System.EventHandler(this.UpdateDataList_Click);
            // 
            // RegisterNew
            // 
            this.RegisterNew.AccessibleName = "Button";
            this.RegisterNew.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNew.ForeColor = System.Drawing.Color.White;
            this.RegisterNew.Location = new System.Drawing.Point(34, 31);
            this.RegisterNew.Name = "RegisterNew";
            this.RegisterNew.Size = new System.Drawing.Size(80, 35);
            this.RegisterNew.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Style.FocusedForeColor = System.Drawing.Color.White;
            this.RegisterNew.Style.ForeColor = System.Drawing.Color.White;
            this.RegisterNew.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Style.HoverForeColor = System.Drawing.Color.Black;
            this.RegisterNew.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Style.PressedForeColor = System.Drawing.Color.White;
            this.RegisterNew.TabIndex = 142;
            this.RegisterNew.Text = "Novo";
            this.RegisterNew.UseVisualStyleBackColor = false;
            this.RegisterNew.Click += new System.EventHandler(this.RegisterNew_Click);
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
            this.UserDataList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.UserDataList_CellMouseMove);
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
            // UserListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 629);
            this.Controls.Add(this.UpdateDataList);
            this.Controls.Add(this.RegisterNew);
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
        private Syncfusion.WinForms.Controls.SfButton RegisterNew;
        private Syncfusion.WinForms.Controls.SfButton UpdateDataList;
    }
}