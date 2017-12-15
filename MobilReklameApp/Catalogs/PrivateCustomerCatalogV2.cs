﻿using System;
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
        private Dictionary<string, PrivateCustomer> _customers;
        private static PrivateCustomerCatalog _singletonInstance = new PrivateCustomerCatalog();
        //private CreatePrivateCustomerCommand _createPrivateCustomerCommand;
        private PrivateCustomer _privateCustomer;

       private ObservableCollection<PrivateCustomer> _collection;


        private PrivateCustomerCatalog()
        {
            _customers = new Dictionary<string, PrivateCustomer>();
            _privateCustomer = new PrivateCustomer();

            _collection = new ObservableCollection<PrivateCustomer>();



        }
        public ObservableCollection<PrivateCustomer> ListAll
        {
            get
            {
                foreach (PrivateCustomer customer in _customers.Values)
                {
                    if (_collection.Contains(customer) == false)
                    {
                        _collection.Add(customer);
                    }
                }
                return _collection;
            }
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
               // if (_singletonInstance != null) return _singletonInstance;
               // _singletonInstance = new PrivateCustomerCatalog();
                return _singletonInstance;
            }
        }
    }
}
