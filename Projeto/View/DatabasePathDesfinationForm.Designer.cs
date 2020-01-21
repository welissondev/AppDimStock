namespace DimStock.View
{
    partial class DatabasePathDesfinationForm
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
            this.dataBasePath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TitleSearchByDescription = new System.Windows.Forms.Label();
            this.SelectFile = new Syncfusion.WinForms.Controls.SfButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dataBasePath)).BeginInit();
            this.SuspendLayout();
            // 
            // dataBasePath
            // 
            this.dataBasePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataBasePath.BeforeTouchSize = new System.Drawing.Size(392, 27);
            this.dataBasePath.BorderColor = System.Drawing.Color.DarkGray;
            this.dataBasePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataBasePath.CanOverrideStyle = true;
            this.dataBasePath.CausesValidation = false;
            this.dataBasePath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dataBasePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBasePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.dataBasePath.Location = new System.Drawing.Point(52, 65);
            this.dataBasePath.MaxLength = 50;
            this.dataBasePath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.dataBasePath.MinimumSize = new System.Drawing.Size(16, 12);
            this.dataBasePath.Multiline = true;
            this.dataBasePath.Name = "dataBasePath";
            this.dataBasePath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.dataBasePath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.dataBasePath.Size = new System.Drawing.Size(392, 27);
            this.dataBasePath.TabIndex = 91;
            this.dataBasePath.Tag = "";
            this.dataBasePath.ThemeName = "Default";
            // 
            // TitleSearchByDescription
            // 
            this.TitleSearchByDescription.AutoSize = true;
            this.TitleSearchByDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.TitleSearchByDescription.Location = new System.Drawing.Point(49, 49);
            this.TitleSearchByDescription.Name = "TitleSearchByDescription";
            this.TitleSearchByDescription.Size = new System.Drawing.Size(214, 13);
            this.TitleSearchByDescription.TabIndex = 92;
            this.TitleSearchByDescription.Text = "Defina um caminho para o banco de dados:";
            // 
            // SelectFile
            // 
            this.SelectFile.AccessibleName = "Button";
            this.SelectFile.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SelectFile.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectFile.ForeColor = System.Drawing.Color.White;
            this.SelectFile.Location = new System.Drawing.Point(447, 65);
            this.SelectFile.Name = "SelectFile";
            this.SelectFile.Size = new System.Drawing.Size(49, 27);
            this.SelectFile.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SelectFile.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SelectFile.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.SelectFile.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SelectFile.Style.FocusedForeColor = System.Drawing.Color.White;
            this.SelectFile.Style.ForeColor = System.Drawing.Color.White;
            this.SelectFile.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SelectFile.Style.HoverForeColor = System.Drawing.Color.Black;
            this.SelectFile.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SelectFile.Style.PressedForeColor = System.Drawing.Color.White;
            this.SelectFile.TabIndex = 142;
            this.SelectFile.Text = "Add";
            this.SelectFile.UseVisualStyleBackColor = false;
            this.SelectFile.Click += new System.EventHandler(this.SelectFile_Click);
            // 
            // DatabasePathDesfinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 145);
            this.Controls.Add(this.SelectFile);
            this.Controls.Add(this.dataBasePath);
            this.Controls.Add(this.TitleSearchByDescription);
            this.Name = "DatabasePathDesfinationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabasePathDesfinationForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataBasePath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TextBoxExt dataBasePath;
        private System.Windows.Forms.Label TitleSearchByDescription;
        private Syncfusion.WinForms.Controls.SfButton SelectFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}