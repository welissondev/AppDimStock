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
            this.GenerateReport = new Syncfusion.WinForms.Controls.SfButton();
            this.UpdateDataList = new Syncfusion.WinForms.Controls.SfButton();
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
            this.StockDataList.Size = new System.Drawing.Size(1002, 463);
            this.StockDataList.TabIndex = 70;
            this.StockDataList.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.StockDataList_CellFormatting);
            // 
            // TitleRecordsByPage
            // 
            this.TitleRecordsByPage.AutoSize = true;
            this.TitleRecordsByPage.Location = new System.Drawing.Point(699, 112);
            this.TitleRecordsByPage.Name = "TitleRecordsByPage";
            this.TitleRecordsByPage.Size = new System.Drawing.Size(107, 13);
            this.TitleRecordsByPage.TabIndex = 106;
            this.TitleRecordsByPage.Text = "Registros por página:";
            // 
            // SearchTitleByDescription
            // 
            this.SearchTitleByDescription.AutoSize = true;
            this.SearchTitleByDescription.Location = new System.Drawing.Point(487, 112);
            this.SearchTitleByDescription.Name = "SearchTitleByDescription";
            this.SearchTitleByDescription.Size = new System.Drawing.Size(112, 13);
            this.SearchTitleByDescription.TabIndex = 105;
            this.SearchTitleByDescription.Text = "Descrição do produto:";
            // 
            // SearchTitleByReference
            // 
            this.SearchTitleByReference.AutoSize = true;
            this.SearchTitleByReference.Location = new System.Drawing.Point(380, 112);
            this.SearchTitleByReference.Name = "SearchTitleByReference";
            this.SearchTitleByReference.Size = new System.Drawing.Size(62, 13);
            this.SearchTitleByReference.TabIndex = 104;
            this.SearchTitleByReference.Text = "Referência:";
            // 
            // SearchTitleBySize
            // 
            this.SearchTitleBySize.AutoSize = true;
            this.SearchTitleBySize.Location = new System.Drawing.Point(274, 112);
            this.SearchTitleBySize.Name = "SearchTitleBySize";
            this.SearchTitleBySize.Size = new System.Drawing.Size(55, 13);
            this.SearchTitleBySize.TabIndex = 103;
            this.SearchTitleBySize.Text = "Tamanho:";
            // 
            // SearchTitleByCode
            // 
            this.SearchTitleByCode.AutoSize = true;
            this.SearchTitleByCode.Location = new System.Drawing.Point(161, 112);
            this.SearchTitleByCode.Name = "SearchTitleByCode";
            this.SearchTitleByCode.Size = new System.Drawing.Size(83, 13);
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
            this.SearchByReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.SearchBySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.SearchByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.SearchByDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            // GenerateReport
            // 
            this.GenerateReport.AccessibleName = "Button";
            this.GenerateReport.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReport.ForeColor = System.Drawing.Color.White;
            this.GenerateReport.Location = new System.Drawing.Point(113, 48);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(83, 35);
            this.GenerateReport.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Style.FocusedForeColor = System.Drawing.Color.White;
            this.GenerateReport.Style.ForeColor = System.Drawing.Color.White;
            this.GenerateReport.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Style.HoverForeColor = System.Drawing.Color.Black;
            this.GenerateReport.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Style.PressedForeColor = System.Drawing.Color.White;
            this.GenerateReport.TabIndex = 141;
            this.GenerateReport.Text = "Relatório";
            this.GenerateReport.UseVisualStyleBackColor = false;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // UpdateDataList
            // 
            this.UpdateDataList.AccessibleName = "Button";
            this.UpdateDataList.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataList.ForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Location = new System.Drawing.Point(31, 48);
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
            this.UpdateDataList.TabIndex = 140;
            this.UpdateDataList.Text = "Atualizar";
            this.UpdateDataList.UseVisualStyleBackColor = false;
            this.UpdateDataList.Click += new System.EventHandler(this.UpdateDataList_Click);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GifLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.GifLoading.Location = new System.Drawing.Point(452, 321);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(191, 169);
            this.GifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GifLoading.TabIndex = 142;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
            // 
            // Summaries
            // 
            this.Summaries.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.Summaries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summaries.Location = new System.Drawing.Point(31, 127);
            this.Summaries.Name = "Summaries";
            this.Summaries.Size = new System.Drawing.Size(129, 27);
            this.Summaries.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Summaries.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.Summaries.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summaries.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summaries.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Summaries.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Summaries.TabIndex = 143;
            this.Summaries.ToolTipOption.ShadowVisible = false;
            this.Summaries.SelectedIndexChanged += new System.EventHandler(this.Summaries_SelectedIndexChanged);
            // 
            // ResumeListTitle
            // 
            this.ResumeListTitle.AutoSize = true;
            this.ResumeListTitle.Location = new System.Drawing.Point(28, 112);
            this.ResumeListTitle.Name = "ResumeListTitle";
            this.ResumeListTitle.Size = new System.Drawing.Size(49, 13);
            this.ResumeListTitle.TabIndex = 144;
            this.ResumeListTitle.Text = "Resumo:";
            // 
            // ClearFields
            // 
            this.ClearFields.AutoSize = true;
            this.ClearFields.Location = new System.Drawing.Point(880, 133);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(38, 13);
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
            this.BindingPagination.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackPage,
            this.toolStripSeparator1,
            this.LblPaginationState,
            this.toolStripSeparator2,
            this.NextPage,
            this.toolStripSeparator3,
            this.LblRecordsState});
            this.BindingPagination.Location = new System.Drawing.Point(0, 656);
            this.BindingPagination.MoveFirstItem = null;
            this.BindingPagination.MoveLastItem = null;
            this.BindingPagination.MoveNextItem = null;
            this.BindingPagination.MovePreviousItem = null;
            this.BindingPagination.Name = "BindingPagination";
            this.BindingPagination.PositionItem = null;
            this.BindingPagination.Size = new System.Drawing.Size(1057, 25);
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
            this.LblPaginationState.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPaginationState.Name = "LblPaginationState";
            this.LblPaginationState.Size = new System.Drawing.Size(77, 22);
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
            this.LblRecordsState.Size = new System.Drawing.Size(86, 22);
            this.LblRecordsState.Text = "0 de 0 registros";
            // 
            // RecordsByPage
            // 
            this.RecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.RecordsByPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Location = new System.Drawing.Point(702, 127);
            this.RecordsByPage.Name = "RecordsByPage";
            this.RecordsByPage.Size = new System.Drawing.Size(172, 27);
            this.RecordsByPage.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordsByPage.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.RecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.TabIndex = 178;
            this.RecordsByPage.ToolTipOption.ShadowVisible = false;
            this.RecordsByPage.SelectedIndexChanged += new System.EventHandler(this.RecordsByPage_SelectedIndexChanged);
            // 
            // StockListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 681);
            this.Controls.Add(this.GenerateReport);
            this.Controls.Add(this.UpdateDataList);
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
            this.MinimumSize = new System.Drawing.Size(980, 720);
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
        private Syncfusion.WinForms.Controls.SfButton UpdateDataList;
        private Syncfusion.WinForms.Controls.SfButton GenerateReport;
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
    }
}