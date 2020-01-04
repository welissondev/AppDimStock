namespace DimStock.View
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
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DayOfTheWeek = new System.Windows.Forms.Label();
            this.FormCaption = new System.Windows.Forms.Label();
            this.GenerateReport = new Syncfusion.WinForms.Controls.SfButton();
            this.UpdateDataList = new Syncfusion.WinForms.Controls.SfButton();
            this.RegisterNew = new Syncfusion.WinForms.Controls.SfButton();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByCode)).BeginInit();
            this.PanelUpperHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // SearchByDescription
            // 
            this.SearchByDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByDescription.BeforeTouchSize = new System.Drawing.Size(235, 27);
            this.SearchByDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByDescription.CanOverrideStyle = true;
            this.SearchByDescription.CausesValidation = false;
            this.SearchByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByDescription.Location = new System.Drawing.Point(311, 152);
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
            this.ProductDataList.Location = new System.Drawing.Point(16, 185);
            this.ProductDataList.Name = "ProductDataList";
            this.ProductDataList.Size = new System.Drawing.Size(936, 454);
            this.ProductDataList.TabIndex = 69;
            this.ProductDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductDataList_CellClick);
            this.ProductDataList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductDataList_CellMouseDoubleClick);
            this.ProductDataList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ProductDataList_CellMouseMove);
            this.ProductDataList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.ProductDataList_RowPrePaint);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.GifLoading.Image = global::DimStock.Properties.Resources.Load;
            this.GifLoading.Location = new System.Drawing.Point(431, 365);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(138, 131);
            this.GifLoading.TabIndex = 85;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
            // 
            // RecordsByPage
            // 
            this.RecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.RecordsByPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Location = new System.Drawing.Point(552, 152);
            this.RecordsByPage.Name = "RecordsByPage";
            this.RecordsByPage.Size = new System.Drawing.Size(136, 27);
            this.RecordsByPage.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordsByPage.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.RecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.TabIndex = 6;
            this.RecordsByPage.ToolTipOption.ShadowVisible = false;
            this.RecordsByPage.SelectedIndexChanged += new System.EventHandler(this.RecordsByPage_SelectedIndexChanged);
            // 
            // TitleRecordsByPage
            // 
            this.TitleRecordsByPage.AutoSize = true;
            this.TitleRecordsByPage.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleRecordsByPage.Location = new System.Drawing.Point(549, 138);
            this.TitleRecordsByPage.Name = "TitleRecordsByPage";
            this.TitleRecordsByPage.Size = new System.Drawing.Size(146, 13);
            this.TitleRecordsByPage.TabIndex = 91;
            this.TitleRecordsByPage.Text = "REGISTROS POR PÁGINA:";
            // 
            // TitleSearchByDescription
            // 
            this.TitleSearchByDescription.AutoSize = true;
            this.TitleSearchByDescription.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSearchByDescription.Location = new System.Drawing.Point(308, 136);
            this.TitleSearchByDescription.Name = "TitleSearchByDescription";
            this.TitleSearchByDescription.Size = new System.Drawing.Size(74, 13);
            this.TitleSearchByDescription.TabIndex = 90;
            this.TitleSearchByDescription.Text = "DESCRIÇÃO:";
            // 
            // TitleSearchByReference
            // 
            this.TitleSearchByReference.AutoSize = true;
            this.TitleSearchByReference.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSearchByReference.Location = new System.Drawing.Point(212, 136);
            this.TitleSearchByReference.Name = "TitleSearchByReference";
            this.TitleSearchByReference.Size = new System.Drawing.Size(74, 13);
            this.TitleSearchByReference.TabIndex = 89;
            this.TitleSearchByReference.Text = "REFERÊNCIA";
            // 
            // TitleSearchBySize
            // 
            this.TitleSearchBySize.AutoSize = true;
            this.TitleSearchBySize.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSearchBySize.Location = new System.Drawing.Point(112, 136);
            this.TitleSearchBySize.Name = "TitleSearchBySize";
            this.TitleSearchBySize.Size = new System.Drawing.Size(66, 13);
            this.TitleSearchBySize.TabIndex = 88;
            this.TitleSearchBySize.Text = "TAMANHO:";
            // 
            // TitleSearchByCode
            // 
            this.TitleSearchByCode.AutoSize = true;
            this.TitleSearchByCode.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleSearchByCode.Location = new System.Drawing.Point(13, 136);
            this.TitleSearchByCode.Name = "TitleSearchByCode";
            this.TitleSearchByCode.Size = new System.Drawing.Size(51, 13);
            this.TitleSearchByCode.TabIndex = 87;
            this.TitleSearchByCode.Text = "CÓDIGO";
            // 
            // SearchByReference
            // 
            this.SearchByReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByReference.BeforeTouchSize = new System.Drawing.Size(235, 27);
            this.SearchByReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchByReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByReference.CanOverrideStyle = true;
            this.SearchByReference.CausesValidation = false;
            this.SearchByReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByReference.Location = new System.Drawing.Point(215, 152);
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
            this.SearchBySize.BeforeTouchSize = new System.Drawing.Size(235, 27);
            this.SearchBySize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchBySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchBySize.CanOverrideStyle = true;
            this.SearchBySize.CausesValidation = false;
            this.SearchBySize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchBySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchBySize.Location = new System.Drawing.Point(115, 152);
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
            this.SearchByCode.BeforeTouchSize = new System.Drawing.Size(235, 27);
            this.SearchByCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByCode.CanOverrideStyle = true;
            this.SearchByCode.CausesValidation = false;
            this.SearchByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByCode.Location = new System.Drawing.Point(16, 152);
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
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.DayOfTheWeek);
            this.PanelUpperHorizontal.Controls.Add(this.FormCaption);
            this.PanelUpperHorizontal.Controls.Add(this.GenerateReport);
            this.PanelUpperHorizontal.Controls.Add(this.UpdateDataList);
            this.PanelUpperHorizontal.Controls.Add(this.RegisterNew);
            this.PanelUpperHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpperHorizontal.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientBottomRight = System.Drawing.Color.RoyalBlue;
            this.PanelUpperHorizontal.GradientTopLeft = System.Drawing.SystemColors.ControlText;
            this.PanelUpperHorizontal.GradientTopRight = System.Drawing.SystemColors.InactiveCaptionText;
            this.PanelUpperHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PanelUpperHorizontal.Name = "PanelUpperHorizontal";
            this.PanelUpperHorizontal.Quality = 10;
            this.PanelUpperHorizontal.Size = new System.Drawing.Size(964, 93);
            this.PanelUpperHorizontal.TabIndex = 140;
            // 
            // DayOfTheWeek
            // 
            this.DayOfTheWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DayOfTheWeek.BackColor = System.Drawing.Color.Transparent;
            this.DayOfTheWeek.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayOfTheWeek.ForeColor = System.Drawing.Color.White;
            this.DayOfTheWeek.Location = new System.Drawing.Point(393, 21);
            this.DayOfTheWeek.Name = "DayOfTheWeek";
            this.DayOfTheWeek.Size = new System.Drawing.Size(563, 40);
            this.DayOfTheWeek.TabIndex = 145;
            this.DayOfTheWeek.Text = "DayOfTheWeek";
            this.DayOfTheWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCaption
            // 
            this.FormCaption.AutoSize = true;
            this.FormCaption.BackColor = System.Drawing.Color.Transparent;
            this.FormCaption.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCaption.ForeColor = System.Drawing.Color.White;
            this.FormCaption.Location = new System.Drawing.Point(8, 0);
            this.FormCaption.Name = "FormCaption";
            this.FormCaption.Size = new System.Drawing.Size(272, 40);
            this.FormCaption.TabIndex = 144;
            this.FormCaption.Text = "Lista de Produtos";
            // 
            // GenerateReport
            // 
            this.GenerateReport.AccessibleName = "Button";
            this.GenerateReport.BackColor = System.Drawing.Color.SeaGreen;
            this.GenerateReport.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateReport.ForeColor = System.Drawing.Color.White;
            this.GenerateReport.Location = new System.Drawing.Point(179, 44);
            this.GenerateReport.Name = "GenerateReport";
            this.GenerateReport.Size = new System.Drawing.Size(80, 35);
            this.GenerateReport.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.GenerateReport.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.GenerateReport.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.GenerateReport.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.GenerateReport.Style.FocusedForeColor = System.Drawing.Color.White;
            this.GenerateReport.Style.ForeColor = System.Drawing.Color.White;
            this.GenerateReport.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateReport.Style.HoverForeColor = System.Drawing.Color.Black;
            this.GenerateReport.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.GenerateReport.Style.PressedForeColor = System.Drawing.Color.White;
            this.GenerateReport.TabIndex = 143;
            this.GenerateReport.Text = "Relatório";
            this.GenerateReport.UseVisualStyleBackColor = false;
            this.GenerateReport.Click += new System.EventHandler(this.GenerateReport_Click);
            // 
            // UpdateDataList
            // 
            this.UpdateDataList.AccessibleName = "Button";
            this.UpdateDataList.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdateDataList.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataList.ForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Location = new System.Drawing.Point(96, 44);
            this.UpdateDataList.Name = "UpdateDataList";
            this.UpdateDataList.Size = new System.Drawing.Size(80, 35);
            this.UpdateDataList.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdateDataList.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.UpdateDataList.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.UpdateDataList.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.UpdateDataList.Style.FocusedForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Style.ForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.HoverForeColor = System.Drawing.Color.Black;
            this.UpdateDataList.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.UpdateDataList.Style.PressedForeColor = System.Drawing.Color.White;
            this.UpdateDataList.TabIndex = 142;
            this.UpdateDataList.Text = "Atualizar";
            this.UpdateDataList.UseVisualStyleBackColor = false;
            this.UpdateDataList.Click += new System.EventHandler(this.UpdateDataList_Click);
            // 
            // RegisterNew
            // 
            this.RegisterNew.AccessibleName = "Button";
            this.RegisterNew.BackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterNew.ForeColor = System.Drawing.Color.White;
            this.RegisterNew.Location = new System.Drawing.Point(13, 44);
            this.RegisterNew.Name = "RegisterNew";
            this.RegisterNew.Size = new System.Drawing.Size(80, 35);
            this.RegisterNew.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.FocusedForeColor = System.Drawing.Color.White;
            this.RegisterNew.Style.ForeColor = System.Drawing.Color.White;
            this.RegisterNew.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.Style.HoverForeColor = System.Drawing.Color.Black;
            this.RegisterNew.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.RegisterNew.Style.PressedForeColor = System.Drawing.Color.White;
            this.RegisterNew.TabIndex = 141;
            this.RegisterNew.Text = "Novo";
            this.RegisterNew.UseVisualStyleBackColor = false;
            this.RegisterNew.Click += new System.EventHandler(this.RegisterNew_Click);
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
            this.BindingPagination.Size = new System.Drawing.Size(964, 25);
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
            // ProductListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.GifLoading);
            this.Controls.Add(this.PanelUpperHorizontal);
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
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "ProductListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductListingForm_Load);
            this.Resize += new System.EventHandler(this.ProductListingForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.SearchByDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchBySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByCode)).EndInit();
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        private Syncfusion.WinForms.Controls.SfButton RegisterNew;
        private Syncfusion.WinForms.Controls.SfButton UpdateDataList;
        private Syncfusion.WinForms.Controls.SfButton GenerateReport;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        public System.Windows.Forms.Label DayOfTheWeek;
        public System.Windows.Forms.Label FormCaption;
    }
}