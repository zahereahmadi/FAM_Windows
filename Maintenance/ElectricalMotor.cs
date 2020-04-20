using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Maintenance
{
    public class ElectricalMotor
    {
        public enum ControlCircuitType
        {
            OneDirection = 1,
            TwoDirection = 2
        }
        public enum SpeedControlEquip
        {
            No_Control = 1,
            Star_Delta = 2,
            DriveStarter = 3,
            SoftStarter = 4
        }
        public ControlCircuitType cctControlCircuit;
        public bool bolIsRunning;
        public bool bolIsRunningRight;
        public bool bolIsRunningLeft;
        public bool bolActivatedOverCurrent;
        public bool bolActivatedEmegency;
        public bool bolIsRemoted;
        public bool bolIsAuto;
        public bool bolCmdStart;
        public bool bolCmdStartRight;
        public bool bolCmdStartLeft;
        public bool bolCmdStop;
        public int intSpeed;
    }
}
