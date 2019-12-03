namespace DimStock.View
{
    partial class FrmUserList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserList));
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnUpdateList = new Syncfusion.WinForms.Controls.SfButton();
            this.BtnNew = new Syncfusion.WinForms.Controls.SfButton();
            this.LblTodayIsDay = new System.Windows.Forms.Label();
            this.LblFormTitle = new System.Windows.Forms.Label();
            this.GridUserList = new System.Windows.Forms.DataGridView();
            this.PicLoading = new System.Windows.Forms.PictureBox();
            this.TxtQueryByUser = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblQueryByUser = new System.Windows.Forms.Label();
            this.TimerExecuteQuery = new System.Windows.Forms.Timer(this.components);
            this.PanelUpperHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUserList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByUser)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.BtnUpdateList);
            this.PanelUpperHorizontal.Controls.Add(this.BtnNew);
            this.PanelUpperHorizontal.Controls.Add(this.LblTodayIsDay);
            this.PanelUpperHorizontal.Controls.Add(this.LblFormTitle);
            this.PanelUpperHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpperHorizontal.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelUpperHorizontal.GradientTopLeft = System.Drawing.SystemColors.ControlText;
            this.PanelUpperHorizontal.GradientTopRight = System.Drawing.SystemColors.ControlText;
            this.PanelUpperHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PanelUpperHorizontal.Name = "PanelUpperHorizontal";
            this.PanelUpperHorizontal.Quality = 10;
            this.PanelUpperHorizontal.Size = new System.Drawing.Size(1035, 100);
            this.PanelUpperHorizontal.TabIndex = 141;
            // 
            // BtnUpdateList
            // 
            this.BtnUpdateList.AccessibleName = "Button";
            this.BtnUpdateList.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUpdateList.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnUpdateList.ForeColor = System.Drawing.Color.White;
            this.BtnUpdateList.Location = new System.Drawing.Point(101, 50);
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
            this.BtnUpdateList.TabIndex = 143;
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
            this.BtnNew.Location = new System.Drawing.Point(18, 50);
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
            this.BtnNew.TabIndex = 142;
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
            this.LblTodayIsDay.Location = new System.Drawing.Point(574, 24);
            this.LblTodayIsDay.Name = "LblTodayIsDay";
            this.LblTodayIsDay.Size = new System.Drawing.Size(455, 40);
            this.LblTodayIsDay.TabIndex = 139;
            this.LblTodayIsDay.Text = "Data de hoje";
            this.LblTodayIsDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblFormTitle
            // 
            this.LblFormTitle.AutoSize = true;
            this.LblFormTitle.BackColor = System.Drawing.Color.Transparent;
            this.LblFormTitle.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFormTitle.ForeColor = System.Drawing.Color.White;
            this.LblFormTitle.Location = new System.Drawing.Point(10, 7);
            this.LblFormTitle.Name = "LblFormTitle";
            this.LblFormTitle.Size = new System.Drawing.Size(267, 40);
            this.LblFormTitle.TabIndex = 138;
            this.LblFormTitle.Text = "Lista de Usuários";
            // 
            // GridUserList
            // 
            this.GridUserList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridUserList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUserList.Location = new System.Drawing.Point(31, 176);
            this.GridUserList.Name = "GridUserList";
            this.GridUserList.Size = new System.Drawing.Size(980, 441);
            this.GridUserList.TabIndex = 142;
            this.GridUserList.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridUserList_CellMouseClick);
            this.GridUserList.CellMouseMove += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GridUserList_CellMouseMove);
            // 
            // PicLoading
            // 
            this.PicLoading.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PicLoading.Image = global::DimStock.Properties.Resources.Load;
            this.PicLoading.Location = new System.Drawing.Point(456, 313);
            this.PicLoading.Name = "PicLoading";
            this.PicLoading.Size = new System.Drawing.Size(129, 133);
            this.PicLoading.TabIndex = 143;
            this.PicLoading.TabStop = false;
            this.PicLoading.Visible = false;
            // 
            // TxtQueryByUser
            // 
            this.TxtQueryByUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtQueryByUser.BeforeTouchSize = new System.Drawing.Size(304, 29);
            this.TxtQueryByUser.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtQueryByUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtQueryByUser.CanOverrideStyle = true;
            this.TxtQueryByUser.CausesValidation = false;
            this.TxtQueryByUser.CornerRadius = 4;
            this.TxtQueryByUser.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtQueryByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtQueryByUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtQueryByUser.Location = new System.Drawing.Point(31, 141);
            this.TxtQueryByUser.MaxLength = 2000;
            this.TxtQueryByUser.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtQueryByUser.Multiline = true;
            this.TxtQueryByUser.Name = "TxtQueryByUser";
            this.TxtQueryByUser.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtQueryByUser.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtQueryByUser.Size = new System.Drawing.Size(304, 29);
            this.TxtQueryByUser.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtQueryByUser.TabIndex = 144;
            this.TxtQueryByUser.Tag = "";
            this.TxtQueryByUser.ThemeName = "Office2016White";
            this.TxtQueryByUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQueryByUser_KeyPress);
            // 
            // LblQueryByUser
            // 
            this.LblQueryByUser.AutoSize = true;
            this.LblQueryByUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQueryByUser.Location = new System.Drawing.Point(28, 122);
            this.LblQueryByUser.Name = "LblQueryByUser";
            this.LblQueryByUser.Size = new System.Drawing.Size(53, 16);
            this.LblQueryByUser.TabIndex = 145;
            this.LblQueryByUser.Text = "Buscar:";
            // 
            // TimerExecuteQuery
            // 
            this.TimerExecuteQuery.Interval = 1000;
            this.TimerExecuteQuery.Tick += new System.EventHandler(this.TimeExecuteQuery_Tick);
            // 
            // FrmUserList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 629);
            this.Controls.Add(this.PicLoading);
            this.Controls.Add(this.TxtQueryByUser);
            this.Controls.Add(this.LblQueryByUser);
            this.Controls.Add(this.GridUserList);
            this.Controls.Add(this.PanelUpperHorizontal);
            this.Name = "FrmUserList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUserList_Load);
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUserList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtQueryByUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        public System.Windows.Forms.Label LblTodayIsDay;
        public System.Windows.Forms.Label LblFormTitle;
        private System.Windows.Forms.DataGridView GridUserList;
        private System.Windows.Forms.PictureBox PicLoading;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtQueryByUser;
        private System.Windows.Forms.Label LblQueryByUser;
        private System.Windows.Forms.Timer TimerExecuteQuery;
        private Syncfusion.WinForms.Controls.SfButton BtnNew;
        private Syncfusion.WinForms.Controls.SfButton BtnUpdateList;
    }
}