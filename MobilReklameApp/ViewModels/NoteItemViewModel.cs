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
    internal class NoteItemViewModel : INotifyPropertyChanged
    {
        private readonly NoteCatalog _noteCatalog = NoteCatalog.SingletonInstance;
        private readonly Note _note;
        private readonly CreateNoteCommand _createNoteCommand;

        public NoteItemViewModel()
        {
            _note = new Note();
            _createNoteCommand = new CreateNoteCommand(_note, _noteCatalog);
        }

        public ObservableCollection<string> ListAll => _noteCatalog.ListAll;

        public string NoteText
        {
            get => _note.GetNote;
            set
            {
                _note.GetNote = value;
                OnPropertyChanged();
                _createNoteCommand.RaiseCanExecuteChanged();
            }
        }

        public ICommand CreateNoteCommand => _createNoteCommand;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
