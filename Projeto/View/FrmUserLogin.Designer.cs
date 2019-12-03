namespace DimStock.View
{
    partial class FrmUserLogin
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
            this.TxtPassWord = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblLogin = new System.Windows.Forms.Label();
            this.TxtLogin = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblPassWord = new System.Windows.Forms.Label();
            this.BtnUserAccess = new Syncfusion.WinForms.Controls.SfButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtPassWord
            // 
            this.TxtPassWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtPassWord.BackColor = System.Drawing.Color.White;
            this.TxtPassWord.BeforeTouchSize = new System.Drawing.Size(217, 26);
            this.TxtPassWord.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtPassWord.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtPassWord.CanOverrideStyle = true;
            this.TxtPassWord.CausesValidation = false;
            this.TxtPassWord.CornerRadius = 4;
            this.TxtPassWord.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TxtPassWord.Location = new System.Drawing.Point(200, 194);
            this.TxtPassWord.MaxLength = 50;
            this.TxtPassWord.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtPassWord.Name = "TxtPassWord";
            this.TxtPassWord.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtPassWord.PasswordChar = '*';
            this.TxtPassWord.Size = new System.Drawing.Size(217, 26);
            this.TxtPassWord.TabIndex = 92;
            this.TxtPassWord.Tag = "";
            this.TxtPassWord.ThemeName = "Default";
            // 
            // LblLogin
            // 
            this.LblLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblLogin.AutoSize = true;
            this.LblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLogin.Location = new System.Drawing.Point(150, 138);
            this.LblLogin.Name = "LblLogin";
            this.LblLogin.Size = new System.Drawing.Size(44, 16);
            this.LblLogin.TabIndex = 93;
            this.LblLogin.Text = "Login:";
            // 
            // TxtLogin
            // 
            this.TxtLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TxtLogin.BackColor = System.Drawing.Color.White;
            this.TxtLogin.BeforeTouchSize = new System.Drawing.Size(217, 26);
            this.TxtLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtLogin.CanOverrideStyle = true;
            this.TxtLogin.CausesValidation = false;
            this.TxtLogin.CornerRadius = 4;
            this.TxtLogin.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TxtLogin.Location = new System.Drawing.Point(200, 132);
            this.TxtLogin.MaxLength = 50;
            this.TxtLogin.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Silver;
            this.TxtLogin.Size = new System.Drawing.Size(217, 26);
            this.TxtLogin.TabIndex = 90;
            this.TxtLogin.Tag = "";
            this.TxtLogin.ThemeName = "Default";
            // 
            // LblPassWord
            // 
            this.LblPassWord.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LblPassWord.AutoSize = true;
            this.LblPassWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassWord.Location = new System.Drawing.Point(150, 200);
            this.LblPassWord.Name = "LblPassWord";
            this.LblPassWord.Size = new System.Drawing.Size(50, 16);
            this.LblPassWord.TabIndex = 91;
            this.LblPassWord.Text = "Senha:";
            // 
            // BtnUserAccess
            // 
            this.BtnUserAccess.AccessibleName = "Button";
            this.BtnUserAccess.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnUserAccess.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUserAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUserAccess.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.BtnUserAccess.ForeColor = System.Drawing.Color.White;
            this.BtnUserAccess.Location = new System.Drawing.Point(200, 231);
            this.BtnUserAccess.Name = "BtnUserAccess";
            this.BtnUserAccess.Size = new System.Drawing.Size(80, 35);
            this.BtnUserAccess.Style.BackColor = System.Drawing.Color.SeaGreen;
            this.BtnUserAccess.Style.DisabledBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUserAccess.Style.DisabledForeColor = System.Drawing.Color.SeaGreen;
            this.BtnUserAccess.Style.FocusedBackColor = System.Drawing.Color.SeaGreen;
            this.BtnUserAccess.Style.FocusedForeColor = System.Drawing.Color.White;
            this.BtnUserAccess.Style.ForeColor = System.Drawing.Color.White;
            this.BtnUserAccess.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnUserAccess.Style.HoverForeColor = System.Drawing.Color.White;
            this.BtnUserAccess.Style.PressedForeColor = System.Drawing.Color.White;
            this.BtnUserAccess.TabIndex = 138;
            this.BtnUserAccess.Text = "Entrar";
            this.BtnUserAccess.UseVisualStyleBackColor = false;
            this.BtnUserAccess.Click += new System.EventHandler(this.BtnUserAccess_Click);
            // 
            // FrmUserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 414);
            this.Controls.Add(this.BtnUserAccess);
            this.Controls.Add(this.TxtPassWord);
            this.Controls.Add(this.LblPassWord);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.LblLogin);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(652, 453);
            this.Name = "FrmUserLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtLogin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtPassWord;
        private System.Windows.Forms.Label LblLogin;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtLogin;
        private System.Windows.Forms.Label LblPassWord;
        private Syncfusion.WinForms.Controls.SfButton BtnUserAccess;
    }
}