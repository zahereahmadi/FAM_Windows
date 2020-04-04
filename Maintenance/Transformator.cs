using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Maintenance
{
    public class Transformator
    {
        public enum PhaseCountType
        {
            PhaseCount1 = 1,
            PhaseCount3 = 2
        }
        public enum CoolingType
        {
            Air = 1,
            Water = 2
        }

        public PhaseCountType pctType;
        public int intOutputBushingCount;
        public int intTapCount;
        public CoolingType ctCooling;
        public int intPrimaryCurrent;
        public int intPrimaryVoltage;
        public int intSecondaryCurrent;
        public int intSecondaryVoltage;
        public short shoTapPosition;
        public short shoOilTemprature;
        public int intOilTempratureSwitchHigh;
        public int intOilTempratureSwitchHighHigh;
        public short shoWindingTemprature;
        public bool bolOilLevelLow;
        public bool bolOilLevelHigh;
        public ElectricalMotor emMotorDrive;
        public bool bolTrBuchholzRelayHigh;
        public bool bolTrBuchholzRelayHighHigh;
        public bool bolTcBuchholzRelay;
        public bool bolPresureSwitch;
        public bool bolOilFlowSwitch;
        public bool bolWaterFlowSwitch;
        public bool bolMotorDriveRunning;
    }
}
