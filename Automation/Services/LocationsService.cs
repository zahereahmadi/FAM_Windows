using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class LocationsService:Generic<tabLocationes>,ILocations
    {
        public LocationsService(DbContext db) : base(db)
        {
        }
    }
}
