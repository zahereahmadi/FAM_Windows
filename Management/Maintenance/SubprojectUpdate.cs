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

namespace Baran.Ferroalloy.Management
{
    public partial class SubprojectUpdate : Form
    {
        public Subproject spUpdate;
        public Connection cnConnection;
        private Category[] caCategories;
        public int subProjectId;

        public SubprojectUpdate()
        {
            InitializeComponent();

            this.spUpdate = new Subproject();
        }

        private void InvoiceUpdate_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var subProjects = db.SubProjects.GetEntity(t => t.intID == subProjectId);
                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategory.Items.Add(item.nvcName);
                }

                cbCategory.SelectedItem = db.Categories.GetEntity(t => t.intNumber == subProjects.intCategory).nvcName;
                this.tbProjectNumber.Text = subProjects.intProject.ToString();
                this.tbName.Text = subProjects.nvcName;
                this.dtpStartDate.Value = subProjects.datStart;
                this.tbprogress.Text = subProjects.intProgress.ToString();
                this.tbDuration.Text = subProjects.intDuration.ToString();
                this.tbTip.Text = subProjects.nvcTip;
            }
            
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;
            using (UnitOfWork db=new UnitOfWork())
            {
                int categoryId = db.Categories.GetEntity(t => t.nvcName == cbCategory.SelectedItem).intNumber;
                var subProjects = db.SubProjects.GetEntity(t => t.intID == subProjectId);
                subProjects.intID = subProjects.intID;
                subProjects.nvcName = tbName.Text.Trim();
                subProjects.datStart = dtpStartDate.Value;
                subProjects.intCategory = categoryId;
                subProjects.intDuration = Convert.ToInt32(Language.GetEnglishText(tbDuration.Text));
                subProjects.intProgress = Convert.ToInt32(Language.GetEnglishText(tbprogress.Text));
                subProjects.intProject = Convert.ToInt32(tbProjectNumber.Text);
                subProjects.nvcTip = tbTip.Text.Trim();
                subProjects.bitSelect = subProjects.bitSelect;
                subProjects.intWeight = subProjects.intWeight;
                db.SubProjects.Update(subProjects);
                db.Save();
            }
            //this.spUpdate.intProjectNumber = int.Parse(this.tbProjectNumber.Text.Trim());
            //this.spUpdate.dtStart = this.dtpStartDate.Value;
            //this.spUpdate.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
            //this.spUpdate.strName = this.tbName.Text.Trim();
            //this.spUpdate.dtStart = this.dtpStartDate.Value;
            //this.spUpdate.intProgress = int.Parse(this.tbprogress.Text.Trim());
            //this.spUpdate.intDuration = int.Parse(this.tbDuration.Text.Trim());
            //this.spUpdate.strTip = this.tbTip.Text.Trim();

            //this.spUpdate.Update(this.cnConnection);

            //Subprojects frmSubprojects = (Subprojects)this.Owner;
            //frmSubprojects.SearchSubProjects();
            this.Close();
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbName.Text.Trim().Length != 0 && this.tbDuration.Text.Trim().Length != 0 &&
                this.dtpStartDate.Value.Year != 1 && this.cbCategory.SelectedIndex != -1 &&
                this.tbprogress.Text.Trim().Length != 0 && this.tbProjectNumber.Text.Trim().Length != 0)
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

        private void DtpStartDate_ValueChanged(object sender, EventArgs e)
        {
          

            SetEnableBtmOk();
        }

        private void TbProjectNumber_TextChanged(object sender, EventArgs e)
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

        private void TbDuration_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void Tbprogress_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }

        private void TbTip_TextChanged(object sender, EventArgs e)
        {
            SetEnableBtmOk();
        }
    }
}
