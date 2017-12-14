using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.SubClasses
{
    public class Note
    {
        private string _note;

        public string GetNote
        {
            get { return _note; }
            set
            {
                _note = value;
            }
        }
    }
}
