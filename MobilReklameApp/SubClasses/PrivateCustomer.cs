using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.DomainClasses;

namespace MobilReklameApp.SubClasses
{
    public class PrivateCustomer : PeopleBase
    {
        public PrivateCustomer()
            
        {
            
        }

        

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Address} {Phone} {Email}";
        }
    }
}
