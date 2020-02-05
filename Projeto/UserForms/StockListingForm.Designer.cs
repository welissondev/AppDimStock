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
            this.StockDataList = new System.Windows.Forms.DataGridView();
            this.TitleRecordsByPage = new System.Windows.Forms.Label();
            this.SearchTitleByDescription = new System.Windows.Forms.Label();
            this.SearchTitleByReference = new System.Windows.Forms.Label();
            this.SearchTitleBySize = new System.Windows.Forms.Label();
            this.SearchTitleByCode = new System.Windows.Forms.Label();
            this.SearchByReference = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchBySize = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchByCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchByDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.GifLoading = new System.Windows.Forms.PictureBox();
            this.Summaries = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ResumeListTitle = new System.Windows.Forms.Label();
            this.ClearFields = new System.Windows.Forms.LinkLabel();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            this.RecordsByPage = new Syncfusion.WinForms.ListView.SfComboBox();
            this.DataList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GenerateReport = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.StockDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Summaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).BeginInit();
            this.SuspendLayout();
            // 
            // StockDataList
            // 
            this.StockDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDataList.Location = new System.Drawing.Point(30, 160);
            this.StockDataList.Name = "StockDataList";
            this.StockDataList.Size = new System.Drawing.Size(873, 363);
            this.StockDataList.TabIndex = 70;
            this.StockDataList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StockDataList_CellFormatting);
            this.StockDataList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockDataList_CellMouseEnter);
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
            this.SearchTitleByDescription.Location = new System.Drawing.Point(487, 108);
            this.SearchTitleByDescription.Name = "SearchTitleByDescription";
            this.SearchTitleByDescription.Size = new System.Drawing.Size(141, 18);
            this.SearchTitleByDescription.TabIndex = 105;
            this.SearchTitleByDescription.Text = "Descrição do produto:";
            // 
            // SearchTitleByReference
            // 
            this.SearchTitleByReference.AutoSize = true;
            this.SearchTitleByReference.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.SearchTitleByReference.Location = new System.Drawing.Point(380, 108);
            this.SearchTitleByReference.Name = "SearchTitleByReference";
            this.SearchTitleByReference.Size = new System.Drawing.Size(74, 18);
            this.SearchTitleByReference.TabIndex = 104;
            this.SearchTitleByReference.Text = "Referência:";
            // 
            // SearchTitleBySize
            // 
            this.SearchTitleBySize.AutoSize = true;
            this.SearchTitleBySize.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.SearchTitleBySize.Location = new System.Drawing.Point(274, 108);
            this.SearchTitleBySize.Name = "SearchTitleBySize";
            this.SearchTitleBySize.Size = new System.Drawing.Size(68, 18);
            this.SearchTitleBySize.TabIndex = 103;
            this.SearchTitleBySize.Text = "Tamanho:";
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
            // SearchByReference
            // 
            this.SearchByReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByReference.BeforeTouchSize = new System.Drawing.Size(208, 27);
            this.SearchByReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchByReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByReference.CanOverrideStyle = true;
            this.SearchByReference.CausesValidation = false;
            this.SearchByReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByReference.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByReference.Location = new System.Drawing.Point(381, 127);
            this.SearchByReference.MaxLength = 50;
            this.SearchByReference.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchByReference.Multiline = true;
            this.SearchByReference.Name = "SearchByReference";
            this.SearchByReference.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchByReference.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchByReference.Size = new System.Drawing.Size(105, 27);
            this.SearchByReference.TabIndex = 98;
            this.SearchByReference.Tag = "";
            this.SearchByReference.ThemeName = "Default";
            this.SearchByReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchFields_KeyPress);
            // 
            // SearchBySize
            // 
            this.SearchBySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchBySize.BeforeTouchSize = new System.Drawing.Size(208, 27);
            this.SearchBySize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchBySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBySize.CanOverrideStyle = true;
            this.SearchBySize.CausesValidation = false;
            this.SearchBySize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchBySize.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchBySize.Location = new System.Drawing.Point(277, 127);
            this.SearchBySize.MaxLength = 50;
            this.SearchBySize.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchBySize.Multiline = true;
            this.SearchBySize.Name = "SearchBySize";
            this.SearchBySize.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchBySize.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchBySize.Size = new System.Drawing.Size(100, 27);
            this.SearchBySize.TabIndex = 97;
            this.SearchBySize.Tag = "";
            this.SearchBySize.ThemeName = "Default";
            this.SearchBySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchFields_KeyPress);
            // 
            // SearchByCode
            // 
            this.SearchByCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByCode.BeforeTouchSize = new System.Drawing.Size(208, 27);
            this.SearchByCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByCode.CanOverrideStyle = true;
            this.SearchByCode.CausesValidation = false;
            this.SearchByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByCode.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByCode.Location = new System.Drawing.Point(164, 127);
            this.SearchByCode.MaxLength = 50;
            this.SearchByCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchByCode.Multiline = true;
            this.SearchByCode.Name = "SearchByCode";
            this.SearchByCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchByCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchByCode.Size = new System.Drawing.Size(109, 27);
            this.SearchByCode.TabIndex = 96;
            this.SearchByCode.Tag = "";
            this.SearchByCode.ThemeName = "Default";
            this.SearchByCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchFields_KeyPress);
            // 
            // SearchByDescription
            // 
            this.SearchByDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByDescription.BeforeTouchSize = new System.Drawing.Size(208, 27);
            this.SearchByDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByDescription.CanOverrideStyle = true;
            this.SearchByDescription.CausesValidation = false;
            this.SearchByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByDescription.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByDescription.Location = new System.Drawing.Point(490, 127);
            this.SearchByDescription.MaxLength = 50;
            this.SearchByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchByDescription.Multiline = true;
            this.SearchByDescription.Name = "SearchByDescription";
            this.SearchByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchByDescription.Size = new System.Drawing.Size(208, 27);
            this.SearchByDescription.TabIndex = 100;
            this.SearchByDescription.Tag = "";
            this.SearchByDescription.ThemeName = "Default";
            this.SearchByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchFields_KeyPress);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 500;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GifLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.GifLoading.Location = new System.Drawing.Point(399, 256);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(135, 135);
            this.GifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GifLoading.TabIndex = 142;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
            // 
            // Summaries
            // 
            this.Summaries.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.Summaries.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summaries.Location = new System.Drawing.Point(31, 127);
            this.Summaries.Name = "Summaries";
            this.Summaries.Size = new System.Drawing.Size(129, 27);
            this.Summaries.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Summaries.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.Summaries.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summaries.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summaries.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Summaries.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summaries.TabIndex = 143;
            this.Summaries.ToolTipOption.ShadowVisible = false;
            this.Summaries.SelectedIndexChanged += new System.EventHandler(this.Summaries_SelectedIndexChanged);
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
            // ClearFields
            // 
            this.ClearFields.AutoSize = true;
            this.ClearFields.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearFields.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ClearFields.Location = new System.Drawing.Point(847, 130);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(49, 18);
            this.ClearFields.TabIndex = 171;
            this.ClearFields.TabStop = true;
            this.ClearFields.Text = "Limpar";
            this.ClearFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearFields_LinkClicked);
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
            // RecordsByPage
            // 
            this.RecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.RecordsByPage.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Location = new System.Drawing.Point(702, 127);
            this.RecordsByPage.Name = "RecordsByPage";
            this.RecordsByPage.Size = new System.Drawing.Size(141, 27);
            this.RecordsByPage.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordsByPage.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.RecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.TabIndex = 178;
            this.RecordsByPage.ToolTipOption.ShadowVisible = false;
            this.RecordsByPage.SelectedIndexChanged += new System.EventHandler(this.RecordsByPage_SelectedIndexChanged);
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
            this.DataList.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.DataList.IdleBorderThickness = 1;
            this.DataList.IdleCornerRadius = 10;
            this.DataList.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.DataList.IdleForecolor = System.Drawing.Color.White;
            this.DataList.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.DataList.Location = new System.Drawing.Point(30, 30);
            this.DataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(97, 43);
            this.DataList.TabIndex = 215;
            this.DataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataList.Click += new System.EventHandler(this.DataList_Click);
            // 
            // GenerateReport
            // 
            this.GenerateReport.ActiveBorderThickness = 1;
            this.GenerateReport.ActiveCornerRadius = 10;
            this.GenerateReport.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.GenerateReport.ActiveForecolor = System.Drawing.Color.White;
            this.GenerateReport.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.GenerateReport.BackColor = System.Drawing.Color.White;
            this.GenerateReport.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GenerateReport.BackgroundImage")));
            this.GenerateReport.ButtonText = "Relatório";
            this.GenerateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateReport.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReport.ForeColor = System.Drawing.Color.SeaGreen;
            this.GenerateReport.IdleBorderThickness = 1;
            this.GenerateReport.IdleCornerRadius = 10;
            this.GenerateReport.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.IdleForecolor = System.Drawing.Color.White;
            this.GenerateReport.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Location = new System.Drawing.Point(130, 30);
            this.GenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(97, 43);
            this.GenerateReport.TabIndex = 216;
            this.GenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click_1);
            // 
            // StockListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.GenerateReport);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.RecordsByPage);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.GifLoading);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.Summaries);
            this.Controls.Add(this.ResumeListTitle);
            this.Controls.Add(this.TitleRecordsByPage);
            this.Controls.Add(this.SearchTitleByDescription);
            this.Controls.Add(this.SearchTitleByReference);
            this.Controls.Add(this.SearchTitleBySize);
            this.Controls.Add(this.SearchTitleByCode);
            this.Controls.Add(this.SearchByReference);
            this.Controls.Add(this.SearchBySize);
            this.Controls.Add(this.SearchByCode);
            this.Controls.Add(this.SearchByDescription);
            this.Controls.Add(this.StockDataList);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "StockListingForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Load += new System.EventHandler(this.StockListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Summaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockDataList;
        private System.Windows.Forms.Label TitleRecordsByPage;
        private System.Windows.Forms.Label SearchTitleByDescription;
        private System.Windows.Forms.Label SearchTitleByReference;
        private System.Windows.Forms.Label SearchTitleBySize;
        private System.Windows.Forms.Label SearchTitleByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchByReference;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchBySize;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchByCode;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchByDescription;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.PictureBox GifLoading;
        private Syncfusion.WinForms.ListView.SfComboBox Summaries;
        private System.Windows.Forms.Label ResumeListTitle;
        private System.Windows.Forms.LinkLabel ClearFields;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripButton NextPage;
        private Syncfusion.WinForms.ListView.SfComboBox RecordsByPage;
        private Bunifu.Framework.UI.BunifuThinButton2 DataList;
        private Bunifu.Framework.UI.BunifuThinButton2 GenerateReport;
    }
}