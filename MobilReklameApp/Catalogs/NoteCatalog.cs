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
    public class NoteCatalog
    {
        private static NoteCatalog _singletonInstance = new NoteCatalog();
        private Note _note;
        private readonly ObservableCollection<string> _notes;
       

        private NoteCatalog()
        {
            _note = new Note();
            _notes = new ObservableCollection<string>();
        }

        public void Add(string note)
        {
            _notes.Add(note);
        }

        public ObservableCollection<string> ListAll => _notes;


        public static NoteCatalog SingletonInstance
        {
            get
            {
                if (_singletonInstance != null) return _singletonInstance;
                _singletonInstance = new NoteCatalog();
                return _singletonInstance;
            }
        }
    }
}
