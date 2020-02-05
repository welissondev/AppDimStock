namespace DimStock.UserForms
{
    partial class StockMovementListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockMovementListingForm));
            this.MovementStockDataList = new System.Windows.Forms.DataGridView();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.GifLoading = new System.Windows.Forms.PictureBox();
            this.OperationTypeTitle = new System.Windows.Forms.Label();
            this.OperationSituationTitle = new System.Windows.Forms.Label();
            this.OperationSituation = new Syncfusion.WinForms.ListView.SfComboBox();
            this.OperationType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.StockMovementIdTitle = new System.Windows.Forms.Label();
            this.SearchByStockMovimentId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ClearSearchFields = new System.Windows.Forms.LinkLabel();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            this.RecordsByPage = new Syncfusion.WinForms.ListView.SfComboBox();
            this.RecordsOfPageTitle = new System.Windows.Forms.Label();
            this.StockMovementMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MovementEntrie_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovementOutPut_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RegisterNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DataList = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.MovementStockDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationSituation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByStockMovimentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).BeginInit();
            this.StockMovementMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MovementStockDataList
            // 
            this.MovementStockDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovementStockDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovementStockDataList.Location = new System.Drawing.Point(21, 139);
            this.MovementStockDataList.Name = "MovementStockDataList";
            this.MovementStockDataList.Size = new System.Drawing.Size(895, 384);
            this.MovementStockDataList.TabIndex = 0;
            this.MovementStockDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovementStockDataList_CellClick);
            this.MovementStockDataList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovementStockDataList_CellMouseEnter);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.GifLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.GifLoading.Location = new System.Drawing.Point(393, 238);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(135, 135);
            this.GifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GifLoading.TabIndex = 159;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
            // 
            // OperationTypeTitle
            // 
            this.OperationTypeTitle.AutoSize = true;
            this.OperationTypeTitle.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.OperationTypeTitle.Location = new System.Drawing.Point(128, 86);
            this.OperationTypeTitle.Name = "OperationTypeTitle";
            this.OperationTypeTitle.Size = new System.Drawing.Size(38, 18);
            this.OperationTypeTitle.TabIndex = 161;
            this.OperationTypeTitle.Text = "Tipo:";
            // 
            // OperationSituationTitle
            // 
            this.OperationSituationTitle.AutoSize = true;
            this.OperationSituationTitle.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.OperationSituationTitle.Location = new System.Drawing.Point(18, 86);
            this.OperationSituationTitle.Name = "OperationSituationTitle";
            this.OperationSituationTitle.Size = new System.Drawing.Size(63, 18);
            this.OperationSituationTitle.TabIndex = 163;
            this.OperationSituationTitle.Text = "Situação:";
            // 
            // OperationSituation
            // 
            this.OperationSituation.BackColor = System.Drawing.Color.White;
            this.OperationSituation.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.OperationSituation.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationSituation.Location = new System.Drawing.Point(21, 106);
            this.OperationSituation.Name = "OperationSituation";
            this.OperationSituation.Size = new System.Drawing.Size(109, 27);
            this.OperationSituation.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.OperationSituation.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OperationSituation.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.OperationSituation.Style.EditorStyle.BorderColor = System.Drawing.Color.Gray;
            this.OperationSituation.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.OperationSituation.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationSituation.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationSituation.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OperationSituation.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationSituation.TabIndex = 165;
            this.OperationSituation.SelectedIndexChanged += new System.EventHandler(this.OperationSituation_SelectedIndexChanged);
            // 
            // OperationType
            // 
            this.OperationType.BackColor = System.Drawing.Color.White;
            this.OperationType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.OperationType.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationType.Location = new System.Drawing.Point(134, 106);
            this.OperationType.Name = "OperationType";
            this.OperationType.Size = new System.Drawing.Size(115, 27);
            this.OperationType.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationType.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.OperationType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OperationType.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.OperationType.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.OperationType.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OperationType.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationType.TabIndex = 166;
            this.OperationType.SelectedIndexChanged += new System.EventHandler(this.OperationType_SelectedIndexChanged);
            // 
            // StockMovementIdTitle
            // 
            this.StockMovementIdTitle.AutoSize = true;
            this.StockMovementIdTitle.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.StockMovementIdTitle.Location = new System.Drawing.Point(250, 86);
            this.StockMovementIdTitle.Name = "StockMovementIdTitle";
            this.StockMovementIdTitle.Size = new System.Drawing.Size(125, 18);
            this.StockMovementIdTitle.TabIndex = 168;
            this.StockMovementIdTitle.Text = "Movimentação Nº :";
            // 
            // SearchByStockMovimentId
            // 
            this.SearchByStockMovimentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByStockMovimentId.BeforeTouchSize = new System.Drawing.Size(136, 27);
            this.SearchByStockMovimentId.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchByStockMovimentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByStockMovimentId.CanOverrideStyle = true;
            this.SearchByStockMovimentId.CausesValidation = false;
            this.SearchByStockMovimentId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByStockMovimentId.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByStockMovimentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByStockMovimentId.Location = new System.Drawing.Point(253, 106);
            this.SearchByStockMovimentId.MaxLength = 50;
            this.SearchByStockMovimentId.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchByStockMovimentId.Multiline = true;
            this.SearchByStockMovimentId.Name = "SearchByStockMovimentId";
            this.SearchByStockMovimentId.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchByStockMovimentId.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchByStockMovimentId.Size = new System.Drawing.Size(136, 27);
            this.SearchByStockMovimentId.TabIndex = 167;
            this.SearchByStockMovimentId.Tag = "";
            this.SearchByStockMovimentId.ThemeName = "Default";
            this.SearchByStockMovimentId.TextChanged += new System.EventHandler(this.QueryByStockMovementId_TextChanged);
            // 
            // ClearSearchFields
            // 
            this.ClearSearchFields.AutoSize = true;
            this.ClearSearchFields.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearSearchFields.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ClearSearchFields.Location = new System.Drawing.Point(560, 108);
            this.ClearSearchFields.Name = "ClearSearchFields";
            this.ClearSearchFields.Size = new System.Drawing.Size(55, 19);
            this.ClearSearchFields.TabIndex = 170;
            this.ClearSearchFields.TabStop = true;
            this.ClearSearchFields.Text = "Limpar";
            this.ClearSearchFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearSearchFields_LinkClicked);
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
            this.BindingPagination.TabIndex = 179;
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
            this.RecordsByPage.Location = new System.Drawing.Point(393, 106);
            this.RecordsByPage.Name = "RecordsByPage";
            this.RecordsByPage.Size = new System.Drawing.Size(165, 27);
            this.RecordsByPage.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordsByPage.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.RecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.TabIndex = 180;
            this.RecordsByPage.ToolTipOption.ShadowVisible = false;
            this.RecordsByPage.SelectedIndexChanged += new System.EventHandler(this.RecordsByPage_SelectedIndexChanged);
            // 
            // RecordsOfPageTitle
            // 
            this.RecordsOfPageTitle.AutoSize = true;
            this.RecordsOfPageTitle.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.RecordsOfPageTitle.Location = new System.Drawing.Point(389, 86);
            this.RecordsOfPageTitle.Name = "RecordsOfPageTitle";
            this.RecordsOfPageTitle.Size = new System.Drawing.Size(134, 18);
            this.RecordsOfPageTitle.TabIndex = 181;
            this.RecordsOfPageTitle.Text = "Registros por página:";
            // 
            // StockMovementMenuStrip
            // 
            this.StockMovementMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovementEntrie_ToolStripMenuItem,
            this.MovementOutPut_ToolStripMenuItem});
            this.StockMovementMenuStrip.Name = "ContextMenuStrip";
            this.StockMovementMenuStrip.Size = new System.Drawing.Size(115, 48);
            // 
            // MovementEntrie_ToolStripMenuItem
            // 
            this.MovementEntrie_ToolStripMenuItem.Name = "MovementEntrie_ToolStripMenuItem";
            this.MovementEntrie_ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.MovementEntrie_ToolStripMenuItem.Text = "Entrada";
            this.MovementEntrie_ToolStripMenuItem.Click += new System.EventHandler(this.MovementEntrie_ToolStripMenuItem_Click);
            // 
            // MovementOutPut_ToolStripMenuItem
            // 
            this.MovementOutPut_ToolStripMenuItem.Name = "MovementOutPut_ToolStripMenuItem";
            this.MovementOutPut_ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.MovementOutPut_ToolStripMenuItem.Text = "Saída";
            this.MovementOutPut_ToolStripMenuItem.Click += new System.EventHandler(this.MovementOutPut_ToolStripMenuItem_Click);
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
            this.RegisterNew.ButtonText = "Nova";
            this.RegisterNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterNew.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.IdleBorderThickness = 1;
            this.RegisterNew.IdleCornerRadius = 10;
            this.RegisterNew.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.IdleForecolor = System.Drawing.Color.White;
            this.RegisterNew.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Location = new System.Drawing.Point(20, 19);
            this.RegisterNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RegisterNew.Name = "RegisterNew";
            this.RegisterNew.Size = new System.Drawing.Size(97, 43);
            this.RegisterNew.TabIndex = 216;
            this.RegisterNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RegisterNew.Click += new System.EventHandler(this.RegisterNew_Click);
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
            this.DataList.Location = new System.Drawing.Point(119, 19);
            this.DataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(97, 43);
            this.DataList.TabIndex = 217;
            this.DataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataList.Click += new System.EventHandler(this.DataList_Click);
            // 
            // StockMovementListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.RegisterNew);
            this.Controls.Add(this.GifLoading);
            this.Controls.Add(this.RecordsByPage);
            this.Controls.Add(this.RecordsOfPageTitle);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.ClearSearchFields);
            this.Controls.Add(this.StockMovementIdTitle);
            this.Controls.Add(this.SearchByStockMovimentId);
            this.Controls.Add(this.OperationType);
            this.Controls.Add(this.OperationSituation);
            this.Controls.Add(this.OperationSituationTitle);
            this.Controls.Add(this.OperationTypeTitle);
            this.Controls.Add(this.MovementStockDataList);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "StockMovementListingForm";
            this.Load += new System.EventHandler(this.StockMovementListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MovementStockDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationSituation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByStockMovimentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).EndInit();
            this.StockMovementMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MovementStockDataList;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.PictureBox GifLoading;
        private System.Windows.Forms.Label OperationTypeTitle;
        private System.Windows.Forms.Label OperationSituationTitle;
        private Syncfusion.WinForms.ListView.SfComboBox OperationSituation;
        private Syncfusion.WinForms.ListView.SfComboBox OperationType;
        private System.Windows.Forms.Label StockMovementIdTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchByStockMovimentId;
        private System.Windows.Forms.LinkLabel ClearSearchFields;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private Syncfusion.WinForms.ListView.SfComboBox RecordsByPage;
        private System.Windows.Forms.Label RecordsOfPageTitle;
        private System.Windows.Forms.ContextMenuStrip StockMovementMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MovementEntrie_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovementOutPut_ToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuThinButton2 RegisterNew;
        private Bunifu.Framework.UI.BunifuThinButton2 DataList;
    }
}