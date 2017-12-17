using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MobilReklameApp.DomainClasses;
using MobilReklameApp.SubClasses;
using MobilReklameApp.ViewModels;

namespace MobilReklameApp.CommandClasses
{
    internal class CreateCompanyCustomerCommand : ICommand
    {
        private readonly CompanyCustomer _companyCustomer;
        private readonly CompanyCustomerCatalog _companyCustomerCatalog;
        private readonly CompanyCustomerItemViewModel _ivm;

        public CreateCompanyCustomerCommand(
            CompanyCustomer companyCustomer, 
            CompanyCustomerCatalog companyCustomerCatalog, 
            CompanyCustomerItemViewModel ivm)
        {
            _companyCustomer = companyCustomer;
            _companyCustomerCatalog = companyCustomerCatalog;
            _ivm = ivm;
        }

        public bool CanExecute(object parameter)
        {
            return _companyCustomer != null;
        }

        public void Execute(object parameter)
        {
            if (_companyCustomerCatalog.Customers.ContainsKey(_companyCustomer.ID) == false)
            {
                _companyCustomerCatalog.AddCustomer(_companyCustomer);
            }
            _ivm.Refresh();            
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}
