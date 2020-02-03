namespace DimStock.UserForms
{
    partial class StockDestinationRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDestinationRegistrationForm));
            this.DestinationLocationTitle = new System.Windows.Forms.Label();
            this.DestinationLocation = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.DestinationDataList = new System.Windows.Forms.DataGridView();
            this.Edit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DataList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Delete = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // DestinationLocationTitle
            // 
            this.DestinationLocationTitle.AutoSize = true;
            this.DestinationLocationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLocationTitle.ForeColor = System.Drawing.Color.Black;
            this.DestinationLocationTitle.Location = new System.Drawing.Point(29, 48);
            this.DestinationLocationTitle.Name = "DestinationLocationTitle";
            this.DestinationLocationTitle.Size = new System.Drawing.Size(162, 20);
            this.DestinationLocationTitle.TabIndex = 144;
            this.DestinationLocationTitle.Text = "Descrição do destino:";
            // 
            // DestinationLocation
            // 
            this.DestinationLocation.BackColor = System.Drawing.Color.White;
            this.DestinationLocation.BeforeTouchSize = new System.Drawing.Size(400, 26);
            this.DestinationLocation.BorderColor = System.Drawing.Color.Silver;
            this.DestinationLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationLocation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DestinationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DestinationLocation.Location = new System.Drawing.Point(32, 70);
            this.DestinationLocation.MinimumSize = new System.Drawing.Size(14, 10);
            this.DestinationLocation.Name = "DestinationLocation";
            this.DestinationLocation.Size = new System.Drawing.Size(400, 26);
            this.DestinationLocation.TabIndex = 143;
            this.DestinationLocation.ThemeName = "Default";
            // 
            // DestinationDataList
            // 
            this.DestinationDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestinationDataList.Location = new System.Drawing.Point(32, 99);
            this.DestinationDataList.Name = "DestinationDataList";
            this.DestinationDataList.Size = new System.Drawing.Size(649, 226);
            this.DestinationDataList.TabIndex = 145;
            this.DestinationDataList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DestinationDataList_CellMouseEnter);
            this.DestinationDataList.DoubleClick += new System.EventHandler(this.DestinationDataList_DoubleClick);
            // 
            // Edit
            // 
            this.Edit.ActiveBorderThickness = 1;
            this.Edit.ActiveCornerRadius = 10;
            this.Edit.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.Edit.ActiveForecolor = System.Drawing.Color.White;
            this.Edit.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.Edit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Edit.BackColor = System.Drawing.Color.White;
            this.Edit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Edit.BackgroundImage")));
            this.Edit.ButtonText = "Editar";
            this.Edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Edit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.SeaGreen;
            this.Edit.IdleBorderThickness = 1;
            this.Edit.IdleCornerRadius = 10;
            this.Edit.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.Edit.IdleForecolor = System.Drawing.Color.White;
            this.Edit.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.Edit.Location = new System.Drawing.Point(131, 335);
            this.Edit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(97, 43);
            this.Edit.TabIndex = 215;
            this.Edit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Save
            // 
            this.Save.ActiveBorderThickness = 1;
            this.Save.ActiveCornerRadius = 10;
            this.Save.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.Save.ActiveForecolor = System.Drawing.Color.White;
            this.Save.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.ButtonText = "Salvar";
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.Save.IdleBorderThickness = 1;
            this.Save.IdleCornerRadius = 10;
            this.Save.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.Save.IdleForecolor = System.Drawing.Color.White;
            this.Save.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.Save.Location = new System.Drawing.Point(32, 335);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 43);
            this.Save.TabIndex = 214;
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // DataList
            // 
            this.DataList.ActiveBorderThickness = 1;
            this.DataList.ActiveCornerRadius = 10;
            this.DataList.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.DataList.ActiveForecolor = System.Drawing.Color.White;
            this.DataList.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.DataList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DataList.BackColor = System.Drawing.Color.White;
            this.DataList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataList.BackgroundImage")));
            this.DataList.ButtonText = "Listar";
            this.DataList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataList.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.DataList.IdleBorderThickness = 1;
            this.DataList.IdleCornerRadius = 10;
            this.DataList.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.DataList.IdleForecolor = System.Drawing.Color.White;
            this.DataList.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.DataList.Location = new System.Drawing.Point(330, 335);
            this.DataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(97, 43);
            this.DataList.TabIndex = 217;
            this.DataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataList.Click += new System.EventHandler(this.DataList_Click);
            // 
            // Delete
            // 
            this.Delete.ActiveBorderThickness = 1;
            this.Delete.ActiveCornerRadius = 10;
            this.Delete.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.Delete.ActiveForecolor = System.Drawing.Color.White;
            this.Delete.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Delete.BackColor = System.Drawing.Color.White;
            this.Delete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Delete.BackgroundImage")));
            this.Delete.ButtonText = "Deletar";
            this.Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Delete.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.SeaGreen;
            this.Delete.IdleBorderThickness = 1;
            this.Delete.IdleCornerRadius = 10;
            this.Delete.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.Delete.IdleForecolor = System.Drawing.Color.White;
            this.Delete.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.Delete.Location = new System.Drawing.Point(231, 335);
            this.Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(97, 43);
            this.Delete.TabIndex = 216;
            this.Delete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // StockDestinationRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 441);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.DestinationDataList);
            this.Controls.Add(this.DestinationLocationTitle);
            this.Controls.Add(this.DestinationLocation);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(728, 460);
            this.Name = "StockDestinationRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StockDestinationRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DestinationLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationDataList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label DestinationLocationTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt DestinationLocation;
        private System.Windows.Forms.DataGridView DestinationDataList;
        private Bunifu.Framework.UI.BunifuThinButton2 Edit;
        private Bunifu.Framework.UI.BunifuThinButton2 Save;
        private Bunifu.Framework.UI.BunifuThinButton2 DataList;
        private Bunifu.Framework.UI.BunifuThinButton2 Delete;
    }
}