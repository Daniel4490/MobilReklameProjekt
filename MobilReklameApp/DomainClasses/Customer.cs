using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Security.Cryptography.Core;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    class Customer : DomainClassBase
    {

        private string _adresse;
        private string _tlf;
        private string _mail;


        public Customer(string adresse, string telefon, string mail)
        {
            _adresse = adresse;
            _tlf = telefon;
            _mail = mail;
            Id = _tlf;
        }

        public string Adresse
        {
            get { return _adresse; }
        }

        public string Telefon
        {
            get { return _tlf; }
        }

        public string Mail
        {
            get { return _mail; }
        }

        public override string Id { get; set; }
    }
}
