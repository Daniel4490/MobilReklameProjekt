﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.CommandClasses;
using MobilReklameApp.DomainClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.ViewModels
{
    class CompanyCustomerItemViewModel : INotifyPropertyChanged
    {
        private CompanyCustomer _companyCustomer;
        private CompanyCustomerCatalog _companyCustomerCatalog;
        private CreateCompanyCustomerCommand _createCompanyCustomerCommand;

        public CompanyCustomerItemViewModel()
        {
            _companyCustomer = new CompanyCustomer();
            _createCompanyCustomerCommand = new CreateCompanyCustomerCommand(_companyCustomer, _companyCustomerCatalog);
        }

        public List<CompanyCustomer> ListAll
        {
            get { return _companyCustomerCatalog.listAll; }
        }

        public string CompanyName
        {
            get { return _companyCustomer.CompanyName; }
            set
            {
                CompanyName = CompanyName = value;
                OnPropertyChanged();
            }
        }

        public string CVR
        {
            get { return _companyCustomer.CVR; }
            set
            {
                CVR = value;
                OnPropertyChanged();
            }
        }

        public string Att
        {
            get { return _companyCustomer.Att; }
            set
            {
                Att = value;
                OnPropertyChanged();
            }
        }

        public string Adress
        {
            get { return _companyCustomer.Address; }
            set
            {
                Adress = value;
                OnPropertyChanged();
            }
        }

        public string Phone
        {
            get { return _companyCustomer.Phone; }
            set
            {
                Phone = value;
                OnPropertyChanged();
            }
        }

        public string Email
        {
            get { return _companyCustomer.Email; }
            set
            {
                Email = value;
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