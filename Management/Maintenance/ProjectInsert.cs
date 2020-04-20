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
    public partial class ProjectInsert : Form
    {
        public Project proInsert;
        public Connection cnConnection;
        private Category[] caCategories;

        public ProjectInsert()
        {
            InitializeComponent();

            this.proInsert = new Project();
        }

        private void ProjectInsert_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategory.Items.Add(item.nvcName);
                }
            }
        }

        private void SetEnableBtmOk()
        {
            if (this.cbCategory.SelectedIndex >= 0 && this.tbName.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var categoryId=db.Categories.GetEntity(t => t.nvcName==cbCategory.SelectedItem).intNumber;
                var maxNumber = db.Projects.GetAll().Max(t => t.intNumber);
                tabProjects tabProjects=new tabProjects()
                {
                    bitSelect = false,
                    nvcName = tbName.Text.Trim(),
                    intNumber = maxNumber+1,
                    intCategory = categoryId,
                    nvcTip = tbTip.Text.Trim()
                };
                db.Projects.Insert(tabProjects);
                db.Save();
                this.Close();
            }
            //this.proInsert.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
            //this.proInsert.strName = this.tbName.Text;
            //this.proInsert.strTip = this.tbTip.Text;

            //proInsert.Insert(this.cnConnection);

            //Projects frmProjects = (Projects)this.Owner;
            //frmProjects.SearchProjects();
            //this.Close();
        }

        private void SetFarsiLanguageTextBoxes(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }


        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void TbName_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TbTip_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }
    }
}
