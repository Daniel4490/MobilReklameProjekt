using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace MobilReklameApp.ViewModels
{
    public class CreateOrderViewModel : INotifyPropertyChanged
    {
        private bool _eANenabled;
        private bool _cVRenabled;

        public enum CustomerChosen
        {
            Privat,
            Erhverv,
            Offentlig
        }
        private CustomerChosen _selectedCustomer;

        public CustomerChosen EnummOrderStatus
        {
            get => _selectedCustomer;
            set
            {
                _selectedCustomer = value;
                SetTextEnabled(value);
                OnPropertyChanged();
            }
        }

        public void SetTextEnabled(CustomerChosen value)
        {
            if (value== CustomerChosen.Privat)
            {
                EANenabled = false;
                CVRenabled = false;
            }
            else if (value== CustomerChosen.Erhverv)
            {
                EANenabled = false;
                CVRenabled = true;
            }
            else if (value== CustomerChosen.Offentlig)
            {
                EANenabled = true;
                CVRenabled = false;
            } 
        }
     
        public bool EANenabled
        {
            get => _eANenabled;
            set { _eANenabled = value; OnPropertyChanged(); }

        }

        public bool CVRenabled
        {
            get => _cVRenabled;
            set { _cVRenabled = value; OnPropertyChanged(); }
        }

        public ObservableCollection<CustomerChosen> _customerChosens;
        public CreateOrderViewModel()
        {
            _customerChosens = new ObservableCollection<CustomerChosen>
            {
                CustomerChosen.Privat,
                CustomerChosen.Erhverv,
                CustomerChosen.Offentlig
            };
        }

        public ObservableCollection<CustomerChosen> CustomerChosens => _customerChosens;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
