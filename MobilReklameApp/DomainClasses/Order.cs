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
        private int _ordreLeveringsDato;
        private int _ordreNummer;
        private string _produktType;
        private string _ordreStatus;
        private string _produktMateriale;



        public Order(string OrdreBeskrivelse, int OrdreDato, int OrdreLeveringsDato, int OrdreNummer,
            string ProduktType, string OrdreStatus, string ProduktMateriale)
        {
            _ordreBeskrivelse = OrdreBeskrivelse;
            _ordreDato = OrdreDato;
            _ordreLeveringsDato = OrdreLeveringsDato;
            _ordreNummer = OrdreNummer;
            _produktType = ProduktType;
            _ordreStatus = OrdreStatus;
            _produktMateriale = ProduktMateriale;

        }

        public class EnumOrder
        {
            enum OrdreStatus
            {
                Afventer,
                Accepteret,
                Anulleret,
                Igangværende,
                Færdig,
                Leveret
            }

            static void Main()
            {
                int x = (int)OrdreStatus.Afventer;
            }


        }
      

        public string OrdreBeskrivelse
        {
            get { return _ordreBeskrivelse; }

        }

        public int OrdreDato
        {
            get { return _ordreDato; }

        }

        public int OrdreLeveringsDato
        {
            get { return _ordreLeveringsDato; }

        }

        public int OrdreNummer
        {
            get { return _ordreNummer; }
        }

        public string OrdreStatus
        {
            get { return _ordreStatus; }
        }

        public string ProduktType
        {
            get { return _produktType; }
        }

        public string ProduktMateriale
        {
            get { return _produktMateriale; }
        }

    }
}
