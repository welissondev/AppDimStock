namespace DimStock.UserForms
{
    partial class AppSettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingsForm));
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PageConfigType = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckBoxNewConfiguration = new System.Windows.Forms.RadioButton();
            this.CheckBoxRestoureBackup = new System.Windows.Forms.RadioButton();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.PageChooseDirectory = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ChooseMainDirectory = new Syncfusion.Windows.Forms.ButtonAdv();
            this.MainDirectoryPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PageCompanyLogo = new System.Windows.Forms.TabPage();
            this.FrameProductPhoto = new System.Windows.Forms.GroupBox();
            this.CompanyLogoImage = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PageLogin = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PassWordConfirmation = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PassWordConfirmationTitle = new System.Windows.Forms.Label();
            this.PassWord = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.Login = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PassWordTitle = new System.Windows.Forms.Label();
            this.Email = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.EmailTitle = new System.Windows.Forms.Label();
            this.UserName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.NameTitle = new System.Windows.Forms.Label();
            this.PageBackUp = new System.Windows.Forms.TabPage();
            this.ListviewBackup = new System.Windows.Forms.ListView();
            this.FileList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ChooseBackup = new Syncfusion.Windows.Forms.ButtonAdv();
            this.BackupPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PageFinalize = new System.Windows.Forms.TabPage();
            this.Loading = new System.Windows.Forms.PictureBox();
            this.LabelPageFinalizeSubTitle = new System.Windows.Forms.Label();
            this.LabelPageFinalizeTitle = new System.Windows.Forms.Label();
            this.NextPage = new System.Windows.Forms.LinkLabel();
            this.BackPage = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CloseAssistant = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.MainTabControl.SuspendLayout();
            this.PageConfigType.SuspendLayout();
            this.PageChooseDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDirectoryPath)).BeginInit();
            this.PageCompanyLogo.SuspendLayout();
            this.FrameProductPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoImage)).BeginInit();
            this.PageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassWordConfirmation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName)).BeginInit();
            this.PageBackUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupPath)).BeginInit();
            this.PageFinalize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Loading)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTabControl.Controls.Add(this.PageConfigType);
            this.MainTabControl.Controls.Add(this.PageChooseDirectory);
            this.MainTabControl.Controls.Add(this.PageCompanyLogo);
            this.MainTabControl.Controls.Add(this.PageLogin);
            this.MainTabControl.Controls.Add(this.PageBackUp);
            this.MainTabControl.Controls.Add(this.PageFinalize);
            this.MainTabControl.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.Location = new System.Drawing.Point(176, 161);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(617, 458);
            this.MainTabControl.TabIndex = 0;
            // 
            // PageConfigType
            // 
            this.PageConfigType.Controls.Add(this.label1);
            this.PageConfigType.Controls.Add(this.CheckBoxNewConfiguration);
            this.PageConfigType.Controls.Add(this.CheckBoxRestoureBackup);
            this.PageConfigType.Controls.Add(this.label21);
            this.PageConfigType.Controls.Add(this.label22);
            this.PageConfigType.Location = new System.Drawing.Point(4, 28);
            this.PageConfigType.Name = "PageConfigType";
            this.PageConfigType.Padding = new System.Windows.Forms.Padding(3);
            this.PageConfigType.Size = new System.Drawing.Size(609, 426);
            this.PageConfigType.TabIndex = 0;
            this.PageConfigType.Text = "Ambiente";
            this.PageConfigType.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(63, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 48);
            this.label1.TabIndex = 203;
            this.label1.Text = "Por favor defina se você deseja realizar uma nova configuração ou restaurar seus " +
    "dados\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CheckBoxNewConfiguration
            // 
            this.CheckBoxNewConfiguration.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxNewConfiguration.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxNewConfiguration.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.CheckBoxNewConfiguration.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.CheckBoxNewConfiguration.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.CheckBoxNewConfiguration.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.CheckBoxNewConfiguration.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxNewConfiguration.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckBoxNewConfiguration.Location = new System.Drawing.Point(65, 275);
            this.CheckBoxNewConfiguration.Name = "CheckBoxNewConfiguration";
            this.CheckBoxNewConfiguration.Size = new System.Drawing.Size(431, 25);
            this.CheckBoxNewConfiguration.TabIndex = 1;
            this.CheckBoxNewConfiguration.Text = "Opção B: Não tenho um backup, desejo fazer uma nova configuração\r\n\r\n\r\n";
            this.CheckBoxNewConfiguration.UseCompatibleTextRendering = true;
            this.CheckBoxNewConfiguration.UseVisualStyleBackColor = false;
            // 
            // CheckBoxRestoureBackup
            // 
            this.CheckBoxRestoureBackup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CheckBoxRestoureBackup.BackColor = System.Drawing.Color.Transparent;
            this.CheckBoxRestoureBackup.FlatAppearance.BorderColor = System.Drawing.Color.MediumSeaGreen;
            this.CheckBoxRestoureBackup.FlatAppearance.CheckedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.CheckBoxRestoureBackup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.CheckBoxRestoureBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.CheckBoxRestoureBackup.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBoxRestoureBackup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CheckBoxRestoureBackup.Location = new System.Drawing.Point(65, 248);
            this.CheckBoxRestoureBackup.Name = "CheckBoxRestoureBackup";
            this.CheckBoxRestoureBackup.Size = new System.Drawing.Size(431, 25);
            this.CheckBoxRestoureBackup.TabIndex = 0;
            this.CheckBoxRestoureBackup.Text = "Opção A: Já tenho um backup pronto para ser restaurado\r\n";
            this.CheckBoxRestoureBackup.UseCompatibleTextRendering = true;
            this.CheckBoxRestoureBackup.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label21.Location = new System.Drawing.Point(59, 62);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(424, 41);
            this.label21.TabIndex = 201;
            this.label21.Text = "Ambiente";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label22.Location = new System.Drawing.Point(62, 162);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(421, 69);
            this.label22.TabIndex = 202;
            this.label22.Text = "Essas definições precisam ser realizadas para que o sistema funcione corretamente" +
    ", fique tranquilo pois esse processo é rápido não vai levar nem um minuto!\r\n";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PageChooseDirectory
            // 
            this.PageChooseDirectory.Controls.Add(this.label4);
            this.PageChooseDirectory.Controls.Add(this.label5);
            this.PageChooseDirectory.Controls.Add(this.label6);
            this.PageChooseDirectory.Controls.Add(this.ChooseMainDirectory);
            this.PageChooseDirectory.Controls.Add(this.MainDirectoryPath);
            this.PageChooseDirectory.Location = new System.Drawing.Point(4, 28);
            this.PageChooseDirectory.Name = "PageChooseDirectory";
            this.PageChooseDirectory.Padding = new System.Windows.Forms.Padding(3);
            this.PageChooseDirectory.Size = new System.Drawing.Size(609, 426);
            this.PageChooseDirectory.TabIndex = 1;
            this.PageChooseDirectory.Text = "Diretório";
            this.PageChooseDirectory.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(61, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(424, 48);
            this.label4.TabIndex = 206;
            this.label4.Text = "Por favor defina o diretório principal de seu negócio, escolha uma pasta vazia do" +
    " sistema\r\n\r\n\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label5.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label5.Location = new System.Drawing.Point(61, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(424, 41);
            this.label5.TabIndex = 204;
            this.label5.Text = "Diretório";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(61, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(424, 69);
            this.label6.TabIndex = 205;
            this.label6.Text = "Essa parte é muito importante, pois nesse diretório principal ficará alocado os a" +
    "rquivos do seu negócio como: pastas, imagens, banco de dados e o backup dos seus" +
    " dados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChooseMainDirectory
            // 
            this.ChooseMainDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ChooseMainDirectory.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.ChooseMainDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.ChooseMainDirectory.BeforeTouchSize = new System.Drawing.Size(37, 27);
            this.ChooseMainDirectory.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.ChooseMainDirectory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ChooseMainDirectory.KeepFocusRectangle = false;
            this.ChooseMainDirectory.Location = new System.Drawing.Point(467, 260);
            this.ChooseMainDirectory.Name = "ChooseMainDirectory";
            this.ChooseMainDirectory.Size = new System.Drawing.Size(37, 27);
            this.ChooseMainDirectory.TabIndex = 154;
            this.ChooseMainDirectory.Text = "buttonAdv1";
            this.ChooseMainDirectory.ThemeName = "Office2016White";
            this.ChooseMainDirectory.UseVisualStyle = true;
            this.ChooseMainDirectory.Click += new System.EventHandler(this.ChooseMainDirectory_Click);
            // 
            // MainDirectoryPath
            // 
            this.MainDirectoryPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MainDirectoryPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.MainDirectoryPath.BeforeTouchSize = new System.Drawing.Size(438, 27);
            this.MainDirectoryPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.MainDirectoryPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MainDirectoryPath.CanOverrideStyle = true;
            this.MainDirectoryPath.CausesValidation = false;
            this.MainDirectoryPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainDirectoryPath.Enabled = false;
            this.MainDirectoryPath.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.MainDirectoryPath.Location = new System.Drawing.Point(66, 260);
            this.MainDirectoryPath.MaxLength = 50;
            this.MainDirectoryPath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.MainDirectoryPath.MinimumSize = new System.Drawing.Size(16, 12);
            this.MainDirectoryPath.Multiline = true;
            this.MainDirectoryPath.Name = "MainDirectoryPath";
            this.MainDirectoryPath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.MainDirectoryPath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.MainDirectoryPath.Size = new System.Drawing.Size(438, 27);
            this.MainDirectoryPath.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.MainDirectoryPath.TabIndex = 149;
            this.MainDirectoryPath.Tag = "";
            this.MainDirectoryPath.ThemeName = "Office2016Colorful";
            this.MainDirectoryPath.ThemesEnabled = false;
            // 
            // PageCompanyLogo
            // 
            this.PageCompanyLogo.Controls.Add(this.FrameProductPhoto);
            this.PageCompanyLogo.Controls.Add(this.label7);
            this.PageCompanyLogo.Controls.Add(this.label8);
            this.PageCompanyLogo.Controls.Add(this.label9);
            this.PageCompanyLogo.Location = new System.Drawing.Point(4, 28);
            this.PageCompanyLogo.Name = "PageCompanyLogo";
            this.PageCompanyLogo.Padding = new System.Windows.Forms.Padding(3);
            this.PageCompanyLogo.Size = new System.Drawing.Size(609, 426);
            this.PageCompanyLogo.TabIndex = 4;
            this.PageCompanyLogo.Text = "Logomarca";
            this.PageCompanyLogo.UseVisualStyleBackColor = true;
            // 
            // FrameProductPhoto
            // 
            this.FrameProductPhoto.BackColor = System.Drawing.Color.White;
            this.FrameProductPhoto.Controls.Add(this.CompanyLogoImage);
            this.FrameProductPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FrameProductPhoto.Location = new System.Drawing.Point(69, 199);
            this.FrameProductPhoto.Name = "FrameProductPhoto";
            this.FrameProductPhoto.Size = new System.Drawing.Size(120, 121);
            this.FrameProductPhoto.TabIndex = 218;
            this.FrameProductPhoto.TabStop = false;
            // 
            // CompanyLogoImage
            // 
            this.CompanyLogoImage.BackColor = System.Drawing.Color.White;
            this.CompanyLogoImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CompanyLogoImage.Image = global::DimStock.Properties.Resources.StockLogo;
            this.CompanyLogoImage.Location = new System.Drawing.Point(7, 16);
            this.CompanyLogoImage.Name = "CompanyLogoImage";
            this.CompanyLogoImage.Size = new System.Drawing.Size(106, 96);
            this.CompanyLogoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CompanyLogoImage.TabIndex = 212;
            this.CompanyLogoImage.TabStop = false;
            this.CompanyLogoImage.Click += new System.EventHandler(this.CompanyLogoImage_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(67, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(334, 27);
            this.label7.TabIndex = 217;
            this.label7.Text = "Insira uma logo marca na extensão do tipo .jpg";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label8.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label8.Location = new System.Drawing.Point(61, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(340, 41);
            this.label8.TabIndex = 215;
            this.label8.Text = "Logo Marca";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(67, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 46);
            this.label9.TabIndex = 216;
            this.label9.Text = "Caso você não defina sua logo, o sistema usará o logotipo padrão da aplicação\r\n";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PageLogin
            // 
            this.PageLogin.AutoScrollMargin = new System.Drawing.Size(0, 50);
            this.PageLogin.Controls.Add(this.label10);
            this.PageLogin.Controls.Add(this.label11);
            this.PageLogin.Controls.Add(this.label12);
            this.PageLogin.Controls.Add(this.PassWordConfirmation);
            this.PageLogin.Controls.Add(this.PassWordConfirmationTitle);
            this.PageLogin.Controls.Add(this.PassWord);
            this.PageLogin.Controls.Add(this.LoginTitle);
            this.PageLogin.Controls.Add(this.Login);
            this.PageLogin.Controls.Add(this.PassWordTitle);
            this.PageLogin.Controls.Add(this.Email);
            this.PageLogin.Controls.Add(this.EmailTitle);
            this.PageLogin.Controls.Add(this.UserName);
            this.PageLogin.Controls.Add(this.NameTitle);
            this.PageLogin.Location = new System.Drawing.Point(4, 28);
            this.PageLogin.Name = "PageLogin";
            this.PageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.PageLogin.Size = new System.Drawing.Size(609, 426);
            this.PageLogin.TabIndex = 3;
            this.PageLogin.Text = "Usuário";
            this.PageLogin.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(62, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(334, 22);
            this.label10.TabIndex = 220;
            this.label10.Text = "Adicione um usuário para acessar o sistema\r\n\r\n";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label11.Location = new System.Drawing.Point(56, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(424, 41);
            this.label11.TabIndex = 218;
            this.label11.Text = "Usuário";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(62, 113);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(387, 55);
            this.label12.TabIndex = 219;
            this.label12.Text = "Lembre-se que o programa também registrará um login padrão \"admin, admin\" caso vo" +
    "cê esqueça seus dados de acesso\r\n\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PassWordConfirmation
            // 
            this.PassWordConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PassWordConfirmation.BeforeTouchSize = new System.Drawing.Size(438, 27);
            this.PassWordConfirmation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.PassWordConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWordConfirmation.CanOverrideStyle = true;
            this.PassWordConfirmation.CausesValidation = false;
            this.PassWordConfirmation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassWordConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PassWordConfirmation.Location = new System.Drawing.Point(402, 288);
            this.PassWordConfirmation.MaxLength = 2000;
            this.PassWordConfirmation.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWordConfirmation.MinimumSize = new System.Drawing.Size(16, 12);
            this.PassWordConfirmation.Name = "PassWordConfirmation";
            this.PassWordConfirmation.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.PassWordConfirmation.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.PassWordConfirmation.PasswordChar = '*';
            this.PassWordConfirmation.Size = new System.Drawing.Size(104, 26);
            this.PassWordConfirmation.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.PassWordConfirmation.TabIndex = 190;
            this.PassWordConfirmation.Tag = "";
            this.PassWordConfirmation.ThemeName = "Office2016Colorful";
            // 
            // PassWordConfirmationTitle
            // 
            this.PassWordConfirmationTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordConfirmationTitle.Location = new System.Drawing.Point(398, 269);
            this.PassWordConfirmationTitle.Name = "PassWordConfirmationTitle";
            this.PassWordConfirmationTitle.Size = new System.Drawing.Size(110, 16);
            this.PassWordConfirmationTitle.TabIndex = 195;
            this.PassWordConfirmationTitle.Text = "Confirmar Senha:";
            // 
            // PassWord
            // 
            this.PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PassWord.BeforeTouchSize = new System.Drawing.Size(438, 27);
            this.PassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.PassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWord.CanOverrideStyle = true;
            this.PassWord.CausesValidation = false;
            this.PassWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PassWord.Location = new System.Drawing.Point(287, 288);
            this.PassWord.MaxLength = 2000;
            this.PassWord.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWord.MinimumSize = new System.Drawing.Size(16, 12);
            this.PassWord.Name = "PassWord";
            this.PassWord.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.PassWord.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(109, 26);
            this.PassWord.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.PassWord.TabIndex = 189;
            this.PassWord.Tag = "";
            this.PassWord.ThemeName = "Office2016Colorful";
            // 
            // LoginTitle
            // 
            this.LoginTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.Location = new System.Drawing.Point(62, 269);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(44, 16);
            this.LoginTitle.TabIndex = 194;
            this.LoginTitle.Text = "Login:";
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Login.BeforeTouchSize = new System.Drawing.Size(438, 27);
            this.Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login.CanOverrideStyle = true;
            this.Login.CausesValidation = false;
            this.Login.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Login.Location = new System.Drawing.Point(66, 288);
            this.Login.MaxLength = 2000;
            this.Login.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login.MinimumSize = new System.Drawing.Size(16, 12);
            this.Login.Name = "Login";
            this.Login.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.Login.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Login.Size = new System.Drawing.Size(215, 26);
            this.Login.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.Login.TabIndex = 188;
            this.Login.Tag = "";
            this.Login.ThemeName = "Office2016Colorful";
            // 
            // PassWordTitle
            // 
            this.PassWordTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordTitle.Location = new System.Drawing.Point(283, 270);
            this.PassWordTitle.Name = "PassWordTitle";
            this.PassWordTitle.Size = new System.Drawing.Size(50, 16);
            this.PassWordTitle.TabIndex = 193;
            this.PassWordTitle.Text = "Senha:";
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Email.BeforeTouchSize = new System.Drawing.Size(438, 27);
            this.Email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.CanOverrideStyle = true;
            this.Email.CausesValidation = false;
            this.Email.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Email.Location = new System.Drawing.Point(66, 237);
            this.Email.MaxLength = 2000;
            this.Email.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.MinimumSize = new System.Drawing.Size(16, 12);
            this.Email.Name = "Email";
            this.Email.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.Email.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Email.Size = new System.Drawing.Size(440, 26);
            this.Email.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.Email.TabIndex = 187;
            this.Email.Tag = "";
            this.Email.ThemeName = "Office2016Colorful";
            this.Email.WordWrap = false;
            // 
            // EmailTitle
            // 
            this.EmailTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTitle.Location = new System.Drawing.Point(62, 220);
            this.EmailTitle.Name = "EmailTitle";
            this.EmailTitle.Size = new System.Drawing.Size(46, 16);
            this.EmailTitle.TabIndex = 192;
            this.EmailTitle.Text = "E-mail";
            // 
            // UserName
            // 
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserName.BeforeTouchSize = new System.Drawing.Size(438, 27);
            this.UserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.CanOverrideStyle = true;
            this.UserName.CausesValidation = false;
            this.UserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.UserName.Location = new System.Drawing.Point(66, 185);
            this.UserName.MaxLength = 2000;
            this.UserName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.MinimumSize = new System.Drawing.Size(16, 12);
            this.UserName.Name = "UserName";
            this.UserName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.UserName.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.UserName.Size = new System.Drawing.Size(440, 26);
            this.UserName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.UserName.TabIndex = 186;
            this.UserName.Tag = "";
            this.UserName.ThemeName = "Office2016Colorful";
            this.UserName.WordWrap = false;
            // 
            // NameTitle
            // 
            this.NameTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTitle.Location = new System.Drawing.Point(62, 168);
            this.NameTitle.Name = "NameTitle";
            this.NameTitle.Size = new System.Drawing.Size(48, 16);
            this.NameTitle.TabIndex = 191;
            this.NameTitle.Text = "Nome:";
            // 
            // PageBackUp
            // 
            this.PageBackUp.Controls.Add(this.ListviewBackup);
            this.PageBackUp.Controls.Add(this.label13);
            this.PageBackUp.Controls.Add(this.label14);
            this.PageBackUp.Controls.Add(this.ChooseBackup);
            this.PageBackUp.Controls.Add(this.BackupPath);
            this.PageBackUp.Location = new System.Drawing.Point(4, 28);
            this.PageBackUp.Name = "PageBackUp";
            this.PageBackUp.Size = new System.Drawing.Size(609, 426);
            this.PageBackUp.TabIndex = 6;
            this.PageBackUp.Text = "BackUp";
            this.PageBackUp.UseVisualStyleBackColor = true;
            // 
            // ListviewBackup
            // 
            this.ListviewBackup.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.ListviewBackup.BackColor = System.Drawing.Color.Gainsboro;
            this.ListviewBackup.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListviewBackup.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FileList});
            this.ListviewBackup.FullRowSelect = true;
            this.ListviewBackup.GridLines = true;
            this.ListviewBackup.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.ListviewBackup.HideSelection = false;
            this.ListviewBackup.HotTracking = true;
            this.ListviewBackup.HoverSelection = true;
            this.ListviewBackup.Location = new System.Drawing.Point(68, 161);
            this.ListviewBackup.MultiSelect = false;
            this.ListviewBackup.Name = "ListviewBackup";
            this.ListviewBackup.Size = new System.Drawing.Size(438, 177);
            this.ListviewBackup.Sorting = System.Windows.Forms.SortOrder.Descending;
            this.ListviewBackup.TabIndex = 210;
            this.ListviewBackup.UseCompatibleStateImageBehavior = false;
            this.ListviewBackup.View = System.Windows.Forms.View.Details;
            // 
            // FileList
            // 
            this.FileList.Text = "Lista de Arquivos";
            this.FileList.Width = 360;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label13.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label13.Location = new System.Drawing.Point(65, 81);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(424, 48);
            this.label13.TabIndex = 209;
            this.label13.Text = "Por favor, selecione o diretório raiz que contem todos os arquivos do programa co" +
    "mo pastas, fotos e o backup\r\n\r\n\r\n\r\n\r\n\r\n";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label14.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label14.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label14.Location = new System.Drawing.Point(65, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(453, 41);
            this.label14.TabIndex = 207;
            this.label14.Text = "BackUp";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ChooseBackup
            // 
            this.ChooseBackup.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.ChooseBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.ChooseBackup.BeforeTouchSize = new System.Drawing.Size(37, 27);
            this.ChooseBackup.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.ChooseBackup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ChooseBackup.KeepFocusRectangle = false;
            this.ChooseBackup.Location = new System.Drawing.Point(469, 132);
            this.ChooseBackup.Name = "ChooseBackup";
            this.ChooseBackup.Size = new System.Drawing.Size(37, 27);
            this.ChooseBackup.TabIndex = 156;
            this.ChooseBackup.Text = "buttonAdv1";
            this.ChooseBackup.ThemeName = "Office2016White";
            this.ChooseBackup.UseVisualStyle = true;
            this.ChooseBackup.Click += new System.EventHandler(this.ChooseBackup_Click);
            // 
            // BackupPath
            // 
            this.BackupPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BackupPath.BeforeTouchSize = new System.Drawing.Size(438, 27);
            this.BackupPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.BackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackupPath.CanOverrideStyle = true;
            this.BackupPath.CausesValidation = false;
            this.BackupPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BackupPath.Enabled = false;
            this.BackupPath.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.BackupPath.Location = new System.Drawing.Point(68, 132);
            this.BackupPath.MaxLength = 50;
            this.BackupPath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.BackupPath.MinimumSize = new System.Drawing.Size(16, 12);
            this.BackupPath.Multiline = true;
            this.BackupPath.Name = "BackupPath";
            this.BackupPath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.BackupPath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.BackupPath.Size = new System.Drawing.Size(438, 27);
            this.BackupPath.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.BackupPath.TabIndex = 155;
            this.BackupPath.Tag = "";
            this.BackupPath.ThemeName = "Office2016Colorful";
            this.BackupPath.ThemesEnabled = false;
            // 
            // PageFinalize
            // 
            this.PageFinalize.Controls.Add(this.Loading);
            this.PageFinalize.Controls.Add(this.LabelPageFinalizeSubTitle);
            this.PageFinalize.Controls.Add(this.LabelPageFinalizeTitle);
            this.PageFinalize.Location = new System.Drawing.Point(4, 28);
            this.PageFinalize.Name = "PageFinalize";
            this.PageFinalize.Size = new System.Drawing.Size(609, 426);
            this.PageFinalize.TabIndex = 5;
            this.PageFinalize.Text = "Finalize";
            this.PageFinalize.UseVisualStyleBackColor = true;
            // 
            // Loading
            // 
            this.Loading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Loading.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Loading.Image = global::DimStock.Properties.Resources.GigLoading;
            this.Loading.Location = new System.Drawing.Point(230, 165);
            this.Loading.Name = "Loading";
            this.Loading.Size = new System.Drawing.Size(123, 126);
            this.Loading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Loading.TabIndex = 213;
            this.Loading.TabStop = false;
            this.Loading.Visible = false;
            // 
            // LabelPageFinalizeSubTitle
            // 
            this.LabelPageFinalizeSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelPageFinalizeSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelPageFinalizeSubTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPageFinalizeSubTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelPageFinalizeSubTitle.Location = new System.Drawing.Point(117, 121);
            this.LabelPageFinalizeSubTitle.Name = "LabelPageFinalizeSubTitle";
            this.LabelPageFinalizeSubTitle.Size = new System.Drawing.Size(334, 22);
            this.LabelPageFinalizeSubTitle.TabIndex = 223;
            this.LabelPageFinalizeSubTitle.Text = "Estamos salvando suas configurações...";
            this.LabelPageFinalizeSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LabelPageFinalizeTitle
            // 
            this.LabelPageFinalizeTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelPageFinalizeTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelPageFinalizeTitle.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPageFinalizeTitle.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.LabelPageFinalizeTitle.Location = new System.Drawing.Point(111, 77);
            this.LabelPageFinalizeTitle.Name = "LabelPageFinalizeTitle";
            this.LabelPageFinalizeTitle.Size = new System.Drawing.Size(424, 41);
            this.LabelPageFinalizeTitle.TabIndex = 221;
            this.LabelPageFinalizeTitle.Text = "Ok, Aguarde Um Instante";
            this.LabelPageFinalizeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NextPage
            // 
            this.NextPage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.NextPage.AutoSize = true;
            this.NextPage.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage.LinkColor = System.Drawing.Color.SteelBlue;
            this.NextPage.Location = new System.Drawing.Point(605, 554);
            this.NextPage.Name = "NextPage";
            this.NextPage.Size = new System.Drawing.Size(84, 19);
            this.NextPage.TabIndex = 204;
            this.NextPage.TabStop = true;
            this.NextPage.Text = "Próximo >>";
            this.NextPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.NextPage_LinkClicked);
            // 
            // BackPage
            // 
            this.BackPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BackPage.AutoSize = true;
            this.BackPage.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackPage.LinkColor = System.Drawing.Color.SteelBlue;
            this.BackPage.Location = new System.Drawing.Point(244, 554);
            this.BackPage.Name = "BackPage";
            this.BackPage.Size = new System.Drawing.Size(82, 19);
            this.BackPage.TabIndex = 203;
            this.BackPage.TabStop = true;
            this.BackPage.Text = "<< Anterior";
            this.BackPage.Visible = false;
            this.BackPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.BackPage_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DimStock.Properties.Resources.StockLogo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(429, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 72);
            this.pictureBox1.TabIndex = 206;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Location = new System.Drawing.Point(260, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(417, 40);
            this.label2.TabIndex = 205;
            this.label2.Text = "DimStock";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(282, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 41);
            this.label3.TabIndex = 207;
            this.label3.Text = "Assistente de configuração";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CloseAssistant
            // 
            this.CloseAssistant.ActiveBorderThickness = 1;
            this.CloseAssistant.ActiveCornerRadius = 10;
            this.CloseAssistant.ActiveFillColor = System.Drawing.Color.Gray;
            this.CloseAssistant.ActiveForecolor = System.Drawing.Color.White;
            this.CloseAssistant.ActiveLineColor = System.Drawing.Color.Gray;
            this.CloseAssistant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CloseAssistant.BackColor = System.Drawing.Color.White;
            this.CloseAssistant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseAssistant.BackgroundImage")));
            this.CloseAssistant.ButtonText = "Fechar";
            this.CloseAssistant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAssistant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAssistant.ForeColor = System.Drawing.Color.SeaGreen;
            this.CloseAssistant.IdleBorderThickness = 1;
            this.CloseAssistant.IdleCornerRadius = 20;
            this.CloseAssistant.IdleFillColor = System.Drawing.Color.White;
            this.CloseAssistant.IdleForecolor = System.Drawing.Color.Gray;
            this.CloseAssistant.IdleLineColor = System.Drawing.Color.Gray;
            this.CloseAssistant.Location = new System.Drawing.Point(391, 543);
            this.CloseAssistant.Margin = new System.Windows.Forms.Padding(5);
            this.CloseAssistant.Name = "CloseAssistant";
            this.CloseAssistant.Size = new System.Drawing.Size(160, 41);
            this.CloseAssistant.TabIndex = 208;
            this.CloseAssistant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseAssistant.Click += new System.EventHandler(this.CloseAssistant_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(246, 518);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(440, 9);
            this.bunifuSeparator2.TabIndex = 207;
            this.bunifuSeparator2.Transparency = 150;
            this.bunifuSeparator2.Vertical = false;
            // 
            // AppSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(959, 667);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.CloseAssistant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NextPage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackPage);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(959, 667);
            this.Name = "AppSettingsForm";
            this.Text = "AppConfigForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTabControl.ResumeLayout(false);
            this.PageConfigType.ResumeLayout(false);
            this.PageChooseDirectory.ResumeLayout(false);
            this.PageChooseDirectory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MainDirectoryPath)).EndInit();
            this.PageCompanyLogo.ResumeLayout(false);
            this.FrameProductPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyLogoImage)).EndInit();
            this.PageLogin.ResumeLayout(false);
            this.PageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassWordConfirmation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName)).EndInit();
            this.PageBackUp.ResumeLayout(false);
            this.PageBackUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupPath)).EndInit();
            this.PageFinalize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Loading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PageConfigType;
        private System.Windows.Forms.TabPage PageChooseDirectory;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt MainDirectoryPath;
        private System.Windows.Forms.TabPage PageLogin;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt PassWordConfirmation;
        private System.Windows.Forms.Label PassWordConfirmationTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt PassWord;
        private System.Windows.Forms.Label LoginTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt Login;
        private System.Windows.Forms.Label PassWordTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt Email;
        private System.Windows.Forms.Label EmailTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt UserName;
        private System.Windows.Forms.Label NameTitle;
        private System.Windows.Forms.TabPage PageCompanyLogo;
        private System.Windows.Forms.PictureBox CompanyLogoImage;
        private System.Windows.Forms.TabPage PageFinalize;
        private System.Windows.Forms.PictureBox Loading;
        private Syncfusion.Windows.Forms.ButtonAdv ChooseMainDirectory;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.LinkLabel NextPage;
        private System.Windows.Forms.RadioButton CheckBoxNewConfiguration;
        private System.Windows.Forms.RadioButton CheckBoxRestoureBackup;
        private System.Windows.Forms.LinkLabel BackPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseAssistant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private System.Windows.Forms.GroupBox FrameProductPhoto;
        private System.Windows.Forms.Label LabelPageFinalizeSubTitle;
        private System.Windows.Forms.Label LabelPageFinalizeTitle;
        private System.Windows.Forms.TabPage PageBackUp;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private Syncfusion.Windows.Forms.ButtonAdv ChooseBackup;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt BackupPath;
        private System.Windows.Forms.ListView ListviewBackup;
        private System.Windows.Forms.ColumnHeader FileList;
    }
}