using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class PartSubBranchService : Generic<tabPartSubBranch>, IPartSubBranch
    {
        public PartSubBranchService(DbContext db) : base(db)
        {
        }

        public List<tabPartSubBranch> ListSubBranches(int branchId, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (filter == "")
                {
                    return db.PartSubBranch.GetAll().Where(t => t.intBranch == branchId).ToList();
                }

                return db.PartSubBranch.GetAll().Where(t => t.nvcName.Contains(filter) && t.intBranch == branchId).ToList();
            }
        }
    }
}
