namespace Baran.Ferroalloy.Management.Production
{
    partial class frmFurnaceControlStockingDetails
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
            this.label9 = new System.Windows.Forms.Label();
            this.pbStockingDetails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbStockingDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.Location = new System.Drawing.Point(602, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 149;
            this.label9.Text = "45 C";
            // 
            // pbStockingDetails
            // 
            this.pbStockingDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbStockingDetails.Location = new System.Drawing.Point(0, 0);
            this.pbStockingDetails.Name = "pbStockingDetails";
            this.pbStockingDetails.Size = new System.Drawing.Size(650, 200);
            this.pbStockingDetails.TabIndex = 0;
            this.pbStockingDetails.TabStop = false;
            // 
            // frmFurnaceControlStockingDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(650, 200);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbStockingDetails);
            this.Font = new System.Drawing.Font("B Yekan", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFurnaceControlStockingDetails";
            this.ShowInTaskbar = false;
            this.Text = "Stocking";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFurnaceControlCbDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbStockingDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbStockingDetails;
    }
}