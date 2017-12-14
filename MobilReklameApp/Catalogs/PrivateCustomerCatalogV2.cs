using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.CommandClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.DomainClasses
{
    class PrivateCustomerCatalog : CatalogBase<PrivateCustomer>
    {
        private Dictionary<string, PrivateCustomer> _customers;
        private static PrivateCustomerCatalog _singletonInstance = new PrivateCustomerCatalog();
        //private CreatePrivateCustomerCommand _createPrivateCustomerCommand;
        private PrivateCustomer _privateCustomer;

        private PrivateCustomerCatalog()
        {
            _customers = new Dictionary<string, PrivateCustomer>();
        }
        public List<PrivateCustomer> ListAll
        {
            get { return _customers.Values.ToList(); }
        }

        public void Add(PrivateCustomer customer)
        {
            _customers.Add(customer.ID, customer);
        }

        //The following insures that this catalog becomes a singleton
        //along with the "_singletonInstance" instance field at the top
        public static PrivateCustomerCatalog SingletonInstance
        {
            get
            {
               // if (_singletonInstance != null) return _singletonInstance;
               // _singletonInstance = new PrivateCustomerCatalog();
                return _singletonInstance;
            }
        }
    }
}
