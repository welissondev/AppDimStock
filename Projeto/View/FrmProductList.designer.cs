namespace DimStock.View
{
    partial class FrmProductList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductList));
            this.TxtQueryByDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.GridProductList = new System.Windows.Forms.DataGridView();
            this.ImgGifLoading = new System.Windows.Forms.PictureBox();
            this.CboPageSize = new Syncfusion.WinForms.ListView.SfComboBox();
            this.TxtOcultNumberOfRecords = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblPageSize = new System.Windows.Forms.Label();
            this.LblQueryByDescription = new System.Windows.Forms.Label();
            this.LblQueryByReference = new System.Windows.Forms.Label();
            this.LblQueryBySize = new System.Windows.Forms.Label();
            this.LblQueryByCode = new System.Windows.Forms.Label();
            this.TxtQueryByReference = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtQueryBySize = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtQueryByCode = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TimerExecuteQuery = new System.Windows.Forms.Timer(this.components);
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnGenerateReport = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnUpdateList = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnNew = new Syncfusion.WinForms.Controls.SfButton();
            this.LblTodayIsDay = new System.Windows.Forms.Label();
            this.LblFormTitle = new System.Windows.Forms.Label();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOcultNumberOfRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryBySize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByCode)).BeginInit();
            this.PanelUpperHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtQueryByDescription
            // 
            this.TxtQueryByDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryByDescription.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtQueryByDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByDescription.CanOverrideStyle = true;
            this.TxtQueryByDescription.CausesValidation = false;
            this.TxtQueryByDescription.CornerRadius = 4;
            this.TxtQueryByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByDescription.Location = new System.Drawing.Point(444, 139);
            this.TxtQueryByDescription.MaxLength = 50;
            this.TxtQueryByDescription.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtQueryByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByDescription.Multiline = true;
            this.TxtQueryByDescription.Name = "TxtQueryByDescription";
            this.TxtQueryByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByDescription.Size = new System.Drawing.Size(211, 29);
            this.TxtQueryByDescription.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryByDescription.TabIndex = 4;
            this.TxtQueryByDescription.Tag = "";
            this.TxtQueryByDescription.ThemeName = "Office2016Colorful";
            this.TxtQueryByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTheQuery_ForTheSearchBox_KeyPress);
            // 
            // GridProductList
            // 
            this.GridProductList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridProductList.Location = new System.Drawing.Point(17, 187);
            this.GridProductList.Name = "GridProductList";
            this.GridProductList.Size = new System.Drawing.Size(935, 452);
            this.GridProductList.TabIndex = 69;
            this.GridProductList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridProductList_CellClick);
            this.GridProductList.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridProductList_CellMouseDoubleClick);
            this.GridProductList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridProductList_CellMouseMove);
            this.GridProductList.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.GridProductList_RowPrePaint);
            // 
            // ImgGifLoading
            // 
            this.ImgGifLoading.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ImgGifLoading.Image = global::DimStock.Properties.Resources.Load;
            this.ImgGifLoading.Location = new System.Drawing.Point(431, 365);
            this.ImgGifLoading.Name = "ImgGifLoading";
            this.ImgGifLoading.Size = new System.Drawing.Size(138, 131);
            this.ImgGifLoading.TabIndex = 85;
            this.ImgGifLoading.TabStop = false;
            this.ImgGifLoading.Visible = false;
            // 
            // CboPageSize
            // 
            this.CboPageSize.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboPageSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPageSize.Location = new System.Drawing.Point(665, 142);
            this.CboPageSize.Name = "CboPageSize";
            this.CboPageSize.Size = new System.Drawing.Size(165, 25);
            this.CboPageSize.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboPageSize.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.CboPageSize.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPageSize.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPageSize.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboPageSize.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CboPageSize.TabIndex = 6;
            this.CboPageSize.ToolTipOption.ShadowVisible = false;
            this.CboPageSize.SelectedIndexChanged += new System.EventHandler(this.CboPageSize_SelectedIndexChanged);
            // 
            // TxtOcultNumberOfRecords
            // 
            this.TxtOcultNumberOfRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtOcultNumberOfRecords.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtOcultNumberOfRecords.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtOcultNumberOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOcultNumberOfRecords.CanOverrideStyle = true;
            this.TxtOcultNumberOfRecords.CausesValidation = false;
            this.TxtOcultNumberOfRecords.CornerRadius = 4;
            this.TxtOcultNumberOfRecords.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtOcultNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOcultNumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtOcultNumberOfRecords.Location = new System.Drawing.Point(659, 139);
            this.TxtOcultNumberOfRecords.MaxLength = 50;
            this.TxtOcultNumberOfRecords.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtOcultNumberOfRecords.Multiline = true;
            this.TxtOcultNumberOfRecords.Name = "TxtOcultNumberOfRecords";
            this.TxtOcultNumberOfRecords.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtOcultNumberOfRecords.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtOcultNumberOfRecords.Size = new System.Drawing.Size(174, 29);
            this.TxtOcultNumberOfRecords.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtOcultNumberOfRecords.TabIndex = 92;
            this.TxtOcultNumberOfRecords.Tag = "";
            this.TxtOcultNumberOfRecords.ThemeName = "Office2016Colorful";
            // 
            // LblPageSize
            // 
            this.LblPageSize.AutoSize = true;
            this.LblPageSize.Location = new System.Drawing.Point(658, 125);
            this.LblPageSize.Name = "LblPageSize";
            this.LblPageSize.Size = new System.Drawing.Size(107, 13);
            this.LblPageSize.TabIndex = 91;
            this.LblPageSize.Text = "Registros por página:";
            // 
            // LblQueryByDescription
            // 
            this.LblQueryByDescription.AutoSize = true;
            this.LblQueryByDescription.Location = new System.Drawing.Point(441, 123);
            this.LblQueryByDescription.Name = "LblQueryByDescription";
            this.LblQueryByDescription.Size = new System.Drawing.Size(112, 13);
            this.LblQueryByDescription.TabIndex = 90;
            this.LblQueryByDescription.Text = "Descrição do produto:";
            // 
            // LblQueryByReference
            // 
            this.LblQueryByReference.AutoSize = true;
            this.LblQueryByReference.Location = new System.Drawing.Point(299, 123);
            this.LblQueryByReference.Name = "LblQueryByReference";
            this.LblQueryByReference.Size = new System.Drawing.Size(62, 13);
            this.LblQueryByReference.TabIndex = 89;
            this.LblQueryByReference.Text = "Referência:";
            // 
            // LblQueryBySize
            // 
            this.LblQueryBySize.AutoSize = true;
            this.LblQueryBySize.Location = new System.Drawing.Point(157, 123);
            this.LblQueryBySize.Name = "LblQueryBySize";
            this.LblQueryBySize.Size = new System.Drawing.Size(55, 13);
            this.LblQueryBySize.TabIndex = 88;
            this.LblQueryBySize.Text = "Tamanho:";
            // 
            // LblQueryByCode
            // 
            this.LblQueryByCode.AutoSize = true;
            this.LblQueryByCode.Location = new System.Drawing.Point(15, 123);
            this.LblQueryByCode.Name = "LblQueryByCode";
            this.LblQueryByCode.Size = new System.Drawing.Size(83, 13);
            this.LblQueryByCode.TabIndex = 87;
            this.LblQueryByCode.Text = "Código Produto:";
            // 
            // TxtQueryByReference
            // 
            this.TxtQueryByReference.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryByReference.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtQueryByReference.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryByReference.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByReference.CanOverrideStyle = true;
            this.TxtQueryByReference.CausesValidation = false;
            this.TxtQueryByReference.CornerRadius = 4;
            this.TxtQueryByReference.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByReference.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByReference.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByReference.Location = new System.Drawing.Point(302, 139);
            this.TxtQueryByReference.MaxLength = 50;
            this.TxtQueryByReference.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtQueryByReference.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByReference.Multiline = true;
            this.TxtQueryByReference.Name = "TxtQueryByReference";
            this.TxtQueryByReference.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByReference.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByReference.Size = new System.Drawing.Size(136, 29);
            this.TxtQueryByReference.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryByReference.TabIndex = 2;
            this.TxtQueryByReference.Tag = "";
            this.TxtQueryByReference.ThemeName = "Office2016Colorful";
            this.TxtQueryByReference.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTheQuery_ForTheSearchBox_KeyPress);
            // 
            // TxtQueryBySize
            // 
            this.TxtQueryBySize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryBySize.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtQueryBySize.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryBySize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryBySize.CanOverrideStyle = true;
            this.TxtQueryBySize.CausesValidation = false;
            this.TxtQueryBySize.CornerRadius = 4;
            this.TxtQueryBySize.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryBySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryBySize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryBySize.Location = new System.Drawing.Point(160, 139);
            this.TxtQueryBySize.MaxLength = 50;
            this.TxtQueryBySize.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtQueryBySize.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryBySize.Multiline = true;
            this.TxtQueryBySize.Name = "TxtQueryBySize";
            this.TxtQueryBySize.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryBySize.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryBySize.Size = new System.Drawing.Size(136, 29);
            this.TxtQueryBySize.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryBySize.TabIndex = 1;
            this.TxtQueryBySize.Tag = "";
            this.TxtQueryBySize.ThemeName = "Office2016Colorful";
            this.TxtQueryBySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTheQuery_ForTheSearchBox_KeyPress);
            // 
            // TxtQueryByCode
            // 
            this.TxtQueryByCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryByCode.BeforeTouchSize = new System.Drawing.Size(174, 29);
            this.TxtQueryByCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryByCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByCode.CanOverrideStyle = true;
            this.TxtQueryByCode.CausesValidation = false;
            this.TxtQueryByCode.CornerRadius = 4;
            this.TxtQueryByCode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByCode.Location = new System.Drawing.Point(18, 139);
            this.TxtQueryByCode.MaxLength = 50;
            this.TxtQueryByCode.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtQueryByCode.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByCode.Multiline = true;
            this.TxtQueryByCode.Name = "TxtQueryByCode";
            this.TxtQueryByCode.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByCode.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByCode.Size = new System.Drawing.Size(136, 29);
            this.TxtQueryByCode.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryByCode.TabIndex = 0;
            this.TxtQueryByCode.Tag = "";
            this.TxtQueryByCode.ThemeName = "Office2016Colorful";
            this.TxtQueryByCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.StartTheQuery_ForTheSearchBox_KeyPress);
            // 
            // TimerExecuteQuery
            // 
            this.TimerExecuteQuery.Interval = 1000;
            this.TimerExecuteQuery.Tick += new System.EventHandler(this.TimerExecuteQuery_Tick);
            // 
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.BtnGenerateReport);
            this.PanelUpperHorizontal.Controls.Add(this.BtnUpdateList);
            this.PanelUpperHorizontal.Controls.Add(this.BtnNew);
            this.PanelUpperHorizontal.Controls.Add(this.LblTodayIsDay);
            this.PanelUpperHorizontal.Controls.Add(this.LblFormTitle);
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
            // BtnGenerateReport
            // 
            this.BtnGenerateReport.AccessibleName = "Button";
            this.BtnGenerateReport.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnGenerateReport.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGenerateReport.ForeColor = System.Drawing.Color.White;
            this.BtnGenerateReport.Location = new System.Drawing.Point(184, 46);
            this.BtnGenerateReport.Name = "BtnGenerateReport";
            this.BtnGenerateReport.Size = new System.Drawing.Size(80, 35);
            this.BtnGenerateReport.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnGenerateReport.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnGenerateReport.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnGenerateReport.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnGenerateReport.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnGenerateReport.Style.ForeColor = System.Drawing.Color.White;
            this.BtnGenerateReport.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnGenerateReport.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnGenerateReport.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnGenerateReport.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnGenerateReport.TabIndex = 143;
            this.BtnGenerateReport.Text = "Relatório";
            this.BtnGenerateReport.UseVisualStyleBackColor = false;
            this.BtnGenerateReport.Click += new System.EventHandler(this.BtnGenerateReport_Click);
            // 
            // BtnUpdateList
            // 
            this.BtnUpdateList.AccessibleName = "Button";
            this.BtnUpdateList.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateList.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Location = new System.Drawing.Point(101, 46);
            this.BtnUpdateList.Name = "BtnUpdateList";
            this.BtnUpdateList.Size = new System.Drawing.Size(80, 35);
            this.BtnUpdateList.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Style.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnUpdateList.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnUpdateList.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.TabIndex = 142;
            this.BtnUpdateList.Text = "Atualizar";
            this.BtnUpdateList.UseVisualStyleBackColor = false;
            this.BtnUpdateList.Click += new System.EventHandler(this.BtnUpdateList_Click);
            // 
            // BtnNew
            // 
            this.BtnNew.AccessibleName = "Button";
            this.BtnNew.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNew.ForeColor = System.Drawing.Color.White;
            this.BtnNew.Location = new System.Drawing.Point(18, 46);
            this.BtnNew.Name = "BtnNew";
            this.BtnNew.Size = new System.Drawing.Size(80, 35);
            this.BtnNew.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnNew.Style.ForeColor = System.Drawing.Color.White;
            this.BtnNew.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNew.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnNew.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNew.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnNew.TabIndex = 141;
            this.BtnNew.Text = "Novo";
            this.BtnNew.UseVisualStyleBackColor = false;
            this.BtnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // LblTodayIsDay
            // 
            this.LblTodayIsDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTodayIsDay.BackColor = System.Drawing.Color.Transparent;
            this.LblTodayIsDay.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTodayIsDay.ForeColor = System.Drawing.Color.White;
            this.LblTodayIsDay.Location = new System.Drawing.Point(442, 24);
            this.LblTodayIsDay.Name = "LblTodayIsDay";
            this.LblTodayIsDay.Size = new System.Drawing.Size(517, 40);
            this.LblTodayIsDay.TabIndex = 139;
            this.LblTodayIsDay.Text = "Entrada de Estoque";
            this.LblTodayIsDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblFormTitle
            // 
            this.LblFormTitle.AutoSize = true;
            this.LblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblFormTitle.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormTitle.ForeColor = System.Drawing.Color.White;
            this.LblFormTitle.Location = new System.Drawing.Point(10, 4);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(272, 40);
            this.LblFormTitle.TabIndex = 138;
            this.LblFormTitle.Text = "Lista de Produtos";
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
            // FrmProductList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.ImgGifLoading);
            this.Controls.Add(this.PanelUpperHorizontal);
            this.Controls.Add(this.CboPageSize);
            this.Controls.Add(this.TxtQueryByDescription);
            this.Controls.Add(this.GridProductList);
            this.Controls.Add(this.TxtQueryByCode);
            this.Controls.Add(this.TxtQueryBySize);
            this.Controls.Add(this.TxtQueryByReference);
            this.Controls.Add(this.TxtOcultNumberOfRecords);
            this.Controls.Add(this.LblQueryByCode);
            this.Controls.Add(this.LblPageSize);
            this.Controls.Add(this.LblQueryBySize);
            this.Controls.Add(this.LblQueryByDescription);
            this.Controls.Add(this.LblQueryByReference);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmProductList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmProductList_Load);
            this.Resize += new System.EventHandler(this.FrmProductList_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImgGifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOcultNumberOfRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryBySize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByCode)).EndInit();
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByDescription;
        private System.Windows.Forms.DataGridView GridProductList;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByReference;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryBySize;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByCode;
        private System.Windows.Forms.Label LblQueryByDescription;
        private System.Windows.Forms.Label LblQueryByReference;
        private System.Windows.Forms.Label LblQueryBySize;
        private System.Windows.Forms.Label LblQueryByCode;
        private System.Windows.Forms.Label LblPageSize;
        private System.Windows.Forms.Timer TimerExecuteQuery;
        private System.Windows.Forms.PictureBox ImgGifLoading;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtOcultNumberOfRecords;
        private Syncfusion.WinForms.ListView.SfComboBox CboPageSize;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        public System.Windows.Forms.Label LblTodayIsDay;
        public System.Windows.Forms.Label LblFormTitle;
        private Syncfusion.WinForms.Controls.SfButton BtnNew;
        private Syncfusion.WinForms.Controls.SfButton BtnUpdateList;
        private Syncfusion.WinForms.Controls.SfButton BtnGenerateReport;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
    }
}