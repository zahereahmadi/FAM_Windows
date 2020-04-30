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
    public partial class frmFurnaceControlProductionDetails : Form
    {
        public frmFurnaceControlProductionDetails()
        {
            InitializeComponent();
        }

        private void frmFurnaceControlCbDetails_Load(object sender, EventArgs e)
        {
            this.pbProductionDetails.ImageLocation = Application.StartupPath + @"\Pics\A28_Main.png";
        }
    }
}
