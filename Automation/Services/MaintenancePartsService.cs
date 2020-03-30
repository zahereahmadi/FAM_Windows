using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class MaintenancePartsService : Generic<tabMaintenanceParts>, IMaintenanceParts
    {
        private dbAfrzEntities _db;
        public MaintenancePartsService(DbContext db) : base(db)
        {
            _db = (dbAfrzEntities)db;
        }

        public List<tabMaintenanceParts> ListMaintenanceParts(string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.MaintenanceParts.GetAll().ToList();
                }


                return db.MaintenanceParts.GetAll().Where(t => t.nvcPart.Contains(filter)).ToList();
            }
        }

        public List<dgvListMaintenancePartsViewModel> dgvListMaintenanceParts(int maiantenanceItemId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = "";
                var branch = "";
                var subBranch = "";
                var maintenancePartses = db.MaintenanceParts.Get(t => t.intMaintenanceItem == maiantenanceItemId).ToList();
                List<dgvListMaintenancePartsViewModel> list = new List<dgvListMaintenancePartsViewModel>();
                foreach (var item in maintenancePartses)
                {
                    var part = item.nvcPart.Split('-');
                    var nameId = Convert.ToInt32(part[2]);
                    var branchId = Convert.ToInt32(part[3]);
                    var subBranchId = Convert.ToInt32(part[4]);
                    name = db.PartName.GetEntity(t => t.intNumber == nameId).nvcName;
                    branch = db.PartBranch.GetEntity(t => t.intNumber == branchId).nvcName;
                    subBranch = db.PartSubBranch.GetEntity(t => t.intNumber == subBranchId).nvcName;
                    list.Add(new dgvListMaintenancePartsViewModel()
                    {
                        intID = item.intID,
                        maintenanceType = item.intMaintenaceType.ToString(),
                        count = item.intCount,
                        namePart = name + " " + branch + " " + subBranch
                    });
                }
                if (filter == "")
                {
                    return list;
                }

                List<dgvListMaintenancePartsViewModel> list1 = new List<dgvListMaintenancePartsViewModel>();
                foreach (var item in maintenancePartses)
                {

                    list1.Add(new dgvListMaintenancePartsViewModel()
                    {
                        intID = item.intID,
                        maintenanceType = item.intMaintenaceType.ToString(),
                        count = item.intCount,
                        namePart = name + " " + branch + " " + subBranch
                    });
                }

                return list.Where(t => t.namePart.Contains(filter) || t.count.Equals(filter)).ToList();
            }
        }
    }
}
