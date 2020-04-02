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
            this.BuniCard = new Bunifu.Framework.UI.BunifuCards();
            this.ButtonDelete = new MetroFramework.Controls.MetroButton();
            this.ButtonClearView = new MetroFramework.Controls.MetroButton();
            this.ButtonSave = new MetroFramework.Controls.MetroButton();
            this.TextSalePrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextCostPrice = new Syncfusion.Windows.Forms.Tools.CurrencyTextBox();
            this.TextBarCode = new MetroFramework.Controls.MetroTextBox();
            this.TextCategoryDescription = new MetroFramework.Controls.MetroTextBox();
            this.TextDescription = new MetroFramework.Controls.MetroTextBox();
            this.TextInternalCode = new MetroFramework.Controls.MetroTextBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.LabelNavegationDescription = new System.Windows.Forms.Label();
            this.TimerSearch = new System.Windows.Forms.Timer(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DataGridCategory = new DimStock.Controls.CustomDataGridViewTwo();
            this.BuniCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonShow_CategoryAddForm
            // 
            this.ButtonShow_CategoryAddForm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonShow_CategoryAddForm.AutoSize = true;
            this.ButtonShow_CategoryAddForm.BackColor = System.Drawing.Color.Transparent;
            this.ButtonShow_CategoryAddForm.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.ButtonShow_CategoryAddForm.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(87)))), ((int)(((byte)(166)))));
            this.ButtonShow_CategoryAddForm.Location = new System.Drawing.Point(624, 173);
            this.ButtonShow_CategoryAddForm.Name = "ButtonShow_CategoryAddForm";
            this.ButtonShow_CategoryAddForm.Size = new System.Drawing.Size(93, 17);
            this.ButtonShow_CategoryAddForm.TabIndex = 221;
            this.ButtonShow_CategoryAddForm.TabStop = true;
            this.ButtonShow_CategoryAddForm.Text = "Adicionar Nova";
            this.ButtonShow_CategoryAddForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ButtonShow_CategoryAddForm_LinkClicked);
            // 
            // BuniCard
            // 
            this.BuniCard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.BuniCard.BackColor = System.Drawing.Color.White;
            this.BuniCard.BorderRadius = 5;
            this.BuniCard.BottomSahddow = true;
            this.BuniCard.color = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(118)))), ((int)(((byte)(190)))));
            this.BuniCard.Controls.Add(this.ButtonDelete);
            this.BuniCard.Controls.Add(this.ButtonClearView);
            this.BuniCard.Controls.Add(this.ButtonSave);
            this.BuniCard.Controls.Add(this.DataGridCategory);
            this.BuniCard.Controls.Add(this.TextSalePrice);
            this.BuniCard.Controls.Add(this.TextCostPrice);
            this.BuniCard.Controls.Add(this.ButtonShow_CategoryAddForm);
            this.BuniCard.Controls.Add(this.TextBarCode);
            this.BuniCard.Controls.Add(this.TextCategoryDescription);
            this.BuniCard.Controls.Add(this.TextDescription);
            this.BuniCard.Controls.Add(this.TextInternalCode);
            this.BuniCard.Controls.Add(this.ButtonClose);
            this.BuniCard.Controls.Add(this.LabelNavegationDescription);
            this.BuniCard.LeftSahddow = true;
            this.BuniCard.Location = new System.Drawing.Point(53, 63);
            this.BuniCard.Name = "BuniCard";
            this.BuniCard.RightSahddow = true;
            this.BuniCard.ShadowDepth = 10;
            this.BuniCard.Size = new System.Drawing.Size(838, 476);
            this.BuniCard.TabIndex = 229;
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonDelete.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonDelete.ForeColor = System.Drawing.Color.White;
            this.ButtonDelete.Location = new System.Drawing.Point(646, 333);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 39);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "Excluir";
            this.ButtonDelete.UseCustomBackColor = true;
            this.ButtonDelete.UseCustomForeColor = true;
            this.ButtonDelete.UseSelectable = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonClearView
            // 
            this.ButtonClearView.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonClearView.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonClearView.ForeColor = System.Drawing.Color.White;
            this.ButtonClearView.Location = new System.Drawing.Point(568, 333);
            this.ButtonClearView.Name = "ButtonClearView";
            this.ButtonClearView.Size = new System.Drawing.Size(75, 39);
            this.ButtonClearView.TabIndex = 7;
            this.ButtonClearView.Text = "Limpar";
            this.ButtonClearView.UseCustomBackColor = true;
            this.ButtonClearView.UseCustomForeColor = true;
            this.ButtonClearView.UseSelectable = true;
            this.ButtonClearView.Click += new System.EventHandler(this.ButtonClearView_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.ButtonSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(490, 333);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 39);
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Salvar";
            this.ButtonSave.UseCustomBackColor = true;
            this.ButtonSave.UseCustomForeColor = true;
            this.ButtonSave.UseSelectable = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextSalePrice
            // 
            this.TextSalePrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextSalePrice.BackGroundColor = System.Drawing.Color.White;
            this.TextSalePrice.BeforeTouchSize = new System.Drawing.Size(188, 29);
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
            this.TextSalePrice.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.TextSalePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextSalePrice.Location = new System.Drawing.Point(118, 241);
            this.TextSalePrice.MinimumSize = new System.Drawing.Size(16, 29);
            this.TextSalePrice.Name = "TextSalePrice";
            this.TextSalePrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextSalePrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextSalePrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextSalePrice.Size = new System.Drawing.Size(188, 29);
            this.TextSalePrice.TabIndex = 4;
            this.TextSalePrice.Text = "R$ 0,00";
            this.TextSalePrice.ThemeName = "Default";
            this.TextSalePrice.ThemesEnabled = false;
            this.TextSalePrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // TextCostPrice
            // 
            this.TextCostPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextCostPrice.BackGroundColor = System.Drawing.Color.White;
            this.TextCostPrice.BeforeTouchSize = new System.Drawing.Size(188, 29);
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
            this.TextCostPrice.Font = new System.Drawing.Font("Segoe UI Light", 12F);
            this.TextCostPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextCostPrice.Location = new System.Drawing.Point(118, 205);
            this.TextCostPrice.MinimumSize = new System.Drawing.Size(16, 29);
            this.TextCostPrice.Name = "TextCostPrice";
            this.TextCostPrice.Office2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.TextCostPrice.Office2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.TextCostPrice.PositiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.TextCostPrice.Size = new System.Drawing.Size(188, 29);
            this.TextCostPrice.TabIndex = 3;
            this.TextCostPrice.Tag = "required";
            this.TextCostPrice.Text = "R$ 0,00";
            this.TextCostPrice.ThemeName = "Default";
            this.TextCostPrice.ThemesEnabled = false;
            this.TextCostPrice.ZeroColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            // 
            // TextBarCode
            // 
            this.TextBarCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.TextBarCode.CustomButton.Image = null;
            this.TextBarCode.CustomButton.Location = new System.Drawing.Point(573, 1);
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
            this.TextBarCode.Location = new System.Drawing.Point(119, 277);
            this.TextBarCode.MaxLength = 32767;
            this.TextBarCode.Name = "TextBarCode";
            this.TextBarCode.PasswordChar = '\0';
            this.TextBarCode.PromptText = "Código de barras";
            this.TextBarCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBarCode.SelectedText = "";
            this.TextBarCode.SelectionLength = 0;
            this.TextBarCode.SelectionStart = 0;
            this.TextBarCode.ShortcutsEnabled = true;
            this.TextBarCode.Size = new System.Drawing.Size(601, 29);
            this.TextBarCode.TabIndex = 5;
            this.TextBarCode.UseSelectable = true;
            this.TextBarCode.WaterMark = "Código de barras";
            this.TextBarCode.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.TextBarCode.WaterMarkFont = new System.Drawing.Font("Calibri Light", 12F);
            // 
            // TextCategoryDescription
            // 
            this.TextCategoryDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.TextCategoryDescription.CustomButton.Image = null;
            this.TextCategoryDescription.CustomButton.Location = new System.Drawing.Point(573, 1);
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
            this.TextCategoryDescription.Location = new System.Drawing.Point(119, 167);
            this.TextCategoryDescription.MaxLength = 32767;
            this.TextCategoryDescription.Name = "TextCategoryDescription";
            this.TextCategoryDescription.PasswordChar = '\0';
            this.TextCategoryDescription.PromptText = "Selecione a categoria";
            this.TextCategoryDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextCategoryDescription.SelectedText = "";
            this.TextCategoryDescription.SelectionLength = 0;
            this.TextCategoryDescription.SelectionStart = 0;
            this.TextCategoryDescription.ShortcutsEnabled = true;
            this.TextCategoryDescription.Size = new System.Drawing.Size(601, 29);
            this.TextCategoryDescription.TabIndex = 2;
            this.TextCategoryDescription.Tag = "required";
            this.TextCategoryDescription.UseSelectable = true;
            this.TextCategoryDescription.WaterMark = "Selecione a categoria";
            this.TextCategoryDescription.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.TextCategoryDescription.WaterMarkFont = new System.Drawing.Font("Calibri Light", 12F);
            this.TextCategoryDescription.TextChanged += new System.EventHandler(this.TextCategoryDescription_TextChanged);
            this.TextCategoryDescription.Click += new System.EventHandler(this.TextCategoryDescription_Click);
            this.TextCategoryDescription.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextCategoryDescription_KeyPress);
            // 
            // TextDescription
            // 
            this.TextDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.TextDescription.CustomButton.Image = null;
            this.TextDescription.CustomButton.Location = new System.Drawing.Point(573, 1);
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
            this.TextDescription.Location = new System.Drawing.Point(119, 129);
            this.TextDescription.MaxLength = 32767;
            this.TextDescription.Name = "TextDescription";
            this.TextDescription.PasswordChar = '\0';
            this.TextDescription.PromptText = "Descrição";
            this.TextDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextDescription.SelectedText = "";
            this.TextDescription.SelectionLength = 0;
            this.TextDescription.SelectionStart = 0;
            this.TextDescription.ShortcutsEnabled = true;
            this.TextDescription.Size = new System.Drawing.Size(601, 29);
            this.TextDescription.TabIndex = 1;
            this.TextDescription.Tag = "required";
            this.TextDescription.UseSelectable = true;
            this.TextDescription.WaterMark = "Descrição";
            this.TextDescription.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.TextDescription.WaterMarkFont = new System.Drawing.Font("Calibri Light", 12F);
            // 
            // TextInternalCode
            // 
            this.TextInternalCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.TextInternalCode.CustomButton.Image = null;
            this.TextInternalCode.CustomButton.Location = new System.Drawing.Point(125, 1);
            this.TextInternalCode.CustomButton.Name = "";
            this.TextInternalCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TextInternalCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TextInternalCode.CustomButton.TabIndex = 1;
            this.TextInternalCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TextInternalCode.CustomButton.UseSelectable = true;
            this.TextInternalCode.CustomButton.Visible = false;
            this.TextInternalCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TextInternalCode.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.TextInternalCode.Lines = new string[0];
            this.TextInternalCode.Location = new System.Drawing.Point(119, 91);
            this.TextInternalCode.MaxLength = 32767;
            this.TextInternalCode.Name = "TextInternalCode";
            this.TextInternalCode.PasswordChar = '\0';
            this.TextInternalCode.PromptText = "Código interno";
            this.TextInternalCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextInternalCode.SelectedText = "";
            this.TextInternalCode.SelectionLength = 0;
            this.TextInternalCode.SelectionStart = 0;
            this.TextInternalCode.ShortcutsEnabled = true;
            this.TextInternalCode.Size = new System.Drawing.Size(153, 29);
            this.TextInternalCode.TabIndex = 0;
            this.TextInternalCode.Tag = "required";
            this.TextInternalCode.UseSelectable = true;
            this.TextInternalCode.WaterMark = "Código interno";
            this.TextInternalCode.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.TextInternalCode.WaterMarkFont = new System.Drawing.Font("Calibri Light", 12F);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Image = global::DimStock.Properties.Resources.IconExit;
            this.ButtonClose.Location = new System.Drawing.Point(802, 8);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(30, 30);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ButtonClose.TabIndex = 230;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // LabelNavegationDescription
            // 
            this.LabelNavegationDescription.BackColor = System.Drawing.Color.Transparent;
            this.LabelNavegationDescription.Font = new System.Drawing.Font("Myanmar Text", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelNavegationDescription.ForeColor = System.Drawing.Color.DimGray;
            this.LabelNavegationDescription.Location = new System.Drawing.Point(16, 11);
            this.LabelNavegationDescription.Name = "LabelNavegationDescription";
            this.LabelNavegationDescription.Size = new System.Drawing.Size(355, 27);
            this.LabelNavegationDescription.TabIndex = 229;
            this.LabelNavegationDescription.Text = "Inicio > Cadastro de Produtos";
            this.LabelNavegationDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // DataGridCategory
            // 
            this.DataGridCategory.AllowUserToAddRows = false;
            this.DataGridCategory.AllowUserToResizeRows = false;
            this.DataGridCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DataGridCategory.BackgroundColor = System.Drawing.Color.White;
            this.DataGridCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataGridCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridCategory.ColumnHeadersVisible = false;
            this.DataGridCategory.CustomSettings = false;
            this.DataGridCategory.Location = new System.Drawing.Point(119, 196);
            this.DataGridCategory.MultiSelect = false;
            this.DataGridCategory.Name = "DataGridCategory";
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri Light", 10F);
            this.DataGridCategory.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridCategory.Size = new System.Drawing.Size(601, 10);
            this.DataGridCategory.TabIndex = 228;
            this.DataGridCategory.Visible = false;
            this.DataGridCategory.DataSourceChanged += new System.EventHandler(this.DataGridCategory_DataSourceChanged);
            this.DataGridCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridCategory_CellClick);
            // 
            // ProductAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 590);
            this.Controls.Add(this.BuniCard);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "ProductAddForm";
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.Click += new System.EventHandler(this.ProductAddForm_Click);
            this.BuniCard.ResumeLayout(false);
            this.BuniCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextSalePrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextCostPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.LinkLabel ButtonShow_CategoryAddForm;
        private Controls.CustomDataGridViewTwo DataGridCategory;
        private Bunifu.Framework.UI.BunifuCards BuniCard;
        public System.Windows.Forms.Label LabelNavegationDescription;
        private System.Windows.Forms.PictureBox ButtonClose;
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
    }
}