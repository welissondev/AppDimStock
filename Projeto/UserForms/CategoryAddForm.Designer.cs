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
            this.ButtonUpdate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonResetView = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonDelete = new Bunifu.Framework.UI.BunifuThinButton2();
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
            // ButtonUpdate
            // 
            this.ButtonUpdate.ActiveBorderThickness = 1;
            this.ButtonUpdate.ActiveCornerRadius = 10;
            this.ButtonUpdate.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonUpdate.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonUpdate.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonUpdate.BackColor = System.Drawing.Color.White;
            this.ButtonUpdate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonUpdate.BackgroundImage")));
            this.ButtonUpdate.ButtonText = "Salvar";
            this.ButtonUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonUpdate.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonUpdate.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonUpdate.IdleBorderThickness = 1;
            this.ButtonUpdate.IdleCornerRadius = 10;
            this.ButtonUpdate.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonUpdate.IdleForecolor = System.Drawing.Color.White;
            this.ButtonUpdate.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonUpdate.Location = new System.Drawing.Point(35, 89);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(97, 43);
            this.ButtonUpdate.TabIndex = 224;
            this.ButtonUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // ButtonResetView
            // 
            this.ButtonResetView.ActiveBorderThickness = 1;
            this.ButtonResetView.ActiveCornerRadius = 10;
            this.ButtonResetView.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonResetView.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonResetView.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonResetView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonResetView.BackColor = System.Drawing.Color.White;
            this.ButtonResetView.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonResetView.BackgroundImage")));
            this.ButtonResetView.ButtonText = "Limpar";
            this.ButtonResetView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonResetView.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonResetView.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonResetView.IdleBorderThickness = 1;
            this.ButtonResetView.IdleCornerRadius = 10;
            this.ButtonResetView.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonResetView.IdleForecolor = System.Drawing.Color.White;
            this.ButtonResetView.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonResetView.Location = new System.Drawing.Point(139, 89);
            this.ButtonResetView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonResetView.Name = "ButtonResetView";
            this.ButtonResetView.Size = new System.Drawing.Size(97, 43);
            this.ButtonResetView.TabIndex = 223;
            this.ButtonResetView.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonResetView.Click += new System.EventHandler(this.ButtonResetView_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.ActiveBorderThickness = 1;
            this.ButtonDelete.ActiveCornerRadius = 10;
            this.ButtonDelete.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDelete.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonDelete.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDelete.BackColor = System.Drawing.Color.White;
            this.ButtonDelete.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonDelete.BackgroundImage")));
            this.ButtonDelete.ButtonText = "Deletar";
            this.ButtonDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDelete.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.IdleBorderThickness = 1;
            this.ButtonDelete.IdleCornerRadius = 10;
            this.ButtonDelete.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonDelete.IdleForecolor = System.Drawing.Color.White;
            this.ButtonDelete.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ButtonDelete.Location = new System.Drawing.Point(244, 89);
            this.ButtonDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(97, 43);
            this.ButtonDelete.TabIndex = 225;
            this.ButtonDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // CategoryAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(571, 178);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.ButtonResetView);
            this.Controls.Add(this.TextDescription);
            this.Controls.Add(this.LabelTextDescription);
            this.MinimumSize = new System.Drawing.Size(587, 217);
            this.Name = "CategoryAddForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.TextDescription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TextDescription;
        private System.Windows.Forms.Label LabelTextDescription;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonUpdate;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonResetView;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonDelete;
    }
}