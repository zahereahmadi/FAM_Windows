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
    public partial class frmFurnaceControlTransformatorDetails : Form
    {
        public frmFurnaceControlTransformatorDetails()
        {
            InitializeComponent();
        }

        private void frmFurnaceControlCbDetails_Load(object sender, EventArgs e)
        {
            this.pbTransformersDetails.ImageLocation = Application.StartupPath + @"\Pics\A14_Main.png";
        }
    }
}
