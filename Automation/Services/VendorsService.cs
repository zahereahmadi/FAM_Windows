using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class VendorsService:Generic<tabVendors>,IVendors
    {
        private dbAfrzEntities _db=new dbAfrzEntities(); 
        public VendorsService(DbContext db) : base(db)
        {
        }

        public IEnumerable<tabVendors> FilterVendors(object category, string brand, string fName, string lName, string tell)
        {
            if (brand != "" || fName!="" || lName!="" || tell!="")
            {
                return _db.tabVendors.ToList().Where(t =>
                    t.tabCategories.nvcName.Equals(category) || t.nvcBrand==brand || t.nvcFirstName==fName ||
                    t.nvcLastName==lName || t.nvcTell==tell).ToList();
            }
            return _db.tabVendors.ToList().Where(t =>
                t.tabCategories.nvcName.Equals(category)).ToList();
            
        }

        public IEnumerable<dgvVendorsViewModel> FillDgvVendors(IEnumerable<tabVendors> list)
        {
            List<dgvVendorsViewModel> models=new List<dgvVendorsViewModel>();
            foreach (var item in list)
            {
                models.Add(new dgvVendorsViewModel()
                {
                    intID = item.intID,
                    intNumber=item.intNumber,
                    Address = item.nvcAddress,
                    Brand = item.nvcBrand,
                    CategoryTitle = item.tabCategories.nvcName,
                    FirstName = item.nvcFirstName,
                    LastName = item.nvcLastName,
                    Tell=item.nvcTell
                });
            }

            return models;
        }
    }
}
