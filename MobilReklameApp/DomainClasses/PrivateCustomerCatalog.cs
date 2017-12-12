using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.DomainClasses
{
    class PrivateCustomerCatalog : CatalogBase<PrivateCustomer>
    {
        private Dictionary<string, PrivateCustomer> _customers;
        private static PrivateCustomerCatalog _singletonInstance;

        public PrivateCustomerCatalog()
        {

            _customers = new Dictionary<string, PrivateCustomer>();
            _customers.Add("Lars", new PrivateCustomer("Lars", "Larsen", "LarsenVej","Larsen phone", "LarsenMail"));
            _customers.Add("Lars", new PrivateCustomer("Lars", "Larsen", "LarsenVej", "Larsen phone", "LarsenMail"));
            _customers.Add("Lars", new PrivateCustomer("Lars", "Larsen", "LarsenVej", "Larsen phone", "LarsenMail"));


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
        public static PrivateCustomerCatalog SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new PrivateCustomerCatalog();
                return _singletonInstance;
            }
        }
    }
}
