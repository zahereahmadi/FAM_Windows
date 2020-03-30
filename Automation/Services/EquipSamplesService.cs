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

        
        public List<tabEquipSamples> FilterEquipSamples(object company, object location, object zone, object subZone, object category,
            object equipName)
        {
            var equipSamples = db.tabEquipSamples.ToList().Where(t =>
                t.tabCompanies.nvcName.Equals(company) || t.tabLocationes.Equals(location) ||
                t.tabZones.Equals(zone) || t.tabSubZones.Equals(subZone) || t.tabCategories.Equals(category) ||
                t.tabEquipName.Equals(equipName));
            return equipSamples.ToList();
        }

        public List<EquipsViewModel> FillDgvEquips(List<tabEquipSamples> list)
        {
            List<EquipsViewModel> models = new List<EquipsViewModel>();
            string order = "";
            foreach (var item in list)
            {
                order = item.intOrder.ToString();
                if (order.Length == 1)
                {
                    order = 0 + order;
                }
                else
                {
                    order = order;
                }
                models.Add(new EquipsViewModel()
                {
                    intID = item.intID,
                    companyTitle = item.tabCompanies.nvcName,
                    locationTitle = item.tabLocationes.nvcName,
                    zoneTitle = item.tabZones.nvcName,
                    subZoneTitle = item.tabSubZones.nvcName,
                    categoryTitle = item.tabCategories.nvcName,
                    equipNameTitle = item.tabEquipName.nvcName,
                    order = order
                });
            }

            return models;
        }
    }
}
