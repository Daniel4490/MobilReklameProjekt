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
        public string PublicName { get; set; }

        public string EAN { get; set; }

        public override string ToString()
        {
            return $"{PublicName} {EAN} {Phone} {Email}";
        }
    }
}
