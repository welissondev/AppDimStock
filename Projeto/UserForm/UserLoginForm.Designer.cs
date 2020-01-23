namespace DimStock.UserForm
{
    partial class UserLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginForm));
            this.PassWord = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.Login = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.SignIn = new Syncfusion.WinForms.Controls.SfButton();
            this.Exit = new Syncfusion.WinForms.Controls.SfButton();
            this.PictureBackGroudUserLogin = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBackGroudUserLogin)).BeginInit();
            this.bunifuCards1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PassWord
            // 
            this.PassWord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassWord.BackColor = System.Drawing.Color.White;
            this.PassWord.BeforeTouchSize = new System.Drawing.Size(192, 26);
            this.PassWord.BorderColor = System.Drawing.Color.DarkGray;
            this.PassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWord.CanOverrideStyle = true;
            this.PassWord.CausesValidation = false;
            this.PassWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PassWord.Location = new System.Drawing.Point(33, 142);
            this.PassWord.MaxLength = 50;
            this.PassWord.MinimumSize = new System.Drawing.Size(16, 12);
            this.PassWord.Name = "PassWord";
            this.PassWord.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(192, 26);
            this.PassWord.TabIndex = 92;
            this.PassWord.Tag = "";
            this.PassWord.ThemeName = "Default";
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.BeforeTouchSize = new System.Drawing.Size(192, 26);
            this.Login.BorderColor = System.Drawing.Color.DarkGray;
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login.CanOverrideStyle = true;
            this.Login.CausesValidation = false;
            this.Login.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Login.Location = new System.Drawing.Point(33, 84);
            this.Login.MaxLength = 50;
            this.Login.MinimumSize = new System.Drawing.Size(16, 12);
            this.Login.Name = "Login";
            this.Login.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Login.Size = new System.Drawing.Size(192, 26);
            this.Login.TabIndex = 90;
            this.Login.Tag = "";
            this.Login.ThemeName = "Default";
            // 
            // SignIn
            // 
            this.SignIn.AccessibleName = "Button";
            this.SignIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignIn.BackColor = System.Drawing.Color.SteelBlue;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.Location = new System.Drawing.Point(32, 184);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(95, 35);
            this.SignIn.Style.BackColor = System.Drawing.Color.SteelBlue;
            this.SignIn.Style.DisabledBackColor = System.Drawing.Color.SteelBlue;
            this.SignIn.Style.DisabledForeColor = System.Drawing.Color.SteelBlue;
            this.SignIn.Style.FocusedBackColor = System.Drawing.Color.SteelBlue;
            this.SignIn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.SignIn.Style.ForeColor = System.Drawing.Color.White;
            this.SignIn.Style.HoverBackColor = System.Drawing.Color.SteelBlue;
            this.SignIn.Style.HoverForeColor = System.Drawing.Color.White;
            this.SignIn.Style.PressedForeColor = System.Drawing.Color.White;
            this.SignIn.TabIndex = 138;
            this.SignIn.Text = "Entrar";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SignIn_Click);
            // 
            // Exit
            // 
            this.Exit.AccessibleName = "Button";
            this.Exit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit.BackColor = System.Drawing.Color.SteelBlue;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.Exit.ForeColor = System.Drawing.Color.White;
            this.Exit.Location = new System.Drawing.Point(130, 184);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(95, 35);
            this.Exit.Style.BackColor = System.Drawing.Color.SteelBlue;
            this.Exit.Style.DisabledBackColor = System.Drawing.Color.SteelBlue;
            this.Exit.Style.DisabledForeColor = System.Drawing.Color.SteelBlue;
            this.Exit.Style.FocusedBackColor = System.Drawing.Color.SteelBlue;
            this.Exit.Style.FocusedForeColor = System.Drawing.Color.White;
            this.Exit.Style.ForeColor = System.Drawing.Color.White;
            this.Exit.Style.HoverBackColor = System.Drawing.Color.SteelBlue;
            this.Exit.Style.HoverForeColor = System.Drawing.Color.White;
            this.Exit.Style.PressedForeColor = System.Drawing.Color.White;
            this.Exit.TabIndex = 139;
            this.Exit.Text = "Sair";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // PictureBackGroudUserLogin
            // 
            this.PictureBackGroudUserLogin.BackgroundImage = global::DimStock.Properties.Resources.Image_backGroud_UserLogin;
            this.PictureBackGroudUserLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PictureBackGroudUserLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PictureBackGroudUserLogin.Location = new System.Drawing.Point(0, 0);
            this.PictureBackGroudUserLogin.Name = "PictureBackGroudUserLogin";
            this.PictureBackGroudUserLogin.Size = new System.Drawing.Size(943, 628);
            this.PictureBackGroudUserLogin.TabIndex = 140;
            this.PictureBackGroudUserLogin.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(28, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 141;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(28, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 142;
            this.label2.Text = "Senha:";
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.SteelBlue;
            this.bunifuCards1.Controls.Add(this.label2);
            this.bunifuCards1.Controls.Add(this.label1);
            this.bunifuCards1.Controls.Add(this.Exit);
            this.bunifuCards1.Controls.Add(this.SignIn);
            this.bunifuCards1.Controls.Add(this.PassWord);
            this.bunifuCards1.Controls.Add(this.Login);
            this.bunifuCards1.LeftSahddow = false;
            this.bunifuCards1.Location = new System.Drawing.Point(340, 119);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(257, 293);
            this.bunifuCards1.TabIndex = 143;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Black;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.WindowText;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 516);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(943, 112);
            this.bunifuGradientPanel1.TabIndex = 144;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(346, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 22);
            this.label5.TabIndex = 144;
            this.label5.Text = "Contato: (28) 98115-7531";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(328, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 22);
            this.label4.TabIndex = 143;
            this.label4.Text = "Site: www.diarioexcel.com.br";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(318, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(302, 22);
            this.label3.TabIndex = 142;
            this.label3.Text = "Desenvolvido por Welisson Silva";
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(943, 628);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.bunifuCards1);
            this.Controls.Add(this.PictureBackGroudUserLogin);
            this.MinimumSize = new System.Drawing.Size(959, 667);
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UserLoginForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBackGroudUserLogin)).EndInit();
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuCards1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.TextBoxExt PassWord;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt Login;
        private Syncfusion.WinForms.Controls.SfButton SignIn;
        private Syncfusion.WinForms.Controls.SfButton Exit;
        private System.Windows.Forms.PictureBox PictureBackGroudUserLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}