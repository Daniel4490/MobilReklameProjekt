using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.DomainClasses
{
    class CustomerCatalog : CatalogBase<PrivateCustomer>
    {
        private Dictionary<string, PrivateCustomer> _customers;

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
    }
}
