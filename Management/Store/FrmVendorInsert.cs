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

namespace Baran.Ferroalloy.Management.Store
{
    public partial class FrmVendorInsert : Form
    {
        public FrmVendorInsert()
        {
            InitializeComponent();
        }

        private void FrmVendorInsert_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategories.Items.Add(item.nvcName);
                }
            }
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            if (cbCategories.SelectedItem != null && txtBrand.Text != "" && txtAddress.Text != "" &&
                txtCity.Text != "" && txtFirstName.Text != "" && txtLastName.Text != null && txtTell.Text != null &&
                txtTip.Text != "")
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    var categories = db.Categories.GetEntity(t => t.nvcName == cbCategories.SelectedItem);
                    var max = db.Vendors.GetAll().Max(t => t.intNumber);
                    tabVendors tabVendors = new tabVendors()
                    {
                        bitIsActive = true,
                        bitSelect = false,
                        intCategory = categories.intNumber,
                        nvcActivityType = "",
                        nvcAddress = txtAddress.Text.Trim(),
                        nvcBrand = txtBrand.Text.Trim(),
                        nvcCity = txtCity.Text.Trim(),
                        nvcFirstName = txtFirstName.Text.Trim(),
                        nvcLastName = txtLastName.Text.Trim(),
                        nvcTell = txtTell.Text.Trim(),
                        nvcTip = txtTip.Text.Trim(),
                        intNumber = max + 1
                    };
                    db.Vendors.Insert(tabVendors);
                    db.Save();
                    this.Close();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا تمام فیلدها را پر کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
