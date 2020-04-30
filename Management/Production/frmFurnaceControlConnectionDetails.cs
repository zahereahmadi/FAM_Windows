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
    public partial class frmFurnaceControlConnectionDetails : Form
    {
        public frmFurnaceControlConnectionDetails()
        {
            InitializeComponent();
        }

        private void frmFurnaceControlConnectionDetails_Load(object sender, EventArgs e)
        {
            this.pbConnetionDetails.ImageLocation = Application.StartupPath + @"\Pics\A9_Main.png";
        }
    }
}
