using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation.Models;
using Baran.Ferroalloy.Automation.ViewModels;

namespace Baran.Ferroalloy.Automation
{
    public interface IMaintenance:IGeneric<tabMaintenances>
    {
        List<tabMaintenances> FilterMaintenances(object subDepartment, object shift, DateTime from, DateTime to);
        List<dgvMaintenanceViewModel> FillDgvMaintenance(List<tabMaintenances> list);
    }
}
