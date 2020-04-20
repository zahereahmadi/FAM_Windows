namespace Baran.Ferroalloy.Management
{
    partial class Subprojects
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmInsert = new System.Windows.Forms.Button();
            this.dgvSubProjects = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labCategory = new System.Windows.Forms.Label();
            this.labTip = new System.Windows.Forms.Label();
            this.labProjectNumber = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.btmExit = new System.Windows.Forms.Button();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.projectNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.progress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btmDelete.Location = new System.Drawing.Point(310, 312);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(125, 35);
            this.btmDelete.TabIndex = 2;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.btmDelete_Click);
            // 
            // btmInsert
            // 
            this.btmInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInsert.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btmInsert.Location = new System.Drawing.Point(472, 312);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(125, 35);
            this.btmInsert.TabIndex = 1;
            this.btmInsert.Text = "ورود ";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.btmInsert_Click);
            // 
            // dgvSubProjects
            // 
            this.dgvSubProjects.AllowUserToAddRows = false;
            this.dgvSubProjects.AllowUserToDeleteRows = false;
            this.dgvSubProjects.AllowUserToOrderColumns = true;
            this.dgvSubProjects.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSubProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSubProjects.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSubProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.projectNumber,
            this.categoryName,
            this.name,
            this.datStart,
            this.duration,
            this.progress,
            this.tip});
            this.dgvSubProjects.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvSubProjects.Location = new System.Drawing.Point(84, 71);
            this.dgvSubProjects.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSubProjects.MultiSelect = false;
            this.dgvSubProjects.Name = "dgvSubProjects";
            this.dgvSubProjects.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSubProjects.RowTemplate.Height = 55;
            this.dgvSubProjects.Size = new System.Drawing.Size(743, 222);
            this.dgvSubProjects.TabIndex = 0;
            this.dgvSubProjects.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvSubProjects_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(576, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "نام:";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 21;
            this.label6.Text = "رسته:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(252, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "توضیح:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "شماره پروژه:";
            // 
            // labCategory
            // 
            this.labCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCategory.AutoSize = true;
            this.labCategory.Location = new System.Drawing.Point(474, 29);
            this.labCategory.Name = "labCategory";
            this.labCategory.Size = new System.Drawing.Size(25, 20);
            this.labCategory.TabIndex = 23;
            this.labCategory.Text = "00";
            // 
            // labTip
            // 
            this.labTip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labTip.AutoSize = true;
            this.labTip.Location = new System.Drawing.Point(311, 64);
            this.labTip.Name = "labTip";
            this.labTip.Size = new System.Drawing.Size(25, 20);
            this.labTip.TabIndex = 23;
            this.labTip.Text = "00";
            // 
            // labProjectNumber
            // 
            this.labProjectNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labProjectNumber.AutoSize = true;
            this.labProjectNumber.Location = new System.Drawing.Point(330, 29);
            this.labProjectNumber.Name = "labProjectNumber";
            this.labProjectNumber.Size = new System.Drawing.Size(25, 20);
            this.labProjectNumber.TabIndex = 24;
            this.labProjectNumber.Text = "00";
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.AutoSize = true;
            this.labName.Location = new System.Drawing.Point(609, 29);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(25, 20);
            this.labName.TabIndex = 25;
            this.labName.Text = "00";
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btmExit.Location = new System.Drawing.Point(390, 383);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(125, 35);
            this.btmExit.TabIndex = 3;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.BtmExit_Click);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle2;
            this.intID.HeaderText = "intID";
            this.intID.MinimumWidth = 10;
            this.intID.Name = "intID";
            this.intID.Visible = false;
            // 
            // bitSelect
            // 
            this.bitSelect.DataPropertyName = "bitSelect";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.NullValue = false;
            this.bitSelect.DefaultCellStyle = dataGridViewCellStyle3;
            this.bitSelect.HeaderText = "انتخاب";
            this.bitSelect.MinimumWidth = 10;
            this.bitSelect.Name = "bitSelect";
            // 
            // projectNumber
            // 
            this.projectNumber.DataPropertyName = "projectNumber";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.projectNumber.DefaultCellStyle = dataGridViewCellStyle4;
            this.projectNumber.HeaderText = "شماره پروژه";
            this.projectNumber.MinimumWidth = 10;
            this.projectNumber.Name = "projectNumber";
            this.projectNumber.ToolTipText = "شماره پروژه";
            this.projectNumber.Visible = false;
            // 
            // categoryName
            // 
            this.categoryName.DataPropertyName = "categoryName";
            this.categoryName.HeaderText = "رسته";
            this.categoryName.Name = "categoryName";
            this.categoryName.ToolTipText = "رسته";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.name.DefaultCellStyle = dataGridViewCellStyle5;
            this.name.HeaderText = "نام";
            this.name.MinimumWidth = 10;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ToolTipText = "نام";
            // 
            // datStart
            // 
            this.datStart.DataPropertyName = "datStart";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Format = "D";
            dataGridViewCellStyle6.NullValue = null;
            this.datStart.DefaultCellStyle = dataGridViewCellStyle6;
            this.datStart.HeaderText = "تاریخ شروع";
            this.datStart.MinimumWidth = 10;
            this.datStart.Name = "datStart";
            this.datStart.ToolTipText = "تاریخ شروع";
            // 
            // duration
            // 
            this.duration.DataPropertyName = "duration";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.duration.DefaultCellStyle = dataGridViewCellStyle7;
            this.duration.HeaderText = "مدت";
            this.duration.MinimumWidth = 10;
            this.duration.Name = "duration";
            this.duration.ToolTipText = "مدت";
            // 
            // progress
            // 
            this.progress.DataPropertyName = "progress";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.progress.DefaultCellStyle = dataGridViewCellStyle8;
            this.progress.HeaderText = "پیشرفت";
            this.progress.MinimumWidth = 10;
            this.progress.Name = "progress";
            this.progress.ReadOnly = true;
            this.progress.ToolTipText = "پیشرفت";
            // 
            // tip
            // 
            this.tip.DataPropertyName = "tip";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.tip.DefaultCellStyle = dataGridViewCellStyle9;
            this.tip.HeaderText = "توضیح";
            this.tip.MinimumWidth = 10;
            this.tip.Name = "tip";
            this.tip.ReadOnly = true;
            this.tip.ToolTipText = "توضیح";
            // 
            // Subprojects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(908, 475);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmExit);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.dgvSubProjects);
            this.Controls.Add(this.labProjectNumber);
            this.Controls.Add(this.labTip);
            this.Controls.Add(this.labCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Subprojects";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "زیرپروژه‌ها";
            this.Load += new System.EventHandler(this.SubProjects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubProjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubProjects;
      
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labCategory;
        private System.Windows.Forms.Label labTip;
        private System.Windows.Forms.Label labProjectNumber;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn projectNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn datStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn progress;
        private System.Windows.Forms.DataGridViewTextBoxColumn tip;
    }
}