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

            Add(new Employee("Jan","Sidstenavn", "Somethingvej 1", "23414823", "Jan@mobilreklame.dk"));
            Add(new Employee("Daniel", "23414823", "Somethingvej 2", "23414824", "Daniel@mobilreklame.dk"));
            Add(new Employee("Thomas", "23414823", "Somethingvej 3", "23414825", "Thomas@mobilreklame.dk"));

            
        }
    }
}
