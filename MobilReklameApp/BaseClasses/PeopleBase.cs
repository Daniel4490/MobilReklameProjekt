using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;


namespace MobilReklameApp.BaseClasses
{
    class PeopleBase
    {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phone;
        private string _email;
        

        public PeopleBase(string firstName, string lastName, string adress, string phone, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = adress;
            _phone = phone;
            _email = email;
        }

        public PeopleBase()
        {
            //parameterless constructor nessecarry for inheritance
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

        public string ID
        {
            get { return _phone; }
        }
        
    }
}
