namespace DimStock.UserForm
{
    partial class AppConfigDirectoryForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ExecuteSettings = new Syncfusion.WinForms.Controls.SfButton();
            this.fieldDataBasePath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.fieldDataBasePath)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(48, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(640, 33);
            this.label4.TabIndex = 147;
            this.label4.Text = "Defina Um Diretório Padrão";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(115, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 54);
            this.label5.TabIndex = 148;
            this.label5.Text = "Nesse diretório ficará alocado os arquivos de seu sistema, como pastas de fotos, " +
    "banco de dados e o backup";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExecuteSettings
            // 
            this.ExecuteSettings.AccessibleName = "Button";
            this.ExecuteSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ExecuteSettings.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExecuteSettings.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExecuteSettings.ForeColor = System.Drawing.Color.White;
            this.ExecuteSettings.Location = new System.Drawing.Point(591, 156);
            this.ExecuteSettings.Name = "ExecuteSettings";
            this.ExecuteSettings.Size = new System.Drawing.Size(49, 27);
            this.ExecuteSettings.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExecuteSettings.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExecuteSettings.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ExecuteSettings.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExecuteSettings.Style.FocusedForeColor = System.Drawing.Color.White;
            this.ExecuteSettings.Style.ForeColor = System.Drawing.Color.White;
            this.ExecuteSettings.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExecuteSettings.Style.HoverForeColor = System.Drawing.Color.Black;
            this.ExecuteSettings.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ExecuteSettings.Style.PressedForeColor = System.Drawing.Color.White;
            this.ExecuteSettings.TabIndex = 146;
            this.ExecuteSettings.Text = "Add";
            this.ExecuteSettings.UseVisualStyleBackColor = false;
            this.ExecuteSettings.Click += new System.EventHandler(this.ExecuteSettings_Click);
            // 
            // fieldDataBasePath
            // 
            this.fieldDataBasePath.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.fieldDataBasePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.fieldDataBasePath.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.fieldDataBasePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fieldDataBasePath.CanOverrideStyle = true;
            this.fieldDataBasePath.CausesValidation = false;
            this.fieldDataBasePath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.fieldDataBasePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fieldDataBasePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.fieldDataBasePath.Location = new System.Drawing.Point(93, 156);
            this.fieldDataBasePath.MaxLength = 50;
            this.fieldDataBasePath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.fieldDataBasePath.MinimumSize = new System.Drawing.Size(16, 12);
            this.fieldDataBasePath.Multiline = true;
            this.fieldDataBasePath.Name = "fieldDataBasePath";
            this.fieldDataBasePath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.fieldDataBasePath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.fieldDataBasePath.Size = new System.Drawing.Size(497, 27);
            this.fieldDataBasePath.TabIndex = 145;
            this.fieldDataBasePath.Tag = "";
            this.fieldDataBasePath.ThemeName = "Default";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.ExecuteSettings);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.fieldDataBasePath);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(109, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 260);
            this.panel1.TabIndex = 149;
            // 
            // DirectoryDefinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(996, 616);
            this.Controls.Add(this.panel1);
            this.Name = "DirectoryDefinationForm";
            this.Text = "DirectoryDefinationForm";
            ((System.ComponentModel.ISupportInitialize)(this.fieldDataBasePath)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Syncfusion.WinForms.Controls.SfButton ExecuteSettings;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt fieldDataBasePath;
        private System.Windows.Forms.Panel panel1;
    }
}