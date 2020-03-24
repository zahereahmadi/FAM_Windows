using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class TechnicalDocumentsService : Generic<tabTechnicalDocuments>, ITechnicalDocuments
    {
        dbAfrzEntities db = new dbAfrzEntities();
        public TechnicalDocumentsService(DbContext db) : base(db)
        {
        }

        public List<tabTechnicalDocuments> FilterTechnicalDocumentItems(object company, object location, object category, object type, object coDesinger,
            object designerName, object revisionNumber)
        {
            var technicalDocuments = db.tabTechnicalDocuments.ToList().Where(t =>
                t.tabCompanies.nvcName.Equals(company) || t.tabLocationes.nvcName.Equals(location) ||
                t.tabCategories.nvcName.Equals(category) || t.tabTechnicalDocumentTypes.nvcName.Equals(type) || t.nvcCoDesigner.Equals(coDesinger) ||
                t.nvcPersonDesigner.Equals(designerName) || t.nvcRevisionNumber.Equals(revisionNumber));
            return technicalDocuments.ToList();
        }

        public List<dgvTechnicalDocumentsViewModel> FilldgvTechnicalDocuments(List<tabTechnicalDocuments> listtTechnicalDocuments)
        {
            List<dgvTechnicalDocumentsViewModel> models = new List<dgvTechnicalDocumentsViewModel>();
            foreach (var item in listtTechnicalDocuments)
            {
                models.Add(new dgvTechnicalDocumentsViewModel()
                {
                    intID = item.intID,
                    CompanyName = item.tabCompanies.nvcName,
                    LocationName = item.tabLocationes.nvcName,
                    CategoryName = item.tabCategories.nvcName,
                    Type = item.tabTechnicalDocumentTypes.nvcName,
                    Order=item.intOrder,
                    CoDesigner = item.nvcCoDesigner,
                    PersonDesigner = item.nvcPersonDesigner,
                    RevisionNumber = item.nvcRevisionNumber
                });
            }

            return models;
        }
    }
}
