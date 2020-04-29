using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation;

namespace Baran.Ferroalloy.Management
{
    public partial class Subprojects : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSetings;
        public Project proProject;
        public DataSet dsSubprojects;
        public Subproject spSearch;
        private Subproject spUpdate;
        public int projectId;
        public DataGridView dataGridView;

        public Subprojects()
        {
            InitializeComponent();
            //bolIsRunning = true;

            this.proProject = new Project();
            this.spSearch = new Subproject();
            this.spUpdate = new Subproject();
            dataGridView = dgvSubProjects;
        }

        private void SubProjects_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var projects = db.Projects.GetEntity(t => t.intID == projectId);
                var subProjects = db.SubProjects.GetEntity(t => t.intProject == projectId);
                labProjectNumber.Text = projects.intNumber.ToString();
                labCategory.Text = projects.tabCategories.nvcName;
                labName.Text = projects.nvcName;
            }
            SetComponentsByPermisions();
            SearchSubProjects();
            //this.labProjectNumber.Text = this.proProject.intNumber.ToString();
            //this.labName.Text = this.proProject.strName;
            //this.labCategory.Text = Category.GetNameByNumber(this.cnConnection,this.proProject.intCategory);
            //this.labTip.Text = this.proProject.strTip;
        }

        public void SearchSubProjects()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgvSubProjects.DataSource = db.SubProjects.FillDgvSubProjects(projectId);
            }
            //this.dsSubprojects = Subproject.GetSubprojects(this.cnConnection, this.spSearch);

            //this.dgvSubProjects.DataSource = this.dsSubprojects;
            //this.dgvSubProjects.DataMember = "tabSubprojects";

            //for (int i = 0; i < this.dgvSubProjects.Rows.Count; i++)
            //{
            //    this.dgvSubProjects.Rows[i].Cells["intCategoryAsName"].Value =
            //        Category.GetNameByNumber(this.cnConnection, (int)this.dgvSubProjects.Rows[i].Cells["intCategory"].Value);
            //}
        }

        private void SetComponentsByPermisions()
        {
            if (this.usUser.bolTechnicalEnabed)
            {
                this.btmDelete.Enabled = true;
                this.btmInsert.Enabled = true;
                //this.dgvSubProjects.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubprojects_CellMouseDoubleClick);
                this.dgvSubProjects.Columns["bitSelect"].Visible = true;
            }
            else
            {
                this.btmDelete.Enabled = false;
                this.btmInsert.Enabled = false;
                //this.dgvSubProjects.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvSubprojects_CellMouseDoubleClick);
                this.dgvSubProjects.Columns["bitSelect"].Visible = false;
            }
        }

        private void btmDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubProjects.CurrentRow != null)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (RtlMessageBox.Show($"آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                            MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var selectItems = dgvSubProjects.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToBoolean(t.Cells["bitSelect"].Value) == true).ToList();

                        foreach (var item in selectItems)
                        {
                            var id = int.Parse(item.Cells["intID"].Value.ToString());
                            var subProjects = db.SubProjects.GetEntity(t => t.intID == id);
                            db.SubProjects.Delete(subProjects);


                        }
                        db.Save();
                        SearchSubProjects();
                    }
                }
            }
            //Int16 intSelectedSubprojects = 0;
            //foreach (DataRow drVendor in this.dsSubprojects.Tables["tabSubprojects"].Rows)
            //{
            //    if ((Boolean)drVendor["bitSelect"])
            //    {
            //        ++intSelectedSubprojects;
            //    }
            //}

            //if (intSelectedSubprojects > 0)
            //{
            //    DialogResult dialogResult = MessageBox.Show("آیا می خواهید " + intSelectedSubprojects.ToString() + " زیرپروژه‌ها را حذف کنید؟", "حذف", MessageBoxButtons.YesNo);
            //    if (dialogResult == DialogResult.Yes)
            //    {
            //        Subproject.DeleteSubprojects(this.cnConnection, this.dsSubprojects);
            //        SearchSubProjects();
            //    }
            //}
            //else
            //{
            //    MessageBox.Show(".هیچ زیرپروژه‌ای انتخاب نشده است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign);
            //}
        }

        private void btmInsert_Click(object sender, EventArgs e)
        {
            SubprojectInsert frmSubprojectInsert = new SubprojectInsert();
            frmSubprojectInsert.projectNumber = Convert.ToInt32(labProjectNumber.Text);
            frmSubprojectInsert.Owner = this;
            frmSubprojectInsert.cnConnection = this.cnConnection;
            frmSubprojectInsert.spInsert.intProjectNumber = this.proProject.intNumber;
            frmSubprojectInsert.ShowDialog();
        }

        private void BtmExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DgvSubProjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            SubprojectUpdate frmSubProjectUpdate = new SubprojectUpdate();
            frmSubProjectUpdate.subProjectId = Convert.ToInt32(dgvSubProjects.CurrentRow.Cells["intID"].Value.ToString());
            frmSubProjectUpdate.Owner = this;
            frmSubProjectUpdate.cnConnection = this.cnConnection;
            frmSubProjectUpdate.ShowDialog();
        }
    }
}
