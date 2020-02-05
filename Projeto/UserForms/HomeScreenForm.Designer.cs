namespace DimStock.UserForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreenForm));
            this.PanelMenuTop = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.MainMenu_Settings = new System.Windows.Forms.LinkLabel();
            this.MainMenu_Support = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.MainMenu_User = new System.Windows.Forms.LinkLabel();
            this.MainMenu_Stock = new System.Windows.Forms.LinkLabel();
            this.MainMenu_Product = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ContextMenu_Product = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuProduct_RegisterNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduct_RegisterNew_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduct_RegisterNew_Category = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduct_ListRegisters = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduct_ListRegisters_Product = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuProduct_ListRegisters_Category = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_Stock = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuStock_RegisterNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock_RegisterNew_Entrie = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock_RegisterNew_Output = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock_ListMovements = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStock_ListStocks = new System.Windows.Forms.ToolStripMenuItem();
            this.ContextMenu_User = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuUser_RegisterNew = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUser_ListUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUser_ListHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DayOfTheWeek = new System.Windows.Forms.Label();
            this.FormNovigationDescription = new System.Windows.Forms.Label();
            this.ContextMenu_Settings = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuSettings_Backup = new System.Windows.Forms.ToolStripMenuItem();
            this.PanelMenuTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ContextMenu_Product.SuspendLayout();
            this.ContextMenu_Stock.SuspendLayout();
            this.ContextMenu_User.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.ContextMenu_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuTop
            // 
            this.PanelMenuTop.AutoSize = true;
            this.PanelMenuTop.BackColor = System.Drawing.Color.CornflowerBlue;
            this.PanelMenuTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelMenuTop.BackgroundImage")));
            this.PanelMenuTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMenuTop.Controls.Add(this.label6);
            this.PanelMenuTop.Controls.Add(this.MainMenu_Settings);
            this.PanelMenuTop.Controls.Add(this.MainMenu_Support);
            this.PanelMenuTop.Controls.Add(this.label4);
            this.PanelMenuTop.Controls.Add(this.label3);
            this.PanelMenuTop.Controls.Add(this.label2);
            this.PanelMenuTop.Controls.Add(this.MainMenu_User);
            this.PanelMenuTop.Controls.Add(this.MainMenu_Stock);
            this.PanelMenuTop.Controls.Add(this.MainMenu_Product);
            this.PanelMenuTop.Controls.Add(this.pictureBox1);
            this.PanelMenuTop.Controls.Add(this.label1);
            this.PanelMenuTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuTop.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(117)))), ((int)(((byte)(192)))));
            this.PanelMenuTop.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(117)))), ((int)(((byte)(192)))));
            this.PanelMenuTop.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(117)))), ((int)(((byte)(192)))));
            this.PanelMenuTop.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(117)))), ((int)(((byte)(192)))));
            this.PanelMenuTop.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuTop.Name = "PanelMenuTop";
            this.PanelMenuTop.Quality = 10;
            this.PanelMenuTop.Size = new System.Drawing.Size(944, 60);
            this.PanelMenuTop.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(681, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(9, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "|";
            // 
            // MainMenu_Settings
            // 
            this.MainMenu_Settings.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.MainMenu_Settings.AutoEllipsis = true;
            this.MainMenu_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(117)))), ((int)(((byte)(192)))));
            this.MainMenu_Settings.DisabledLinkColor = System.Drawing.Color.White;
            this.MainMenu_Settings.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Settings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenu_Settings.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MainMenu_Settings.LinkColor = System.Drawing.Color.AliceBlue;
            this.MainMenu_Settings.Location = new System.Drawing.Point(701, 0);
            this.MainMenu_Settings.Name = "MainMenu_Settings";
            this.MainMenu_Settings.Size = new System.Drawing.Size(128, 59);
            this.MainMenu_Settings.TabIndex = 17;
            this.MainMenu_Settings.TabStop = true;
            this.MainMenu_Settings.Text = "Configurações";
            this.MainMenu_Settings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainMenu_Settings.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MainMenu_Settings.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainMenu_Settings_LinkClicked);
            // 
            // MainMenu_Support
            // 
            this.MainMenu_Support.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.MainMenu_Support.AutoEllipsis = true;
            this.MainMenu_Support.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(117)))), ((int)(((byte)(192)))));
            this.MainMenu_Support.DisabledLinkColor = System.Drawing.Color.White;
            this.MainMenu_Support.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Support.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenu_Support.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MainMenu_Support.LinkColor = System.Drawing.Color.AliceBlue;
            this.MainMenu_Support.Location = new System.Drawing.Point(580, 0);
            this.MainMenu_Support.Name = "MainMenu_Support";
            this.MainMenu_Support.Size = new System.Drawing.Size(100, 59);
            this.MainMenu_Support.TabIndex = 15;
            this.MainMenu_Support.TabStop = true;
            this.MainMenu_Support.Text = "Suporte";
            this.MainMenu_Support.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainMenu_Support.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MainMenu_Support.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainMenu_Support_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(569, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(9, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "|";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(461, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(9, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "|";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(352, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(9, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "|";
            // 
            // MainMenu_User
            // 
            this.MainMenu_User.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.MainMenu_User.AutoEllipsis = true;
            this.MainMenu_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(117)))), ((int)(((byte)(192)))));
            this.MainMenu_User.DisabledLinkColor = System.Drawing.Color.White;
            this.MainMenu_User.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_User.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenu_User.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MainMenu_User.LinkColor = System.Drawing.Color.AliceBlue;
            this.MainMenu_User.Location = new System.Drawing.Point(468, 0);
            this.MainMenu_User.Name = "MainMenu_User";
            this.MainMenu_User.Size = new System.Drawing.Size(100, 59);
            this.MainMenu_User.TabIndex = 10;
            this.MainMenu_User.TabStop = true;
            this.MainMenu_User.Text = "Usuário";
            this.MainMenu_User.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainMenu_User.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MainMenu_User.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainMenu_User_LinkClicked);
            // 
            // MainMenu_Stock
            // 
            this.MainMenu_Stock.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.MainMenu_Stock.AutoEllipsis = true;
            this.MainMenu_Stock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(117)))), ((int)(((byte)(192)))));
            this.MainMenu_Stock.DisabledLinkColor = System.Drawing.Color.White;
            this.MainMenu_Stock.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Stock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenu_Stock.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MainMenu_Stock.LinkColor = System.Drawing.Color.AliceBlue;
            this.MainMenu_Stock.Location = new System.Drawing.Point(362, 0);
            this.MainMenu_Stock.Name = "MainMenu_Stock";
            this.MainMenu_Stock.Size = new System.Drawing.Size(100, 59);
            this.MainMenu_Stock.TabIndex = 9;
            this.MainMenu_Stock.TabStop = true;
            this.MainMenu_Stock.Text = "Estoque";
            this.MainMenu_Stock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainMenu_Stock.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MainMenu_Stock.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainMenu_Stock_LinkClicked);
            // 
            // MainMenu_Product
            // 
            this.MainMenu_Product.ActiveLinkColor = System.Drawing.Color.LightSkyBlue;
            this.MainMenu_Product.AutoEllipsis = true;
            this.MainMenu_Product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(117)))), ((int)(((byte)(192)))));
            this.MainMenu_Product.DisabledLinkColor = System.Drawing.Color.White;
            this.MainMenu_Product.Font = new System.Drawing.Font("Calibri Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu_Product.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainMenu_Product.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.MainMenu_Product.LinkColor = System.Drawing.Color.AliceBlue;
            this.MainMenu_Product.Location = new System.Drawing.Point(256, 0);
            this.MainMenu_Product.Name = "MainMenu_Product";
            this.MainMenu_Product.Size = new System.Drawing.Size(100, 59);
            this.MainMenu_Product.TabIndex = 8;
            this.MainMenu_Product.TabStop = true;
            this.MainMenu_Product.Text = "Produto";
            this.MainMenu_Product.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MainMenu_Product.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.MainMenu_Product.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MainMenu_Product_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::DimStock.Properties.Resources.DimStockLogoType;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 57);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "DimStock";
            // 
            // ContextMenu_Product
            // 
            this.ContextMenu_Product.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduct_RegisterNew,
            this.MenuProduct_ListRegisters});
            this.ContextMenu_Product.Name = "ContextMenu_Product";
            this.ContextMenu_Product.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ContextMenu_Product.Size = new System.Drawing.Size(157, 48);
            // 
            // MenuProduct_RegisterNew
            // 
            this.MenuProduct_RegisterNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduct_RegisterNew_Product,
            this.MenuProduct_RegisterNew_Category});
            this.MenuProduct_RegisterNew.Name = "MenuProduct_RegisterNew";
            this.MenuProduct_RegisterNew.Size = new System.Drawing.Size(156, 22);
            this.MenuProduct_RegisterNew.Text = "Cadastrar Novo";
            // 
            // MenuProduct_RegisterNew_Product
            // 
            this.MenuProduct_RegisterNew_Product.Name = "MenuProduct_RegisterNew_Product";
            this.MenuProduct_RegisterNew_Product.Size = new System.Drawing.Size(125, 22);
            this.MenuProduct_RegisterNew_Product.Text = "Produto";
            this.MenuProduct_RegisterNew_Product.Click += new System.EventHandler(this.MenuProduct_RegisterNew_Product_Click);
            // 
            // MenuProduct_RegisterNew_Category
            // 
            this.MenuProduct_RegisterNew_Category.Name = "MenuProduct_RegisterNew_Category";
            this.MenuProduct_RegisterNew_Category.Size = new System.Drawing.Size(125, 22);
            this.MenuProduct_RegisterNew_Category.Text = "Categoria";
            this.MenuProduct_RegisterNew_Category.Click += new System.EventHandler(this.MenuProduct_RegisterNew_Category_Click);
            // 
            // MenuProduct_ListRegisters
            // 
            this.MenuProduct_ListRegisters.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuProduct_ListRegisters_Product,
            this.MenuProduct_ListRegisters_Category});
            this.MenuProduct_ListRegisters.Name = "MenuProduct_ListRegisters";
            this.MenuProduct_ListRegisters.Size = new System.Drawing.Size(156, 22);
            this.MenuProduct_ListRegisters.Text = "Listar Registros";
            // 
            // MenuProduct_ListRegisters_Product
            // 
            this.MenuProduct_ListRegisters_Product.Name = "MenuProduct_ListRegisters_Product";
            this.MenuProduct_ListRegisters_Product.Size = new System.Drawing.Size(130, 22);
            this.MenuProduct_ListRegisters_Product.Text = "Produtos";
            this.MenuProduct_ListRegisters_Product.Click += new System.EventHandler(this.MenuProduct_ListRegisters_Product_Click);
            // 
            // MenuProduct_ListRegisters_Category
            // 
            this.MenuProduct_ListRegisters_Category.Name = "MenuProduct_ListRegisters_Category";
            this.MenuProduct_ListRegisters_Category.Size = new System.Drawing.Size(130, 22);
            this.MenuProduct_ListRegisters_Category.Text = "Categorias";
            this.MenuProduct_ListRegisters_Category.Click += new System.EventHandler(this.MenuProduct_ListRegisters_Category_Click);
            // 
            // ContextMenu_Stock
            // 
            this.ContextMenu_Stock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStock_RegisterNew,
            this.MenuStock_ListMovements,
            this.MenuStock_ListStocks});
            this.ContextMenu_Stock.Name = "ContextMenu_Stock";
            this.ContextMenu_Stock.Size = new System.Drawing.Size(191, 70);
            // 
            // MenuStock_RegisterNew
            // 
            this.MenuStock_RegisterNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuStock_RegisterNew_Entrie,
            this.MenuStock_RegisterNew_Output});
            this.MenuStock_RegisterNew.Name = "MenuStock_RegisterNew";
            this.MenuStock_RegisterNew.Size = new System.Drawing.Size(190, 22);
            this.MenuStock_RegisterNew.Text = "Cadastrar Novo";
            // 
            // MenuStock_RegisterNew_Entrie
            // 
            this.MenuStock_RegisterNew_Entrie.Name = "MenuStock_RegisterNew_Entrie";
            this.MenuStock_RegisterNew_Entrie.Size = new System.Drawing.Size(114, 22);
            this.MenuStock_RegisterNew_Entrie.Text = "Entrada";
            this.MenuStock_RegisterNew_Entrie.Click += new System.EventHandler(this.MenuStock_RegisterNew_Entrie_Click);
            // 
            // MenuStock_RegisterNew_Output
            // 
            this.MenuStock_RegisterNew_Output.Name = "MenuStock_RegisterNew_Output";
            this.MenuStock_RegisterNew_Output.Size = new System.Drawing.Size(114, 22);
            this.MenuStock_RegisterNew_Output.Text = "Saída";
            this.MenuStock_RegisterNew_Output.Click += new System.EventHandler(this.MenuStock_RegisterNew_Output_Click);
            // 
            // MenuStock_ListMovements
            // 
            this.MenuStock_ListMovements.Name = "MenuStock_ListMovements";
            this.MenuStock_ListMovements.Size = new System.Drawing.Size(190, 22);
            this.MenuStock_ListMovements.Text = "Listar Movimentações";
            this.MenuStock_ListMovements.Click += new System.EventHandler(this.MenuStock_ListMovements_Click);
            // 
            // MenuStock_ListStocks
            // 
            this.MenuStock_ListStocks.Name = "MenuStock_ListStocks";
            this.MenuStock_ListStocks.Size = new System.Drawing.Size(190, 22);
            this.MenuStock_ListStocks.Text = "Listar Estoques";
            this.MenuStock_ListStocks.Click += new System.EventHandler(this.MenuStock_ListStocks_Click);
            // 
            // ContextMenu_User
            // 
            this.ContextMenu_User.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuUser_RegisterNew,
            this.MenuUser_ListUsers,
            this.MenuUser_ListHistory});
            this.ContextMenu_User.Name = "ContextMenu_User";
            this.ContextMenu_User.Size = new System.Drawing.Size(159, 70);
            // 
            // MenuUser_RegisterNew
            // 
            this.MenuUser_RegisterNew.Name = "MenuUser_RegisterNew";
            this.MenuUser_RegisterNew.Size = new System.Drawing.Size(158, 22);
            this.MenuUser_RegisterNew.Text = "Cadastrar Novo";
            this.MenuUser_RegisterNew.Click += new System.EventHandler(this.MenuUser_RegisterNew_Click);
            // 
            // MenuUser_ListUsers
            // 
            this.MenuUser_ListUsers.Name = "MenuUser_ListUsers";
            this.MenuUser_ListUsers.Size = new System.Drawing.Size(158, 22);
            this.MenuUser_ListUsers.Text = "Listar Usuários";
            this.MenuUser_ListUsers.Click += new System.EventHandler(this.MenuUser_ListUsers_Click);
            // 
            // MenuUser_ListHistory
            // 
            this.MenuUser_ListHistory.Name = "MenuUser_ListHistory";
            this.MenuUser_ListHistory.Size = new System.Drawing.Size(158, 22);
            this.MenuUser_ListHistory.Text = "Listar Históricos";
            this.MenuUser_ListHistory.Click += new System.EventHandler(this.MenuUser_ListHistory_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.DayOfTheWeek);
            this.bunifuGradientPanel1.Controls.Add(this.FormNovigationDescription);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DimGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.SystemColors.Desktop;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.SystemColors.Desktop;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.SystemColors.Desktop;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 60);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(944, 31);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // DayOfTheWeek
            // 
            this.DayOfTheWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DayOfTheWeek.BackColor = System.Drawing.Color.Transparent;
            this.DayOfTheWeek.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayOfTheWeek.ForeColor = System.Drawing.Color.White;
            this.DayOfTheWeek.Location = new System.Drawing.Point(490, -2);
            this.DayOfTheWeek.Name = "DayOfTheWeek";
            this.DayOfTheWeek.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DayOfTheWeek.Size = new System.Drawing.Size(451, 33);
            this.DayOfTheWeek.TabIndex = 1;
            this.DayOfTheWeek.Text = "DayOfTheWeek";
            this.DayOfTheWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FormNovigationDescription
            // 
            this.FormNovigationDescription.BackColor = System.Drawing.Color.Transparent;
            this.FormNovigationDescription.Font = new System.Drawing.Font("Calibri Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNovigationDescription.ForeColor = System.Drawing.Color.White;
            this.FormNovigationDescription.Location = new System.Drawing.Point(4, -2);
            this.FormNovigationDescription.Name = "FormNovigationDescription";
            this.FormNovigationDescription.Size = new System.Drawing.Size(535, 33);
            this.FormNovigationDescription.TabIndex = 0;
            this.FormNovigationDescription.Text = "Tela Inicial";
            this.FormNovigationDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ContextMenu_Settings
            // 
            this.ContextMenu_Settings.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuSettings_Backup});
            this.ContextMenu_Settings.Name = "ContextMenu_Settings";
            this.ContextMenu_Settings.Size = new System.Drawing.Size(114, 26);
            // 
            // MenuSettings_Backup
            // 
            this.MenuSettings_Backup.Name = "MenuSettings_Backup";
            this.MenuSettings_Backup.Size = new System.Drawing.Size(113, 22);
            this.MenuSettings_Backup.Text = "Backup";
            this.MenuSettings_Backup.Click += new System.EventHandler(this.MenuSettings_Backup_Click);
            // 
            // HomeScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(944, 681);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.PanelMenuTop);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(960, 720);
            this.Name = "HomeScreenForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeScreenForm_Load);
            this.PanelMenuTop.ResumeLayout(false);
            this.PanelMenuTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ContextMenu_Product.ResumeLayout(false);
            this.ContextMenu_Stock.ResumeLayout(false);
            this.ContextMenu_User.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.ContextMenu_Settings.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel PanelMenuTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Product;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct_RegisterNew;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct_ListRegisters;
        private System.Windows.Forms.LinkLabel MainMenu_Product;
        private System.Windows.Forms.LinkLabel MainMenu_User;
        private System.Windows.Forms.LinkLabel MainMenu_Stock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Stock;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_RegisterNew;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_RegisterNew_Entrie;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_RegisterNew_Output;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_ListMovements;
        private System.Windows.Forms.ToolStripMenuItem MenuStock_ListStocks;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_User;
        private System.Windows.Forms.ToolStripMenuItem MenuUser_RegisterNew;
        private System.Windows.Forms.ToolStripMenuItem MenuUser_ListUsers;
        private System.Windows.Forms.ToolStripMenuItem MenuUser_ListHistory;
        private System.Windows.Forms.LinkLabel MainMenu_Support;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel MainMenu_Settings;
        private System.Windows.Forms.Label DayOfTheWeek;
        private System.Windows.Forms.ContextMenuStrip ContextMenu_Settings;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings_Backup;
        public System.Windows.Forms.Label FormNovigationDescription;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct_RegisterNew_Product;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct_RegisterNew_Category;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct_ListRegisters_Product;
        private System.Windows.Forms.ToolStripMenuItem MenuProduct_ListRegisters_Category;
    }
}



