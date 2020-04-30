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
    public partial class frmFurnaceControlHoistDetails : Form
    {
        public frmFurnaceControlHoistDetails()
        {
            InitializeComponent();
        }

        private void frmFurnaceControlCbDetails_Load(object sender, EventArgs e)
        {
            this.pbHoistDetails.ImageLocation = Application.StartupPath + @"\Pics\A17_Main.png";
        }
    }
}
