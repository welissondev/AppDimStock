namespace DimStock.UserForms
{
    partial class StockMovementListingForm
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
            this.SearchTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SearchTimer
            // 
            this.SearchTimer.Interval = 1000;
            
            // 
            // StockMovementListingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 551);
            this.MinimumSize = new System.Drawing.Size(944, 590);
            this.Name = "StockMovementListingForm";
            
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer SearchTimer;
    }
}