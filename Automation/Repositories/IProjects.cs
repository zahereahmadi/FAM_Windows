using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public interface IProjects:IGeneric<tabProjects>
    {
        IEnumerable<tabProjects> FilterProjects(string name, string number, object category, string tips);
        List<DgvProjectsViewModel> FillDgvProjects(List<tabProjects> list);
    }
}
