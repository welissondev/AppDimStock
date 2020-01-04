namespace DimStock.View
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
            this.PassWord = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LoginTitle = new System.Windows.Forms.Label();
            this.Login = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.PassWordTitle = new System.Windows.Forms.Label();
            this.SignIn = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.PassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).BeginInit();
            this.SuspendLayout();
            // 
            // PassWord
            // 
            this.PassWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PassWord.BackColor = System.Drawing.Color.White;
            this.PassWord.BeforeTouchSize = new System.Drawing.Size(217, 26);
            this.PassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PassWord.CanOverrideStyle = true;
            this.PassWord.CausesValidation = false;
            this.PassWord.CornerRadius = 4;
            this.PassWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PassWord.Location = new System.Drawing.Point(223, 200);
            this.PassWord.MaxLength = 50;
            this.PassWord.MinimumSize = new System.Drawing.Size(16, 12);
            this.PassWord.Name = "PassWord";
            this.PassWord.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.PassWord.PasswordChar = '*';
            this.PassWord.Size = new System.Drawing.Size(217, 26);
            this.PassWord.TabIndex = 92;
            this.PassWord.Tag = "";
            this.PassWord.ThemeName = "Default";
            // 
            // LoginTitle
            // 
            this.LoginTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LoginTitle.AutoSize = true;
            this.LoginTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginTitle.Location = new System.Drawing.Point(173, 144);
            this.LoginTitle.Name = "LoginTitle";
            this.LoginTitle.Size = new System.Drawing.Size(44, 16);
            this.LoginTitle.TabIndex = 93;
            this.LoginTitle.Text = "Login:";
            // 
            // Login
            // 
            this.Login.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Login.BackColor = System.Drawing.Color.White;
            this.Login.BeforeTouchSize = new System.Drawing.Size(217, 26);
            this.Login.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Login.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Login.CanOverrideStyle = true;
            this.Login.CausesValidation = false;
            this.Login.CornerRadius = 4;
            this.Login.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Login.Location = new System.Drawing.Point(223, 138);
            this.Login.MaxLength = 50;
            this.Login.MinimumSize = new System.Drawing.Size(16, 12);
            this.Login.Name = "Login";
            this.Login.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.Login.Size = new System.Drawing.Size(217, 26);
            this.Login.TabIndex = 90;
            this.Login.Tag = "";
            this.Login.ThemeName = "Default";
            // 
            // PassWordTitle
            // 
            this.PassWordTitle.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PassWordTitle.AutoSize = true;
            this.PassWordTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassWordTitle.Location = new System.Drawing.Point(173, 206);
            this.PassWordTitle.Name = "PassWordTitle";
            this.PassWordTitle.Size = new System.Drawing.Size(50, 16);
            this.PassWordTitle.TabIndex = 91;
            this.PassWordTitle.Text = "Senha:";
            // 
            // SignIn
            // 
            this.SignIn.AccessibleName = "Button";
            this.SignIn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SignIn.BackColor = System.Drawing.Color.SeaGreen;
            this.SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignIn.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.SignIn.ForeColor = System.Drawing.Color.White;
            this.SignIn.Location = new System.Drawing.Point(223, 237);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(80, 35);
            this.SignIn.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.SignIn.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.SignIn.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.SignIn.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.SignIn.Style.FocusedForeColor = System.Drawing.Color.White;
            this.SignIn.Style.ForeColor = System.Drawing.Color.White;
            this.SignIn.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.SignIn.Style.HoverForeColor = System.Drawing.Color.White;
            this.SignIn.Style.PressedForeColor = System.Drawing.Color.White;
            this.SignIn.TabIndex = 138;
            this.SignIn.Text = "Entrar";
            this.SignIn.UseVisualStyleBackColor = false;
            this.SignIn.Click += new System.EventHandler(this.SingnIn_Click);
            // 
            // UserLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 414);
            this.Controls.Add(this.SignIn);
            this.Controls.Add(this.PassWord);
            this.Controls.Add(this.PassWordTitle);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.LoginTitle);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 453);
            this.Name = "UserLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aría de acesso do usuário";
            ((System.ComponentModel.ISupportInitialize)(this.PassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Login)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.TextBoxExt PassWord;
        private System.Windows.Forms.Label LoginTitle;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt Login;
        private System.Windows.Forms.Label PassWordTitle;
        private Syncfusion.WinForms.Controls.SfButton SignIn;
    }
}