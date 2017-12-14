using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobilReklameApp.SubClasses
{
    class NoteItemViewModel : INotifyPropertyChanged
    {
        private NoteCatalog _noteCatalog = NoteCatalog.SingletonInstance;
        private Note _note;
        private CreateNoteCommand _createNoteCommand;

        public NoteItemViewModel()
        {
            _note = new Note();
            _createNoteCommand = new CreateNoteCommand(_note, _noteCatalog);
        }

        public ObservableCollection<string> ListAll
        {
            get { return _noteCatalog.ListAll; }
        }

        public string NoteText
        {
            get { return _note.GetNote; }
            set
            {
                _note.GetNote = value;
                OnPropertyChanged();
                _createNoteCommand.RaiseCanExecuteChanged();
            }
        }

        public ICommand CreateNoteCommand
        {
            get { return _createNoteCommand; }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
