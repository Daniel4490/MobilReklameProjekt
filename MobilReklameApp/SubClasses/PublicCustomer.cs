﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.DomainClasses;

namespace MobilReklameApp.SubClasses
{
    class PublicCustomer : PeopleBase
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phone;
        private string _email;
        private string _ean;

        public PublicCustomer(string firstName, string lastName, string adress, string phone, string email, string ean)
            : base(firstName, lastName, adress, phone, email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = adress;
            _phone = phone;
            _email = email;
            _ean = ean;
        }



        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public string Address
        {
            get { return _address; }
        }

        public string Phone
        {
            get { return _phone; }
        }

        public string Email
        {
            get { return _email; }
        }

        public string EAN
        {
            get { return _ean; }
        }
    }
}
