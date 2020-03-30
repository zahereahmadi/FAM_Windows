using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmTechnicalDocumentItems : Form
    {
        public int technicalDocumentId;
        public string technicalDocumentCode;
        public FrmTechnicalDocumentItems()
        {
            InitializeComponent();
        }

        private void FrmTechnicalDocumentItems_Load(object sender, EventArgs e)
        {
            dgvTechnicalDocumentItems.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                
                var technicalDocuments = db.TechnicalDocuments.GetEntity(t => t.intID == technicalDocumentId);
                var companyId = technicalDocuments.intCompany.ToString();
                var locationId = technicalDocuments.intLocation.ToString();
                var categoryId = technicalDocuments.intCategory.ToString();
                var order = technicalDocuments.intOrder.ToString();
                var model = MyExtentions.GetTechnicalDocumentCode(companyId, locationId, categoryId, order);

                technicalDocumentCode = model.Company + "" + model.Location + "" + model.Category + "" + model.Order;
                txtTechnicalDocument.Text = technicalDocumentCode;
                ListRefresh();
            }
        }

        private void BtnSelectEquip_Click(object sender, EventArgs e)
        {
            FrmSelectEquip frmSelectEquip = new FrmSelectEquip();
            frmSelectEquip.ShowDialog();
            txtEquipName.Text = frmSelectEquip.equipName;
            txtEquipCode.Text = frmSelectEquip.equipCode;
        }

        private void BtnSelectPartType_Click(object sender, EventArgs e)
        {
            FrmSelectPart frmSelectPart = new FrmSelectPart();
            frmSelectPart.ShowDialog();
            txtPartTypeName.Text = frmSelectPart.partName;
            txtPartTypeCode.Text = frmSelectPart.partCode;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (txtPartTypeCode.Text != "" && txtEquipCode.Text != "")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var equipCode = txtEquipCode.Text;
                    var partCode = txtPartTypeCode.Text;
                    tabTechnicalDocumentItems tabTechnicalDocumentItems = new tabTechnicalDocumentItems()
                    {
                        bitIsMain = cbIsMain.Checked,
                        bitSelect = false,
                        nvcDocumentCode = technicalDocumentCode,
                        nvcEquipCode = equipCode,
                        nvcPartCode = partCode
                    };
                    db.TechnicalDocumentItems.Insert(tabTechnicalDocumentItems);
                    db.Save();
                    ListRefresh();
                    txtEquipCode.Text = "";
                    txtEquipName.Text = "";
                    txtPartTypeCode.Text = "";
                    txtPartTypeName.Text = "";
                }

            }

        }

        public void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvTechnicalDocumentItems.DataSource =
                    db.TechnicalDocumentItems.ListTechnicalDocumentItems(txtTechnicalDocument.Text);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvTechnicalDocumentItems.DataSource =
                    db.TechnicalDocumentItems.ListTechnicalDocumentItems(txtTechnicalDocument.Text, txtSearch.Text);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTechnicalDocumentItems.CurrentRow != null)
            {
                using (UnitOfWork db=new UnitOfWork())
                {
                    if (RtlMessageBox.Show("آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(dgvTechnicalDocumentItems.CurrentRow.Cells["intID"].Value.ToString());
                        var technicalDocumentItems = db.TechnicalDocumentItems.GetEntity(t => t.intID == id);
                        db.TechnicalDocumentItems.Delete(technicalDocumentItems);
                        db.Save();
                        ListRefresh();
                    }
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک کالا را از لیست انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
