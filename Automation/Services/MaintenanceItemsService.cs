using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class MaintenanceItemsService : Generic<tabMaintenanceItems>, IMaintenanceItem
    {
        private dbAfrzEntities _db;

        public MaintenanceItemsService(DbContext db) : base(db)
        {
            _db = (dbAfrzEntities) db;
        }

        public List<dgvMaintenanceItemsViewModel> ListMaintenanceItems(int maintenanceId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var equipName = "";
                var equipNameId = 0;
                var maintenanceItems = db.MaintenanceItem.GetByWhere(t => t.intMaintenance == maintenanceId).ToList();
                List<dgvMaintenanceItemsViewModel> list = new List<dgvMaintenanceItemsViewModel>();
                foreach (var item in maintenanceItems)
                {
                    var equipCode = item.nvcEquip.ToCharArray();
                    if (equipCode[10] == '0')
                    {
                        equipNameId = Convert.ToInt32(equipCode[11].ToString());

                    }
                    else
                    {
                        equipNameId = Convert.ToInt32(equipCode[10] + "" + equipCode[11]);
                    }

                    equipName = db.EquipName.GetEntity(t => t.intNumber == equipNameId).nvcName;
                    list.Add(new dgvMaintenanceItemsViewModel()
                    {
                        intID = item.intID,
                        nvcEquip = equipName
                    });
                }
                if (filter == "")
                {
                    return list;
                }

                return list.Where(t => t.nvcEquip.Contains(filter)).ToList();
            }
        }
    }
}
