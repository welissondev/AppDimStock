namespace SysEstoque.View
{
    partial class FrmProdutoRelatorio
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
            this.tBProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbEstoqueDataSet = new SysEstoque.DbEstoqueDataSet();
            this.TxtBuscarCodigo = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscarTamanho = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.TxtBuscarReferencia = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblBuscarCodigo = new System.Windows.Forms.Label();
            this.LblBuscarTamanho = new System.Windows.Forms.Label();
            this.LblBuscarReferencia = new System.Windows.Forms.Label();
            this.RelProdutos = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tBProdutoTableAdapter = new SysEstoque.DbEstoqueDataSetTableAdapters.TBProdutoTableAdapter();
            this.TxtBuscarDescricao = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.LblBuscarDescricao = new System.Windows.Forms.Label();
            this.PicCarregando = new System.Windows.Forms.PictureBox();
            this.TimerExecultaConsulta = new System.Windows.Forms.Timer(this.components);
            this.LblLimpar = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tBProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoqueDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCodigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarTamanho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).BeginInit();
            this.SuspendLayout();
            // 
            // tBProdutoBindingSource
            // 
            this.tBProdutoBindingSource.DataMember = "TBProduto";
            this.tBProdutoBindingSource.DataSource = this.dbEstoqueDataSet;
            // 
            // dbEstoqueDataSet
            // 
            this.dbEstoqueDataSet.DataSetName = "DbEstoqueDataSet";
            this.dbEstoqueDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TxtBuscarCodigo
            // 
            this.TxtBuscarCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarCodigo.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtBuscarCodigo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarCodigo.CanOverrideStyle = true;
            this.TxtBuscarCodigo.CausesValidation = false;
            this.TxtBuscarCodigo.CornerRadius = 4;
            this.TxtBuscarCodigo.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarCodigo.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarCodigo.Location = new System.Drawing.Point(11, 34);
            this.TxtBuscarCodigo.MaxLength = 50;
            this.TxtBuscarCodigo.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtBuscarCodigo.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarCodigo.Multiline = true;
            this.TxtBuscarCodigo.Name = "TxtBuscarCodigo";
            this.TxtBuscarCodigo.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarCodigo.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarCodigo.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscarCodigo.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarCodigo.TabIndex = 90;
            this.TxtBuscarCodigo.Tag = "";
            this.TxtBuscarCodigo.ThemeName = "Office2016Colorful";
            this.TxtBuscarCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarCodigo_KeyPress);
            // 
            // TxtBuscarTamanho
            // 
            this.TxtBuscarTamanho.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.TxtBuscarTamanho.BeforeTouchSize = new System.Drawing.Size(136, 29);
            this.TxtBuscarTamanho.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.TxtBuscarTamanho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtBuscarTamanho.CanOverrideStyle = true;
            this.TxtBuscarTamanho.CausesValidation = false;
            this.TxtBuscarTamanho.CornerRadius = 4;
            this.TxtBuscarTamanho.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtBuscarTamanho.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarTamanho.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TxtBuscarTamanho.Location = new System.Drawing.Point(153, 34);
            this.TxtBuscarTamanho.MaxLength = 50;
            this.TxtBuscarTamanho.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtBuscarTamanho.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarTamanho.Multiline = true;
            this.TxtBuscarTamanho.Name = "TxtBuscarTamanho";
            this.TxtBuscarTamanho.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarTamanho.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarTamanho.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscarTamanho.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarTamanho.TabIndex = 91;
            this.TxtBuscarTamanho.Tag = "";
            this.TxtBuscarTamanho.ThemeName = "Office2016Colorful";
            this.TxtBuscarTamanho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarCodigo_KeyPress);
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
            this.TxtBuscarReferencia.Location = new System.Drawing.Point(295, 34);
            this.TxtBuscarReferencia.MaxLength = 50;
            this.TxtBuscarReferencia.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtBuscarReferencia.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarReferencia.Multiline = true;
            this.TxtBuscarReferencia.Name = "TxtBuscarReferencia";
            this.TxtBuscarReferencia.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarReferencia.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarReferencia.Size = new System.Drawing.Size(136, 29);
            this.TxtBuscarReferencia.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarReferencia.TabIndex = 92;
            this.TxtBuscarReferencia.Tag = "";
            this.TxtBuscarReferencia.ThemeName = "Office2016Colorful";
            this.TxtBuscarReferencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarCodigo_KeyPress);
            // 
            // LblBuscarCodigo
            // 
            this.LblBuscarCodigo.AutoSize = true;
            this.LblBuscarCodigo.Location = new System.Drawing.Point(8, 18);
            this.LblBuscarCodigo.Name = "LblBuscarCodigo";
            this.LblBuscarCodigo.Size = new System.Drawing.Size(83, 13);
            this.LblBuscarCodigo.TabIndex = 93;
            this.LblBuscarCodigo.Text = "Código Produto:";
            // 
            // LblBuscarTamanho
            // 
            this.LblBuscarTamanho.AutoSize = true;
            this.LblBuscarTamanho.Location = new System.Drawing.Point(150, 18);
            this.LblBuscarTamanho.Name = "LblBuscarTamanho";
            this.LblBuscarTamanho.Size = new System.Drawing.Size(55, 13);
            this.LblBuscarTamanho.TabIndex = 94;
            this.LblBuscarTamanho.Text = "Tamanho:";
            // 
            // LblBuscarReferencia
            // 
            this.LblBuscarReferencia.AutoSize = true;
            this.LblBuscarReferencia.Location = new System.Drawing.Point(292, 18);
            this.LblBuscarReferencia.Name = "LblBuscarReferencia";
            this.LblBuscarReferencia.Size = new System.Drawing.Size(62, 13);
            this.LblBuscarReferencia.TabIndex = 95;
            this.LblBuscarReferencia.Text = "Referência:";
            // 
            // RelProdutos
            // 
            this.RelProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            reportDataSource1.Name = "TBProdutosDataSet";
            reportDataSource1.Value = this.tBProdutoBindingSource;
            this.RelProdutos.LocalReport.DataSources.Add(reportDataSource1);
            this.RelProdutos.LocalReport.ReportEmbeddedResource = "SysEstoque.Relatorio.RelProdutos.rdlc";
            this.RelProdutos.Location = new System.Drawing.Point(11, 69);
            this.RelProdutos.Name = "RelProdutos";
            this.RelProdutos.ServerReport.BearerToken = null;
            this.RelProdutos.Size = new System.Drawing.Size(848, 513);
            this.RelProdutos.TabIndex = 97;
            // 
            // tBProdutoTableAdapter
            // 
            this.tBProdutoTableAdapter.ClearBeforeFill = true;
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
            this.TxtBuscarDescricao.Location = new System.Drawing.Point(437, 34);
            this.TxtBuscarDescricao.MaxLength = 50;
            this.TxtBuscarDescricao.Metrocolor = System.Drawing.Color.DodgerBlue;
            this.TxtBuscarDescricao.MinimumSize = new System.Drawing.Size(16, 12);
            this.TxtBuscarDescricao.Multiline = true;
            this.TxtBuscarDescricao.Name = "TxtBuscarDescricao";
            this.TxtBuscarDescricao.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Black;
            this.TxtBuscarDescricao.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Black;
            this.TxtBuscarDescricao.Size = new System.Drawing.Size(211, 29);
            this.TxtBuscarDescricao.Style = Syncfusion.Windows.Forms.Tools.TextBoxExt.theme.Office2016Colorful;
            this.TxtBuscarDescricao.TabIndex = 98;
            this.TxtBuscarDescricao.Tag = "";
            this.TxtBuscarDescricao.ThemeName = "Office2016Colorful";
            this.TxtBuscarDescricao.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBuscarCodigo_KeyPress);
            // 
            // LblBuscarDescricao
            // 
            this.LblBuscarDescricao.AutoSize = true;
            this.LblBuscarDescricao.Location = new System.Drawing.Point(434, 18);
            this.LblBuscarDescricao.Name = "LblBuscarDescricao";
            this.LblBuscarDescricao.Size = new System.Drawing.Size(112, 13);
            this.LblBuscarDescricao.TabIndex = 99;
            this.LblBuscarDescricao.Text = "Descrição do produto:";
            // 
            // PicCarregando
            // 
            this.PicCarregando.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PicCarregando.Image = global::SysEstoque.Properties.Resources.Load;
            this.PicCarregando.Location = new System.Drawing.Point(354, 246);
            this.PicCarregando.Name = "PicCarregando";
            this.PicCarregando.Size = new System.Drawing.Size(129, 137);
            this.PicCarregando.TabIndex = 140;
            this.PicCarregando.TabStop = false;
            this.PicCarregando.Visible = false;
            // 
            // TimerExecultaConsulta
            // 
            this.TimerExecultaConsulta.Interval = 1000;
            this.TimerExecultaConsulta.Tick += new System.EventHandler(this.TimerExecultaConsulta_Tick);
            // 
            // LblLimpar
            // 
            this.LblLimpar.AutoSize = true;
            this.LblLimpar.Location = new System.Drawing.Point(654, 42);
            this.LblLimpar.Name = "LblLimpar";
            this.LblLimpar.Size = new System.Drawing.Size(38, 13);
            this.LblLimpar.TabIndex = 147;
            this.LblLimpar.TabStop = true;
            this.LblLimpar.Text = "Limpar";
            this.LblLimpar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LblLimpar_LinkClicked);
            // 
            // FrmProdutoRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(871, 594);
            this.Controls.Add(this.LblLimpar);
            this.Controls.Add(this.PicCarregando);
            this.Controls.Add(this.TxtBuscarDescricao);
            this.Controls.Add(this.LblBuscarDescricao);
            this.Controls.Add(this.RelProdutos);
            this.Controls.Add(this.TxtBuscarCodigo);
            this.Controls.Add(this.TxtBuscarTamanho);
            this.Controls.Add(this.TxtBuscarReferencia);
            this.Controls.Add(this.LblBuscarCodigo);
            this.Controls.Add(this.LblBuscarTamanho);
            this.Controls.Add(this.LblBuscarReferencia);
            this.Name = "FrmProdutoRelatorio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório de Produtos";
            this.Load += new System.EventHandler(this.FrmProdutoRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tBProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbEstoqueDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCodigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarTamanho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarReferencia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarDescricao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicCarregando)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblBuscarCodigo;
        private System.Windows.Forms.Label LblBuscarTamanho;
        private System.Windows.Forms.Label LblBuscarReferencia;
        private Microsoft.Reporting.WinForms.ReportViewer RelProdutos;
        private DbEstoqueDataSet dbEstoqueDataSet;
        private System.Windows.Forms.BindingSource tBProdutoBindingSource;
        private DbEstoqueDataSetTableAdapters.TBProdutoTableAdapter tBProdutoTableAdapter;
        private System.Windows.Forms.Label LblBuscarDescricao;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarCodigo;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarTamanho;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarReferencia;
        public Syncfusion.Windows.Forms.Tools.TextBoxExt TxtBuscarDescricao;
        private System.Windows.Forms.PictureBox PicCarregando;
        private System.Windows.Forms.Timer TimerExecultaConsulta;
        private System.Windows.Forms.LinkLabel LblLimpar;
    }
}