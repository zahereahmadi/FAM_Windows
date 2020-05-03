using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation.Models;
using Baran.Ferroalloy.Automation.ViewModels;

namespace Baran.Ferroalloy.Automation
{
    public class MaintenanceService : Generic<tabMaintenances>, IMaintenance
    {
        private dbAfrzEntities db = new dbAfrzEntities();
        public MaintenanceService(DbContext db) : base(db)
        {

        }

        //public List<dgvMaintenanceViewModel> dgvMaintenanceList(string filter = "")
        //{
        //    var leaderWorker = "";
        //    var workers = "";
        //    var maintenances = _db.tabMaintenances.ToList();
        //    foreach (var item in maintenances)
        //    {
        //        var leader = _db.tabEmployees.FirstOrDefault(t => t.nvcCoID == item.nvcCoIdLeader);
        //        leaderWorker = leader.nvcFirstname + " " + leader.nvcLastname;
        //        var coIds = item.nvcCoIdsWorkGroup.Split('-');
        //        var coId = "";
        //        for (int i = 0; i < coIds.Length; i++)
        //        {
        //            coId = coIds[i];
        //            var coIdEmployee = _db.tabEmployees.FirstOrDefault(t => t.nvcCoID == coId);
        //            workers += coIdEmployee.nvcFirstname + " " + coIdEmployee.nvcLastname + "-";
        //        }

        //        workers = workers.Remove(workers.Length - 1);

        //    }
        //    if (filter == "")
        //    {
        //        return _db.tabMaintenances.Select(t => new dgvMaintenanceViewModel()
        //        {
        //            intID = t.intID,
        //            datWorkGroup = t.datWorkGroup.Date,
        //            leaderWorker = leaderWorker,
        //            nameDapartment = t.tabDepartments.nvcName,
        //            nameShift = t.tabShifts.nvcName,
        //            nameSubDepartment = t.tabSubDepartments.nvcName,
        //            workers = workers,
        //        }).ToList();
        //    }

        //}

        public List<tabMaintenances> FilterMaintenances(object subDepartment, object shift, DateTime from, DateTime to)
        {
            var maintenances = db.tabMaintenances.ToList().Where(t =>
                t.tabSubDepartments.nvcName.Equals(subDepartment) || t.tabShifts.nvcName.Equals(shift) ||
                (t.datWorkGroup.Date >= from && t.datWorkGroup.Date <= to));
            return maintenances.ToList();
        }

        public List<dgvMaintenanceViewModel> FillDgvMaintenance(List<tabMaintenances> list)
        {
            List<dgvMaintenanceViewModel> models = new List<dgvMaintenanceViewModel>();
            var leaderWorker = "";
            foreach (var item in list)
            {
                var leader = db.tabEmployees.FirstOrDefault(t => t.nvcCoID == item.nvcCoIdLeader);
                leaderWorker = leader.nvcFirstname + " " + leader.nvcLastname;
                var coIds = item.nvcCoIdsWorkGroup.Split('-');
                var workersName = MyExtentions.GetNameByCoId(coIds);
                models.Add(new dgvMaintenanceViewModel()
                {
                    intID = item.intID,
                    datWorkGroup = Convert.ToString(item.datWorkGroup.Date),
                    nameShift = item.tabShifts.nvcName,
                    nameSubDepartment = item.tabSubDepartments.nvcName,
                    workers = workersName,
                    leaderWorker = leaderWorker
                });
            }

            return models;
        }
    }
}
