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

        private readonly string _orderDate = DateTime.Now.ToString("D");
        private readonly string _orderDeliveryDate = DateTime.Now.AddDays(365).ToString("D");
        private static int _orderNumber = 1000;
        private OrderStatus _orderStatus;

        public Order(OrderStatus orderStatus, string orderDescription, string produktType, string produktMateriale)
        {
            OrderDescriptions = orderDescription;
            ProductType = produktType;
            _orderStatus = orderStatus;
            ProductMaterial = produktMateriale;
            OrderNumber = _orderNumber++;
        }

        public string OrderDescriptions { get; set; }

        public string OrderDate => _orderDate;

        public string OrderDeliveryDate => _orderDeliveryDate;

        public int OrderNumber { get; set; }

        public OrderStatus EnummOrderStatus
        {
            get => _orderStatus;
            set { _orderStatus = value; OnPropertyChanged(); }
        }    

        public string ProductType { get; }

        public string ProductMaterial { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }



}
