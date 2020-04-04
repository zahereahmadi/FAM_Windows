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
    public partial class SubprojectInsert : Form
    {
        public Subproject spInsert;

        public Connection cnConnection;
        private Category[] caCategories;
        public int projectNumber;

        public SubprojectInsert()
        {
            InitializeComponent();

            this.spInsert = new Subproject();
        }

        private void SubprojectInsert_Load(object sender, EventArgs e)
        {

            using (UnitOfWork db = new UnitOfWork())
            {
                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategory.Items.Add(item.nvcName);
                }
            }
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            this.btmOK.Enabled = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                int categoryId = db.Categories.GetEntity(t => t.nvcName == cbCategory.SelectedItem).intNumber;
                tabSubProjects tabSubProjects = new tabSubProjects()
                {
                    nvcName = tbName.Text.Trim(),
                    bitSelect = false,
                    datStart = dtpStartDate.Value,
                    intCategory = categoryId,
                    intDuration = Convert.ToInt32(Language.GetEnglishText(tbDuration.Text)),
                    intProgress = Convert.ToInt32(Language.GetEnglishText(tbprogress.Text)),
                    //intWeight = 0,
                    nvcTip = tbTip.Text.Trim(),
                    intProject = projectNumber
                };
                db.SubProjects.Insert(tabSubProjects);
                db.Save();

                this.Close();
            }
            //this.spInsert.intCategory = this.caCategories[this.cbCategory.SelectedIndex].intNumber;
            //this.spInsert.dtStart = this.dtpStartDate.Value;
            //this.spInsert.strName = this.tbName.Text;
            //this.spInsert.intDuration = int.Parse(this.tbDuration.Text);
            //this.spInsert.strTip = this.tbTip.Text;


            //spInsert.Insert(this.cnConnection);

            //Subprojects frmSubprojects = (Subprojects)this.Owner;
            //frmSubprojects.SearchSubProjects();

        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SetEnableBtmOk()
        {
            if (this.tbName.Text.Trim().Length != 0 && this.tbDuration.Text.Trim().Length != 0 &&
                this.dtpStartDate.Value.Year != 1 && this.cbCategory.SelectedIndex != -1 &&
                this.tbprogress.Text.Trim().Length != 0)
            {
                this.btmOK.Enabled = true;
            }
            else
            {
                this.btmOK.Enabled = false;
            }
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

        private void TbName_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TbDuration_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void Tbprogress_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void TbTip_Enter(object sender, EventArgs e)
        {
            Language.SetFarsiLanguage();
        }

        private void SubprojectInsert_FormClosed(object sender, FormClosedEventArgs e)
        {
            RtlMessageBox.Show("");
        }
    }
}
