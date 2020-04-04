using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class ProjectsService:Generic<tabProjects>,IProjects
    {
        private dbAfrzEntities db=new dbAfrzEntities();
        public ProjectsService(DbContext db) : base(db)
        {
        }

        public IEnumerable<tabProjects> FilterProjects(string name, string number, object category, string tips)
        {
            return db.tabProjects.ToList().Where(t =>
                t.nvcName.Equals(name) || t.intNumber.ToString().Equals(number) ||
                t.tabCategories.nvcName.Equals(category) || t.nvcTip.Equals(tips));
        }

        public List<DgvProjectsViewModel> FillDgvProjects(List<tabProjects> list)
        {
            List<DgvProjectsViewModel> models=new List<DgvProjectsViewModel>();
            foreach (var item in list)
            {
                models.Add(new DgvProjectsViewModel()
                {
                    intID = item.intID,
                    name=item.nvcName,
                    number = item.intNumber.ToString(),
                    categoryName = item.tabCategories.nvcName,
                    tip=item.nvcTip
                });
            }

            return models;
        }
    }
}
