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
        private readonly Dictionary<int, Order> _orders;
        private static OrderCatalog _singletonInstance = new OrderCatalog();

        private OrderCatalog()
        {
            _orders = new Dictionary<int, Order>();
            _orders.Add(1,new Order(
                Order.OrderStatus.Afventer, "Ordrer beskrivelse","Produkt type", "Produkt materiale"));
            _orders.Add(2,new Order(
                Order.OrderStatus.Afventer, "Ordrer beskrivelse", "Produkt type", "Produkt materiale"));
            _orders.Add(3, new Order(
                Order.OrderStatus.Afventer, "Ordrer beskrivelse", "Produkt type", "Produkt materiale"));
        }

        public List<Order> ListAll => _orders.Values.ToList();

        public void AddO(Order order)
        {
            _orders.Add(order.OrderNumber, order);
        }
        
        public static OrderCatalog SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new OrderCatalog();
                return _singletonInstance;
            }
        }
    }
}
