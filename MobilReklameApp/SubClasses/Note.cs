using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.SubClasses
{
    public class Note : INotifyPropertyChanged
    {
        private string _note;

        public string GetNote
        {
            get { return _note; }
            set
            {
                _note = value;
                OnPropertyChanged();
            }
        }
      

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
