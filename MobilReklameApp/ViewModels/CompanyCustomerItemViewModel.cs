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
    internal class CompanyCustomerItemViewModel : INotifyPropertyChanged
    {
        private readonly CompanyCustomer _companyCustomer;
        private readonly CompanyCustomerCatalog _companyCustomerCatalog = CompanyCustomerCatalog.SingletonInstance;
        private readonly CreateCompanyCustomerCommand _createCompanyCustomerCommand;


        public CompanyCustomerItemViewModel()
        {
            _companyCustomer = new CompanyCustomer();
            _companyCustomerCatalog = new CompanyCustomerCatalog();
            _createCompanyCustomerCommand = new CreateCompanyCustomerCommand(_companyCustomer, _companyCustomerCatalog, this);
        }

        public void Refresh()
        {
            OnPropertyChanged(nameof(ListAll));
        }

        public ObservableCollection<CompanyCustomer> ListAll => _companyCustomerCatalog.ListAll;

        public string CompanyName
        {
            get => _companyCustomer.CompanyName;
            set { _companyCustomer.CompanyName = value; OnPropertyChanged(); }

        }

        public string CVR
        {
            get => _companyCustomer.CVR;
            set { _companyCustomer.CVR = value; OnPropertyChanged(); }
        }

        public string Att => _companyCustomer.Att;

        public string Adress
        {
            get => _companyCustomer.Address;
            set { _companyCustomer.Address = value; OnPropertyChanged(); }
        }

        public string Phone
        {
            get => _companyCustomer.Phone;
            set { _companyCustomer.Phone = value; OnPropertyChanged(); }
        }

        public string Email
        {
            get => _companyCustomer.Email;
            set { _companyCustomer.Email = value; OnPropertyChanged(); }
        }

        public ICommand CreateCompanyCustomerCommand => _createCompanyCustomerCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
