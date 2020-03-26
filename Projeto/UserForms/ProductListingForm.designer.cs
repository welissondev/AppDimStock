namespace DimStock.UserForms
{
    partial class ProductListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListingForm));
            this.TextSearchDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.DatagridProduct = new System.Windows.Forms.DataGridView();
            this.LabelSearchDescription = new System.Windows.Forms.Label();
            this.LabelSearchInternalCode = new System.Windows.Forms.Label();
            this.TextSearchInternalCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ButtonShow_ProductAddForm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonUpdate_DatagridProduct = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonGenerate_Report = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchInternalCode)).BeginInit();
            this.SuspendLayout();
            // 
            // TextSearchDescription
            // 
            this.TextSearchDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextSearchDescription.BeforeTouchSize = new System.Drawing.Size(140, 27);
            this.TextSearchDescription.BorderColor = System.Drawing.Color.DarkGray;
            this.TextSearchDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchDescription.CanOverrideStyle = true;
            this.TextSearchDescription.CausesValidation = false;
            this.TextSearchDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchDescription.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSearchDescription.Location = new System.Drawing.Point(163, 108);
            this.TextSearchDescription.MaxLength = 50;
            this.TextSearchDescription.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TextSearchDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchDescription.Multiline = true;
            this.TextSearchDescription.Name = "TextSearchDescription";
            this.TextSearchDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextSearchDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextSearchDescription.Size = new System.Drawing.Size(362, 27);
            this.TextSearchDescription.TabIndex = 4;
            this.TextSearchDescription.Tag = "";
            this.TextSearchDescription.ThemeName = "Default";
            this.TextSearchDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearchDescription_KeyPress);
            // 
            // DatagridProduct
            // 
            this.DatagridProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatagridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridProduct.Location = new System.Drawing.Point(16, 150);
            this.DatagridProduct.Name = "DatagridProduct";
            this.DatagridProduct.Size = new System.Drawing.Size(900, 389);
            this.DatagridProduct.TabIndex = 69;
            this.DatagridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridProduct_CellClick);
            this.DatagridProduct.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DatagridProduct_CellMouseDoubleClick);
            this.DatagridProduct.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridProduct_CellMouseEnter);
            this.DatagridProduct.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DatagridProduct_RowPrePaint);
            // 
            // LabelSearchDescription
            // 
            this.LabelSearchDescription.AutoSize = true;
            this.LabelSearchDescription.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.LabelSearchDescription.Location = new System.Drawing.Point(160, 90);
            this.LabelSearchDescription.Name = "LabelSearchDescription";
            this.LabelSearchDescription.Size = new System.Drawing.Size(69, 18);
            this.LabelSearchDescription.TabIndex = 90;
            this.LabelSearchDescription.Text = "Descrição:";
            // 
            // LabelSearchInternalCode
            // 
            this.LabelSearchInternalCode.AutoSize = true;
            this.LabelSearchInternalCode.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.LabelSearchInternalCode.Location = new System.Drawing.Point(14, 90);
            this.LabelSearchInternalCode.Name = "LabelSearchInternalCode";
            this.LabelSearchInternalCode.Size = new System.Drawing.Size(54, 18);
            this.LabelSearchInternalCode.TabIndex = 87;
            this.LabelSearchInternalCode.Text = "Código:";
            // 
            // TextSearchInternalCode
            // 
            this.TextSearchInternalCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextSearchInternalCode.BeforeTouchSize = new System.Drawing.Size(140, 27);
            this.TextSearchInternalCode.BorderColor = System.Drawing.Color.DarkGray;
            this.TextSearchInternalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchInternalCode.CanOverrideStyle = true;
            this.TextSearchInternalCode.CausesValidation = false;
            this.TextSearchInternalCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchInternalCode.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchInternalCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSearchInternalCode.Location = new System.Drawing.Point(17, 108);
            this.TextSearchInternalCode.MaxLength = 50;
            this.TextSearchInternalCode.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TextSearchInternalCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchInternalCode.Multiline = true;
            this.TextSearchInternalCode.Name = "TextSearchInternalCode";
            this.TextSearchInternalCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextSearchInternalCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextSearchInternalCode.Size = new System.Drawing.Size(140, 27);
            this.TextSearchInternalCode.TabIndex = 0;
            this.TextSearchInternalCode.Tag = "";
            this.TextSearchInternalCode.ThemeName = "Default";
            this.TextSearchInternalCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearchInternalCode_KeyPress);
            // 
            // ButtonShow_ProductAddForm
            // 
            this.ButtonShow_ProductAddForm.ActiveBorderThickness = 1;
            this.ButtonShow_ProductAddForm.ActiveCornerRadius = 10;
            this.ButtonShow_ProductAddForm.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonShow_ProductAddForm.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonShow_ProductAddForm.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonShow_ProductAddForm.BackColor = System.Drawing.Color.White;
            this.ButtonShow_ProductAddForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonShow_ProductAddForm.BackgroundImage")));
            this.ButtonShow_ProductAddForm.ButtonText = "Novo";
            this.ButtonShow_ProductAddForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShow_ProductAddForm.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShow_ProductAddForm.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonShow_ProductAddForm.IdleBorderThickness = 1;
            this.ButtonShow_ProductAddForm.IdleCornerRadius = 10;
            this.ButtonShow_ProductAddForm.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonShow_ProductAddForm.IdleForecolor = System.Drawing.Color.White;
            this.ButtonShow_ProductAddForm.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonShow_ProductAddForm.Location = new System.Drawing.Point(13, 22);
            this.ButtonShow_ProductAddForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonShow_ProductAddForm.Name = "ButtonShow_ProductAddForm";
            this.ButtonShow_ProductAddForm.Size = new System.Drawing.Size(97, 43);
            this.ButtonShow_ProductAddForm.TabIndex = 209;
            this.ButtonShow_ProductAddForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonShow_ProductAddForm.Click += new System.EventHandler(this.ButtonShow_ProductAddForm_Click);
            // 
            // ButtonUpdate_DatagridProduct
            // 
            this.ButtonUpdate_DatagridProduct.ActiveBorderThickness = 1;
            this.ButtonUpdate_DatagridProduct.ActiveCornerRadius = 10;
            this.ButtonUpdate_DatagridProduct.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonUpdate_DatagridProduct.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonUpdate_DatagridProduct.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonUpdate_DatagridProduct.BackColor = System.Drawing.Color.White;
            this.ButtonUpdate_DatagridProduct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate_DatagridProduct.BackgroundImage")));
            this.ButtonUpdate_DatagridProduct.ButtonText = "Listar";
            this.ButtonUpdate_DatagridProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate_DatagridProduct.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonUpdate_DatagridProduct.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonUpdate_DatagridProduct.IdleBorderThickness = 1;
            this.ButtonUpdate_DatagridProduct.IdleCornerRadius = 10;
            this.ButtonUpdate_DatagridProduct.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonUpdate_DatagridProduct.IdleForecolor = System.Drawing.Color.White;
            this.ButtonUpdate_DatagridProduct.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonUpdate_DatagridProduct.Location = new System.Drawing.Point(112, 22);
            this.ButtonUpdate_DatagridProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonUpdate_DatagridProduct.Name = "ButtonUpdate_DatagridProduct";
            this.ButtonUpdate_DatagridProduct.Size = new System.Drawing.Size(97, 43);
            this.ButtonUpdate_DatagridProduct.TabIndex = 210;
            this.ButtonUpdate_DatagridProduct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonUpdate_DatagridProduct.Click += new System.EventHandler(this.ButtonUpdate_DatagridProduct_Click);
            // 
            // ButtonGenerate_Report
            // 
            this.ButtonGenerate_Report.ActiveBorderThickness = 1;
            this.ButtonGenerate_Report.ActiveCornerRadius = 10;
            this.ButtonGenerate_Report.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonGenerate_Report.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonGenerate_Report.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonGenerate_Report.BackColor = System.Drawing.Color.White;
            this.ButtonGenerate_Report.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGenerate_Report.BackgroundImage")));
            this.ButtonGenerate_Report.ButtonText = "Relatório";
            this.ButtonGenerate_Report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGenerate_Report.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerate_Report.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonGenerate_Report.IdleBorderThickness = 1;
            this.ButtonGenerate_Report.IdleCornerRadius = 10;
            this.ButtonGenerate_Report.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGenerate_Report.IdleForecolor = System.Drawing.Color.White;
            this.ButtonGenerate_Report.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGenerate_Report.Location = new System.Drawing.Point(211, 22);
            this.ButtonGenerate_Report.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonGenerate_Report.Name = "ButtonGenerate_Report";
            this.ButtonGenerate_Report.Size = new System.Drawing.Size(97, 43);
            this.ButtonGenerate_Report.TabIndex = 211;
            this.ButtonGenerate_Report.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonGenerate_Report.Click += new System.EventHandler(this.ButtonGenerate_Report_Click);
            // 
            // ProductListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.ButtonGenerate_Report);
            this.Controls.Add(this.ButtonUpdate_DatagridProduct);
            this.Controls.Add(this.ButtonShow_ProductAddForm);
            this.Controls.Add(this.TextSearchDescription);
            this.Controls.Add(this.DatagridProduct);
            this.Controls.Add(this.TextSearchInternalCode);
            this.Controls.Add(this.LabelSearchInternalCode);
            this.Controls.Add(this.LabelSearchDescription);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "ProductListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProductListingForm_Load);
            this.Resize += new System.EventHandler(this.ProductListingForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchInternalCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchDescription;
        private System.Windows.Forms.DataGridView DatagridProduct;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchInternalCode;
        private System.Windows.Forms.Label LabelSearchDescription;
        private System.Windows.Forms.Label LabelSearchInternalCode;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonShow_ProductAddForm;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonUpdate_DatagridProduct;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonGenerate_Report;
    }
}