using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    public class OrderCatalog : CatalogBase<Order>
    {

        private Dictionary<int, Order> _orders;

        public OrderCatalog()
        {
            _orders = new Dictionary<int, Order>();
            Add(new Order("Ordre beskrivelse", DateTime.Today, DateTime.Today, "Produkt type", "Produkt Materiale") );
        }

        public List<Order> listAll
        {
            get { return _orders.Values.ToList(); }
        }

        public void Add(Order order)
        {
            _orders.Add(order.OrderNumber, order);
        }




    }
}
