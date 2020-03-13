using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class EquipSamplesService : Generic<tabEquipSamples>, IEquipSamples
    {
        private dbAfrzEntities db = new dbAfrzEntities();
        public EquipSamplesService(DbContext db) : base(db)
        {
        }

        public List<tabEquipSamples> FilterEquips(string company, string location, string zone, string subZone, string category, string equipName)
        {
            return db.tabEquipSamples.Where(t =>
                t.tabCompanies.nvcName.Equals(company) || t.tabLocationes.Equals(location) ||
                t.tabZones.nvcName.Equals(zone) || t.tabSubZones.nvcName.Equals(subZone) ||
                t.tabCategories.nvcName.Equals(category) || t.tabEquipName.nvcName.Equals(equipName)).ToList();
        }
    }
}
