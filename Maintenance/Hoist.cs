using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Maintenance
{
    public class Hoist
    {
        public short shoCylinderLength;
        public short shoPostion;

        public int intRaisePressure;
        public bool bolIsRaising;
        public bool bolCmdRaise;

        public bool bolIsLowering;
        public int intLowerPressure;
        public bool bolCmdLower;

        public bool IsRemote;
        public bool IsAuto;
        
        public Hoist()
        {

        }
    }
}
