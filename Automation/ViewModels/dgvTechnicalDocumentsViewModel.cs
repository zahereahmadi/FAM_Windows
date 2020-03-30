using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Automation
{
    public class dgvTechnicalDocumentsViewModel
    {
        public int intID { get; set; }
        public string CompanyName { get; set; }
        public string LocationName { get; set; }
        public string CategoryName { get; set; }
        public string Type { get; set; }
        public int? Order { get; set; }
        public string CoDesigner { get; set; }
        public string PersonDesigner { get; set; }
        public string RevisionNumber { get; set; }
    }
}
