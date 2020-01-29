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
            this.HistoryDataList = new System.Windows.Forms.DataGridView();
            this.SearchTitleByLogin = new System.Windows.Forms.Label();
            this.SearchByLogin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.StartDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.StartDateTitle = new System.Windows.Forms.Label();
            this.FinalDateTitle = new System.Windows.Forms.Label();
            this.FinalDate = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.GifLoading = new System.Windows.Forms.PictureBox();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            this.RecordsByPage = new Syncfusion.WinForms.ListView.SfComboBox();
            this.TitleRecordsByPage = new System.Windows.Forms.Label();
            this.DataList = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).BeginInit();
            this.SuspendLayout();
            // 
            // HistoryDataList
            // 
            this.HistoryDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HistoryDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.HistoryDataList.Location = new System.Drawing.Point(29, 146);
            this.HistoryDataList.Name = "HistoryDataList";
            this.HistoryDataList.Size = new System.Drawing.Size(907, 508);
            this.HistoryDataList.TabIndex = 145;
            this.HistoryDataList.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.HistoryDataList_CellMouseEnter);
            // 
            // SearchTitleByLogin
            // 
            this.SearchTitleByLogin.AutoSize = true;
            this.SearchTitleByLogin.Location = new System.Drawing.Point(27, 99);
            this.SearchTitleByLogin.Name = "SearchTitleByLogin";
            this.SearchTitleByLogin.Size = new System.Drawing.Size(72, 13);
            this.SearchTitleByLogin.TabIndex = 147;
            this.SearchTitleByLogin.Text = "Buscar Login:";
            // 
            // SearchByLogin
            // 
            this.SearchByLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SearchByLogin.BeforeTouchSize = new System.Drawing.Size(136, 27);
            this.SearchByLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.SearchByLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchByLogin.CanOverrideStyle = true;
            this.SearchByLogin.CausesValidation = false;
            this.SearchByLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SearchByLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchByLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.SearchByLogin.Location = new System.Drawing.Point(30, 113);
            this.SearchByLogin.MaxLength = 50;
            this.SearchByLogin.MinimumSize = new System.Drawing.Size(16, 12);
            this.SearchByLogin.Multiline = true;
            this.SearchByLogin.Name = "SearchByLogin";
            this.SearchByLogin.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.SearchByLogin.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.SearchByLogin.Size = new System.Drawing.Size(136, 27);
            this.SearchByLogin.TabIndex = 146;
            this.SearchByLogin.Tag = "";
            this.SearchByLogin.ThemeName = "Default";
            this.SearchByLogin.TextChanged += new System.EventHandler(this.SearchByLogin_TextChanged);
            // 
            // StartDate
            // 
            this.StartDate.Location = new System.Drawing.Point(169, 113);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(124, 27);
            this.StartDate.Style.BorderColor = System.Drawing.Color.Silver;
            this.StartDate.Style.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.StartDate.Style.ForeColor = System.Drawing.Color.Black;
            this.StartDate.Style.HoverBorderColor = System.Drawing.Color.Silver;
            this.StartDate.Style.UpDownForeColor = System.Drawing.Color.White;
            this.StartDate.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.StartDate.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.StartDate.TabIndex = 148;
            // 
            // StartDateTitle
            // 
            this.StartDateTitle.AutoSize = true;
            this.StartDateTitle.Location = new System.Drawing.Point(166, 99);
            this.StartDateTitle.Name = "StartDateTitle";
            this.StartDateTitle.Size = new System.Drawing.Size(61, 13);
            this.StartDateTitle.TabIndex = 144;
            this.StartDateTitle.Text = "Data Inicio:";
            // 
            // FinalDateTitle
            // 
            this.FinalDateTitle.AutoSize = true;
            this.FinalDateTitle.Location = new System.Drawing.Point(293, 99);
            this.FinalDateTitle.Name = "FinalDateTitle";
            this.FinalDateTitle.Size = new System.Drawing.Size(58, 13);
            this.FinalDateTitle.TabIndex = 150;
            this.FinalDateTitle.Text = "Data Final:";
            // 
            // FinalDate
            // 
            this.FinalDate.Location = new System.Drawing.Point(296, 113);
            this.FinalDate.Name = "FinalDate";
            this.FinalDate.Size = new System.Drawing.Size(121, 27);
            this.FinalDate.Style.BorderColor = System.Drawing.Color.Silver;
            this.FinalDate.Style.DisabledForeColor = System.Drawing.Color.White;
            this.FinalDate.Style.FocusedBorderColor = System.Drawing.Color.DarkGray;
            this.FinalDate.Style.HoverBorderColor = System.Drawing.Color.Silver;
            this.FinalDate.Style.UpDownForeColor = System.Drawing.Color.White;
            this.FinalDate.Style.UpDownHoverForeColor = System.Drawing.Color.White;
            this.FinalDate.Style.WatermarkForeColor = System.Drawing.Color.White;
            this.FinalDate.TabIndex = 151;
            this.FinalDate.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.FinalDate_ValueChanged);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // GifLoading
            // 
            this.GifLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GifLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.GifLoading.Location = new System.Drawing.Point(394, 330);
            this.GifLoading.Name = "GifLoading";
            this.GifLoading.Size = new System.Drawing.Size(176, 175);
            this.GifLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GifLoading.TabIndex = 152;
            this.GifLoading.TabStop = false;
            this.GifLoading.Visible = false;
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
            this.RecordsByPage.BackColor = System.Drawing.Color.White;
            this.RecordsByPage.CanOverrideStyle = true;
            this.RecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.RecordsByPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Location = new System.Drawing.Point(420, 113);
            this.RecordsByPage.Name = "RecordsByPage";
            this.RecordsByPage.Size = new System.Drawing.Size(136, 27);
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
            this.RecordsByPage.Style.EditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.ReadOnlyEditorStyle.BorderColor = System.Drawing.Color.DarkGray;
            this.RecordsByPage.Style.ReadOnlyEditorStyle.DisabledBackColor = System.Drawing.Color.Gray;
            this.RecordsByPage.Style.ReadOnlyEditorStyle.FocusedBorderColor = System.Drawing.Color.Gray;
            this.RecordsByPage.Style.ReadOnlyEditorStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.Style.TokenStyle.CloseButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RecordsByPage.Style.TokenStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecordsByPage.TabIndex = 180;
            this.RecordsByPage.ToolTipOption.ShadowVisible = false;
            this.RecordsByPage.SelectedIndexChanged += new System.EventHandler(this.RecordsByPage_SelectedIndexChanged);
            // 
            // TitleRecordsByPage
            // 
            this.TitleRecordsByPage.AutoSize = true;
            this.TitleRecordsByPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TitleRecordsByPage.Location = new System.Drawing.Point(417, 99);
            this.TitleRecordsByPage.Name = "TitleRecordsByPage";
            this.TitleRecordsByPage.Size = new System.Drawing.Size(109, 13);
            this.TitleRecordsByPage.TabIndex = 181;
            this.TitleRecordsByPage.Text = "Registros Por Página:";
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
            this.DataList.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.DataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.DataList.IdleBorderThickness = 1;
            this.DataList.IdleCornerRadius = 10;
            this.DataList.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.DataList.IdleForecolor = System.Drawing.Color.White;
            this.DataList.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.DataList.Location = new System.Drawing.Point(29, 25);
            this.DataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(97, 43);
            this.DataList.TabIndex = 218;
            this.DataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataList.Click += new System.EventHandler(this.DataList_Click);
            // 
            // UserHistoryListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.DataList);
            this.Controls.Add(this.RecordsByPage);
            this.Controls.Add(this.TitleRecordsByPage);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.GifLoading);
            this.Controls.Add(this.FinalDate);
            this.Controls.Add(this.FinalDateTitle);
            this.Controls.Add(this.StartDate);
            this.Controls.Add(this.SearchTitleByLogin);
            this.Controls.Add(this.SearchByLogin);
            this.Controls.Add(this.HistoryDataList);
            this.Controls.Add(this.StartDateTitle);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "UserHistoryListingForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.UserHistoryListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HistoryDataList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchByLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GifLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RecordsByPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView HistoryDataList;
        private System.Windows.Forms.Label SearchTitleByLogin;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt SearchByLogin;
        private Syncfusion.WinForms.Input.SfDateTimeEdit StartDate;
        private System.Windows.Forms.Label StartDateTitle;
        private System.Windows.Forms.Label FinalDateTitle;
        private Syncfusion.WinForms.Input.SfDateTimeEdit FinalDate;
        private System.Windows.Forms.Timer SearchTimer;
        private System.Windows.Forms.PictureBox GifLoading;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private Syncfusion.WinForms.ListView.SfComboBox RecordsByPage;
        private System.Windows.Forms.Label TitleRecordsByPage;
        private Bunifu.Framework.UI.BunifuThinButton2 DataList;
    }
}