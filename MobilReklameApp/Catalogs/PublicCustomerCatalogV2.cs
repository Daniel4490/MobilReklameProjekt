using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.DomainClasses
{
    class PublicCustomerCatalog : CatalogBase<PublicCustomer>
    {
        
        private Dictionary<string, PublicCustomer> _customers;
        private static PublicCustomerCatalog _singletonInstance;

        

        public PublicCustomerCatalog()
        {
            _customers = new Dictionary<string, PublicCustomer>();

        }

        public List<PublicCustomer> listAll
        {
            get { return _customers.Values.ToList(); }
        }


        public void Add(PublicCustomer customer)
        {
            _customers.Add(customer.ID, customer);
        }

        //The following insures that this catalog becomes a singleton
        //along with the "_singletonInstance" instance field at the top
        public static PublicCustomerCatalog SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new PublicCustomerCatalog();
                return _singletonInstance;
            }
        }

    }
}
