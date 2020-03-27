using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public static class MyExtentions
    {

        public static GetPartTypeViewModel GetPartType(this char[] arrayChars)
        {
            GetPartTypeViewModel model = new GetPartTypeViewModel();
            if (arrayChars[0] == '0' && arrayChars[2] == '0' && arrayChars[4] == '0' && arrayChars[6] == '0' && arrayChars[8] == '0')
            {
                model.StoreId = Convert.ToInt32(arrayChars[1].ToString());
                model.CategoryId = Convert.ToInt32(arrayChars[3].ToString());
                model.PartNameId = Convert.ToInt32(arrayChars[5].ToString());
                model.PartBranchId = Convert.ToInt32(arrayChars[7].ToString());
                model.PartSubBranchId = Convert.ToInt32(arrayChars[9].ToString());
            }
            else
            {
                model.StoreId = Convert.ToInt32(arrayChars[0] + "" + arrayChars[1]);
                model.CategoryId = Convert.ToInt32(arrayChars[2] + "" + arrayChars[3]);
                model.PartNameId = Convert.ToInt32(arrayChars[4] + "" + arrayChars[5]);
                model.PartBranchId = Convert.ToInt32(arrayChars[6] + "" + arrayChars[7]);
                model.PartSubBranchId = Convert.ToInt32(arrayChars[8] + "" + arrayChars[9]);
            }

            return model;
        }

        //------------------------------------------------------------------------

        public static string GetNameByCoId(this string[] coIds)
        {
            using (dbAfrzEntities db = new dbAfrzEntities())
            {
                var coId = "";
                var workersName = "";
                for (int i = 0; i < coIds.Length; i++)
                {
                    coId = coIds[i];
                    var coIdEmployee = db.tabEmployees.FirstOrDefault(t => t.nvcCoID == coId);
                    workersName += coIdEmployee.nvcFirstname + " " + coIdEmployee.nvcLastname + "-";
                }

                workersName = workersName.Remove(workersName.Length - 1);
                return workersName;
            }

        }

        //---------------------------------------------------------------------------

        public static GetEquipSampleViewModel GetEquipSample(this string company, string location, string zone, string subZone,
            string category, string equipName, string order)
        {
            if (company.Length == 1)
            {
                company = 0 + company;
            }
            else
            {
                company = company;
            }

            if (location.Length == 1)
            {
                location = 0 + location;
            }
            else
            {
                location = location;
            }


            if (zone.Length == 1)
            {
                zone = 0 + zone;
            }
            else
            {
                zone = zone;
            }

            if (subZone.Length == 1)
            {
                subZone = 0 + subZone;
            }
            else
            {
                subZone = subZone;
            }

            if (category.Length == 1)
            {
                category = 0 + category;
            }
            else
            {
                category = category;
            }

            if (equipName.Length == 1)
            {
                equipName = 0 + equipName;
            }
            else
            {
                equipName = equipName;
            }

            if (order.Length == 1)
            {
                order = 0 + order;
            }
            else
            {
                order = order;
            }

            GetEquipSampleViewModel model = new GetEquipSampleViewModel()
            {
                CompanyId = company,
                LocationId = location,
                ZoneId = zone,
                SubZoneId = subZone,
                CategoryId = category,
                EquipNameId = equipName,
                OrderId = order
            };

            return model;
        }

        //---------------------------------------------------------------------------------

        public static GetPartTypeByIdsViewModel GetPartTypeByIds(this string store, string category, string name, string branch,
            string subBranch)
        {
            if (store.Length == 1)
            {
                store = 0 + store;
            }
            else
            {
                store = store;
            }

            if (category.Length == 1)
            {
                category = 0 + category;
            }
            else
            {
                category = category;
            }

            if (name.Length == 1)
            {
                name = 0 + name;
            }
            else
            {
                name = name;
            }

            if (branch.Length == 1)
            {
                branch = 0 + branch;
            }
            else
            {
                branch = branch;
            }

            if (subBranch.Length == 1)
            {
                subBranch = 0 + subBranch;
            }
            else
            {
                subBranch = subBranch;
            }

            GetPartTypeByIdsViewModel model = new GetPartTypeByIdsViewModel()
            {
                Store = store,
                Category = category,
                PartName = name,
                PartBranch = branch,
                PartSubBranch = subBranch
            };
            return model;
        }

        //--------------------------------------------------------------------------------

        public static GetTechnicalDocumentCodeViewModel GetTechnicalDocumentCode(this string company, string location,
            string category, string order)
        {
            if (company.Length == 1)
            {
                company = 0 + company;
            }
            else
            {
                company = company;
            }

            if (location.Length == 1)
            {
                location = 0 + location;
            }
            else
            {
                location = location;
            }

            if (category.Length == 1)
            {
                category = 0 + category;
            }
            else
            {
                category = category;
            }

            switch (order.Length)
            {
                case 1:
                    order = "0" + "0" + "0" + order;
                    break;
                case 2:
                    order = "0" + "0" + order;
                    break;
                case 3:
                    order = "0" + order;
                    break;
                case 4:
                    order = order;
                    break;
            }

            GetTechnicalDocumentCodeViewModel model = new GetTechnicalDocumentCodeViewModel()
            {
                Company = company,
                Location = location,
                Category = category,
                Order = order
            };
            return model;
        }
    }
}
