namespace DimStock.UserForms
{
    partial class StockListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockListingForm));
            this.DatagridStock = new System.Windows.Forms.DataGridView();
            this.TitleRecordsByPage = new System.Windows.Forms.Label();
            this.SearchTitleByDescription = new System.Windows.Forms.Label();
            this.SearchTitleByCode = new System.Windows.Forms.Label();
            this.TextSearchByCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TextSearchByDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.PictureLoading = new System.Windows.Forms.PictureBox();
            this.ComBoxSummaries = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ResumeListTitle = new System.Windows.Forms.Label();
            this.ButtonClearFields = new System.Windows.Forms.LinkLabel();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxRecordsByPage = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ButtonDataList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonGenerateReport = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBoxSummaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRecordsByPage)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridStock
            // 
            this.DatagridStock.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatagridStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridStock.Location = new System.Drawing.Point(30, 160);
            this.DatagridStock.Name = "DatagridStock";
            this.DatagridStock.Size = new System.Drawing.Size(873, 363);
            this.DatagridStock.TabIndex = 70;
            this.DatagridStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DatagridStock_CellFormatting);
            this.DatagridStock.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridStock_CellMouseEnter);
            // 
            // TitleRecordsByPage
            // 
            this.TitleRecordsByPage.AutoSize = true;
            this.TitleRecordsByPage.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.TitleRecordsByPage.Location = new System.Drawing.Point(699, 108);
            this.TitleRecordsByPage.Name = "TitleRecordsByPage";
            this.TitleRecordsByPage.Size = new System.Drawing.Size(134, 18);
            this.TitleRecordsByPage.TabIndex = 106;
            this.TitleRecordsByPage.Text = "Registros por página:";
            // 
            // SearchTitleByDescription
            // 
            this.SearchTitleByDescription.AutoSize = true;
            this.SearchTitleByDescription.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.SearchTitleByDescription.Location = new System.Drawing.Point(291, 108);
            this.SearchTitleByDescription.Name = "SearchTitleByDescription";
            this.SearchTitleByDescription.Size = new System.Drawing.Size(141, 18);
            this.SearchTitleByDescription.TabIndex = 105;
            this.SearchTitleByDescription.Text = "Descrição do produto:";
            // 
            // SearchTitleByCode
            // 
            this.SearchTitleByCode.AutoSize = true;
            this.SearchTitleByCode.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.SearchTitleByCode.Location = new System.Drawing.Point(161, 108);
            this.SearchTitleByCode.Name = "SearchTitleByCode";
            this.SearchTitleByCode.Size = new System.Drawing.Size(107, 18);
            this.SearchTitleByCode.TabIndex = 102;
            this.SearchTitleByCode.Text = "Código Produto:";
            // 
            // TextSearchByCode
            // 
            this.TextSearchByCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextSearchByCode.BeforeTouchSize = new System.Drawing.Size(404, 27);
            this.TextSearchByCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextSearchByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchByCode.CanOverrideStyle = true;
            this.TextSearchByCode.CausesValidation = false;
            this.TextSearchByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchByCode.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSearchByCode.Location = new System.Drawing.Point(164, 127);
            this.TextSearchByCode.MaxLength = 50;
            this.TextSearchByCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchByCode.Multiline = true;
            this.TextSearchByCode.Name = "TextSearchByCode";
            this.TextSearchByCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextSearchByCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextSearchByCode.Size = new System.Drawing.Size(124, 27);
            this.TextSearchByCode.TabIndex = 96;
            this.TextSearchByCode.Tag = "";
            this.TextSearchByCode.ThemeName = "Default";
            this.TextSearchByCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearchFields_KeyPress);
            // 
            // TextSearchByDescription
            // 
            this.TextSearchByDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextSearchByDescription.BeforeTouchSize = new System.Drawing.Size(404, 27);
            this.TextSearchByDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextSearchByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchByDescription.CanOverrideStyle = true;
            this.TextSearchByDescription.CausesValidation = false;
            this.TextSearchByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchByDescription.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSearchByDescription.Location = new System.Drawing.Point(294, 127);
            this.TextSearchByDescription.MaxLength = 50;
            this.TextSearchByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchByDescription.Multiline = true;
            this.TextSearchByDescription.Name = "TextSearchByDescription";
            this.TextSearchByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextSearchByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextSearchByDescription.Size = new System.Drawing.Size(404, 27);
            this.TextSearchByDescription.TabIndex = 100;
            this.TextSearchByDescription.Tag = "";
            this.TextSearchByDescription.ThemeName = "Default";
            this.TextSearchByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearchFields_KeyPress);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 500;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // PictureLoading
            // 
            this.PictureLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.PictureLoading.Location = new System.Drawing.Point(399, 256);
            this.PictureLoading.Name = "PictureLoading";
            this.PictureLoading.Size = new System.Drawing.Size(135, 135);
            this.PictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLoading.TabIndex = 142;
            this.PictureLoading.TabStop = false;
            this.PictureLoading.Visible = false;
            // 
            // ComBoxSummaries
            // 
            this.ComBoxSummaries.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.ComBoxSummaries.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxSummaries.Location = new System.Drawing.Point(31, 127);
            this.ComBoxSummaries.Name = "ComBoxSummaries";
            this.ComBoxSummaries.Size = new System.Drawing.Size(129, 27);
            this.ComBoxSummaries.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComBoxSummaries.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.ComBoxSummaries.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxSummaries.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxSummaries.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComBoxSummaries.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComBoxSummaries.TabIndex = 143;
            this.ComBoxSummaries.ToolTipOption.ShadowVisible = false;
            this.ComBoxSummaries.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSummaries_SelectedIndexChanged);
            // 
            // ResumeListTitle
            // 
            this.ResumeListTitle.AutoSize = true;
            this.ResumeListTitle.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.ResumeListTitle.Location = new System.Drawing.Point(28, 108);
            this.ResumeListTitle.Name = "ResumeListTitle";
            this.ResumeListTitle.Size = new System.Drawing.Size(61, 18);
            this.ResumeListTitle.TabIndex = 144;
            this.ResumeListTitle.Text = "Resumo:";
            // 
            // ButtonClearFields
            // 
            this.ButtonClearFields.AutoSize = true;
            this.ButtonClearFields.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearFields.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonClearFields.Location = new System.Drawing.Point(847, 130);
            this.ButtonClearFields.Name = "ButtonClearFields";
            this.ButtonClearFields.Size = new System.Drawing.Size(49, 18);
            this.ButtonClearFields.TabIndex = 171;
            this.ButtonClearFields.TabStop = true;
            this.ButtonClearFields.Text = "Limpar";
            this.ButtonClearFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonClearFields_LinkClicked);
            // 
            // BindingPagination
            // 
            this.BindingPagination.AddNewItem = null;
            this.BindingPagination.CountItem = null;
            this.BindingPagination.DeleteItem = null;
            this.BindingPagination.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BindingPagination.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BindingPagination.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackPage,
            this.toolStripSeparator1,
            this.LblPaginationState,
            this.toolStripSeparator2,
            this.NextPage,
            this.toolStripSeparator3,
            this.LblRecordsState});
            this.BindingPagination.Location = new System.Drawing.Point(0, 526);
            this.BindingPagination.MoveFirstItem = null;
            this.BindingPagination.MoveLastItem = null;
            this.BindingPagination.MoveNextItem = null;
            this.BindingPagination.MovePreviousItem = null;
            this.BindingPagination.Name = "BindingPagination";
            this.BindingPagination.PositionItem = null;
            this.BindingPagination.Size = new System.Drawing.Size(928, 25);
            this.BindingPagination.TabIndex = 177;
            this.BindingPagination.Text = "bindingNavigator1";
            // 
            // BackPage
            // 
            this.BackPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BackPage.Image = ((System.Drawing.Image)(resources.GetObject("BackPage.Image")));
            this.BackPage.Name = "BackPage";
            this.BackPage.RightToLeftAutoMirrorImage = true;
            this.BackPage.Size = new System.Drawing.Size(23, 22);
            this.BackPage.Click += new System.EventHandler(this.BackPage_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // LblPaginationState
            // 
            this.LblPaginationState.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaginationState.Name = "LblPaginationState";
            this.LblPaginationState.Size = new System.Drawing.Size(97, 22);
            this.LblPaginationState.Text = "Página 0 de 0";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // NextPage
            // 
            this.NextPage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextPage.Image = ((System.Drawing.Image)(resources.GetObject("NextPage.Image")));
            this.NextPage.Name = "NextPage";
            this.NextPage.RightToLeftAutoMirrorImage = true;
            this.NextPage.Size = new System.Drawing.Size(23, 22);
            this.NextPage.Click += new System.EventHandler(this.NextPage_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // LblRecordsState
            // 
            this.LblRecordsState.Name = "LblRecordsState";
            this.LblRecordsState.Size = new System.Drawing.Size(110, 22);
            this.LblRecordsState.Text = "0 de 0 registros";
            // 
            // ComboBoxRecordsByPage
            // 
            this.ComboBoxRecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.ComboBoxRecordsByPage.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Location = new System.Drawing.Point(702, 127);
            this.ComboBoxRecordsByPage.Name = "ComboBoxRecordsByPage";
            this.ComboBoxRecordsByPage.Size = new System.Drawing.Size(141, 27);
            this.ComboBoxRecordsByPage.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComboBoxRecordsByPage.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.ComboBoxRecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxRecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.TabIndex = 178;
            this.ComboBoxRecordsByPage.ToolTipOption.ShadowVisible = false;
            this.ComboBoxRecordsByPage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRecordsByPage_SelectedIndexChanged);
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
            this.ButtonDataList.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonDataList.IdleBorderThickness = 1;
            this.ButtonDataList.IdleCornerRadius = 10;
            this.ButtonDataList.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDataList.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.Location = new System.Drawing.Point(30, 30);
            this.ButtonDataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDataList.Name = "ButtonDataList";
            this.ButtonDataList.Size = new System.Drawing.Size(97, 43);
            this.ButtonDataList.TabIndex = 215;
            this.ButtonDataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDataList.Click += new System.EventHandler(this.ButtonDataList_Click);
            // 
            // ButtonGenerateReport
            // 
            this.ButtonGenerateReport.ActiveBorderThickness = 1;
            this.ButtonGenerateReport.ActiveCornerRadius = 10;
            this.ButtonGenerateReport.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonGenerateReport.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonGenerateReport.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonGenerateReport.BackColor = System.Drawing.Color.White;
            this.ButtonGenerateReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGenerateReport.BackgroundImage")));
            this.ButtonGenerateReport.ButtonText = "Relatório";
            this.ButtonGenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGenerateReport.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonGenerateReport.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonGenerateReport.IdleBorderThickness = 1;
            this.ButtonGenerateReport.IdleCornerRadius = 10;
            this.ButtonGenerateReport.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGenerateReport.IdleForecolor = System.Drawing.Color.White;
            this.ButtonGenerateReport.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGenerateReport.Location = new System.Drawing.Point(130, 30);
            this.ButtonGenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonGenerateReport.Name = "ButtonGenerateReport";
            this.ButtonGenerateReport.Size = new System.Drawing.Size(97, 43);
            this.ButtonGenerateReport.TabIndex = 216;
            this.ButtonGenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonGenerateReport.Click += new System.EventHandler(this.ButtonGenerateReport_Click);
            // 
            // StockListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.ButtonGenerateReport);
            this.Controls.Add(this.ButtonDataList);
            this.Controls.Add(this.ComboBoxRecordsByPage);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.PictureLoading);
            this.Controls.Add(this.ButtonClearFields);
            this.Controls.Add(this.ComBoxSummaries);
            this.Controls.Add(this.ResumeListTitle);
            this.Controls.Add(this.TitleRecordsByPage);
            this.Controls.Add(this.SearchTitleByDescription);
            this.Controls.Add(this.SearchTitleByCode);
            this.Controls.Add(this.TextSearchByCode);
            this.Controls.Add(this.TextSearchByDescription);
            this.Controls.Add(this.DatagridStock);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "StockListingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += new System.EventHandler(this.StockListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComBoxSummaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRecordsByPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatagridStock;
        private System.Windows.Forms.Label TitleRecordsByPage;
        private System.Windows.Forms.Label SearchTitleByDescription;
        private System.Windows.Forms.Label SearchTitleByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchByDescription;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.PictureBox PictureLoading;
        private Syncfusion.WinForms.ListView.SfComboBox ComBoxSummaries;
        private System.Windows.Forms.Label ResumeListTitle;
        private System.Windows.Forms.LinkLabel ButtonClearFields;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripButton NextPage;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBoxRecordsByPage;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDataList;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonGenerateReport;
    }
}