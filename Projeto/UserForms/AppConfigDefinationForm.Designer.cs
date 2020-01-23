namespace DimStock.UserForms
{
    partial class AppConfigDefinationForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RestoureConfiguration = new Bunifu.Framework.UI.BunifuTileButton();
            this.StartNewConfiguration = new Bunifu.Framework.UI.BunifuTileButton();
            this.FormNovigationDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(379, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 60);
            this.label3.TabIndex = 12;
            this.label3.Text = "Restaurar configuração";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(194, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 60);
            this.label2.TabIndex = 11;
            this.label2.Text = "Iniciar nova configuração";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RestoureConfiguration
            // 
            this.RestoureConfiguration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RestoureConfiguration.BackColor = System.Drawing.Color.SteelBlue;
            this.RestoureConfiguration.color = System.Drawing.Color.SteelBlue;
            this.RestoureConfiguration.colorActive = System.Drawing.Color.RoyalBlue;
            this.RestoureConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RestoureConfiguration.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.RestoureConfiguration.ForeColor = System.Drawing.Color.White;
            this.RestoureConfiguration.Image = global::DimStock.Properties.Resources.icon_restoure_bussines_settings;
            this.RestoureConfiguration.ImagePosition = 20;
            this.RestoureConfiguration.ImageZoom = 50;
            this.RestoureConfiguration.LabelPosition = 41;
            this.RestoureConfiguration.LabelText = "";
            this.RestoureConfiguration.Location = new System.Drawing.Point(379, 210);
            this.RestoureConfiguration.Margin = new System.Windows.Forms.Padding(6);
            this.RestoureConfiguration.Name = "RestoureConfiguration";
            this.RestoureConfiguration.Size = new System.Drawing.Size(128, 129);
            this.RestoureConfiguration.TabIndex = 10;
            // 
            // StartNewConfiguration
            // 
            this.StartNewConfiguration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartNewConfiguration.AutoSize = true;
            this.StartNewConfiguration.BackColor = System.Drawing.Color.SteelBlue;
            this.StartNewConfiguration.color = System.Drawing.Color.SteelBlue;
            this.StartNewConfiguration.colorActive = System.Drawing.Color.RoyalBlue;
            this.StartNewConfiguration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartNewConfiguration.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.StartNewConfiguration.ForeColor = System.Drawing.Color.White;
            this.StartNewConfiguration.Image = global::DimStock.Properties.Resources.icon_new_bussines_settigs;
            this.StartNewConfiguration.ImagePosition = 20;
            this.StartNewConfiguration.ImageZoom = 50;
            this.StartNewConfiguration.LabelPosition = 41;
            this.StartNewConfiguration.LabelText = "";
            this.StartNewConfiguration.Location = new System.Drawing.Point(194, 210);
            this.StartNewConfiguration.Margin = new System.Windows.Forms.Padding(6);
            this.StartNewConfiguration.Name = "StartNewConfiguration";
            this.StartNewConfiguration.Size = new System.Drawing.Size(128, 129);
            this.StartNewConfiguration.TabIndex = 9;
            this.StartNewConfiguration.Click += new System.EventHandler(this.StartNewConfiguration_Click);
            // 
            // FormNovigationDescription
            // 
            this.FormNovigationDescription.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FormNovigationDescription.BackColor = System.Drawing.Color.Transparent;
            this.FormNovigationDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormNovigationDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormNovigationDescription.Location = new System.Drawing.Point(42, 117);
            this.FormNovigationDescription.Name = "FormNovigationDescription";
            this.FormNovigationDescription.Size = new System.Drawing.Size(637, 33);
            this.FormNovigationDescription.TabIndex = 7;
            this.FormNovigationDescription.Text = "Seja Bem Vindo!";
            this.FormNovigationDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(48, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "Escolha uma opção para proceguir com a instalação";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigurationDefinationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(732, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RestoureConfiguration);
            this.Controls.Add(this.StartNewConfiguration);
            this.Controls.Add(this.FormNovigationDescription);
            this.Controls.Add(this.label1);
            this.Name = "ConfigurationDefinationForm";
            this.Text = "ConfigurationDefinationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuTileButton RestoureConfiguration;
        private Bunifu.Framework.UI.BunifuTileButton StartNewConfiguration;
        private System.Windows.Forms.Label FormNovigationDescription;
        private System.Windows.Forms.Label label1;
    }
}