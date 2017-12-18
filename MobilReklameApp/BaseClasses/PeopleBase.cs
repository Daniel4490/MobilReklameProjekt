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
       protected PeopleBase()
       {
            ID = Phone;
       }

        public string FirstName { get; set; }

       public string LastName { get; set; }

       public string Address { get; set; }

       public string Phone { get; set; }

       public string Email { get; set; }

       public string ID
       {
           get => Phone;
           set => Phone = value;
       }
   }
}
