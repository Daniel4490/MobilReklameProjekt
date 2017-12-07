using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;

namespace MobilReklameApp.DomainClasses
{
    public class OrderItemViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Order> _orders;
        private Order _selectedOrder;
        private ObservableCollection<Order.OrderStatus> _orderStatuses;
        private Order.OrderStatus _selectedStatus;

        public OrderItemViewModel()
        {
            _orders = new ObservableCollection<Order>();
            _orderStatuses = new ObservableCollection<Order.OrderStatus>();

            _orders.Add(new Order(Order.OrderStatus.Afventer, "Ordrer beskrivelse", "Produkt type", "Produkt materiale"));
            _orders.Add(new Order(Order.OrderStatus.Accepteret, "Ordrer beskrivelse", "Produkt type", "Produkt materiale"));
            _orders.Add(new Order(Order.OrderStatus.Anulleret, "Ordrer beskrivelse", "Produkt type", "Produkt materiale"));

            _orderStatuses.Add(Order.OrderStatus.Afventer);
            _orderStatuses.Add(Order.OrderStatus.Accepteret);
            _orderStatuses.Add(Order.OrderStatus.Anulleret);
            _orderStatuses.Add(Order.OrderStatus.Færdig);
            _orderStatuses.Add(Order.OrderStatus.Igangværende);
            _orderStatuses.Add(Order.OrderStatus.Leveret);

            _selectedOrder = _orders[0];
        }

        public ObservableCollection<Order> Orders
        {
            get { return _orders; }
        }

        public ObservableCollection<Order.OrderStatus> OrderStatuses
        {
            get { return _orderStatuses; }
            
        }

        public Order.OrderStatus SelectedStatus
        {
            get { return _selectedStatus; }
            set
            {
                _selectedStatus = value;
                _selectedOrder.EnummOrderStatus = value;
                OnPropertyChanged();

            }
        }

        public Order SelectedOrder
        {
            get { return _selectedOrder; }
            set
            {
                _selectedOrder = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}