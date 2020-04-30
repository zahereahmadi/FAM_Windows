namespace Baran.Ferroalloy.Management.Production
{
    partial class frmFurnaceControlConnectionDetails
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
            this.pbConnetionDetails = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbConnetionDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // label106
            // 
            this.label106.AutoSize = true;
            this.label106.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label106.Location = new System.Drawing.Point(28, 9);
            this.label106.Name = "label106";
            this.label106.Size = new System.Drawing.Size(33, 10);
            this.label106.TabIndex = 147;
            this.label106.Text = "Furnace";
            // 
            // pbConnetionDetails
            // 
            this.pbConnetionDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbConnetionDetails.Location = new System.Drawing.Point(0, 0);
            this.pbConnetionDetails.Name = "pbConnetionDetails";
            this.pbConnetionDetails.Size = new System.Drawing.Size(250, 350);
            this.pbConnetionDetails.TabIndex = 0;
            this.pbConnetionDetails.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(196, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 10);
            this.label1.TabIndex = 147;
            this.label1.Text = "Star";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(171, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 10);
            this.label2.TabIndex = 151;
            this.label2.Text = "Delta";
            // 
            // frmFurnaceControlConnectionDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(250, 350);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label106);
            this.Controls.Add(this.pbConnetionDetails);
            this.Font = new System.Drawing.Font("B Yekan", 10F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 389);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(266, 389);
            this.Name = "frmFurnaceControlConnectionDetails";
            this.ShowInTaskbar = false;
            this.Text = "Connection";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmFurnaceControlConnectionDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbConnetionDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label106;
        private System.Windows.Forms.PictureBox pbConnetionDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}