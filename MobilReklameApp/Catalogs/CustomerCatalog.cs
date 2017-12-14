using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.Catalogs
{
    class CustomerCatalog : CatalogBase<PrivateCustomer>
    {
        private Dictionary<string, PrivateCustomer> _customers;
        private static CustomerCatalog _singletonInstance;

        public CustomerCatalog()
        {

        }
        public List<PrivateCustomer> listAll
        {
            get { return _customers.Values.ToList(); }
        }

        public void Add(PrivateCustomer customer)
        {
            _customers.Add(customer.ID, customer);
        }

        //The following insures that this catalog becomes a singleton
        //along with the "_singletonInstance" instance field at the top
        public static CustomerCatalog SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new CustomerCatalog();
                return _singletonInstance;
            }
        }
    }
}
