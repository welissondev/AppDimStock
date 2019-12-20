namespace DimStock.View
{
    partial class FrmStockMovementList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockMovementList));
            this.StockMovementList = new System.Windows.Forms.DataGridView();
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.UpdateList = new Syncfusion.WinForms.Controls.SfButton();
            this.TodayIsDay = new System.Windows.Forms.Label();
            this.FormTitle = new System.Windows.Forms.Label();
            this.QueryTimer = new System.Windows.Forms.Timer(this.components);
            this.ImageLoading = new System.Windows.Forms.PictureBox();
            this.TxtTipo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.OperationTypeTitle = new System.Windows.Forms.Label();
            this.OperationSituationTitle = new System.Windows.Forms.Label();
            this.TxtSituacao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.OperationSituationList = new Syncfusion.WinForms.ListView.SfComboBox();
            this.OperationTypeList = new Syncfusion.WinForms.ListView.SfComboBox();
            this.StockMovementIdTitle = new System.Windows.Forms.Label();
            this.QueryByStockMovimentId = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblOu = new System.Windows.Forms.Label();
            this.ClearSearchFields = new System.Windows.Forms.LinkLabel();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            this.PageSizeList = new Syncfusion.WinForms.ListView.SfComboBox();
            this.TxtOcultNumberOfRecords = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PageSizeTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StockMovementList)).BeginInit();
            this.PanelUpperHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationSituationList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationTypeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByStockMovimentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageSizeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOcultNumberOfRecords)).BeginInit();
            this.SuspendLayout();
            // 
            // StockMovementList
            // 
            this.StockMovementList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StockMovementList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockMovementList.Location = new System.Drawing.Point(19, 181);
            this.StockMovementList.Name = "StockMovementList";
            this.StockMovementList.Size = new System.Drawing.Size(992, 365);
            this.StockMovementList.TabIndex = 0;
            this.StockMovementList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StockMovementList_CellClick);
            this.StockMovementList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StockMovementList_CellMouseMove);
            // 
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.UpdateList);
            this.PanelUpperHorizontal.Controls.Add(this.TodayIsDay);
            this.PanelUpperHorizontal.Controls.Add(this.FormTitle);
            this.PanelUpperHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpperHorizontal.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientTopLeft = System.Drawing.SystemColors.ControlText;
            this.PanelUpperHorizontal.GradientTopRight = System.Drawing.SystemColors.ControlText;
            this.PanelUpperHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PanelUpperHorizontal.Name = "PanelUpperHorizontal";
            this.PanelUpperHorizontal.Quality = 10;
            this.PanelUpperHorizontal.Size = new System.Drawing.Size(1023, 101);
            this.PanelUpperHorizontal.TabIndex = 141;
            // 
            // UpdateList
            // 
            this.UpdateList.AccessibleName = "Button";
            this.UpdateList.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateList.ForeColor = System.Drawing.Color.White;
            this.UpdateList.Location = new System.Drawing.Point(19, 52);
            this.UpdateList.Name = "UpdateList";
            this.UpdateList.Size = new System.Drawing.Size(80, 35);
            this.UpdateList.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.UpdateList.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.UpdateList.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.UpdateList.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.UpdateList.Style.FocusedForeColor = System.Drawing.Color.White;
            this.UpdateList.Style.ForeColor = System.Drawing.Color.White;
            this.UpdateList.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateList.Style.HoverForeColor = System.Drawing.Color.White;
            this.UpdateList.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.UpdateList.Style.PressedForeColor = System.Drawing.Color.White;
            this.UpdateList.TabIndex = 140;
            this.UpdateList.Text = "Atualizar";
            this.UpdateList.UseVisualStyleBackColor = false;
            this.UpdateList.Click += new System.EventHandler(this.BtnUpdateList_Click);
            // 
            // TodayIsDay
            // 
            this.TodayIsDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TodayIsDay.BackColor = System.Drawing.Color.Transparent;
            this.TodayIsDay.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayIsDay.ForeColor = System.Drawing.Color.White;
            this.TodayIsDay.Location = new System.Drawing.Point(554, 27);
            this.TodayIsDay.Name = "TodayIsDay";
            this.TodayIsDay.Size = new System.Drawing.Size(457, 40);
            this.TodayIsDay.TabIndex = 139;
            this.TodayIsDay.Text = "Entrada de Estoque";
            this.TodayIsDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormTitle
            // 
            this.FormTitle.AutoSize = true;
            this.FormTitle.BackColor = System.Drawing.Color.Transparent;
            this.FormTitle.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormTitle.ForeColor = System.Drawing.Color.White;
            this.FormTitle.Location = new System.Drawing.Point(12, 9);
            this.FormTitle.Name = "FormTitle";
            this.FormTitle.Size = new System.Drawing.Size(536, 40);
            this.FormTitle.TabIndex = 138;
            this.FormTitle.Text = "Lista de movimentações no estoque";
            // 
            // QueryTimer
            // 
            this.QueryTimer.Interval = 1000;
            this.QueryTimer.Tick += new System.EventHandler(this.QueryTimer_Tick);
            // 
            // ImageLoading
            // 
            this.ImageLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ImageLoading.Image = global::DimStock.Properties.Resources.Load;
            this.ImageLoading.Location = new System.Drawing.Point(446, 299);
            this.ImageLoading.Name = "ImageLoading";
            this.ImageLoading.Size = new System.Drawing.Size(129, 137);
            this.ImageLoading.TabIndex = 159;
            this.ImageLoading.TabStop = false;
            this.ImageLoading.Visible = false;
            // 
            // TxtTipo
            // 
            this.TxtTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtTipo.BeforeTouchSize = new System.Drawing.Size(120, 29);
            this.TxtTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTipo.CanOverrideStyle = true;
            this.TxtTipo.CausesValidation = false;
            this.TxtTipo.CornerRadius = 4;
            this.TxtTipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtTipo.Location = new System.Drawing.Point(143, 146);
            this.TxtTipo.MaxLength = 50;
            this.TxtTipo.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtTipo.Multiline = true;
            this.TxtTipo.Name = "TxtTipo";
            this.TxtTipo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtTipo.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtTipo.Size = new System.Drawing.Size(120, 29);
            this.TxtTipo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtTipo.TabIndex = 160;
            this.TxtTipo.Tag = "";
            this.TxtTipo.ThemeName = "Office2016Colorful";
            // 
            // OperationTypeTitle
            // 
            this.OperationTypeTitle.AutoSize = true;
            this.OperationTypeTitle.Location = new System.Drawing.Point(140, 131);
            this.OperationTypeTitle.Name = "OperationTypeTitle";
            this.OperationTypeTitle.Size = new System.Drawing.Size(31, 13);
            this.OperationTypeTitle.TabIndex = 161;
            this.OperationTypeTitle.Text = "Tipo:";
            // 
            // OperationSituationTitle
            // 
            this.OperationSituationTitle.AutoSize = true;
            this.OperationSituationTitle.Location = new System.Drawing.Point(17, 130);
            this.OperationSituationTitle.Name = "OperationSituationTitle";
            this.OperationSituationTitle.Size = new System.Drawing.Size(52, 13);
            this.OperationSituationTitle.TabIndex = 163;
            this.OperationSituationTitle.Text = "Situação:";
            // 
            // TxtSituacao
            // 
            this.TxtSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtSituacao.BeforeTouchSize = new System.Drawing.Size(120, 29);
            this.TxtSituacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtSituacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSituacao.CanOverrideStyle = true;
            this.TxtSituacao.CausesValidation = false;
            this.TxtSituacao.CornerRadius = 4;
            this.TxtSituacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtSituacao.Location = new System.Drawing.Point(20, 146);
            this.TxtSituacao.MaxLength = 50;
            this.TxtSituacao.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtSituacao.Multiline = true;
            this.TxtSituacao.Name = "TxtSituacao";
            this.TxtSituacao.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtSituacao.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtSituacao.Size = new System.Drawing.Size(120, 29);
            this.TxtSituacao.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtSituacao.TabIndex = 162;
            this.TxtSituacao.Tag = "";
            this.TxtSituacao.ThemeName = "Office2016Colorful";
            // 
            // OperationSituationList
            // 
            this.OperationSituationList.BackColor = System.Drawing.Color.White;
            this.OperationSituationList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationSituationList.Location = new System.Drawing.Point(28, 149);
            this.OperationSituationList.Name = "OperationSituationList";
            this.OperationSituationList.Size = new System.Drawing.Size(109, 24);
            this.OperationSituationList.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationSituationList.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.OperationSituationList.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.OperationSituationList.Style.EditorStyle.BorderColor = System.Drawing.Color.White;
            this.OperationSituationList.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.OperationSituationList.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OperationSituationList.TabIndex = 165;
            this.OperationSituationList.SelectedIndexChanged += new System.EventHandler(this.OperationSituationList_SelectedIndexChanged);
            // 
            // OperationTypeList
            // 
            this.OperationTypeList.BackColor = System.Drawing.Color.White;
            this.OperationTypeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationTypeList.Location = new System.Drawing.Point(146, 148);
            this.OperationTypeList.Name = "OperationTypeList";
            this.OperationTypeList.Size = new System.Drawing.Size(115, 25);
            this.OperationTypeList.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationTypeList.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.OperationTypeList.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.OperationTypeList.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.OperationTypeList.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OperationTypeList.TabIndex = 166;
            this.OperationTypeList.SelectedIndexChanged += new System.EventHandler(this.OperationTypeList_SelectedIndexChanged);
            // 
            // StockMovementIdTitle
            // 
            this.StockMovementIdTitle.AutoSize = true;
            this.StockMovementIdTitle.Location = new System.Drawing.Point(293, 129);
            this.StockMovementIdTitle.Name = "StockMovementIdTitle";
            this.StockMovementIdTitle.Size = new System.Drawing.Size(98, 13);
            this.StockMovementIdTitle.TabIndex = 168;
            this.StockMovementIdTitle.Text = "Movimentação Nº :";
            // 
            // QueryByStockMovimentId
            // 
            this.QueryByStockMovimentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.QueryByStockMovimentId.BeforeTouchSize = new System.Drawing.Size(120, 29);
            this.QueryByStockMovimentId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.QueryByStockMovimentId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.QueryByStockMovimentId.CanOverrideStyle = true;
            this.QueryByStockMovimentId.CausesValidation = false;
            this.QueryByStockMovimentId.CornerRadius = 4;
            this.QueryByStockMovimentId.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.QueryByStockMovimentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QueryByStockMovimentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.QueryByStockMovimentId.Location = new System.Drawing.Point(296, 145);
            this.QueryByStockMovimentId.MaxLength = 50;
            this.QueryByStockMovimentId.MinimumSize = new System.Drawing.Size(16, 12);
            this.QueryByStockMovimentId.Multiline = true;
            this.QueryByStockMovimentId.Name = "QueryByStockMovimentId";
            this.QueryByStockMovimentId.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.QueryByStockMovimentId.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.QueryByStockMovimentId.Size = new System.Drawing.Size(136, 29);
            this.QueryByStockMovimentId.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.QueryByStockMovimentId.TabIndex = 167;
            this.QueryByStockMovimentId.Tag = "";
            this.QueryByStockMovimentId.ThemeName = "Office2016Colorful";
            this.QueryByStockMovimentId.TextChanged += new System.EventHandler(this.QueryByStockMovementId_TextChanged);
            // 
            // LblOu
            // 
            this.LblOu.AutoSize = true;
            this.LblOu.Location = new System.Drawing.Point(269, 155);
            this.LblOu.Name = "LblOu";
            this.LblOu.Size = new System.Drawing.Size(21, 13);
            this.LblOu.TabIndex = 169;
            this.LblOu.Text = "Ou";
            // 
            // ClearSearchFields
            // 
            this.ClearSearchFields.AutoSize = true;
            this.ClearSearchFields.Location = new System.Drawing.Point(620, 155);
            this.ClearSearchFields.Name = "ClearSearchFields";
            this.ClearSearchFields.Size = new System.Drawing.Size(38, 13);
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
            this.BindingPagination.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackPage,
            this.toolStripSeparator1,
            this.LblPaginationState,
            this.toolStripSeparator2,
            this.NextPage,
            this.toolStripSeparator3,
            this.LblRecordsState});
            this.BindingPagination.Location = new System.Drawing.Point(0, 578);
            this.BindingPagination.MoveFirstItem = null;
            this.BindingPagination.MoveLastItem = null;
            this.BindingPagination.MoveNextItem = null;
            this.BindingPagination.MovePreviousItem = null;
            this.BindingPagination.Name = "BindingPagination";
            this.BindingPagination.PositionItem = null;
            this.BindingPagination.Size = new System.Drawing.Size(1023, 25);
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
            // PageSizeList
            // 
            this.PageSizeList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PageSizeList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageSizeList.Location = new System.Drawing.Point(446, 149);
            this.PageSizeList.Name = "PageSizeList";
            this.PageSizeList.Size = new System.Drawing.Size(165, 25);
            this.PageSizeList.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PageSizeList.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.PageSizeList.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageSizeList.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageSizeList.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PageSizeList.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageSizeList.TabIndex = 180;
            this.PageSizeList.ToolTipOption.ShadowVisible = false;
            this.PageSizeList.SelectedIndexChanged += new System.EventHandler(this.PageSizeList_SelectedIndexChanged);
            // 
            // TxtOcultNumberOfRecords
            // 
            this.TxtOcultNumberOfRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtOcultNumberOfRecords.BeforeTouchSize = new System.Drawing.Size(120, 29);
            this.TxtOcultNumberOfRecords.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtOcultNumberOfRecords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtOcultNumberOfRecords.CanOverrideStyle = true;
            this.TxtOcultNumberOfRecords.CausesValidation = false;
            this.TxtOcultNumberOfRecords.CornerRadius = 4;
            this.TxtOcultNumberOfRecords.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtOcultNumberOfRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOcultNumberOfRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtOcultNumberOfRecords.Location = new System.Drawing.Point(440, 146);
            this.TxtOcultNumberOfRecords.MaxLength = 50;
            this.TxtOcultNumberOfRecords.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtOcultNumberOfRecords.Multiline = true;
            this.TxtOcultNumberOfRecords.Name = "TxtOcultNumberOfRecords";
            this.TxtOcultNumberOfRecords.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtOcultNumberOfRecords.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtOcultNumberOfRecords.Size = new System.Drawing.Size(174, 29);
            this.TxtOcultNumberOfRecords.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtOcultNumberOfRecords.TabIndex = 182;
            this.TxtOcultNumberOfRecords.Tag = "";
            this.TxtOcultNumberOfRecords.ThemeName = "Office2016Colorful";
            // 
            // PageSizeTitle
            // 
            this.PageSizeTitle.AutoSize = true;
            this.PageSizeTitle.Location = new System.Drawing.Point(439, 132);
            this.PageSizeTitle.Name = "PageSizeTitle";
            this.PageSizeTitle.Size = new System.Drawing.Size(107, 13);
            this.PageSizeTitle.TabIndex = 181;
            this.PageSizeTitle.Text = "Registros por página:";
            // 
            // FrmStockMovementList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 603);
            this.Controls.Add(this.PageSizeList);
            this.Controls.Add(this.TxtOcultNumberOfRecords);
            this.Controls.Add(this.PageSizeTitle);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.ClearSearchFields);
            this.Controls.Add(this.LblOu);
            this.Controls.Add(this.StockMovementIdTitle);
            this.Controls.Add(this.QueryByStockMovimentId);
            this.Controls.Add(this.OperationTypeList);
            this.Controls.Add(this.OperationSituationList);
            this.Controls.Add(this.OperationSituationTitle);
            this.Controls.Add(this.TxtSituacao);
            this.Controls.Add(this.OperationTypeTitle);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.ImageLoading);
            this.Controls.Add(this.PanelUpperHorizontal);
            this.Controls.Add(this.StockMovementList);
            this.Name = "FrmStockMovementList";
            this.Load += new System.EventHandler(this.FrmStockMovementList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockMovementList)).EndInit();
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationSituationList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationTypeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QueryByStockMovimentId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PageSizeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtOcultNumberOfRecords)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockMovementList;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        public System.Windows.Forms.Label TodayIsDay;
        public System.Windows.Forms.Label FormTitle;
        private System.Windows.Forms.Timer QueryTimer;
        private System.Windows.Forms.PictureBox ImageLoading;
        private Syncfusion.WinForms.Controls.SfButton UpdateList;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtTipo;
        private System.Windows.Forms.Label OperationTypeTitle;
        private System.Windows.Forms.Label OperationSituationTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtSituacao;
        private Syncfusion.WinForms.ListView.SfComboBox OperationSituationList;
        private Syncfusion.WinForms.ListView.SfComboBox OperationTypeList;
        private System.Windows.Forms.Label StockMovementIdTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt QueryByStockMovimentId;
        private System.Windows.Forms.Label LblOu;
        private System.Windows.Forms.LinkLabel ClearSearchFields;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private Syncfusion.WinForms.ListView.SfComboBox PageSizeList;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtOcultNumberOfRecords;
        private System.Windows.Forms.Label PageSizeTitle;
    }
}