namespace DimStock.View
{
    partial class FrmStockActivityList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmStockActivityList));
            this.GridActivityList = new System.Windows.Forms.DataGridView();
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnUpdateList = new Syncfusion.WinForms.Controls.SfButton();
            this.LblToDayIsDay = new System.Windows.Forms.Label();
            this.LblFormTitle = new System.Windows.Forms.Label();
            this.TimerExecuteQuery = new System.Windows.Forms.Timer(this.components);
            this.PicLoading = new System.Windows.Forms.PictureBox();
            this.TxtTipo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblActivityType = new System.Windows.Forms.Label();
            this.LblActivitySituation = new System.Windows.Forms.Label();
            this.TxtSituacao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.CboActivitySituation = new Syncfusion.WinForms.ListView.SfComboBox();
            this.CboActivityType = new Syncfusion.WinForms.ListView.SfComboBox();
            this.LblActivityNumber = new System.Windows.Forms.Label();
            this.TxtQueryByActvityNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblOu = new System.Windows.Forms.Label();
            this.LblClear = new System.Windows.Forms.LinkLabel();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GridActivityList)).BeginInit();
            this.PanelUpperHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSituacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboActivitySituation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboActivityType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByActvityNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridActivityList
            // 
            this.GridActivityList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridActivityList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridActivityList.Location = new System.Drawing.Point(19, 181);
            this.GridActivityList.Name = "GridActivityList";
            this.GridActivityList.Size = new System.Drawing.Size(992, 365);
            this.GridActivityList.TabIndex = 0;
            this.GridActivityList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridActivityList_CellClick);
            this.GridActivityList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridActivityList_CellMouseMove);
            // 
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.BtnUpdateList);
            this.PanelUpperHorizontal.Controls.Add(this.LblToDayIsDay);
            this.PanelUpperHorizontal.Controls.Add(this.LblFormTitle);
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
            // BtnUpdateList
            // 
            this.BtnUpdateList.AccessibleName = "Button";
            this.BtnUpdateList.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUpdateList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateList.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Location = new System.Drawing.Point(19, 52);
            this.BtnUpdateList.Name = "BtnUpdateList";
            this.BtnUpdateList.Size = new System.Drawing.Size(80, 35);
            this.BtnUpdateList.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Style.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnUpdateList.Style.HoverForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.TabIndex = 140;
            this.BtnUpdateList.Text = "Atualizar";
            this.BtnUpdateList.UseVisualStyleBackColor = false;
            this.BtnUpdateList.Click += new System.EventHandler(this.BtnUpdateList_Click);
            // 
            // LblToDayIsDay
            // 
            this.LblToDayIsDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblToDayIsDay.BackColor = System.Drawing.Color.Transparent;
            this.LblToDayIsDay.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblToDayIsDay.ForeColor = System.Drawing.Color.White;
            this.LblToDayIsDay.Location = new System.Drawing.Point(450, 27);
            this.LblToDayIsDay.Name = "LblToDayIsDay";
            this.LblToDayIsDay.Size = new System.Drawing.Size(561, 40);
            this.LblToDayIsDay.TabIndex = 139;
            this.LblToDayIsDay.Text = "Entrada de Estoque";
            this.LblToDayIsDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblFormTitle
            // 
            this.LblFormTitle.AutoSize = true;
            this.LblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblFormTitle.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormTitle.ForeColor = System.Drawing.Color.White;
            this.LblFormTitle.Location = new System.Drawing.Point(12, 9);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(424, 40);
            this.LblFormTitle.TabIndex = 138;
            this.LblFormTitle.Text = "Lista Atividades No Estoque";
            // 
            // TimerExecuteQuery
            // 
            this.TimerExecuteQuery.Interval = 1000;
            this.TimerExecuteQuery.Tick += new System.EventHandler(this.TimerExecuteQuery_Tick);
            // 
            // PicLoading
            // 
            this.PicLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLoading.Image = global::DimStock.Properties.Resources.Load;
            this.PicLoading.Location = new System.Drawing.Point(446, 299);
            this.PicLoading.Name = "PicLoading";
            this.PicLoading.Size = new System.Drawing.Size(129, 137);
            this.PicLoading.TabIndex = 159;
            this.PicLoading.TabStop = false;
            this.PicLoading.Visible = false;
            // 
            // TxtTipo
            // 
            this.TxtTipo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtTipo.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtTipo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTipo.CanOverrideStyle = true;
            this.TxtTipo.CausesValidation = false;
            this.TxtTipo.CornerRadius = 4;
            this.TxtTipo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtTipo.Location = new System.Drawing.Point(17, 145);
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
            // LblActivityType
            // 
            this.LblActivityType.AutoSize = true;
            this.LblActivityType.Location = new System.Drawing.Point(14, 130);
            this.LblActivityType.Name = "LblActivityType";
            this.LblActivityType.Size = new System.Drawing.Size(31, 13);
            this.LblActivityType.TabIndex = 161;
            this.LblActivityType.Text = "Tipo:";
            // 
            // LblActivitySituation
            // 
            this.LblActivitySituation.AutoSize = true;
            this.LblActivitySituation.Location = new System.Drawing.Point(135, 129);
            this.LblActivitySituation.Name = "LblActivitySituation";
            this.LblActivitySituation.Size = new System.Drawing.Size(52, 13);
            this.LblActivitySituation.TabIndex = 163;
            this.LblActivitySituation.Text = "Situação:";
            // 
            // TxtSituacao
            // 
            this.TxtSituacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtSituacao.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtSituacao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtSituacao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSituacao.CanOverrideStyle = true;
            this.TxtSituacao.CausesValidation = false;
            this.TxtSituacao.CornerRadius = 4;
            this.TxtSituacao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtSituacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSituacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtSituacao.Location = new System.Drawing.Point(138, 145);
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
            // CboActivitySituation
            // 
            this.CboActivitySituation.BackColor = System.Drawing.Color.White;
            this.CboActivitySituation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboActivitySituation.Location = new System.Drawing.Point(146, 148);
            this.CboActivitySituation.Name = "CboActivitySituation";
            this.CboActivitySituation.Size = new System.Drawing.Size(109, 24);
            this.CboActivitySituation.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboActivitySituation.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.CboActivitySituation.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.CboActivitySituation.Style.EditorStyle.BorderColor = System.Drawing.Color.White;
            this.CboActivitySituation.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.CboActivitySituation.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboActivitySituation.TabIndex = 165;
            this.CboActivitySituation.SelectedIndexChanged += new System.EventHandler(this.CboActivitySituation_SelectedIndexChanged);
            // 
            // CboActivityType
            // 
            this.CboActivityType.BackColor = System.Drawing.Color.White;
            this.CboActivityType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboActivityType.Location = new System.Drawing.Point(20, 147);
            this.CboActivityType.Name = "CboActivityType";
            this.CboActivityType.Size = new System.Drawing.Size(115, 25);
            this.CboActivityType.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CboActivityType.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.CboActivityType.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.CboActivityType.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.CboActivityType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CboActivityType.TabIndex = 166;
            this.CboActivityType.SelectedIndexChanged += new System.EventHandler(this.CboActivityType_SelectedIndexChanged);
            // 
            // LblActivityNumber
            // 
            this.LblActivityNumber.AutoSize = true;
            this.LblActivityNumber.Location = new System.Drawing.Point(288, 129);
            this.LblActivityNumber.Name = "LblActivityNumber";
            this.LblActivityNumber.Size = new System.Drawing.Size(66, 13);
            this.LblActivityNumber.TabIndex = 168;
            this.LblActivityNumber.Text = "Nº Atividade";
            // 
            // TxtQueryByActvityNumber
            // 
            this.TxtQueryByActvityNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryByActvityNumber.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtQueryByActvityNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtQueryByActvityNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByActvityNumber.CanOverrideStyle = true;
            this.TxtQueryByActvityNumber.CausesValidation = false;
            this.TxtQueryByActvityNumber.CornerRadius = 4;
            this.TxtQueryByActvityNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByActvityNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByActvityNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByActvityNumber.Location = new System.Drawing.Point(291, 145);
            this.TxtQueryByActvityNumber.MaxLength = 50;
            this.TxtQueryByActvityNumber.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByActvityNumber.Multiline = true;
            this.TxtQueryByActvityNumber.Name = "TxtQueryByActvityNumber";
            this.TxtQueryByActvityNumber.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtQueryByActvityNumber.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtQueryByActvityNumber.Size = new System.Drawing.Size(136, 29);
            this.TxtQueryByActvityNumber.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtQueryByActvityNumber.TabIndex = 167;
            this.TxtQueryByActvityNumber.Tag = "";
            this.TxtQueryByActvityNumber.ThemeName = "Office2016Colorful";
            this.TxtQueryByActvityNumber.TextChanged += new System.EventHandler(this.TxtQueryByActivityNumber_TextChanged);
            // 
            // LblOu
            // 
            this.LblOu.AutoSize = true;
            this.LblOu.Location = new System.Drawing.Point(264, 155);
            this.LblOu.Name = "LblOu";
            this.LblOu.Size = new System.Drawing.Size(21, 13);
            this.LblOu.TabIndex = 169;
            this.LblOu.Text = "Ou";
            // 
            // LblClear
            // 
            this.LblClear.AutoSize = true;
            this.LblClear.Location = new System.Drawing.Point(437, 154);
            this.LblClear.Name = "LblClear";
            this.LblClear.Size = new System.Drawing.Size(38, 13);
            this.LblClear.TabIndex = 170;
            this.LblClear.TabStop = true;
            this.LblClear.Text = "Limpar";
            this.LblClear.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblClear_LinkClicked);
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
            // FrmStockActivityList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 603);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.LblClear);
            this.Controls.Add(this.LblOu);
            this.Controls.Add(this.LblActivityNumber);
            this.Controls.Add(this.TxtQueryByActvityNumber);
            this.Controls.Add(this.CboActivityType);
            this.Controls.Add(this.CboActivitySituation);
            this.Controls.Add(this.LblActivitySituation);
            this.Controls.Add(this.TxtSituacao);
            this.Controls.Add(this.LblActivityType);
            this.Controls.Add(this.TxtTipo);
            this.Controls.Add(this.PicLoading);
            this.Controls.Add(this.PanelUpperHorizontal);
            this.Controls.Add(this.GridActivityList);
            this.Name = "FrmStockActivityList";
            this.Load += new System.EventHandler(this.FrmStockActivityList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridActivityList)).EndInit();
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSituacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboActivitySituation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CboActivityType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByActvityNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridActivityList;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        public System.Windows.Forms.Label LblToDayIsDay;
        public System.Windows.Forms.Label LblFormTitle;
        private System.Windows.Forms.Timer TimerExecuteQuery;
        private System.Windows.Forms.PictureBox PicLoading;
        private Syncfusion.WinForms.Controls.SfButton BtnUpdateList;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtTipo;
        private System.Windows.Forms.Label LblActivityType;
        private System.Windows.Forms.Label LblActivitySituation;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtSituacao;
        private Syncfusion.WinForms.ListView.SfComboBox CboActivitySituation;
        private Syncfusion.WinForms.ListView.SfComboBox CboActivityType;
        private System.Windows.Forms.Label LblActivityNumber;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByActvityNumber;
        private System.Windows.Forms.Label LblOu;
        private System.Windows.Forms.LinkLabel LblClear;
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