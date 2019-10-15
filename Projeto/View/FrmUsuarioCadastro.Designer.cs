namespace SysEstoque.View
{
    partial class FrmUsuarioCadastro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsuarioCadastro));
            this.TxtNome = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblNome = new System.Windows.Forms.Label();
            this.TxtEmail = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblEmail = new System.Windows.Forms.Label();
            this.TxtLogin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblSenha = new System.Windows.Forms.Label();
            this.TxtSenha = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblLogin = new System.Windows.Forms.Label();
            this.PanelHorizontalSuperior = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.BtnSalvar = new Syncfusion.WinForms.Controls.SfButton();
            this.LblDataLong = new System.Windows.Forms.Label();
            this.LblCaptionAtividade = new System.Windows.Forms.Label();
            this.BtnNovaAtividade = new Syncfusion.WinForms.Controls.SfButton();
            this.GbxPermissoes = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ChkPermissaoVisualizar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label4 = new System.Windows.Forms.Label();
            this.ChkPermissaoTodas = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label3 = new System.Windows.Forms.Label();
            this.ChkPermissaoDeletar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ChkPermissaoEditar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ChkPermissaoCadastrar = new Bunifu.Framework.UI.BunifuCheckbox();
            this.TxtConfirmarSenha = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblConfirmarSenha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenha)).BeginInit();
            this.PanelHorizontalSuperior.SuspendLayout();
            this.GbxPermissoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConfirmarSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtNome
            // 
            this.TxtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtNome.BeforeTouchSize = new System.Drawing.Size(794, 29);
            this.TxtNome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtNome.CanOverrideStyle = true;
            this.TxtNome.CausesValidation = false;
            this.TxtNome.CornerRadius = 4;
            this.TxtNome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtNome.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtNome.Location = new System.Drawing.Point(84, 169);
            this.TxtNome.MaxLength = 2000;
            this.TxtNome.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtNome.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtNome.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtNome.Size = new System.Drawing.Size(794, 29);
            this.TxtNome.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtNome.TabIndex = 0;
            this.TxtNome.Tag = "";
            this.TxtNome.ThemeName = "Office2016White";
            this.TxtNome.WordWrap = false;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(84, 153);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(48, 16);
            this.LblNome.TabIndex = 83;
            this.LblNome.Text = "Nome:";
            // 
            // TxtEmail
            // 
            this.TxtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtEmail.BeforeTouchSize = new System.Drawing.Size(794, 29);
            this.TxtEmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmail.CanOverrideStyle = true;
            this.TxtEmail.CausesValidation = false;
            this.TxtEmail.CornerRadius = 4;
            this.TxtEmail.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtEmail.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtEmail.Location = new System.Drawing.Point(84, 221);
            this.TxtEmail.MaxLength = 2000;
            this.TxtEmail.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtEmail.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtEmail.Name = "TxtEmail";
            this.TxtEmail.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtEmail.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtEmail.Size = new System.Drawing.Size(794, 29);
            this.TxtEmail.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtEmail.TabIndex = 1;
            this.TxtEmail.Tag = "";
            this.TxtEmail.ThemeName = "Office2016White";
            this.TxtEmail.WordWrap = false;
            // 
            // LblEmail
            // 
            this.LblEmail.AutoSize = true;
            this.LblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmail.Location = new System.Drawing.Point(84, 202);
            this.LblEmail.Name = "LblEmail";
            this.LblEmail.Size = new System.Drawing.Size(46, 16);
            this.LblEmail.TabIndex = 85;
            this.LblEmail.Text = "E-mail";
            // 
            // TxtLogin
            // 
            this.TxtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtLogin.BeforeTouchSize = new System.Drawing.Size(794, 29);
            this.TxtLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLogin.CanOverrideStyle = true;
            this.TxtLogin.CausesValidation = false;
            this.TxtLogin.CornerRadius = 4;
            this.TxtLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtLogin.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtLogin.Location = new System.Drawing.Point(84, 279);
            this.TxtLogin.MaxLength = 2000;
            this.TxtLogin.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtLogin.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtLogin.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtLogin.Size = new System.Drawing.Size(342, 29);
            this.TxtLogin.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtLogin.TabIndex = 2;
            this.TxtLogin.Tag = "";
            this.TxtLogin.ThemeName = "Office2016White";
            // 
            // LblSenha
            // 
            this.LblSenha.AutoSize = true;
            this.LblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSenha.Location = new System.Drawing.Point(84, 322);
            this.LblSenha.Name = "LblSenha";
            this.LblSenha.Size = new System.Drawing.Size(50, 16);
            this.LblSenha.TabIndex = 87;
            this.LblSenha.Text = "Senha:";
            // 
            // TxtSenha
            // 
            this.TxtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtSenha.BeforeTouchSize = new System.Drawing.Size(794, 29);
            this.TxtSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtSenha.CanOverrideStyle = true;
            this.TxtSenha.CausesValidation = false;
            this.TxtSenha.CornerRadius = 4;
            this.TxtSenha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtSenha.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtSenha.Location = new System.Drawing.Point(84, 341);
            this.TxtSenha.MaxLength = 2000;
            this.TxtSenha.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtSenha.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtSenha.Name = "TxtSenha";
            this.TxtSenha.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtSenha.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtSenha.PasswordChar = '*';
            this.TxtSenha.Size = new System.Drawing.Size(342, 29);
            this.TxtSenha.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtSenha.TabIndex = 3;
            this.TxtSenha.Tag = "";
            this.TxtSenha.ThemeName = "Office2016White";
            // 
            // LblLogin
            // 
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(84, 260);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(44, 16);
            this.LblLogin.TabIndex = 89;
            this.LblLogin.Text = "Login:";
            // 
            // PanelHorizontalSuperior
            // 
            this.PanelHorizontalSuperior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelHorizontalSuperior.BackgroundImage")));
            this.PanelHorizontalSuperior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelHorizontalSuperior.Controls.Add(this.BtnSalvar);
            this.PanelHorizontalSuperior.Controls.Add(this.LblDataLong);
            this.PanelHorizontalSuperior.Controls.Add(this.LblCaptionAtividade);
            this.PanelHorizontalSuperior.Controls.Add(this.BtnNovaAtividade);
            this.PanelHorizontalSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHorizontalSuperior.GradientBottomLeft = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientBottomRight = System.Drawing.SystemColors.MenuHighlight;
            this.PanelHorizontalSuperior.GradientTopLeft = System.Drawing.SystemColors.ControlText;
            this.PanelHorizontalSuperior.GradientTopRight = System.Drawing.SystemColors.ControlText;
            this.PanelHorizontalSuperior.Location = new System.Drawing.Point(0, 0);
            this.PanelHorizontalSuperior.Name = "PanelHorizontalSuperior";
            this.PanelHorizontalSuperior.Quality = 10;
            this.PanelHorizontalSuperior.Size = new System.Drawing.Size(964, 100);
            this.PanelHorizontalSuperior.TabIndex = 140;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.AccessibleName = "Button";
            this.BtnSalvar.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSalvar.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Location = new System.Drawing.Point(100, 51);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(80, 35);
            this.BtnSalvar.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Style.ForeColor = System.Drawing.Color.White;
            this.BtnSalvar.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSalvar.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnSalvar.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnSalvar.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = false;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // LblDataLong
            // 
            this.LblDataLong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.LblDataLong.BackColor = System.Drawing.Color.Transparent;
            this.LblDataLong.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataLong.ForeColor = System.Drawing.Color.White;
            this.LblDataLong.Location = new System.Drawing.Point(497, 26);
            this.LblDataLong.Name = "LblDataLong";
            this.LblDataLong.Size = new System.Drawing.Size(455, 40);
            this.LblDataLong.TabIndex = 139;
            this.LblDataLong.Text = "Data de hoje";
            this.LblDataLong.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LblCaptionAtividade
            // 
            this.LblCaptionAtividade.AutoSize = true;
            this.LblCaptionAtividade.BackColor = System.Drawing.Color.Transparent;
            this.LblCaptionAtividade.Font = new System.Drawing.Font("Cambria", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCaptionAtividade.ForeColor = System.Drawing.Color.White;
            this.LblCaptionAtividade.Location = new System.Drawing.Point(10, 8);
            this.LblCaptionAtividade.Name = "LblCaptionAtividade";
            this.LblCaptionAtividade.Size = new System.Drawing.Size(331, 40);
            this.LblCaptionAtividade.TabIndex = 138;
            this.LblCaptionAtividade.Text = "Cadastro De Usuários";
            // 
            // BtnNovaAtividade
            // 
            this.BtnNovaAtividade.AccessibleName = "Button";
            this.BtnNovaAtividade.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNovaAtividade.ForeColor = System.Drawing.Color.White;
            this.BtnNovaAtividade.Location = new System.Drawing.Point(17, 51);
            this.BtnNovaAtividade.Name = "BtnNovaAtividade";
            this.BtnNovaAtividade.Size = new System.Drawing.Size(80, 35);
            this.BtnNovaAtividade.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnNovaAtividade.Style.ForeColor = System.Drawing.Color.White;
            this.BtnNovaAtividade.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnNovaAtividade.Style.HoverForeColor = System.Drawing.Color.Black;
            this.BtnNovaAtividade.Style.PressedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnNovaAtividade.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnNovaAtividade.TabIndex = 137;
            this.BtnNovaAtividade.Text = "Novo";
            this.BtnNovaAtividade.UseVisualStyleBackColor = false;
            this.BtnNovaAtividade.Click += new System.EventHandler(this.BtnNovaAtividade_Click);
            // 
            // GbxPermissoes
            // 
            this.GbxPermissoes.Controls.Add(this.label5);
            this.GbxPermissoes.Controls.Add(this.ChkPermissaoVisualizar);
            this.GbxPermissoes.Controls.Add(this.label4);
            this.GbxPermissoes.Controls.Add(this.ChkPermissaoTodas);
            this.GbxPermissoes.Controls.Add(this.label3);
            this.GbxPermissoes.Controls.Add(this.ChkPermissaoDeletar);
            this.GbxPermissoes.Controls.Add(this.label2);
            this.GbxPermissoes.Controls.Add(this.label1);
            this.GbxPermissoes.Controls.Add(this.ChkPermissaoEditar);
            this.GbxPermissoes.Controls.Add(this.ChkPermissaoCadastrar);
            this.GbxPermissoes.Location = new System.Drawing.Point(81, 466);
            this.GbxPermissoes.Name = "GbxPermissoes";
            this.GbxPermissoes.Size = new System.Drawing.Size(794, 79);
            this.GbxPermissoes.TabIndex = 141;
            this.GbxPermissoes.TabStop = false;
            this.GbxPermissoes.Text = "Permissões ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(367, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 91;
            this.label5.Text = "Visualizar";
            // 
            // ChkPermissaoVisualizar
            // 
            this.ChkPermissaoVisualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoVisualizar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoVisualizar.Checked = false;
            this.ChkPermissaoVisualizar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkPermissaoVisualizar.ForeColor = System.Drawing.Color.White;
            this.ChkPermissaoVisualizar.Location = new System.Drawing.Point(341, 32);
            this.ChkPermissaoVisualizar.Name = "ChkPermissaoVisualizar";
            this.ChkPermissaoVisualizar.Size = new System.Drawing.Size(20, 20);
            this.ChkPermissaoVisualizar.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(465, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 89;
            this.label4.Text = "Todas";
            // 
            // ChkPermissaoTodas
            // 
            this.ChkPermissaoTodas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoTodas.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoTodas.Checked = false;
            this.ChkPermissaoTodas.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkPermissaoTodas.ForeColor = System.Drawing.Color.White;
            this.ChkPermissaoTodas.Location = new System.Drawing.Point(439, 32);
            this.ChkPermissaoTodas.Name = "ChkPermissaoTodas";
            this.ChkPermissaoTodas.Size = new System.Drawing.Size(20, 20);
            this.ChkPermissaoTodas.TabIndex = 88;
            this.ChkPermissaoTodas.OnChange += new System.EventHandler(this.ChkPermissaoTodas_OnChange);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 87;
            this.label3.Text = "Deletar";
            // 
            // ChkPermissaoDeletar
            // 
            this.ChkPermissaoDeletar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoDeletar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoDeletar.Checked = false;
            this.ChkPermissaoDeletar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkPermissaoDeletar.ForeColor = System.Drawing.Color.White;
            this.ChkPermissaoDeletar.Location = new System.Drawing.Point(247, 32);
            this.ChkPermissaoDeletar.Name = "ChkPermissaoDeletar";
            this.ChkPermissaoDeletar.Size = new System.Drawing.Size(20, 20);
            this.ChkPermissaoDeletar.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "Editar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = "Cadastrar";
            // 
            // ChkPermissaoEditar
            // 
            this.ChkPermissaoEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoEditar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoEditar.Checked = false;
            this.ChkPermissaoEditar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkPermissaoEditar.ForeColor = System.Drawing.Color.White;
            this.ChkPermissaoEditar.Location = new System.Drawing.Point(148, 32);
            this.ChkPermissaoEditar.Name = "ChkPermissaoEditar";
            this.ChkPermissaoEditar.Size = new System.Drawing.Size(20, 20);
            this.ChkPermissaoEditar.TabIndex = 1;
            // 
            // ChkPermissaoCadastrar
            // 
            this.ChkPermissaoCadastrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoCadastrar.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.ChkPermissaoCadastrar.Checked = false;
            this.ChkPermissaoCadastrar.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.ChkPermissaoCadastrar.ForeColor = System.Drawing.Color.White;
            this.ChkPermissaoCadastrar.Location = new System.Drawing.Point(28, 32);
            this.ChkPermissaoCadastrar.Name = "ChkPermissaoCadastrar";
            this.ChkPermissaoCadastrar.Size = new System.Drawing.Size(20, 20);
            this.ChkPermissaoCadastrar.TabIndex = 0;
            // 
            // TxtConfirmarSenha
            // 
            this.TxtConfirmarSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtConfirmarSenha.BeforeTouchSize = new System.Drawing.Size(794, 29);
            this.TxtConfirmarSenha.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.TxtConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtConfirmarSenha.CanOverrideStyle = true;
            this.TxtConfirmarSenha.CausesValidation = false;
            this.TxtConfirmarSenha.CornerRadius = 4;
            this.TxtConfirmarSenha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtConfirmarSenha.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmarSenha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtConfirmarSenha.Location = new System.Drawing.Point(84, 398);
            this.TxtConfirmarSenha.MaxLength = 2000;
            this.TxtConfirmarSenha.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtConfirmarSenha.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtConfirmarSenha.Name = "TxtConfirmarSenha";
            this.TxtConfirmarSenha.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Silver;
            this.TxtConfirmarSenha.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtConfirmarSenha.PasswordChar = '*';
            this.TxtConfirmarSenha.Size = new System.Drawing.Size(342, 29);
            this.TxtConfirmarSenha.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016White;
            this.TxtConfirmarSenha.TabIndex = 4;
            this.TxtConfirmarSenha.Tag = "";
            this.TxtConfirmarSenha.ThemeName = "Office2016White";
            // 
            // LblConfirmarSenha
            // 
            this.LblConfirmarSenha.AutoSize = true;
            this.LblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConfirmarSenha.Location = new System.Drawing.Point(84, 379);
            this.LblConfirmarSenha.Name = "LblConfirmarSenha";
            this.LblConfirmarSenha.Size = new System.Drawing.Size(110, 16);
            this.LblConfirmarSenha.TabIndex = 142;
            this.LblConfirmarSenha.Text = "Confirmar Senha:";
            // 
            // FrmUsuarioCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.TxtConfirmarSenha);
            this.Controls.Add(this.LblConfirmarSenha);
            this.Controls.Add(this.GbxPermissoes);
            this.Controls.Add(this.PanelHorizontalSuperior);
            this.Controls.Add(this.TxtSenha);
            this.Controls.Add(this.LblLogin);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.LblSenha);
            this.Controls.Add(this.TxtEmail);
            this.Controls.Add(this.LblEmail);
            this.Controls.Add(this.TxtNome);
            this.Controls.Add(this.LblNome);
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "FrmUsuarioCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TxtNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenha)).EndInit();
            this.PanelHorizontalSuperior.ResumeLayout(false);
            this.PanelHorizontalSuperior.PerformLayout();
            this.GbxPermissoes.ResumeLayout(false);
            this.GbxPermissoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConfirmarSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtNome;
        private System.Windows.Forms.Label LblNome;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtEmail;
        private System.Windows.Forms.Label LblEmail;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtLogin;
        private System.Windows.Forms.Label LblSenha;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtSenha;
        private System.Windows.Forms.Label LblLogin;
        private Bunifu.Framework.UI.BunifuGradientPanel PanelHorizontalSuperior;
        private Syncfusion.WinForms.Controls.SfButton BtnSalvar;
        public System.Windows.Forms.Label LblDataLong;
        public System.Windows.Forms.Label LblCaptionAtividade;
        private Syncfusion.WinForms.Controls.SfButton BtnNovaAtividade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtConfirmarSenha;
        private System.Windows.Forms.Label LblConfirmarSenha;
        public System.Windows.Forms.GroupBox GbxPermissoes;
        public Bunifu.Framework.UI.BunifuCheckbox ChkPermissaoTodas;
        public Bunifu.Framework.UI.BunifuCheckbox ChkPermissaoDeletar;
        public Bunifu.Framework.UI.BunifuCheckbox ChkPermissaoEditar;
        public Bunifu.Framework.UI.BunifuCheckbox ChkPermissaoCadastrar;
        private System.Windows.Forms.Label label5;
        public Bunifu.Framework.UI.BunifuCheckbox ChkPermissaoVisualizar;
    }
}