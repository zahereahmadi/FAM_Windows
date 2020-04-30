namespace Baran.Ferroalloy.Management.Production
{
    partial class frmCoolingControl
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
            this.pbCooling = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbCooling)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCooling
            // 
            this.pbCooling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbCooling.ErrorImage = null;
            this.pbCooling.Location = new System.Drawing.Point(0, 0);
            this.pbCooling.Name = "pbCooling";
            this.pbCooling.Size = new System.Drawing.Size(1920, 1000);
            this.pbCooling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbCooling.TabIndex = 0;
            this.pbCooling.TabStop = false;
            // 
            // frmCoolingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1920, 1000);
            this.Controls.Add(this.pbCooling);
            this.Font = new System.Drawing.Font("Arial", 8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCoolingControl";
            this.Text = "frmCoolingControl";
            this.Load += new System.EventHandler(this.frmCoolingControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCooling)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCooling;
    }
}