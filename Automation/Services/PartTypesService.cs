using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class PartTypesService : Generic<tabPartTypes>, IPartTypes

    {
        private dbAfrzEntities _db=new dbAfrzEntities();
        public PartTypesService(DbContext db) : base(db)
        {
        }

        public List<dgvListStoresViewModel> ListParts(string filter = "")
        {
            if (filter == "")
            {

                return _db.tabPartTypes.Select(t=>new dgvListStoresViewModel()
                {
                    intID = t.intID,
                    intNumber =t.intStore + "" + t.intCategory + "" + t.intName + "" + t.intBranch + "" + t.intSubBranch,
                    namePart = t.tabPartName.nvcName + " " + t.tabPartBranch.nvcName + " " + t.tabPartSubBranch.nvcName
                }).ToList();
            }

            
            var parts = _db.tabPartTypes.ToList();
            List<dgvListStoresViewModel> list = new List<dgvListStoresViewModel>();
            foreach (var item in parts)
            {

                list.Add(new dgvListStoresViewModel()
                {
                    intID = item.intID,
                    intNumber = item.intStore + "" + item.intCategory + "" + item.intName + "" + item.intBranch + "" + item.intSubBranch,
                    namePart = item.tabPartName.nvcName + " " + item.tabPartBranch.nvcName + " " + item.tabPartSubBranch.nvcName
                });
            }

            return list.Where(t=>t.namePart.Contains(filter)).ToList();
        }

        public List<tabPartTypes> FilterPartTypes(object store, object category, object name, object branch, object subBranch)
        {
            var list = _db.tabPartTypes.ToList().Where(t =>
                t.tabStores.nvcName.Equals(store) || t.tabCategories.Equals(category) || t.tabPartName.Equals(name) ||
                t.tabPartBranch.Equals(branch) || t.tabPartSubBranch.Equals(subBranch));
            return list.ToList();
        }

        public List<PartsViewModel> FillDgvParts(List<tabPartTypes> list)
        {
            List<PartsViewModel> models=new List<PartsViewModel>();
            foreach (var item in list)
            {
                models.Add(new PartsViewModel()
                {
                    intID = item.intID,
                    storeTitle = item.tabStores.nvcName,
                    categoryTitle = item.tabCategories.nvcName,
                    nameTitle = item.tabPartName.nvcName,
                    branchTitle = item.tabPartBranch.nvcName,
                    subBranchTitle = item.tabPartSubBranch.nvcName,
                    measurementUnitTitle = item.tabMeasurementUnits.nvcName,
                    floOrderPoint = item.floOrderPoint,
                    floSupply = item.floSupply,
                });
            }

            return models;
        }
    }
}
