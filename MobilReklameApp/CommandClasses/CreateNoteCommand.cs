using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.CommandClasses
{
    public class CreateNoteCommand : ICommand
    {
        private Note _note;
        private NoteCatalog _catalog;

        public CreateNoteCommand(Note note, NoteCatalog catalog)
        {
            _note = note;
            _catalog = catalog;
        }

        public bool CanExecute(object parameter)
        {
            return _note != null;
        }

        public void Execute(object parameter)
        {
            _catalog.Add(_note.GetNote);

            _note = new Note();
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler CanExecuteChanged;
    }
}
