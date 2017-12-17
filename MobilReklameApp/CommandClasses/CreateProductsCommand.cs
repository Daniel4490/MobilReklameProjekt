using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.CommandClasses
{
    internal class CreateProductsCommand : ICommand
    {
        private ICommand _commandImplementation;

        private Products _products;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}
