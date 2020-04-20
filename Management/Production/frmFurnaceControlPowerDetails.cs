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
    public partial class frmFurnaceControlPowerDetails : Form
    {
        public frmFurnaceControlPowerDetails()
        {
            InitializeComponent();
        }

        private void frmFurnaceControlPowerDetails_Load(object sender, EventArgs e)
        {
            this.pbPowerDetails.ImageLocation = Application.StartupPath + @"\Pics\A8_Main.png";
        }
    }
}
