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
    public partial class FrmPartSamples : Form
    {
        public int equipId;
        public FrmPartSamples()
        {
            InitializeComponent();
        }

        private void FrmPartSamples_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var equipSamples = db.EquipSamples.GetEntity(t => t.intID == equipId);
                var company = equipSamples.intCompany.ToString();
                if (company.Length == 1)
                {
                    company = 0 + company;
                }
                else
                {
                    company = company;
                }

                var location = equipSamples.intLocation.ToString();
                if (location.Length == 1)
                {
                    location = 0 + location;
                }
                else
                {
                    location = location;
                }

                var zone = equipSamples.intZone.ToString();
                if (zone.Length == 1)
                {
                    zone = 0 + zone;
                }
                else
                {
                    zone = zone;
                }

                var subZone = equipSamples.intSubZone.ToString();
                if (subZone.Length == 1)
                {
                    subZone = 0 + subZone;
                }
                else
                {
                    subZone = subZone;
                }

                var category = equipSamples.intCategory.ToString();
                if (category.Length == 1)
                {
                    category = 0 + category;
                }
                else
                {
                    category = category;
                }

                var equipName = equipSamples.intEquipName.ToString();
                if (equipName.Length == 1)
                {
                    equipName = 0 + equipName;
                }
                else
                {
                    equipName = equipName;
                }

                var order = equipSamples.intOrder.ToString();
                if (order.Length == 1)
                {
                    order = 0 + order;
                }
                else
                {
                    order = order;
                }
                txtEquipSampleCode.Text = company+"" + location + "" +zone + "" + subZone + "" +category + "" + equipName + "" + order;

                var name = db.EquipName.GetEntity(t => t.intNumber == equipSamples.intEquipName).nvcName;
                txtEquipSampleName.Text = name;
                ListRefresh();
            }
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
            if (txtPartTypeCode.Text != "" && txtEquipSampleCode.Text != "")
            {
                using (UnitOfWork db=new UnitOfWork())
                {
                    var equipCode = txtEquipSampleCode.Text;
                    var partCode = txtPartTypeCode.Text;
                    var partSamples = db.PartSamples
                        .GetByWhere(t => t.nvcEquipSampleCode == equipCode && t.nvcPartTypeCode == partCode).ToList();
                    tabPartSamples tabPartSamples = new tabPartSamples();
                    if (partSamples.Count > 0)
                    {
                        var last = partSamples.Last();
                        tabPartSamples.intOrder = last.intOrder + 1;
                    }
                    else
                    {
                        tabPartSamples.intOrder = 1;
                    }
                    tabPartSamples.bitSelect = false;
                    tabPartSamples.nvcEquipSampleCode = equipCode;
                    tabPartSamples.nvcPartTypeCode = partCode;
                    db.PartSamples.Insert(tabPartSamples);
                    db.Save();
                    ListRefresh();
                    txtPartTypeCode.Text = "";
                    txtPartTypeName.Text = "";
                }
            }
        }

        private void ListRefresh()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvPartSamples.DataSource = db.PartSamples.ListPartSamples(txtEquipSampleCode.Text);
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                this.dgvPartSamples.DataSource = db.PartSamples.ListPartSamples(txtEquipSampleCode.Text, txtSearch.Text);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPartSamples.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (RtlMessageBox.Show("آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var id = Convert.ToInt32(dgvPartSamples.CurrentRow.Cells["intID"].Value.ToString());
                        var partSamples = db.PartSamples.GetEntity(t => t.intID == id);
                        db.PartSamples.Delete(partSamples);
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
