using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    class Customer : DomainClassBase
    {
        private string _firstName;
        private string _lastName;
        private string _adress;
        private string _phone;
        private string _email;


        public Customer(string firstName, string lastName, string adress, string phone, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _adress = adress;
            _phone = phone;
            _email = email;

            Id = phone;

        }



        public string FirstName
        {
            get { return _firstName; }
        }

        public string LastName
        {
            get { return _lastName; }
        }

        public string Adress
        {
            get { return _adress; }
        }

        public string Phone
        {
            get { return _phone; }
        }

        public string Email
        {
            get { return _email; }
        }

        public override string Id { get; set; }
    }
}
