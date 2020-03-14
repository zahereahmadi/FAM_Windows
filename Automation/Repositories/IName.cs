using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public interface IPartName : IGeneric<tabPartName>
    {
        List<tabPartName> ListNames(int categoryId,string filter = "");
    }
}
