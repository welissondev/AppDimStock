namespace DimStock.UserForms
{
    partial class BackupSaveForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupSaveForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.OpenDirectory = new Syncfusion.Windows.Forms.ButtonAdv();
            this.BackupFolderPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.GenerateBackup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupFolderPath)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Location = new System.Drawing.Point(94, 27);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(739, 472);
            this.MainTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.OpenDirectory);
            this.tabPage1.Controls.Add(this.BackupFolderPath);
            this.tabPage1.Controls.Add(this.GenerateBackup);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(731, 446);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BackUp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // OpenDirectory
            // 
            this.OpenDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.OpenDirectory.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.OpenDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.OpenDirectory.BeforeTouchSize = new System.Drawing.Size(37, 27);
            this.OpenDirectory.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo;
            this.OpenDirectory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OpenDirectory.KeepFocusRectangle = false;
            this.OpenDirectory.Location = new System.Drawing.Point(539, 275);
            this.OpenDirectory.Name = "OpenDirectory";
            this.OpenDirectory.Size = new System.Drawing.Size(37, 27);
            this.OpenDirectory.TabIndex = 211;
            this.OpenDirectory.Text = "buttonAdv1";
            this.OpenDirectory.ThemeName = "Office2016White";
            this.OpenDirectory.UseVisualStyle = true;
            this.OpenDirectory.Click += new System.EventHandler(this.OpenDirectory_Click);
            // 
            // BackupFolderPath
            // 
            this.BackupFolderPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackupFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackupFolderPath.BeforeTouchSize = new System.Drawing.Size(391, 27);
            this.BackupFolderPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.BackupFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackupFolderPath.CanOverrideStyle = true;
            this.BackupFolderPath.CausesValidation = false;
            this.BackupFolderPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BackupFolderPath.Enabled = false;
            this.BackupFolderPath.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackupFolderPath.Location = new System.Drawing.Point(150, 275);
            this.BackupFolderPath.MaxLength = 50;
            this.BackupFolderPath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.BackupFolderPath.MinimumSize = new System.Drawing.Size(16, 12);
            this.BackupFolderPath.Multiline = true;
            this.BackupFolderPath.Name = "BackupFolderPath";
            this.BackupFolderPath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.BackupFolderPath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.BackupFolderPath.Size = new System.Drawing.Size(391, 27);
            this.BackupFolderPath.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.BackupFolderPath.TabIndex = 210;
            this.BackupFolderPath.Tag = "";
            this.BackupFolderPath.ThemeName = "Office2016Colorful";
            this.BackupFolderPath.ThemesEnabled = false;
            // 
            // GenerateBackup
            // 
            this.GenerateBackup.ActiveBorderThickness = 1;
            this.GenerateBackup.ActiveCornerRadius = 10;
            this.GenerateBackup.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateBackup.ActiveForecolor = System.Drawing.Color.White;
            this.GenerateBackup.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateBackup.BackColor = System.Drawing.Color.Transparent;
            this.GenerateBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GenerateBackup.BackgroundImage")));
            this.GenerateBackup.ButtonText = "Gerar Backup";
            this.GenerateBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateBackup.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.GenerateBackup.ForeColor = System.Drawing.Color.White;
            this.GenerateBackup.IdleBorderThickness = 1;
            this.GenerateBackup.IdleCornerRadius = 10;
            this.GenerateBackup.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateBackup.IdleForecolor = System.Drawing.Color.White;
            this.GenerateBackup.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.GenerateBackup.Location = new System.Drawing.Point(148, 310);
            this.GenerateBackup.Margin = new System.Windows.Forms.Padding(5);
            this.GenerateBackup.Name = "GenerateBackup";
            this.GenerateBackup.Size = new System.Drawing.Size(150, 41);
            this.GenerateBackup.TabIndex = 209;
            this.GenerateBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GenerateBackup.Click += new System.EventHandler(this.GenerateBackup_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(147, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(380, 54);
            this.label1.TabIndex = 206;
            this.label1.Text = "Efetue uma cópia de segurança regularmente ou antes de operações que afetarão a b" +
    "ase de dados de forma a garantir a integridade dos dados\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label21
            // 
            this.label21.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label21.Location = new System.Drawing.Point(143, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(424, 41);
            this.label21.TabIndex = 204;
            this.label21.Text = "Backup";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(147, 197);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(411, 69);
            this.label22.TabIndex = 205;
            this.label22.Text = "É altamente recomendado que seja feito o backup do banco de dados pelo menos 1 ve" +
    "z ao dia. Esse arquivo sera salvo na pasta DatabaseBackup do diretório raiz defi" +
    "nido por você.";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BackupSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.MainTabControl);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "BackupSaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BackupSaveForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupFolderPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuThinButton2 GenerateBackup;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt BackupFolderPath;
        private Syncfusion.Windows.Forms.ButtonAdv OpenDirectory;
    }
}