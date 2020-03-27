using Baran.Ferroalloy.Automation.SqlDataBase;
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
using Baran.Ferroalloy.Automation;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Management
{
    public partial class TechnicalDocumentInsert : Form
    {
        public TechnicalDocument tdTechnicalDocument = new TechnicalDocument();
        public Connection cnConnection;
        private Category[] caCategories;

        public TechnicalDocumentInsert()
        {
            InitializeComponent();
        }

        private void TechnicalDocumentInsert_Load(object sender, EventArgs e)
        {
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

        private void BtmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var companyId = db.Companies.GetEntityByName(t => t.nvcName == cbCompanies.SelectedItem).intNumber;
                var locationId = db.Locations.GetEntityByName(t => t.nvcName == cbLocations.SelectedItem).intNumber;
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber;
                var typeId = db.TechnicalDocumentTypes.GetEntityByName(t => t.nvcName == cbType.SelectedItem).intNumber;
                var coDesigner = tbCoDesigner.Text.Trim();
                var designerName = tbDesignerName.Text.Trim();
                var revisionNumber = tbRevisionNumber.Text.Trim();
                var title = txtTitle.Text.Trim();

                var technicalDocuments = db.TechnicalDocuments.GetByWhere(t =>
                    t.intCompany == companyId && t.intLocation == locationId && t.intCategory == categoryId && t.intType == typeId).ToList();
                tabTechnicalDocuments tabTechnicalDocuments = new tabTechnicalDocuments();

                if (technicalDocuments.Count > 0)
                {
                    var last = technicalDocuments.Last();
                    tabTechnicalDocuments.intOrder = last.intOrder + 1;
                }
                else
                {
                    tabTechnicalDocuments.intOrder = 1;
                }
                tabTechnicalDocuments.bitSelect = false;
                tabTechnicalDocuments.intCompany = companyId;
                tabTechnicalDocuments.intLocation = locationId;
                tabTechnicalDocuments.intCategory = categoryId;
                tabTechnicalDocuments.intType = typeId;
                tabTechnicalDocuments.nvcCoDesigner = coDesigner;
                tabTechnicalDocuments.nvcPersonDesigner = designerName;
                tabTechnicalDocuments.nvcRevisionNumber = revisionNumber;
                tabTechnicalDocuments.nvcTitle = title;

                db.TechnicalDocuments.Insert(tabTechnicalDocuments);
                db.Save();
                this.Close();
                TechnicalDocuments frmTechnicalDocuments = new TechnicalDocuments();
                frmTechnicalDocuments.RefreshList(tabTechnicalDocuments.intCompany,
                    tabTechnicalDocuments.intLocation, tabTechnicalDocuments.intCategory,
                    tabTechnicalDocuments.intType);
                DialogResult = DialogResult.OK;
                //if (technicalDocuments.Last().intOrder.ToString().Length == 4)
                //{
                //    RtlMessageBox.Show("سقف ورود این مستند پر شده است", "اخطار", MessageBoxButtons.OK,
                //        MessageBoxIcon.Warning);
                //}
                //else
                //{

                //}
            }
        }

        private void BtmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
