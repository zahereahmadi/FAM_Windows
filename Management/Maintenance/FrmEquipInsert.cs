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
using Baran.Ferroalloy.Management.Maintenance;

namespace Baran.Ferroalloy.Management
{
    public partial class FrmEquipInsert : Form
    {
        public FrmEquipInsert()
        {
            InitializeComponent();
        }

        private void FrmEquipInsert_Load(object sender, EventArgs e)
        {
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
                    cbLocations.Items.Add(item.nvcName);
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

            btn_SubZonesEdit.Enabled = false;
            btn_EquipNameEdit.Enabled = false;
            SetEnableBtmOk();
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
                btn_SubZonesEdit.Enabled = true;
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
                btn_EquipNameEdit.Enabled = true;
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
                    if (companyId.Length == 1)
                    {
                        companyId = 0 + companyId;
                    }
                    else
                    {
                        companyId = companyId;
                    }

                    var locationId = db.Locations.GetEntityByName(t => t.nvcName == cbLocations.SelectedItem).intNumber.ToString();
                    if (locationId.Length == 1)
                    {
                        locationId = 0 + locationId;
                    }
                    else
                    {
                        locationId = locationId;
                    }

                    var zoneId = db.Zone.GetEntityByName(t => t.nvcName == cbZones.SelectedItem).intNumber.ToString();
                    if (zoneId.Length == 1)
                    {
                        zoneId = 0 + zoneId;
                    }
                    else
                    {
                        zoneId = zoneId;
                    }

                    var subZoneId = db.SubZone.GetEntityByName(t => t.nvcName == cbSubZones.SelectedItem).intNumber.ToString();
                    if (subZoneId.Length == 1)
                    {
                        subZoneId = 0 + subZoneId;
                    }
                    else
                    {
                        subZoneId = subZoneId;
                    }

                    var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber.ToString();
                    if (categoryId.Length == 1)
                    {
                        categoryId = 0 + categoryId;
                    }
                    else
                    {
                        categoryId = categoryId;
                    }

                    var eqiupNameId = db.EquipName.GetEntityByName(t => t.nvcName == cbEqiupName.SelectedItem).intNumber.ToString();
                    if (eqiupNameId.Length == 1)
                    {
                        eqiupNameId = 0 + eqiupNameId;
                    }
                    else
                    {
                        eqiupNameId = eqiupNameId;
                    }

                    var order = db.EquipSamples.GetAll().FirstOrDefault(t =>
                        t.tabCompanies.nvcName.Equals(cbCompanies.SelectedItem) &&
                        t.tabLocationes.nvcName.Equals(cbLocations.SelectedItem) &&
                        t.tabZones.nvcName.Equals(cbZones.SelectedItem) &&
                        t.tabSubZones.nvcName.Equals(cbSubZones.SelectedItem) &&
                        t.tabCategories.nvcName.Equals(cbCategories.SelectedItem) &&
                        t.tabEquipName.nvcName.Equals(cbEqiupName.SelectedItem)).intOrder.ToString();
                    if (order.Length == 1)
                    {
                        order = 0 + order;
                    }
                    else
                    {
                        order = order;
                    }
                    labCode.Text = companyId + "" + locationId + "" + zoneId + "" + subZoneId + "" + categoryId + "" + eqiupNameId + "" + order;
                }
                else
                {
                    btn_EquipNameEdit.Enabled = false;
                }
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
                var equips = db.EquipSamples.GetByWhere(t =>
                    t.intCompany == companyId && t.intLocation == locationId &&
                    t.intZone == zoneId && t.intSubZone == subZonesId && t.intCategory == categoryId &&
                    t.intEquipName == eqiupNameId).Last();
                tabEquipSamples tabEquips = new tabEquipSamples();
                if (equips != null)
                {
                    tabEquips.intOrder = equips.intOrder + 1;
                }
                else
                {
                    tabEquips.intOrder = 1;
                }
                tabEquips.bitSelect = false;
                tabEquips.intCompany = companyId;
                tabEquips.intLocation = locationId;
                tabEquips.intZone = zoneId;
                tabEquips.intSubZone = subZonesId;
                tabEquips.intCategory = categoryId;
                tabEquips.intEquipName = eqiupNameId;
                if (equips.intOrder.ToString().Length == 2)
                {
                    RtlMessageBox.Show("سقف ورود این تجهیز پر شده است", "اخطار", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
                else
                {
                    db.EquipSamples.Insert(tabEquips);
                    db.Save();
                    this.Close();
                    DialogResult = DialogResult.OK;
                }
                
                //if (equips != null)
                //{
                //    RtlMessageBox.Show("این تجهیز قبلا ثبت شده است", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //else
                //{
                //    var order = equips.intOrder.ToString();

                //    tabEquips tabEquips = new tabEquips()
                //    {
                //        bitSelect = false,
                //        intZone = zoneId,
                //        intSubZone = subZonesId,
                //        intCategory = categoryId,
                //        intEquipName = eqiupNameId,
                //        intOrder=Convert.ToInt32(order)
                //    };
                //    db.Equip.Insert(tabEquips);
                //    db.Save();
                //    this.Close();
                //    DialogResult = DialogResult.OK;
                //}
            }
        }

        private void Btn_ZonesEdit_Click(object sender, EventArgs e)
        {
            FrmZones frmZones = new FrmZones();
            frmZones.ShowDialog();
        }

        private void Btn_SubZonesEdit_Click(object sender, EventArgs e)
        {
            FrmSubZones frmSubZones = new FrmSubZones();
            frmSubZones.zoneName = cbZones.SelectedItem.ToString();
            frmSubZones.ShowDialog();
            cbZones.SelectedIndex = -1;
            cbSubZones.SelectedIndex = -1;
        }

        private void Btn_CategoryEdit_Click(object sender, EventArgs e)
        {
            FrmCategoryInsert frmCategoryInsert = new FrmCategoryInsert();
            frmCategoryInsert.ShowDialog();
        }

        private void Btn_EquipNameEdit_Click(object sender, EventArgs e)
        {
            FrmEquipName frmEquipName = new FrmEquipName();
            frmEquipName.categoryName = cbCategories.SelectedItem.ToString();
            frmEquipName.ShowDialog();
            cbCategories.SelectedIndex = -1;
            cbEqiupName.SelectedIndex = -1;
        }
    }
}
