namespace DimStock.UserForms
{
    partial class ProductAddForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ButtonShow_CategoryAddForm = new System.Windows.Forms.LinkLabel();
            this.DataGridCategory = new DimStock.Controls.CustomDataGridViewTwo();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.TextSalePrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextCostPrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextBarCode = new MetroFramework.Controls.MetroTextBox();
            this.TextCategoryDescription = new MetroFramework.Controls.MetroTextBox();
            this.TextDescription = new MetroFramework.Controls.MetroTextBox();
            this.TextInternalCode = new MetroFramework.Controls.MetroTextBox();
            this.LabelNavegationDescription = new System.Windows.Forms.Label();
            this.ButtonDelete = new MetroFramework.Controls.MetroButton();
            this.ButtonClearView = new MetroFramework.Controls.MetroButton();
            this.ButtonSave = new MetroFramework.Controls.MetroButton();
            this.TimerSearch = new System.Windows.Forms.Timer(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuniCard = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            this.ButtonClose = new MetroFramework.Controls.MetroButton();
            this.bunifuShadowPanel1 = new Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.BuniCard.SuspendLayout();
            this.bunifuShadowPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonShow_CategoryAddForm
            // 
            this.ButtonShow_CategoryAddForm.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ButtonShow_CategoryAddForm.AutoSize = true;
            this.ButtonShow_CategoryAddForm.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShow_CategoryAddForm.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.ButtonShow_CategoryAddForm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.ButtonShow_CategoryAddForm.Location = new System.Drawing.Point(686, 225);
            this.ButtonShow_CategoryAddForm.Name = "ButtonShow_CategoryAddForm";
            this.ButtonShow_CategoryAddForm.Size = new System.Drawing.Size(93, 17);
            this.ButtonShow_CategoryAddForm.TabIndex = 221;
            this.ButtonShow_CategoryAddForm.TabStop = true;
            this.ButtonShow_CategoryAddForm.Text = "Adicionar Nova";
            this.ButtonShow_CategoryAddForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonShow_CategoryAddForm_LinkClicked);
            // 
            // DataGridCategory
            // 
            this.DataGridCategory.AllowUserToAddRows = false;
            this.DataGridCategory.AllowUserToResizeRows = false;
            this.DataGridCategory.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DataGridCategory.BackgroundColor = System.Drawing.Color.White;
            this.DataGridCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCategory.ColumnHeadersVisible = false;
            this.DataGridCategory.CustomSettings = false;
            this.DataGridCategory.Location = new System.Drawing.Point(34, 249);
            this.DataGridCategory.MultiSelect = false;
            this.DataGridCategory.Name = "DataGridCategory";
            this.DataGridCategory.RowHeadersVisible = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.DataGridCategory.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCategory.Size = new System.Drawing.Size(748, 10);
            this.DataGridCategory.TabIndex = 228;
            this.DataGridCategory.Visible = false;
            this.DataGridCategory.DataSourceChanged += new System.EventHandler(this.DataGridCategory_DataSourceChanged);
            this.DataGridCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCategory_CellClick);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(32, 374);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 17);
            this.label6.TabIndex = 238;
            this.label6.Text = "Código de barras:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(31, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 237;
            this.label5.Text = "Venda:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(31, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 236;
            this.label4.Text = "Custo:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(31, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 235;
            this.label3.Text = "Categoria:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(31, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 234;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(31, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 232;
            this.label1.Text = "Código:";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(34, 36);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(748, 10);
            this.bunifuSeparator1.TabIndex = 231;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // TextSalePrice
            // 
            this.TextSalePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextSalePrice.BackGroundColor = System.Drawing.Color.White;
            this.TextSalePrice.BeforeTouchSize = new System.Drawing.Size(270, 29);
            this.TextSalePrice.BorderColor = System.Drawing.Color.Gray;
            this.TextSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextSalePrice.CanOverrideStyle = true;
            this.TextSalePrice.CausesValidation = false;
            this.TextSalePrice.CornerRadius = 1;
            this.TextSalePrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextSalePrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextSalePrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F);
            this.TextSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextSalePrice.Location = new System.Drawing.Point(33, 337);
            this.TextSalePrice.MinimumSize = new System.Drawing.Size(16, 29);
            this.TextSalePrice.Name = "TextSalePrice";
            this.TextSalePrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextSalePrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextSalePrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextSalePrice.Size = new System.Drawing.Size(270, 29);
            this.TextSalePrice.TabIndex = 4;
            this.TextSalePrice.Text = "R$ 0,00";
            this.TextSalePrice.ThemeName = "Default";
            this.TextSalePrice.ThemesEnabled = false;
            this.TextSalePrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // TextCostPrice
            // 
            this.TextCostPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TextCostPrice.BackGroundColor = System.Drawing.Color.White;
            this.TextCostPrice.BeforeTouchSize = new System.Drawing.Size(270, 29);
            this.TextCostPrice.BorderColor = System.Drawing.Color.Gray;
            this.TextCostPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextCostPrice.CanOverrideStyle = true;
            this.TextCostPrice.CausesValidation = false;
            this.TextCostPrice.CornerRadius = 1;
            this.TextCostPrice.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextCostPrice.DecimalValue = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.TextCostPrice.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F);
            this.TextCostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextCostPrice.Location = new System.Drawing.Point(33, 281);
            this.TextCostPrice.MinimumSize = new System.Drawing.Size(16, 29);
            this.TextCostPrice.Name = "TextCostPrice";
            this.TextCostPrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextCostPrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextCostPrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextCostPrice.Size = new System.Drawing.Size(270, 29);
            this.TextCostPrice.TabIndex = 3;
            this.TextCostPrice.Tag = "required";
            this.TextCostPrice.Text = "R$ 0,00";
            this.TextCostPrice.ThemeName = "Default";
            this.TextCostPrice.ThemesEnabled = false;
            this.TextCostPrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // TextBarCode
            // 
            this.TextBarCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.TextBarCode.CustomButton.Image = null;
            this.TextBarCode.CustomButton.Location = new System.Drawing.Point(719, 1);
            this.TextBarCode.CustomButton.Name = "";
            this.TextBarCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TextBarCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextBarCode.CustomButton.TabIndex = 1;
            this.TextBarCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextBarCode.CustomButton.UseSelectable = true;
            this.TextBarCode.CustomButton.Visible = false;
            this.TextBarCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextBarCode.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.TextBarCode.Lines = new string[0];
            this.TextBarCode.Location = new System.Drawing.Point(35, 392);
            this.TextBarCode.MaxLength = 32767;
            this.TextBarCode.Name = "TextBarCode";
            this.TextBarCode.PasswordChar = '\0';
            this.TextBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBarCode.SelectedText = "";
            this.TextBarCode.SelectionLength = 0;
            this.TextBarCode.SelectionStart = 0;
            this.TextBarCode.ShortcutsEnabled = true;
            this.TextBarCode.Size = new System.Drawing.Size(747, 29);
            this.TextBarCode.TabIndex = 5;
            this.TextBarCode.UseSelectable = true;
            this.TextBarCode.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.TextBarCode.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 12.75F);
            // 
            // TextCategoryDescription
            // 
            this.TextCategoryDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.TextCategoryDescription.CustomButton.Image = null;
            this.TextCategoryDescription.CustomButton.Location = new System.Drawing.Point(720, 1);
            this.TextCategoryDescription.CustomButton.Name = "";
            this.TextCategoryDescription.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TextCategoryDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextCategoryDescription.CustomButton.TabIndex = 1;
            this.TextCategoryDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextCategoryDescription.CustomButton.UseSelectable = true;
            this.TextCategoryDescription.CustomButton.Visible = false;
            this.TextCategoryDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextCategoryDescription.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.TextCategoryDescription.Lines = new string[0];
            this.TextCategoryDescription.Location = new System.Drawing.Point(34, 220);
            this.TextCategoryDescription.MaxLength = 32767;
            this.TextCategoryDescription.Name = "TextCategoryDescription";
            this.TextCategoryDescription.PasswordChar = '\0';
            this.TextCategoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextCategoryDescription.SelectedText = "";
            this.TextCategoryDescription.SelectionLength = 0;
            this.TextCategoryDescription.SelectionStart = 0;
            this.TextCategoryDescription.ShortcutsEnabled = true;
            this.TextCategoryDescription.Size = new System.Drawing.Size(748, 29);
            this.TextCategoryDescription.TabIndex = 2;
            this.TextCategoryDescription.Tag = "required";
            this.TextCategoryDescription.UseSelectable = true;
            this.TextCategoryDescription.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.TextCategoryDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.TextCategoryDescription.TextChanged += new System.EventHandler(this.TextCategoryDescription_TextChanged);
            this.TextCategoryDescription.Click += new System.EventHandler(this.TextCategoryDescription_Click);
            this.TextCategoryDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCategoryDescription_KeyPress);
            // 
            // TextDescription
            // 
            this.TextDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.TextDescription.CustomButton.Image = null;
            this.TextDescription.CustomButton.Location = new System.Drawing.Point(720, 1);
            this.TextDescription.CustomButton.Name = "";
            this.TextDescription.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TextDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextDescription.CustomButton.TabIndex = 1;
            this.TextDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextDescription.CustomButton.UseSelectable = true;
            this.TextDescription.CustomButton.Visible = false;
            this.TextDescription.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextDescription.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.TextDescription.Lines = new string[0];
            this.TextDescription.Location = new System.Drawing.Point(34, 161);
            this.TextDescription.MaxLength = 32767;
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.PasswordChar = '\0';
            this.TextDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextDescription.SelectedText = "";
            this.TextDescription.SelectionLength = 0;
            this.TextDescription.SelectionStart = 0;
            this.TextDescription.ShortcutsEnabled = true;
            this.TextDescription.Size = new System.Drawing.Size(748, 29);
            this.TextDescription.TabIndex = 1;
            this.TextDescription.Tag = "required";
            this.TextDescription.UseSelectable = true;
            this.TextDescription.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.TextDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 12.75F);
            // 
            // TextInternalCode
            // 
            this.TextInternalCode.Anchor = System.Windows.Forms.AnchorStyles.Left;
            // 
            // 
            // 
            this.TextInternalCode.CustomButton.BackColor = System.Drawing.Color.White;
            this.TextInternalCode.CustomButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TextInternalCode.CustomButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.TextInternalCode.CustomButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TextInternalCode.CustomButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TextInternalCode.CustomButton.Image = null;
            this.TextInternalCode.CustomButton.Location = new System.Drawing.Point(241, 1);
            this.TextInternalCode.CustomButton.Name = "";
            this.TextInternalCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TextInternalCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextInternalCode.CustomButton.TabIndex = 1;
            this.TextInternalCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextInternalCode.CustomButton.UseSelectable = true;
            this.TextInternalCode.CustomButton.UseVisualStyleBackColor = false;
            this.TextInternalCode.CustomButton.Visible = false;
            this.TextInternalCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextInternalCode.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.TextInternalCode.Lines = new string[0];
            this.TextInternalCode.Location = new System.Drawing.Point(34, 103);
            this.TextInternalCode.MaxLength = 32767;
            this.TextInternalCode.Name = "TextInternalCode";
            this.TextInternalCode.PasswordChar = '\0';
            this.TextInternalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextInternalCode.SelectedText = "";
            this.TextInternalCode.SelectionLength = 0;
            this.TextInternalCode.SelectionStart = 0;
            this.TextInternalCode.ShortcutsEnabled = true;
            this.TextInternalCode.Size = new System.Drawing.Size(269, 29);
            this.TextInternalCode.TabIndex = 0;
            this.TextInternalCode.Tag = "required";
            this.TextInternalCode.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextInternalCode.UseCustomBackColor = true;
            this.TextInternalCode.UseCustomForeColor = true;
            this.TextInternalCode.UseSelectable = true;
            this.TextInternalCode.WaterMarkColor = System.Drawing.Color.Silver;
            this.TextInternalCode.WaterMarkFont = new System.Drawing.Font("Segoe UI Semibold", 12.75F);
            // 
            // LabelNavegationDescription
            // 
            this.LabelNavegationDescription.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LabelNavegationDescription.BackColor = System.Drawing.Color.Transparent;
            this.LabelNavegationDescription.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNavegationDescription.ForeColor = System.Drawing.Color.DimGray;
            this.LabelNavegationDescription.Location = new System.Drawing.Point(29, 8);
            this.LabelNavegationDescription.Name = "LabelNavegationDescription";
            this.LabelNavegationDescription.Size = new System.Drawing.Size(355, 26);
            this.LabelNavegationDescription.TabIndex = 229;
            this.LabelNavegationDescription.Text = "Inicio > Cadastro de Produtos";
            this.LabelNavegationDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(174, 26);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(144, 39);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "Excluir";
            this.ButtonDelete.UseCustomBackColor = true;
            this.ButtonDelete.UseCustomForeColor = true;
            this.ButtonDelete.UseSelectable = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonClearView
            // 
            this.ButtonClearView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.ButtonClearView.ForeColor = System.Drawing.Color.White;
            this.ButtonClearView.Location = new System.Drawing.Point(318, 26);
            this.ButtonClearView.Name = "ButtonClearView";
            this.ButtonClearView.Size = new System.Drawing.Size(144, 39);
            this.ButtonClearView.TabIndex = 7;
            this.ButtonClearView.Text = "Limpar";
            this.ButtonClearView.UseCustomBackColor = true;
            this.ButtonClearView.UseCustomForeColor = true;
            this.ButtonClearView.UseSelectable = true;
            this.ButtonClearView.Click += new System.EventHandler(this.ButtonClearView_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(30, 26);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(144, 39);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseCustomBackColor = true;
            this.ButtonSave.UseCustomForeColor = true;
            this.ButtonSave.UseSelectable = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TimerSearch
            // 
            this.TimerSearch.Interval = 800;
            this.TimerSearch.Tick += new System.EventHandler(this.TimerSearch_Tick);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // BuniCard
            // 
            this.BuniCard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BuniCard.BorderColor = System.Drawing.Color.Transparent;
            this.BuniCard.Controls.Add(this.DataGridCategory);
            this.BuniCard.Controls.Add(this.ButtonShow_CategoryAddForm);
            this.BuniCard.Controls.Add(this.LabelNavegationDescription);
            this.BuniCard.Controls.Add(this.TextBarCode);
            this.BuniCard.Controls.Add(this.label1);
            this.BuniCard.Controls.Add(this.bunifuSeparator1);
            this.BuniCard.Controls.Add(this.label2);
            this.BuniCard.Controls.Add(this.label5);
            this.BuniCard.Controls.Add(this.TextInternalCode);
            this.BuniCard.Controls.Add(this.TextCategoryDescription);
            this.BuniCard.Controls.Add(this.TextSalePrice);
            this.BuniCard.Controls.Add(this.label4);
            this.BuniCard.Controls.Add(this.label3);
            this.BuniCard.Controls.Add(this.label6);
            this.BuniCard.Controls.Add(this.TextDescription);
            this.BuniCard.Controls.Add(this.TextCostPrice);
            this.BuniCard.Location = new System.Drawing.Point(63, 27);
            this.BuniCard.Name = "BuniCard";
            this.BuniCard.PanelColor = System.Drawing.Color.Empty;
            this.BuniCard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BuniCard.ShadowDept = 2;
            this.BuniCard.ShadowTopLeftVisible = true;
            this.BuniCard.Size = new System.Drawing.Size(811, 448);
            this.BuniCard.TabIndex = 9;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonClose.ForeColor = System.Drawing.Color.White;
            this.ButtonClose.Location = new System.Drawing.Point(641, 26);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(144, 39);
            this.ButtonClose.TabIndex = 10;
            this.ButtonClose.Text = "Sair";
            this.ButtonClose.UseCustomBackColor = true;
            this.ButtonClose.UseCustomForeColor = true;
            this.ButtonClose.UseSelectable = true;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // bunifuShadowPanel1
            // 
            this.bunifuShadowPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuShadowPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuShadowPanel1.Controls.Add(this.ButtonClose);
            this.bunifuShadowPanel1.Controls.Add(this.ButtonSave);
            this.bunifuShadowPanel1.Controls.Add(this.ButtonDelete);
            this.bunifuShadowPanel1.Controls.Add(this.ButtonClearView);
            this.bunifuShadowPanel1.Location = new System.Drawing.Point(63, 481);
            this.bunifuShadowPanel1.Name = "bunifuShadowPanel1";
            this.bunifuShadowPanel1.PanelColor = System.Drawing.Color.Empty;
            this.bunifuShadowPanel1.ShadowDept = 2;
            this.bunifuShadowPanel1.ShadowTopLeftVisible = true;
            this.bunifuShadowPanel1.Size = new System.Drawing.Size(811, 86);
            this.bunifuShadowPanel1.TabIndex = 11;
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 590);
            this.Controls.Add(this.bunifuShadowPanel1);
            this.Controls.Add(this.BuniCard);
            this.DisplayHeader = false;
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "ProductAddForm";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.RightToLeftLayout = true;
            this.ShowIcon = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Load += new System.EventHandler(this.ProductAddForm_Load);
            this.Click += new System.EventHandler(this.ProductAddForm_Click);
            this.Resize += new System.EventHandler(this.ProductAddForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.BuniCard.ResumeLayout(false);
            this.BuniCard.PerformLayout();
            this.bunifuShadowPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel ButtonShow_CategoryAddForm;
        private Controls.CustomDataGridViewTwo DataGridCategory;
        public System.Windows.Forms.Label LabelNavegationDescription;
        private System.Windows.Forms.Timer TimerSearch;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private MetroFramework.Controls.MetroTextBox TextBarCode;
        private MetroFramework.Controls.MetroTextBox TextCategoryDescription;
        private MetroFramework.Controls.MetroTextBox TextDescription;
        private MetroFramework.Controls.MetroTextBox TextInternalCode;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextSalePrice;
        public Syncfusion.Windows.Forms.Tools.CurrencyTextBox TextCostPrice;
        private MetroFramework.Controls.MetroButton ButtonDelete;
        private MetroFramework.Controls.MetroButton ButtonClearView;
        private MetroFramework.Controls.MetroButton ButtonSave;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel BuniCard;
        private MetroFramework.Controls.MetroButton ButtonClose;
        private Bunifu.UI.WinForm.BunifuShadowPanel.BunifuShadowPanel bunifuShadowPanel1;
    }
}