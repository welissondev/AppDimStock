namespace DimStock.Screens
{
    partial class AppSettingsScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppSettingsScreen));
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
            this.ButtonChooseMainDirectory = new Syncfusion.Windows.Forms.ButtonAdv();
            this.TextMainDirectoryPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PageCompanyLogo = new System.Windows.Forms.TabPage();
            this.FrameProductPhoto = new System.Windows.Forms.GroupBox();
            this.PictureCompanyLogo = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.PageLogin = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TextPasswordConfirmation = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PassWordConfirmationTitle = new System.Windows.Forms.Label();
            this.TextPassWord = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.TextLogin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PassWordTitle = new System.Windows.Forms.Label();
            this.TextEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.EmailTitle = new System.Windows.Forms.Label();
            this.TextUserName = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.NameTitle = new System.Windows.Forms.Label();
            this.PageBackUp = new System.Windows.Forms.TabPage();
            this.ListviewBackup = new System.Windows.Forms.ListView();
            this.FileList = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.ButtonChooseBackup = new Syncfusion.Windows.Forms.ButtonAdv();
            this.TextBackupPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PageFinalize = new System.Windows.Forms.TabPage();
            this.PictureLoading = new System.Windows.Forms.PictureBox();
            this.LabelPageFinalizeSubTitle = new System.Windows.Forms.Label();
            this.LabelPageFinalizeTitle = new System.Windows.Forms.Label();
            this.ButtonNextPage = new System.Windows.Forms.LinkLabel();
            this.ButtonBackPage = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonCloseAssistant = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.MainTabControl.SuspendLayout();
            this.PageConfigType.SuspendLayout();
            this.PageChooseDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextMainDirectoryPath)).BeginInit();
            this.PageCompanyLogo.SuspendLayout();
            this.FrameProductPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureCompanyLogo)).BeginInit();
            this.PageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextPasswordConfirmation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextUserName)).BeginInit();
            this.PageBackUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBackupPath)).BeginInit();
            this.PageFinalize.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).BeginInit();
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
            this.MainTabControl.Location = new System.Drawing.Point(173, 154);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(577, 409);
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
            this.PageConfigType.Size = new System.Drawing.Size(569, 377);
            this.PageConfigType.TabIndex = 0;
            this.PageConfigType.Text = "Ambiente";
            this.PageConfigType.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(63, 79);
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
            this.CheckBoxNewConfiguration.Location = new System.Drawing.Point(65, 246);
            this.CheckBoxNewConfiguration.Name = "CheckBoxNewConfiguration";
            this.CheckBoxNewConfiguration.Size = new System.Drawing.Size(391, 25);
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
            this.CheckBoxRestoureBackup.Location = new System.Drawing.Point(65, 219);
            this.CheckBoxRestoureBackup.Name = "CheckBoxRestoureBackup";
            this.CheckBoxRestoureBackup.Size = new System.Drawing.Size(391, 25);
            this.CheckBoxRestoureBackup.TabIndex = 0;
            this.CheckBoxRestoureBackup.Text = "Opção A: Já tenho um backup pronto para ser restaurado\r\n";
            this.CheckBoxRestoureBackup.UseCompatibleTextRendering = true;
            this.CheckBoxRestoureBackup.UseVisualStyleBackColor = false;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label21.Location = new System.Drawing.Point(59, 33);
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
            this.label22.Location = new System.Drawing.Point(62, 133);
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
            this.PageChooseDirectory.Controls.Add(this.ButtonChooseMainDirectory);
            this.PageChooseDirectory.Controls.Add(this.TextMainDirectoryPath);
            this.PageChooseDirectory.Location = new System.Drawing.Point(4, 28);
            this.PageChooseDirectory.Name = "PageChooseDirectory";
            this.PageChooseDirectory.Padding = new System.Windows.Forms.Padding(3);
            this.PageChooseDirectory.Size = new System.Drawing.Size(569, 377);
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
            this.label4.Location = new System.Drawing.Point(61, 113);
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
            this.label5.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label5.Location = new System.Drawing.Point(61, 56);
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
            this.label6.Location = new System.Drawing.Point(61, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(424, 69);
            this.label6.TabIndex = 205;
            this.label6.Text = "Essa parte é muito importante, pois nesse diretório principal ficará alocado os a" +
    "rquivos do seu negócio como: pastas, imagens, banco de dados e o backup dos seus" +
    " dados";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonChooseMainDirectory
            // 
            this.ButtonChooseMainDirectory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonChooseMainDirectory.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.ButtonChooseMainDirectory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.ButtonChooseMainDirectory.BeforeTouchSize = new System.Drawing.Size(37, 27);
            this.ButtonChooseMainDirectory.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.ButtonChooseMainDirectory.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ButtonChooseMainDirectory.KeepFocusRectangle = false;
            this.ButtonChooseMainDirectory.Location = new System.Drawing.Point(467, 243);
            this.ButtonChooseMainDirectory.Name = "ButtonChooseMainDirectory";
            this.ButtonChooseMainDirectory.Size = new System.Drawing.Size(37, 27);
            this.ButtonChooseMainDirectory.TabIndex = 154;
            this.ButtonChooseMainDirectory.Text = "buttonAdv1";
            this.ButtonChooseMainDirectory.ThemeName = "Office2016White";
            this.ButtonChooseMainDirectory.UseVisualStyle = true;
            this.ButtonChooseMainDirectory.Click += new System.EventHandler(this.ButtonChooseMainDirectory_Click);
            // 
            // TextMainDirectoryPath
            // 
            this.TextMainDirectoryPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextMainDirectoryPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextMainDirectoryPath.BeforeTouchSize = new System.Drawing.Size(405, 27);
            this.TextMainDirectoryPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextMainDirectoryPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextMainDirectoryPath.CanOverrideStyle = true;
            this.TextMainDirectoryPath.CausesValidation = false;
            this.TextMainDirectoryPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextMainDirectoryPath.Enabled = false;
            this.TextMainDirectoryPath.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextMainDirectoryPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextMainDirectoryPath.Location = new System.Drawing.Point(66, 243);
            this.TextMainDirectoryPath.MaxLength = 50;
            this.TextMainDirectoryPath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TextMainDirectoryPath.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextMainDirectoryPath.Multiline = true;
            this.TextMainDirectoryPath.Name = "TextMainDirectoryPath";
            this.TextMainDirectoryPath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextMainDirectoryPath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextMainDirectoryPath.Size = new System.Drawing.Size(438, 27);
            this.TextMainDirectoryPath.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TextMainDirectoryPath.TabIndex = 149;
            this.TextMainDirectoryPath.Tag = "";
            this.TextMainDirectoryPath.ThemeName = "Office2016Colorful";
            this.TextMainDirectoryPath.ThemesEnabled = false;
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
            this.PageCompanyLogo.Size = new System.Drawing.Size(569, 377);
            this.PageCompanyLogo.TabIndex = 4;
            this.PageCompanyLogo.Text = "Logomarca";
            this.PageCompanyLogo.UseVisualStyleBackColor = true;
            // 
            // FrameProductPhoto
            // 
            this.FrameProductPhoto.BackColor = System.Drawing.Color.White;
            this.FrameProductPhoto.Controls.Add(this.PictureCompanyLogo);
            this.FrameProductPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.FrameProductPhoto.Location = new System.Drawing.Point(69, 168);
            this.FrameProductPhoto.Name = "FrameProductPhoto";
            this.FrameProductPhoto.Size = new System.Drawing.Size(120, 121);
            this.FrameProductPhoto.TabIndex = 218;
            this.FrameProductPhoto.TabStop = false;
            // 
            // PictureCompanyLogo
            // 
            this.PictureCompanyLogo.BackColor = System.Drawing.Color.White;
            this.PictureCompanyLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PictureCompanyLogo.Image = global::DimStock.Properties.Resources.DimStockLogoType;
            this.PictureCompanyLogo.Location = new System.Drawing.Point(7, 16);
            this.PictureCompanyLogo.Name = "PictureCompanyLogo";
            this.PictureCompanyLogo.Size = new System.Drawing.Size(106, 96);
            this.PictureCompanyLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureCompanyLogo.TabIndex = 212;
            this.PictureCompanyLogo.TabStop = false;
            this.PictureCompanyLogo.Click += new System.EventHandler(this.PictureCompanyLogo_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label7.Location = new System.Drawing.Point(67, 78);
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
            this.label8.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label8.Location = new System.Drawing.Point(61, 31);
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
            this.label9.Location = new System.Drawing.Point(67, 111);
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
            this.PageLogin.Controls.Add(this.TextPasswordConfirmation);
            this.PageLogin.Controls.Add(this.PassWordConfirmationTitle);
            this.PageLogin.Controls.Add(this.TextPassWord);
            this.PageLogin.Controls.Add(this.LoginTitle);
            this.PageLogin.Controls.Add(this.TextLogin);
            this.PageLogin.Controls.Add(this.PassWordTitle);
            this.PageLogin.Controls.Add(this.TextEmail);
            this.PageLogin.Controls.Add(this.EmailTitle);
            this.PageLogin.Controls.Add(this.TextUserName);
            this.PageLogin.Controls.Add(this.NameTitle);
            this.PageLogin.Location = new System.Drawing.Point(4, 28);
            this.PageLogin.Name = "PageLogin";
            this.PageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.PageLogin.Size = new System.Drawing.Size(569, 377);
            this.PageLogin.TabIndex = 3;
            this.PageLogin.Text = "Usuário";
            this.PageLogin.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label10.Location = new System.Drawing.Point(62, 63);
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
            this.label11.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label11.Location = new System.Drawing.Point(56, 15);
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
            this.label12.Location = new System.Drawing.Point(62, 92);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(387, 55);
            this.label12.TabIndex = 219;
            this.label12.Text = "Lembre-se que o programa também registrará um login padrão \"admin, admin\" caso vo" +
    "cê esqueça seus dados de acesso\r\n\r\n";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TextPasswordConfirmation
            // 
            this.TextPasswordConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextPasswordConfirmation.BeforeTouchSize = new System.Drawing.Size(405, 27);
            this.TextPasswordConfirmation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextPasswordConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextPasswordConfirmation.CanOverrideStyle = true;
            this.TextPasswordConfirmation.CausesValidation = false;
            this.TextPasswordConfirmation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextPasswordConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPasswordConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextPasswordConfirmation.Location = new System.Drawing.Point(402, 267);
            this.TextPasswordConfirmation.MaxLength = 2000;
            this.TextPasswordConfirmation.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextPasswordConfirmation.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextPasswordConfirmation.Name = "TextPasswordConfirmation";
            this.TextPasswordConfirmation.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TextPasswordConfirmation.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TextPasswordConfirmation.PasswordChar = '*';
            this.TextPasswordConfirmation.Size = new System.Drawing.Size(104, 26);
            this.TextPasswordConfirmation.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TextPasswordConfirmation.TabIndex = 190;
            this.TextPasswordConfirmation.Tag = "";
            this.TextPasswordConfirmation.ThemeName = "Office2016Colorful";
            // 
            // PassWordConfirmationTitle
            // 
            this.PassWordConfirmationTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordConfirmationTitle.Location = new System.Drawing.Point(398, 248);
            this.PassWordConfirmationTitle.Name = "PassWordConfirmationTitle";
            this.PassWordConfirmationTitle.Size = new System.Drawing.Size(110, 16);
            this.PassWordConfirmationTitle.TabIndex = 195;
            this.PassWordConfirmationTitle.Text = "Confirmar Senha:";
            // 
            // TextPassWord
            // 
            this.TextPassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextPassWord.BeforeTouchSize = new System.Drawing.Size(405, 27);
            this.TextPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextPassWord.CanOverrideStyle = true;
            this.TextPassWord.CausesValidation = false;
            this.TextPassWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextPassWord.Location = new System.Drawing.Point(287, 267);
            this.TextPassWord.MaxLength = 2000;
            this.TextPassWord.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextPassWord.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextPassWord.Name = "TextPassWord";
            this.TextPassWord.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TextPassWord.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TextPassWord.PasswordChar = '*';
            this.TextPassWord.Size = new System.Drawing.Size(109, 26);
            this.TextPassWord.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TextPassWord.TabIndex = 189;
            this.TextPassWord.Tag = "";
            this.TextPassWord.ThemeName = "Office2016Colorful";
            // 
            // LoginTitle
            // 
            this.LoginTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.Location = new System.Drawing.Point(62, 248);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(44, 16);
            this.LoginTitle.TabIndex = 194;
            this.LoginTitle.Text = "Login:";
            // 
            // TextLogin
            // 
            this.TextLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextLogin.BeforeTouchSize = new System.Drawing.Size(405, 27);
            this.TextLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextLogin.CanOverrideStyle = true;
            this.TextLogin.CausesValidation = false;
            this.TextLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextLogin.Location = new System.Drawing.Point(66, 267);
            this.TextLogin.MaxLength = 2000;
            this.TextLogin.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextLogin.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextLogin.Name = "TextLogin";
            this.TextLogin.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TextLogin.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TextLogin.Size = new System.Drawing.Size(215, 26);
            this.TextLogin.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TextLogin.TabIndex = 188;
            this.TextLogin.Tag = "";
            this.TextLogin.ThemeName = "Office2016Colorful";
            // 
            // PassWordTitle
            // 
            this.PassWordTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordTitle.Location = new System.Drawing.Point(283, 249);
            this.PassWordTitle.Name = "PassWordTitle";
            this.PassWordTitle.Size = new System.Drawing.Size(50, 16);
            this.PassWordTitle.TabIndex = 193;
            this.PassWordTitle.Text = "Senha:";
            // 
            // TextEmail
            // 
            this.TextEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextEmail.BeforeTouchSize = new System.Drawing.Size(405, 27);
            this.TextEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextEmail.CanOverrideStyle = true;
            this.TextEmail.CausesValidation = false;
            this.TextEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextEmail.Location = new System.Drawing.Point(66, 216);
            this.TextEmail.MaxLength = 2000;
            this.TextEmail.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextEmail.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextEmail.Name = "TextEmail";
            this.TextEmail.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TextEmail.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TextEmail.Size = new System.Drawing.Size(440, 26);
            this.TextEmail.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TextEmail.TabIndex = 187;
            this.TextEmail.Tag = "";
            this.TextEmail.ThemeName = "Office2016Colorful";
            this.TextEmail.WordWrap = false;
            // 
            // EmailTitle
            // 
            this.EmailTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTitle.Location = new System.Drawing.Point(62, 199);
            this.EmailTitle.Name = "EmailTitle";
            this.EmailTitle.Size = new System.Drawing.Size(46, 16);
            this.EmailTitle.TabIndex = 192;
            this.EmailTitle.Text = "E-mail";
            // 
            // TextUserName
            // 
            this.TextUserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextUserName.BeforeTouchSize = new System.Drawing.Size(405, 27);
            this.TextUserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextUserName.CanOverrideStyle = true;
            this.TextUserName.CausesValidation = false;
            this.TextUserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextUserName.Location = new System.Drawing.Point(66, 164);
            this.TextUserName.MaxLength = 2000;
            this.TextUserName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TextUserName.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextUserName.Name = "TextUserName";
            this.TextUserName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TextUserName.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TextUserName.Size = new System.Drawing.Size(440, 26);
            this.TextUserName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TextUserName.TabIndex = 186;
            this.TextUserName.Tag = "";
            this.TextUserName.ThemeName = "Office2016Colorful";
            this.TextUserName.WordWrap = false;
            // 
            // NameTitle
            // 
            this.NameTitle.Font = new System.Drawing.Font("Calibri Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTitle.Location = new System.Drawing.Point(62, 147);
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
            this.PageBackUp.Controls.Add(this.ButtonChooseBackup);
            this.PageBackUp.Controls.Add(this.TextBackupPath);
            this.PageBackUp.Location = new System.Drawing.Point(4, 28);
            this.PageBackUp.Name = "PageBackUp";
            this.PageBackUp.Size = new System.Drawing.Size(569, 377);
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
            this.ListviewBackup.Location = new System.Drawing.Point(68, 137);
            this.ListviewBackup.MultiSelect = false;
            this.ListviewBackup.Name = "ListviewBackup";
            this.ListviewBackup.Size = new System.Drawing.Size(438, 159);
            this.ListviewBackup.Sorting = System.Windows.Forms.SortOrder.Ascending;
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
            this.label13.Location = new System.Drawing.Point(65, 53);
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
            this.label14.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label14.Location = new System.Drawing.Point(65, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(453, 41);
            this.label14.TabIndex = 207;
            this.label14.Text = "BackUp";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonChooseBackup
            // 
            this.ButtonChooseBackup.Appearance = Syncfusion.Windows.Forms.ButtonAppearance.Office2016White;
            this.ButtonChooseBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(165)))), ((int)(((byte)(220)))));
            this.ButtonChooseBackup.BeforeTouchSize = new System.Drawing.Size(37, 27);
            this.ButtonChooseBackup.ButtonType = Syncfusion.Windows.Forms.Tools.ButtonTypes.Browse;
            this.ButtonChooseBackup.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ButtonChooseBackup.KeepFocusRectangle = false;
            this.ButtonChooseBackup.Location = new System.Drawing.Point(469, 104);
            this.ButtonChooseBackup.Name = "ButtonChooseBackup";
            this.ButtonChooseBackup.Size = new System.Drawing.Size(37, 27);
            this.ButtonChooseBackup.TabIndex = 156;
            this.ButtonChooseBackup.Text = "buttonAdv1";
            this.ButtonChooseBackup.ThemeName = "Office2016White";
            this.ButtonChooseBackup.UseVisualStyle = true;
            this.ButtonChooseBackup.Click += new System.EventHandler(this.ButtonChooseBackup_Click);
            // 
            // TextBackupPath
            // 
            this.TextBackupPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TextBackupPath.BeforeTouchSize = new System.Drawing.Size(405, 27);
            this.TextBackupPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TextBackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBackupPath.CanOverrideStyle = true;
            this.TextBackupPath.CausesValidation = false;
            this.TextBackupPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBackupPath.Enabled = false;
            this.TextBackupPath.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBackupPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TextBackupPath.Location = new System.Drawing.Point(68, 104);
            this.TextBackupPath.MaxLength = 50;
            this.TextBackupPath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TextBackupPath.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextBackupPath.Multiline = true;
            this.TextBackupPath.Name = "TextBackupPath";
            this.TextBackupPath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TextBackupPath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TextBackupPath.Size = new System.Drawing.Size(405, 27);
            this.TextBackupPath.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TextBackupPath.TabIndex = 155;
            this.TextBackupPath.Tag = "";
            this.TextBackupPath.ThemeName = "Office2016Colorful";
            this.TextBackupPath.ThemesEnabled = false;
            // 
            // PageFinalize
            // 
            this.PageFinalize.Controls.Add(this.PictureLoading);
            this.PageFinalize.Controls.Add(this.LabelPageFinalizeSubTitle);
            this.PageFinalize.Controls.Add(this.LabelPageFinalizeTitle);
            this.PageFinalize.Location = new System.Drawing.Point(4, 28);
            this.PageFinalize.Name = "PageFinalize";
            this.PageFinalize.Size = new System.Drawing.Size(569, 377);
            this.PageFinalize.TabIndex = 5;
            this.PageFinalize.Text = "Finalize";
            this.PageFinalize.UseVisualStyleBackColor = true;
            // 
            // PictureLoading
            // 
            this.PictureLoading.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PictureLoading.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PictureLoading.Image = global::DimStock.Properties.Resources.Loading;
            this.PictureLoading.Location = new System.Drawing.Point(208, 139);
            this.PictureLoading.Name = "PictureLoading";
            this.PictureLoading.Size = new System.Drawing.Size(123, 126);
            this.PictureLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureLoading.TabIndex = 213;
            this.PictureLoading.TabStop = false;
            this.PictureLoading.Visible = false;
            // 
            // LabelPageFinalizeSubTitle
            // 
            this.LabelPageFinalizeSubTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelPageFinalizeSubTitle.BackColor = System.Drawing.Color.Transparent;
            this.LabelPageFinalizeSubTitle.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPageFinalizeSubTitle.ForeColor = System.Drawing.SystemColors.Desktop;
            this.LabelPageFinalizeSubTitle.Location = new System.Drawing.Point(95, 95);
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
            this.LabelPageFinalizeTitle.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.LabelPageFinalizeTitle.Location = new System.Drawing.Point(89, 51);
            this.LabelPageFinalizeTitle.Name = "LabelPageFinalizeTitle";
            this.LabelPageFinalizeTitle.Size = new System.Drawing.Size(424, 41);
            this.LabelPageFinalizeTitle.TabIndex = 221;
            this.LabelPageFinalizeTitle.Text = "Ok, Aguarde Um Instante";
            this.LabelPageFinalizeTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonNextPage
            // 
            this.ButtonNextPage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ButtonNextPage.AutoSize = true;
            this.ButtonNextPage.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNextPage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonNextPage.Location = new System.Drawing.Point(580, 511);
            this.ButtonNextPage.Name = "ButtonNextPage";
            this.ButtonNextPage.Size = new System.Drawing.Size(84, 19);
            this.ButtonNextPage.TabIndex = 204;
            this.ButtonNextPage.TabStop = true;
            this.ButtonNextPage.Text = "Próximo >>";
            this.ButtonNextPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonNextPage_LinkClicked);
            // 
            // ButtonBackPage
            // 
            this.ButtonBackPage.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonBackPage.AutoSize = true;
            this.ButtonBackPage.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBackPage.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonBackPage.Location = new System.Drawing.Point(234, 511);
            this.ButtonBackPage.Name = "ButtonBackPage";
            this.ButtonBackPage.Size = new System.Drawing.Size(82, 19);
            this.ButtonBackPage.TabIndex = 203;
            this.ButtonBackPage.TabStop = true;
            this.ButtonBackPage.Text = "<< Anterior";
            this.ButtonBackPage.Visible = false;
            this.ButtonBackPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonBackPage_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DimStock.Properties.Resources.DimStockLogoType;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(419, 23);
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
            this.label2.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.label2.Location = new System.Drawing.Point(250, 82);
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
            this.label3.Location = new System.Drawing.Point(272, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(378, 41);
            this.label3.TabIndex = 207;
            this.label3.Text = "Assistente de configuração";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonCloseAssistant
            // 
            this.ButtonCloseAssistant.ActiveBorderThickness = 1;
            this.ButtonCloseAssistant.ActiveCornerRadius = 10;
            this.ButtonCloseAssistant.ActiveFillColor = System.Drawing.Color.Gray;
            this.ButtonCloseAssistant.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonCloseAssistant.ActiveLineColor = System.Drawing.Color.Gray;
            this.ButtonCloseAssistant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCloseAssistant.BackColor = System.Drawing.Color.White;
            this.ButtonCloseAssistant.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCloseAssistant.BackgroundImage")));
            this.ButtonCloseAssistant.ButtonText = "Fechar";
            this.ButtonCloseAssistant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseAssistant.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCloseAssistant.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonCloseAssistant.IdleBorderThickness = 1;
            this.ButtonCloseAssistant.IdleCornerRadius = 20;
            this.ButtonCloseAssistant.IdleFillColor = System.Drawing.Color.White;
            this.ButtonCloseAssistant.IdleForecolor = System.Drawing.Color.Gray;
            this.ButtonCloseAssistant.IdleLineColor = System.Drawing.Color.Gray;
            this.ButtonCloseAssistant.Location = new System.Drawing.Point(374, 501);
            this.ButtonCloseAssistant.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonCloseAssistant.Name = "ButtonCloseAssistant";
            this.ButtonCloseAssistant.Size = new System.Drawing.Size(160, 41);
            this.ButtonCloseAssistant.TabIndex = 208;
            this.ButtonCloseAssistant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonCloseAssistant.Click += new System.EventHandler(this.ButtonCloseAssistant_Click);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.ForeColor = System.Drawing.Color.White;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(243, 481);
            this.bunifuSeparator2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(440, 14);
            this.bunifuSeparator2.TabIndex = 207;
            this.bunifuSeparator2.Transparency = 150;
            this.bunifuSeparator2.Vertical = false;
            // 
            // AppSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(944, 590);
            this.Controls.Add(this.bunifuSeparator2);
            this.Controls.Add(this.ButtonCloseAssistant);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonNextPage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ButtonBackPage);
            this.Controls.Add(this.MainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "AppSettingsForm";
            this.Text = "Assistente de configuração da aplicação";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTabControl.ResumeLayout(false);
            this.PageConfigType.ResumeLayout(false);
            this.PageChooseDirectory.ResumeLayout(false);
            this.PageChooseDirectory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextMainDirectoryPath)).EndInit();
            this.PageCompanyLogo.ResumeLayout(false);
            this.FrameProductPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureCompanyLogo)).EndInit();
            this.PageLogin.ResumeLayout(false);
            this.PageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextPasswordConfirmation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextUserName)).EndInit();
            this.PageBackUp.ResumeLayout(false);
            this.PageBackUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextBackupPath)).EndInit();
            this.PageFinalize.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureLoading)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TabPage PageConfigType;
        private System.Windows.Forms.TabPage PageChooseDirectory;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextMainDirectoryPath;
        private System.Windows.Forms.TabPage PageLogin;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextPasswordConfirmation;
        private System.Windows.Forms.Label PassWordConfirmationTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextPassWord;
        private System.Windows.Forms.Label LoginTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextLogin;
        private System.Windows.Forms.Label PassWordTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextEmail;
        private System.Windows.Forms.Label EmailTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextUserName;
        private System.Windows.Forms.Label NameTitle;
        private System.Windows.Forms.TabPage PageCompanyLogo;
        private System.Windows.Forms.PictureBox PictureCompanyLogo;
        private System.Windows.Forms.TabPage PageFinalize;
        private System.Windows.Forms.PictureBox PictureLoading;
        private Syncfusion.Windows.Forms.ButtonAdv ButtonChooseMainDirectory;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.LinkLabel ButtonNextPage;
        private System.Windows.Forms.RadioButton CheckBoxNewConfiguration;
        private System.Windows.Forms.LinkLabel ButtonBackPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonCloseAssistant;
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
        private Syncfusion.Windows.Forms.ButtonAdv ButtonChooseBackup;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TextBackupPath;
        private System.Windows.Forms.ListView ListviewBackup;
        private System.Windows.Forms.ColumnHeader FileList;
        public System.Windows.Forms.TabControl MainTabControl;
        public System.Windows.Forms.RadioButton CheckBoxRestoureBackup;
    }
}