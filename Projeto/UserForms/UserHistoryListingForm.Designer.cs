namespace DimStock.UserForms
{
    partial class UserHistoryListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHistoryListingForm));
            this.DatagridUserHistory = new System.Windows.Forms.DataGridView();
            this.SearchTitleByLogin = new System.Windows.Forms.Label();
            this.TextSearchByLogin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TextStartDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.StartDateTitle = new System.Windows.Forms.Label();
            this.FinalDateTitle = new System.Windows.Forms.Label();
            this.TextFinalDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.PictureLoading = new System.Windows.Forms.PictureBox();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            this.ComboBoxRecordsByPage = new Syncfusion.WinForms.ListView.SfComboBox();
            this.TitleRecordsByPage = new System.Windows.Forms.Label();
            this.ButtonDataList = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DatagridUserHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRecordsByPage)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridUserHistory
            // 
            this.DatagridUserHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatagridUserHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridUserHistory.Location = new System.Drawing.Point(29, 146);
            this.DatagridUserHistory.Name = "DatagridUserHistory";
            this.DatagridUserHistory.Size = new System.Drawing.Size(871, 377);
            this.DatagridUserHistory.TabIndex = 145;
            this.DatagridUserHistory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridUserHistory_CellMouseEnter);
            // 
            // SearchTitleByLogin
            // 
            this.SearchTitleByLogin.AutoSize = true;
            this.SearchTitleByLogin.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.SearchTitleByLogin.Location = new System.Drawing.Point(27, 94);
            this.SearchTitleByLogin.Name = "SearchTitleByLogin";
            this.SearchTitleByLogin.Size = new System.Drawing.Size(87, 18);
            this.SearchTitleByLogin.TabIndex = 147;
            this.SearchTitleByLogin.Text = "Buscar Login:";
            // 
            // TextSearchByLogin
            // 
            this.TextSearchByLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextSearchByLogin.BeforeTouchSize = new System.Drawing.Size(243, 27);
            this.TextSearchByLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextSearchByLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchByLogin.CanOverrideStyle = true;
            this.TextSearchByLogin.CausesValidation = false;
            this.TextSearchByLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchByLogin.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchByLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSearchByLogin.Location = new System.Drawing.Point(30, 113);
            this.TextSearchByLogin.MaxLength = 50;
            this.TextSearchByLogin.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchByLogin.Multiline = true;
            this.TextSearchByLogin.Name = "TextSearchByLogin";
            this.TextSearchByLogin.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextSearchByLogin.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextSearchByLogin.Size = new System.Drawing.Size(243, 27);
            this.TextSearchByLogin.TabIndex = 146;
            this.TextSearchByLogin.Tag = "";
            this.TextSearchByLogin.ThemeName = "Default";
            this.TextSearchByLogin.TextChanged += new System.EventHandler(this.TextSearchByLogin_TextChanged);
            // 
            // TextStartDate
            // 
            this.TextStartDate.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStartDate.Location = new System.Drawing.Point(276, 113);
            this.TextStartDate.Name = "TextStartDate";
            this.TextStartDate.Size = new System.Drawing.Size(124, 27);
            this.TextStartDate.Style.BorderColor = System.Drawing.Color.Silver;
            this.TextStartDate.Style.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.TextStartDate.Style.ForeColor = System.Drawing.Color.Black;
            this.TextStartDate.Style.HoverBorderColor = System.Drawing.Color.Silver;
            this.TextStartDate.Style.UpDownForeColor = System.Drawing.Color.White;
            this.TextStartDate.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.TextStartDate.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.TextStartDate.TabIndex = 148;
            // 
            // StartDateTitle
            // 
            this.StartDateTitle.AutoSize = true;
            this.StartDateTitle.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.StartDateTitle.Location = new System.Drawing.Point(273, 94);
            this.StartDateTitle.Name = "StartDateTitle";
            this.StartDateTitle.Size = new System.Drawing.Size(75, 18);
            this.StartDateTitle.TabIndex = 144;
            this.StartDateTitle.Text = "Data Inicio:";
            // 
            // FinalDateTitle
            // 
            this.FinalDateTitle.AutoSize = true;
            this.FinalDateTitle.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.FinalDateTitle.Location = new System.Drawing.Point(400, 94);
            this.FinalDateTitle.Name = "FinalDateTitle";
            this.FinalDateTitle.Size = new System.Drawing.Size(71, 18);
            this.FinalDateTitle.TabIndex = 150;
            this.FinalDateTitle.Text = "Data Final:";
            // 
            // TextFinalDate
            // 
            this.TextFinalDate.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFinalDate.Location = new System.Drawing.Point(403, 113);
            this.TextFinalDate.Name = "TextFinalDate";
            this.TextFinalDate.Size = new System.Drawing.Size(121, 27);
            this.TextFinalDate.Style.BorderColor = System.Drawing.Color.Silver;
            this.TextFinalDate.Style.DisabledForeColor = System.Drawing.Color.White;
            this.TextFinalDate.Style.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.TextFinalDate.Style.HoverBorderColor = System.Drawing.Color.Silver;
            this.TextFinalDate.Style.UpDownForeColor = System.Drawing.Color.White;
            this.TextFinalDate.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.TextFinalDate.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.TextFinalDate.TabIndex = 151;
            this.TextFinalDate.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.TextFinalDate_ValueChanged);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // PictureLoading
            // 
            this.PictureLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PictureLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.PictureLoading.Location = new System.Drawing.Point(403, 259);
            this.PictureLoading.Name = "PictureLoading";
            this.PictureLoading.Size = new System.Drawing.Size(135, 135);
            this.PictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureLoading.TabIndex = 152;
            this.PictureLoading.TabStop = false;
            this.PictureLoading.Visible = false;
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
            this.ComboBoxRecordsByPage.BackColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.CanOverrideStyle = true;
            this.ComboBoxRecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.ComboBoxRecordsByPage.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Location = new System.Drawing.Point(527, 113);
            this.ComboBoxRecordsByPage.Name = "ComboBoxRecordsByPage";
            this.ComboBoxRecordsByPage.Size = new System.Drawing.Size(168, 27);
            this.ComboBoxRecordsByPage.Style.DropDownButtonStyle.BackColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.Style.DropDownButtonStyle.DisabledBackColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.Style.DropDownButtonStyle.DisabledForeColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.Style.DropDownButtonStyle.FocusedBackColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.Style.DropDownButtonStyle.HoverBackColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.Style.DropDownButtonStyle.PressedBackColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.Style.DropDownStyle.BorderColor = System.Drawing.Color.Gray;
            this.ComboBoxRecordsByPage.Style.DropDownStyle.GripperForeColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.Style.EditorStyle.BackColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.Style.EditorStyle.BorderColor = System.Drawing.Color.DarkGray;
            this.ComboBoxRecordsByPage.Style.EditorStyle.DisabledBackColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.Style.EditorStyle.DisabledBorderColor = System.Drawing.Color.DarkGray;
            this.ComboBoxRecordsByPage.Style.EditorStyle.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.ComboBoxRecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Style.ReadOnlyEditorStyle.BorderColor = System.Drawing.Color.DarkGray;
            this.ComboBoxRecordsByPage.Style.ReadOnlyEditorStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.ComboBoxRecordsByPage.Style.ReadOnlyEditorStyle.FocusedBorderColor = System.Drawing.Color.Gray;
            this.ComboBoxRecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboBoxRecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.TabIndex = 180;
            this.ComboBoxRecordsByPage.ToolTipOption.ShadowVisible = false;
            this.ComboBoxRecordsByPage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRecordsByPage_SelectedIndexChanged);
            // 
            // TitleRecordsByPage
            // 
            this.TitleRecordsByPage.AutoSize = true;
            this.TitleRecordsByPage.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.TitleRecordsByPage.Location = new System.Drawing.Point(524, 94);
            this.TitleRecordsByPage.Name = "TitleRecordsByPage";
            this.TitleRecordsByPage.Size = new System.Drawing.Size(134, 18);
            this.TitleRecordsByPage.TabIndex = 181;
            this.TitleRecordsByPage.Text = "Registros Por Página:";
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
            this.ButtonDataList.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonDataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonDataList.IdleBorderThickness = 1;
            this.ButtonDataList.IdleCornerRadius = 10;
            this.ButtonDataList.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDataList.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.Location = new System.Drawing.Point(29, 25);
            this.ButtonDataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDataList.Name = "ButtonDataList";
            this.ButtonDataList.Size = new System.Drawing.Size(97, 43);
            this.ButtonDataList.TabIndex = 218;
            this.ButtonDataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDataList.Click += new System.EventHandler(this.ButtonDataList_Click);
            // 
            // UserHistoryListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.ButtonDataList);
            this.Controls.Add(this.ComboBoxRecordsByPage);
            this.Controls.Add(this.TitleRecordsByPage);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.PictureLoading);
            this.Controls.Add(this.TextFinalDate);
            this.Controls.Add(this.FinalDateTitle);
            this.Controls.Add(this.TextStartDate);
            this.Controls.Add(this.SearchTitleByLogin);
            this.Controls.Add(this.TextSearchByLogin);
            this.Controls.Add(this.DatagridUserHistory);
            this.Controls.Add(this.StartDateTitle);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "UserHistoryListingForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.UserHistoryListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridUserHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRecordsByPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DatagridUserHistory;
        private System.Windows.Forms.Label SearchTitleByLogin;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchByLogin;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TextStartDate;
        private System.Windows.Forms.Label StartDateTitle;
        private System.Windows.Forms.Label FinalDateTitle;
        private Syncfusion.WinForms.Input.SfDateTimeEdit TextFinalDate;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.PictureBox PictureLoading;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBoxRecordsByPage;
        private System.Windows.Forms.Label TitleRecordsByPage;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDataList;
    }
}