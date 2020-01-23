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
            this.RpvReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RpvReportViewer
            // 
            this.RpvReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RpvReportViewer.Location = new System.Drawing.Point(0, 0);
            this.RpvReportViewer.Name = "RpvReportViewer";
            this.RpvReportViewer.ServerReport.BearerToken = null;
            this.RpvReportViewer.Size = new System.Drawing.Size(920, 637);
            this.RpvReportViewer.TabIndex = 1;
            // 
            // ReportViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 637);
            this.Controls.Add(this.RpvReportViewer);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReportViewForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer RpvReportViewer;
    }
}