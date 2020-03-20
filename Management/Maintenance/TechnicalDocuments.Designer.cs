namespace Baran.Ferroalloy.Management
{
    partial class TechnicalDocuments
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
            this.btmExit = new System.Windows.Forms.Button();
            this.tbRevisionNumber = new System.Windows.Forms.TextBox();
            this.tbCoDesigner = new System.Windows.Forms.TextBox();
            this.cbLocations = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbCompanies = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbCategories = new System.Windows.Forms.ComboBox();
            this.labelcategory = new System.Windows.Forms.Label();
            this.tbDesignerName = new System.Windows.Forms.TextBox();
            this.btmSearch = new System.Windows.Forms.Button();
            this.dgvTechnicalDocuments = new System.Windows.Forms.DataGridView();
            this.intID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bitSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CompanyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoDesigner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonDesigner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RevisionNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btmInsert = new System.Windows.Forms.Button();
            this.btmDelete = new System.Windows.Forms.Button();
            this.btmClose = new System.Windows.Forms.Button();
            this.btnTachnicalDocumentItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicalDocuments)).BeginInit();
            this.SuspendLayout();
            // 
            // btmExit
            // 
            this.btmExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btmExit.Location = new System.Drawing.Point(578, 798);
            this.btmExit.Margin = new System.Windows.Forms.Padding(0);
            this.btmExit.Name = "btmExit";
            this.btmExit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.btmExit.Size = new System.Drawing.Size(128, 33);
            this.btmExit.TabIndex = 4;
            this.btmExit.Text = "خروج";
            this.btmExit.UseVisualStyleBackColor = true;
            this.btmExit.Click += new System.EventHandler(this.btmExit_Click);
            // 
            // tbRevisionNumber
            // 
            this.tbRevisionNumber.Location = new System.Drawing.Point(1110, 129);
            this.tbRevisionNumber.Margin = new System.Windows.Forms.Padding(2);
            this.tbRevisionNumber.Name = "tbRevisionNumber";
            this.tbRevisionNumber.Size = new System.Drawing.Size(120, 27);
            this.tbRevisionNumber.TabIndex = 35;
            // 
            // tbCoDesigner
            // 
            this.tbCoDesigner.Location = new System.Drawing.Point(476, 129);
            this.tbCoDesigner.Margin = new System.Windows.Forms.Padding(2);
            this.tbCoDesigner.Name = "tbCoDesigner";
            this.tbCoDesigner.Size = new System.Drawing.Size(224, 27);
            this.tbCoDesigner.TabIndex = 33;
            // 
            // cbLocations
            // 
            this.cbLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbLocations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLocations.FormattingEnabled = true;
            this.cbLocations.Location = new System.Drawing.Point(658, 56);
            this.cbLocations.Margin = new System.Windows.Forms.Padding(4);
            this.cbLocations.Name = "cbLocations";
            this.cbLocations.Size = new System.Drawing.Size(133, 28);
            this.cbLocations.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(613, 58);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "محل:";
            // 
            // cbCompanies
            // 
            this.cbCompanies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCompanies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCompanies.FormattingEnabled = true;
            this.cbCompanies.Location = new System.Drawing.Point(352, 56);
            this.cbCompanies.Margin = new System.Windows.Forms.Padding(4);
            this.cbCompanies.Name = "cbCompanies";
            this.cbCompanies.Size = new System.Drawing.Size(133, 28);
            this.cbCompanies.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(296, 59);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 21);
            this.label8.TabIndex = 51;
            this.label8.Text = "شرکت:";
            // 
            // cbCategories
            // 
            this.cbCategories.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategories.FormattingEnabled = true;
            this.cbCategories.Location = new System.Drawing.Point(984, 56);
            this.cbCategories.Margin = new System.Windows.Forms.Padding(4);
            this.cbCategories.Name = "cbCategories";
            this.cbCategories.Size = new System.Drawing.Size(133, 28);
            this.cbCategories.TabIndex = 56;
            // 
            // labelcategory
            // 
            this.labelcategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelcategory.AutoSize = true;
            this.labelcategory.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelcategory.Location = new System.Drawing.Point(934, 58);
            this.labelcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelcategory.Name = "labelcategory";
            this.labelcategory.Size = new System.Drawing.Size(42, 21);
            this.labelcategory.TabIndex = 55;
            this.labelcategory.Text = "رسته:";
            // 
            // tbDesignerName
            // 
            this.tbDesignerName.Location = new System.Drawing.Point(781, 129);
            this.tbDesignerName.Margin = new System.Windows.Forms.Padding(2);
            this.tbDesignerName.Name = "tbDesignerName";
            this.tbDesignerName.Size = new System.Drawing.Size(224, 27);
            this.tbDesignerName.TabIndex = 61;
            // 
            // btmSearch
            // 
            this.btmSearch.Location = new System.Drawing.Point(1022, 194);
            this.btmSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btmSearch.Name = "btmSearch";
            this.btmSearch.Size = new System.Drawing.Size(208, 30);
            this.btmSearch.TabIndex = 57;
            this.btmSearch.Text = "جستجو";
            this.btmSearch.UseVisualStyleBackColor = true;
            this.btmSearch.Click += new System.EventHandler(this.btmSearch_Click);
            // 
            // dgvTechnicalDocuments
            // 
            this.dgvTechnicalDocuments.AllowUserToAddRows = false;
            this.dgvTechnicalDocuments.AllowUserToDeleteRows = false;
            this.dgvTechnicalDocuments.AllowUserToOrderColumns = true;
            this.dgvTechnicalDocuments.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTechnicalDocuments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTechnicalDocuments.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTechnicalDocuments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTechnicalDocuments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnicalDocuments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.intID,
            this.bitSelect,
            this.CompanyName,
            this.LocationName,
            this.CategoryName,
            this.Type,
            this.Order,
            this.CoDesigner,
            this.PersonDesigner,
            this.RevisionNumber});
            this.dgvTechnicalDocuments.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgvTechnicalDocuments.Location = new System.Drawing.Point(119, 237);
            this.dgvTechnicalDocuments.Margin = new System.Windows.Forms.Padding(2);
            this.dgvTechnicalDocuments.Name = "dgvTechnicalDocuments";
            this.dgvTechnicalDocuments.RowTemplate.Height = 55;
            this.dgvTechnicalDocuments.Size = new System.Drawing.Size(1130, 359);
            this.dgvTechnicalDocuments.TabIndex = 25;
            this.dgvTechnicalDocuments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTechnicalDocuments_CellDoubleClick);
            // 
            // intID
            // 
            this.intID.DataPropertyName = "intID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.intID.DefaultCellStyle = dataGridViewCellStyle2;
            this.intID.HeaderText = "intID";
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
            this.bitSelect.Name = "bitSelect";
            // 
            // CompanyName
            // 
            this.CompanyName.DataPropertyName = "CompanyName";
            this.CompanyName.HeaderText = "شرکت";
            this.CompanyName.Name = "CompanyName";
            // 
            // LocationName
            // 
            this.LocationName.DataPropertyName = "LocationName";
            this.LocationName.HeaderText = "محل";
            this.LocationName.Name = "LocationName";
            // 
            // CategoryName
            // 
            this.CategoryName.DataPropertyName = "CategoryName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CategoryName.DefaultCellStyle = dataGridViewCellStyle4;
            this.CategoryName.HeaderText = "رسته";
            this.CategoryName.Name = "CategoryName";
            this.CategoryName.ReadOnly = true;
            this.CategoryName.ToolTipText = "رسته";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "نوع";
            this.Type.Name = "Type";
            // 
            // Order
            // 
            this.Order.DataPropertyName = "Order";
            this.Order.HeaderText = "ترتیب";
            this.Order.Name = "Order";
            // 
            // CoDesigner
            // 
            this.CoDesigner.DataPropertyName = "CoDesigner";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.CoDesigner.DefaultCellStyle = dataGridViewCellStyle5;
            this.CoDesigner.HeaderText = "شرکت طراح";
            this.CoDesigner.Name = "CoDesigner";
            this.CoDesigner.ReadOnly = true;
            this.CoDesigner.ToolTipText = "شرکت طراح";
            // 
            // PersonDesigner
            // 
            this.PersonDesigner.DataPropertyName = "PersonDesigner";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.PersonDesigner.DefaultCellStyle = dataGridViewCellStyle6;
            this.PersonDesigner.HeaderText = "فرد طراح";
            this.PersonDesigner.Name = "PersonDesigner";
            this.PersonDesigner.ReadOnly = true;
            this.PersonDesigner.ToolTipText = "فرد طراح";
            // 
            // RevisionNumber
            // 
            this.RevisionNumber.DataPropertyName = "RevisionNumber";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RevisionNumber.DefaultCellStyle = dataGridViewCellStyle7;
            this.RevisionNumber.HeaderText = "شماره نگارش";
            this.RevisionNumber.Name = "RevisionNumber";
            this.RevisionNumber.ReadOnly = true;
            this.RevisionNumber.ToolTipText = "شماره نگارش";
            // 
            // cbType
            // 
            this.cbType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(212, 129);
            this.cbType.Margin = new System.Windows.Forms.Padding(4);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(133, 28);
            this.cbType.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(142, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 63;
            this.label1.Text = "نوع نقشه:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(718, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 21);
            this.label2.TabIndex = 65;
            this.label2.Text = "نام طراح:";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(364, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 21);
            this.label7.TabIndex = 66;
            this.label7.Text = "شرکت تهیه کننده:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("B Yekan", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(1021, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 67;
            this.label3.Text = "شماره نگارش:";
            // 
            // btmInsert
            // 
            this.btmInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmInsert.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmInsert.Location = new System.Drawing.Point(537, 620);
            this.btmInsert.Margin = new System.Windows.Forms.Padding(0);
            this.btmInsert.Name = "btmInsert";
            this.btmInsert.Size = new System.Drawing.Size(127, 35);
            this.btmInsert.TabIndex = 69;
            this.btmInsert.Text = "ورود";
            this.btmInsert.UseVisualStyleBackColor = true;
            this.btmInsert.Click += new System.EventHandler(this.BtmInsert_Click);
            // 
            // btmDelete
            // 
            this.btmDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmDelete.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmDelete.Location = new System.Drawing.Point(354, 620);
            this.btmDelete.Margin = new System.Windows.Forms.Padding(0);
            this.btmDelete.Name = "btmDelete";
            this.btmDelete.Size = new System.Drawing.Size(125, 35);
            this.btmDelete.TabIndex = 70;
            this.btmDelete.Text = "حذف";
            this.btmDelete.UseVisualStyleBackColor = true;
            this.btmDelete.Click += new System.EventHandler(this.BtmDelete_Click);
            // 
            // btmClose
            // 
            this.btmClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btmClose.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btmClose.Location = new System.Drawing.Point(537, 683);
            this.btmClose.Margin = new System.Windows.Forms.Padding(0);
            this.btmClose.Name = "btmClose";
            this.btmClose.Size = new System.Drawing.Size(125, 35);
            this.btmClose.TabIndex = 68;
            this.btmClose.Text = "خروج";
            this.btmClose.UseVisualStyleBackColor = true;
            this.btmClose.Click += new System.EventHandler(this.btmClose_Click);
            // 
            // btnTachnicalDocumentItems
            // 
            this.btnTachnicalDocumentItems.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTachnicalDocumentItems.Font = new System.Drawing.Font("B Yekan", 11F);
            this.btnTachnicalDocumentItems.Location = new System.Drawing.Point(722, 620);
            this.btnTachnicalDocumentItems.Margin = new System.Windows.Forms.Padding(0);
            this.btnTachnicalDocumentItems.Name = "btnTachnicalDocumentItems";
            this.btnTachnicalDocumentItems.Size = new System.Drawing.Size(161, 35);
            this.btnTachnicalDocumentItems.TabIndex = 71;
            this.btnTachnicalDocumentItems.Text = "ورود آیتم های مستند";
            this.btnTachnicalDocumentItems.UseVisualStyleBackColor = true;
            this.btnTachnicalDocumentItems.Click += new System.EventHandler(this.BtnTachnicalDocumentItems_Click);
            // 
            // TechnicalDocuments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1362, 764);
            this.Controls.Add(this.btnTachnicalDocumentItems);
            this.Controls.Add(this.btmInsert);
            this.Controls.Add(this.btmDelete);
            this.Controls.Add(this.btmClose);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvTechnicalDocuments);
            this.Controls.Add(this.tbDesignerName);
            this.Controls.Add(this.btmSearch);
            this.Controls.Add(this.tbRevisionNumber);
            this.Controls.Add(this.cbCategories);
            this.Controls.Add(this.labelcategory);
            this.Controls.Add(this.cbLocations);
            this.Controls.Add(this.tbCoDesigner);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbCompanies);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btmExit);
            this.Font = new System.Drawing.Font("B Yekan", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TechnicalDocuments";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "سندهای فنی";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TechnicalDocuments_FormClosing);
            this.Load += new System.EventHandler(this.TechnicalDocuments_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnicalDocuments)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmExit;
        private System.Windows.Forms.TextBox tbRevisionNumber;
        private System.Windows.Forms.TextBox tbCoDesigner;
        private System.Windows.Forms.ComboBox cbLocations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbCompanies;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbCategories;
        private System.Windows.Forms.Label labelcategory;
        private System.Windows.Forms.TextBox tbDesignerName;
        private System.Windows.Forms.Button btmSearch;
        private System.Windows.Forms.DataGridView dgvTechnicalDocuments;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btmInsert;
        private System.Windows.Forms.Button btmDelete;
        private System.Windows.Forms.Button btmClose;
        private System.Windows.Forms.DataGridViewTextBoxColumn intID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bitSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompanyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoDesigner;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonDesigner;
        private System.Windows.Forms.DataGridViewTextBoxColumn RevisionNumber;
        private System.Windows.Forms.Button btnTachnicalDocumentItems;
    }
}