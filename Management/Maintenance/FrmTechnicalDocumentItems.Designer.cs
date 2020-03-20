namespace Baran.Ferroalloy.Management.Maintenance
{
    partial class FrmTechnicalDocumentItems
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbIsMain = new System.Windows.Forms.CheckBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtPartTypeName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPartTypeCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSelectPartType = new System.Windows.Forms.Button();
            this.txtEquipName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquipCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectEquip = new System.Windows.Forms.Button();
            this.txtTechnicalDocument = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvTechnicalDocumentItems = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicalDocumentItems)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIsMain);
            this.groupBox1.Controls.Add(this.btnOk);
            this.groupBox1.Controls.Add(this.txtPartTypeName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPartTypeCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnSelectPartType);
            this.groupBox1.Controls.Add(this.txtEquipName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEquipCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSelectEquip);
            this.groupBox1.Controls.Add(this.txtTechnicalDocument);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(311, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ورود آیتم مستند";
            // 
            // cbIsMain
            // 
            this.cbIsMain.AutoSize = true;
            this.cbIsMain.Location = new System.Drawing.Point(190, 314);
            this.cbIsMain.Name = "cbIsMain";
            this.cbIsMain.Size = new System.Drawing.Size(83, 24);
            this.cbIsMain.TabIndex = 14;
            this.cbIsMain.Text = "نقشه اصلی";
            this.cbIsMain.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(6, 314);
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
            this.txtPartTypeName.Location = new System.Drawing.Point(6, 267);
            this.txtPartTypeName.Name = "txtPartTypeName";
            this.txtPartTypeName.Size = new System.Drawing.Size(234, 27);
            this.txtPartTypeName.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "نام قطعه:";
            // 
            // txtPartTypeCode
            // 
            this.txtPartTypeCode.Enabled = false;
            this.txtPartTypeCode.Location = new System.Drawing.Point(6, 234);
            this.txtPartTypeCode.Name = "txtPartTypeCode";
            this.txtPartTypeCode.Size = new System.Drawing.Size(234, 27);
            this.txtPartTypeCode.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(246, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "کد قطعه:";
            // 
            // btnSelectPartType
            // 
            this.btnSelectPartType.Location = new System.Drawing.Point(51, 199);
            this.btnSelectPartType.Name = "btnSelectPartType";
            this.btnSelectPartType.Size = new System.Drawing.Size(157, 29);
            this.btnSelectPartType.TabIndex = 7;
            this.btnSelectPartType.Text = "انتخاب قطعه";
            this.btnSelectPartType.UseVisualStyleBackColor = true;
            this.btnSelectPartType.Click += new System.EventHandler(this.BtnSelectPartType_Click);
            // 
            // txtEquipName
            // 
            this.txtEquipName.Enabled = false;
            this.txtEquipName.Location = new System.Drawing.Point(6, 149);
            this.txtEquipName.Name = "txtEquipName";
            this.txtEquipName.Size = new System.Drawing.Size(234, 27);
            this.txtEquipName.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "نام تجهیز:";
            // 
            // txtEquipCode
            // 
            this.txtEquipCode.Enabled = false;
            this.txtEquipCode.Location = new System.Drawing.Point(6, 116);
            this.txtEquipCode.Name = "txtEquipCode";
            this.txtEquipCode.Size = new System.Drawing.Size(234, 27);
            this.txtEquipCode.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(246, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "کد تجهیز:";
            // 
            // btnSelectEquip
            // 
            this.btnSelectEquip.Location = new System.Drawing.Point(51, 81);
            this.btnSelectEquip.Name = "btnSelectEquip";
            this.btnSelectEquip.Size = new System.Drawing.Size(157, 29);
            this.btnSelectEquip.TabIndex = 2;
            this.btnSelectEquip.Text = "انتخاب تجهیز";
            this.btnSelectEquip.UseVisualStyleBackColor = true;
            this.btnSelectEquip.Click += new System.EventHandler(this.BtnSelectEquip_Click);
            // 
            // txtTechnicalDocument
            // 
            this.txtTechnicalDocument.Enabled = false;
            this.txtTechnicalDocument.Location = new System.Drawing.Point(6, 29);
            this.txtTechnicalDocument.Name = "txtTechnicalDocument";
            this.txtTechnicalDocument.Size = new System.Drawing.Size(234, 27);
            this.txtTechnicalDocument.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "کد مستند:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.dgvTechnicalDocumentItems);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(329, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 350);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست آیتم های مستند";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(6, 314);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 30);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // dgvTechnicalDocumentItems
            // 
            this.dgvTechnicalDocumentItems.AllowUserToAddRows = false;
            this.dgvTechnicalDocumentItems.AllowUserToDeleteRows = false;
            this.dgvTechnicalDocumentItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTechnicalDocumentItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicalDocumentItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.equipName,
            this.partName});
            this.dgvTechnicalDocumentItems.Location = new System.Drawing.Point(6, 62);
            this.dgvTechnicalDocumentItems.Name = "dgvTechnicalDocumentItems";
            this.dgvTechnicalDocumentItems.ReadOnly = true;
            this.dgvTechnicalDocumentItems.Size = new System.Drawing.Size(337, 232);
            this.dgvTechnicalDocumentItems.TabIndex = 2;
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            this.intID.HeaderText = "intID";
            this.intID.Name = "intID";
            this.intID.ReadOnly = true;
            this.intID.Visible = false;
            // 
            // equipName
            // 
            this.equipName.DataPropertyName = "equipName";
            this.equipName.HeaderText = "نام تجهیز";
            this.equipName.Name = "equipName";
            this.equipName.ReadOnly = true;
            // 
            // partName
            // 
            this.partName.DataPropertyName = "partName";
            this.partName.HeaderText = "نام قطعه";
            this.partName.Name = "partName";
            this.partName.ReadOnly = true;
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
            // FrmTechnicalDocumentItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(694, 373);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTechnicalDocumentItems";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ورود آیتم های مستند";
            this.Load += new System.EventHandler(this.FrmTechnicalDocumentItems_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicalDocumentItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTechnicalDocument;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtPartTypeName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPartTypeCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSelectPartType;
        private System.Windows.Forms.TextBox txtEquipName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquipCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSelectEquip;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.CheckBox cbIsMain;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvTechnicalDocumentItems;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partName;
    }
}