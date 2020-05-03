using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
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
    public partial class frmMaterialHandelingControl : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;

        public frmMaterialHandelingControl()
        {
            InitializeComponent();
        }

        private void frmCoolingControl_Load(object sender, EventArgs e)
        {
            //this.pbCooling.ImageLocation = Application.StartupPath + @"\Pics\A32_a.png";
        }
    }
}
