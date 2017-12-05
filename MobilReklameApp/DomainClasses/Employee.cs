using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    class Employee : DomainClassBase
    {
        private string _name;
        private string _phoneNumber;
        private string _id;

        public Employee(string name, string phoneNumber)
        {
            _name = name;
            _phoneNumber = phoneNumber;
            
        }

        public override string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public string ID
        {
            get { return _id; }
        }

    


    }
}
