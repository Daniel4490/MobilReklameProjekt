using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.DomainClasses;

namespace MobilReklameApp.SubClasses
{
    public class PublicCustomer : PeopleBase
    {

        private string _ean;
        private string _PublicName;

        public PublicCustomer()
            
        {
                
        }

        public string PublicName
        {
            get { return _PublicName; }
            set { _PublicName = value; }
        }

        public string EAN
        {
            get { return _ean; }
            set { _ean = value; }
        }

        public override string ToString()
        {
            return $"{PublicName} {EAN} {Phone} {Email}";
        }
    }
}
