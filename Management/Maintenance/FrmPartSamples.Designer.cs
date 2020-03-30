namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmPartSamples
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvPartSamples = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtEquipSampleName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPartTypeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartTypeCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectPartType = new System.Windows.Forms.Button();
            this.txtEquipSampleCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartSamples)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.dgvPartSamples);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(329, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 290);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست قطعات یک تجهیز";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 254);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvPartSamples
            // 
            this.dgvPartSamples.AllowUserToAddRows = false;
            this.dgvPartSamples.AllowUserToDeleteRows = false;
            this.dgvPartSamples.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPartSamples.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPartSamples.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.partName,
            this.order});
            this.dgvPartSamples.Location = new System.Drawing.Point(6, 62);
            this.dgvPartSamples.Name = "dgvPartSamples";
            this.dgvPartSamples.ReadOnly = true;
            this.dgvPartSamples.Size = new System.Drawing.Size(337, 186);
            this.dgvPartSamples.TabIndex = 2;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 29);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(287, 27);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "جستجو:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtEquipSampleName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtPartTypeName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPartTypeCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSelectPartType);
            this.groupBox1.Controls.Add(this.txtEquipSampleCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 290);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود قطعه جدید";
            // 
            // txtEquipSampleName
            // 
            this.txtEquipSampleName.Enabled = false;
            this.txtEquipSampleName.Location = new System.Drawing.Point(6, 62);
            this.txtEquipSampleName.Name = "txtEquipSampleName";
            this.txtEquipSampleName.Size = new System.Drawing.Size(238, 27);
            this.txtEquipSampleName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "نام تجهیز:";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(0, 254);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(93, 30);
            this.btnOk.TabIndex = 12;
            this.btnOk.Text = "ورود";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // txtPartTypeName
            // 
            this.txtPartTypeName.Enabled = false;
            this.txtPartTypeName.Location = new System.Drawing.Point(8, 198);
            this.txtPartTypeName.Name = "txtPartTypeName";
            this.txtPartTypeName.Size = new System.Drawing.Size(234, 27);
            this.txtPartTypeName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "نام قطعه:";
            // 
            // txtPartTypeCode
            // 
            this.txtPartTypeCode.Enabled = false;
            this.txtPartTypeCode.Location = new System.Drawing.Point(8, 165);
            this.txtPartTypeCode.Name = "txtPartTypeCode";
            this.txtPartTypeCode.Size = new System.Drawing.Size(234, 27);
            this.txtPartTypeCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "کد قطعه:";
            // 
            // btnSelectPartType
            // 
            this.btnSelectPartType.Location = new System.Drawing.Point(53, 130);
            this.btnSelectPartType.Name = "btnSelectPartType";
            this.btnSelectPartType.Size = new System.Drawing.Size(157, 29);
            this.btnSelectPartType.TabIndex = 7;
            this.btnSelectPartType.Text = "انتخاب قطعه";
            this.btnSelectPartType.UseVisualStyleBackColor = true;
            this.btnSelectPartType.Click += new System.EventHandler(this.BtnSelectPartType_Click);
            // 
            // txtEquipSampleCode
            // 
            this.txtEquipSampleCode.Enabled = false;
            this.txtEquipSampleCode.Location = new System.Drawing.Point(6, 29);
            this.txtEquipSampleCode.Name = "txtEquipSampleCode";
            this.txtEquipSampleCode.Size = new System.Drawing.Size(238, 27);
            this.txtEquipSampleCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد تجهیز:";
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            this.intID.HeaderText = "intID";
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            this.intID.Visible = false;
            // 
            // partName
            // 
            this.partName.DataPropertyName = "partName";
            this.partName.HeaderText = "نام قطعه";
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
            // 
            // order
            // 
            this.order.DataPropertyName = "order";
            this.order.HeaderText = "ترتیب";
            this.order.Name = "order";
            this.order.ReadOnly = true;
            // 
            // FrmPartSamples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(694, 313);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPartSamples";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست قطعات";
            this.Load += new System.EventHandler(this.FrmPartSamples_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPartSamples)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvPartSamples;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtPartTypeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPartTypeCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectPartType;
        private System.Windows.Forms.TextBox txtEquipSampleCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEquipSampleName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
    }
}