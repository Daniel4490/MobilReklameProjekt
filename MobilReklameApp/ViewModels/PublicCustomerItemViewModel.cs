using System;
using System.Collections.Generic;
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
    class PublicCustomerItemViewModel : INotifyPropertyChanged
    {
        private PublicCustomerCatalog _publicCustomerCatalog = PublicCustomerCatalog.SingletonInstance;
        private PublicCustomer _publicCustomer;
        private CreatePublicCustomerCommand _createPublicCustomerCommand;

        public PublicCustomerItemViewModel()
        {
            _publicCustomer = new PublicCustomer();
            _createPublicCustomerCommand = new CreatePublicCustomerCommand(_publicCustomer, _publicCustomerCatalog);
        }

        public List<PublicCustomer> ListAll
        {
            get { return _publicCustomerCatalog.listAll; }
        }

        public string PublicName
        {
            get { return _publicCustomer.PublicName; }
            set
            {
                PublicName = value;
                OnPropertyChanged();
            }
        }

        public string Adress
        {
            get { return _publicCustomer.Address; }
            set
            {
                Adress = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return _publicCustomer.Phone; }
            set
            {
                Phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _publicCustomer.Email; }
            set
            {
                Email = value;
                OnPropertyChanged();
            }
        }

        public ICommand CreatePublicCustomerCommand
        {
            get { return _createPublicCustomerCommand; }
        }




        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
