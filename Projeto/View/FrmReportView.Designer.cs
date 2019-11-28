namespace DimStock.View
{
    partial class FrmReportView
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
            this.RpvReportView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RpvReportView
            // 
            this.RpvReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RpvReportView.Location = new System.Drawing.Point(0, 0);
            this.RpvReportView.Name = "RpvReportView";
            this.RpvReportView.ServerReport.BearerToken = null;
            this.RpvReportView.Size = new System.Drawing.Size(920, 637);
            this.RpvReportView.TabIndex = 1;
            // 
            // FrmReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 637);
            this.Controls.Add(this.RpvReportView);
            this.Name = "FrmReportView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmReportView_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer RpvReportView;
    }
}