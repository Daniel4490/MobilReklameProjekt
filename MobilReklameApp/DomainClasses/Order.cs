using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.DomainClasses
{
   public class Order
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
        private DateTime _orderDate = DateTime.Now;
        private DateTime _orderDeliveryDate;
        private int _orderNumber = 1000;
        private string _productType;
        private ObservableCollection<OrderStatus> _orderStatus;
        private string _productMaterial;

        

        public Order(string orderDescription, DateTime orderDate, DateTime orderDeliveryDate, string produktType, string produktMateriale)
        {
            _orderDescription = orderDescription;
            _orderDate = orderDate;
            _orderDeliveryDate = orderDeliveryDate;
            _orderNumber++;
            _productType = produktType;
            _productMaterial = produktMateriale;

        }



        
        public string OrderDescriptions
        {
            get { return _orderDescription; }
            set { _orderDescription = value; }
        }

        public DateTime OrdreDato
        {
            get { return _orderDate; }

        }

        public DateTime OrderDeliveryDate
        {
            get { return _orderDeliveryDate; }

        }

        public int OrdreNummer
        {
            get { return _orderNumber; }
        }

        public ObservableCollection<OrderStatus> EnummOrderStatus
        {
            get { return _orderStatus; }
            set { _orderStatus = value; }
        }
        

        public string ProductType
        {
            get { return _productType; }
        }

        public string ProductMaterial
        {
            get { return _productMaterial; }
        }





    }



}
