namespace DimStock.Screens
{
    partial class UserLoginAccessScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginAccessScreen));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.ButtonEnter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TextLogin = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.TextPassWord = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.FormTransation = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuCards1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCards1
            // 
            this.bunifuCards1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCards1.BackColor = System.Drawing.Color.White;
            this.bunifuCards1.BorderRadius = 5;
            this.bunifuCards1.BottomSahddow = true;
            this.bunifuCards1.color = System.Drawing.Color.White;
            this.bunifuCards1.Controls.Add(this.ButtonEnter);
            this.bunifuCards1.Controls.Add(this.bunifuGradientPanel1);
            this.bunifuCards1.Controls.Add(this.TextLogin);
            this.bunifuCards1.Controls.Add(this.TextPassWord);
            this.FormTransation.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(218, 106);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(506, 467);
            this.bunifuCards1.TabIndex = 4;
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.AllowToggling = false;
            this.ButtonEnter.AnimationSpeed = 200;
            this.ButtonEnter.AutoGenerateColors = false;
            this.ButtonEnter.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEnter.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.ButtonEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEnter.BackgroundImage")));
            this.ButtonEnter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonEnter.ButtonText = "Acessar Sistema";
            this.ButtonEnter.ButtonTextMarginLeft = 0;
            this.ButtonEnter.ColorContrastOnClick = 45;
            this.ButtonEnter.ColorContrastOnHover = 45;
            this.ButtonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.ButtonEnter.CustomizableEdges = borderEdges1;
            this.FormTransation.SetDecoration(this.ButtonEnter, BunifuAnimatorNS.DecorationType.None);
            this.ButtonEnter.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ButtonEnter.DisabledBorderColor = System.Drawing.Color.Empty;
            this.ButtonEnter.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ButtonEnter.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.ButtonEnter.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.ButtonEnter.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.ButtonEnter.ForeColor = System.Drawing.Color.White;
            this.ButtonEnter.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEnter.IconMarginLeft = 11;
            this.ButtonEnter.IconPadding = 10;
            this.ButtonEnter.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonEnter.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.ButtonEnter.IdleBorderRadius = 3;
            this.ButtonEnter.IdleBorderThickness = 1;
            this.ButtonEnter.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.ButtonEnter.IdleIconLeftImage = null;
            this.ButtonEnter.IdleIconRightImage = null;
            this.ButtonEnter.IndicateFocus = false;
            this.ButtonEnter.Location = new System.Drawing.Point(59, 328);
            this.ButtonEnter.Name = "ButtonEnter";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.ButtonEnter.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.ButtonEnter.OnPressedState = stateProperties2;
            this.ButtonEnter.Size = new System.Drawing.Size(382, 45);
            this.ButtonEnter.TabIndex = 5;
            this.ButtonEnter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonEnter.TextMarginLeft = 0;
            this.ButtonEnter.UseDefaultRadiusAndThickness = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.FormTransation.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(137)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(137)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(137)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(137)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(506, 135);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.FormTransation.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(450, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cadastre seus produtos, gerencie seu estoque e muito mais...\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.FormTransation.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar DimStock";
            // 
            // TextLogin
            // 
            this.TextLogin.AcceptsReturn = false;
            this.TextLogin.AcceptsTab = false;
            this.TextLogin.AnimationSpeed = 200;
            this.TextLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextLogin.BackColor = System.Drawing.Color.Transparent;
            this.TextLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextLogin.BackgroundImage")));
            this.TextLogin.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextLogin.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.TextLogin.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextLogin.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextLogin.BorderRadius = 1;
            this.TextLogin.BorderThickness = 1;
            this.TextLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormTransation.SetDecoration(this.TextLogin, BunifuAnimatorNS.DecorationType.None);
            this.TextLogin.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.TextLogin.DefaultText = "";
            this.TextLogin.FillColor = System.Drawing.Color.White;
            this.TextLogin.HideSelection = true;
            this.TextLogin.IconLeft = null;
            this.TextLogin.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextLogin.IconPadding = 10;
            this.TextLogin.IconRight = null;
            this.TextLogin.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextLogin.Lines = new string[0];
            this.TextLogin.Location = new System.Drawing.Point(59, 228);
            this.TextLogin.MaxLength = 32767;
            this.TextLogin.MinimumSize = new System.Drawing.Size(100, 35);
            this.TextLogin.Modified = false;
            this.TextLogin.Multiline = false;
            this.TextLogin.Name = "TextLogin";
            stateProperties3.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextLogin.OnActiveState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Empty;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextLogin.OnDisabledState = stateProperties4;
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextLogin.OnHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.Silver;
            stateProperties6.FillColor = System.Drawing.Color.White;
            stateProperties6.ForeColor = System.Drawing.Color.Empty;
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextLogin.OnIdleState = stateProperties6;
            this.TextLogin.PasswordChar = '\0';
            this.TextLogin.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextLogin.PlaceholderText = "Nome de usuário";
            this.TextLogin.ReadOnly = false;
            this.TextLogin.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextLogin.SelectedText = "";
            this.TextLogin.SelectionLength = 0;
            this.TextLogin.SelectionStart = 0;
            this.TextLogin.ShortcutsEnabled = true;
            this.TextLogin.Size = new System.Drawing.Size(382, 35);
            this.TextLogin.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.TextLogin.TabIndex = 0;
            this.TextLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextLogin.TextMarginBottom = 0;
            this.TextLogin.TextMarginLeft = 5;
            this.TextLogin.TextMarginTop = 0;
            this.TextLogin.TextPlaceholder = "Nome de usuário";
            this.TextLogin.UseSystemPasswordChar = false;
            this.TextLogin.WordWrap = true;
            // 
            // TextPassWord
            // 
            this.TextPassWord.AcceptsReturn = false;
            this.TextPassWord.AcceptsTab = false;
            this.TextPassWord.AnimationSpeed = 200;
            this.TextPassWord.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TextPassWord.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TextPassWord.BackColor = System.Drawing.Color.Transparent;
            this.TextPassWord.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TextPassWord.BackgroundImage")));
            this.TextPassWord.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TextPassWord.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.TextPassWord.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TextPassWord.BorderColorIdle = System.Drawing.Color.Silver;
            this.TextPassWord.BorderRadius = 1;
            this.TextPassWord.BorderThickness = 1;
            this.TextPassWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TextPassWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormTransation.SetDecoration(this.TextPassWord, BunifuAnimatorNS.DecorationType.None);
            this.TextPassWord.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.TextPassWord.DefaultText = "";
            this.TextPassWord.FillColor = System.Drawing.Color.White;
            this.TextPassWord.HideSelection = true;
            this.TextPassWord.IconLeft = null;
            this.TextPassWord.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPassWord.IconPadding = 10;
            this.TextPassWord.IconRight = null;
            this.TextPassWord.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TextPassWord.Lines = new string[0];
            this.TextPassWord.Location = new System.Drawing.Point(59, 269);
            this.TextPassWord.MaxLength = 32767;
            this.TextPassWord.MinimumSize = new System.Drawing.Size(100, 35);
            this.TextPassWord.Modified = false;
            this.TextPassWord.Multiline = false;
            this.TextPassWord.Name = "TextPassWord";
            stateProperties7.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextPassWord.OnActiveState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Empty;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextPassWord.OnDisabledState = stateProperties8;
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextPassWord.OnHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Silver;
            stateProperties10.FillColor = System.Drawing.Color.White;
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextPassWord.OnIdleState = stateProperties10;
            this.TextPassWord.PasswordChar = '*';
            this.TextPassWord.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextPassWord.PlaceholderText = "*******";
            this.TextPassWord.ReadOnly = false;
            this.TextPassWord.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextPassWord.SelectedText = "";
            this.TextPassWord.SelectionLength = 0;
            this.TextPassWord.SelectionStart = 0;
            this.TextPassWord.ShortcutsEnabled = true;
            this.TextPassWord.Size = new System.Drawing.Size(382, 35);
            this.TextPassWord.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.TextPassWord.TabIndex = 1;
            this.TextPassWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.TextPassWord.TextMarginBottom = 0;
            this.TextPassWord.TextMarginLeft = 5;
            this.TextPassWord.TextMarginTop = 0;
            this.TextPassWord.TextPlaceholder = "*******";
            this.TextPassWord.UseSystemPasswordChar = false;
            this.TextPassWord.WordWrap = true;
            // 
            // FormTransation
            // 
            this.FormTransation.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.FormTransation.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.FormTransation.DefaultAnimation = animation1;
            this.FormTransation.Interval = 15;
            this.FormTransation.MaxAnimationTime = 2000;
            this.FormTransation.TimeStep = 0.01F;
            // 
            // UserLoginAccessScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(943, 665);
            this.Controls.Add(this.bunifuCards1);
            this.FormTransation.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(959, 667);
            this.Name = "UserLoginAccessScreen";
            this.bunifuCards1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox TextLogin;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox TextPassWord;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition FormTransation;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonEnter;
    }
}