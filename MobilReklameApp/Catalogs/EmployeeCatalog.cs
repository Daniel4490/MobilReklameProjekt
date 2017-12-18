using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    internal class EmployeeCatalog : CatalogBase<Employee>
    {
        private Dictionary<int, Employee> _employees;
        private static EmployeeCatalog _singletonInstance;

        public EmployeeCatalog()
        {
            _employees = new Dictionary<int, Employee>();    
        }
        
        public static EmployeeCatalog SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new EmployeeCatalog();
                return _singletonInstance;
            }
        }
    }
}
