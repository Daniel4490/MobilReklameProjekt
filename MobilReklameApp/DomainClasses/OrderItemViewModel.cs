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
        private ObservableCollection<Ordre> _orders;
        private Ordre _selectedOrder;

        public OrderItemViewModel()
        {
            _orders = new ObservableCollection<Ordre>();

            _orders.Add(new Ordre("Ordre beskrivelse 1", 12, 06, "Ordrenummer", "Produkttype", "Ordrestatu  s", "produkt materiale"));
            _orders.Add(new Ordre("Ordre beskrivelse 2", 10, 06, "Ordrenummer", "Produkttype", "Ordrestatus", "produkt materiale"));
            _orders.Add(new Ordre("Ordre beskrivelse 3", 03, 09, "Ordrenummer", "Produkttype", "Ordrestatus", "produkt materiale"));

            _selectedOrder = _orders[0];
        }

        public ObservableCollection<Ordre> Orders
        {
            get { return _orders; }
        }

        public Ordre SelectedOrder
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
