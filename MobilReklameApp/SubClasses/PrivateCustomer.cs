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
        public PrivateCustomer(string firstName, string lastName, string adress, string phone, string email)
            : base(firstName, lastName, adress, phone, email)
        {
            
        }

        
    }
}
