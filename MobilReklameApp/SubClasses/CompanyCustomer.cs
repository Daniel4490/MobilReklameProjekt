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
        private string _companyName;
        private string _att;

        public CompanyCustomer()

        {

        }

        public string CVR
        {
            get { return _cvr; }
            set { _cvr = value; }
        }

        public string CompanyName
        {
            get { return _companyName; }
            set { _companyName = value; }
        }

        public string Att
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public override string ToString()
        {
            return $"{CompanyName} {CVR} {Phone} {Email}";
        }


    }
}
