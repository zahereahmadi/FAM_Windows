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

namespace Baran.Ferroalloy.Management
{
    public partial class FrmEquipUpdate : Form
    {
        public int equipId;

        public FrmEquipUpdate()
        {
            InitializeComponent();
        }

        private void FrmEquipUpdate_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var equips = db.EquipSamples.GetEntity(t => t.intID == equipId);
                var companies = db.Companies.GetAll();
                foreach (var item in companies)
                {
                    cbCompanies.Items.Add(item.nvcName);
                }
                cbCompanies.SelectedItem = equips.tabCompanies.nvcName;

                var locationes = db.Locations.GetAll();
                foreach (var item in locationes)
                {
                    cbLocations.Items.Add(item.nvcName);
                }
                cbLocations.SelectedItem = equips.tabLocationes.nvcName;

                var zones = db.Zone.GetAll();
                foreach (var item in zones)
                {
                    cbZones.Items.Add(item.nvcName);
                }

                cbZones.SelectedItem = equips.tabZones.nvcName;

                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategories.Items.Add(item.nvcName);
                }

                cbCategories.SelectedItem = equips.tabCategories.nvcName;

                cbSubZones.SelectedItem = equips.tabSubZones.nvcName;
                cbEqiupName.SelectedItem = equips.tabEquipName.nvcName;
            }

            SetEnableBtmOk();
        }

        private void SetEnableBtmOk()
        {
            if (this.cbZones.SelectedIndex >= 0 && this.cbSubZones.SelectedIndex >= 0 &&
                this.cbCategories.SelectedIndex >= 0 && this.cbEqiupName.SelectedIndex >= 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
            SetEnableBtmOk();
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
            SetEnableBtmOk();
        }

        private void CbEqiupName_SelectedIndexChanged(object sender, EventArgs e)
        {
            labCode.Text = "";
            labName.Text = "";
            using (UnitOfWork db = new UnitOfWork())
            {

                if (cbZones.SelectedIndex != -1 && cbSubZones.SelectedIndex != -1 && cbCategories.SelectedIndex != -1)
                {
                    cbEqiupName.Enabled = true;
                    this.labName.Text = cbEqiupName.SelectedItem.ToString();
                    var companyId = db.Companies.GetEntityByName(t => t.nvcName == cbCompanies.SelectedItem).intNumber.ToString();
                    var locationId = db.Locations.GetEntityByName(t => t.nvcName == cbLocations.SelectedItem).intNumber.ToString();
                    var zoneId = db.Zone.GetEntityByName(t => t.nvcName == cbZones.SelectedItem).intNumber.ToString();
                    var subZoneId = db.SubZone.GetEntityByName(t => t.nvcName == cbSubZones.SelectedItem).intNumber.ToString();
                    var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber.ToString();
                    var eqiupNameId = db.EquipName.GetEntityByName(t => t.nvcName == cbEqiupName.SelectedItem).intNumber.ToString();
                    var order = db.EquipSamples.GetAll().FirstOrDefault(t =>
                        t.tabZones.nvcName.Equals(cbZones.SelectedItem) &&
                        t.tabSubZones.nvcName.Equals(cbSubZones.SelectedItem) &&
                        t.tabCategories.nvcName.Equals(cbCategories.SelectedItem) &&
                        t.tabEquipName.nvcName.Equals(cbEqiupName.SelectedItem)).intOrder.ToString();

                    var model = MyExtentions.GetEquipSample(companyId, locationId, zoneId, subZoneId, categoryId, eqiupNameId, order);
                    labCode.Text = model.CompanyId + "" + model.LocationId + "" + model.ZoneId + "" + model.SubZoneId + "" +
                                   model.CategoryId + "" + model.EquipNameId;
                }

            }

            SetEnableBtmOk();
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var companyId = db.Companies.GetEntityByName(t => t.nvcName == cbCompanies.SelectedItem).intNumber;
                var locationId = db.Locations.GetEntityByName(t => t.nvcName == cbLocations.SelectedItem).intNumber;
                var zoneId = db.Zone.GetEntityByName(t => t.nvcName == cbZones.SelectedItem).intNumber;
                var subZonesId = db.SubZone.GetEntityByName(t => t.nvcName == cbSubZones.SelectedItem).intNumber;
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber;
                var eqiupNameId = db.EquipName.GetEntityByName(t => t.nvcName == cbEqiupName.SelectedItem).intNumber;
                var equips = db.EquipSamples.GetEntity(t => t.intID == equipId);
                equips.intID = equipId;
                equips.intCompany = companyId;
                equips.intLocation = locationId;
                equips.intZone = zoneId;
                equips.intSubZone = subZonesId;
                equips.intCategory = categoryId;
                equips.intEquipName = eqiupNameId;
                equips.intOrder = equips.intOrder;
                db.EquipSamples.Update(equips);
                db.Save();
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
