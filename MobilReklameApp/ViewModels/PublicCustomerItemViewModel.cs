using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MobilReklameApp.CommandClasses;
using MobilReklameApp.DomainClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.ViewModels
{
    public class PublicCustomerItemViewModel : INotifyPropertyChanged
    {
        private readonly PublicCustomerCatalog _publicCustomerCatalog = PublicCustomerCatalog.SingletonInstance;
        private readonly PublicCustomer _publicCustomer;
        private readonly CreatePublicCustomerCommand _createPublicCustomerCommand;

        public PublicCustomerItemViewModel()
        {
            _publicCustomer = new PublicCustomer();
            _createPublicCustomerCommand = new CreatePublicCustomerCommand(
                _publicCustomer, 
                _publicCustomerCatalog, 
                this);
        }

        public void Refresh()
        {
            OnPropertyChanged(nameof(ListAll));
        }

        public ObservableCollection<PublicCustomer> ListAll => _publicCustomerCatalog.ListAll;

        public string PublicName
        {
            get => _publicCustomer.PublicName;
            set { _publicCustomer.PublicName = value; OnPropertyChanged(); }
        }

        public string Address
        {
            get => _publicCustomer.Address;
            set { _publicCustomer.Address = value; OnPropertyChanged(); }
        }

        public string EAN => EAN;

        public string Phone
        {
            get => _publicCustomer.Phone;
            set { _publicCustomer.Phone = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get => _publicCustomer.Email;
            set { _publicCustomer.Email = value; OnPropertyChanged(); }
        }

        public ICommand CreatePublicCustomerCommand => _createPublicCustomerCommand;


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
