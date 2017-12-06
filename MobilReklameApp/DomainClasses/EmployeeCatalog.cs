using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    class EmployeeCatalog : CatalogBase<Employee>
    {
        private Dictionary<int, Employee> _employees;

        public EmployeeCatalog()
        {
            _employees = new Dictionary<int, Employee>();

            Add(new Employee("Jan","23414823", "", "", ""));
            Add(new Employee("Daniel", "23414823", "", "", ""));
            Add(new Employee("Thomas", "23414823", "", "", ""));
        }
    }
}
