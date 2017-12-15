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
    public class CreateOrderViewModel : INotifyPropertyChanged
    {

        public CreateOrderViewModel()
        {
            
        }
       
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
        public void SetTextEnabled(CustomerChosen value)
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
