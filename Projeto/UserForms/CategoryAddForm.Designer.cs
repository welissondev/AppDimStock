namespace DimStock.UserForms
{
    partial class CategoryAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CategoryAddForm));
            this.TextDescription = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LabelTextDescription = new System.Windows.Forms.Label();
            this.ButtonSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonClear = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.TextDescription)).BeginInit();
            this.SuspendLayout();
            // 
            // TextDescription
            // 
            this.TextDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextDescription.BackColor = System.Drawing.Color.White;
            this.TextDescription.BeforeTouchSize = new System.Drawing.Size(504, 26);
            this.TextDescription.BorderColor = System.Drawing.Color.DarkGray;
            this.TextDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextDescription.CanOverrideStyle = true;
            this.TextDescription.CausesValidation = false;
            this.TextDescription.CornerRadius = 1;
            this.TextDescription.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextDescription.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextDescription.Location = new System.Drawing.Point(35, 55);
            this.TextDescription.MaxLength = 2000;
            this.TextDescription.MinimumSize = new System.Drawing.Size(16, 12);
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextDescription.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextDescription.Size = new System.Drawing.Size(504, 26);
            this.TextDescription.TabIndex = 214;
            this.TextDescription.Tag = "";
            this.TextDescription.ThemeName = "Default";
            this.TextDescription.ThemesEnabled = false;
            // 
            // LabelTextDescription
            // 
            this.LabelTextDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LabelTextDescription.AutoSize = true;
            this.LabelTextDescription.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTextDescription.Location = new System.Drawing.Point(32, 38);
            this.LabelTextDescription.Name = "LabelTextDescription";
            this.LabelTextDescription.Size = new System.Drawing.Size(69, 18);
            this.LabelTextDescription.TabIndex = 215;
            this.LabelTextDescription.Text = "Descrição:";
            // 
            // ButtonSave
            // 
            this.ButtonSave.ActiveBorderThickness = 1;
            this.ButtonSave.ActiveCornerRadius = 10;
            this.ButtonSave.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonSave.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonSave.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSave.BackColor = System.Drawing.Color.White;
            this.ButtonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSave.BackgroundImage")));
            this.ButtonSave.ButtonText = "Salvar";
            this.ButtonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSave.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonSave.IdleBorderThickness = 1;
            this.ButtonSave.IdleCornerRadius = 10;
            this.ButtonSave.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSave.IdleForecolor = System.Drawing.Color.White;
            this.ButtonSave.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSave.Location = new System.Drawing.Point(35, 89);
            this.ButtonSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(97, 43);
            this.ButtonSave.TabIndex = 224;
            this.ButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.ActiveBorderThickness = 1;
            this.ButtonClear.ActiveCornerRadius = 10;
            this.ButtonClear.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonClear.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonClear.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonClear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClear.BackColor = System.Drawing.Color.White;
            this.ButtonClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonClear.BackgroundImage")));
            this.ButtonClear.ButtonText = "Limpar";
            this.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClear.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonClear.IdleBorderThickness = 1;
            this.ButtonClear.IdleCornerRadius = 10;
            this.ButtonClear.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonClear.IdleForecolor = System.Drawing.Color.White;
            this.ButtonClear.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonClear.Location = new System.Drawing.Point(136, 89);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(97, 43);
            this.ButtonClear.TabIndex = 223;
            this.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ProductCategoryRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 178);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.LabelTextDescription);
            this.MinimumSize = new System.Drawing.Size(587, 217);
            this.Name = "ProductCategoryRegistrationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TextDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextDescription;
        private System.Windows.Forms.Label LabelTextDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonSave;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonClear;
    }
}