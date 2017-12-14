using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
namespace MobilReklameApp.ViewModels
{
    class CreateOrderViewModel : INotifyPropertyChanged
    {
        //Produkt___________________________________________________________________________________________________
        private string _mål;
        private string _antal;
        private string _lam;
        private string _medie;
        //private string _751c;
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
        }

        public string Antal
        {
            get { return _antal; }
        }

        public string Lam
        {
            get { return _lam; }
        }

        public string Medie
        {
            get { return _medie; }
        }

        //public string 751c
        //{
        //  get {
        //        return _751c;
        //    } 
        //}

        public string AluSand3mm
        {
            get { return _aluSand3mm; }
        }

        public string PVC10mm
        {
            get { return _pvc10mm; }
        }

        public string LeveringsAntal
        {
            get { return _leveringsAntal; }
        }

        public string DTPKr
        {
            get { return _dtpKr; }
        }

        public string OpTil10Procent
        {
            get { return _opTil10; }
        }

        public string FragtKr
        {
            get { return _fragtKr; }
        }

        public string PrisKr
        {
            get { return _prisKr; }
        }
        //Produkt___________________________________________________________________________________________________
        public enum CustomerChosen
        {
            Privat,
            Erhverv,
            Offentlig
        }
        private CustomerChosen _selectedCustomer;

        public CustomerChosen EnummOrderStatus
        {
            get { return _selectedCustomer; }
            set
            {
                _selectedCustomer = value;
                SetTextEnabled(value);
                OnPropertyChanged();
            }
        }
        //This makes the combobox able to grey stuff out
        private void SetTextEnabled(CustomerChosen value)
        {
            if (value== CustomerChosen.Privat)
            {
                EANenabled = false;
                CVRenabled = false;
            }
            else if (value== CustomerChosen.Erhverv)
            {
                EANenabled = false;
                CVRenabled = true;
            }
            else if (value== CustomerChosen.Offentlig)
            {
                EANenabled = true;
                CVRenabled = false;
            }
            
            
        }

        
        public bool EANenabled
        {
            get { return _eaNenabled; }
            set
            {
                _eaNenabled = value;
                OnPropertyChanged();
            }
        }

        public bool CVRenabled
        {
            get { return _cvRenabled; }
            set
            {
                _cvRenabled = value;
                OnPropertyChanged();
            }
        }
        //This makes the combobox able to grey stuff out

        private ObservableCollection<CustomerChosen> _customerChosens;
        public CreateOrderViewModel(string mål, string antal, string lam, string medie, string aluSand3Mm, string pvc10Mm, string leveringsAntal, string dtpKr, string opTil10, string fragtKr, string prisKr)
        {
            _mål = mål;
            _antal = antal;
            _lam = lam;
            _medie = medie;
            _aluSand3mm = aluSand3Mm;
            _pvc10mm = pvc10Mm;
            _leveringsAntal = leveringsAntal;
            _dtpKr = dtpKr;
            _opTil10 = opTil10;
            _fragtKr = fragtKr;
            _prisKr = prisKr;
            //This is to make the ComboBox Work
            _customerChosens = new ObservableCollection<CustomerChosen>();

            _customerChosens.Add(CustomerChosen.Privat);
            _customerChosens.Add(CustomerChosen.Erhverv);
            _customerChosens.Add(CustomerChosen.Offentlig);
            //This is to make the ComboBox Work


            _eaNenabled = true;
            _cvRenabled = false;

        }

        //This is to make the ComboBox Work
        public ObservableCollection<CustomerChosen> CustomerChosens
        {
            get { return _customerChosens; }

        }
        //This is to make the ComboBox Work


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private CustomerChosen _customerState;
        private Dictionary<CustomerChosen, Dictionary<CustomerChosen, bool>> _allCustomerStates;
        private bool _eaNenabled;
        private bool _cvRenabled;

        public Dictionary<CustomerChosen, bool> CustomerStates
        {
            get
            {
                return _allCustomerStates[_customerState];
            }
        }















    }
}
