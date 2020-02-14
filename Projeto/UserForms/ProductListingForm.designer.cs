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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductListingForm));
            this.SearchByDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ProductDataList = new System.Windows.Forms.DataGridView();
            this.GifLoading = new System.Windows.Forms.PictureBox();
            this.RecordsByPage = new Syncfusion.WinForms.ListView.SfComboBox();
            this.TitleRecordsByPage = new System.Windows.Forms.Label();
            this.TitleSearchByDescription = new System.Windows.Forms.Label();
            this.TitleSearchByReference = new System.Windows.Forms.Label();
            this.TitleSearchBySize = new System.Windows.Forms.Label();
            this.TitleSearchByCode = new System.Windows.Forms.Label();
            this.SearchByReference = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchBySize = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchByCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            this.NewRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DataList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.GenerateReport = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchByDescription
            // 
            this.SearchByDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByDescription.BeforeTouchSize = new System.Drawing.Size(90, 27);
            this.SearchByDescription.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByDescription.CanOverrideStyle = true;
            this.SearchByDescription.CausesValidation = false;
            this.SearchByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByDescription.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByDescription.Location = new System.Drawing.Point(309, 108);
            this.SearchByDescription.MaxLength = 50;
            this.SearchByDescription.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.SearchByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchByDescription.Multiline = true;
            this.SearchByDescription.Name = "SearchByDescription";
            this.SearchByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchByDescription.Size = new System.Drawing.Size(235, 27);
            this.SearchByDescription.TabIndex = 4;
            this.SearchByDescription.Tag = "";
            this.SearchByDescription.ThemeName = "Default";
            this.SearchByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchByFields_KeyPress);
            // 
            // ProductDataList
            // 
            this.ProductDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductDataList.Location = new System.Drawing.Point(16, 150);
            this.ProductDataList.Name = "ProductDataList";
            this.ProductDataList.Size = new System.Drawing.Size(900, 373);
            this.ProductDataList.TabIndex = 69;
            this.ProductDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataList_CellClick);
            this.ProductDataList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductDataList_CellMouseDoubleClick);
            this.ProductDataList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataList_CellMouseEnter);
            this.ProductDataList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.ProductDataList_RowPrePaint);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GifLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.GifLoading.Location = new System.Drawing.Point(390, 269);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(135, 135);
            this.GifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GifLoading.TabIndex = 85;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
            // 
            // RecordsByPage
            // 
            this.RecordsByPage.BackColor = System.Drawing.Color.White;
            this.RecordsByPage.CanOverrideStyle = true;
            this.RecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.RecordsByPage.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Location = new System.Drawing.Point(550, 108);
            this.RecordsByPage.Name = "RecordsByPage";
            this.RecordsByPage.Size = new System.Drawing.Size(157, 27);
            this.RecordsByPage.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.White;
            this.RecordsByPage.Style.DropDownButtonStyle.DisabledBackColor = System.Drawing.Color.White;
            this.RecordsByPage.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.RecordsByPage.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.White;
            this.RecordsByPage.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.White;
            this.RecordsByPage.Style.DropDownButtonStyle.PressedBackColor = System.Drawing.Color.White;
            this.RecordsByPage.Style.DropDownStyle.BorderColor = System.Drawing.Color.Gray;
            this.RecordsByPage.Style.DropDownStyle.GripperForeColor = System.Drawing.Color.White;
            this.RecordsByPage.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.RecordsByPage.Style.EditorStyle.BorderColor = System.Drawing.Color.DarkGray;
            this.RecordsByPage.Style.EditorStyle.DisabledBackColor = System.Drawing.Color.White;
            this.RecordsByPage.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.DarkGray;
            this.RecordsByPage.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.RecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.ReadOnlyEditorStyle.BorderColor = System.Drawing.Color.DarkGray;
            this.RecordsByPage.Style.ReadOnlyEditorStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.RecordsByPage.Style.ReadOnlyEditorStyle.FocusedBorderColor = System.Drawing.Color.Gray;
            this.RecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.TabIndex = 6;
            this.RecordsByPage.ToolTipOption.ShadowVisible = false;
            this.RecordsByPage.SelectedIndexChanged += new System.EventHandler(this.RecordsByPage_SelectedIndexChanged);
            // 
            // TitleRecordsByPage
            // 
            this.TitleRecordsByPage.AutoSize = true;
            this.TitleRecordsByPage.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.TitleRecordsByPage.Location = new System.Drawing.Point(547, 90);
            this.TitleRecordsByPage.Name = "TitleRecordsByPage";
            this.TitleRecordsByPage.Size = new System.Drawing.Size(134, 18);
            this.TitleRecordsByPage.TabIndex = 91;
            this.TitleRecordsByPage.Text = "Registros Por Página:";
            // 
            // TitleSearchByDescription
            // 
            this.TitleSearchByDescription.AutoSize = true;
            this.TitleSearchByDescription.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.TitleSearchByDescription.Location = new System.Drawing.Point(306, 90);
            this.TitleSearchByDescription.Name = "TitleSearchByDescription";
            this.TitleSearchByDescription.Size = new System.Drawing.Size(69, 18);
            this.TitleSearchByDescription.TabIndex = 90;
            this.TitleSearchByDescription.Text = "Descrição:";
            // 
            // TitleSearchByReference
            // 
            this.TitleSearchByReference.AutoSize = true;
            this.TitleSearchByReference.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.TitleSearchByReference.Location = new System.Drawing.Point(211, 90);
            this.TitleSearchByReference.Name = "TitleSearchByReference";
            this.TitleSearchByReference.Size = new System.Drawing.Size(74, 18);
            this.TitleSearchByReference.TabIndex = 89;
            this.TitleSearchByReference.Text = "Referência:";
            // 
            // TitleSearchBySize
            // 
            this.TitleSearchBySize.AutoSize = true;
            this.TitleSearchBySize.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.TitleSearchBySize.Location = new System.Drawing.Point(112, 90);
            this.TitleSearchBySize.Name = "TitleSearchBySize";
            this.TitleSearchBySize.Size = new System.Drawing.Size(68, 18);
            this.TitleSearchBySize.TabIndex = 88;
            this.TitleSearchBySize.Text = "Tamanho:";
            // 
            // TitleSearchByCode
            // 
            this.TitleSearchByCode.AutoSize = true;
            this.TitleSearchByCode.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.TitleSearchByCode.Location = new System.Drawing.Point(14, 90);
            this.TitleSearchByCode.Name = "TitleSearchByCode";
            this.TitleSearchByCode.Size = new System.Drawing.Size(54, 18);
            this.TitleSearchByCode.TabIndex = 87;
            this.TitleSearchByCode.Text = "Código:";
            // 
            // SearchByReference
            // 
            this.SearchByReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByReference.BeforeTouchSize = new System.Drawing.Size(90, 27);
            this.SearchByReference.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchByReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByReference.CanOverrideStyle = true;
            this.SearchByReference.CausesValidation = false;
            this.SearchByReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByReference.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByReference.Location = new System.Drawing.Point(214, 108);
            this.SearchByReference.MaxLength = 50;
            this.SearchByReference.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.SearchByReference.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchByReference.Multiline = true;
            this.SearchByReference.Name = "SearchByReference";
            this.SearchByReference.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchByReference.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchByReference.Size = new System.Drawing.Size(90, 27);
            this.SearchByReference.TabIndex = 2;
            this.SearchByReference.Tag = "";
            this.SearchByReference.ThemeName = "Default";
            this.SearchByReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchByFields_KeyPress);
            // 
            // SearchBySize
            // 
            this.SearchBySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchBySize.BeforeTouchSize = new System.Drawing.Size(90, 27);
            this.SearchBySize.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchBySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBySize.CanOverrideStyle = true;
            this.SearchBySize.CausesValidation = false;
            this.SearchBySize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchBySize.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchBySize.Location = new System.Drawing.Point(115, 108);
            this.SearchBySize.MaxLength = 50;
            this.SearchBySize.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.SearchBySize.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchBySize.Multiline = true;
            this.SearchBySize.Name = "SearchBySize";
            this.SearchBySize.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchBySize.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchBySize.Size = new System.Drawing.Size(94, 27);
            this.SearchBySize.TabIndex = 1;
            this.SearchBySize.Tag = "";
            this.SearchBySize.ThemeName = "Default";
            this.SearchBySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchByFields_KeyPress);
            // 
            // SearchByCode
            // 
            this.SearchByCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByCode.BeforeTouchSize = new System.Drawing.Size(90, 27);
            this.SearchByCode.BorderColor = System.Drawing.Color.DarkGray;
            this.SearchByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByCode.CanOverrideStyle = true;
            this.SearchByCode.CausesValidation = false;
            this.SearchByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByCode.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByCode.Location = new System.Drawing.Point(17, 108);
            this.SearchByCode.MaxLength = 50;
            this.SearchByCode.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.SearchByCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchByCode.Multiline = true;
            this.SearchByCode.Name = "SearchByCode";
            this.SearchByCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchByCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchByCode.Size = new System.Drawing.Size(93, 27);
            this.SearchByCode.TabIndex = 0;
            this.SearchByCode.Tag = "";
            this.SearchByCode.ThemeName = "Default";
            this.SearchByCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchByFields_KeyPress);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 500;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
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
            this.BindingPagination.TabIndex = 178;
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
            // NewRegister
            // 
            this.NewRegister.ActiveBorderThickness = 1;
            this.NewRegister.ActiveCornerRadius = 10;
            this.NewRegister.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.NewRegister.ActiveForecolor = System.Drawing.Color.White;
            this.NewRegister.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.NewRegister.BackColor = System.Drawing.Color.White;
            this.NewRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NewRegister.BackgroundImage")));
            this.NewRegister.ButtonText = "Novo";
            this.NewRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewRegister.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.NewRegister.IdleBorderThickness = 1;
            this.NewRegister.IdleCornerRadius = 10;
            this.NewRegister.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.NewRegister.IdleForecolor = System.Drawing.Color.White;
            this.NewRegister.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.NewRegister.Location = new System.Drawing.Point(13, 22);
            this.NewRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NewRegister.Name = "NewRegister";
            this.NewRegister.Size = new System.Drawing.Size(97, 43);
            this.NewRegister.TabIndex = 209;
            this.NewRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NewRegister.Click += new System.EventHandler(this.NewRegister_Click);
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
            this.DataList.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.DataList.IdleBorderThickness = 1;
            this.DataList.IdleCornerRadius = 10;
            this.DataList.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.DataList.IdleForecolor = System.Drawing.Color.White;
            this.DataList.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.DataList.Location = new System.Drawing.Point(112, 22);
            this.DataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(97, 43);
            this.DataList.TabIndex = 210;
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
            this.GenerateReport.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReport.ForeColor = System.Drawing.Color.SeaGreen;
            this.GenerateReport.IdleBorderThickness = 1;
            this.GenerateReport.IdleCornerRadius = 10;
            this.GenerateReport.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.IdleForecolor = System.Drawing.Color.White;
            this.GenerateReport.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Location = new System.Drawing.Point(211, 22);
            this.GenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(97, 43);
            this.GenerateReport.TabIndex = 211;
            this.GenerateReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // ProductListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.GenerateReport);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.NewRegister);
            this.Controls.Add(this.GifLoading);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.RecordsByPage);
            this.Controls.Add(this.SearchByDescription);
            this.Controls.Add(this.ProductDataList);
            this.Controls.Add(this.SearchByCode);
            this.Controls.Add(this.SearchBySize);
            this.Controls.Add(this.SearchByReference);
            this.Controls.Add(this.TitleSearchByCode);
            this.Controls.Add(this.TitleRecordsByPage);
            this.Controls.Add(this.TitleSearchBySize);
            this.Controls.Add(this.TitleSearchByDescription);
            this.Controls.Add(this.TitleSearchByReference);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "ProductListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProductListingForm_Load);
            this.Resize += new System.EventHandler(this.ProductListingForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SearchByDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchByDescription;
        private System.Windows.Forms.DataGridView ProductDataList;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchByReference;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchBySize;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchByCode;
        private System.Windows.Forms.Label TitleSearchByDescription;
        private System.Windows.Forms.Label TitleSearchByReference;
        private System.Windows.Forms.Label TitleSearchBySize;
        private System.Windows.Forms.Label TitleSearchByCode;
        private System.Windows.Forms.Label TitleRecordsByPage;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.PictureBox GifLoading;
        private Syncfusion.WinForms.ListView.SfComboBox RecordsByPage;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private Bunifu.Framework.UI.BunifuThinButton2 NewRegister;
        private Bunifu.Framework.UI.BunifuThinButton2 DataList;
        private Bunifu.Framework.UI.BunifuThinButton2 GenerateReport;
    }
}