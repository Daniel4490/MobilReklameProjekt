using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    public class OrderCatalog : CatalogBase<Ordre>
    {

        private Dictionary<string, Ordre> _orders;

        public OrderCatalog()
        {
            _orders = new Dictionary<string, Ordre>();
            Add(new Ordre("Ordre beskrivelse", 05, 06, "Ordrenummer", "Produkttype", "Ordrestatus", "produkt materiale") );
        }

        public List<Ordre> listAll
        {
            get { return _orders.Values.ToList(); }
        }

        public void Add(Ordre ordre)
        {
            _orders.Add(ordre.Id, ordre);
        }




    }
}
