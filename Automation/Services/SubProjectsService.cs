using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class SubProjectsService:Generic<tabSubProjects>,ISubProjects
    {
        dbAfrzEntities db=new dbAfrzEntities();
        public SubProjectsService(DbContext db) : base(db)
        {
        }

        public IEnumerable<DgvSubProjectsViewModel> FillDgvSubProjects(int projectId)
        {
            var projects = db.tabProjects.FirstOrDefault(t => t.intID == projectId);
            var subProjects = db.tabSubProjects.Where(t => t.intProject == projects.intNumber).ToList();
            List<DgvSubProjectsViewModel> list=new List<DgvSubProjectsViewModel>();
            foreach (var item in subProjects)
            {
                list.Add(new DgvSubProjectsViewModel()
                {
                    intID=item.intID,
                    name = item.nvcName,
                    categoryName=item.tabCategories.nvcName,
                    tip = item.nvcTip,
                    datStart = item.datStart.ToString("D"),
                    duration = item.intDuration,
                    progress = item.intProgress,
                    //projectNumber = item.intProgress
                });
            }

            return list;
        }
    }
}
