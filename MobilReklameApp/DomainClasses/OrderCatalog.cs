using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.DomainClasses
{
    class OrderCatalog
    {

        private string _memberName;

        public OrderCatalog(string MemberName)
        {
            _memberName = MemberName;
        }


        public string MemberName
        {
            get { return _memberName; }
        }




    }
}
