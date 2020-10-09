namespace DimStock.Screens
{
    partial class BackupSaveScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupSaveScreen));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.TabPageGenerate = new System.Windows.Forms.TabPage();
            this.ButtonOpenFolder = new Syncfusion.Windows.Forms.ButtonAdv();
            this.TextFolderPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LabelSubTitle = new System.Windows.Forms.Label();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.LabelDescription = new System.Windows.Forms.Label();
            this.ButtonGenerate = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.MainTabControl.SuspendLayout();
            this.TabPageGenerate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextFolderPath)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MainTabControl.Controls.Add(this.TabPageGenerate);
            this.MainTabControl.Location = new System.Drawing.Point(94, 27);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(739, 472);
            this.MainTabControl.TabIndex = 0;
            // 
            // TabPageGenerate
            // 
            this.TabPageGenerate.Controls.Add(this.ButtonGenerate);
            this.TabPageGenerate.Controls.Add(this.ButtonOpenFolder);
            this.TabPageGenerate.Controls.Add(this.TextFolderPath);
            this.TabPageGenerate.Controls.Add(this.LabelSubTitle);
            this.TabPageGenerate.Controls.Add(this.LabelTitle);
            this.TabPageGenerate.Controls.Add(this.LabelDescription);
            this.TabPageGenerate.Location = new System.Drawing.Point(4, 22);
            this.TabPageGenerate.Name = "TabPageGenerate";
            this.TabPageGenerate.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageGenerate.Size = new System.Drawing.Size(731, 446);
            this.TabPageGenerate.TabIndex = 0;
            this.TabPageGenerate.Text = "Gerar Backup";
            this.TabPageGenerate.UseVisualStyleBackColor = true;
            // 
            // ButtonOpenFolder
            // 
            this.ButtonOpenFolder.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonOpenFolder.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.ButtonOpenFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.ButtonOpenFolder.BeforeTouchSize = new System.Drawing.Size(37, 27);
            this.ButtonOpenFolder.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Redo;
            this.ButtonOpenFolder.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ButtonOpenFolder.KeepFocusRectangle = false;
            this.ButtonOpenFolder.Location = new System.Drawing.Point(539, 275);
            this.ButtonOpenFolder.Name = "ButtonOpenFolder";
            this.ButtonOpenFolder.Size = new System.Drawing.Size(37, 27);
            this.ButtonOpenFolder.TabIndex = 211;
            this.ButtonOpenFolder.Text = "buttonAdv1";
            this.ButtonOpenFolder.ThemeName = "Office2016White";
            this.ButtonOpenFolder.UseVisualStyle = true;
            // 
            // TextFolderPath
            // 
            this.TextFolderPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextFolderPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextFolderPath.BeforeTouchSize = new System.Drawing.Size(405, 27);
            this.TextFolderPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextFolderPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextFolderPath.CanOverrideStyle = true;
            this.TextFolderPath.CausesValidation = false;
            this.TextFolderPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextFolderPath.Enabled = false;
            this.TextFolderPath.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextFolderPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextFolderPath.Location = new System.Drawing.Point(150, 275);
            this.TextFolderPath.MaxLength = 50;
            this.TextFolderPath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TextFolderPath.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextFolderPath.Multiline = true;
            this.TextFolderPath.Name = "TextFolderPath";
            this.TextFolderPath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextFolderPath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextFolderPath.Size = new System.Drawing.Size(391, 27);
            this.TextFolderPath.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TextFolderPath.TabIndex = 210;
            this.TextFolderPath.Tag = "";
            this.TextFolderPath.ThemeName = "Office2016Colorful";
            this.TextFolderPath.ThemesEnabled = false;
            // 
            // LabelSubTitle
            // 
            this.LabelSubTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelSubTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelSubTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelSubTitle.Location = new System.Drawing.Point(147, 138);
            this.LabelSubTitle.Name = "LabelSubTitle";
            this.LabelSubTitle.Size = new System.Drawing.Size(380, 54);
            this.LabelSubTitle.TabIndex = 206;
            this.LabelSubTitle.Text = "Efetue uma cópia de segurança regularmente ou antes de operações que afetarão a b" +
    "ase de dados de forma a garantir a integridade dos dados\r\n\r\n";
            this.LabelSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelTitle
            // 
            this.LabelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LabelTitle.Location = new System.Drawing.Point(143, 85);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(424, 41);
            this.LabelTitle.TabIndex = 204;
            this.LabelTitle.Text = "Backup";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelDescription
            // 
            this.LabelDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelDescription.BackColor = System.Drawing.Color.Transparent;
            this.LabelDescription.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LabelDescription.Location = new System.Drawing.Point(147, 197);
            this.LabelDescription.Name = "LabelDescription";
            this.LabelDescription.Size = new System.Drawing.Size(411, 69);
            this.LabelDescription.TabIndex = 205;
            this.LabelDescription.Text = "É altamente recomendado que seja feito o backup do banco de dados pelo menos 1 ve" +
    "z ao dia. Esse arquivo sera salvo na pasta DatabaseBackup do diretório raiz defi" +
    "nido por você.";
            this.LabelDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonGenerate
            // 
            this.ButtonGenerate.AllowToggling = false;
            this.ButtonGenerate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonGenerate.AnimationSpeed = 200;
            this.ButtonGenerate.AutoGenerateColors = false;
            this.ButtonGenerate.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ButtonGenerate.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGenerate.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(229)))));
            this.ButtonGenerate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonGenerate.BackgroundImage")));
            this.ButtonGenerate.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonGenerate.ButtonText = "Salvar Dados";
            this.ButtonGenerate.ButtonTextMarginLeft = 0;
            this.ButtonGenerate.ColorContrastOnClick = 45;
            this.ButtonGenerate.ColorContrastOnHover = 45;
            this.ButtonGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonGenerate.CustomizableEdges = borderEdges1;
            this.ButtonGenerate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonGenerate.DisabledBorderColor = System.Drawing.Color.Empty;
            this.ButtonGenerate.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonGenerate.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonGenerate.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonGenerate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.ButtonGenerate.ForeColor = System.Drawing.Color.White;
            this.ButtonGenerate.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGenerate.IconMarginLeft = 11;
            this.ButtonGenerate.IconPadding = 10;
            this.ButtonGenerate.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonGenerate.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(229)))));
            this.ButtonGenerate.IdleBorderRadius = 20;
            this.ButtonGenerate.IdleBorderThickness = 8;
            this.ButtonGenerate.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(229)))));
            this.ButtonGenerate.IdleIconLeftImage = null;
            this.ButtonGenerate.IdleIconRightImage = null;
            this.ButtonGenerate.IndicateFocus = false;
            this.ButtonGenerate.Location = new System.Drawing.Point(143, 313);
            this.ButtonGenerate.Name = "ButtonGenerate";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 20;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 8;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.ButtonGenerate.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(229)))));
            stateProperties2.BorderRadius = 20;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 8;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(229)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.ButtonGenerate.OnPressedState = stateProperties2;
            this.ButtonGenerate.Size = new System.Drawing.Size(144, 41);
            this.ButtonGenerate.TabIndex = 212;
            this.ButtonGenerate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonGenerate.TextMarginLeft = 0;
            this.ButtonGenerate.UseDefaultRadiusAndThickness = true;
            // 
            // BackupSaveScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.MainTabControl);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "BackupSaveScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MainTabControl.ResumeLayout(false);
            this.TabPageGenerate.ResumeLayout(false);
            this.TabPageGenerate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextFolderPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage TabPageGenerate;
        private System.Windows.Forms.Label LabelSubTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.Label LabelDescription;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextFolderPath;
        private Syncfusion.Windows.Forms.ButtonAdv ButtonOpenFolder;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonGenerate;
    }
}