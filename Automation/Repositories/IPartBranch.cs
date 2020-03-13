using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;


namespace Baran.Ferroalloy.Automation
{
    public interface IPartBranch : IGeneric<tabPartBranch>
    {
        List<tabPartBranch> ListBranches(int nameId, string filter = "");
    }
}
