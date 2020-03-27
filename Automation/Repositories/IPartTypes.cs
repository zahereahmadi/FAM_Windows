using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public interface IPartTypes : IGeneric<tabPartTypes>
    {
        List<dgvListStoresViewModel> ListParts(string filter="");
        List<tabPartTypes> FilterPartTypes(object store, object category, object name, object branch, object subBranch);
        List<PartsViewModel> FillDgvParts(List<tabPartTypes> list);
    }
}
