namespace DimStock.View
{
    partial class HomeScreenForm
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
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduct_RegisterNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduct_ListProducts = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock_RegisterNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock_Register_Entry = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock_Register_Output = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock_ListStockMovement = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock_ListStocks = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUser_RegisterNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUser_ListUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUser_ListHistorics = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduct,
            this.MenuStock,
            this.MenuUser});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(964, 24);
            this.MenuStrip.TabIndex = 0;
            this.MenuStrip.Text = "MenuStrip";
            // 
            // MenuProduct
            // 
            this.MenuProduct.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduct_RegisterNew,
            this.MenuProduct_ListProducts});
            this.MenuProduct.Name = "MenuProduct";
            this.MenuProduct.Size = new System.Drawing.Size(62, 20);
            this.MenuProduct.Text = "Produto";
            // 
            // MenuProduct_RegisterNew
            // 
            this.MenuProduct_RegisterNew.Name = "MenuProduct_RegisterNew";
            this.MenuProduct_RegisterNew.Size = new System.Drawing.Size(156, 22);
            this.MenuProduct_RegisterNew.Text = "Cadastrar Novo";
            this.MenuProduct_RegisterNew.Click += new System.EventHandler(this.MenuProduct_RegisterNew_Click);
            // 
            // MenuProduct_ListProducts
            // 
            this.MenuProduct_ListProducts.Name = "MenuProduct_ListProducts";
            this.MenuProduct_ListProducts.Size = new System.Drawing.Size(156, 22);
            this.MenuProduct_ListProducts.Text = "Listar Produtos";
            this.MenuProduct_ListProducts.Click += new System.EventHandler(this.MenuProduct_ListProducts_Click);
            // 
            // MenuStock
            // 
            this.MenuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStock_RegisterNew,
            this.MenuStock_ListStockMovement,
            this.MenuStock_ListStocks});
            this.MenuStock.Name = "MenuStock";
            this.MenuStock.Size = new System.Drawing.Size(61, 20);
            this.MenuStock.Text = "Estoque";
            // 
            // MenuStock_RegisterNew
            // 
            this.MenuStock_RegisterNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStock_Register_Entry,
            this.MenuStock_Register_Output});
            this.MenuStock_RegisterNew.Name = "MenuStock_RegisterNew";
            this.MenuStock_RegisterNew.Size = new System.Drawing.Size(185, 22);
            this.MenuStock_RegisterNew.Text = "Cadastrar Novo";
            // 
            // MenuStock_Register_Entry
            // 
            this.MenuStock_Register_Entry.Name = "MenuStock_Register_Entry";
            this.MenuStock_Register_Entry.Size = new System.Drawing.Size(180, 22);
            this.MenuStock_Register_Entry.Text = "Entrada";
            this.MenuStock_Register_Entry.Click += new System.EventHandler(this.MenuStock_RegisterNew_Entry_Click);
            // 
            // MenuStock_Register_Output
            // 
            this.MenuStock_Register_Output.Name = "MenuStock_Register_Output";
            this.MenuStock_Register_Output.Size = new System.Drawing.Size(180, 22);
            this.MenuStock_Register_Output.Text = "Saída";
            this.MenuStock_Register_Output.Click += new System.EventHandler(this.MenuStock_RegisterNew_Output_Click);
            // 
            // MenuStock_ListStockMovement
            // 
            this.MenuStock_ListStockMovement.Name = "MenuStock_ListStockMovement";
            this.MenuStock_ListStockMovement.Size = new System.Drawing.Size(185, 22);
            this.MenuStock_ListStockMovement.Text = "Listar Movimentação";
            this.MenuStock_ListStockMovement.Click += new System.EventHandler(this.MenuStock_ListStockMovement_Click);
            // 
            // MenuStock_ListStocks
            // 
            this.MenuStock_ListStocks.Name = "MenuStock_ListStocks";
            this.MenuStock_ListStocks.Size = new System.Drawing.Size(185, 22);
            this.MenuStock_ListStocks.Text = "Listar Estoques";
            this.MenuStock_ListStocks.Click += new System.EventHandler(this.MenuStock_ListStocks_Click);
            // 
            // MenuUser
            // 
            this.MenuUser.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUser_RegisterNew,
            this.MenuUser_ListUsers,
            this.MenuUser_ListHistorics});
            this.MenuUser.Name = "MenuUser";
            this.MenuUser.Size = new System.Drawing.Size(59, 20);
            this.MenuUser.Text = "Usuário";
            // 
            // MenuUser_RegisterNew
            // 
            this.MenuUser_RegisterNew.Name = "MenuUser_RegisterNew";
            this.MenuUser_RegisterNew.Size = new System.Drawing.Size(180, 22);
            this.MenuUser_RegisterNew.Text = "Cadastrar Novo";
            this.MenuUser_RegisterNew.Click += new System.EventHandler(this.MenuUser_RegisterNew_Click);
            // 
            // MenuUser_ListUsers
            // 
            this.MenuUser_ListUsers.Name = "MenuUser_ListUsers";
            this.MenuUser_ListUsers.Size = new System.Drawing.Size(180, 22);
            this.MenuUser_ListUsers.Text = "Listar Usuarios";
            this.MenuUser_ListUsers.Click += new System.EventHandler(this.MenuUser_ListUsers_Click);
            // 
            // MenuUser_ListHistorics
            // 
            this.MenuUser_ListHistorics.Name = "MenuUser_ListHistorics";
            this.MenuUser_ListHistorics.Size = new System.Drawing.Size(180, 22);
            this.MenuUser_ListHistorics.Text = "Listar Históricos";
            this.MenuUser_ListHistorics.Click += new System.EventHandler(this.MenuUser_ListHistorics_Click);
            // 
            // MdlHomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 681);
            this.Controls.Add(this.MenuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(980, 720);
            this.Name = "MdlHomeScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolStripMenuItem MenuStock;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_RegisterNew;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_ListStockMovement;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_Register_Entry;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_Register_Output;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct_RegisterNew;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct_ListProducts;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_ListStocks;
        public System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem MenuUser;
        private System.Windows.Forms.ToolStripMenuItem MenuUser_RegisterNew;
        private System.Windows.Forms.ToolStripMenuItem MenuUser_ListUsers;
        private System.Windows.Forms.ToolStripMenuItem MenuUser_ListHistorics;
    }
}



