using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    public class Ordre : DomainClassBase
    {
        private string _ordreBeskrivelse;
        private int _ordreDato;
        private int _ordreLeveringsDato;
        private string _ordreNummer;
        private string _produktType;
        private string _ordreStatus;
        private string _produktMateriale;



        public Ordre(string ordreBeskrivelse, int ordreDato, int ordreLeveringsDato, string ordreNummer,
            string produktType, string ordreStatus, string produktMateriale)
        {
            _ordreBeskrivelse = ordreBeskrivelse;
            _ordreDato = ordreDato;
            _ordreLeveringsDato = ordreLeveringsDato;
            _ordreNummer = ordreNummer;
            _produktType = produktType;
            _ordreStatus = ordreStatus;
            _produktMateriale = produktMateriale;

            Id = _ordreNummer;
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

        public string OrdreNummer
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

        public override string Id { get; set; }
    }


}
