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
using Baran.Ferroalloy.Management.Office;

namespace Baran.Ferroalloy.Management.Store
{
    public partial class FrmInvoiceUpdate : Form
    {
        public int vendorId;
        public string coId;
        public int invoiceId;
        public FrmInvoiceUpdate()
        {
            InitializeComponent();
        }

        private void FrmInvoiceUpdate_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {

                var invoices = db.Invoices.GetEntity(t => t.intID == invoiceId);
                coId = invoices.nvcBuyerCoID;
                vendorId = invoices.intVendorNumber;
                var employees = db.Employees.GetEntity(t => t.nvcCoID == invoices.nvcBuyerCoID);
                numInvoiceNumberOfVendor.Value = invoices.intInvoiceNumberOfVendor;
                dtpDate.Value = invoices.datDate;
                txtVendor.Text = invoices.tabVendors.nvcBrand;
                txtEmployee.Text = employees.nvcFirstname + " " + employees.nvcLastname;

            }

        }

        private void BtmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (numInvoiceNumberOfVendor.Value >0 && txtVendor.Text != null &&
                txtEmployee.Text != null)
            {
                using (UnitOfWork db=new UnitOfWork())
                {
                    var invoices = db.Invoices.GetEntity(t => t.intID == invoiceId);
                    invoices.intInvoiceNumberOfVendor = (int)numInvoiceNumberOfVendor.Value;
                    invoices.nvcBuyerCoID = coId;
                    invoices.datDate = dtpDate.Value;
                    invoices.intID = invoiceId;
                    invoices.intInvoiceNumbrOfOwner = invoices.intInvoiceNumbrOfOwner;
                    invoices.bitSelect = invoices.bitSelect;
                    invoices.intVendorNumber = vendorId;
                    db.Invoices.Update(invoices);
                    db.Save();
                    this.Close();
                }
            }
        }

        private void BtnSelectVendor_Click(object sender, EventArgs e)
        {
            FrmSelectVendor frmSelectVendor=new FrmSelectVendor();
            frmSelectVendor.ShowDialog();
            txtVendor.Text = frmSelectVendor.brand;
            vendorId = frmSelectVendor.vendorId;
        }

        private void BtnSelectEmployee_Click(object sender, EventArgs e)
        {
            FrmSelectEmployee frmSelectEmployee=new FrmSelectEmployee();
            frmSelectEmployee.ShowDialog();
            txtEmployee.Text = frmSelectEmployee.fullName;
            coId = frmSelectEmployee.coId;
        }
    }
}
