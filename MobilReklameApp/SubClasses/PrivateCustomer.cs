using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.DomainClasses;

namespace MobilReklameApp.SubClasses
{
    class PrivateCustomer : PeopleBase
    {
      
     

        public PrivateCustomer(string firstName, string lastName, string email, string address, string phone 
            ) : base (firstName, lastName, address, email, phone)

        {
            




        }
    }
}
