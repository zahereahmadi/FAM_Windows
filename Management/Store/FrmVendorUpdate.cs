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

namespace Baran.Ferroalloy.Management.Store
{
    public partial class FrmVendorUpdate : Form
    {
        public int vendorId;
        public FrmVendorUpdate()
        {
            InitializeComponent();
        }

        private void FrmVendorUpdate_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var vendors = db.Vendors.GetEntity(t => t.intID == vendorId);
                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategories.Items.Add(item.nvcName);
                }

                cbCategories.SelectedItem = vendors.tabCategories.nvcName;
                txtBrand.Text = vendors.nvcBrand;
                txtTell.Text = vendors.nvcTell;
                txtFirstName.Text = vendors.nvcFirstName;
                txtLastName.Text = vendors.nvcLastName;
                txtCity.Text = vendors.nvcCity;
                txtAddress.Text = vendors.nvcAddress;
                txtTip.Text = vendors.nvcTip;
            }
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            if (cbCategories.SelectedItem != null && txtBrand.Text != "" && txtAddress.Text != "" &&
                txtCity.Text != "" && txtFirstName.Text != "" && txtLastName.Text != null && txtTell.Text != null &&
                txtTip.Text != "")
            {
                using (UnitOfWork db=new UnitOfWork())
                {
                    var vendors = db.Vendors.GetEntity(t => t.intID == vendorId);
                    var categories = db.Categories.GetEntity(t => t.nvcName == cbCategories.SelectedItem);
                    vendors.intID = vendorId;
                    vendors.nvcAddress = txtAddress.Text.Trim();
                    vendors.nvcBrand = txtBrand.Text.Trim();
                    vendors.nvcCity = txtCity.Text.Trim();
                    vendors.nvcFirstName = txtFirstName.Text.Trim();
                    vendors.nvcLastName = txtLastName.Text.Trim();
                    vendors.nvcTell = txtTell.Text.Trim();
                    vendors.nvcTip = txtTip.Text.Trim();
                    vendors.bitIsActive = vendors.bitIsActive;
                    vendors.bitSelect = vendors.bitSelect;
                    vendors.intCategory = categories.intNumber;
                    vendors.intNumber = vendors.intNumber;
                    vendors.nvcActivityType = vendors.nvcActivityType;
                    db.Vendors.Update(vendors);
                    db.Save();
                    this.Close();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا تمام فیلدها را پر کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBrand_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TxtTell_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TxtFirstName_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TxtLastName_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TxtCity_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TxtAddress_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TxtTip_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        
    }
}
