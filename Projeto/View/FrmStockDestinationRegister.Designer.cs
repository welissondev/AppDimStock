namespace DimStock.View
{
    partial class FrmStockDestinationRegister
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
            this.LblDestinationLocation = new System.Windows.Forms.Label();
            this.TxtDestinationLocation = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.GridDestinationList = new System.Windows.Forms.DataGridView();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.BtnDelele = new System.Windows.Forms.Button();
            this.BtnUpdateList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDestinationLocation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDestinationList)).BeginInit();
            this.SuspendLayout();
            // 
            // LblDestinationLocation
            // 
            this.LblDestinationLocation.AutoSize = true;
            this.LblDestinationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDestinationLocation.ForeColor = System.Drawing.Color.Black;
            this.LblDestinationLocation.Location = new System.Drawing.Point(43, 44);
            this.LblDestinationLocation.Name = "LblDestinationLocation";
            this.LblDestinationLocation.Size = new System.Drawing.Size(137, 20);
            this.LblDestinationLocation.TabIndex = 144;
            this.LblDestinationLocation.Text = "Nome do destino: ";
            // 
            // TxtDestinationLocation
            // 
            this.TxtDestinationLocation.BackColor = System.Drawing.Color.White;
            this.TxtDestinationLocation.BeforeTouchSize = new System.Drawing.Size(405, 26);
            this.TxtDestinationLocation.BorderColor = System.Drawing.Color.Silver;
            this.TxtDestinationLocation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDestinationLocation.CornerRadius = 4;
            this.TxtDestinationLocation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtDestinationLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDestinationLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDestinationLocation.Location = new System.Drawing.Point(46, 66);
            this.TxtDestinationLocation.MinimumSize = new System.Drawing.Size(14, 10);
            this.TxtDestinationLocation.Name = "TxtDestinationLocation";
            this.TxtDestinationLocation.Size = new System.Drawing.Size(405, 26);
            this.TxtDestinationLocation.TabIndex = 143;
            this.TxtDestinationLocation.ThemeName = "Default";
            // 
            // GridDestinationList
            // 
            this.GridDestinationList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDestinationList.Location = new System.Drawing.Point(46, 101);
            this.GridDestinationList.Name = "GridDestinationList";
            this.GridDestinationList.Size = new System.Drawing.Size(446, 226);
            this.GridDestinationList.TabIndex = 145;
            this.GridDestinationList.DoubleClick += new System.EventHandler(this.GridDestinationList_DoubleClick);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(498, 99);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 146;
            this.BtnRegister.Text = "Cadastrar";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(498, 128);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(75, 23);
            this.BtnEdit.TabIndex = 147;
            this.BtnEdit.Text = "Editar";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // BtnDelele
            // 
            this.BtnDelele.Location = new System.Drawing.Point(498, 157);
            this.BtnDelele.Name = "BtnDelele";
            this.BtnDelele.Size = new System.Drawing.Size(75, 23);
            this.BtnDelele.TabIndex = 148;
            this.BtnDelele.Text = "Deletar";
            this.BtnDelele.UseVisualStyleBackColor = true;
            this.BtnDelele.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdateList
            // 
            this.BtnUpdateList.Location = new System.Drawing.Point(498, 186);
            this.BtnUpdateList.Name = "BtnUpdateList";
            this.BtnUpdateList.Size = new System.Drawing.Size(75, 23);
            this.BtnUpdateList.TabIndex = 149;
            this.BtnUpdateList.Text = "Atualizar";
            this.BtnUpdateList.UseVisualStyleBackColor = true;
            this.BtnUpdateList.Click += new System.EventHandler(this.BtnUpdateList_Click);
            // 
            // FrmStockDestinationRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 366);
            this.Controls.Add(this.BtnUpdateList);
            this.Controls.Add(this.BtnDelele);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.GridDestinationList);
            this.Controls.Add(this.LblDestinationLocation);
            this.Controls.Add(this.TxtDestinationLocation);
            this.Name = "FrmStockDestinationRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque destinos";
            this.Load += new System.EventHandler(this.FrmStockDestinationRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtDestinationLocation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDestinationList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label LblDestinationLocation;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtDestinationLocation;
        private System.Windows.Forms.DataGridView GridDestinationList;
        private System.Windows.Forms.Button BtnRegister;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button BtnDelele;
        private System.Windows.Forms.Button BtnUpdateList;
    }
}