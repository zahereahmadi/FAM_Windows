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

namespace Baran.Ferroalloy.Management
{
    public partial class TechnicalDocumentUpdate : Form
    {
        public TechnicalDocument tdTechnicalDocument = new TechnicalDocument();
        public Connection cnConnection;
        private Category[] caCategories;
        public int technicalDocumentId;

        public TechnicalDocumentUpdate()
        {
            InitializeComponent();
        }

        private void TechnicalDocumentUpdate_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var technicalDocuments = db.TechnicalDocuments.GetEntity(t => t.intID == technicalDocumentId);
                var companies = db.Companies.GetAll();
                foreach (var item in companies)
                {
                    cbCompanies.Items.Add(item.nvcName);
                }
                cbCompanies.SelectedItem = technicalDocuments.tabCompanies.nvcName;

                var locationes = db.Locations.GetAll();
                foreach (var item in locationes)
                {
                    cbLocations.Items.Add(item.nvcName);
                }
                cbLocations.SelectedItem = technicalDocuments.tabLocationes.nvcName;

                var categories = db.Categories.GetAll();
                foreach (var item in categories)
                {
                    cbCategories.Items.Add(item.nvcName);
                }
                cbCategories.SelectedItem = technicalDocuments.tabCategories.nvcName;

                tbCoDesigner.Text = technicalDocuments.nvcCoDesigner;
                tbDesignerName.Text = technicalDocuments.nvcPersonDesigner;
                tbRevisionNumber.Text = technicalDocuments.nvcRevisionNumber;

                var technicalDocumentTypes = db.TechnicalDocumentTypes.GetAll();
                foreach (var item in technicalDocumentTypes)
                {
                    cbType.Items.Add(item.nvcName);
                }
                cbType.SelectedItem = technicalDocuments.tabTechnicalDocumentTypes.nvcName;
            }
        }

        private void btmOK_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db=new UnitOfWork())
            {
                var companyId = db.Companies.GetEntityByName(t => t.nvcName == cbCompanies.SelectedItem).intNumber;
                var locationId = db.Locations.GetEntityByName(t => t.nvcName == cbLocations.SelectedItem).intNumber;
                var categoryId = db.Categories.GetEntityByName(t => t.nvcName == cbCategories.SelectedItem).intNumber;
                var typeId = db.TechnicalDocumentTypes.GetEntityByName(t => t.nvcName == cbType.SelectedItem).intNumber;
                var coDesigner = tbCoDesigner.Text.Trim();
                var designerName = tbDesignerName.Text.Trim();
                var revisionNumber = tbRevisionNumber.Text.Trim();
                var technicalDocuments = db.TechnicalDocuments.GetEntity(t => t.intID == technicalDocumentId);
                technicalDocuments.intID = technicalDocumentId;
                technicalDocuments.bitSelect = false;
                technicalDocuments.intCompany = companyId;
                technicalDocuments.intLocation = locationId;
                technicalDocuments.intCategory = categoryId;
                technicalDocuments.intType = typeId;
                technicalDocuments.intOrder = technicalDocuments.intOrder;
                technicalDocuments.nvcCoDesigner = coDesigner;
                technicalDocuments.nvcPersonDesigner = designerName;
                technicalDocuments.nvcRevisionNumber = revisionNumber;
                db.TechnicalDocuments.Update(technicalDocuments);
                db.Save();
                this.Close();
                DialogResult = DialogResult.OK;
            }
        }

        private void btmCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
