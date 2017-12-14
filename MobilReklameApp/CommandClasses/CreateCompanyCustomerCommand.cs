using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MobilReklameApp.DomainClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.CommandClasses
{
    class CreateCompanyCustomerCommand : ICommand
    {
        private CompanyCustomer _companyCustomer;
        private CompanyCustomerCatalog _companyCustomerCatalog;

        public CreateCompanyCustomerCommand(CompanyCustomer companyCustomer, CompanyCustomerCatalog companyCustomerCatalog)
        {
            _companyCustomer = companyCustomer;
            _companyCustomerCatalog = companyCustomerCatalog ;
        }

        public bool CanExecute(object parameter)
        {
            return _companyCustomer != null;
        }

        public void Execute(object parameter)
        {
            _companyCustomerCatalog.Add(_companyCustomer);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;

    }
}
