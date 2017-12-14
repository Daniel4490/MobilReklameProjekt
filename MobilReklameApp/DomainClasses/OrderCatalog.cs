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
        private static OrderCatalog _singletonInstance = new OrderCatalog();

        private OrderCatalog()
        {
            _orders = new Dictionary<int, Order>();
            _orders.Add(1,new Order(Order.OrderStatus.Afventer, "Ordrebeskrivelse","Produkttype", "Produktmateriale"));
            _orders.Add(2,new Order(Order.OrderStatus.Afventer, "Ordrer beskrivelse", "Produkt type", "Produkt materiale"));
            _orders.Add(3, new Order(Order.OrderStatus.Afventer, "Ordrer beskrivelse", "Produkt type", "Produkt materiale"));
        }

        public List<Order> ListAll
        {
            get { return _orders.Values.ToList(); }
        }

        public void AddO(Order order)
        {
            _orders.Add(order.OrderNumber, order);
        }

        //The following insures that this catalog becomes a singleton
        //along with the "_singletonInstance" instance field at the top
        public static OrderCatalog SingletonInstance
        {
            get
            {
                return _singletonInstance;
            }
        }


    }
}
