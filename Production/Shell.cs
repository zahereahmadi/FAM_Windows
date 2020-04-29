using Baran.Ferroalloy.Maintenance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Production
{
    public class Shell
    {
        public ElectricalMotor emRotation;

        public int intFloorTemperatureTransmitterCount;
        public int[] intFloorTemperatureTransmitter;
        public int intChargeTemperatureTransmitter;

        public TimeSpan tsRotationClockWise;
        public TimeSpan tsRotationStop;
        public TimeSpan tsRotationAntiClockWise;

        public ElectricalMotor emFloorCooling;
    }
}
