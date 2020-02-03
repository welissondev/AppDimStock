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
            this.BackupFolderPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.GenerateBackup = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label1 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.OpenDirectory = new Syncfusion.Windows.Forms.ButtonAdv();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupFolderPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Location = new System.Drawing.Point(70, 158);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(809, 428);
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
            this.tabPage1.Size = new System.Drawing.Size(801, 402);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "BackUp";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BackupFolderPath
            // 
            this.BackupFolderPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BackupFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackupFolderPath.BeforeTouchSize = new System.Drawing.Size(438, 27);
            this.BackupFolderPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.BackupFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackupFolderPath.CanOverrideStyle = true;
            this.BackupFolderPath.CausesValidation = false;
            this.BackupFolderPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BackupFolderPath.Enabled = false;
            this.BackupFolderPath.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackupFolderPath.Location = new System.Drawing.Point(185, 253);
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
            this.GenerateBackup.ActiveFillColor = System.Drawing.Color.Gray;
            this.GenerateBackup.ActiveForecolor = System.Drawing.Color.White;
            this.GenerateBackup.ActiveLineColor = System.Drawing.Color.Gray;
            this.GenerateBackup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GenerateBackup.BackColor = System.Drawing.Color.Transparent;
            this.GenerateBackup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GenerateBackup.BackgroundImage")));
            this.GenerateBackup.ButtonText = "Gerar Backup";
            this.GenerateBackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GenerateBackup.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenerateBackup.ForeColor = System.Drawing.Color.SeaGreen;
            this.GenerateBackup.IdleBorderThickness = 1;
            this.GenerateBackup.IdleCornerRadius = 20;
            this.GenerateBackup.IdleFillColor = System.Drawing.Color.White;
            this.GenerateBackup.IdleForecolor = System.Drawing.Color.Gray;
            this.GenerateBackup.IdleLineColor = System.Drawing.Color.Gray;
            this.GenerateBackup.Location = new System.Drawing.Point(184, 293);
            this.GenerateBackup.Margin = new System.Windows.Forms.Padding(5);
            this.GenerateBackup.Name = "GenerateBackup";
            this.GenerateBackup.Size = new System.Drawing.Size(160, 41);
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
            this.label1.Location = new System.Drawing.Point(182, 116);
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
            this.label21.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label21.Location = new System.Drawing.Point(178, 63);
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
            this.label22.Location = new System.Drawing.Point(182, 175);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(411, 69);
            this.label22.TabIndex = 205;
            this.label22.Text = "É altamente recomendado que seja feito o backup do banco de dados pelo menos 1 ve" +
    "z ao dia. Esse arquivo sera salvo na pasta DatabaseBackup do diretório raiz defi" +
    "nido por você.";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(250, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 40);
            this.label2.TabIndex = 208;
            this.label2.Text = "DimStock";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(272, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 29);
            this.label3.TabIndex = 210;
            this.label3.Text = "Assistente de Backup\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DimStock.Properties.Resources.DimStockLogoType;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(419, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 72);
            this.pictureBox1.TabIndex = 209;
            this.pictureBox1.TabStop = false;
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
            this.OpenDirectory.Location = new System.Drawing.Point(539, 253);
            this.OpenDirectory.Name = "OpenDirectory";
            this.OpenDirectory.Size = new System.Drawing.Size(37, 27);
            this.OpenDirectory.TabIndex = 211;
            this.OpenDirectory.Text = "buttonAdv1";
            this.OpenDirectory.ThemeName = "Office2016White";
            this.OpenDirectory.UseVisualStyle = true;
            this.OpenDirectory.Click += new System.EventHandler(this.OpenDirectory_Click);
            // 
            // BackupSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 628);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.MainTabControl);
            this.MinimumSize = new System.Drawing.Size(959, 667);
            this.Name = "BackupSaveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.BackupSaveForm_Load);
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupFolderPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Syncfusion.Windows.Forms.ButtonAdv OpenDirectory;
    }
}