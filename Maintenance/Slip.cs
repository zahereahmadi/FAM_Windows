using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Maintenance
{
    public class Slip
    {
        public bool bolRunning;
        public int intMiddleCylinderLength;
        public int intMiddleCylinerPressure;
        public bool bolCmdMiddleCylinderRaise;
        public bool bolCmdMiddleCylinderLower;
        public bool bolRaisedMiddleCylinder;
        public bool bolLoweredMiddleCylinder;

        public int intLowerRingPressure;
        public bool bolCmdLowerRingDeflate;
        public bool bolDeflatedLowerRing;

        public int intUpperRingPressure;
        public bool bolCmdUpperRingDeflate;
        public bool bolDeflatedUpperRing;

        public bool bolIsRemoted;
        public bool bolIsAuto;
        public bool bolCmdStart;
        
        public int intSlipAmount;

        public Slip()
        {

        }
    }
}
