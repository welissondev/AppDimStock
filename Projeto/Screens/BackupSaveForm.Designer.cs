namespace DimStock.Screens
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
            this.ButtonOpenDirectory = new Syncfusion.Windows.Forms.ButtonAdv();
            this.TextBackupFolderPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.ButtonGenerateBackup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBackupFolderPath)).BeginInit();
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
            this.tabPage1.Controls.Add(this.ButtonOpenDirectory);
            this.tabPage1.Controls.Add(this.TextBackupFolderPath);
            this.tabPage1.Controls.Add(this.ButtonGenerateBackup);
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
            // ButtonOpenDirectory
            // 
            this.ButtonOpenDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonOpenDirectory.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.ButtonOpenDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.ButtonOpenDirectory.BeforeTouchSize = new System.Drawing.Size(37, 27);
            this.ButtonOpenDirectory.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo;
            this.ButtonOpenDirectory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ButtonOpenDirectory.KeepFocusRectangle = false;
            this.ButtonOpenDirectory.Location = new System.Drawing.Point(539, 275);
            this.ButtonOpenDirectory.Name = "ButtonOpenDirectory";
            this.ButtonOpenDirectory.Size = new System.Drawing.Size(37, 27);
            this.ButtonOpenDirectory.TabIndex = 211;
            this.ButtonOpenDirectory.Text = "buttonAdv1";
            this.ButtonOpenDirectory.ThemeName = "Office2016White";
            this.ButtonOpenDirectory.UseVisualStyle = true;
            this.ButtonOpenDirectory.Click += new System.EventHandler(this.ButtonOpenDirectory_Click);
            // 
            // TextBackupFolderPath
            // 
            this.TextBackupFolderPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBackupFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextBackupFolderPath.BeforeTouchSize = new System.Drawing.Size(391, 27);
            this.TextBackupFolderPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextBackupFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBackupFolderPath.CanOverrideStyle = true;
            this.TextBackupFolderPath.CausesValidation = false;
            this.TextBackupFolderPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBackupFolderPath.Enabled = false;
            this.TextBackupFolderPath.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBackupFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextBackupFolderPath.Location = new System.Drawing.Point(150, 275);
            this.TextBackupFolderPath.MaxLength = 50;
            this.TextBackupFolderPath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TextBackupFolderPath.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextBackupFolderPath.Multiline = true;
            this.TextBackupFolderPath.Name = "TextBackupFolderPath";
            this.TextBackupFolderPath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextBackupFolderPath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextBackupFolderPath.Size = new System.Drawing.Size(391, 27);
            this.TextBackupFolderPath.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TextBackupFolderPath.TabIndex = 210;
            this.TextBackupFolderPath.Tag = "";
            this.TextBackupFolderPath.ThemeName = "Office2016Colorful";
            this.TextBackupFolderPath.ThemesEnabled = false;
            // 
            // ButtonGenerateBackup
            // 
            this.ButtonGenerateBackup.ActiveBorderThickness = 1;
            this.ButtonGenerateBackup.ActiveCornerRadius = 10;
            this.ButtonGenerateBackup.ActiveFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGenerateBackup.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonGenerateBackup.ActiveLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGenerateBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonGenerateBackup.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGenerateBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGenerateBackup.BackgroundImage")));
            this.ButtonGenerateBackup.ButtonText = "Gerar Backup";
            this.ButtonGenerateBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGenerateBackup.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonGenerateBackup.ForeColor = System.Drawing.Color.White;
            this.ButtonGenerateBackup.IdleBorderThickness = 1;
            this.ButtonGenerateBackup.IdleCornerRadius = 10;
            this.ButtonGenerateBackup.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGenerateBackup.IdleForecolor = System.Drawing.Color.White;
            this.ButtonGenerateBackup.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonGenerateBackup.Location = new System.Drawing.Point(148, 310);
            this.ButtonGenerateBackup.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonGenerateBackup.Name = "ButtonGenerateBackup";
            this.ButtonGenerateBackup.Size = new System.Drawing.Size(150, 41);
            this.ButtonGenerateBackup.TabIndex = 209;
            this.ButtonGenerateBackup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonGenerateBackup.Click += new System.EventHandler(this.ButtonGenerateBackup_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.TextBackupFolderPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonGenerateBackup;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextBackupFolderPath;
        private Syncfusion.Windows.Forms.ButtonAdv ButtonOpenDirectory;
    }
}