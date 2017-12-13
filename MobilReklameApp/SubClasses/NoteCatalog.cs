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
    public class NoteCatalog : INotifyPropertyChanged
    {
        private Note _note;
        private ObservableCollection<string> _notes;
        private CreateNoteCommand _createNoteCommand;

        public NoteCatalog()
        {
            _note = new Note();
            _createNoteCommand = new CreateNoteCommand(_note,this);

            _notes = new ObservableCollection<string>();
        }

        public ObservableCollection<string> ListAll
        {
            get { return _notes; }
        }

        public void AddNote()
        {
            _notes.Add(_note.GetNote);
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
