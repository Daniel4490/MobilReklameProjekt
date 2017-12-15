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
        private ObservableCollection<CompanyCustomer> _customerCollection;
        private static CompanyCustomerCatalog _singletonInstance;

        public CompanyCustomerCatalog()
        {
            _customers = new Dictionary<string, CompanyCustomer>();
            _customerCollection = new ObservableCollection<CompanyCustomer>();

            foreach (CompanyCustomer companyCustomer in _customers.Values)
            {
                if (_customerCollection.Contains(companyCustomer) == false)
                {
                    _customerCollection.Add(companyCustomer);
                }
            }
        }

        public ObservableCollection<CompanyCustomer> listAll
        {
            get { return _customerCollection; }
        }

        public void Add(CompanyCustomer customer)
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





