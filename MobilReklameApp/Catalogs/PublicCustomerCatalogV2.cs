using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.Catalogs
{
    class PublicCustomerCatalog : CatalogBase<PublicCustomer>
    {
        
        private Dictionary<string, PublicCustomer> _customers;
        private static PublicCustomerCatalog _singletonInstance;

        

        public PublicCustomerCatalog()
        {
            _customers = new Dictionary<string, PublicCustomer>();
            _customers.Add("Lars", new PublicCustomer("Lars", "Larsen", "LarsenVej", "Larsen mobil", "LarsenMail", "EAN"));
            _customers.Add("Lars", new PublicCustomer("Lars", "Larsen", "LarsenVej", "Larsen mobil", "LarsenMail", "EAN"));
            _customers.Add("Lars", new PublicCustomer("Lars", "Larsen", "LarsenVej", "Larsen mobil", "LarsenMail", "EAN"));

         

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
