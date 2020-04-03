using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.SqlDataBase;
using Baran.Ferroalloy.Finance;
using Baran.Ferroalloy.Maintenance;
using Baran.Ferroalloy.Office;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Management
{
    public partial class ProjectUpdate : Form
    {
        public Project proUpdate;
        public Connection cnConnection;
        private Category[] caCategories;
        public int projectId;
        public ProjectUpdate()
        {
            InitializeComponent();
        }

        private void ProjectUpdate_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var projects = db.Projects.GetEntity(t => t.intID == projectId);
                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategory.Items.Add(item.nvcName);
                }

                cbCategory.SelectedItem = projects.tabCategories.nvcName;
                tbNumber.Text = projects.intNumber.ToString();
                tbName.Text = projects.nvcName.Trim();
                tbTip.Text = projects.nvcTip.Trim();

            }
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var projects = db.Projects.GetEntity(t => t.intID == projectId);
                var categoryId = db.Categories.GetEntity(t => t.nvcName == cbCategory.SelectedItem).intNumber;
                var number = Convert.ToInt32(tbNumber.Text.Trim());
                projects.intID = projectId;
                projects.nvcName = tbName.Text.Trim();
                projects.nvcTip = tbTip.Text.Trim();
                projects.intCategory = categoryId;
                projects.bitSelect = projects.bitSelect;
                if (projects.intNumber == number)
                {
                    projects.intNumber = projects.intNumber;
                    db.Projects.Update(projects);
                    db.Save();
                    this.Close();
                }
                else
                {
                    var searchProject = db.Projects.GetEntity(t => t.intNumber == number);
                    if (searchProject != null)
                    {
                        RtlMessageBox.Show("شماره وارد شده تکراری می باشد!", "اخطار", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        projects.intNumber = number;
                        db.Projects.Update(projects);
                        db.Save();
                        this.Close();
                    }

                }

                
            }
            //this.proUpdate.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
            //this.proUpdate.strName = this.tbName.Text;
            //this.proUpdate.intNumber = int.Parse(this.tbNumber.Text);
            //this.proUpdate.strTip = this.tbTip.Text;

            //this.proUpdate.Update(this.cnConnection);

            //Projects frmProjects = (Projects)this.Owner;
            //frmProjects.SearchProjects();
            //this.Close();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbNumber.Text.Trim().Length != 0 && this.cbCategory.SelectedIndex >= 0 &&
                this.tbName.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void SetFarsiLanguageTextBoxes(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void SetNumbericCharsTextBoxes(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TbNumber_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void CbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbName_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbTip_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }
    }
}
