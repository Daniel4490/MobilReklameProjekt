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
    class CreatePublicCustomerCommand : ICommand
    {
        private PublicCustomer _publicCustomer;
        private PublicCustomerCatalog _publicCustomerCatalog;
        private PublicCustomerItemViewModel _ivm;

        public CreatePublicCustomerCommand(PublicCustomer publicCustomer, PublicCustomerCatalog publicCustomerCatalog, PublicCustomerItemViewModel ivm)
        {
            _publicCustomer = publicCustomer;
            _publicCustomerCatalog = publicCustomerCatalog;
            _ivm = ivm;
        }

        public bool CanExecute(object parameter)
        {
            return _publicCustomer != null;
        }

        public void Execute(object parameter)
        {
            if (_publicCustomerCatalog.Customers.ContainsKey(_publicCustomer.ID) == false)
            {
                _publicCustomerCatalog.AddCustomer(_publicCustomer);
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
