namespace DimStock.UserForms
{
    partial class ProductCategoryRegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCategoryRegistrationForm));
            this.Description = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.DescriptionTitle = new System.Windows.Forms.Label();
            this.Save = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ClearFields = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.Description)).BeginInit();
            this.SuspendLayout();
            // 
            // Description
            // 
            this.Description.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Description.BackColor = System.Drawing.Color.White;
            this.Description.BeforeTouchSize = new System.Drawing.Size(504, 26);
            this.Description.BorderColor = System.Drawing.Color.DarkGray;
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description.CanOverrideStyle = true;
            this.Description.CausesValidation = false;
            this.Description.CornerRadius = 1;
            this.Description.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Description.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Description.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Description.Location = new System.Drawing.Point(35, 55);
            this.Description.MaxLength = 2000;
            this.Description.MinimumSize = new System.Drawing.Size(16, 12);
            this.Description.Name = "Description";
            this.Description.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.Description.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.Description.Size = new System.Drawing.Size(504, 26);
            this.Description.TabIndex = 214;
            this.Description.Tag = "";
            this.Description.ThemeName = "Default";
            this.Description.ThemesEnabled = false;
            // 
            // DescriptionTitle
            // 
            this.DescriptionTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DescriptionTitle.AutoSize = true;
            this.DescriptionTitle.Font = new System.Drawing.Font("Calibri Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DescriptionTitle.Location = new System.Drawing.Point(32, 38);
            this.DescriptionTitle.Name = "DescriptionTitle";
            this.DescriptionTitle.Size = new System.Drawing.Size(69, 18);
            this.DescriptionTitle.TabIndex = 215;
            this.DescriptionTitle.Text = "Descrição:";
            // 
            // Save
            // 
            this.Save.ActiveBorderThickness = 1;
            this.Save.ActiveCornerRadius = 10;
            this.Save.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.Save.ActiveForecolor = System.Drawing.Color.White;
            this.Save.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save.BackColor = System.Drawing.Color.White;
            this.Save.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Save.BackgroundImage")));
            this.Save.ButtonText = "Salvar";
            this.Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Save.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.Save.ForeColor = System.Drawing.Color.SeaGreen;
            this.Save.IdleBorderThickness = 1;
            this.Save.IdleCornerRadius = 10;
            this.Save.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.Save.IdleForecolor = System.Drawing.Color.White;
            this.Save.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.Save.Location = new System.Drawing.Point(35, 89);
            this.Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(97, 43);
            this.Save.TabIndex = 224;
            this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // ClearFields
            // 
            this.ClearFields.ActiveBorderThickness = 1;
            this.ClearFields.ActiveCornerRadius = 10;
            this.ClearFields.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ClearFields.ActiveForecolor = System.Drawing.Color.White;
            this.ClearFields.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ClearFields.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ClearFields.BackColor = System.Drawing.Color.White;
            this.ClearFields.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ClearFields.BackgroundImage")));
            this.ClearFields.ButtonText = "Limpar";
            this.ClearFields.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearFields.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ClearFields.ForeColor = System.Drawing.Color.SeaGreen;
            this.ClearFields.IdleBorderThickness = 1;
            this.ClearFields.IdleCornerRadius = 10;
            this.ClearFields.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ClearFields.IdleForecolor = System.Drawing.Color.White;
            this.ClearFields.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ClearFields.Location = new System.Drawing.Point(136, 89);
            this.ClearFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ClearFields.Name = "ClearFields";
            this.ClearFields.Size = new System.Drawing.Size(97, 43);
            this.ClearFields.TabIndex = 223;
            this.ClearFields.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClearFields.Click += new System.EventHandler(this.ClearFields_Click);
            // 
            // ProductCategoryRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 178);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.ClearFields);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.DescriptionTitle);
            this.MinimumSize = new System.Drawing.Size(587, 217);
            this.Name = "ProductCategoryRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.Description)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Syncfusion.Windows.Forms.Tools.TextBoxExt Description;
        private System.Windows.Forms.Label DescriptionTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 Save;
        private Bunifu.Framework.UI.BunifuThinButton2 ClearFields;
    }
}