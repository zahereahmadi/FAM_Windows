using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Automation
{
    public class DgvSubProjectsViewModel
    {
        public int intID { get; set; }
        //public int projectNumber { get; set; }
        public string categoryName { get; set; }
        public string name { get; set; }
        public string datStart { get; set; }
        public int duration { get; set; }
        public int progress { get; set; }
        public string tip { get; set; }
    }
}
