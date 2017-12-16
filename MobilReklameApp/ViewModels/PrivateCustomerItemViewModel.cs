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
   public class PrivateCustomerItemViewModel : INotifyPropertyChanged
   {
        private PrivateCustomerCatalog _privateCustomerCatalog = PrivateCustomerCatalog.SingletonInstance;
        private PrivateCustomer _privateCustomer;
        private CreatePrivateCustomerCommand _createPrivateCustomerCommand;

        public PrivateCustomerItemViewModel()
        {
            _privateCustomer = new PrivateCustomer();
            _createPrivateCustomerCommand = new CreatePrivateCustomerCommand(_privateCustomer, _privateCustomerCatalog, this);
        }

       public void Refresh()
       {
           OnPropertyChanged(nameof(ListAll));
       }

        public ObservableCollection<PrivateCustomer> ListAll
        {
            get
            { return _privateCustomerCatalog.ListAll; }
        }

        public string FirstName
        {
            get { return _privateCustomer.FirstName; }
            set
            {
                _privateCustomer.FirstName = value;
                OnPropertyChanged();
            }

        }

        public string LastName
        {
            get { return _privateCustomer.LastName; }
            set
            {
                _privateCustomer.LastName = value;
                OnPropertyChanged();
            }
        }

        public string Adress
        {
            get { return _privateCustomer.Address; }
            set
            {
                _privateCustomer.Address = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return _privateCustomer.Phone; }
            set
            {
                _privateCustomer.Phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _privateCustomer.Email; }
            set
            {
                _privateCustomer.Email = value;
                OnPropertyChanged();
            }
        }

        public ICommand CreatePrivateCustomerCommand
        {
            get { return _createPrivateCustomerCommand; }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
