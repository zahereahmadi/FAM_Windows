using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class PartSamplesService : Generic<tabPartSamples>, IPartSamples
    {
        dbAfrzEntities _db = new dbAfrzEntities();
        public PartSamplesService(DbContext db) : base(db)
        {
        }

        public List<dgvPartSamplesViewModel> ListPartSamples(string equipCode, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = "";
                var branch = "";
                var subBranch = "";
                var order = "";
                int nameId = 0;
                int branchId = 0;
                int subBranchId = 0;
                var partSamples = db.PartSamples.Get(t => t.nvcEquipSampleCode == equipCode).ToList();
                List<dgvPartSamplesViewModel> list = new List<dgvPartSamplesViewModel>();
                foreach (var item in partSamples)
                {
                    switch (item.intOrder.ToString().Length)
                    {
                        case 1:
                            order = "0" + "0" + "0" + item.intOrder;
                            break;
                        case 2:
                            order = "0" + "0" + item.intOrder;
                            break;
                        case 3:
                            order = "0" + item.intOrder;
                            break;
                        case 4:
                            order = item.intOrder.ToString();
                            break;
                    }
                    var part = item.nvcPartTypeCode.ToCharArray();

                    if (part[4] == '0' && part[6] == '0' && part[8] == '0')
                    {
                        nameId = Convert.ToInt32(part[5].ToString());
                        branchId = Convert.ToInt32(part[7].ToString());
                        subBranchId = Convert.ToInt32(part[9].ToString());
                    }
                    else
                    {
                        nameId = Convert.ToInt32(part[4] + "" + part[5]);
                        branchId = Convert.ToInt32(part[6] + "" + part[7]);
                        subBranchId = Convert.ToInt32(part[8] + "" + part[9]);
                    }
                    name = db.PartName.GetEntity(t => t.intNumber == nameId).nvcName;
                    branch = db.PartBranch.GetEntity(t => t.intNumber == branchId).nvcName;
                    subBranch = db.PartSubBranch.GetEntity(t => t.intNumber == subBranchId).nvcName;
                    list.Add(new dgvPartSamplesViewModel()
                    {
                        intID = item.intID,
                        partName = name + " " + branch + " " + subBranch,
                        order = order
                    });
                }

                if (filter == "")
                {
                    return list;
                }

                List<dgvPartSamplesViewModel> list1 = new List<dgvPartSamplesViewModel>();
                foreach (var item in partSamples)
                {
                    list1.Add(new dgvPartSamplesViewModel()
                    {
                        intID = item.intID,
                        partName = name + " " + branch + " " + subBranch,
                        order = order
                    });
                }
                return list.Where(t => t.partName.Contains(filter)).ToList();
            }
        }
    }
}
