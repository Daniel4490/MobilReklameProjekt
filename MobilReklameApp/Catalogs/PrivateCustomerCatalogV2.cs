using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.CommandClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.DomainClasses
{
   public class PrivateCustomerCatalog : CatalogBase<PrivateCustomer>
   {
        private readonly Dictionary<string, PrivateCustomer> _customers;
        private static PrivateCustomerCatalog _singletonInstance = new PrivateCustomerCatalog();
        private readonly ObservableCollection<PrivateCustomer> _collection;

        public PrivateCustomerCatalog()
        {
            _customers = new Dictionary<string, PrivateCustomer>();
            _collection = new ObservableCollection<PrivateCustomer>();
        }
        public ObservableCollection<PrivateCustomer> ListAll
        {
            get
            {
                _collection.Clear();
                foreach (PrivateCustomer customer in _customers.Values)
                {
                    _collection.Add(customer);
                }
                return _collection;
            }
        }

       public Dictionary<string, PrivateCustomer> Customers => _customers;


       public void AddCustomer(PrivateCustomer customer)
       {
            _customers.Add(customer.ID, customer);
       }

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
