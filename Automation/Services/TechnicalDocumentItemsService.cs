using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;
using Baran.Ferroalloy.Automation.ViewModels;

namespace Baran.Ferroalloy.Automation
{
    public class TechnicalDocumentItemsService : Generic<tabTechnicalDocumentItems>, ITechnicalDocumentItems
    {
        dbAfrzEntities _db = new dbAfrzEntities();
        public TechnicalDocumentItemsService(DbContext db) : base(db)
        {
        }


        public List<dgvTechnicalDocumentItemsViewModel> ListTechnicalDocumentItems(string technicalDocumentCode, string filter = "")
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var name = "";
                var branch = "";
                var subBranch = "";
                var equipName = "";
                var nameEquipOrPart = "";
                int nameId;
                int branchId;
                int subBranchId;
                var technicalDocument = db.TechnicalDocumentItems.Get(t => t.nvcDocumentCode == technicalDocumentCode).ToList();
                List<dgvTechnicalDocumentItemsViewModel> list = new List<dgvTechnicalDocumentItemsViewModel>();
                foreach (var item in technicalDocument)
                {
                    if (item.nvcPartCode != null)
                    {
                        var part = item.nvcPartCode.ToCharArray();
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
                    }

                    if (item.nvcEquipCode != null)
                    {
                        var equip = item.nvcEquipCode.ToCharArray();
                        var eqipId = 0;
                        if (equip[10] != '0')
                        {
                            eqipId = Convert.ToInt32(equip[10] + "" + equip[11]);
                        }
                        else
                        {
                            eqipId = Convert.ToInt32(equip[11].ToString());
                        }
                        equipName = db.EquipName.GetEntity(t => t.intNumber == eqipId).nvcName;
                    }
                    
                    if (item.nvcEquipCode == null)
                    {
                        nameEquipOrPart = name + " " + branch + " " + subBranch;
                    }
                    else if (item.nvcPartCode == null)
                    {
                        nameEquipOrPart = equipName;
                    }
                    list.Add(new dgvTechnicalDocumentItemsViewModel()
                    {
                        intID = item.intID,
                        name = nameEquipOrPart
                        //equipName = equipName,
                        //partName = name + " " + branch + " " + subBranch
                    });
                }
                if (filter == "")
                {
                    return list;
                }


                return list.Where(t => t.name.Contains(filter)).ToList();
            }
        }
    }
}
