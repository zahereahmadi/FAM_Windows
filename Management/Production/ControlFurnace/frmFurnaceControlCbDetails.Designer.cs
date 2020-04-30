namespace Baran.Ferroalloy.Management.Production
{
    partial class frmFurnaceControlCbDetails
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
            this.label106 = new System.Windows.Forms.Label();
            this.pbCbDetails = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCbDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label106.Location = new System.Drawing.Point(56, 18);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(29, 10);
            this.label106.TabIndex = 147;
            this.label106.Text = "3 MVar";
            // 
            // pbCbDetails
            // 
            this.pbCbDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCbDetails.Location = new System.Drawing.Point(0, 0);
            this.pbCbDetails.Name = "pbCbDetails";
            this.pbCbDetails.Size = new System.Drawing.Size(250, 280);
            this.pbCbDetails.TabIndex = 0;
            this.pbCbDetails.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(171, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 10);
            this.label1.TabIndex = 147;
            this.label1.Text = "6 MVar";
            // 
            // frmFurnaceControlCbDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(250, 280);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.pbCbDetails);
            this.Font = new System.Drawing.Font("B Yekan", 10F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFurnaceControlCbDetails";
            this.ShowInTaskbar = false;
            this.Text = "Capacitor Bank";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFurnaceControlCbDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCbDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.PictureBox pbCbDetails;
        private System.Windows.Forms.Label label1;
    }
}