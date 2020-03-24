namespace DimStock.UserForms
{
    partial class CategoryListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryListingForm));
            this.DatagridCategory = new System.Windows.Forms.DataGridView();
            this.LabelSearchDescription = new System.Windows.Forms.Label();
            this.ButtonShow_CategoryAddForm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonClear_ResetView = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonUpdate_DataGridCategory = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextSearchDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridCategory
            // 
            this.DatagridCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatagridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridCategory.Location = new System.Drawing.Point(12, 133);
            this.DatagridCategory.Name = "DatagridCategory";
            this.DatagridCategory.Size = new System.Drawing.Size(904, 390);
            this.DatagridCategory.TabIndex = 0;
            this.DatagridCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridCategory_CellClick);
            this.DatagridCategory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridCategory_CellMouseEnter);
            this.DatagridCategory.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DatagridCategory_RowPrePaint);
            // 
            // LabelSearchDescription
            // 
            this.LabelSearchDescription.AutoSize = true;
            this.LabelSearchDescription.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.LabelSearchDescription.Location = new System.Drawing.Point(9, 81);
            this.LabelSearchDescription.Name = "LabelSearchDescription";
            this.LabelSearchDescription.Size = new System.Drawing.Size(69, 18);
            this.LabelSearchDescription.TabIndex = 183;
            this.LabelSearchDescription.Text = "Descrição:";
            // 
            // ButtonShow_CategoryAddForm
            // 
            this.ButtonShow_CategoryAddForm.ActiveBorderThickness = 1;
            this.ButtonShow_CategoryAddForm.ActiveCornerRadius = 10;
            this.ButtonShow_CategoryAddForm.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonShow_CategoryAddForm.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonShow_CategoryAddForm.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonShow_CategoryAddForm.BackColor = System.Drawing.Color.White;
            this.ButtonShow_CategoryAddForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonShow_CategoryAddForm.BackgroundImage")));
            this.ButtonShow_CategoryAddForm.ButtonText = "Novo";
            this.ButtonShow_CategoryAddForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonShow_CategoryAddForm.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonShow_CategoryAddForm.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonShow_CategoryAddForm.IdleBorderThickness = 1;
            this.ButtonShow_CategoryAddForm.IdleCornerRadius = 10;
            this.ButtonShow_CategoryAddForm.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonShow_CategoryAddForm.IdleForecolor = System.Drawing.Color.White;
            this.ButtonShow_CategoryAddForm.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonShow_CategoryAddForm.Location = new System.Drawing.Point(14, 14);
            this.ButtonShow_CategoryAddForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonShow_CategoryAddForm.Name = "ButtonShow_CategoryAddForm";
            this.ButtonShow_CategoryAddForm.Size = new System.Drawing.Size(97, 43);
            this.ButtonShow_CategoryAddForm.TabIndex = 232;
            this.ButtonShow_CategoryAddForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonShow_CategoryAddForm.Click += new System.EventHandler(this.ButtonShow_CategoryAddForm_Click);
            // 
            // ButtonClear_ResetView
            // 
            this.ButtonClear_ResetView.ActiveBorderThickness = 1;
            this.ButtonClear_ResetView.ActiveCornerRadius = 10;
            this.ButtonClear_ResetView.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonClear_ResetView.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonClear_ResetView.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonClear_ResetView.BackColor = System.Drawing.Color.White;
            this.ButtonClear_ResetView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonClear_ResetView.BackgroundImage")));
            this.ButtonClear_ResetView.ButtonText = "Limpar";
            this.ButtonClear_ResetView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClear_ResetView.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonClear_ResetView.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonClear_ResetView.IdleBorderThickness = 1;
            this.ButtonClear_ResetView.IdleCornerRadius = 10;
            this.ButtonClear_ResetView.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonClear_ResetView.IdleForecolor = System.Drawing.Color.White;
            this.ButtonClear_ResetView.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonClear_ResetView.Location = new System.Drawing.Point(218, 14);
            this.ButtonClear_ResetView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonClear_ResetView.Name = "ButtonClear_ResetView";
            this.ButtonClear_ResetView.Size = new System.Drawing.Size(97, 43);
            this.ButtonClear_ResetView.TabIndex = 231;
            this.ButtonClear_ResetView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonClear_ResetView.Click += new System.EventHandler(this.ButtonClear_ResetView_Click);
            // 
            // ButtonUpdate_DataGridCategory
            // 
            this.ButtonUpdate_DataGridCategory.ActiveBorderThickness = 1;
            this.ButtonUpdate_DataGridCategory.ActiveCornerRadius = 10;
            this.ButtonUpdate_DataGridCategory.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonUpdate_DataGridCategory.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonUpdate_DataGridCategory.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonUpdate_DataGridCategory.BackColor = System.Drawing.Color.White;
            this.ButtonUpdate_DataGridCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate_DataGridCategory.BackgroundImage")));
            this.ButtonUpdate_DataGridCategory.ButtonText = "Listar";
            this.ButtonUpdate_DataGridCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate_DataGridCategory.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonUpdate_DataGridCategory.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonUpdate_DataGridCategory.IdleBorderThickness = 1;
            this.ButtonUpdate_DataGridCategory.IdleCornerRadius = 10;
            this.ButtonUpdate_DataGridCategory.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonUpdate_DataGridCategory.IdleForecolor = System.Drawing.Color.White;
            this.ButtonUpdate_DataGridCategory.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonUpdate_DataGridCategory.Location = new System.Drawing.Point(116, 14);
            this.ButtonUpdate_DataGridCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonUpdate_DataGridCategory.Name = "ButtonUpdate_DataGridCategory";
            this.ButtonUpdate_DataGridCategory.Size = new System.Drawing.Size(97, 43);
            this.ButtonUpdate_DataGridCategory.TabIndex = 230;
            this.ButtonUpdate_DataGridCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonUpdate_DataGridCategory.Click += new System.EventHandler(this.ButtonUpdate_DataGridCategory_Click);
            // 
            // TextSearchDescription
            // 
            this.TextSearchDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TextSearchDescription.BackColor = System.Drawing.Color.White;
            this.TextSearchDescription.BeforeTouchSize = new System.Drawing.Size(401, 26);
            this.TextSearchDescription.BorderColor = System.Drawing.Color.DarkGray;
            this.TextSearchDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchDescription.CanOverrideStyle = true;
            this.TextSearchDescription.CausesValidation = false;
            this.TextSearchDescription.CornerRadius = 1;
            this.TextSearchDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchDescription.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextSearchDescription.Location = new System.Drawing.Point(12, 101);
            this.TextSearchDescription.MaxLength = 2000;
            this.TextSearchDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchDescription.Name = "TextSearchDescription";
            this.TextSearchDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextSearchDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextSearchDescription.Size = new System.Drawing.Size(401, 26);
            this.TextSearchDescription.TabIndex = 233;
            this.TextSearchDescription.Tag = "";
            this.TextSearchDescription.ThemeName = "Default";
            this.TextSearchDescription.ThemesEnabled = false;
            this.TextSearchDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearchDescription_KeyPress);
            // 
            // CategoryListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.TextSearchDescription);
            this.Controls.Add(this.ButtonShow_CategoryAddForm);
            this.Controls.Add(this.ButtonClear_ResetView);
            this.Controls.Add(this.ButtonUpdate_DataGridCategory);
            this.Controls.Add(this.LabelSearchDescription);
            this.Controls.Add(this.DatagridCategory);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "CategoryListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CategoryListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatagridCategory;
        private System.Windows.Forms.Label LabelSearchDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonShow_CategoryAddForm;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonClear_ResetView;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonUpdate_DataGridCategory;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchDescription;
    }
}