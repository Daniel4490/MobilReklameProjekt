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
            //This is to make the ComboBox Work
            _customerChosens = new ObservableCollection<CustomerChosen>();

            _customerChosens.Add(CustomerChosen.Privat);
            _customerChosens.Add(CustomerChosen.Erhverv);
            _customerChosens.Add(CustomerChosen.Offentlig);
            //This is to make the ComboBox Work

            
            Dictionary<CustomerChosen, bool> offentligCustomerState = new Dictionary<CustomerChosen, bool>();
            offentligCustomerState.Add(CustomerChosen.Offentlig, true);
            offentligCustomerState.Add(CustomerChosen.Offentlig, false);

            _allCustomerStates.Add(CustomerChosen.Offentlig, offentligCustomerState);


        }

        //This is to make the ComboBox Work
        public ObservableCollection<CustomerChosen> CustomerChosens
        {
            get { return _customerChosens; }

        }
        //This is to make the ComboBox Work


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }






        private CustomerChosen _customerState;
        private Dictionary<CustomerChosen, Dictionary<CustomerChosen, bool>> _allCustomerStates;

        public Dictionary<CustomerChosen, bool> CustomerStates
        {
            get
            {
                return _allCustomerStates[_customerState];
            }
        }















    }
}
