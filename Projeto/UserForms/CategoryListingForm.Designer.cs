namespace DimStock.UserForms
{
    partial class CategoryListingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryListingForm));
            this.DatagridCategory = new System.Windows.Forms.DataGridView();
            this.BindingPagination = new System.Windows.Forms.BindingNavigator(this.components);
            this.BackPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.LblPaginationState = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.NextPage = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.LblRecordsState = new System.Windows.Forms.ToolStripLabel();
            this.PictureLoading = new System.Windows.Forms.PictureBox();
            this.ComboBoxRecordsByPage = new Syncfusion.WinForms.ListView.SfComboBox();
            this.TextSearchByDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TitleRecordsByPage = new System.Windows.Forms.Label();
            this.TitleSearchByDescription = new System.Windows.Forms.Label();
            this.ButtonDataList = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonNewRegister = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).BeginInit();
            this.BindingPagination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRecordsByPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // DatagridCategory
            // 
            this.DatagridCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatagridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatagridCategory.Location = new System.Drawing.Point(12, 133);
            this.DatagridCategory.Name = "DatagridCategory";
            this.DatagridCategory.Size = new System.Drawing.Size(904, 390);
            this.DatagridCategory.TabIndex = 0;
            this.DatagridCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridCategory_CellClick);
            this.DatagridCategory.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DatagridCategory_CellMouseEnter);
            this.DatagridCategory.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.DatagridCategory_RowPrePaint);
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
            // PictureLoading
            // 
            this.PictureLoading.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PictureLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.PictureLoading.Location = new System.Drawing.Point(353, 252);
            this.PictureLoading.Name = "PictureLoading";
            this.PictureLoading.Size = new System.Drawing.Size(135, 135);
            this.PictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLoading.TabIndex = 180;
            this.PictureLoading.TabStop = false;
            this.PictureLoading.Visible = false;
            // 
            // ComboBoxRecordsByPage
            // 
            this.ComboBoxRecordsByPage.BackColor = System.Drawing.Color.White;
            this.ComboBoxRecordsByPage.CanOverrideStyle = true;
            this.ComboBoxRecordsByPage.DropDownStyle = Syncfusion.WinForms.ListView.Enums.DropDownStyle.DropDownList;
            this.ComboBoxRecordsByPage.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxRecordsByPage.Location = new System.Drawing.Point(383, 100);
            this.ComboBoxRecordsByPage.Name = "ComboBoxRecordsByPage";
            this.ComboBoxRecordsByPage.Size = new System.Drawing.Size(160, 27);
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
            this.ComboBoxRecordsByPage.TabIndex = 182;
            this.ComboBoxRecordsByPage.ToolTipOption.ShadowVisible = false;
            this.ComboBoxRecordsByPage.SelectedIndexChanged += new System.EventHandler(this.ComboBoxRecordsByPage_SelectedIndexChanged);
            // 
            // TextSearchByDescription
            // 
            this.TextSearchByDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextSearchByDescription.BeforeTouchSize = new System.Drawing.Size(365, 27);
            this.TextSearchByDescription.BorderColor = System.Drawing.Color.DarkGray;
            this.TextSearchByDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSearchByDescription.CanOverrideStyle = true;
            this.TextSearchByDescription.CausesValidation = false;
            this.TextSearchByDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSearchByDescription.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearchByDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextSearchByDescription.Location = new System.Drawing.Point(12, 100);
            this.TextSearchByDescription.MaxLength = 50;
            this.TextSearchByDescription.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TextSearchByDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextSearchByDescription.Multiline = true;
            this.TextSearchByDescription.Name = "TextSearchByDescription";
            this.TextSearchByDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextSearchByDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextSearchByDescription.Size = new System.Drawing.Size(365, 27);
            this.TextSearchByDescription.TabIndex = 181;
            this.TextSearchByDescription.Tag = "";
            this.TextSearchByDescription.ThemeName = "Default";
            this.TextSearchByDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextSearchByDescription_KeyPress);
            // 
            // TitleRecordsByPage
            // 
            this.TitleRecordsByPage.AutoSize = true;
            this.TitleRecordsByPage.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.TitleRecordsByPage.Location = new System.Drawing.Point(380, 81);
            this.TitleRecordsByPage.Name = "TitleRecordsByPage";
            this.TitleRecordsByPage.Size = new System.Drawing.Size(134, 18);
            this.TitleRecordsByPage.TabIndex = 184;
            this.TitleRecordsByPage.Text = "Registros Por Página:";
            // 
            // TitleSearchByDescription
            // 
            this.TitleSearchByDescription.AutoSize = true;
            this.TitleSearchByDescription.Font = new System.Drawing.Font("Calibri Light", 11F);
            this.TitleSearchByDescription.Location = new System.Drawing.Point(9, 81);
            this.TitleSearchByDescription.Name = "TitleSearchByDescription";
            this.TitleSearchByDescription.Size = new System.Drawing.Size(69, 18);
            this.TitleSearchByDescription.TabIndex = 183;
            this.TitleSearchByDescription.Text = "Descrição:";
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
            this.ButtonDataList.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDataList.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonDataList.IdleBorderThickness = 1;
            this.ButtonDataList.IdleCornerRadius = 10;
            this.ButtonDataList.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDataList.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDataList.Location = new System.Drawing.Point(111, 19);
            this.ButtonDataList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDataList.Name = "ButtonDataList";
            this.ButtonDataList.Size = new System.Drawing.Size(97, 43);
            this.ButtonDataList.TabIndex = 213;
            this.ButtonDataList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDataList.Click += new System.EventHandler(this.ButtonDataList_Click);
            // 
            // ButtonNewRegister
            // 
            this.ButtonNewRegister.ActiveBorderThickness = 1;
            this.ButtonNewRegister.ActiveCornerRadius = 10;
            this.ButtonNewRegister.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonNewRegister.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonNewRegister.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonNewRegister.BackColor = System.Drawing.Color.White;
            this.ButtonNewRegister.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonNewRegister.BackgroundImage")));
            this.ButtonNewRegister.ButtonText = "Novo";
            this.ButtonNewRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonNewRegister.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNewRegister.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonNewRegister.IdleBorderThickness = 1;
            this.ButtonNewRegister.IdleCornerRadius = 10;
            this.ButtonNewRegister.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonNewRegister.IdleForecolor = System.Drawing.Color.White;
            this.ButtonNewRegister.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonNewRegister.Location = new System.Drawing.Point(12, 19);
            this.ButtonNewRegister.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonNewRegister.Name = "ButtonNewRegister";
            this.ButtonNewRegister.Size = new System.Drawing.Size(97, 43);
            this.ButtonNewRegister.TabIndex = 212;
            this.ButtonNewRegister.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonNewRegister.Click += new System.EventHandler(this.ButtonNewRegister_Click);
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 500;
            this.SearchTimer.Tick += new System.EventHandler(this.SearchTimer_Tick);
            // 
            // ProductCategoryListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.ButtonDataList);
            this.Controls.Add(this.ButtonNewRegister);
            this.Controls.Add(this.ComboBoxRecordsByPage);
            this.Controls.Add(this.TextSearchByDescription);
            this.Controls.Add(this.TitleRecordsByPage);
            this.Controls.Add(this.TitleSearchByDescription);
            this.Controls.Add(this.PictureLoading);
            this.Controls.Add(this.BindingPagination);
            this.Controls.Add(this.DatagridCategory);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "ProductCategoryListingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.ProductCategoryListingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DatagridCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingPagination)).EndInit();
            this.BindingPagination.ResumeLayout(false);
            this.BindingPagination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboBoxRecordsByPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSearchByDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatagridCategory;
        private System.Windows.Forms.BindingNavigator BindingPagination;
        private System.Windows.Forms.ToolStripButton BackPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel LblPaginationState;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton NextPage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel LblRecordsState;
        private System.Windows.Forms.PictureBox PictureLoading;
        private Syncfusion.WinForms.ListView.SfComboBox ComboBoxRecordsByPage;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextSearchByDescription;
        private System.Windows.Forms.Label TitleRecordsByPage;
        private System.Windows.Forms.Label TitleSearchByDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDataList;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonNewRegister;
        private System.Windows.Forms.Timer SearchTimer;
    }
}