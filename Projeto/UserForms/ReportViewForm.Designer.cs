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
            this.ReportViewControl = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // ReportViewControl
            // 
            this.ReportViewControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReportViewControl.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReportViewControl.LocalReport.EnableExternalImages = true;
            this.ReportViewControl.Location = new System.Drawing.Point(12, 12);
            this.ReportViewControl.Name = "ReportViewControl";
            this.ReportViewControl.ServerReport.BearerToken = null;
            this.ReportViewControl.Size = new System.Drawing.Size(896, 613);
            this.ReportViewControl.TabIndex = 1;
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 637);
            this.Controls.Add(this.ReportViewControl);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportViewForm";
            this.Load += new System.EventHandler(this.FrmReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer ReportViewControl;
    }
}