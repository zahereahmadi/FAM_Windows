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
using Baran.Ferroalloy.Management.Office;

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
            using (UnitOfWork db = new UnitOfWork())
            {
                var maintenances = db.Maintenance.GetEntity(t => t.intID == maintenanceId);
                if (maintenances != null)
                {
                    List<int> intWorkGroup = new List<int> { 1, 2, 3, 4 };
                    foreach (var item in intWorkGroup)
                    {
                        cbWorkGroup.Items.Add(item);
                    }

                    cbWorkGroup.SelectedIndex = maintenances.intWourkGroup;

                    var shifts = db.shift.GetAll();
                    foreach (var item in shifts)
                    {
                        cbShift.Items.Add(item.nvcName);
                    }
                    cbShift.SelectedItem = maintenances.tabShifts.nvcName;

                    dtMaintenance.Text = maintenances.datWorkGroup.ToString("D");

                    var subDepartments = db.subDepartment.GetAll().Where(t => t.intDepartment == maintenances.intDepartment);
                    foreach (var item in subDepartments)
                    {
                        cbSubDepartment.Items.Add(item.nvcName);
                    }
                    cbSubDepartment.SelectedItem = maintenances.tabSubDepartments.nvcName;

                    var coIds = maintenances.nvcCoIdsWorkGroup.Split('-');
                    var fullName = "";
                    foreach (var item in coIds)
                    {
                        var employees = db.Employees.GetEntity(t => t.nvcCoID == item);
                        fullName = employees.nvcFirstname + " " + employees.nvcLastname;
                        lbWorkers.Items.Add(fullName);
                    }

                    var leader = db.Employees.GetEntity(t => t.nvcCoID == maintenances.nvcCoIdLeader);
                    txtLeaderWorkGroup.Text = leader.nvcFirstname + " " + leader.nvcLastname;
                }
            }
        }

        private void BtmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var maintenances = db.Maintenance.GetEntity(t => t.intID == maintenanceId);
                var shiftId = db.shift.GetEntity(t => t.nvcName == cbShift.SelectedItem).intNumber;
                var subDepartmentId = db.subDepartment.GetEntity(t => t.nvcName == cbSubDepartment.SelectedItem).intNumber;
                var coIds = "";
                var coIdLeader = db.Employees.GetEntity(t => t.nvcFirstname + " " + t.nvcLastname == txtLeaderWorkGroup.Text).nvcCoID;
                var nameWorker = lbWorkers.Items;
                foreach (var item in nameWorker)
                {
                    coIds += db.Employees.GetEntity(t => t.nvcFirstname + " " + t.nvcLastname == item).nvcCoID + "-";
                    //coIdLeader = db.Employees.GetEntity(t =>
                    // t.nvcFirstname + " " + t.nvcLastname == item && t.bitIsLeader == true).nvcCoID;
                }

                coIds = coIds.Remove(coIds.Length - 1);

                maintenances.intID = maintenances.intID;
                maintenances.intDepartment = 5;
                maintenances.bitSelect = false;
                maintenances.datWorkGroup = dtMaintenance.Value;
                maintenances.intShift = shiftId;
                maintenances.intSubDepartment = subDepartmentId;
                maintenances.nvcCoIdsWorkGroup = Language.GetEnglishText(coIds);
                maintenances.nvcCoIdLeader = coIdLeader;
                maintenances.intWourkGroup = (int) cbWorkGroup.SelectedItem;

                db.Maintenance.Update(maintenances);
                db.Save();
                this.Close();
            }
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSelectEmployee_Click(object sender, EventArgs e)
        {
            FrmSelectEmployee frmSelectEmployee = new FrmSelectEmployee();
            frmSelectEmployee.ShowDialog();
            lbWorkers.Items.Add(frmSelectEmployee.fullName);
        }

        private void BtmDeleteEmployee_Click(object sender, EventArgs e)
        {
            if (lbWorkers.SelectedItem != null)
            {
                this.lbWorkers.Items.RemoveAt(this.lbWorkers.SelectedIndex);
            }
            else
            {
                RtlMessageBox.Show("لطفا تعمیرکار مورد نظر را انتخاب کنید", "اخطار", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void BtnSelectWorkerLeader_Click(object sender, EventArgs e)
        {
            FrmSelectEmployee frmSelectEmployee = new FrmSelectEmployee();
            frmSelectEmployee.ShowDialog();
            txtLeaderWorkGroup.Text = frmSelectEmployee.fullName;
        }


    }
}
