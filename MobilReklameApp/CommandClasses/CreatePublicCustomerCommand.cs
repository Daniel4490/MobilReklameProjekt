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
    class CreatePublicCustomerCommand : ICommand
    {
        private PublicCustomer _publicCustomer;
        private PublicCustomerCatalog _publicCustomerCatalog;

        public CreatePublicCustomerCommand(PublicCustomer publicCustomer, PublicCustomerCatalog publicCustomerCatalog)
        {
            _publicCustomer = publicCustomer;
            _publicCustomerCatalog = publicCustomerCatalog;
        }

        public bool CanExecute(object parameter)
        {
            return _publicCustomer != null;
        }

        public void Execute(object parameter)
        {
            _publicCustomerCatalog.Add(_publicCustomer);
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}
