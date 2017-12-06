using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    class Employee : PeopleBase
    {


        public Employee(string firstName, string lastName, string address, string phone, string email)
            : base(firstName, lastName, address, phone, email)
        {
            
        }
        
    }
}
