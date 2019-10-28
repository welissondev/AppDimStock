namespace SysEstoque.View
{
    partial class MDIPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.produtoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeProdutosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProdutoRelatorioMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Estoque = new System.Windows.Forms.ToolStripMenuItem();
            this.novaEntradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeEstoqueToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.históricoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.produtoToolStripMenuItem,
            this.Estoque,
            this.usuárioToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(964, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // produtoToolStripMenuItem
            // 
            this.produtoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.listaDeProdutosToolStripMenuItem,
            this.ProdutoRelatorioMenuItem});
            this.produtoToolStripMenuItem.Name = "produtoToolStripMenuItem";
            this.produtoToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.produtoToolStripMenuItem.Text = "Produto";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            this.cadastrarToolStripMenuItem.Click += new System.EventHandler(this.ProdutoAdicionarMenuItem_Click);
            // 
            // listaDeProdutosToolStripMenuItem
            // 
            this.listaDeProdutosToolStripMenuItem.Name = "listaDeProdutosToolStripMenuItem";
            this.listaDeProdutosToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.listaDeProdutosToolStripMenuItem.Text = "Listar registros";
            this.listaDeProdutosToolStripMenuItem.Click += new System.EventHandler(this.ProdutoListaMenuItem_Click);
            // 
            // ProdutoRelatorioMenuItem
            // 
            this.ProdutoRelatorioMenuItem.Name = "ProdutoRelatorioMenuItem";
            this.ProdutoRelatorioMenuItem.Size = new System.Drawing.Size(154, 22);
            this.ProdutoRelatorioMenuItem.Text = "Gerar relatórios";
            this.ProdutoRelatorioMenuItem.Click += new System.EventHandler(this.ProdutoRelatorioMenuItem_Click);
            // 
            // Estoque
            // 
            this.Estoque.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novaEntradaToolStripMenuItem,
            this.listaDeEstoqueToolStripMenuItem,
            this.listaDeEstoqueToolStripMenuItem1});
            this.Estoque.Name = "Estoque";
            this.Estoque.Size = new System.Drawing.Size(61, 20);
            this.Estoque.Text = "Estoque";
            // 
            // novaEntradaToolStripMenuItem
            // 
            this.novaEntradaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaToolStripMenuItem,
            this.saidaToolStripMenuItem});
            this.novaEntradaToolStripMenuItem.Name = "novaEntradaToolStripMenuItem";
            this.novaEntradaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.novaEntradaToolStripMenuItem.Text = "Cadastrar";
            // 
            // entradaToolStripMenuItem
            // 
            this.entradaToolStripMenuItem.Name = "entradaToolStripMenuItem";
            this.entradaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entradaToolStripMenuItem.Text = "Entrada";
            this.entradaToolStripMenuItem.Click += new System.EventHandler(this.EstoqueEntradaMenuItem_Click);
            // 
            // saidaToolStripMenuItem
            // 
            this.saidaToolStripMenuItem.Name = "saidaToolStripMenuItem";
            this.saidaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saidaToolStripMenuItem.Text = "Saída";
            this.saidaToolStripMenuItem.Click += new System.EventHandler(this.EstoqueSaidaMenuItem_Click);
            // 
            // listaDeEstoqueToolStripMenuItem
            // 
            this.listaDeEstoqueToolStripMenuItem.Name = "listaDeEstoqueToolStripMenuItem";
            this.listaDeEstoqueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.listaDeEstoqueToolStripMenuItem.Text = "Listar atividades";
            this.listaDeEstoqueToolStripMenuItem.Click += new System.EventHandler(this.ListaDeEstoqueMenuItem_Click);
            // 
            // listaDeEstoqueToolStripMenuItem1
            // 
            this.listaDeEstoqueToolStripMenuItem1.Name = "listaDeEstoqueToolStripMenuItem1";
            this.listaDeEstoqueToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.listaDeEstoqueToolStripMenuItem1.Text = "Listar registros";
            this.listaDeEstoqueToolStripMenuItem1.Click += new System.EventHandler(this.EstoqueListaMenuItem_Click);
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adicionarToolStripMenuItem,
            this.listarDeUsuariosToolStripMenuItem,
            this.históricoToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // adicionarToolStripMenuItem
            // 
            this.adicionarToolStripMenuItem.Name = "adicionarToolStripMenuItem";
            this.adicionarToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.adicionarToolStripMenuItem.Text = "Cadastrar";
            this.adicionarToolStripMenuItem.Click += new System.EventHandler(this.UsuarioCadastroMenuItem_Click);
            // 
            // listarDeUsuariosToolStripMenuItem
            // 
            this.listarDeUsuariosToolStripMenuItem.Name = "listarDeUsuariosToolStripMenuItem";
            this.listarDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.listarDeUsuariosToolStripMenuItem.Text = "Listar registros";
            this.listarDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.UsuarioListaMenuItem_Click);
            // 
            // históricoToolStripMenuItem
            // 
            this.históricoToolStripMenuItem.Name = "históricoToolStripMenuItem";
            this.históricoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.históricoToolStripMenuItem.Text = "Ver históricos";
            this.históricoToolStripMenuItem.Click += new System.EventHandler(this.UsuarioHistóricoMenuItem_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "MDIPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem Estoque;
        private System.Windows.Forms.ToolStripMenuItem novaEntradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstoqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem produtoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeProdutosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeEstoqueToolStripMenuItem1;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem históricoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProdutoRelatorioMenuItem;
    }
}



