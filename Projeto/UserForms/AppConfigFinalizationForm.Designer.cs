namespace DimStock.UserForms
{
    partial class AppConfigFinalizationForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.FinalizeSettings = new Syncfusion.WinForms.Controls.SfButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.FinalizeSettings);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(28, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 260);
            this.panel1.TabIndex = 150;
            // 
            // FinalizeSettings
            // 
            this.FinalizeSettings.AccessibleName = "Button";
            this.FinalizeSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FinalizeSettings.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FinalizeSettings.Font = new System.Drawing.Font("Microsoft JhengHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalizeSettings.ForeColor = System.Drawing.Color.White;
            this.FinalizeSettings.Location = new System.Drawing.Point(296, 119);
            this.FinalizeSettings.Name = "FinalizeSettings";
            this.FinalizeSettings.Size = new System.Drawing.Size(117, 43);
            this.FinalizeSettings.Style.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.FinalizeSettings.Style.DisabledBackColor = System.Drawing.Color.MediumSeaGreen;
            this.FinalizeSettings.Style.DisabledForeColor = System.Drawing.Color.MediumSeaGreen;
            this.FinalizeSettings.Style.FocusedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.FinalizeSettings.Style.FocusedForeColor = System.Drawing.Color.White;
            this.FinalizeSettings.Style.ForeColor = System.Drawing.Color.White;
            this.FinalizeSettings.Style.HoverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.FinalizeSettings.Style.HoverForeColor = System.Drawing.Color.Black;
            this.FinalizeSettings.Style.PressedBackColor = System.Drawing.Color.MediumSeaGreen;
            this.FinalizeSettings.Style.PressedForeColor = System.Drawing.Color.White;
            this.FinalizeSettings.TabIndex = 146;
            this.FinalizeSettings.Text = "Reiniciar";
            this.FinalizeSettings.UseVisualStyleBackColor = false;
            this.FinalizeSettings.Click += new System.EventHandler(this.FinalizeSettings_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(48, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(640, 33);
            this.label4.TabIndex = 147;
            this.label4.Text = "Configurado Com Sucesso!";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppConfigFinalizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AppConfigFinalizationForm";
            this.Text = "AppConfigRedefinationForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Syncfusion.WinForms.Controls.SfButton FinalizeSettings;
        private System.Windows.Forms.Label label4;
    }
}