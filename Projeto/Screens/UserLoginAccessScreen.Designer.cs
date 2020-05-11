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
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties13 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties14 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties15 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties16 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            this.TextLogin = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.TextPassWord = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.ButtonEnter = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuCards1 = new Bunifu.Framework.UI.BunifuCards();
            this.BunifuTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.bunifuCards1.SuspendLayout();
            this.SuspendLayout();
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
            this.BunifuTransition.SetDecoration(this.TextLogin, BunifuAnimatorNS.DecorationType.None);
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
            stateProperties11.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextLogin.OnActiveState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.Empty;
            stateProperties12.FillColor = System.Drawing.Color.White;
            stateProperties12.ForeColor = System.Drawing.Color.Empty;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextLogin.OnDisabledState = stateProperties12;
            stateProperties13.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties13.FillColor = System.Drawing.Color.Empty;
            stateProperties13.ForeColor = System.Drawing.Color.Empty;
            stateProperties13.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextLogin.OnHoverState = stateProperties13;
            stateProperties14.BorderColor = System.Drawing.Color.Silver;
            stateProperties14.FillColor = System.Drawing.Color.White;
            stateProperties14.ForeColor = System.Drawing.Color.Empty;
            stateProperties14.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextLogin.OnIdleState = stateProperties14;
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
            this.BunifuTransition.SetDecoration(this.TextPassWord, BunifuAnimatorNS.DecorationType.None);
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
            stateProperties15.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties15.FillColor = System.Drawing.Color.Empty;
            stateProperties15.ForeColor = System.Drawing.Color.Empty;
            stateProperties15.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextPassWord.OnActiveState = stateProperties15;
            stateProperties16.BorderColor = System.Drawing.Color.Empty;
            stateProperties16.FillColor = System.Drawing.Color.White;
            stateProperties16.ForeColor = System.Drawing.Color.Empty;
            stateProperties16.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TextPassWord.OnDisabledState = stateProperties16;
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextPassWord.OnHoverState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.Silver;
            stateProperties18.FillColor = System.Drawing.Color.White;
            stateProperties18.ForeColor = System.Drawing.Color.Empty;
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TextPassWord.OnIdleState = stateProperties18;
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
            // ButtonEnter
            // 
            this.ButtonEnter.AllowToggling = false;
            this.ButtonEnter.AnimationSpeed = 200;
            this.ButtonEnter.AutoGenerateColors = false;
            this.ButtonEnter.BackColor = System.Drawing.Color.Transparent;
            this.ButtonEnter.BackColor1 = System.Drawing.Color.MediumSeaGreen;
            this.ButtonEnter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonEnter.BackgroundImage")));
            this.ButtonEnter.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.ButtonEnter.ButtonText = "Acessar Sistema";
            this.ButtonEnter.ButtonTextMarginLeft = 0;
            this.ButtonEnter.ColorContrastOnClick = 45;
            this.ButtonEnter.ColorContrastOnHover = 45;
            this.ButtonEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.ButtonEnter.CustomizableEdges = borderEdges2;
            this.BunifuTransition.SetDecoration(this.ButtonEnter, BunifuAnimatorNS.DecorationType.None);
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
            this.ButtonEnter.IdleBorderColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonEnter.IdleBorderRadius = 3;
            this.ButtonEnter.IdleBorderThickness = 1;
            this.ButtonEnter.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonEnter.IdleIconLeftImage = null;
            this.ButtonEnter.IdleIconRightImage = null;
            this.ButtonEnter.IndicateFocus = false;
            this.ButtonEnter.Location = new System.Drawing.Point(59, 322);
            this.ButtonEnter.Name = "ButtonEnter";
            stateProperties19.BorderColor = System.Drawing.Color.MediumSeaGreen;
            stateProperties19.BorderRadius = 3;
            stateProperties19.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties19.BorderThickness = 1;
            stateProperties19.FillColor = System.Drawing.Color.MediumSeaGreen;
            stateProperties19.ForeColor = System.Drawing.Color.White;
            stateProperties19.IconLeftImage = null;
            stateProperties19.IconRightImage = null;
            this.ButtonEnter.onHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(137)))));
            stateProperties20.BorderRadius = 3;
            stateProperties20.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties20.BorderThickness = 1;
            stateProperties20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(88)))), ((int)(((byte)(137)))));
            stateProperties20.ForeColor = System.Drawing.Color.White;
            stateProperties20.IconLeftImage = null;
            stateProperties20.IconRightImage = null;
            this.ButtonEnter.OnPressedState = stateProperties20;
            this.ButtonEnter.Size = new System.Drawing.Size(382, 45);
            this.ButtonEnter.TabIndex = 2;
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
            this.BunifuTransition.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
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
            this.BunifuTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
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
            this.BunifuTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Iniciar DimStock";
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
            this.BunifuTransition.SetDecoration(this.bunifuCards1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuCards1.LeftSahddow = true;
            this.bunifuCards1.Location = new System.Drawing.Point(225, 106);
            this.bunifuCards1.Name = "bunifuCards1";
            this.bunifuCards1.RightSahddow = true;
            this.bunifuCards1.ShadowDepth = 20;
            this.bunifuCards1.Size = new System.Drawing.Size(506, 467);
            this.bunifuCards1.TabIndex = 4;
            // 
            // BunifuTransition
            // 
            this.BunifuTransition.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.BunifuTransition.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 1F;
            this.BunifuTransition.DefaultAnimation = animation2;
            this.BunifuTransition.Interval = 100;
            // 
            // UserLoginAccessScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(957, 665);
            this.Controls.Add(this.bunifuCards1);
            this.BunifuTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(959, 667);
            this.Name = "UserLoginAccessScreen";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.bunifuCards1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox TextLogin;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox TextPassWord;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton ButtonEnter;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCards bunifuCards1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private BunifuAnimatorNS.BunifuTransition BunifuTransition;
    }
}