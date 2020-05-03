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
using Baran.Ferroalloy.Management.Office;

namespace Baran.Ferroalloy.Management.Store
{
    public partial class FrmInvoiceInsert : Form
    {
        public int vendorId;
        public string coId;
        public FrmInvoiceInsert()
        {
            InitializeComponent();
        }

        private void BtmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSelectVendor_Click(object sender, EventArgs e)
        {
            FrmSelectVendor frmSelectVendor=new FrmSelectVendor();
            frmSelectVendor.ShowDialog();
            txtVendor.Text=frmSelectVendor.brand;
            vendorId = frmSelectVendor.vendorId;
        }

        private void BtnSelectEmployee_Click(object sender, EventArgs e)
        {
            FrmSelectEmployee frmSelectEmployee =new FrmSelectEmployee();
            frmSelectEmployee.ShowDialog();
            txtEmployee.Text=frmSelectEmployee.fullName;
            coId = frmSelectEmployee.coId;
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (numInvoiceNumberOfVendor.Value > 0 && txtVendor.Text != "" &&
                txtEmployee.Text != "")
            {
                using (UnitOfWork db=new UnitOfWork())
                {
                    var max = db.Invoices.GetAll().Max(t => t.intInvoiceNumbrOfOwner);
                    tabInvoices tabInvoices = new tabInvoices()
                    {
                        bitSelect = false,
                        datDate = dtpDate.Value,
                        intInvoiceNumberOfVendor = (int)numInvoiceNumberOfVendor.Value,
                        intInvoiceNumbrOfOwner = max + 1,
                        intVendorNumber = vendorId,
                        nvcBuyerCoID = coId
                    };
                    db.Invoices.Insert(tabInvoices);
                    db.Save();
                    this.Close();

                }
                
            }
            else
            {
                RtlMessageBox.Show("لطفا تمام فیلدها را ‍پر کنید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmInvoiceInsert_Load(object sender, EventArgs e)
        {

        }
    }
}
