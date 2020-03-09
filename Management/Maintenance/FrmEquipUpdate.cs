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
                var equips = db.Equip.GetEntity(t => t.intID == equipId);
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

                    var order = db.Equip.GetEntity(t => t.intID == equipId).intOrder.ToString();
                    if (order.Length == 1)
                    {
                        order = 0 + order;
                    }
                    else
                    {
                        order = order;
                    }
                    labCode.Text = zoneId + "" + subZoneId + "" + categoryId + "" + eqiupNameId + "" + order;
                }

            }

            SetEnableBtmOk();
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var zoneId = db.Zone.GetEntityByName(t => t.nvcName == cbZones.SelectedItem).intNumber;
                var subZonesId = db.SubZone.GetEntityByName(t => t.nvcName == cbSubZones.SelectedItem).intNumber;
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber;
                var eqiupNameId = db.EquipName.GetEntityByName(t => t.nvcName == cbEqiupName.SelectedItem).intNumber;
                var equips = db.Equip.GetEntity(t => t.intID == equipId);
                equips.intID = equipId;
                equips.intZone = zoneId;
                equips.intSubZone = subZonesId;
                equips.intCategory = categoryId;
                equips.intEquipName = eqiupNameId;
                equips.intOrder = equips.intOrder;
                db.Equip.Update(equips);
                db.Save();
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }
    }
}
