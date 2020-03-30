using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class CompaniesService:Generic<tabCompanies>,ICompanies
    {
        public CompaniesService(DbContext db) : base(db)
        {
        }
    }
}
