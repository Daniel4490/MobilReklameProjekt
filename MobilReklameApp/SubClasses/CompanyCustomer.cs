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
    public class CompanyCustomer : PeopleBase
    {
        public string CVR { get; set; }

        public string CompanyName { get; set; }

        public string Att => $"{FirstName} {LastName}";

        public override string ToString()
        {
            return $"{CompanyName} {CVR} {Phone} {Email}";
        }


    }
}
