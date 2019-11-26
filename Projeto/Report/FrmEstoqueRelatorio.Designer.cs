namespace DimStock.Relatorio
{
    partial class FrmEstoqueRelatorio
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.RpvEstoque = new Microsoft.Reporting.WinForms.ReportViewer();
            this.relEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.relEstoqueBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RpvEstoque
            // 
            this.RpvEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RpvEstoque.AutoSize = true;
            reportDataSource1.Name = "DsRelEstoque";
            reportDataSource1.Value = this.relEstoqueBindingSource;
            this.RpvEstoque.LocalReport.DataSources.Add(reportDataSource1);
            this.RpvEstoque.LocalReport.ReportEmbeddedResource = "DimStock.Relatorio.RelEstoques.rdlc";
            this.RpvEstoque.Location = new System.Drawing.Point(12, 9);
            this.RpvEstoque.Margin = new System.Windows.Forms.Padding(0);
            this.RpvEstoque.Name = "RpvEstoque";
            this.RpvEstoque.ServerReport.BearerToken = null;
            this.RpvEstoque.Size = new System.Drawing.Size(896, 616);
            this.RpvEstoque.TabIndex = 0;
            // 
            // relEstoqueBindingSource
            // 
            this.relEstoqueBindingSource.DataSource = typeof(DimStock.Relatorio.RelEstoque);
            // 
            // FrmEstoqueRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(920, 637);
            this.Controls.Add(this.RpvEstoque);
            this.Name = "FrmEstoqueRelatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEstoqueRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.relEstoqueBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Microsoft.Reporting.WinForms.ReportViewer RpvEstoque;
        private System.Windows.Forms.BindingSource relEstoqueBindingSource;
    }
}