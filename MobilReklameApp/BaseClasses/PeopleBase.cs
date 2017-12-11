using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;


namespace MobilReklameApp.BaseClasses
{
   public abstract class PeopleBase
   {
        private string _firstName;
        private string _lastName;
        private string _address;
        private string _phone;
        private string _email;
 
        protected PeopleBase(string firstName, string lastName, string address, string phone, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address = address;
            _phone = phone;
            _email = email;           
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

        //creates a unique ID based on the first two initials in firstname, 
        //first two initials in lastname,
        //the last four digitals in the phonenumber
        //and lastly combines them back into a string

        //public string ID
        //{
        //    get
        //    {
        //        char[] firstNameArray = _firstName.ToCharArray();
        //        char[] lastNameArray = _lastName.ToCharArray();
        //        char[] phoneArray = _phone.ToCharArray();
        //        StringBuilder iDStringBuilder = new StringBuilder(
        //            firstNameArray[0] +
        //            firstNameArray[1] +
        //            lastNameArray[0] +
        //            lastNameArray[1] +
        //            phoneArray[4] +
        //            phoneArray[5] +
        //            phoneArray[6] +
        //            phoneArray[7]);
        //        string iDString = iDStringBuilder.ToString();
        //        return iDString;
        //
        //    }
        //
        //}


    }

}
