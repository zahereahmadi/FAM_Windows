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

namespace Baran.Ferroalloy.Management.Office
{
    public partial class FrmSelectEmployee : Form
    {
        public string coId;
        public string fullName;

        public FrmSelectEmployee()
        {
            InitializeComponent();
            coId = "";
            fullName = "";
        }

        private void FrmSelectEmployee_Load(object sender, EventArgs e)
        {
            dgvEmployees.AutoGenerateColumns = false;
            using (UnitOfWork db=new UnitOfWork())
            {
                var departments = db.department.GetAll();
                foreach (var item in departments)
                {
                    cbDepartments.Items.Add(item.nvcName);
                }

            }
        }

        private void Filter()
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var employees = db.Employees.FilterSelectEmployee(tbCoID.Text.Trim(), cbDepartments.SelectedText,
                    tbLastName.Text.Trim(), tbFirstName.Text.Trim());
                dgvEmployees.DataSource = db.Employees.SelectEmployeeByFilter(employees);
            }
        }

        private void BtmSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void BtmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtmSelect_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow != null)
            {
                using (UnitOfWork db=new UnitOfWork())
                {
                    coId = dgvEmployees.CurrentRow.Cells["nvcCoID"].Value.ToString();
                    fullName = dgvEmployees.CurrentRow.Cells["nvcFirstName"].Value.ToString() + " " +
                               dgvEmployees.CurrentRow.Cells["nvcLastName"].Value.ToString();
                }
                this.Close();
            }
            else
            {
                RtlMessageBox.Show("لطفا یک کارمند را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
