using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.DomainClasses
{
    class Order
    {
        private string _ordreBeskrivelse;
        private int _ordreDato;
        private string _ordreLeveringsDato;
        private int _ordreNummer;
        private string _produktType;
        private string _ordreStatus;


        public Order()
        {
            _ordreBeskrivelse = OrdreBeskrivelse;
            _ordreDato = OrdreDato;
            _ordreLeveringsDato = OrdreLeveringsDato;
            _ordreNummer = OrdreNummer;
            _produktType = ProduktType;
            _ordreStatus = OrdreStatus;

        }

    public string OrdreBeskrivelse
    {
        get { return _ordreBeskrivelse; }
        
    }

    public string OrdreBeskrivelse
        {
            get { return _ordreBeskrivelse; }

        }

    public string OrdreBeskrivelse
        {
            get { return _ordreBeskrivelse; }

        }
    }
