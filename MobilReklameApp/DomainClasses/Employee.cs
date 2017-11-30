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
        private int _phoneNumber;
        private int _id;

        public Employee(string Name, int PhoneNumber, int ID)
        {
            _name = Name;
            _phoneNumber = PhoneNumber;
            _id = ID;
        }

        public override int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
        }

        public int PhoneNumber
        {
            get { return _phoneNumber; }
        }

        public int ID
        {
            get { return _id; }
        }

    


    }
}
