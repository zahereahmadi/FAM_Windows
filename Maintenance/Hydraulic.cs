using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Maintenance
{
    public class HydraulicPack
    {
        public int intPumpsCount;
        public ElectricalMotor[] emPumps;
        public int intPackPressure;
        public bool bolEnergizedMainElectricalValve;
        public int intPackTemprature;
        public ElectricalMotor emPackOilPump;
        public bool bolPackInletOilFilterDirty;
        public bool bolPackOutletOilFilterDirty;
        public bool bolPackOilLevelLow;
        public bool bolPackOilLevelHigh;
        public bool bolHydraulicLeakage;

        public HydraulicPack()
        {

        }
    }
}
