using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.DomainClasses
{
    class Ordre
    {
        public enum OrdreStatus
        {
            Afventer,
            Accepteret,
            Anulleret,
            Igangværende,
            Færdig,
            Leveret
        }

        

        private string _ordreBeskrivelse;
        private int _ordreDato;
        private int _ordreLeveringsDato;
        private int _ordreNummer;
        private string _produktType;
        public OrdreStatus _ordreStatus;
        private string _produktMateriale;

        

        public Ordre(OrdreStatus ordreStatus, string ordreBeskrivelse, int ordreDato, int ordreLeveringsDato, int ordreNummer,
            string produktType, string produktMateriale)
        {
            _ordreBeskrivelse = ordreBeskrivelse;
            _ordreDato = ordreDato;
            _ordreLeveringsDato = ordreLeveringsDato;
            _ordreNummer = ordreNummer;
            _produktType = produktType;
            _ordreStatus = ordreStatus;
            _produktMateriale = produktMateriale;

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

        public string EnummOrdreStatus
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
