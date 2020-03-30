﻿namespace Baran.Ferroalloy.Management
{
    partial class FrmEquips
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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEquips = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.companyTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zoneTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subZoneTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equipNameTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btmInsert = new System.Windows.Forms.Button();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmExit = new System.Windows.Forms.Button();
            this.cbZones = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSubZones = new System.Windows.Forms.ComboBox();
            this.Label = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEqiupName = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labCode = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btmSearch = new System.Windows.Forms.Button();
            this.cbCompanies = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPartTypeInsert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquips)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEquips
            // 
            this.dgvEquips.AllowUserToAddRows = false;
            this.dgvEquips.AllowUserToDeleteRows = false;
            this.dgvEquips.AllowUserToOrderColumns = true;
            this.dgvEquips.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEquips.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEquips.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEquips.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEquips.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEquips.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.companyTitle,
            this.locationTitle,
            this.zoneTitle,
            this.subZoneTitle,
            this.categoryTitle,
            this.equipNameTitle,
            this.order});
            this.dgvEquips.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvEquips.Location = new System.Drawing.Point(136, 187);
            this.dgvEquips.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEquips.MultiSelect = false;
            this.dgvEquips.Name = "dgvEquips";
            this.dgvEquips.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvEquips.RowTemplate.Height = 55;
            this.dgvEquips.Size = new System.Drawing.Size(1100, 353);
            this.dgvEquips.TabIndex = 25;
            this.dgvEquips.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvEquips_CellDoubleClick);
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
            // companyTitle
            // 
            this.companyTitle.DataPropertyName = "companyTitle";
            this.companyTitle.HeaderText = "شرکت";
            this.companyTitle.Name = "companyTitle";
            // 
            // locationTitle
            // 
            this.locationTitle.DataPropertyName = "locationTitle";
            this.locationTitle.HeaderText = "محل";
            this.locationTitle.Name = "locationTitle";
            // 
            // zoneTitle
            // 
            this.zoneTitle.DataPropertyName = "zoneTitle";
            this.zoneTitle.HeaderText = "بخش";
            this.zoneTitle.Name = "zoneTitle";
            // 
            // subZoneTitle
            // 
            this.subZoneTitle.DataPropertyName = "subZoneTitle";
            this.subZoneTitle.HeaderText = "زیربخش";
            this.subZoneTitle.Name = "subZoneTitle";
            // 
            // categoryTitle
            // 
            this.categoryTitle.DataPropertyName = "categoryTitle";
            this.categoryTitle.HeaderText = "رسته";
            this.categoryTitle.Name = "categoryTitle";
            // 
            // equipNameTitle
            // 
            this.equipNameTitle.DataPropertyName = "equipNameTitle";
            this.equipNameTitle.HeaderText = "نام";
            this.equipNameTitle.Name = "equipNameTitle";
            // 
            // order
            // 
            this.order.DataPropertyName = "order";
            this.order.HeaderText = "ترتیب";
            this.order.Name = "order";
            // 
            // btmInsert
            // 
            this.btmInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInsert.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmInsert.Location = new System.Drawing.Point(619, 571);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(127, 35);
            this.btmInsert.TabIndex = 26;
            this.btmInsert.Text = "ورود تجهیز";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.BtmInsert_Click);
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmDelete.Location = new System.Drawing.Point(436, 571);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(125, 35);
            this.btmDelete.TabIndex = 27;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.BtmDelete_Click);
            // 
            // btmExit
            // 
            this.btmExit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmExit.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmExit.Location = new System.Drawing.Point(619, 646);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Size = new System.Drawing.Size(125, 35);
            this.btmExit.TabIndex = 24;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.BtmExit_Click);
            // 
            // cbZones
            // 
            this.cbZones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbZones.FormattingEnabled = true;
            this.cbZones.Location = new System.Drawing.Point(258, 86);
            this.cbZones.Margin = new System.Windows.Forms.Padding(4);
            this.cbZones.Name = "cbZones";
            this.cbZones.Size = new System.Drawing.Size(133, 28);
            this.cbZones.TabIndex = 35;
            this.cbZones.SelectedIndexChanged += new System.EventHandler(this.CbZones_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(217, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 21);
            this.label3.TabIndex = 34;
            this.label3.Text = "بخش:";
            // 
            // cbSubZones
            // 
            this.cbSubZones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbSubZones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSubZones.FormattingEnabled = true;
            this.cbSubZones.Location = new System.Drawing.Point(526, 88);
            this.cbSubZones.Margin = new System.Windows.Forms.Padding(4);
            this.cbSubZones.Name = "cbSubZones";
            this.cbSubZones.Size = new System.Drawing.Size(133, 28);
            this.cbSubZones.TabIndex = 37;
            // 
            // Label
            // 
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Label.Location = new System.Drawing.Point(460, 90);
            this.Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(58, 21);
            this.Label.TabIndex = 36;
            this.Label.Text = "زیربخش:";
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(777, 86);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(133, 28);
            this.cbCategories.TabIndex = 39;
            this.cbCategories.SelectedIndexChanged += new System.EventHandler(this.CbCategories_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(727, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "رسته:";
            // 
            // cbEqiupName
            // 
            this.cbEqiupName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbEqiupName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEqiupName.FormattingEnabled = true;
            this.cbEqiupName.Location = new System.Drawing.Point(1025, 90);
            this.cbEqiupName.Margin = new System.Windows.Forms.Padding(4);
            this.cbEqiupName.Name = "cbEqiupName";
            this.cbEqiupName.Size = new System.Drawing.Size(133, 28);
            this.cbEqiupName.TabIndex = 41;
            this.cbEqiupName.SelectedIndexChanged += new System.EventHandler(this.CbEqiupName_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(988, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 21);
            this.label4.TabIndex = 40;
            this.label4.Text = "نام:";
            // 
            // labCode
            // 
            this.labCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labCode.Location = new System.Drawing.Point(249, 141);
            this.labCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labCode.Name = "labCode";
            this.labCode.Size = new System.Drawing.Size(239, 23);
            this.labCode.TabIndex = 45;
            // 
            // labName
            // 
            this.labName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labName.Location = new System.Drawing.Point(665, 141);
            this.labName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(291, 23);
            this.labName.TabIndex = 44;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(217, 141);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 20);
            this.label8.TabIndex = 43;
            this.label8.Text = "کد:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(632, 141);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 42;
            this.label7.Text = "نام:";
            // 
            // btmSearch
            // 
            this.btmSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmSearch.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmSearch.Location = new System.Drawing.Point(1039, 136);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(186, 28);
            this.btmSearch.TabIndex = 46;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.BtmSearch_Click);
            // 
            // cbCompanies
            // 
            this.cbCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.Location = new System.Drawing.Point(479, 35);
            this.cbCompanies.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(133, 28);
            this.cbCompanies.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(423, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 21);
            this.label1.TabIndex = 47;
            this.label1.Text = "شرکت:";
            // 
            // cbLocations
            // 
            this.cbLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(823, 35);
            this.cbLocations.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(133, 28);
            this.cbLocations.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(782, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 21);
            this.label5.TabIndex = 49;
            this.label5.Text = "محل:";
            // 
            // btnPartTypeInsert
            // 
            this.btnPartTypeInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPartTypeInsert.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btnPartTypeInsert.Location = new System.Drawing.Point(802, 571);
            this.btnPartTypeInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btnPartTypeInsert.Name = "btnPartTypeInsert";
            this.btnPartTypeInsert.Size = new System.Drawing.Size(127, 35);
            this.btnPartTypeInsert.TabIndex = 51;
            this.btnPartTypeInsert.Text = "ورود قطعه";
            this.btnPartTypeInsert.UseVisualStyleBackColor = true;
            this.btnPartTypeInsert.Click += new System.EventHandler(this.BtnPartTypeInsert_Click);
            // 
            // FrmEquips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1362, 764);
            this.ControlBox = false;
            this.Controls.Add(this.btnPartTypeInsert);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbCompanies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.labCode);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbEqiupName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSubZones);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.cbZones);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvEquips);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmExit);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEquips";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تجهیز";
            this.Load += new System.EventHandler(this.FrmZones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquips)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dgvEquips;
        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.ComboBox cbZones;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSubZones;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEqiupName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labCode;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.ComboBox cbCompanies;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPartTypeInsert;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn zoneTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn subZoneTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn equipNameTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn order;
    }
}