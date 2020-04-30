using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;
using Baran.Ferroalloy.Automation.ViewModels;

namespace Baran.Ferroalloy.Automation
{
    public interface IInvoices: IGeneric<tabInvoices>
    {
        IEnumerable<tabInvoices> FilterInvoices(string brand, int invoiceNumbrOfOwner, int invoiceNumberOfVendor,
            object buyerName, DateTime from, DateTime to);
        IEnumerable<dgvInvoicesViewModel> FillDgvInvoices(IEnumerable<tabInvoices> invoices);
    }
}
