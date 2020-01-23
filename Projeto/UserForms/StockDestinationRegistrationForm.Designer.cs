namespace DimStock.UserForms
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
            this.DestinationLocationTitle = new System.Windows.Forms.Label();
            this.DestinationLocation = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.DestinationDataList = new System.Windows.Forms.DataGridView();
            this.RegisterNew = new System.Windows.Forms.Button();
            this.ChangeRegister = new System.Windows.Forms.Button();
            this.ExcludeRegister = new System.Windows.Forms.Button();
            this.UpdateDataList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationDataList)).BeginInit();
            this.SuspendLayout();
            // 
            // DestinationLocationTitle
            // 
            this.DestinationLocationTitle.AutoSize = true;
            this.DestinationLocationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLocationTitle.ForeColor = System.Drawing.Color.Black;
            this.DestinationLocationTitle.Location = new System.Drawing.Point(9, 96);
            this.DestinationLocationTitle.Name = "DestinationLocationTitle";
            this.DestinationLocationTitle.Size = new System.Drawing.Size(162, 20);
            this.DestinationLocationTitle.TabIndex = 144;
            this.DestinationLocationTitle.Text = "Descrição do destino:";
            // 
            // DestinationLocation
            // 
            this.DestinationLocation.BackColor = System.Drawing.Color.White;
            this.DestinationLocation.BeforeTouchSize = new System.Drawing.Size(400, 26);
            this.DestinationLocation.BorderColor = System.Drawing.Color.Silver;
            this.DestinationLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DestinationLocation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DestinationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DestinationLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DestinationLocation.Location = new System.Drawing.Point(12, 118);
            this.DestinationLocation.MinimumSize = new System.Drawing.Size(14, 10);
            this.DestinationLocation.Name = "DestinationLocation";
            this.DestinationLocation.Size = new System.Drawing.Size(400, 26);
            this.DestinationLocation.TabIndex = 143;
            this.DestinationLocation.ThemeName = "Default";
            // 
            // DestinationDataList
            // 
            this.DestinationDataList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationDataList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DestinationDataList.Location = new System.Drawing.Point(12, 147);
            this.DestinationDataList.Name = "DestinationDataList";
            this.DestinationDataList.Size = new System.Drawing.Size(688, 262);
            this.DestinationDataList.TabIndex = 145;
            this.DestinationDataList.DoubleClick += new System.EventHandler(this.DestinationDataList_DoubleClick);
            // 
            // RegisterNew
            // 
            this.RegisterNew.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RegisterNew.FlatAppearance.BorderSize = 0;
            this.RegisterNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterNew.ForeColor = System.Drawing.Color.White;
            this.RegisterNew.Location = new System.Drawing.Point(16, 30);
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
            this.ChangeRegister.Location = new System.Drawing.Point(102, 30);
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
            this.ExcludeRegister.Location = new System.Drawing.Point(188, 30);
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
            this.UpdateDataList.Location = new System.Drawing.Point(274, 30);
            this.UpdateDataList.Name = "UpdateDataList";
            this.UpdateDataList.Size = new System.Drawing.Size(80, 35);
            this.UpdateDataList.TabIndex = 149;
            this.UpdateDataList.Text = "Atualizar";
            this.UpdateDataList.UseVisualStyleBackColor = false;
            this.UpdateDataList.Click += new System.EventHandler(this.UpdateDataList_Click);
            // 
            // StockDestinationRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(712, 421);
            this.Controls.Add(this.UpdateDataList);
            this.Controls.Add(this.ExcludeRegister);
            this.Controls.Add(this.ChangeRegister);
            this.Controls.Add(this.DestinationDataList);
            this.Controls.Add(this.RegisterNew);
            this.Controls.Add(this.DestinationLocationTitle);
            this.Controls.Add(this.DestinationLocation);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(728, 460);
            this.Name = "StockDestinationRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.StockDestinationRegistrationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DestinationLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DestinationDataList)).EndInit();
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
    }
}