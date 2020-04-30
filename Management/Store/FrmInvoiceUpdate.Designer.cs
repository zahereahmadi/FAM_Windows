namespace Baran.Ferroalloy.Management.Store
{
    partial class FrmInvoiceUpdate
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btmClose = new System.Windows.Forms.Button();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.btnSelectEmployee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVendor = new System.Windows.Forms.TextBox();
            this.btnSelectVendor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.numInvoiceNumberOfVendor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceNumberOfVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnOk.Location = new System.Drawing.Point(233, 283);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(125, 35);
            this.btnOk.TabIndex = 102;
            this.btnOk.Text = "تایید";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // btmClose
            // 
            this.btmClose.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btmClose.Location = new System.Drawing.Point(378, 283);
            this.btmClose.Margin = new System.Windows.Forms.Padding(4);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(125, 35);
            this.btmClose.TabIndex = 101;
            this.btmClose.Text = "رد";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.BtmClose_Click);
            // 
            // txtEmployee
            // 
            this.txtEmployee.Enabled = false;
            this.txtEmployee.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEmployee.Location = new System.Drawing.Point(312, 195);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(345, 28);
            this.txtEmployee.TabIndex = 100;
            // 
            // btnSelectEmployee
            // 
            this.btnSelectEmployee.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectEmployee.Location = new System.Drawing.Point(156, 193);
            this.btnSelectEmployee.Name = "btnSelectEmployee";
            this.btnSelectEmployee.Size = new System.Drawing.Size(133, 31);
            this.btnSelectEmployee.TabIndex = 99;
            this.btnSelectEmployee.Text = "انتخاب";
            this.btnSelectEmployee.UseVisualStyleBackColor = true;
            this.btnSelectEmployee.Click += new System.EventHandler(this.BtnSelectEmployee_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(58, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 21);
            this.label4.TabIndex = 98;
            this.label4.Text = "انتخاب کارمند:";
            // 
            // txtVendor
            // 
            this.txtVendor.Enabled = false;
            this.txtVendor.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtVendor.Location = new System.Drawing.Point(312, 127);
            this.txtVendor.Name = "txtVendor";
            this.txtVendor.Size = new System.Drawing.Size(345, 28);
            this.txtVendor.TabIndex = 97;
            // 
            // btnSelectVendor
            // 
            this.btnSelectVendor.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSelectVendor.Location = new System.Drawing.Point(156, 125);
            this.btnSelectVendor.Name = "btnSelectVendor";
            this.btnSelectVendor.Size = new System.Drawing.Size(133, 31);
            this.btnSelectVendor.TabIndex = 96;
            this.btnSelectVendor.Text = "انتخاب";
            this.btnSelectVendor.UseVisualStyleBackColor = true;
            this.btnSelectVendor.Click += new System.EventHandler(this.BtnSelectVendor_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(58, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 21);
            this.label2.TabIndex = 95;
            this.label2.Text = "انتخاب فروشگاه:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(374, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 94;
            this.label1.Text = "تاریخ فاکتور:";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(457, 55);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 27);
            this.dtpDate.TabIndex = 93;
            // 
            // numInvoiceNumberOfVendor
            // 
            this.numInvoiceNumberOfVendor.Location = new System.Drawing.Point(156, 58);
            this.numInvoiceNumberOfVendor.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numInvoiceNumberOfVendor.Name = "numInvoiceNumberOfVendor";
            this.numInvoiceNumberOfVendor.Size = new System.Drawing.Size(136, 27);
            this.numInvoiceNumberOfVendor.TabIndex = 92;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(66, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 91;
            this.label3.Text = "شماره فاکتور :";
            // 
            // FrmInvoiceUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(715, 372);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.btnSelectEmployee);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtVendor);
            this.Controls.Add(this.btnSelectVendor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.numInvoiceNumberOfVendor);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvoiceUpdate";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ویرایش فاکتور";
            this.Load += new System.EventHandler(this.FrmInvoiceUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceNumberOfVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.Button btnSelectEmployee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVendor;
        private System.Windows.Forms.Button btnSelectVendor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.NumericUpDown numInvoiceNumberOfVendor;
        private System.Windows.Forms.Label label3;
    }
}