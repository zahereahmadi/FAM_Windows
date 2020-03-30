using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public interface IEmployees:IGeneric<tabEmployees>
    {
        IEnumerable<tabEmployees> FilterSelectEmployee(string coId="", string department = "", string lastName = "", string firstName = "");

        List<SelectEmployeeViewModel> SelectEmployeeByFilter(IEnumerable<tabEmployees> listEmployees);
    }
}
