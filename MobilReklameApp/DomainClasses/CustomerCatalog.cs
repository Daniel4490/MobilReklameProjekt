using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    class CustomerCatalog : CatalogBase<Customer>
    {
        private Dictionary<string, Customer> _customers;

        public CustomerCatalog()
        {
            
        }
        public List<Customer> listAll
        {
            get { return _customers.Values.ToList(); }
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer.Id, customer);
        }



    }
}
