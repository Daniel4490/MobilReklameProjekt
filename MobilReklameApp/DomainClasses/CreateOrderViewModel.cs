using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.DomainClasses
{
    class CreateOrderViewModel : INotifyPropertyChanged
    {


        public enum CustomerChosen
        {
            Privat,
            Erhverv,
            Offentlig
        }
        private CustomerChosen _selectedCustomer;

        public CustomerChosen EnummOrderStatus
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<CustomerChosen> _customerChosens;
        public CreateOrderViewModel()
        {
            _customerChosens = new ObservableCollection<CustomerChosen>();

            _customerChosens.Add(CustomerChosen.Privat);
            _customerChosens.Add(CustomerChosen.Erhverv);
            _customerChosens.Add(CustomerChosen.Offentlig);
        }


        public ObservableCollection<CustomerChosen> CustomerChosens
        {
            get { return _customerChosens; }

        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }




















    }
}
