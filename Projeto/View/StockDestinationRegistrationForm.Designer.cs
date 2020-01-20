namespace DimStock.View
{
    partial class StockDestinationRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockDestinationRegistrationForm));
            this.DestinationLocationTitle = new System.Windows.Forms.Label();
            this.DestinationLocation = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.DestinationDataList = new System.Windows.Forms.DataGridView();
            this.RegisterNew = new System.Windows.Forms.Button();
            this.ChangeRegister = new System.Windows.Forms.Button();
            this.ExcludeRegister = new System.Windows.Forms.Button();
            this.UpdateDataList = new System.Windows.Forms.Button();
            this.PanelUpperHorizontal = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DayOfTheWeek = new System.Windows.Forms.Label();
            this.FormCaption = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationDataList)).BeginInit();
            this.PanelUpperHorizontal.SuspendLayout();
            this.SuspendLayout();
            // 
            // DestinationLocationTitle
            // 
            this.DestinationLocationTitle.AutoSize = true;
            this.DestinationLocationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLocationTitle.ForeColor = System.Drawing.Color.Black;
            this.DestinationLocationTitle.Location = new System.Drawing.Point(9, 108);
            this.DestinationLocationTitle.Name = "DestinationLocationTitle";
            this.DestinationLocationTitle.Size = new System.Drawing.Size(162, 20);
            this.DestinationLocationTitle.TabIndex = 144;
            this.DestinationLocationTitle.Text = "Descrição do destino:";
            // 
            // DestinationLocation
            // 
            this.DestinationLocation.BackColor = System.Drawing.Color.White;
            this.DestinationLocation.BeforeTouchSize = new System.Drawing.Size(90, 27);
            this.DestinationLocation.BorderColor = System.Drawing.Color.Silver;
            this.DestinationLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationLocation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DestinationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DestinationLocation.Location = new System.Drawing.Point(12, 130);
            this.DestinationLocation.MinimumSize = new System.Drawing.Size(14, 10);
            this.DestinationLocation.Name = "DestinationLocation";
            this.DestinationLocation.Size = new System.Drawing.Size(374, 26);
            this.DestinationLocation.TabIndex = 143;
            this.DestinationLocation.ThemeName = "Default";
            // 
            // DestinationDataList
            // 
            this.DestinationDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestinationDataList.Location = new System.Drawing.Point(12, 159);
            this.DestinationDataList.Name = "DestinationDataList";
            this.DestinationDataList.Size = new System.Drawing.Size(987, 366);
            this.DestinationDataList.TabIndex = 145;
            this.DestinationDataList.DoubleClick += new System.EventHandler(this.DestinationDataList_DoubleClick);
            // 
            // RegisterNew
            // 
            this.RegisterNew.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.FlatAppearance.BorderSize = 0;
            this.RegisterNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterNew.ForeColor = System.Drawing.Color.White;
            this.RegisterNew.Location = new System.Drawing.Point(19, 51);
            this.RegisterNew.Name = "RegisterNew";
            this.RegisterNew.Size = new System.Drawing.Size(80, 35);
            this.RegisterNew.TabIndex = 146;
            this.RegisterNew.Text = "Cadastrar";
            this.RegisterNew.UseVisualStyleBackColor = false;
            this.RegisterNew.Click += new System.EventHandler(this.RegisterNew_Click);
            // 
            // ChangeRegister
            // 
            this.ChangeRegister.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChangeRegister.FlatAppearance.BorderSize = 0;
            this.ChangeRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeRegister.ForeColor = System.Drawing.Color.White;
            this.ChangeRegister.Location = new System.Drawing.Point(105, 51);
            this.ChangeRegister.Name = "ChangeRegister";
            this.ChangeRegister.Size = new System.Drawing.Size(80, 35);
            this.ChangeRegister.TabIndex = 147;
            this.ChangeRegister.Text = "Editar";
            this.ChangeRegister.UseVisualStyleBackColor = false;
            this.ChangeRegister.Click += new System.EventHandler(this.ChangeRegister_Click);
            // 
            // ExcludeRegister
            // 
            this.ExcludeRegister.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExcludeRegister.FlatAppearance.BorderSize = 0;
            this.ExcludeRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExcludeRegister.ForeColor = System.Drawing.Color.White;
            this.ExcludeRegister.Location = new System.Drawing.Point(191, 51);
            this.ExcludeRegister.Name = "ExcludeRegister";
            this.ExcludeRegister.Size = new System.Drawing.Size(80, 35);
            this.ExcludeRegister.TabIndex = 148;
            this.ExcludeRegister.Text = "Deletar";
            this.ExcludeRegister.UseVisualStyleBackColor = false;
            this.ExcludeRegister.Click += new System.EventHandler(this.ExcludeRegister_Click);
            // 
            // UpdateDataList
            // 
            this.UpdateDataList.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.UpdateDataList.FlatAppearance.BorderSize = 0;
            this.UpdateDataList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateDataList.ForeColor = System.Drawing.Color.White;
            this.UpdateDataList.Location = new System.Drawing.Point(277, 51);
            this.UpdateDataList.Name = "UpdateDataList";
            this.UpdateDataList.Size = new System.Drawing.Size(80, 35);
            this.UpdateDataList.TabIndex = 149;
            this.UpdateDataList.Text = "Atualizar";
            this.UpdateDataList.UseVisualStyleBackColor = false;
            this.UpdateDataList.Click += new System.EventHandler(this.UpdateDataList_Click);
            // 
            // PanelUpperHorizontal
            // 
            this.PanelUpperHorizontal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelUpperHorizontal.BackgroundImage")));
            this.PanelUpperHorizontal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelUpperHorizontal.Controls.Add(this.DayOfTheWeek);
            this.PanelUpperHorizontal.Controls.Add(this.UpdateDataList);
            this.PanelUpperHorizontal.Controls.Add(this.ExcludeRegister);
            this.PanelUpperHorizontal.Controls.Add(this.FormCaption);
            this.PanelUpperHorizontal.Controls.Add(this.ChangeRegister);
            this.PanelUpperHorizontal.Controls.Add(this.RegisterNew);
            this.PanelUpperHorizontal.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUpperHorizontal.GradientBottomLeft = System.Drawing.Color.Black;
            this.PanelUpperHorizontal.GradientBottomRight = System.Drawing.Color.Black;
            this.PanelUpperHorizontal.GradientTopLeft = System.Drawing.Color.Gray;
            this.PanelUpperHorizontal.GradientTopRight = System.Drawing.Color.Gray;
            this.PanelUpperHorizontal.Location = new System.Drawing.Point(0, 0);
            this.PanelUpperHorizontal.Name = "PanelUpperHorizontal";
            this.PanelUpperHorizontal.Quality = 10;
            this.PanelUpperHorizontal.Size = new System.Drawing.Size(1011, 99);
            this.PanelUpperHorizontal.TabIndex = 150;
            // 
            // DayOfTheWeek
            // 
            this.DayOfTheWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DayOfTheWeek.BackColor = System.Drawing.Color.Transparent;
            this.DayOfTheWeek.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayOfTheWeek.ForeColor = System.Drawing.Color.White;
            this.DayOfTheWeek.Location = new System.Drawing.Point(449, 26);
            this.DayOfTheWeek.Name = "DayOfTheWeek";
            this.DayOfTheWeek.Size = new System.Drawing.Size(556, 40);
            this.DayOfTheWeek.TabIndex = 139;
            this.DayOfTheWeek.Text = "DayOfTheWeek";
            this.DayOfTheWeek.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormCaption
            // 
            this.FormCaption.AutoSize = true;
            this.FormCaption.BackColor = System.Drawing.Color.Transparent;
            this.FormCaption.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormCaption.ForeColor = System.Drawing.Color.White;
            this.FormCaption.Location = new System.Drawing.Point(10, 7);
            this.FormCaption.Name = "FormCaption";
            this.FormCaption.Size = new System.Drawing.Size(330, 40);
            this.FormCaption.TabIndex = 138;
            this.FormCaption.Text = "Cadastro De Destinos";
            // 
            // StockDestinationRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1011, 537);
            this.Controls.Add(this.PanelUpperHorizontal);
            this.Controls.Add(this.DestinationDataList);
            this.Controls.Add(this.DestinationLocationTitle);
            this.Controls.Add(this.DestinationLocation);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(728, 460);
            this.Name = "StockDestinationRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StockDestinationRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DestinationLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationDataList)).EndInit();
            this.PanelUpperHorizontal.ResumeLayout(false);
            this.PanelUpperHorizontal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label DestinationLocationTitle;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt DestinationLocation;
        private System.Windows.Forms.DataGridView DestinationDataList;
        private System.Windows.Forms.Button RegisterNew;
        private System.Windows.Forms.Button ChangeRegister;
        private System.Windows.Forms.Button ExcludeRegister;
        private System.Windows.Forms.Button UpdateDataList;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelUpperHorizontal;
        public System.Windows.Forms.Label DayOfTheWeek;
        public System.Windows.Forms.Label FormCaption;
    }
}