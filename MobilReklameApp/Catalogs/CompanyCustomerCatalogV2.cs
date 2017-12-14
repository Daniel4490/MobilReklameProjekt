using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.Catalogs
{
    class CompanyCustomerCatalog : CatalogBase<CompanyCustomer>
    {
        private Dictionary<string, CompanyCustomer> _customers;
        private static CompanyCustomerCatalog _singletonInstance;

        public CompanyCustomerCatalog()
        {

            _customers = new Dictionary<string, CompanyCustomer>();
            _customers.Add("Customer1", new CompanyCustomer("CVR", "FirstName", "LastName", "Address", "Phone", "Mail"));
            _customers.Add("Customer1", new CompanyCustomer("CVR", "FirstName", "LastName", "Address", "Phone", "Mail"));
            _customers.Add("Customer1", new CompanyCustomer("CVR", "FirstName", "LastName", "Address", "Phone", "Mail"));


        }
        public List<CompanyCustomer> listAll
        {
            get { return _customers.Values.ToList(); }
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





