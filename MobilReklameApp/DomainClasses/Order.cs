using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.DomainClasses
{
   public class Order : INotifyPropertyChanged
    {
        public enum OrderStatus
        {
            Afventer,
            Accepteret,
            Anulleret,
            Igangværende,
            Færdig,
            Leveret
        }

        
        
        private string _orderDescription;
        private string _orderDate = DateTime.Now.ToString("D"); //.ToLongDateString
        private string _orderDeliveryDate = DateTime.Now.AddDays(365).ToString("D"); //.ToLongDateString
        private static int _orderNumber = 1000;
        private string _productType;
        private OrderStatus _orderStatus;
        private string _productMaterial;

        

        

        public Order(OrderStatus orderStatus, string orderDescription, string produktType, string produktMateriale)
        {
            _orderDescription = orderDescription;
            _orderNumber++;
            _productType = produktType;
            _orderStatus = orderStatus;
            _productMaterial = produktMateriale;
            this.OrderNumber = _orderNumber;

        }



        
        public string OrderDescriptions
        {
            get { return _orderDescription; }
            set { _orderDescription = value; }
        }

        public string OrderDate
        {
            get { return _orderDate ; }

        }


        public string OrderDeliveryDate
        {
            get { return _orderDeliveryDate; }

        }

        public int OrderNumber { get; set; }

        public OrderStatus EnummOrderStatus
        {
            get { return _orderStatus; }
            set
            {
                _orderStatus = value;
                OnPropertyChanged();
            }
        }
        

        public string ProductType
        {
            get { return _productType; }
        }

        public string ProductMaterial
        {
            get { return _productMaterial; }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}
