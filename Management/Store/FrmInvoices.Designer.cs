namespace Baran.Ferroalloy.Management.Store
{
    partial class FrmInvoices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumbrOfOwner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InvoiceNumberOfVendor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuyerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmInsert = new System.Windows.Forms.Button();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmExit = new System.Windows.Forms.Button();
            this.btmIsert2 = new System.Windows.Forms.Button();
            this.chbDateCheck = new System.Windows.Forms.CheckBox();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.labToDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.labFromDate = new System.Windows.Forms.Label();
            this.numInvoiceNumbrOfOwner = new System.Windows.Forms.NumericUpDown();
            this.numInvoiceNumberOfVendor = new System.Windows.Forms.NumericUpDown();
            this.cbBuyerNames = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceNumbrOfOwner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceNumberOfVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(245, 152);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(136, 27);
            this.txtBrand.TabIndex = 45;
            this.txtBrand.Enter += new System.EventHandler(this.TxtBrand_Enter);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(162, 153);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 21);
            this.label5.TabIndex = 44;
            this.label5.Text = "نام فروشگاه:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(438, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "نام خریدار:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(701, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "شماره فاکتور سازمان:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(994, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "شماره فاکتور :";
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSearch.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmSearch.Location = new System.Drawing.Point(1053, 212);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(178, 28);
            this.btmSearch.TabIndex = 52;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.BtmSearch_Click);
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AllowUserToAddRows = false;
            this.dgvInvoice.AllowUserToDeleteRows = false;
            this.dgvInvoice.AllowUserToOrderColumns = true;
            this.dgvInvoice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInvoice.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bitSelect,
            this.intID,
            this.Brand,
            this.InvoiceNumbrOfOwner,
            this.InvoiceNumberOfVendor,
            this.BuyerName,
            this.Date});
            this.dgvInvoice.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvInvoice.Location = new System.Drawing.Point(131, 248);
            this.dgvInvoice.Margin = new System.Windows.Forms.Padding(4);
            this.dgvInvoice.MultiSelect = false;
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvInvoice.RowTemplate.Height = 55;
            this.dgvInvoice.Size = new System.Drawing.Size(1100, 353);
            this.dgvInvoice.TabIndex = 53;
            this.dgvInvoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvInvoice_CellDoubleClick);
            // 
            // bitSelect
            // 
            this.bitSelect.DataPropertyName = "bitSelect";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.NullValue = false;
            this.bitSelect.DefaultCellStyle = dataGridViewCellStyle2;
            this.bitSelect.HeaderText = "انتخاب";
            this.bitSelect.MinimumWidth = 10;
            this.bitSelect.Name = "bitSelect";
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle3;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.Visible = false;
            // 
            // Brand
            // 
            this.Brand.DataPropertyName = "Brand";
            this.Brand.HeaderText = "نام فروشگاه";
            this.Brand.Name = "Brand";
            // 
            // InvoiceNumbrOfOwner
            // 
            this.InvoiceNumbrOfOwner.DataPropertyName = "InvoiceNumbrOfOwner";
            this.InvoiceNumbrOfOwner.HeaderText = "شماره فاکتور سازمان";
            this.InvoiceNumbrOfOwner.Name = "InvoiceNumbrOfOwner";
            // 
            // InvoiceNumberOfVendor
            // 
            this.InvoiceNumberOfVendor.DataPropertyName = "InvoiceNumberOfVendor";
            this.InvoiceNumberOfVendor.HeaderText = "شماره فاکتور";
            this.InvoiceNumberOfVendor.Name = "InvoiceNumberOfVendor";
            // 
            // BuyerName
            // 
            this.BuyerName.DataPropertyName = "BuyerName";
            this.BuyerName.HeaderText = "نام خریدار";
            this.BuyerName.Name = "BuyerName";
            // 
            // Date
            // 
            this.Date.DataPropertyName = "Date";
            this.Date.HeaderText = "تاریخ ثبت";
            this.Date.Name = "Date";
            // 
            // btmInsert
            // 
            this.btmInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInsert.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmInsert.Location = new System.Drawing.Point(619, 632);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(127, 35);
            this.btmInsert.TabIndex = 55;
            this.btmInsert.Text = "ورود";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.BtmInsert_Click);
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmDelete.Location = new System.Drawing.Point(463, 632);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(125, 35);
            this.btmDelete.TabIndex = 56;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.BtmDelete_Click);
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmExit.Location = new System.Drawing.Point(621, 697);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(125, 35);
            this.btmExit.TabIndex = 54;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.BtmExit_Click);
            // 
            // btmIsert2
            // 
            this.btmIsert2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmIsert2.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmIsert2.Location = new System.Drawing.Point(772, 632);
            this.btmIsert2.Margin = new System.Windows.Forms.Padding(0);
            this.btmIsert2.Name = "btmIsert2";
            this.btmIsert2.Size = new System.Drawing.Size(127, 35);
            this.btmIsert2.TabIndex = 57;
            this.btmIsert2.Text = "ورود آیتم فاکتور";
            this.btmIsert2.UseVisualStyleBackColor = true;
            // 
            // chbDateCheck
            // 
            this.chbDateCheck.AutoSize = true;
            this.chbDateCheck.Location = new System.Drawing.Point(374, 101);
            this.chbDateCheck.Name = "chbDateCheck";
            this.chbDateCheck.Size = new System.Drawing.Size(52, 24);
            this.chbDateCheck.TabIndex = 76;
            this.chbDateCheck.Text = "تاریخ";
            this.chbDateCheck.UseVisualStyleBackColor = true;
            this.chbDateCheck.CheckedChanged += new System.EventHandler(this.ChbDateCheck_CheckedChanged);
            // 
            // dtpToDate
            // 
            this.dtpToDate.Enabled = false;
            this.dtpToDate.Location = new System.Drawing.Point(728, 97);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(200, 27);
            this.dtpToDate.TabIndex = 75;
            // 
            // labToDate
            // 
            this.labToDate.AutoSize = true;
            this.labToDate.Enabled = false;
            this.labToDate.Location = new System.Drawing.Point(703, 102);
            this.labToDate.Name = "labToDate";
            this.labToDate.Size = new System.Drawing.Size(20, 20);
            this.labToDate.TabIndex = 74;
            this.labToDate.Text = "تا:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Enabled = false;
            this.dtpFromDate.Location = new System.Drawing.Point(463, 97);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(200, 27);
            this.dtpFromDate.TabIndex = 73;
            // 
            // labFromDate
            // 
            this.labFromDate.AutoSize = true;
            this.labFromDate.Enabled = false;
            this.labFromDate.Location = new System.Drawing.Point(435, 102);
            this.labFromDate.Name = "labFromDate";
            this.labFromDate.Size = new System.Drawing.Size(23, 20);
            this.labFromDate.TabIndex = 72;
            this.labFromDate.Text = "از:";
            // 
            // numInvoiceNumbrOfOwner
            // 
            this.numInvoiceNumbrOfOwner.Location = new System.Drawing.Point(828, 153);
            this.numInvoiceNumbrOfOwner.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numInvoiceNumbrOfOwner.Name = "numInvoiceNumbrOfOwner";
            this.numInvoiceNumbrOfOwner.Size = new System.Drawing.Size(136, 27);
            this.numInvoiceNumbrOfOwner.TabIndex = 77;
            this.numInvoiceNumbrOfOwner.Enter += new System.EventHandler(this.NumInvoiceNumbrOfOwner_Enter);
            // 
            // numInvoiceNumberOfVendor
            // 
            this.numInvoiceNumberOfVendor.Location = new System.Drawing.Point(1084, 153);
            this.numInvoiceNumberOfVendor.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numInvoiceNumberOfVendor.Name = "numInvoiceNumberOfVendor";
            this.numInvoiceNumberOfVendor.Size = new System.Drawing.Size(136, 27);
            this.numInvoiceNumberOfVendor.TabIndex = 78;
            this.numInvoiceNumberOfVendor.Enter += new System.EventHandler(this.NumInvoiceNumberOfVendor_Enter);
            // 
            // cbBuyerNames
            // 
            this.cbBuyerNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbBuyerNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBuyerNames.FormattingEnabled = true;
            this.cbBuyerNames.Location = new System.Drawing.Point(513, 151);
            this.cbBuyerNames.Name = "cbBuyerNames";
            this.cbBuyerNames.Size = new System.Drawing.Size(136, 28);
            this.cbBuyerNames.TabIndex = 79;
            // 
            // FrmInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1362, 764);
            this.ControlBox = false;
            this.Controls.Add(this.cbBuyerNames);
            this.Controls.Add(this.numInvoiceNumberOfVendor);
            this.Controls.Add(this.numInvoiceNumbrOfOwner);
            this.Controls.Add(this.chbDateCheck);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.labToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.labFromDate);
            this.Controls.Add(this.btmIsert2);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.dgvInvoice);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmInvoices";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "فاکتور";
            this.Load += new System.EventHandler(this.FrmInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceNumbrOfOwner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInvoiceNumberOfVendor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.Button btmIsert2;
        private System.Windows.Forms.CheckBox chbDateCheck;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label labToDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label labFromDate;
        private System.Windows.Forms.NumericUpDown numInvoiceNumbrOfOwner;
        private System.Windows.Forms.NumericUpDown numInvoiceNumberOfVendor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumbrOfOwner;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNumberOfVendor;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuyerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.ComboBox cbBuyerNames;
    }
}