using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Production;
using Baran.Ferroalloy.Production.Furnace;
using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baran.Ferroalloy.Management.Production
{
    public partial class frmFurnaceControl : Form
    {
        public struct str500ms
        {
            public short shoEl1Current;
            public short shoEl2Current;
            public short shoEl3Current;
            public short shoEl1HoistPostion;
            public short shoEl2HoistPostion;
            public short shoEl3HoistPostion;
        }
        public struct str1s
        {
            public bool bolFurnaceIsOn;
            public short shoFurnaceActivePower;
            public short shoFurnaceReActivePower;
            public double shoFurnacePfWithoutCorrection;
            public byte bytFurnaceConnection;
            public byte bytCapacitorBankCapacity;

            public bool bolShellRotationIsRunning;
            public bool bolShellRotationIsRunningRight;
            public bool bolShellRotationIsRunningLeft;
            
            public short shoTr1TapPosition;
            public short shoTr2TapPosition;
            public short shoTr3TapPosition;

            public bool bolEl1SlipRunning;
            public bool bolEl2SlipRunning;
            public bool bolEl3SlipRunning;
        }
        public struct str5s
        {
            public short shoTr1OilTemprature;
            public short shoTr2OilTemprature;
            public short shoTr3OilTemprature;
            public short shoTr1WindingTemprature;
            public short shoTr2WindingTemprature;
            public short shoTr3WindingTemprature;
        }

        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;

        public Plc plcMain = new Plc(CpuType.S71500, "127.0.0.1", 0, 2);

        public str500ms s500msPlc;
        public str1s s1sPlc;
        public str5s s5sPlc;

        private FurnacePower fpPower;
        private Electrode elElectrode1;
        private Electrode elElectrode2;
        private Electrode elElectrode3;
        private Shell shlShell;
        private Transformator trTransformator1;
        private Transformator trTransformator2;
        private Transformator trTransformator3;
        private Hoist hoiElectrode1;
        private Hoist hoiElectrode2;
        private Hoist hoiElectrode3;
        private Slip slpElectrode1;
        private Slip slpElectrode2;
        private Slip slpElectrode3;

        public frmFurnaceControl()
        {
            InitializeComponent();
        }

        private void frmFurnaceControl_Load(object sender, EventArgs e)
        {
            #region Open Plc
            try
            {
                this.plcMain.Open();
            }
            catch (PlcException pe)
            {
                AnalizePlcErrorCode(pe.ErrorCode);
            }
            #endregion Open Plc

            this.s500msPlc = new str500ms();
            this.s1sPlc = new str1s();
            this.s5sPlc = new str5s();

            this.fpPower = new FurnacePower();
            this.elElectrode1 = new Electrode();
            this.elElectrode2 = new Electrode();
            this.elElectrode3 = new Electrode();
            this.shlShell = new Shell();
            this.trTransformator1 = new Transformator();
            this.trTransformator2 = new Transformator();
            this.trTransformator3 = new Transformator();
            this.hoiElectrode1 = new Hoist();
            this.hoiElectrode2 = new Hoist();
            this.hoiElectrode3 = new Hoist();
            this.slpElectrode1 = new Slip();
            this.slpElectrode2 = new Slip();
            this.slpElectrode3 = new Slip();

        }

        private void frmFurnaceControl_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                this.plcMain.Close();
            }
            catch (PlcException pe)
            {
                AnalizePlcErrorCode(pe.ErrorCode);
            }
        }

        private void AnalizePlcErrorCode(ErrorCode ecErrorCodeArg)
        {
            switch (ecErrorCodeArg)
            {
                case ErrorCode.ConnectionError:
                    this.labStatus.Text = "Connection to PLC Is Lost. Please Check Cable, Network Swich and Plc";
                    break;
                case ErrorCode.IPAddressNotAvailable:
                    this.labStatus.Text = "PLC Isnt Access. Please Check Plc";
                    break;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            //y -= 1;
            //Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //Pen selPen = new Pen(Color.Black,2);
           
            ////g.Dispose();

            //// Create solid brush.
            //SolidBrush blueBrush = new SolidBrush(Color.Gray);

            //// Create rectangle.
            //Rectangle rect = new Rectangle(x, y, 400, 100);

            //// Fill rectangle to screen.
            //e.Graphics.FillRectangle(blueBrush, rect);
            //g.DrawRectangle(selPen, rect);
            //// 
            //g.Dispose();
        }

        private void s500msUpdateObjects()
        {
            this.elElectrode1.shoCurrent = this.s500msPlc.shoEl1Current;
            this.elElectrode2.shoCurrent = this.s500msPlc.shoEl2Current;
            this.elElectrode3.shoCurrent = this.s500msPlc.shoEl3Current;
            this.hoiElectrode1.shoPostion = this.s500msPlc.shoEl1HoistPostion;
            this.hoiElectrode2.shoPostion = this.s500msPlc.shoEl2HoistPostion;
            this.hoiElectrode3.shoPostion = this.s500msPlc.shoEl3HoistPostion;

            this.labEl1Current.Text = this.elElectrode1.shoCurrent.ToString();
            this.labEl1Current.Text = this.elElectrode2.shoCurrent.ToString();
            this.labEl1Current.Text = this.elElectrode3.shoCurrent.ToString();
        }

        private void s1sUpdateObjects()
        {

        }

        private void s5sUpdateObjects()
        {

        }

        private void tmr500ms_Tick(object sender, EventArgs e)
        {
            this.s500msPlc = (str500ms) this.plcMain.ReadStruct<str500ms>(1);
            s500msUpdateObjects();
        }

        private void tmr1s_Tick(object sender, EventArgs e)
        {

        }

        private void tmr5s_Tick(object sender, EventArgs e)
        {

        }

        private void tmr1min_Tick(object sender, EventArgs e)
        {

        }
    }
}
