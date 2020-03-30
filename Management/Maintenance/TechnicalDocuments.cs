using Baran.Ferroalloy.Automation.Security;
using Baran.Ferroalloy.Automation.SqlDataBase;
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
using Baran.Ferroalloy.Management.Maintenance;

namespace Baran.Ferroalloy.Management
{
    public partial class TechnicalDocuments : Form
    {
        public static Boolean bolIsRunning;
        public Connection cnConnection;
        public User usUser;
        public FamSetting setSettings;
        public DataSet dsTechnicalDocuments;
        private Category[] caCategories;
        private Zone[] zoZones;
        private TechnicalDocument tdSearch;
        private TechnicalDocument tdUpdate;


        public TechnicalDocuments()
        {
            InitializeComponent();
            bolIsRunning = true;
        }

        private void TechnicalDocuments_Load(object sender, EventArgs e)
        {
            //SetComponentsByPermisions();
            dgvTechnicalDocuments.AutoGenerateColumns = false;
            using (UnitOfWork db = new UnitOfWork())
            {
                var companies = db.Companies.GetAll();
                foreach (var item in companies)
                {
                    cbCompanies.Items.Add(item.nvcName);
                }

                var locationes = db.Locations.GetAll();
                foreach (var item in locationes)
                {
                    cbLocations.Items.Add(item.nvcName);
                }

                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategories.Items.Add(item.nvcName);
                }

                var technicalDocumentTypes = db.TechnicalDocumentTypes.GetAll();
                foreach (var item in technicalDocumentTypes)
                {
                    cbType.Items.Add(item.nvcName);
                }
            }
        }

        private void btmSearch_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var technicalDocuments = db.TechnicalDocuments.FilterTechnicalDocumentItems(cbCompanies.SelectedItem, cbLocations.SelectedItem,
                    cbCategories.SelectedItem, cbType.SelectedItem, tbCoDesigner.Text.Trim(),
                    tbDesignerName.Text.Trim(), tbRevisionNumber.Text.Trim());
                dgvTechnicalDocuments.DataSource = db.TechnicalDocuments.FilldgvTechnicalDocuments(technicalDocuments);
            }
        }

        public void RefreshList(int? company, int? location, int? category, int? type)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var technicalDocuments = db.TechnicalDocuments.GetByWhere(t =>
                    t.intCompany == company && t.intLocation == location && t.intCategory == category &&
                    t.intType == type).ToList();
                dgvTechnicalDocuments.DataSource = db.TechnicalDocuments.FilldgvTechnicalDocuments(technicalDocuments);
            }
        }

        private void BtmDelete_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (dgvTechnicalDocuments.CurrentRow.Cells != null)
                {
                    if (RtlMessageBox.Show($"آیا از حذف مطمئن هستید؟", "توجه", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var selectItems = dgvTechnicalDocuments.Rows.Cast<DataGridViewRow>().Where(t => Convert.ToBoolean(t.Cells["bitSelect"].Value) == true).ToList();

                        foreach (var item in selectItems)
                        {
                            var id = int.Parse(item.Cells["intID"].Value.ToString());
                            var technicalDocuments = db.TechnicalDocuments.GetEntity(t => t.intID == id);
                            db.TechnicalDocuments.Delete(technicalDocuments);
                        }
                        db.Save();
                        Filter();
                    }
                }
                else
                {
                    RtlMessageBox.Show("لطفا یک سند را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }

        private void BtmInsert_Click(object sender, EventArgs e)
        {
            TechnicalDocumentInsert frmTechnicalDocumentInsert = new TechnicalDocumentInsert();
            frmTechnicalDocumentInsert.Show();
        }

        private void SetComponentsByPermisions()
        {
            //if (this.usUser.bolTechnicalEnabed)
            //{
            //    this.btmDelete.Enabled = true;
            //    this.btmInsert.Enabled = true;
            //    this.dgvTechnicalDocuments.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTechnicalDocuments_CellMouseDoubleClick);
            //}
            //else
            //{
            //    this.btmDelete.Enabled = false;
            //    this.btmInsert.Enabled = false;
            //    this.dgvTechnicalDocuments.CellMouseDoubleClick -= new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTechnicalDocuments_CellMouseDoubleClick);
            //}
        }

        private void btmClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TechnicalDocuments_FormClosing(object sender, FormClosingEventArgs e)
        {
            //bolIsRunning = false;

            //Management frmManagement = (Management)this.MdiParent;
            //frmManagement.menWindows.DropDownItems["menWindowsTechnicalDocuments"].Dispose();
        }

        //private void btmExit_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void DgvTechnicalDocuments_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TechnicalDocumentUpdate frmTechnicalDocumentUpdate = new TechnicalDocumentUpdate();
            frmTechnicalDocumentUpdate.technicalDocumentId = Convert.ToInt32(dgvTechnicalDocuments.CurrentRow.Cells["intID"].Value.ToString());
            frmTechnicalDocumentUpdate.ShowDialog();
        }

        private void BtnTachnicalDocumentItems_Click(object sender, EventArgs e)
        {
            if (dgvTechnicalDocuments.CurrentRow != null)
            {
                FrmTechnicalDocumentItems frmTechnicalDocumentItems = new FrmTechnicalDocumentItems();
                var technicalDocumentId= Convert.ToInt32(dgvTechnicalDocuments.CurrentRow.Cells["intID"].Value.ToString());
                frmTechnicalDocumentItems.technicalDocumentId = technicalDocumentId;
                frmTechnicalDocumentItems.ShowDialog();
            }
            else
            {
                RtlMessageBox.Show("لطفا یک سند را انتخاب کنید", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
