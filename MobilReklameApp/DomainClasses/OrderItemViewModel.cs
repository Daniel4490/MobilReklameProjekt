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

        public OrderItemViewModel()
        {
            _orders = new ObservableCollection<Order>();

            _orders.Add(new Order(Order.OrderStatus.Igangværende, "Ordre beskrivelse", DateTime.Today, DateTime.Today, "Produkt type", "Produkt Materiale"));
            _orders.Add(new Order(Order.OrderStatus.Igangværende, "Ordre beskrivelse", DateTime.Today, DateTime.Today, "Produkt type", "Produkt Materiale"));
            _orders.Add(new Order(Order.OrderStatus.Igangværende, "Ordre beskrivelse", DateTime.Today, DateTime.Today, "Produkt type", "Produkt Materiale"));

            _selectedOrder = _orders[0];
        }

        public ObservableCollection<Order> Orders
        {
            get { return _orders; }
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