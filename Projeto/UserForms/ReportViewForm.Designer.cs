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
            this.ButtonCloseForm = new Bunifu.Framework.UI.BunifuThinButton2();
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
            // ButtonCloseForm
            // 
            this.ButtonCloseForm.ActiveBorderThickness = 1;
            this.ButtonCloseForm.ActiveCornerRadius = 10;
            this.ButtonCloseForm.ActiveFillColor = System.Drawing.SystemColors.Desktop;
            this.ButtonCloseForm.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonCloseForm.ActiveLineColor = System.Drawing.SystemColors.Desktop;
            this.ButtonCloseForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCloseForm.BackColor = System.Drawing.Color.White;
            this.ButtonCloseForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCloseForm.BackgroundImage")));
            this.ButtonCloseForm.ButtonText = "Sair";
            this.ButtonCloseForm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCloseForm.Font = new System.Drawing.Font("Calibri Light", 14F);
            this.ButtonCloseForm.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonCloseForm.IdleBorderThickness = 1;
            this.ButtonCloseForm.IdleCornerRadius = 10;
            this.ButtonCloseForm.IdleFillColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonCloseForm.IdleForecolor = System.Drawing.Color.White;
            this.ButtonCloseForm.IdleLineColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonCloseForm.Location = new System.Drawing.Point(11, 494);
            this.ButtonCloseForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonCloseForm.Name = "ButtonCloseForm";
            this.ButtonCloseForm.Size = new System.Drawing.Size(97, 43);
            this.ButtonCloseForm.TabIndex = 221;
            this.ButtonCloseForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonCloseForm.Click += new System.EventHandler(this.ButtonCloseForm_Click);
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.Controls.Add(this.ButtonCloseForm);
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
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonCloseForm;
    }
}