using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Core;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.DomainClasses
{
    class CompanyCustomerCatalog : CatalogBase<CompanyCustomer>
    {
        private Dictionary<string, CompanyCustomer> _customers;
        private static CompanyCustomerCatalog _singletonInstance;
        private ObservableCollection<CompanyCustomer> _collection;

        public CompanyCustomerCatalog()
        {
            _customers = new Dictionary<string, CompanyCustomer>();

            _collection = new ObservableCollection<CompanyCustomer>();


        }

        public ObservableCollection<CompanyCustomer> ListAll
        {
            get
            {
                _collection.Clear();
                foreach (CompanyCustomer customer in _customers.Values)
                {
                    _collection.Add(customer);
                }
                return _collection;
            }
        }

        public Dictionary<string, CompanyCustomer> Customers
        {
            get { return _customers; }
        }


        public void AddCustomer(CompanyCustomer customer)
        {
            _customers.Add(customer.ID, customer);
        }

        //The following insures that this catalog becomes a singleton
        //along with the "_singletonInstance" instance field at the top
        public static CompanyCustomerCatalog SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new CompanyCustomerCatalog();
                return _singletonInstance;
            }
        }
    }
}





