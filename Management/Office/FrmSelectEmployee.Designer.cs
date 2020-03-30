namespace Baran.Ferroalloy.Management.Office
{
    partial class FrmSelectEmployee
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmSelect = new System.Windows.Forms.Button();
            this.btmClose = new System.Windows.Forms.Button();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nvcFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentTilte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcNationalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nvcCoID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDepartments = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbCoID = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // btmSelect
            // 
            this.btmSelect.Location = new System.Drawing.Point(308, 498);
            this.btmSelect.Margin = new System.Windows.Forms.Padding(4);
            this.btmSelect.Name = "btmSelect";
            this.btmSelect.Size = new System.Drawing.Size(125, 35);
            this.btmSelect.TabIndex = 44;
            this.btmSelect.Text = "انتخاب";
            this.btmSelect.UseVisualStyleBackColor = true;
            this.btmSelect.Click += new System.EventHandler(this.BtmSelect_Click);
            // 
            // btmClose
            // 
            this.btmClose.Location = new System.Drawing.Point(453, 498);
            this.btmClose.Margin = new System.Windows.Forms.Padding(4);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(125, 35);
            this.btmClose.TabIndex = 43;
            this.btmClose.Text = "رد";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.BtmClose_Click);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AllowUserToAddRows = false;
            this.dgvEmployees.AllowUserToDeleteRows = false;
            this.dgvEmployees.AllowUserToOrderColumns = true;
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.nvcFirstName,
            this.nvcLastName,
            this.departmentTilte,
            this.nvcNationalID,
            this.nvcCoID});
            this.dgvEmployees.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvEmployees.Location = new System.Drawing.Point(71, 209);
            this.dgvEmployees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.ReadOnly = true;
            this.dgvEmployees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEmployees.RowTemplate.Height = 55;
            this.dgvEmployees.Size = new System.Drawing.Size(743, 228);
            this.dgvEmployees.TabIndex = 42;
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle10;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            this.intID.Visible = false;
            // 
            // bitSelect
            // 
            this.bitSelect.DataPropertyName = "bitSelect";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.NullValue = false;
            this.bitSelect.DefaultCellStyle = dataGridViewCellStyle11;
            this.bitSelect.HeaderText = "انتخاب";
            this.bitSelect.MinimumWidth = 10;
            this.bitSelect.Name = "bitSelect";
            this.bitSelect.ReadOnly = true;
            this.bitSelect.Visible = false;
            // 
            // nvcFirstName
            // 
            this.nvcFirstName.DataPropertyName = "nvcFirstName";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nvcFirstName.DefaultCellStyle = dataGridViewCellStyle12;
            this.nvcFirstName.HeaderText = "نام";
            this.nvcFirstName.MinimumWidth = 10;
            this.nvcFirstName.Name = "nvcFirstName";
            this.nvcFirstName.ReadOnly = true;
            this.nvcFirstName.ToolTipText = "نام کوچک";
            // 
            // nvcLastName
            // 
            this.nvcLastName.DataPropertyName = "nvcLastName";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.nvcLastName.DefaultCellStyle = dataGridViewCellStyle13;
            this.nvcLastName.HeaderText = "نام خانوادگی";
            this.nvcLastName.MinimumWidth = 10;
            this.nvcLastName.Name = "nvcLastName";
            this.nvcLastName.ReadOnly = true;
            // 
            // departmentTilte
            // 
            this.departmentTilte.DataPropertyName = "departmentTilte";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.departmentTilte.DefaultCellStyle = dataGridViewCellStyle14;
            this.departmentTilte.HeaderText = "واحد";
            this.departmentTilte.MinimumWidth = 10;
            this.departmentTilte.Name = "departmentTilte";
            this.departmentTilte.ReadOnly = true;
            this.departmentTilte.ToolTipText = "واحد";
            // 
            // nvcNationalID
            // 
            this.nvcNationalID.DataPropertyName = "nvcNationalID";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcNationalID.DefaultCellStyle = dataGridViewCellStyle15;
            this.nvcNationalID.HeaderText = "کد ملی";
            this.nvcNationalID.MinimumWidth = 10;
            this.nvcNationalID.Name = "nvcNationalID";
            this.nvcNationalID.ReadOnly = true;
            // 
            // nvcCoID
            // 
            this.nvcCoID.DataPropertyName = "nvcCoID";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.nvcCoID.DefaultCellStyle = dataGridViewCellStyle16;
            this.nvcCoID.HeaderText = "کد پرسنلی";
            this.nvcCoID.MinimumWidth = 10;
            this.nvcCoID.Name = "nvcCoID";
            this.nvcCoID.ReadOnly = true;
            this.nvcCoID.ToolTipText = "کد پرسنلی";
            // 
            // cbDepartments
            // 
            this.cbDepartments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDepartments.FormattingEnabled = true;
            this.cbDepartments.Location = new System.Drawing.Point(520, 57);
            this.cbDepartments.Margin = new System.Windows.Forms.Padding(4);
            this.cbDepartments.Name = "cbDepartments";
            this.cbDepartments.Size = new System.Drawing.Size(150, 28);
            this.cbDepartments.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(482, 61);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "واحد:";
            // 
            // tbCoID
            // 
            this.tbCoID.Location = new System.Drawing.Point(239, 57);
            this.tbCoID.Margin = new System.Windows.Forms.Padding(4);
            this.tbCoID.MaxLength = 4;
            this.tbCoID.Name = "tbCoID";
            this.tbCoID.Size = new System.Drawing.Size(80, 27);
            this.tbCoID.TabIndex = 38;
            this.tbCoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(273, 103);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(150, 27);
            this.tbLastName.TabIndex = 35;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 61);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 39;
            this.label3.Text = "کد پرسنلی:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 107);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "نام خانوادگی:";
            // 
            // btmSearch
            // 
            this.btmSearch.Location = new System.Drawing.Point(627, 150);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(125, 35);
            this.btmSearch.TabIndex = 40;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.BtmSearch_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(491, 103);
            this.tbFirstName.Margin = new System.Windows.Forms.Padding(4);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(150, 27);
            this.tbFirstName.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(462, 107);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "نام:";
            // 
            // FrmSelectEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.btmSelect);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.dgvEmployees);
            this.Controls.Add(this.cbDepartments);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbCoID);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSelectEmployee";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "انتخاب کارمند";
            this.Load += new System.EventHandler(this.FrmSelectEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmSelect;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.ComboBox cbDepartments;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbCoID;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentTilte;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcNationalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn nvcCoID;
    }
}