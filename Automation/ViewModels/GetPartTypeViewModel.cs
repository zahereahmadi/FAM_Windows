using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baran.Ferroalloy.Automation
{
    public class GetPartTypeViewModel
    {
        public int StoreId { get; set; }
        public int CategoryId { get; set; }
        public int PartNameId { get; set; }
        public int PartBranchId { get; set; }
        public int PartSubBranchId { get; set; }
        public int? Order { get; set; }
    }
}
