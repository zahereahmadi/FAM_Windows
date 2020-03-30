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

namespace Baran.Ferroalloy.Management
{
    public partial class FrmSelectEquip : Form
    {
        public int equipId;
        public string equipName;
        public string equipCode;

        public FrmSelectEquip()
        {
            InitializeComponent();
            equipId = 0;
            equipName = "";
            equipCode = "";
        }

        private void FrmSelectEquip_Load(object sender, EventArgs e)
        {
            dgvEquips.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                var companies = db.Companies.GetAll();
                foreach (var item in companies)
                {
                    cbCompanies.Items.Add(item.nvcName);
                }

                var locationes = db.Locations.GetAll();
                foreach (var item in locationes)
                {
                    cbLocationes.Items.Add(item.nvcName);
                }

                var zones = db.Zone.GetAll();
                foreach (var item in zones)
                {
                    cbZones.Items.Add(item.nvcName);
                }

                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategories.Items.Add(item.nvcName);
                }
            }
        }

        private void CbZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubZones.Items.Clear();
            labCode.Text = "";
            labName.Text = "";
            using (UnitOfWork db = new UnitOfWork())
            {
                var subZones = db.SubZone.GetByWhere(t => t.tabZones.nvcName == cbZones.SelectedItem);
                foreach (var item in subZones)
                {
                    cbSubZones.Items.Add(item.nvcName);
                }
            }
        }

        private void CbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEqiupName.Items.Clear();
            labCode.Text = "";
            labName.Text = "";
            using (UnitOfWork db = new UnitOfWork())
            {
                var equipName = db.EquipName.GetByWhere(t => t.tabCategories.nvcName == cbCategories.SelectedItem);
                foreach (var item in equipName)
                {
                    cbEqiupName.Items.Add(item.nvcName);
                }
            }
        }

        private void CbEqiupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            labCode.Text = "";
            labName.Text = "";
            using (UnitOfWork db = new UnitOfWork())
            {
                this.labName.Text = cbEqiupName.SelectedItem.ToString();
                var companyId = db.Companies.GetEntityByName(t => t.nvcName == cbCompanies.SelectedItem).intNumber.ToString();
                var locationId = db.Locations.GetEntityByName(t => t.nvcName == cbLocationes.SelectedItem).intNumber.ToString();
                var zoneId = db.Zone.GetEntityByName(t => t.nvcName == cbZones.SelectedItem).intNumber.ToString();
                var subZoneId = db.SubZone.GetEntityByName(t => t.nvcName == cbSubZones.SelectedItem).intNumber.ToString();
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber.ToString();
                var eqiupNameId = db.EquipName.GetEntityByName(t => t.nvcName == cbEqiupName.SelectedItem).intNumber.ToString();
                var model = MyExtentions.GetEquipSample(companyId, locationId, zoneId, subZoneId, categoryId, eqiupNameId,"");
                labCode.Text = model.CompanyId + "" + model.LocationId + "" + model.ZoneId + "" + model.SubZoneId + "" +
                               model.CategoryId + "" + model.EquipNameId;
            }
        }

        public void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var tabEquipSamples = db.EquipSamples.FilterEquipSamples(cbCompanies.SelectedItem,
                    cbLocationes.SelectedItem, cbZones.SelectedItem, cbSubZones.SelectedItem, cbCategories.SelectedItem,
                    cbEqiupName.SelectedItem);
                var list = db.EquipSamples.FillDgvEquips(tabEquipSamples);
                dgvEquips.DataSource = list;
                //var equips = db.EquipSamples.GetAll().Where(t =>
                //    t.tabZones.nvcName.Equals(cbZones.SelectedItem) ||
                //    t.tabSubZones.nvcName.Equals(cbSubZones.SelectedItem) ||
                //    t.tabCategories.nvcName.Equals(cbCategories.SelectedItem) ||
                //    t.tabEquipName.Equals(cbEqiupName.SelectedItem));
                //List<EquipsViewModel> list = new List<EquipsViewModel>();
                //foreach (var item in equips)
                //{
                //    list.Add(new EquipsViewModel()
                //    {
                //        intID = item.intID,
                //        categoryTitle = item.tabCategories.nvcName,
                //        equipNameTitle = item.tabEquipName.nvcName,
                //        subZoneTitle = item.tabSubZones.nvcName,
                //        zoneTitle = item.tabZones.nvcName
                //    });
                //}

                //dgvEquips.DataSource = list;
            }
        }

        private void BtmSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtmSelect_Click(object sender, EventArgs e)
        {
            if (dgvEquips.CurrentRow != null)
            {
                equipId = Convert.ToInt32(dgvEquips.CurrentRow.Cells["intID"].Value.ToString());
                using (UnitOfWork db = new UnitOfWork())
                {
                    var equips = db.EquipSamples.GetEntity(t => t.intID == equipId);
                    equipName = equips.tabEquipName.nvcName;
                    var company = equips.intCompany.ToString();
                    var location = equips.intLocation.ToString();
                    var zone = equips.intZone.ToString();
                    var subZone = equips.intSubZone.ToString();
                    var category = equips.intCategory.ToString();
                    var name = equips.intEquipName.ToString();
                    var order = equips.intOrder.ToString();
                    var model = MyExtentions.GetEquipSample(company, location, zone, subZone, category, name, order);
                    equipCode = model.CompanyId + "" + model.LocationId + "" + model.ZoneId + "" + model.SubZoneId +
                                "" + model.CategoryId + "" + model.EquipNameId + "" + model.OrderId;
                    this.Close();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا یک تجهیز را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
