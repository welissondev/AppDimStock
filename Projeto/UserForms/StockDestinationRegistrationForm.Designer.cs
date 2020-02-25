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
            this.TextDestinationLocation = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.DatagridDestination = new System.Windows.Forms.DataGridView();
            this.ButtonEdit = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonDataList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonDelete = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.TextDestinationLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridDestination)).BeginInit();
            this.SuspendLayout();
            // 
            // DestinationLocationTitle
            // 
            this.DestinationLocationTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DestinationLocationTitle.AutoSize = true;
            this.DestinationLocationTitle.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLocationTitle.ForeColor = System.Drawing.Color.Black;
            this.DestinationLocationTitle.Location = new System.Drawing.Point(9, 17);
            this.DestinationLocationTitle.Name = "DestinationLocationTitle";
            this.DestinationLocationTitle.Size = new System.Drawing.Size(136, 18);
            this.DestinationLocationTitle.TabIndex = 144;
            this.DestinationLocationTitle.Text = "Descrição do destino:";
            // 
            // TextDestinationLocation
            // 
            this.TextDestinationLocation.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TextDestinationLocation.BackColor = System.Drawing.Color.White;
            this.TextDestinationLocation.BeforeTouchSize = new System.Drawing.Size(400, 26);
            this.TextDestinationLocation.BorderColor = System.Drawing.Color.Silver;
            this.TextDestinationLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDestinationLocation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextDestinationLocation.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDestinationLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextDestinationLocation.Location = new System.Drawing.Point(12, 35);
            this.TextDestinationLocation.MinimumSize = new System.Drawing.Size(14, 10);
            this.TextDestinationLocation.Name = "TextDestinationLocation";
            this.TextDestinationLocation.Size = new System.Drawing.Size(400, 26);
            this.TextDestinationLocation.TabIndex = 143;
            this.TextDestinationLocation.ThemeName = "Default";
            // 
            // DatagridDestination
            // 
            this.DatagridDestination.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DatagridDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridDestination.Location = new System.Drawing.Point(12, 74);
            this.DatagridDestination.Name = "DatagridDestination";
            this.DatagridDestination.Size = new System.Drawing.Size(904, 465);
            this.DatagridDestination.TabIndex = 145;
            this.DatagridDestination.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridDestination_CellMouseEnter);
            this.DatagridDestination.DoubleClick += new System.EventHandler(this.DatagridDestination_DoubleClick);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.ActiveBorderThickness = 1;
            this.ButtonEdit.ActiveCornerRadius = 10;
            this.ButtonEdit.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonEdit.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonEdit.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonEdit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonEdit.BackColor = System.Drawing.Color.White;
            this.ButtonEdit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEdit.BackgroundImage")));
            this.ButtonEdit.ButtonText = "Editar";
            this.ButtonEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEdit.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEdit.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonEdit.IdleBorderThickness = 1;
            this.ButtonEdit.IdleCornerRadius = 10;
            this.ButtonEdit.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonEdit.IdleForecolor = System.Drawing.Color.White;
            this.ButtonEdit.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonEdit.Location = new System.Drawing.Point(619, 16);
            this.ButtonEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(97, 43);
            this.ButtonEdit.TabIndex = 215;
            this.ButtonEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.ActiveBorderThickness = 1;
            this.ButtonSave.ActiveCornerRadius = 10;
            this.ButtonSave.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonSave.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonSave.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonSave.BackColor = System.Drawing.Color.White;
            this.ButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.BackgroundImage")));
            this.ButtonSave.ButtonText = "Salvar";
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonSave.IdleBorderThickness = 1;
            this.ButtonSave.IdleCornerRadius = 10;
            this.ButtonSave.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSave.IdleForecolor = System.Drawing.Color.White;
            this.ButtonSave.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSave.Location = new System.Drawing.Point(520, 16);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 43);
            this.ButtonSave.TabIndex = 214;
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDataList
            // 
            this.ButtonDataList.ActiveBorderThickness = 1;
            this.ButtonDataList.ActiveCornerRadius = 10;
            this.ButtonDataList.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDataList.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonDataList.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDataList.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonDataList.BackColor = System.Drawing.Color.White;
            this.ButtonDataList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDataList.BackgroundImage")));
            this.ButtonDataList.ButtonText = "Listar";
            this.ButtonDataList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDataList.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonDataList.IdleBorderThickness = 1;
            this.ButtonDataList.IdleCornerRadius = 10;
            this.ButtonDataList.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDataList.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.Location = new System.Drawing.Point(818, 16);
            this.ButtonDataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDataList.Name = "ButtonDataList";
            this.ButtonDataList.Size = new System.Drawing.Size(97, 43);
            this.ButtonDataList.TabIndex = 217;
            this.ButtonDataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDataList.Click += new System.EventHandler(this.ButtonDataList_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.ActiveBorderThickness = 1;
            this.ButtonDelete.ActiveCornerRadius = 10;
            this.ButtonDelete.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDelete.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonDelete.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ButtonDelete.BackColor = System.Drawing.Color.White;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.ButtonText = "Deletar";
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDelete.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonDelete.IdleBorderThickness = 1;
            this.ButtonDelete.IdleCornerRadius = 10;
            this.ButtonDelete.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDelete.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDelete.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDelete.Location = new System.Drawing.Point(719, 16);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(97, 43);
            this.ButtonDelete.TabIndex = 216;
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // StockDestinationRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.ButtonDataList);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.DatagridDestination);
            this.Controls.Add(this.DestinationLocationTitle);
            this.Controls.Add(this.TextDestinationLocation);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "StockDestinationRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StockDestinationRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TextDestinationLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridDestination)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label DestinationLocationTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextDestinationLocation;
        private System.Windows.Forms.DataGridView DatagridDestination;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonEdit;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonSave;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDataList;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDelete;
    }
}