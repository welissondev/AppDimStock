namespace DimStock.UserForms
{
    partial class ReportViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportViewForm));
            this.ReportViewControl = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CloseForm = new Bunifu.Framework.UI.BunifuThinButton2();
            this.SuspendLayout();
            // 
            // ReportViewControl
            // 
            this.ReportViewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportViewControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportViewControl.DocumentMapWidth = 125;
            this.ReportViewControl.LocalReport.EnableExternalImages = true;
            this.ReportViewControl.Location = new System.Drawing.Point(12, 12);
            this.ReportViewControl.Name = "ReportViewControl";
            this.ReportViewControl.ServerReport.BearerToken = null;
            this.ReportViewControl.Size = new System.Drawing.Size(904, 474);
            this.ReportViewControl.TabIndex = 1;
            // 
            // CloseForm
            // 
            this.CloseForm.ActiveBorderThickness = 1;
            this.CloseForm.ActiveCornerRadius = 10;
            this.CloseForm.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.CloseForm.ActiveForecolor = System.Drawing.Color.White;
            this.CloseForm.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.CloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CloseForm.BackColor = System.Drawing.Color.White;
            this.CloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseForm.BackgroundImage")));
            this.CloseForm.ButtonText = "Sair";
            this.CloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseForm.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.CloseForm.ForeColor = System.Drawing.Color.SeaGreen;
            this.CloseForm.IdleBorderThickness = 1;
            this.CloseForm.IdleCornerRadius = 10;
            this.CloseForm.IdleFillColor = System.Drawing.Color.MediumAquamarine;
            this.CloseForm.IdleForecolor = System.Drawing.Color.White;
            this.CloseForm.IdleLineColor = System.Drawing.Color.MediumAquamarine;
            this.CloseForm.Location = new System.Drawing.Point(11, 494);
            this.CloseForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(97, 43);
            this.CloseForm.TabIndex = 221;
            this.CloseForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.ReportViewControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "ReportViewForm";
            this.Load += new System.EventHandler(this.FrmReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewControl;
        private Bunifu.Framework.UI.BunifuThinButton2 CloseForm;
    }
}