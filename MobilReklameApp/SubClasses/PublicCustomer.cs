using System;
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
        
        private string _ean;

        public PublicCustomer(string firstName, string lastName, string address, string phone, string email, string ean)
            : base(firstName, lastName, address, phone, email)
        {
            
            _ean = ean;
        }

        public string EAN
        {
            get { return _ean; }
        }
    }
}
