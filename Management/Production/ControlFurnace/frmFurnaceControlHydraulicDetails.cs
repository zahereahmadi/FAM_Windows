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
    public partial class frmFurnaceControlHydraulicDetails : Form
    {
        public frmFurnaceControlHydraulicDetails()
        {
            InitializeComponent();
        }

        private void frmFurnaceControlCbDetails_Load(object sender, EventArgs e)
        {
            this.pbHydraulicDetails.ImageLocation = Application.StartupPath + @"\Pics\A22_Main.png";
        }
    }
}
