namespace DimStock.View
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
            this.UpdateDataList = new Syncfusion.WinForms.Controls.SfButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.MovementStockDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationSituation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByStockMovimentId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).BeginInit();
            this.SuspendLayout();
            // 
            // MovementStockDataList
            // 
            this.MovementStockDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MovementStockDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovementStockDataList.Location = new System.Drawing.Point(19, 139);
            this.MovementStockDataList.Name = "MovementStockDataList";
            this.MovementStockDataList.Size = new System.Drawing.Size(992, 407);
            this.MovementStockDataList.TabIndex = 0;
            this.MovementStockDataList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MovementStockDataList_CellClick);
            this.MovementStockDataList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MovementStockDataList_CellMouseMove);
            // 
            // UpdateDataList
            // 
            this.UpdateDataList.AccessibleName = "Button";
            this.UpdateDataList.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateDataList.ForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Location = new System.Drawing.Point(21, 25);
            this.UpdateDataList.Name = "UpdateDataList";
            this.UpdateDataList.Size = new System.Drawing.Size(80, 35);
            this.UpdateDataList.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.FocusedForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Style.ForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.HoverForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.Style.PressedForeColor = System.Drawing.Color.White;
            this.UpdateDataList.TabIndex = 140;
            this.UpdateDataList.Text = "Atualizar";
            this.UpdateDataList.UseVisualStyleBackColor = false;
            this.UpdateDataList.Click += new System.EventHandler(this.UpdateDataList_Click);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GifLoading.Image = global::DimStock.Properties.Resources.GigLoading;
            this.GifLoading.Location = new System.Drawing.Point(432, 259);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(169, 167);
            this.GifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GifLoading.TabIndex = 159;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
            // 
            // OperationTypeTitle
            // 
            this.OperationTypeTitle.AutoSize = true;
            this.OperationTypeTitle.Location = new System.Drawing.Point(128, 90);
            this.OperationTypeTitle.Name = "OperationTypeTitle";
            this.OperationTypeTitle.Size = new System.Drawing.Size(31, 13);
            this.OperationTypeTitle.TabIndex = 161;
            this.OperationTypeTitle.Text = "Tipo:";
            // 
            // OperationSituationTitle
            // 
            this.OperationSituationTitle.AutoSize = true;
            this.OperationSituationTitle.Location = new System.Drawing.Point(18, 90);
            this.OperationSituationTitle.Name = "OperationSituationTitle";
            this.OperationSituationTitle.Size = new System.Drawing.Size(52, 13);
            this.OperationSituationTitle.TabIndex = 163;
            this.OperationSituationTitle.Text = "Situação:";
            // 
            // OperationSituation
            // 
            this.OperationSituation.BackColor = System.Drawing.Color.White;
            this.OperationSituation.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.OperationSituation.Location = new System.Drawing.Point(21, 106);
            this.OperationSituation.Name = "OperationSituation";
            this.OperationSituation.Size = new System.Drawing.Size(109, 27);
            this.OperationSituation.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.OperationSituation.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OperationSituation.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.OperationSituation.Style.EditorStyle.BorderColor = System.Drawing.Color.Gray;
            this.OperationSituation.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.OperationSituation.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OperationSituation.TabIndex = 165;
            this.OperationSituation.SelectedIndexChanged += new System.EventHandler(this.OperationSituation_SelectedIndexChanged);
            // 
            // OperationType
            // 
            this.OperationType.BackColor = System.Drawing.Color.White;
            this.OperationType.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.OperationType.Location = new System.Drawing.Point(134, 106);
            this.OperationType.Name = "OperationType";
            this.OperationType.Size = new System.Drawing.Size(115, 27);
            this.OperationType.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OperationType.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.OperationType.Style.DropDownStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.OperationType.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.OperationType.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.White;
            this.OperationType.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.OperationType.TabIndex = 166;
            this.OperationType.SelectedIndexChanged += new System.EventHandler(this.OperationType_SelectedIndexChanged);
            // 
            // StockMovementIdTitle
            // 
            this.StockMovementIdTitle.AutoSize = true;
            this.StockMovementIdTitle.Location = new System.Drawing.Point(249, 90);
            this.StockMovementIdTitle.Name = "StockMovementIdTitle";
            this.StockMovementIdTitle.Size = new System.Drawing.Size(98, 13);
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
            this.SearchByStockMovimentId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByStockMovimentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByStockMovimentId.Location = new System.Drawing.Point(252, 106);
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
            this.ClearSearchFields.Location = new System.Drawing.Point(563, 113);
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
            // RecordsByPage
            // 
            this.RecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.RecordsByPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Location = new System.Drawing.Point(391, 106);
            this.RecordsByPage.Name = "RecordsByPage";
            this.RecordsByPage.Size = new System.Drawing.Size(165, 27);
            this.RecordsByPage.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordsByPage.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.Transparent;
            this.RecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.TabIndex = 180;
            this.RecordsByPage.ToolTipOption.ShadowVisible = false;
            this.RecordsByPage.SelectedIndexChanged += new System.EventHandler(this.RecordsByPage_SelectedIndexChanged);
            // 
            // RecordsOfPageTitle
            // 
            this.RecordsOfPageTitle.AutoSize = true;
            this.RecordsOfPageTitle.Location = new System.Drawing.Point(388, 90);
            this.RecordsOfPageTitle.Name = "RecordsOfPageTitle";
            this.RecordsOfPageTitle.Size = new System.Drawing.Size(107, 13);
            this.RecordsOfPageTitle.TabIndex = 181;
            this.RecordsOfPageTitle.Text = "Registros por página:";
            // 
            // StockMovementListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1023, 603);
            this.Controls.Add(this.UpdateDataList);
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
            this.Controls.Add(this.GifLoading);
            this.Controls.Add(this.MovementStockDataList);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView MovementStockDataList;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.PictureBox GifLoading;
        private Syncfusion.WinForms.Controls.SfButton UpdateDataList;
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
    }
}