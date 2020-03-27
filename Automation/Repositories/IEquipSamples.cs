using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public interface IEquipSamples : IGeneric<tabEquipSamples>
    {
        List<tabEquipSamples> FilterEquips(string company, string location, string zone, string subZone,
            string category, string equipName);

        List<tabEquipSamples> FilterEquipSamples(object company, object location, object zone, object subZone,
            object category, object equipName);

        List<EquipsViewModel> FillDgvEquips(List<tabEquipSamples> list);

    }
}
