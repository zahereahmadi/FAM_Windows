using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baran.Ferroalloy.Automation.Models;

namespace Baran.Ferroalloy.Automation
{
    public class EmployeesService : Generic<tabEmployees>, IEmployees
    {
        private dbAfrzEntities db = new dbAfrzEntities();
        public EmployeesService(DbContext db) : base(db)
        {
        }

        public IEnumerable<tabEmployees> FilterSelectEmployee(string coId = "", string department = "", string lastName = "", string firstName = "")
        {
            return db.tabEmployees.ToList().Where(t =>
                t.nvcCoID.Equals(coId) || t.tabDepartments.nvcName.Equals(department) ||
                t.nvcLastname.Equals(lastName) || t.nvcFirstname.Equals(firstName));
        }

        public List<SelectEmployeeViewModel> SelectEmployeeByFilter(IEnumerable<tabEmployees> listEmployees)
        {
            List<SelectEmployeeViewModel> list=new List<SelectEmployeeViewModel>();
            foreach (var item in listEmployees)
            {
                list.Add(new SelectEmployeeViewModel()
                {
                    intID = item.intID,
                    nvcFirstName = item.nvcFirstname,
                    nvcLastName = item.nvcLastname,
                    departmentTilte = item.tabDepartments.nvcName,
                    nvcNationalID = item.nvcNationalID,
                    nvcCoID = item.nvcCoID

                });
            }

            return list;
        }
    }
}
