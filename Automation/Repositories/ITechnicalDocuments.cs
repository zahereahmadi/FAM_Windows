using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public interface ITechnicalDocuments:IGeneric<tabTechnicalDocuments>
    {
        List<tabTechnicalDocuments> FilterTechnicalDocumentItems(object company, object location, object category,
            object type, object coDesinger, object designerName, object revisionNumber);

        List<dgvTechnicalDocumentsViewModel> FilldgvTechnicalDocuments(
            List<tabTechnicalDocuments> listtTechnicalDocuments);
    }
}
