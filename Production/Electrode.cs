using Baran.Ferroalloy.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Production.Furnace
{
    public class Electrode
    {
        public int intDiameter;

        public Hoist hoiHoist;
        public Slip slpSlip;

        public short shoCurrent;
        public short shoVoltage;
        public short shoCurrentSetpoint;

        public Electrode()
        {

        }
    }
}
