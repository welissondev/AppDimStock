namespace DimStock.UserForms
{
    partial class AppConfigForm
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
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.PageConfigType = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RestoureConfiguration = new Bunifu.Framework.UI.BunifuTileButton();
            this.StartNewConfiguration = new Bunifu.Framework.UI.BunifuTileButton();
            this.FormNovigationDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PageChooseDirectory = new System.Windows.Forms.TabPage();
            this.ChooseDirectory = new Syncfusion.WinForms.Controls.SfButton();
            this.label4 = new System.Windows.Forms.Label();
            this.DataBasePath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label5 = new System.Windows.Forms.Label();
            this.PageCompany = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.StrieetNumber = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label15 = new System.Windows.Forms.Label();
            this.Cep = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label14 = new System.Windows.Forms.Label();
            this.State = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label13 = new System.Windows.Forms.Label();
            this.City = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label12 = new System.Windows.Forms.Label();
            this.District = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label11 = new System.Windows.Forms.Label();
            this.Address = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label10 = new System.Windows.Forms.Label();
            this.RG_IE = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label9 = new System.Windows.Forms.Label();
            this.CPF_CNPJ = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label8 = new System.Windows.Forms.Label();
            this.SaveCompanyData = new Syncfusion.WinForms.Controls.SfButton();
            this.Company = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PageLogin = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.SaveUserData = new Syncfusion.WinForms.Controls.SfButton();
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
            this.PageCompanyLogo = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LogoImage = new System.Windows.Forms.PictureBox();
            this.ChooseLogo = new Syncfusion.WinForms.Controls.SfButton();
            this.LogoPath = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.MainTabControl.SuspendLayout();
            this.PageConfigType.SuspendLayout();
            this.PageChooseDirectory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBasePath)).BeginInit();
            this.PageCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StrieetNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.State)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.City)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.District)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RG_IE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPF_CNPJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Company)).BeginInit();
            this.PageLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassWordConfirmation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName)).BeginInit();
            this.PageCompanyLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPath)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTabControl
            // 
            this.MainTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MainTabControl.Controls.Add(this.PageConfigType);
            this.MainTabControl.Controls.Add(this.PageChooseDirectory);
            this.MainTabControl.Controls.Add(this.PageCompany);
            this.MainTabControl.Controls.Add(this.PageCompanyLogo);
            this.MainTabControl.Controls.Add(this.PageLogin);
            this.MainTabControl.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTabControl.Location = new System.Drawing.Point(37, 9);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(896, 675);
            this.MainTabControl.TabIndex = 0;
            // 
            // PageConfigType
            // 
            this.PageConfigType.Controls.Add(this.label3);
            this.PageConfigType.Controls.Add(this.label2);
            this.PageConfigType.Controls.Add(this.RestoureConfiguration);
            this.PageConfigType.Controls.Add(this.StartNewConfiguration);
            this.PageConfigType.Controls.Add(this.FormNovigationDescription);
            this.PageConfigType.Controls.Add(this.label1);
            this.PageConfigType.Location = new System.Drawing.Point(4, 27);
            this.PageConfigType.Name = "PageConfigType";
            this.PageConfigType.Padding = new System.Windows.Forms.Padding(3);
            this.PageConfigType.Size = new System.Drawing.Size(888, 828);
            this.PageConfigType.TabIndex = 0;
            this.PageConfigType.Text = "TIPO";
            this.PageConfigType.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(458, 495);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 60);
            this.label3.TabIndex = 18;
            this.label3.Text = "Restaurar Configuração";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(273, 495);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 60);
            this.label2.TabIndex = 17;
            this.label2.Text = "Iniciar Nova Configuração";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestoureConfiguration
            // 
            this.RestoureConfiguration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestoureConfiguration.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.RestoureConfiguration.color = System.Drawing.Color.MediumSeaGreen;
            this.RestoureConfiguration.colorActive = System.Drawing.Color.SeaGreen;
            this.RestoureConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoureConfiguration.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.RestoureConfiguration.ForeColor = System.Drawing.Color.White;
            this.RestoureConfiguration.Image = global::DimStock.Properties.Resources.icon_restoure_bussines_settings;
            this.RestoureConfiguration.ImagePosition = 20;
            this.RestoureConfiguration.ImageZoom = 50;
            this.RestoureConfiguration.LabelPosition = 41;
            this.RestoureConfiguration.LabelText = "";
            this.RestoureConfiguration.Location = new System.Drawing.Point(458, 390);
            this.RestoureConfiguration.Margin = new System.Windows.Forms.Padding(6);
            this.RestoureConfiguration.Name = "RestoureConfiguration";
            this.RestoureConfiguration.Size = new System.Drawing.Size(128, 129);
            this.RestoureConfiguration.TabIndex = 16;
            // 
            // StartNewConfiguration
            // 
            this.StartNewConfiguration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartNewConfiguration.AutoSize = true;
            this.StartNewConfiguration.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.StartNewConfiguration.color = System.Drawing.Color.MediumSeaGreen;
            this.StartNewConfiguration.colorActive = System.Drawing.Color.SeaGreen;
            this.StartNewConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartNewConfiguration.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.StartNewConfiguration.ForeColor = System.Drawing.Color.White;
            this.StartNewConfiguration.Image = global::DimStock.Properties.Resources.icon_new_bussines_settigs;
            this.StartNewConfiguration.ImagePosition = 20;
            this.StartNewConfiguration.ImageZoom = 50;
            this.StartNewConfiguration.LabelPosition = 41;
            this.StartNewConfiguration.LabelText = "";
            this.StartNewConfiguration.Location = new System.Drawing.Point(273, 390);
            this.StartNewConfiguration.Margin = new System.Windows.Forms.Padding(6);
            this.StartNewConfiguration.Name = "StartNewConfiguration";
            this.StartNewConfiguration.Size = new System.Drawing.Size(128, 129);
            this.StartNewConfiguration.TabIndex = 15;
            this.StartNewConfiguration.Click += new System.EventHandler(this.StartNewConfiguration_Click);
            // 
            // FormNovigationDescription
            // 
            this.FormNovigationDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormNovigationDescription.BackColor = System.Drawing.Color.Transparent;
            this.FormNovigationDescription.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNovigationDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormNovigationDescription.Location = new System.Drawing.Point(110, 263);
            this.FormNovigationDescription.Name = "FormNovigationDescription";
            this.FormNovigationDescription.Size = new System.Drawing.Size(637, 42);
            this.FormNovigationDescription.TabIndex = 13;
            this.FormNovigationDescription.Text = "Seja Bem Vindo!";
            this.FormNovigationDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(176, 305);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(520, 53);
            this.label1.TabIndex = 14;
            this.label1.Text = "Antes de começar, precisamos fazer algumas configurações. Selecione uma das opçõe" +
    "s a seguir:\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageChooseDirectory
            // 
            this.PageChooseDirectory.Controls.Add(this.ChooseDirectory);
            this.PageChooseDirectory.Controls.Add(this.label4);
            this.PageChooseDirectory.Controls.Add(this.DataBasePath);
            this.PageChooseDirectory.Controls.Add(this.label5);
            this.PageChooseDirectory.Location = new System.Drawing.Point(4, 27);
            this.PageChooseDirectory.Name = "PageChooseDirectory";
            this.PageChooseDirectory.Padding = new System.Windows.Forms.Padding(3);
            this.PageChooseDirectory.Size = new System.Drawing.Size(888, 644);
            this.PageChooseDirectory.TabIndex = 1;
            this.PageChooseDirectory.Text = "DIRETÓRIO";
            this.PageChooseDirectory.UseVisualStyleBackColor = true;
            // 
            // ChooseDirectory
            // 
            this.ChooseDirectory.AccessibleName = "Button";
            this.ChooseDirectory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChooseDirectory.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseDirectory.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDirectory.ForeColor = System.Drawing.Color.White;
            this.ChooseDirectory.Location = new System.Drawing.Point(670, 342);
            this.ChooseDirectory.Name = "ChooseDirectory";
            this.ChooseDirectory.Size = new System.Drawing.Size(49, 27);
            this.ChooseDirectory.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseDirectory.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseDirectory.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseDirectory.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseDirectory.Style.FocusedForeColor = System.Drawing.Color.White;
            this.ChooseDirectory.Style.ForeColor = System.Drawing.Color.White;
            this.ChooseDirectory.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseDirectory.Style.HoverForeColor = System.Drawing.Color.Black;
            this.ChooseDirectory.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseDirectory.Style.PressedForeColor = System.Drawing.Color.White;
            this.ChooseDirectory.TabIndex = 150;
            this.ChooseDirectory.Text = "Add";
            this.ChooseDirectory.UseVisualStyleBackColor = false;
            this.ChooseDirectory.Click += new System.EventHandler(this.ChooseDirectory_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(115, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(640, 44);
            this.label4.TabIndex = 151;
            this.label4.Text = "Adicione Um Diretório";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DataBasePath
            // 
            this.DataBasePath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataBasePath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataBasePath.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.DataBasePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.DataBasePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataBasePath.CanOverrideStyle = true;
            this.DataBasePath.CausesValidation = false;
            this.DataBasePath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DataBasePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBasePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.DataBasePath.Location = new System.Drawing.Point(173, 342);
            this.DataBasePath.MaxLength = 50;
            this.DataBasePath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.DataBasePath.MinimumSize = new System.Drawing.Size(16, 12);
            this.DataBasePath.Multiline = true;
            this.DataBasePath.Name = "DataBasePath";
            this.DataBasePath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.DataBasePath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.DataBasePath.Size = new System.Drawing.Size(497, 27);
            this.DataBasePath.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.DataBasePath.TabIndex = 149;
            this.DataBasePath.Tag = "";
            this.DataBasePath.ThemeName = "Office2016Colorful";
            this.DataBasePath.ThemesEnabled = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(182, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(525, 54);
            this.label5.TabIndex = 152;
            this.label5.Text = "Nesse diretório ficará alocado os arquivos de seu sistema, como pastas, fotos, ba" +
    "nco de dados e o backup";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageCompany
            // 
            this.PageCompany.Controls.Add(this.label16);
            this.PageCompany.Controls.Add(this.StrieetNumber);
            this.PageCompany.Controls.Add(this.label15);
            this.PageCompany.Controls.Add(this.Cep);
            this.PageCompany.Controls.Add(this.label14);
            this.PageCompany.Controls.Add(this.State);
            this.PageCompany.Controls.Add(this.label13);
            this.PageCompany.Controls.Add(this.City);
            this.PageCompany.Controls.Add(this.label12);
            this.PageCompany.Controls.Add(this.District);
            this.PageCompany.Controls.Add(this.label11);
            this.PageCompany.Controls.Add(this.Address);
            this.PageCompany.Controls.Add(this.label10);
            this.PageCompany.Controls.Add(this.RG_IE);
            this.PageCompany.Controls.Add(this.label9);
            this.PageCompany.Controls.Add(this.CPF_CNPJ);
            this.PageCompany.Controls.Add(this.label8);
            this.PageCompany.Controls.Add(this.SaveCompanyData);
            this.PageCompany.Controls.Add(this.Company);
            this.PageCompany.Controls.Add(this.label6);
            this.PageCompany.Controls.Add(this.label7);
            this.PageCompany.Location = new System.Drawing.Point(4, 27);
            this.PageCompany.Name = "PageCompany";
            this.PageCompany.Padding = new System.Windows.Forms.Padding(3);
            this.PageCompany.Size = new System.Drawing.Size(888, 644);
            this.PageCompany.TabIndex = 2;
            this.PageCompany.Text = "EMPRESA";
            this.PageCompany.UseVisualStyleBackColor = true;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label16.Location = new System.Drawing.Point(618, 512);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 21);
            this.label16.TabIndex = 228;
            this.label16.Text = "Rua Nº:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // StrieetNumber
            // 
            this.StrieetNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StrieetNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.StrieetNumber.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.StrieetNumber.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.StrieetNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StrieetNumber.CanOverrideStyle = true;
            this.StrieetNumber.CausesValidation = false;
            this.StrieetNumber.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StrieetNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrieetNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.StrieetNumber.Location = new System.Drawing.Point(623, 535);
            this.StrieetNumber.MaxLength = 50;
            this.StrieetNumber.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.StrieetNumber.MinimumSize = new System.Drawing.Size(16, 12);
            this.StrieetNumber.Multiline = true;
            this.StrieetNumber.Name = "StrieetNumber";
            this.StrieetNumber.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.StrieetNumber.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.StrieetNumber.Size = new System.Drawing.Size(98, 27);
            this.StrieetNumber.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.StrieetNumber.TabIndex = 227;
            this.StrieetNumber.Tag = "";
            this.StrieetNumber.ThemeName = "Office2016Colorful";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label15.Location = new System.Drawing.Point(513, 512);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(102, 21);
            this.label15.TabIndex = 226;
            this.label15.Text = "Cep:";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Cep
            // 
            this.Cep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Cep.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.Cep.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Cep.CanOverrideStyle = true;
            this.Cep.CausesValidation = false;
            this.Cep.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cep.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Cep.Location = new System.Drawing.Point(519, 535);
            this.Cep.MaxLength = 50;
            this.Cep.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.Cep.MinimumSize = new System.Drawing.Size(16, 12);
            this.Cep.Multiline = true;
            this.Cep.Name = "Cep";
            this.Cep.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.Cep.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.Cep.Size = new System.Drawing.Size(98, 27);
            this.Cep.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.Cep.TabIndex = 225;
            this.Cep.Tag = "";
            this.Cep.ThemeName = "Office2016Colorful";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label14.Location = new System.Drawing.Point(174, 512);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(176, 21);
            this.label14.TabIndex = 224;
            this.label14.Text = "Estado:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // State
            // 
            this.State.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.State.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.State.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.State.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.State.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.State.CanOverrideStyle = true;
            this.State.CausesValidation = false;
            this.State.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.State.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.State.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.State.Location = new System.Drawing.Point(179, 535);
            this.State.MaxLength = 50;
            this.State.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.State.MinimumSize = new System.Drawing.Size(16, 12);
            this.State.Multiline = true;
            this.State.Name = "State";
            this.State.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.State.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.State.Size = new System.Drawing.Size(334, 27);
            this.State.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.State.TabIndex = 223;
            this.State.Tag = "";
            this.State.ThemeName = "Office2016Colorful";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label13.Location = new System.Drawing.Point(354, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(180, 21);
            this.label13.TabIndex = 222;
            this.label13.Text = "Cidade:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // City
            // 
            this.City.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.City.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.City.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.City.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.City.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.City.CanOverrideStyle = true;
            this.City.CausesValidation = false;
            this.City.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.City.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.City.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.City.Location = new System.Drawing.Point(361, 472);
            this.City.MaxLength = 50;
            this.City.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.City.MinimumSize = new System.Drawing.Size(16, 12);
            this.City.Multiline = true;
            this.City.Name = "City";
            this.City.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.City.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.City.Size = new System.Drawing.Size(360, 27);
            this.City.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.City.TabIndex = 221;
            this.City.Tag = "";
            this.City.ThemeName = "Office2016Colorful";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label12.Location = new System.Drawing.Point(174, 449);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(176, 21);
            this.label12.TabIndex = 220;
            this.label12.Text = "Bairro:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // District
            // 
            this.District.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.District.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.District.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.District.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.District.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.District.CanOverrideStyle = true;
            this.District.CausesValidation = false;
            this.District.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.District.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.District.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.District.Location = new System.Drawing.Point(179, 472);
            this.District.MaxLength = 50;
            this.District.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.District.MinimumSize = new System.Drawing.Size(16, 12);
            this.District.Multiline = true;
            this.District.Name = "District";
            this.District.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.District.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.District.Size = new System.Drawing.Size(176, 27);
            this.District.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.District.TabIndex = 219;
            this.District.Tag = "";
            this.District.ThemeName = "Office2016Colorful";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label11.Location = new System.Drawing.Point(174, 385);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(176, 21);
            this.label11.TabIndex = 218;
            this.label11.Text = "Endereço:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Address.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.Address.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Address.CanOverrideStyle = true;
            this.Address.CausesValidation = false;
            this.Address.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Address.Location = new System.Drawing.Point(179, 408);
            this.Address.MaxLength = 50;
            this.Address.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.Address.MinimumSize = new System.Drawing.Size(16, 12);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.Address.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.Address.Size = new System.Drawing.Size(542, 27);
            this.Address.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.Address.TabIndex = 217;
            this.Address.Tag = "";
            this.Address.ThemeName = "Office2016Colorful";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Location = new System.Drawing.Point(174, 320);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(176, 21);
            this.label10.TabIndex = 216;
            this.label10.Text = "RG \\ IE";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RG_IE
            // 
            this.RG_IE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RG_IE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.RG_IE.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.RG_IE.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.RG_IE.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RG_IE.CanOverrideStyle = true;
            this.RG_IE.CausesValidation = false;
            this.RG_IE.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.RG_IE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RG_IE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.RG_IE.Location = new System.Drawing.Point(179, 343);
            this.RG_IE.MaxLength = 50;
            this.RG_IE.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.RG_IE.MinimumSize = new System.Drawing.Size(16, 12);
            this.RG_IE.Multiline = true;
            this.RG_IE.Name = "RG_IE";
            this.RG_IE.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.RG_IE.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.RG_IE.Size = new System.Drawing.Size(542, 27);
            this.RG_IE.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.RG_IE.TabIndex = 215;
            this.RG_IE.Tag = "";
            this.RG_IE.ThemeName = "Office2016Colorful";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(174, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 21);
            this.label9.TabIndex = 214;
            this.label9.Text = "CPF \\ CNPJ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPF_CNPJ
            // 
            this.CPF_CNPJ.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CPF_CNPJ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CPF_CNPJ.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.CPF_CNPJ.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.CPF_CNPJ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CPF_CNPJ.CanOverrideStyle = true;
            this.CPF_CNPJ.CausesValidation = false;
            this.CPF_CNPJ.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.CPF_CNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF_CNPJ.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.CPF_CNPJ.Location = new System.Drawing.Point(179, 276);
            this.CPF_CNPJ.MaxLength = 50;
            this.CPF_CNPJ.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.CPF_CNPJ.MinimumSize = new System.Drawing.Size(16, 12);
            this.CPF_CNPJ.Multiline = true;
            this.CPF_CNPJ.Name = "CPF_CNPJ";
            this.CPF_CNPJ.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.CPF_CNPJ.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.CPF_CNPJ.Size = new System.Drawing.Size(542, 27);
            this.CPF_CNPJ.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.CPF_CNPJ.TabIndex = 213;
            this.CPF_CNPJ.Tag = "";
            this.CPF_CNPJ.ThemeName = "Office2016Colorful";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(174, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 21);
            this.label8.TabIndex = 212;
            this.label8.Text = "Nome \\ Empresa";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SaveCompanyData
            // 
            this.SaveCompanyData.AccessibleName = "Button";
            this.SaveCompanyData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveCompanyData.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveCompanyData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveCompanyData.ForeColor = System.Drawing.Color.White;
            this.SaveCompanyData.Location = new System.Drawing.Point(179, 586);
            this.SaveCompanyData.Name = "SaveCompanyData";
            this.SaveCompanyData.Size = new System.Drawing.Size(106, 46);
            this.SaveCompanyData.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveCompanyData.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveCompanyData.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveCompanyData.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveCompanyData.Style.FocusedForeColor = System.Drawing.Color.White;
            this.SaveCompanyData.Style.ForeColor = System.Drawing.Color.White;
            this.SaveCompanyData.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveCompanyData.Style.HoverForeColor = System.Drawing.Color.Black;
            this.SaveCompanyData.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveCompanyData.Style.PressedForeColor = System.Drawing.Color.White;
            this.SaveCompanyData.TabIndex = 211;
            this.SaveCompanyData.Text = "Salvar";
            this.SaveCompanyData.UseVisualStyleBackColor = false;
            this.SaveCompanyData.Click += new System.EventHandler(this.SaveCompanyData_Click);
            // 
            // Company
            // 
            this.Company.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Company.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Company.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.Company.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Company.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Company.CanOverrideStyle = true;
            this.Company.CausesValidation = false;
            this.Company.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Company.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Company.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Company.Location = new System.Drawing.Point(179, 209);
            this.Company.MaxLength = 50;
            this.Company.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.Company.MinimumSize = new System.Drawing.Size(16, 12);
            this.Company.Multiline = true;
            this.Company.Name = "Company";
            this.Company.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.Company.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.Company.Size = new System.Drawing.Size(542, 27);
            this.Company.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.Company.TabIndex = 210;
            this.Company.Tag = "";
            this.Company.ThemeName = "Office2016Colorful";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(118, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(640, 49);
            this.label6.TabIndex = 208;
            this.label6.Text = "Dados Da Empresa";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(195, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(525, 54);
            this.label7.TabIndex = 209;
            this.label7.Text = "Esses dados serão arquivados no seu banco de dados, serão mantidos apenas para fi" +
    "ns de configuração no sistema";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageLogin
            // 
            this.PageLogin.Controls.Add(this.label17);
            this.PageLogin.Controls.Add(this.label18);
            this.PageLogin.Controls.Add(this.SaveUserData);
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
            this.PageLogin.Location = new System.Drawing.Point(4, 27);
            this.PageLogin.Name = "PageLogin";
            this.PageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.PageLogin.Size = new System.Drawing.Size(888, 644);
            this.PageLogin.TabIndex = 3;
            this.PageLogin.Text = "LOGIN";
            this.PageLogin.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label17.Location = new System.Drawing.Point(119, 102);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(640, 41);
            this.label17.TabIndex = 197;
            this.label17.Text = "Cadastre Seu Usuário";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label18.Location = new System.Drawing.Point(215, 143);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(441, 70);
            this.label18.TabIndex = 198;
            this.label18.Text = "Cadastre seu login de usuário para acessar o sistema, caso você esquecer esses da" +
    "dos lembre-se que o acesso padrão é Login: Admin  Senha: Admin";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveUserData
            // 
            this.SaveUserData.AccessibleName = "Button";
            this.SaveUserData.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SaveUserData.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveUserData.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveUserData.ForeColor = System.Drawing.Color.White;
            this.SaveUserData.Location = new System.Drawing.Point(139, 494);
            this.SaveUserData.Name = "SaveUserData";
            this.SaveUserData.Size = new System.Drawing.Size(106, 51);
            this.SaveUserData.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveUserData.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveUserData.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveUserData.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveUserData.Style.FocusedForeColor = System.Drawing.Color.White;
            this.SaveUserData.Style.ForeColor = System.Drawing.Color.White;
            this.SaveUserData.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveUserData.Style.HoverForeColor = System.Drawing.Color.Black;
            this.SaveUserData.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SaveUserData.Style.PressedForeColor = System.Drawing.Color.White;
            this.SaveUserData.TabIndex = 196;
            this.SaveUserData.Text = "Salvar";
            this.SaveUserData.UseVisualStyleBackColor = false;
            this.SaveUserData.Click += new System.EventHandler(this.SaveUserData_Click);
            // 
            // PassWordConfirmation
            // 
            this.PassWordConfirmation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassWordConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PassWordConfirmation.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.PassWordConfirmation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.PassWordConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWordConfirmation.CanOverrideStyle = true;
            this.PassWordConfirmation.CausesValidation = false;
            this.PassWordConfirmation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassWordConfirmation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PassWordConfirmation.Location = new System.Drawing.Point(139, 449);
            this.PassWordConfirmation.MaxLength = 2000;
            this.PassWordConfirmation.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWordConfirmation.MinimumSize = new System.Drawing.Size(16, 12);
            this.PassWordConfirmation.Name = "PassWordConfirmation";
            this.PassWordConfirmation.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.PassWordConfirmation.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.PassWordConfirmation.PasswordChar = '*';
            this.PassWordConfirmation.Size = new System.Drawing.Size(342, 26);
            this.PassWordConfirmation.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.PassWordConfirmation.TabIndex = 190;
            this.PassWordConfirmation.Tag = "";
            this.PassWordConfirmation.ThemeName = "Office2016Colorful";
            // 
            // PassWordConfirmationTitle
            // 
            this.PassWordConfirmationTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassWordConfirmationTitle.AutoSize = true;
            this.PassWordConfirmationTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordConfirmationTitle.Location = new System.Drawing.Point(135, 431);
            this.PassWordConfirmationTitle.Name = "PassWordConfirmationTitle";
            this.PassWordConfirmationTitle.Size = new System.Drawing.Size(110, 16);
            this.PassWordConfirmationTitle.TabIndex = 195;
            this.PassWordConfirmationTitle.Text = "Confirmar Senha:";
            // 
            // PassWord
            // 
            this.PassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassWord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.PassWord.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.PassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.PassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWord.CanOverrideStyle = true;
            this.PassWord.CausesValidation = false;
            this.PassWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.PassWord.Location = new System.Drawing.Point(139, 398);
            this.PassWord.MaxLength = 2000;
            this.PassWord.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWord.MinimumSize = new System.Drawing.Size(16, 12);
            this.PassWord.Name = "PassWord";
            this.PassWord.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.PassWord.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(342, 26);
            this.PassWord.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.PassWord.TabIndex = 189;
            this.PassWord.Tag = "";
            this.PassWord.ThemeName = "Office2016Colorful";
            // 
            // LoginTitle
            // 
            this.LoginTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.Location = new System.Drawing.Point(135, 328);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(44, 16);
            this.LoginTitle.TabIndex = 194;
            this.LoginTitle.Text = "Login:";
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Login.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login.CanOverrideStyle = true;
            this.Login.CausesValidation = false;
            this.Login.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Login.Location = new System.Drawing.Point(139, 347);
            this.Login.MaxLength = 2000;
            this.Login.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login.MinimumSize = new System.Drawing.Size(16, 12);
            this.Login.Name = "Login";
            this.Login.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.Login.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Login.Size = new System.Drawing.Size(342, 26);
            this.Login.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.Login.TabIndex = 188;
            this.Login.Tag = "";
            this.Login.ThemeName = "Office2016Colorful";
            // 
            // PassWordTitle
            // 
            this.PassWordTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassWordTitle.AutoSize = true;
            this.PassWordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordTitle.Location = new System.Drawing.Point(135, 380);
            this.PassWordTitle.Name = "PassWordTitle";
            this.PassWordTitle.Size = new System.Drawing.Size(50, 16);
            this.PassWordTitle.TabIndex = 193;
            this.PassWordTitle.Text = "Senha:";
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Email.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.Email.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.Email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Email.CanOverrideStyle = true;
            this.Email.CausesValidation = false;
            this.Email.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.Email.Location = new System.Drawing.Point(139, 296);
            this.Email.MaxLength = 2000;
            this.Email.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Email.MinimumSize = new System.Drawing.Size(16, 12);
            this.Email.Name = "Email";
            this.Email.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.Email.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Email.Size = new System.Drawing.Size(609, 26);
            this.Email.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.Email.TabIndex = 187;
            this.Email.Tag = "";
            this.Email.ThemeName = "Office2016Colorful";
            this.Email.WordWrap = false;
            // 
            // EmailTitle
            // 
            this.EmailTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.EmailTitle.AutoSize = true;
            this.EmailTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTitle.Location = new System.Drawing.Point(135, 279);
            this.EmailTitle.Name = "EmailTitle";
            this.EmailTitle.Size = new System.Drawing.Size(46, 16);
            this.EmailTitle.TabIndex = 192;
            this.EmailTitle.Text = "E-mail";
            // 
            // UserName
            // 
            this.UserName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UserName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.UserName.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.UserName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.UserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UserName.CanOverrideStyle = true;
            this.UserName.CausesValidation = false;
            this.UserName.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.UserName.Location = new System.Drawing.Point(139, 244);
            this.UserName.MaxLength = 2000;
            this.UserName.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.UserName.MinimumSize = new System.Drawing.Size(16, 12);
            this.UserName.Name = "UserName";
            this.UserName.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.UserName.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.UserName.Size = new System.Drawing.Size(609, 26);
            this.UserName.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.UserName.TabIndex = 186;
            this.UserName.Tag = "";
            this.UserName.ThemeName = "Office2016Colorful";
            this.UserName.WordWrap = false;
            // 
            // NameTitle
            // 
            this.NameTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NameTitle.AutoSize = true;
            this.NameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTitle.Location = new System.Drawing.Point(135, 227);
            this.NameTitle.Name = "NameTitle";
            this.NameTitle.Size = new System.Drawing.Size(48, 16);
            this.NameTitle.TabIndex = 191;
            this.NameTitle.Text = "Nome:";
            // 
            // PageCompanyLogo
            // 
            this.PageCompanyLogo.Controls.Add(this.ChooseLogo);
            this.PageCompanyLogo.Controls.Add(this.LogoPath);
            this.PageCompanyLogo.Controls.Add(this.LogoImage);
            this.PageCompanyLogo.Controls.Add(this.label19);
            this.PageCompanyLogo.Controls.Add(this.label20);
            this.PageCompanyLogo.Location = new System.Drawing.Point(4, 27);
            this.PageCompanyLogo.Name = "PageCompanyLogo";
            this.PageCompanyLogo.Padding = new System.Windows.Forms.Padding(3);
            this.PageCompanyLogo.Size = new System.Drawing.Size(888, 644);
            this.PageCompanyLogo.TabIndex = 4;
            this.PageCompanyLogo.Text = "LOGO";
            this.PageCompanyLogo.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label19.Location = new System.Drawing.Point(103, 130);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(640, 49);
            this.label19.TabIndex = 210;
            this.label19.Text = "Insira Sua Logo";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label20.Location = new System.Drawing.Point(180, 169);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(525, 54);
            this.label20.TabIndex = 211;
            this.label20.Text = "Defina uma logo marca do tipo .jpeg, caso você não definir um logo o sistema usar" +
    "á a logomarca padrão do aplicativo\r\n";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogoImage
            // 
            this.LogoImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoImage.BackColor = System.Drawing.SystemColors.Control;
            this.LogoImage.Location = new System.Drawing.Point(336, 248);
            this.LogoImage.Name = "LogoImage";
            this.LogoImage.Size = new System.Drawing.Size(172, 174);
            this.LogoImage.TabIndex = 212;
            this.LogoImage.TabStop = false;
            // 
            // ChooseLogo
            // 
            this.ChooseLogo.AccessibleName = "Button";
            this.ChooseLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChooseLogo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseLogo.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseLogo.ForeColor = System.Drawing.Color.White;
            this.ChooseLogo.Location = new System.Drawing.Point(656, 457);
            this.ChooseLogo.Name = "ChooseLogo";
            this.ChooseLogo.Size = new System.Drawing.Size(49, 27);
            this.ChooseLogo.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseLogo.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseLogo.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseLogo.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseLogo.Style.FocusedForeColor = System.Drawing.Color.White;
            this.ChooseLogo.Style.ForeColor = System.Drawing.Color.White;
            this.ChooseLogo.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseLogo.Style.HoverForeColor = System.Drawing.Color.Black;
            this.ChooseLogo.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.ChooseLogo.Style.PressedForeColor = System.Drawing.Color.White;
            this.ChooseLogo.TabIndex = 214;
            this.ChooseLogo.Text = "Add";
            this.ChooseLogo.UseVisualStyleBackColor = false;
            // 
            // LogoPath
            // 
            this.LogoPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LogoPath.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LogoPath.BeforeTouchSize = new System.Drawing.Size(497, 27);
            this.LogoPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.LogoPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoPath.CanOverrideStyle = true;
            this.LogoPath.CausesValidation = false;
            this.LogoPath.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.LogoPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoPath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.LogoPath.Location = new System.Drawing.Point(159, 457);
            this.LogoPath.MaxLength = 50;
            this.LogoPath.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.LogoPath.MinimumSize = new System.Drawing.Size(16, 12);
            this.LogoPath.Multiline = true;
            this.LogoPath.Name = "LogoPath";
            this.LogoPath.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.LogoPath.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.LogoPath.Size = new System.Drawing.Size(497, 27);
            this.LogoPath.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.LogoPath.TabIndex = 213;
            this.LogoPath.Tag = "";
            this.LogoPath.ThemeName = "Office2016Colorful";
            this.LogoPath.ThemesEnabled = false;
            // 
            // AppConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 694);
            this.Controls.Add(this.MainTabControl);
            this.Name = "AppConfigForm";
            this.Text = "AppConfigForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainTabControl.ResumeLayout(false);
            this.PageConfigType.ResumeLayout(false);
            this.PageConfigType.PerformLayout();
            this.PageChooseDirectory.ResumeLayout(false);
            this.PageChooseDirectory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataBasePath)).EndInit();
            this.PageCompany.ResumeLayout(false);
            this.PageCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StrieetNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.State)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.City)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.District)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Address)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RG_IE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CPF_CNPJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Company)).EndInit();
            this.PageLogin.ResumeLayout(false);
            this.PageLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PassWordConfirmation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserName)).EndInit();
            this.PageCompanyLogo.ResumeLayout(false);
            this.PageCompanyLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPath)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage PageConfigType;
        private System.Windows.Forms.TabPage PageChooseDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTileButton RestoureConfiguration;
        private Bunifu.Framework.UI.BunifuTileButton StartNewConfiguration;
        private System.Windows.Forms.Label FormNovigationDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage PageCompany;
        private Syncfusion.WinForms.Controls.SfButton ChooseDirectory;
        private System.Windows.Forms.Label label4;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt DataBasePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label16;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt StrieetNumber;
        private System.Windows.Forms.Label label15;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Cep;
        private System.Windows.Forms.Label label14;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt State;
        private System.Windows.Forms.Label label13;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt City;
        private System.Windows.Forms.Label label12;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt District;
        private System.Windows.Forms.Label label11;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Address;
        private System.Windows.Forms.Label label10;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt RG_IE;
        private System.Windows.Forms.Label label9;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt CPF_CNPJ;
        private System.Windows.Forms.Label label8;
        private Syncfusion.WinForms.Controls.SfButton SaveCompanyData;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt Company;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage PageLogin;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private Syncfusion.WinForms.Controls.SfButton SaveUserData;
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
        private Syncfusion.WinForms.Controls.SfButton ChooseLogo;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt LogoPath;
        private System.Windows.Forms.PictureBox LogoImage;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
    }
}