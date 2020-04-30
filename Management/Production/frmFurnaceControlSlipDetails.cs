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
    public partial class frmFurnaceControlSlipDetails : Form
    {
        public frmFurnaceControlSlipDetails()
        {
            InitializeComponent();
        }

        private void frmFurnaceControlCbDetails_Load(object sender, EventArgs e)
        {
            this.pbHoistDetails.ImageLocation = Application.StartupPath + @"\Pics\A20_Main.png";
        }
    }
}
