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
    public partial class FrmSelectVendor : Form
    {
        public int vendorId;
        public string brand;
        public FrmSelectVendor()
        {
            InitializeComponent();
            vendorId = 0;
            brand = "";
        }

        private void FrmSelectVendor_Load(object sender, EventArgs e)
        {
            dgvVendors.AutoGenerateColumns = false;
            using (UnitOfWork db =new UnitOfWork())
            {
                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategories.Items.Add(item.nvcName);
                }
            }
        }

        private void BtmSearch_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var vendorsList = db.Vendors.FilterVendors(cbCategories.SelectedItem, txtBrand.Text, txtFirstName.Text,
                    txtLastName.Text, "");
                dgvVendors.DataSource = db.Vendors.FillDgvVendors(vendorsList);
            }
        }

        private void BtmSelect_Click(object sender, EventArgs e)
        {
            if (dgvVendors.CurrentRow != null)
            {
                vendorId = int.Parse(dgvVendors.CurrentRow.Cells["intNumber"].Value.ToString());
                brand = dgvVendors.CurrentRow.Cells["Brand1"].Value.ToString();
                this.Close();
            }
            else
            {
                RtlMessageBox.Show("لطفا سطر مورد نظر را انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void BtmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
