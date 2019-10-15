namespace SysEstoque.View
{
    partial class FrmEstoqueDestinoCadastro
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDestino = new Syncfusion.Windows.Forms.Tools.TextBoxExt();
            this.GridListaDestinos = new System.Windows.Forms.DataGridView();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.BtnEditar = new System.Windows.Forms.Button();
            this.BtnDeleta = new System.Windows.Forms.Button();
            this.BtnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDestino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaDestinos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(43, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 21);
            this.label1.TabIndex = 144;
            this.label1.Text = "Nome do destino: ";
            // 
            // TxtDestino
            // 
            this.TxtDestino.BackColor = System.Drawing.Color.White;
            this.TxtDestino.BeforeTouchSize = new System.Drawing.Size(405, 29);
            this.TxtDestino.BorderColor = System.Drawing.Color.Silver;
            this.TxtDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDestino.CornerRadius = 4;
            this.TxtDestino.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TxtDestino.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtDestino.Location = new System.Drawing.Point(46, 66);
            this.TxtDestino.Metrocolor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(211)))), ((int)(((byte)(212)))));
            this.TxtDestino.MinimumSize = new System.Drawing.Size(14, 10);
            this.TxtDestino.Name = "TxtDestino";
            this.TxtDestino.Size = new System.Drawing.Size(405, 29);
            this.TxtDestino.TabIndex = 143;
            this.TxtDestino.ThemeName = "Default";
            // 
            // GridListaDestinos
            // 
            this.GridListaDestinos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridListaDestinos.Location = new System.Drawing.Point(46, 101);
            this.GridListaDestinos.Name = "GridListaDestinos";
            this.GridListaDestinos.Size = new System.Drawing.Size(446, 226);
            this.GridListaDestinos.TabIndex = 145;
            this.GridListaDestinos.DoubleClick += new System.EventHandler(this.GridListaDestinos_DoubleClick);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(498, 99);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCadastrar.TabIndex = 146;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // BtnEditar
            // 
            this.BtnEditar.Location = new System.Drawing.Point(498, 128);
            this.BtnEditar.Name = "BtnEditar";
            this.BtnEditar.Size = new System.Drawing.Size(75, 23);
            this.BtnEditar.TabIndex = 147;
            this.BtnEditar.Text = "Editar";
            this.BtnEditar.UseVisualStyleBackColor = true;
            this.BtnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // BtnDeleta
            // 
            this.BtnDeleta.Location = new System.Drawing.Point(498, 157);
            this.BtnDeleta.Name = "BtnDeleta";
            this.BtnDeleta.Size = new System.Drawing.Size(75, 23);
            this.BtnDeleta.TabIndex = 148;
            this.BtnDeleta.Text = "Deletar";
            this.BtnDeleta.UseVisualStyleBackColor = true;
            this.BtnDeleta.Click += new System.EventHandler(this.BtnDeleta_Click);
            // 
            // BtnAtualizar
            // 
            this.BtnAtualizar.Location = new System.Drawing.Point(498, 186);
            this.BtnAtualizar.Name = "BtnAtualizar";
            this.BtnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.BtnAtualizar.TabIndex = 149;
            this.BtnAtualizar.Text = "Atualizar";
            this.BtnAtualizar.UseVisualStyleBackColor = true;
            this.BtnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // FrmEstoqueDestinoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(616, 366);
            this.Controls.Add(this.BtnAtualizar);
            this.Controls.Add(this.BtnDeleta);
            this.Controls.Add(this.BtnEditar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.GridListaDestinos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtDestino);
            this.Name = "FrmEstoqueDestinoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque destinos";
            this.Load += new System.EventHandler(this.FrmEstoqueDestinoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtDestino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridListaDestinos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private Syncfusion.Windows.Forms.Tools.TextBoxExt TxtDestino;
        private System.Windows.Forms.DataGridView GridListaDestinos;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button BtnEditar;
        private System.Windows.Forms.Button BtnDeleta;
        private System.Windows.Forms.Button BtnAtualizar;
    }
}