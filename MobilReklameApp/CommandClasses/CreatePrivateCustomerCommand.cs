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
   public class CreatePrivateCustomerCommand : ICommand
    {
        private readonly PrivateCustomer _privateCustomer;
        private readonly PrivateCustomerCatalog _privateCustomerCatalog;
        private readonly PrivateCustomerItemViewModel _ivm;

        public CreatePrivateCustomerCommand(PrivateCustomer privateCustomer, PrivateCustomerCatalog privateCustomerCatalog, PrivateCustomerItemViewModel ivm)
        {
            _privateCustomer = privateCustomer;
            _privateCustomerCatalog = privateCustomerCatalog;
            _ivm = ivm;
        }

        public bool CanExecute(object parameter)
        {
            return _privateCustomer != null;
        }

        public void Execute(object parameter)
        {
            if (_privateCustomerCatalog.Customers.ContainsKey(_privateCustomer.ID) == false)
            {
                _privateCustomerCatalog.AddCustomer(_privateCustomer);
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
