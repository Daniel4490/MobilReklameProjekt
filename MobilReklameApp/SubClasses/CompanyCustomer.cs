using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Certificates;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.DomainClasses;

namespace MobilReklameApp.SubClasses
{
    class CompanyCustomer : PeopleBase
    {
        private string _cvr;

        public CompanyCustomer(string cvr, string firstName, string lastName, string address, string phone, string email)
            : base(firstName, lastName, address, phone, email)
        {
            _cvr = cvr;
        }

        public string Cvr
        {
            get { return _cvr; }
           // set { _cvr = value; }
        }
      


    }
}
