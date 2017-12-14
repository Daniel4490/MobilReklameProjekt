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
    class CreatePrivateCustomerCommand : ICommand
    {
        private PrivateCustomer _privateCustomer;
        private PrivateCustomerCatalog _privateCustomerCatalog;

        public CreatePrivateCustomerCommand(PrivateCustomer privateCustomer, PrivateCustomerCatalog privateCustomerCatalog)
        {
            _privateCustomer = privateCustomer;
            _privateCustomerCatalog = privateCustomerCatalog;
        }

        public bool CanExecute(object parameter)
        {
            return _privateCustomer != null;
        }

        public void Execute(object parameter)
        {
            _privateCustomerCatalog.Add(_privateCustomer);

            _privateCustomer = new PrivateCustomer();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}
