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
    public partial class FrmInvoices : Form
    {
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        public FrmInvoices()
        {
            InitializeComponent();
        }

        private void FrmInvoices_Load(object sender, EventArgs e)
        {
            dtpFromDate.Enabled = false;
            dtpToDate.Enabled = false;
            using (UnitOfWork db=new UnitOfWork())
            {
                var employees = db.Employees.GetByWhere(t => t.intPost == 5 && t.intDepartment == 3 && t.intSubDepartment == 13);
                foreach (var item in employees)
                {
                    cbBuyerNames.Items.Add(item.nvcFirstname + " " + item.nvcLastname);
                }
            }
        }

        public void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
               var invoices = db.Invoices.FilterInvoices(txtBrand.Text.Trim(), (int) numInvoiceNumbrOfOwner.Value,
                    (int) numInvoiceNumberOfVendor.Value, cbBuyerNames.SelectedItem, dtpFromDate.Value, dtpToDate.Value);
               dgvInvoice.DataSource=db.Invoices.FillDgvInvoices(invoices);
            }

        }

        private void BtmSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void ChbDateCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (chbDateCheck.Checked)
            {
                dtpFromDate.Enabled = true;
                dtpToDate.Enabled = true;
            }
            else
            {
                dtpFromDate.Enabled = false;
                dtpToDate.Enabled = false;
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            if (dgvInvoice.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (RtlMessageBox.Show($"آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var selectItems = dgvInvoice.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToBoolean(t.Cells["bitSelect"].Value) == true).ToList();

                        foreach (var item in selectItems)
                        {
                            var id = int.Parse(item.Cells["intID"].Value.ToString());
                            var invoices = db.Invoices.GetEntity(t => t.intID == id);
                            db.Invoices.Delete(invoices);

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

        private void TxtAmont_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void NumInvoiceNumbrOfOwner_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void NumInvoiceNumberOfVendor_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void BtmInsert_Click(object sender, EventArgs e)
        {
            FrmInvoiceInsert frmInvoiceInsert=new FrmInvoiceInsert();
            frmInvoiceInsert.Show();
        }

        private void DgvInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmInvoiceUpdate frmInvoiceUpdate=new FrmInvoiceUpdate();
            frmInvoiceUpdate.invoiceId = Convert.ToInt32(dgvInvoice.CurrentRow.Cells["intID"].Value.ToString());
            frmInvoiceUpdate.Show();
        }

        private void BtmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
