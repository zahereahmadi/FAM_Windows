using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class InvoicesService:Generic<tabInvoices>,IInvoices
    {
        private dbAfrzEntities _db = new dbAfrzEntities();
        public InvoicesService(DbContext db) : base(db)
        {
        }


        public IEnumerable<tabInvoices> FilterInvoices(string brand, int invoiceNumbrOfOwner, int invoiceNumberOfVendor, object buyerName,
            DateTime from, DateTime to)
        {
            List<tabInvoices> invoicesList=new List<tabInvoices>();
            var employees = _db.tabEmployees.FirstOrDefault(t => (t.nvcFirstname + " " + t.nvcLastname) == buyerName);
            if (employees != null)
            {
                invoicesList = _db.tabInvoices.ToList().Where(t => t.tabVendors.nvcBrand.Equals(brand) ||
                                                                       t.intInvoiceNumbrOfOwner == invoiceNumbrOfOwner ||
                                                                       t.nvcBuyerCoID == employees.nvcCoID ||
                                                                       t.intInvoiceNumberOfVendor == invoiceNumberOfVendor ||
                                                                       (t.datDate >= @from && t.datDate <= to)).ToList();
            }
            else
            {
                invoicesList = _db.tabInvoices.ToList().Where(t => t.tabVendors.nvcBrand.Equals(brand) ||
                                                                   t.intInvoiceNumbrOfOwner == invoiceNumbrOfOwner ||
                                                                   t.intInvoiceNumberOfVendor == invoiceNumberOfVendor ||
                                                                   (t.datDate >= @from && t.datDate <= to)).ToList();
            }

            return invoicesList;
        }

        public IEnumerable<dgvInvoicesViewModel> FillDgvInvoices(IEnumerable<tabInvoices> invoices)
        {
            List<dgvInvoicesViewModel> list=new List<dgvInvoicesViewModel>();
            foreach (var item in invoices)
            {
                var employees = _db.tabEmployees.FirstOrDefault(t => t.nvcCoID == item.nvcBuyerCoID);
                list.Add(new dgvInvoicesViewModel()
                {
                    intID=item.intID,
                    Brand = item.tabVendors.nvcBrand,
                    BuyerName = employees.nvcFirstname+" "+employees.nvcLastname,
                    Date = item.datDate.ToString("D"),
                    InvoiceNumbrOfOwner = item.intInvoiceNumbrOfOwner,
                    InvoiceNumberOfVendor=item.intInvoiceNumberOfVendor
                });
            }

            return list;
        }
    }
}
