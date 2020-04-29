using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation;

namespace Baran.Ferroalloy.Management.Maintenance
{
    public partial class FrmMaintenanceUpdate : Form
    {
        public int maintenanceId;

        public FrmMaintenanceUpdate()
        {
            InitializeComponent();
        }

        private void FrmMaintenanceUpdate_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var maintenances = db.Maintenance.GetEntity(t => t.intID == maintenanceId);
                if (maintenances != null)
                {
                    List<int> intWorkGroup = new List<int> { 1, 2, 3, 4 };
                    foreach (var item in intWorkGroup)
                    {
                        cbWorkGroup.Items.Add(item);
                    }

                    cbWorkGroup.SelectedItem = maintenances.intWourkGroup.ToString();

                    var shifts = db.shift.GetAll();
                    foreach (var item in shifts)
                    {
                        cbShift.Items.Add(item.nvcName);
                    }
                    cbShift.SelectedItem = maintenances.tabShifts.nvcName;

                    dtMaintenance.Text = maintenances.datWorkGroup.ToString();

                    var subDepartments = db.subDepartment.GetAll().Where(t => t.intDepartment == maintenances.intDepartment);
                    foreach (var item in subDepartments)
                    {
                        cbSubDepartment.Items.Add(item.nvcName);
                    }
                    cbSubDepartment.SelectedItem = maintenances.tabDepartments.nvcName;

                    var coIds=maintenances.nvcCoIdsWorkGroup.Split('-');
                    var fullName = "";
                    foreach (var item in coIds)
                    {
                        var employees = db.Employees.GetEntity(t => t.nvcCoID == item);
                        fullName += employees.nvcFirstname + " " + employees.nvcLastname + "-";
                    }

                    fullName = fullName.Remove(fullName.Length - 1);
                    lbWorkers.Items.Add(fullName);

                }
            }
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {

        }
    }
}
