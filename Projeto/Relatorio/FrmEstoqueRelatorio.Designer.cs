namespace SysEstoque.Relatorio
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
            this.tBEstoqueBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEstoqueDataSet = new SysEstoque.DbEstoqueDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tBEstoqueTableAdapter = new SysEstoque.DbEstoqueDataSetTableAdapters.TBEstoqueTableAdapter();
            this.LblBuscaDescricao = new System.Windows.Forms.Label();
            this.LblBuscaReferencia = new System.Windows.Forms.Label();
            this.LblBuscaTamanho = new System.Windows.Forms.Label();
            this.LblBuscaCode = new System.Windows.Forms.Label();
            this.TxtBuscarReferencia = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscaTamanho = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscaCodigo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscarDescricao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TimerExecultaConsulta = new System.Windows.Forms.Timer(this.components);
            this.PicCarregando = new System.Windows.Forms.PictureBox();
            this.LblLimpar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tBEstoqueBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).BeginInit();
            this.SuspendLayout();
            // 
            // tBEstoqueBindingSource
            // 
            this.tBEstoqueBindingSource.DataMember = "TBEstoque";
            this.tBEstoqueBindingSource.DataSource = this.dbEstoqueDataSet;
            // 
            // dbEstoqueDataSet
            // 
            this.dbEstoqueDataSet.DataSetName = "DbEstoqueDataSet";
            this.dbEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.reportViewer1.AutoSize = true;
            reportDataSource1.Name = "TBEstoqueDataSet";
            reportDataSource1.Value = this.tBEstoqueBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SysEstoque.Relatorio.RelEstoques.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 91);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(954, 534);
            this.reportViewer1.TabIndex = 0;
            // 
            // tBEstoqueTableAdapter
            // 
            this.tBEstoqueTableAdapter.ClearBeforeFill = true;
            // 
            // LblBuscaDescricao
            // 
            this.LblBuscaDescricao.AutoSize = true;
            this.LblBuscaDescricao.Location = new System.Drawing.Point(436, 32);
            this.LblBuscaDescricao.Name = "LblBuscaDescricao";
            this.LblBuscaDescricao.Size = new System.Drawing.Size(112, 13);
            this.LblBuscaDescricao.TabIndex = 113;
            this.LblBuscaDescricao.Text = "Descrição do produto:";
            // 
            // LblBuscaReferencia
            // 
            this.LblBuscaReferencia.AutoSize = true;
            this.LblBuscaReferencia.Location = new System.Drawing.Point(294, 32);
            this.LblBuscaReferencia.Name = "LblBuscaReferencia";
            this.LblBuscaReferencia.Size = new System.Drawing.Size(62, 13);
            this.LblBuscaReferencia.TabIndex = 112;
            this.LblBuscaReferencia.Text = "Referência:";
            // 
            // LblBuscaTamanho
            // 
            this.LblBuscaTamanho.AutoSize = true;
            this.LblBuscaTamanho.Location = new System.Drawing.Point(152, 32);
            this.LblBuscaTamanho.Name = "LblBuscaTamanho";
            this.LblBuscaTamanho.Size = new System.Drawing.Size(55, 13);
            this.LblBuscaTamanho.TabIndex = 111;
            this.LblBuscaTamanho.Text = "Tamanho:";
            // 
            // LblBuscaCode
            // 
            this.LblBuscaCode.AutoSize = true;
            this.LblBuscaCode.Location = new System.Drawing.Point(10, 32);
            this.LblBuscaCode.Name = "LblBuscaCode";
            this.LblBuscaCode.Size = new System.Drawing.Size(83, 13);
            this.LblBuscaCode.TabIndex = 110;
            this.LblBuscaCode.Text = "Código Produto:";
            // 
            // TxtBuscarReferencia
            // 
            this.TxtBuscarReferencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarReferencia.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtBuscarReferencia.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarReferencia.CanOverrideStyle = true;
            this.TxtBuscarReferencia.CausesValidation = false;
            this.TxtBuscarReferencia.CornerRadius = 4;
            this.TxtBuscarReferencia.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarReferencia.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarReferencia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarReferencia.Location = new System.Drawing.Point(297, 48);
            this.TxtBuscarReferencia.MaxLength = 50;
            this.TxtBuscarReferencia.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscarReferencia.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarReferencia.Multiline = true;
            this.TxtBuscarReferencia.Name = "TxtBuscarReferencia";
            this.TxtBuscarReferencia.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarReferencia.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarReferencia.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscarReferencia.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarReferencia.TabIndex = 108;
            this.TxtBuscarReferencia.Tag = "";
            this.TxtBuscarReferencia.ThemeName = "Office2016Colorful";
            this.TxtBuscarReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscaCodigo_KeyPress);
            // 
            // TxtBuscaTamanho
            // 
            this.TxtBuscaTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscaTamanho.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtBuscaTamanho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscaTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscaTamanho.CanOverrideStyle = true;
            this.TxtBuscaTamanho.CausesValidation = false;
            this.TxtBuscaTamanho.CornerRadius = 4;
            this.TxtBuscaTamanho.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscaTamanho.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscaTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscaTamanho.Location = new System.Drawing.Point(155, 48);
            this.TxtBuscaTamanho.MaxLength = 50;
            this.TxtBuscaTamanho.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscaTamanho.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscaTamanho.Multiline = true;
            this.TxtBuscaTamanho.Name = "TxtBuscaTamanho";
            this.TxtBuscaTamanho.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscaTamanho.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscaTamanho.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscaTamanho.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscaTamanho.TabIndex = 107;
            this.TxtBuscaTamanho.Tag = "";
            this.TxtBuscaTamanho.ThemeName = "Office2016Colorful";
            this.TxtBuscaTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscaCodigo_KeyPress);
            // 
            // TxtBuscaCodigo
            // 
            this.TxtBuscaCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscaCodigo.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtBuscaCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscaCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscaCodigo.CanOverrideStyle = true;
            this.TxtBuscaCodigo.CausesValidation = false;
            this.TxtBuscaCodigo.CornerRadius = 4;
            this.TxtBuscaCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscaCodigo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscaCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscaCodigo.Location = new System.Drawing.Point(13, 48);
            this.TxtBuscaCodigo.MaxLength = 50;
            this.TxtBuscaCodigo.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscaCodigo.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscaCodigo.Multiline = true;
            this.TxtBuscaCodigo.Name = "TxtBuscaCodigo";
            this.TxtBuscaCodigo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscaCodigo.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscaCodigo.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscaCodigo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscaCodigo.TabIndex = 106;
            this.TxtBuscaCodigo.Tag = "";
            this.TxtBuscaCodigo.ThemeName = "Office2016Colorful";
            this.TxtBuscaCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscaCodigo_KeyPress);
            // 
            // TxtBuscarDescricao
            // 
            this.TxtBuscarDescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarDescricao.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtBuscarDescricao.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarDescricao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarDescricao.CanOverrideStyle = true;
            this.TxtBuscarDescricao.CausesValidation = false;
            this.TxtBuscarDescricao.CornerRadius = 4;
            this.TxtBuscarDescricao.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarDescricao.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarDescricao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarDescricao.Location = new System.Drawing.Point(439, 48);
            this.TxtBuscarDescricao.MaxLength = 50;
            this.TxtBuscarDescricao.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtBuscarDescricao.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarDescricao.Multiline = true;
            this.TxtBuscarDescricao.Name = "TxtBuscarDescricao";
            this.TxtBuscarDescricao.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarDescricao.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarDescricao.Size = new System.Drawing.Size(208, 29);
            this.TxtBuscarDescricao.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarDescricao.TabIndex = 109;
            this.TxtBuscarDescricao.Tag = "";
            this.TxtBuscarDescricao.ThemeName = "Office2016Colorful";
            this.TxtBuscarDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscaCodigo_KeyPress);
            // 
            // TimerExecultaConsulta
            // 
            this.TimerExecultaConsulta.Interval = 1000;
            this.TimerExecultaConsulta.Tick += new System.EventHandler(this.TimerExecultaConsulta_Tick);
            // 
            // PicCarregando
            // 
            this.PicCarregando.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PicCarregando.Image = global::SysEstoque.Properties.Resources.Load;
            this.PicCarregando.Location = new System.Drawing.Point(391, 272);
            this.PicCarregando.Name = "PicCarregando";
            this.PicCarregando.Size = new System.Drawing.Size(129, 137);
            this.PicCarregando.TabIndex = 141;
            this.PicCarregando.TabStop = false;
            this.PicCarregando.Visible = false;
            // 
            // LblLimpar
            // 
            this.LblLimpar.AutoSize = true;
            this.LblLimpar.Location = new System.Drawing.Point(653, 56);
            this.LblLimpar.Name = "LblLimpar";
            this.LblLimpar.Size = new System.Drawing.Size(38, 13);
            this.LblLimpar.TabIndex = 148;
            this.LblLimpar.TabStop = true;
            this.LblLimpar.Text = "Limpar";
            this.LblLimpar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLimpar_LinkClicked);
            // 
            // FrmEstoqueRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 637);
            this.Controls.Add(this.LblLimpar);
            this.Controls.Add(this.PicCarregando);
            this.Controls.Add(this.LblBuscaDescricao);
            this.Controls.Add(this.LblBuscaReferencia);
            this.Controls.Add(this.LblBuscaTamanho);
            this.Controls.Add(this.LblBuscaCode);
            this.Controls.Add(this.TxtBuscarReferencia);
            this.Controls.Add(this.TxtBuscaTamanho);
            this.Controls.Add(this.TxtBuscaCodigo);
            this.Controls.Add(this.TxtBuscarDescricao);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmEstoqueRelatorio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmEstoqueRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBEstoqueBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscaCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private DbEstoqueDataSet dbEstoqueDataSet;
        private System.Windows.Forms.BindingSource tBEstoqueBindingSource;
        private DbEstoqueDataSetTableAdapters.TBEstoqueTableAdapter tBEstoqueTableAdapter;
        private System.Windows.Forms.Label LblBuscaDescricao;
        private System.Windows.Forms.Label LblBuscaReferencia;
        private System.Windows.Forms.Label LblBuscaTamanho;
        private System.Windows.Forms.Label LblBuscaCode;
        private System.Windows.Forms.Timer TimerExecultaConsulta;
        private System.Windows.Forms.PictureBox PicCarregando;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarReferencia;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscaTamanho;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscaCodigo;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarDescricao;
        private System.Windows.Forms.LinkLabel LblLimpar;
    }
}