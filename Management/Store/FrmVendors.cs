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
using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;

namespace Baran.Ferroalloy.Management.Store
{
    public partial class FrmVendors : Form
    {
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        public FrmVendors()
        {
            InitializeComponent();
        }

        private void FrmVendors_Load(object sender, EventArgs e)
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

        public void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var vendors = db.Vendors.FilterVendors(cbCategories.SelectedItem, txtBrand.Text.Trim(), txtFirstName.Text.Trim(),
                    txtLastName.Text.Trim(), txtTell.Text.Trim());
                var list = db.Vendors.FillDgvVendors(vendors);
                dgvVendors.DataSource = list;

            }
        }

        private void BtmSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            if (dgvVendors.CurrentRow != null)
            {
                using (UnitOfWork db=new UnitOfWork())
                {
                    if (RtlMessageBox.Show($"آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var selectItems = dgvVendors.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToBoolean(t.Cells["bitSelect"].Value) == true).ToList();

                        foreach (var item in selectItems)
                        {
                            var id = int.Parse(item.Cells["intID"].Value.ToString());
                            var vendors = db.Vendors.GetEntity(t => t.intID == id);
                            db.Vendors.Delete(vendors);

                        }
                        db.Save();
                        Filter();
                    }
                }
                
            }
            else
            {
                RtlMessageBox.Show("لطفا سطرهای مورد نظر خود را انتخاب کنید", "توجه", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void TxtBrand_Enter(object sender, EventArgs e)
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

        private void TxtTell_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void BtmInsert_Click(object sender, EventArgs e)
        {
            FrmVendorInsert frmVendorInsert=new FrmVendorInsert();
            frmVendorInsert.Show();
        }

        private void DgvVendors_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvVendors.CurrentRow != null)
            {
                FrmVendorUpdate frmVendorUpdate = new FrmVendorUpdate();
                frmVendorUpdate.vendorId = Convert.ToInt32(dgvVendors.CurrentRow.Cells["intID"].Value.ToString());
                frmVendorUpdate.Show();
            }
                
        }

        private void BtmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
