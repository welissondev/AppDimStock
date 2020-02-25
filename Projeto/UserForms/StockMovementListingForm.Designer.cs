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
            this.DatagridMovement = new System.Windows.Forms.DataGridView();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.PictureLoading = new System.Windows.Forms.PictureBox();
            this.OperationTypeTitle = new System.Windows.Forms.Label();
            this.OperationSituationTitle = new System.Windows.Forms.Label();
            this.ComboBoxOperationSituation = new Syncfusion.WinForms.ListView.SfComboBox();
            this.ComboBoxOperationType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.StockMovementIdTitle = new System.Windows.Forms.Label();
            this.ButtonClearSearchFields = new System.Windows.Forms.LinkLabel();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxRecordsByPage = new Syncfusion.WinForms.ListView.SfComboBox();
            this.RecordsOfPageTitle = new System.Windows.Forms.Label();
            this.StockMovementMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MovementEntrie_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MovementOutPut_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ButonRegisterNew = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonDataList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.TextSearchByOperationCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridMovement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxOperationSituation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxOperationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRecordsByPage)).BeginInit();
            this.StockMovementMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByOperationCode)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridMovement
            // 
            this.DatagridMovement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatagridMovement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridMovement.Location = new System.Drawing.Point(21, 139);
            this.DatagridMovement.Name = "DatagridMovement";
            this.DatagridMovement.Size = new System.Drawing.Size(895, 384);
            this.DatagridMovement.TabIndex = 0;
            this.DatagridMovement.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridMovement_CellClick);
            this.DatagridMovement.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridMovement_CellMouseEnter);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // PictureLoading
            // 
            this.PictureLoading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PictureLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.PictureLoading.Location = new System.Drawing.Point(393, 238);
            this.PictureLoading.Name = "PictureLoading";
            this.PictureLoading.Size = new System.Drawing.Size(135, 135);
            this.PictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLoading.TabIndex = 159;
            this.PictureLoading.TabStop = false;
            this.PictureLoading.Visible = false;
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
            // ComboBoxOperationSituation
            // 
            this.ComboBoxOperationSituation.BackColor = System.Drawing.Color.White;
            this.ComboBoxOperationSituation.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.ComboBoxOperationSituation.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperationSituation.Location = new System.Drawing.Point(21, 106);
            this.ComboBoxOperationSituation.Name = "ComboBoxOperationSituation";
            this.ComboBoxOperationSituation.Size = new System.Drawing.Size(109, 27);
            this.ComboBoxOperationSituation.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.ComboBoxOperationSituation.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ComboBoxOperationSituation.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.ComboBoxOperationSituation.Style.EditorStyle.BorderColor = System.Drawing.Color.Gray;
            this.ComboBoxOperationSituation.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.ComboBoxOperationSituation.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperationSituation.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperationSituation.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxOperationSituation.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperationSituation.TabIndex = 165;
            this.ComboBoxOperationSituation.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOperationSituation_SelectedIndexChanged);
            // 
            // ComboBoxOperationType
            // 
            this.ComboBoxOperationType.BackColor = System.Drawing.Color.White;
            this.ComboBoxOperationType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.ComboBoxOperationType.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperationType.Location = new System.Drawing.Point(134, 106);
            this.ComboBoxOperationType.Name = "ComboBoxOperationType";
            this.ComboBoxOperationType.Size = new System.Drawing.Size(115, 27);
            this.ComboBoxOperationType.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComboBoxOperationType.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.ComboBoxOperationType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.ComboBoxOperationType.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.ComboBoxOperationType.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.ComboBoxOperationType.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperationType.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperationType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxOperationType.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxOperationType.TabIndex = 166;
            this.ComboBoxOperationType.SelectedIndexChanged += new System.EventHandler(this.ComboBoxOperationType_SelectedIndexChanged);
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
            // ButtonClearSearchFields
            // 
            this.ButtonClearSearchFields.AutoSize = true;
            this.ButtonClearSearchFields.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClearSearchFields.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonClearSearchFields.Location = new System.Drawing.Point(558, 109);
            this.ButtonClearSearchFields.Name = "ButtonClearSearchFields";
            this.ButtonClearSearchFields.Size = new System.Drawing.Size(55, 19);
            this.ButtonClearSearchFields.TabIndex = 170;
            this.ButtonClearSearchFields.TabStop = true;
            this.ButtonClearSearchFields.Text = "Limpar";
            this.ButtonClearSearchFields.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonClearSearchFields_LinkClicked);
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
            // ComboBoxRecordsByPage
            // 
            this.ComboBoxRecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.ComboBoxRecordsByPage.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Location = new System.Drawing.Point(391, 106);
            this.ComboBoxRecordsByPage.Name = "ComboBoxRecordsByPage";
            this.ComboBoxRecordsByPage.Size = new System.Drawing.Size(165, 27);
            this.ComboBoxRecordsByPage.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ComboBoxRecordsByPage.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.ComboBoxRecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxRecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.TabIndex = 180;
            this.ComboBoxRecordsByPage.ToolTipOption.ShadowVisible = false;
            this.ComboBoxRecordsByPage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRecordsByPage_SelectedIndexChanged);
            // 
            // RecordsOfPageTitle
            // 
            this.RecordsOfPageTitle.AutoSize = true;
            this.RecordsOfPageTitle.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.RecordsOfPageTitle.Location = new System.Drawing.Point(387, 86);
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
            // ButonRegisterNew
            // 
            this.ButonRegisterNew.ActiveBorderThickness = 1;
            this.ButonRegisterNew.ActiveCornerRadius = 10;
            this.ButonRegisterNew.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButonRegisterNew.ActiveForecolor = System.Drawing.Color.White;
            this.ButonRegisterNew.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButonRegisterNew.BackColor = System.Drawing.Color.White;
            this.ButonRegisterNew.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButonRegisterNew.BackgroundImage")));
            this.ButonRegisterNew.ButtonText = "Nova";
            this.ButonRegisterNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButonRegisterNew.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButonRegisterNew.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButonRegisterNew.IdleBorderThickness = 1;
            this.ButonRegisterNew.IdleCornerRadius = 10;
            this.ButonRegisterNew.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButonRegisterNew.IdleForecolor = System.Drawing.Color.White;
            this.ButonRegisterNew.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButonRegisterNew.Location = new System.Drawing.Point(20, 19);
            this.ButonRegisterNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButonRegisterNew.Name = "ButonRegisterNew";
            this.ButonRegisterNew.Size = new System.Drawing.Size(97, 43);
            this.ButonRegisterNew.TabIndex = 216;
            this.ButonRegisterNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButonRegisterNew.Click += new System.EventHandler(this.ButtonRegisterNew_Click);
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
            this.ButtonDataList.Location = new System.Drawing.Point(119, 19);
            this.ButtonDataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDataList.Name = "ButtonDataList";
            this.ButtonDataList.Size = new System.Drawing.Size(97, 43);
            this.ButtonDataList.TabIndex = 217;
            this.ButtonDataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDataList.Click += new System.EventHandler(this.ButtonDataList_Click);
            // 
            // TextSearchByOperationCode
            // 
            this.TextSearchByOperationCode.BackColor = System.Drawing.Color.White;
            this.TextSearchByOperationCode.BeforeTouchSize = new System.Drawing.Size(132, 28);
            this.TextSearchByOperationCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextSearchByOperationCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchByOperationCode.CanOverrideStyle = true;
            this.TextSearchByOperationCode.CausesValidation = false;
            this.TextSearchByOperationCode.CornerRadius = 1;
            this.TextSearchByOperationCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchByOperationCode.Font = new System.Drawing.Font("Calibri Light", 12F);
            this.TextSearchByOperationCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextSearchByOperationCode.Location = new System.Drawing.Point(253, 105);
            this.TextSearchByOperationCode.MaxLength = 2000;
            this.TextSearchByOperationCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchByOperationCode.Multiline = true;
            this.TextSearchByOperationCode.Name = "TextSearchByOperationCode";
            this.TextSearchByOperationCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextSearchByOperationCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextSearchByOperationCode.Size = new System.Drawing.Size(132, 28);
            this.TextSearchByOperationCode.TabIndex = 220;
            this.TextSearchByOperationCode.Tag = "";
            this.TextSearchByOperationCode.ThemeName = "Default";
            this.TextSearchByOperationCode.ThemesEnabled = false;
            this.TextSearchByOperationCode.TextChanged += new System.EventHandler(this.TextSearchByOperationCode_TextChanged);
            // 
            // StockMovementListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.TextSearchByOperationCode);
            this.Controls.Add(this.ButtonDataList);
            this.Controls.Add(this.ButonRegisterNew);
            this.Controls.Add(this.PictureLoading);
            this.Controls.Add(this.ComboBoxRecordsByPage);
            this.Controls.Add(this.RecordsOfPageTitle);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.ButtonClearSearchFields);
            this.Controls.Add(this.StockMovementIdTitle);
            this.Controls.Add(this.ComboBoxOperationType);
            this.Controls.Add(this.ComboBoxOperationSituation);
            this.Controls.Add(this.OperationSituationTitle);
            this.Controls.Add(this.OperationTypeTitle);
            this.Controls.Add(this.DatagridMovement);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "StockMovementListingForm";
            this.Load += new System.EventHandler(this.StockMovementListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridMovement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxOperationSituation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxOperationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRecordsByPage)).EndInit();
            this.StockMovementMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByOperationCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatagridMovement;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.PictureBox PictureLoading;
        private System.Windows.Forms.Label OperationTypeTitle;
        private System.Windows.Forms.Label OperationSituationTitle;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBoxOperationSituation;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBoxOperationType;
        private System.Windows.Forms.Label StockMovementIdTitle;
        private System.Windows.Forms.LinkLabel ButtonClearSearchFields;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBoxRecordsByPage;
        private System.Windows.Forms.Label RecordsOfPageTitle;
        private System.Windows.Forms.ContextMenuStrip StockMovementMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MovementEntrie_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MovementOutPut_ToolStripMenuItem;
        private Bunifu.Framework.UI.BunifuThinButton2 ButonRegisterNew;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDataList;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchByOperationCode;
    }
}