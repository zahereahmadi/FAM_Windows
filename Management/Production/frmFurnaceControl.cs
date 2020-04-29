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
            #region Set Icons
            this.pbPowerMain.ImageLocation = Application.StartupPath + @"\Pics\A1_a.png";
            this.pbPowerSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbPowerManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbPowerReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbPowerAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbPowerAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbPowerRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbConnectionMain.ImageLocation = Application.StartupPath + @"\Pics\A10_a.png";
            this.pbConnectionSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbConnectionManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbConnectionReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbConnectionAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbConnectionAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbConnectionRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbCbMain.ImageLocation = Application.StartupPath + @"\Pics\A11_a.png";
            this.pbCbSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbCbManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbCbReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbCbAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbCbAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbCbRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbTransformatorsDetails.ImageLocation = Application.StartupPath + @"\Pics\A13_a.png";
            this.pbTransformatorsSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbTransformatorsManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbTransformatorsReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbTransformatorsAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbTransformatorsAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbTransformatorsRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbHoistDetails.ImageLocation = Application.StartupPath + @"\Pics\A18_a.png";
            this.pbHoistSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbHoistManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbHoistReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbHoistAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbHoistAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbHoistRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbSlipDetails.ImageLocation = Application.StartupPath + @"\Pics\A19_a.png";
            this.pbSlipSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbSlipManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbSlipReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbSlipAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbSlipAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbSlipRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbHydraulicDetails.ImageLocation = Application.StartupPath + @"\Pics\A21_a.png";
            this.pbHydraulicSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbHydraulicManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbHydraulicReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbHydraulicAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbHydraulicAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbHydraulicRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbShellDetails.ImageLocation = Application.StartupPath + @"\Pics\A15_a.png";
            this.pbShellSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbShellManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbShellReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbShellAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbShellAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbShellRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbStockingDetails.ImageLocation = Application.StartupPath + @"\Pics\A26_a.png";
            this.pbStockingSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbStockingManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbStockingReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbStockingAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbStockingAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbStockingRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbProductionDetails.ImageLocation = Application.StartupPath + @"\Pics\A27_a.png";
            this.pbProductionSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
            this.pbProductionManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbProductionReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
            this.pbProductionAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
            this.pbProductionAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
            this.pbProductionRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";

            this.pbFurnaceManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
            this.pbFurnaceReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";

            this.pbFurnaceFullScreen.ImageLocation = Application.StartupPath + @"\Pics\A29_a.png";
            this.pbFurnaceMute.ImageLocation = Application.StartupPath + @"\Pics\A30_a.png";
            this.pbFurnaceAlarms.ImageLocation = Application.StartupPath + @"\Pics\A31_a.png";

            #endregion Set Icons

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

        private void pbPowerMain_MouseEnter(object sender, EventArgs e)
        {
            this.pbPowerMain.ImageLocation = Application.StartupPath + @"\Pics\A1_b.png";
        }

        private void pbPowerMain_MouseLeave(object sender, EventArgs e)
        {
            this.pbPowerMain.ImageLocation = Application.StartupPath + @"\Pics\A1_a.png";
        }

        private void pbPowerMain_Click(object sender, EventArgs e)
        {
            frmFurnaceControlPowerDetails frAction = new frmFurnaceControlPowerDetails();
            frAction.Show();
        }

        private void pbPowerSettings_Click(object sender, EventArgs e)
        {
            frmFurnaceControlPowerSettings frmAction = new frmFurnaceControlPowerSettings();
            frmAction.Show();
        }

        private void pbPowerManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlPowerManual frmAction = new frmFurnaceControlPowerManual();
            frmAction.Show();
        }

        private void pbPowerReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlPowerReports frmAction = new frmFurnaceControlPowerReports();
            frmAction.Show();
        }

        private void pbPowerAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlPowerAlarms frmAction = new frmFurnaceControlPowerAlarms();
            frmAction.Show();
        }

        private void pbConnectionSettings_Click(object sender, EventArgs e)
        {
            frmFurnaceControlConnectionSettings frmAction = new frmFurnaceControlConnectionSettings();
            frmAction.Show();
        }

        private void pbConnectionManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlConnectionManual frmAction = new frmFurnaceControlConnectionManual();
            frmAction.Show();
        }

        private void pbConnectionReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlConnectionReports frmAction = new frmFurnaceControlConnectionReports();
            frmAction.Show();
        }

        private void pbConnectionAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlConnectionAlarms frmAction = new frmFurnaceControlConnectionAlarms();
            frmAction.Show();
        }

        private void pbConnectionMain_Click(object sender, EventArgs e)
        {
            frmFurnaceControlConnectionDetails frmAction = new frmFurnaceControlConnectionDetails();
            frmAction.Show();
        }

        private void pbConnectionMain_MouseEnter(object sender, EventArgs e)
        {
            this.pbConnectionMain.ImageLocation = Application.StartupPath + @"\Pics\A10_b.png";
        }

        private void pbConnectionMain_MouseLeave(object sender, EventArgs e)
        {
            this.pbConnectionMain.ImageLocation = Application.StartupPath + @"\Pics\A10_a.png";
        }

        private void pbCbMain_Click(object sender, EventArgs e)
        {
            frmFurnaceControlCbDetails frmAction = new frmFurnaceControlCbDetails();
            frmAction.Show();
        }

        private void pbCbMain_MouseEnter(object sender, EventArgs e)
        {
            this.pbCbMain.ImageLocation = Application.StartupPath + @"\Pics\A11_b.png";
        }

        private void pbCbMain_MouseLeave(object sender, EventArgs e)
        {
            this.pbCbMain.ImageLocation = Application.StartupPath + @"\Pics\A11_a.png";
        }

        private void pbPowerSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbPowerSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbPowerSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbPowerSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbPowerManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbPowerManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbPowerManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbPowerManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbPowerReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbPowerReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbPowerReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbPowerReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbPowerAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbPowerAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbPowerAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbPowerAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbPowerAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbPowerAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbPowerAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbPowerAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbPowerRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbPowerRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbPowerRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbPowerRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbConnectionSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbConnectionSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbConnectionSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbConnectionSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbConnectionManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbConnectionManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbConnectionManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbConnectionManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbConnectionReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbConnectionReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbConnectionReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbConnectionReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbConnectionAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbConnectionAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbConnectionAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbConnectionAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbConnectionAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbConnectionAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbConnectionAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbConnectionAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbConnectionRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbConnectionRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbConnectionRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbConnectionRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbCbSettings_Click(object sender, EventArgs e)
        {
            frmFurnaceControlCbSettings frmAction = new frmFurnaceControlCbSettings();
            frmAction.Show();
        }

        private void pbCbSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbCbSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbCbSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbCbSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbCbManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlCbManual frmAction = new frmFurnaceControlCbManual();
            frmAction.Show();
        }

        private void pbCbManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbCbManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbCbManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbCbManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbCbReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlCbReports frmAction = new frmFurnaceControlCbReports();
            frmAction.Show();
        }

        private void pbCbReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbCbReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbCbReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbCbReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbCbAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlCbAlarms frmAction = new frmFurnaceControlCbAlarms();
            frmAction.Show();
        }

        private void pbCbAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbCbAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbCbAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbCbAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbCbAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbCbAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbCbAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbCbAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbCbRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbCbRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbCbRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbCbRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbTransformatorsDetails_Click(object sender, EventArgs e)
        {
            frmFurnaceControlTransformatorDetails frmAction = new frmFurnaceControlTransformatorDetails();
            frmAction.Show();
        }

        private void pbTransformatorsDetails_MouseEnter(object sender, EventArgs e)
        {
            this.pbTransformatorsDetails.ImageLocation = Application.StartupPath + @"\Pics\A13_b.png";
        }

        private void pbTransformatorsDetails_MouseLeave(object sender, EventArgs e)
        {
            this.pbTransformatorsDetails.ImageLocation = Application.StartupPath + @"\Pics\A13_a.png";
        }

        private void pbTransformatorsSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbTransformatorsSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbTransformatorsSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbTransformatorsSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbTransformatorsManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbTransformatorsManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbTransformatorsManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbTransformatorsManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbTransformatorsReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbTransformatorsReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbTransformatorsReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbTransformatorsReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbTransformatorsAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbTransformatorsAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbTransformatorsAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbTransformatorsAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbTransformatorsAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbTransformatorsAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbTransformatorsAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbTransformatorsAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbTransformatorsRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbTransformatorsRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbTransformatorsRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbTransformatorsRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbHoistSettings_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHoistSettings frmAction = new frmFurnaceControlHoistSettings();
            frmAction.Show();
        }

        private void pbHoistSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbHoistSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbHoistSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbHoistSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbHoistManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHoistManual frmAction = new frmFurnaceControlHoistManual();
            frmAction.Show();
        }

        private void pbHoistManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbHoistManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbHoistManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbHoistManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbHoistReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHoistReports frmAction = new frmFurnaceControlHoistReports();
            frmAction.Show();
        }

        private void pbHoistReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbHoistReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbHoistReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbHoistReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbHoistAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHoistAlarms frmAction = new frmFurnaceControlHoistAlarms();
            frmAction.Show();
        }

        private void pbHoistAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbHoistAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbHoistAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbHoistAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbHoistAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbHoistAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbHoistAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbHoistAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbHoistRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbHoistRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbHoistRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbHoistRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbHoistDetails_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHoistDetails frmAction = new frmFurnaceControlHoistDetails();
            frmAction.Show();
        }

        private void pbHoistDetails_MouseEnter(object sender, EventArgs e)
        {
            this.pbHoistDetails.ImageLocation = Application.StartupPath + @"\Pics\A18_b.png";
        }

        private void pbHoistDetails_MouseLeave(object sender, EventArgs e)
        {
            this.pbHoistDetails.ImageLocation = Application.StartupPath + @"\Pics\A18_a.png";
        }

        private void pbSlipDetails_Click(object sender, EventArgs e)
        {
            frmFurnaceControlSlipDetails frmAction = new frmFurnaceControlSlipDetails();
            frmAction.Show();
        }

        private void pbSlipDetails_MouseEnter(object sender, EventArgs e)
        {
            this.pbSlipDetails.ImageLocation = Application.StartupPath + @"\Pics\A19_b.png";
        }

        private void pbSlipDetails_MouseLeave(object sender, EventArgs e)
        {
            this.pbSlipDetails.ImageLocation = Application.StartupPath + @"\Pics\A19_a.png";
        }

        private void pbSlipSettings_Click(object sender, EventArgs e)
        {
            frmFurnaceControlSlipSettings frmAction = new frmFurnaceControlSlipSettings();
            frmAction.Show();
        }

        private void pbSlipSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbSlipSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbSlipSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbSlipSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbSlipManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlSlipManual frmAction = new frmFurnaceControlSlipManual();
            frmAction.Show();
        }

        private void pbSlipManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbSlipManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbSlipManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbSlipManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbSlipReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlSlipReports frmAction = new frmFurnaceControlSlipReports();
            frmAction.Show();
        }

        private void pbSlipReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbSlipReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbSlipReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbSlipReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbSlipAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlSlipAlarms frmAction = new frmFurnaceControlSlipAlarms();
            frmAction.Show();
        }

        private void pbSlipAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbSlipAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbSlipAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbSlipAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbSlipAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbSlipAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbSlipAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbSlipAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbSlipRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbSlipRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbSlipRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbSlipRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbHydraulicDetails_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHydraulicDetails frmAction = new frmFurnaceControlHydraulicDetails();
            frmAction.Show();
        }

        private void pbHydraulicDetails_MouseEnter(object sender, EventArgs e)
        {
            this.pbHydraulicDetails.ImageLocation = Application.StartupPath + @"\Pics\A21_b.png";
        }

        private void pbHydraulicDetails_MouseLeave(object sender, EventArgs e)
        {
            this.pbHydraulicDetails.ImageLocation = Application.StartupPath + @"\Pics\A21_a.png";
        }

        private void pbHydraulicSettings_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHydraulicSettings frmAction = new frmFurnaceControlHydraulicSettings();
            frmAction.Show();
        }

        private void pbHydraulicSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbHydraulicSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbHydraulicSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbHydraulicSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbHydraulicManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHydraulicManual frmAction = new frmFurnaceControlHydraulicManual();
            frmAction.Show();
        }

        private void pbHydraulicManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbHydraulicManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbHydraulicManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbHydraulicManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbHydraulicReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHydraulicReports frmAction = new frmFurnaceControlHydraulicReports();
            frmAction.Show();
        }

        private void pbHydraulicReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbHydraulicReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbHydraulicReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbHydraulicReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbHydraulicAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlHydraulicAlarms frmAction = new frmFurnaceControlHydraulicAlarms();
            frmAction.Show();
        }

        private void pbHydraulicAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbHydraulicAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbHydraulicAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbHydraulicAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbHydraulicAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbHydraulicAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbHydraulicAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbHydraulicAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbHydraulicRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbHydraulicRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbHydraulicRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbHydraulicRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbShellDetails_Click(object sender, EventArgs e)
        {
            frmFurnaceControlShellDetails frmAction = new frmFurnaceControlShellDetails();
            frmAction.Show();
        }

        private void pbShellDetails_MouseEnter(object sender, EventArgs e)
        {
            this.pbShellDetails.ImageLocation = Application.StartupPath + @"\Pics\A15_b.png";
        }

        private void pbShellDetails_MouseLeave(object sender, EventArgs e)
        {
            this.pbShellDetails.ImageLocation = Application.StartupPath + @"\Pics\A15_a.png";
        }

        private void pbShellSetings_Click(object sender, EventArgs e)
        {
            frmFurnaceControlShellSettings frmAction = new frmFurnaceControlShellSettings();
            frmAction.Show();
        }

        private void pbShellSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbShellSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbShellSetings_MouseLeave(object sender, EventArgs e)
        {
            this.pbShellSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbShellManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlShellManual frmAction = new frmFurnaceControlShellManual();
            frmAction.Show();
        }

        private void pbShellManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbShellManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";

        }

        private void pbShellManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbShellManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbShellReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlShellReports frmAction = new frmFurnaceControlShellReports();
            frmAction.Show();
        }

        private void pbShellReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbShellReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbShellReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbShellReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbShellAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlShellAlarms frmAction = new frmFurnaceControlShellAlarms();
            frmAction.Show();
        }

        private void pbShellAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbShellAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbShellAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbShellAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbShellAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbShellAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbShellAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbShellAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbShellRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbShellRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbShellRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbShellRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbStockingDetails_Click(object sender, EventArgs e)
        {
            frmFurnaceControlStockingDetails frmAction = new frmFurnaceControlStockingDetails();
            frmAction.Show();
        }

        private void pbStockingDetails_MouseEnter(object sender, EventArgs e)
        {
            this.pbStockingDetails.ImageLocation = Application.StartupPath + @"\Pics\A26_b.png";
        }

        private void pbStockingDetails_MouseLeave(object sender, EventArgs e)
        {
            this.pbStockingDetails.ImageLocation = Application.StartupPath + @"\Pics\A26_a.png";
        }

        private void pbStockingSettings_Click(object sender, EventArgs e)
        {
            frmFurnaceControlStockingSettings frmAction = new frmFurnaceControlStockingSettings();
            frmAction.Show();
        }

        private void pbStockingSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbStockingSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbStockingSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbStockingSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbStockingManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlStockingManual frmAction = new frmFurnaceControlStockingManual();
            frmAction.Show();
        }

        private void pbStockingManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbStockingManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbStockingManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbStockingManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbStockingReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlStockingReports frmAction = new frmFurnaceControlStockingReports();
            frmAction.Show();
        }

        private void pbStockingReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbStockingReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbStockingReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbStockingReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbStockingAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlStockingAlarms frmAction = new frmFurnaceControlStockingAlarms();
            frmAction.Show();
        }

        private void pbStockingAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbStockingAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbStockingAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbStockingAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbStockingAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbStockingAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbStockingAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbStockingAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbStockingRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbStockingRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbStockingRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbStockingRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbProductionDetails_Click(object sender, EventArgs e)
        {
            frmFurnaceControlProductionDetails frmAction = new frmFurnaceControlProductionDetails();
            frmAction.Show();
        }

        private void pbProductionDetails_MouseEnter(object sender, EventArgs e)
        {
            this.pbProductionDetails.ImageLocation = Application.StartupPath + @"\Pics\A27_b.png";

        }
        private void pbProductionDetails_MouseLeave(object sender, EventArgs e)
        {
            this.pbProductionDetails.ImageLocation = Application.StartupPath + @"\Pics\A27_a.png";
        }

        private void pbProductionSettings_Click(object sender, EventArgs e)
        {
            frmFurnaceControlProductionSettings frmAction = new frmFurnaceControlProductionSettings();
            frmAction.Show();
        }

        private void pbProductionSettings_MouseEnter(object sender, EventArgs e)
        {
            this.pbProductionSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_b.png";
        }

        private void pbProductionSettings_MouseLeave(object sender, EventArgs e)
        {
            this.pbProductionSettings.ImageLocation = Application.StartupPath + @"\Pics\A2_a.png";
        }

        private void pbProductionManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlProductionManual frmAction = new frmFurnaceControlProductionManual();
            frmAction.Show();
        }

        private void pbProductionManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbProductionManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbProductionManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbProductionManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbProductionReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlProductionReports frmAction = new frmFurnaceControlProductionReports();
            frmAction.Show();
        }

        private void pbProductionReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbProductionReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbProductionReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbProductionReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbProductionAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlProductionAlarms frmAction = new frmFurnaceControlProductionAlarms();
            frmAction.Show();
        }

        private void pbProductionAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbProductionAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_b.png";
        }

        private void pbProductionAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbProductionAlarms.ImageLocation = Application.StartupPath + @"\Pics\A5_a.png";
        }

        private void pbProductionAuto_MouseEnter(object sender, EventArgs e)
        {
            this.pbProductionAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_b.png";
        }

        private void pbProductionAuto_MouseLeave(object sender, EventArgs e)
        {
            this.pbProductionAuto.ImageLocation = Application.StartupPath + @"\Pics\A6_a.png";
        }

        private void pbProductionRemote_MouseEnter(object sender, EventArgs e)
        {
            this.pbProductionRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_b.png";
        }

        private void pbProductionRemote_MouseLeave(object sender, EventArgs e)
        {
            this.pbProductionRemote.ImageLocation = Application.StartupPath + @"\Pics\A7_a.png";
        }

        private void pbFurnaceReports_Click(object sender, EventArgs e)
        {
            frmFurnaceControlFurnaceReports frmAction = new frmFurnaceControlFurnaceReports();
            frmAction.Show();
        }

        private void pbFurnaceReports_MouseEnter(object sender, EventArgs e)
        {
            this.pbFurnaceReports.ImageLocation = Application.StartupPath + @"\Pics\A4_b.png";
        }

        private void pbFurnaceReports_MouseLeave(object sender, EventArgs e)
        {
            this.pbFurnaceReports.ImageLocation = Application.StartupPath + @"\Pics\A4_a.png";
        }

        private void pbFurnaceManual_Click(object sender, EventArgs e)
        {
            frmFurnaceControlFurnaceManual frmAction = new frmFurnaceControlFurnaceManual();
            frmAction.Show();
        }

        private void pbFurnaceManual_MouseEnter(object sender, EventArgs e)
        {
            this.pbFurnaceManual.ImageLocation = Application.StartupPath + @"\Pics\A3_b.png";
        }

        private void pbFurnaceManual_MouseLeave(object sender, EventArgs e)
        {
            this.pbFurnaceManual.ImageLocation = Application.StartupPath + @"\Pics\A3_a.png";
        }

        private void pbFurnaceFullScreen_Click(object sender, EventArgs e)
        {
           
        }

        private void pbFurnaceFullScreen_MouseEnter(object sender, EventArgs e)
        {
            this.pbFurnaceFullScreen.ImageLocation = Application.StartupPath + @"\Pics\A29_b.png";
        }

        private void pbFurnaceFullScreen_MouseLeave(object sender, EventArgs e)
        {
            this.pbFurnaceFullScreen.ImageLocation = Application.StartupPath + @"\Pics\A29_a.png";
        }

        private void pbFurnaceMute_Click(object sender, EventArgs e)
        {

        }

        private void pbFurnaceMute_MouseEnter(object sender, EventArgs e)
        {
            this.pbFurnaceMute.ImageLocation = Application.StartupPath + @"\Pics\A30_b.png";
        }

        private void pbFurnaceMute_MouseLeave(object sender, EventArgs e)
        {
            this.pbFurnaceMute.ImageLocation = Application.StartupPath + @"\Pics\A30_a.png";
        }

        private void pbFurnaceAlarms_Click(object sender, EventArgs e)
        {
            frmFurnaceControlFurnaceAlarms frmAction = new frmFurnaceControlFurnaceAlarms();
            frmAction.Show();
        }

        private void pbFurnaceAlarms_MouseEnter(object sender, EventArgs e)
        {
            this.pbFurnaceAlarms.ImageLocation = Application.StartupPath + @"\Pics\A31_b.png";
        }

        private void pbFurnaceAlarms_MouseLeave(object sender, EventArgs e)
        {
            this.pbFurnaceAlarms.ImageLocation = Application.StartupPath + @"\Pics\A31_a.png";
        }
    }
}
