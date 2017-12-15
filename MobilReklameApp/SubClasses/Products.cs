using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.Annotations;

namespace MobilReklameApp.SubClasses
{
    public class Products : INotifyPropertyChanged
    {
        //Produkt___________________________________________________________________________________________________
        private string _mål;
        private string _antal;
        private string _lam;
        private string _medie;
        private string _syv51c;
        private string _aluSand3mm;
        private string _pvc10mm;
        private string _leveringsAntal;
        private string _dtpKr;
        private string _opTil10;
        private string _fragtKr;
        private string _prisKr;


        public string Mål
        {
            get { return _mål; }
            set
            {
                _mål = value;
                OnPropertyChanged();
            }
        }

        public string Antal
        {
            get { return _antal; }
            set
            {
                _antal = value;
                OnPropertyChanged();
            }
        }

        public string Lam
        {
            get { return _lam; }
            set
            {
                _lam = value;
                OnPropertyChanged();
            }
        }

        public string Medie
        {
            get { return _medie; }
            set
            {
                _medie = value;
                OnPropertyChanged();
            }
        }

        public string Syv51c
        {
            get { return _syv51c; }
            set
            {
                _syv51c = value;
                OnPropertyChanged();
            }
        }

        public string AluSand3mm
        {
            get { return _aluSand3mm; }
            set
            {
                _aluSand3mm = value;
                OnPropertyChanged();
            }
        }

        public string PVC10mm
        {
            get { return _pvc10mm; }
            set
            {
                _pvc10mm = value;
                OnPropertyChanged();
            }
        }

        public string LeveringsAntal
        {
            get { return _leveringsAntal; }
            set
            {
                _leveringsAntal = value;
                OnPropertyChanged();
            }
        }

        public string DTPKr
        {
            get { return _dtpKr; }
            set
            {
                _dtpKr = value;
                OnPropertyChanged();
            }
        }

        public string OpTil10Procent
        {
            get { return _opTil10; }
            set
            {
                _opTil10 = value;
                OnPropertyChanged();
            }
        }

        public string FragtKr
        {
            get { return _fragtKr; }
            set
            {
                _fragtKr = value;
                OnPropertyChanged();
            }
        }

        public string PrisKr
        {
            get { return _prisKr; }
            set
            {
                _prisKr = value;
                OnPropertyChanged();
            }
        }
        //Produkt___________________________________________________________________________________________________

        public Products(string mål, string antal, string lam, string medie, string syv51c,  string aluSand3Mm, string pvc10Mm,
            string leveringsAntal, string dtpKr, string opTil10, string fragtKr, string prisKr)
        {
            _mål = mål;
            _antal = antal;
            _lam = lam;
            _medie = medie;
            _syv51c = syv51c;
            _aluSand3mm = aluSand3Mm;
            _pvc10mm = pvc10Mm;
            _leveringsAntal = leveringsAntal;
            _dtpKr = dtpKr;
            _opTil10 = opTil10;
            _fragtKr = fragtKr;
            _prisKr = prisKr;
        }

        public Products()
        {
            throw new NotImplementedException();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
