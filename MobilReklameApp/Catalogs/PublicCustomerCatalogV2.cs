using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.DomainClasses
{
    internal class PublicCustomerCatalog : CatalogBase<PublicCustomer>
    {
        
        private readonly Dictionary<string, PublicCustomer> _customers;
        private static PublicCustomerCatalog _singletonInstance;
        private readonly ObservableCollection<PublicCustomer> _collection;

        public PublicCustomerCatalog()
        {
            _customers = new Dictionary<string, PublicCustomer>();
            _collection = new ObservableCollection<PublicCustomer>();

        }

        public ObservableCollection<PublicCustomer> ListAll
        {
            get
            {
                _collection.Clear();
                foreach (PublicCustomer customer in _customers.Values)
                {
                    _collection.Add(customer);
                }
                return _collection;
            }
        }

        public Dictionary<string, PublicCustomer> Customers => _customers;

        public void AddCustomer(PublicCustomer customer)
        {
            _customers.Add(customer.ID, customer);
        }

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
