using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Maintenance
{
    public class FurnacePower
    {
        public enum ConnectionType
        {
            Stat = 1,
            Dlta = 2,
            No_Connection = 3
        }

        public bool bolFurnaceIsOn;
        public short shoActivePower;
        public short shoNoCorrectionReActivePower;
        public double dblNoCorrectionPowerFactor;
        public ConnectionType ctConnection;
        public int intCapacityCapacitorBank;
        public int intConnectedCapacitorBank;
        
        public FurnacePower()
        {

        }
    }
}
