using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;


namespace Baran.Ferroalloy.Automation
{
    public class PartBranchService : Generic<tabPartBranch>,IPartBranch
    {
        public PartBranchService(DbContext db) : base(db)
        {
        }

        public List<tabPartBranch> ListBranches(int nameId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.PartBranch.GetAll().Where(t => t.intName == nameId).ToList();
                }

                return db.PartBranch.GetAll().Where(t => t.nvcName.Contains(filter) && t.intName == nameId).ToList();
            }
        }
    }
}
