using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.DomainClasses
{
    class Ordre
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
        private int _orderNumber;
        private string _productType;
        public OrderStatus _orderStatus;
        private string _productMaterial;

        

        public Ordre(OrderStatus orderStatus, string orderDescription, DateTime orderDate, DateTime orderDeliveryDate, int orderNumber,
            string produktType, string produktMateriale)
        {
            _orderDescription = orderDescription;
            _orderDate = orderDate;
            _orderDeliveryDate = orderDeliveryDate;
            _orderNumber = orderNumber;
            _productType = produktType;
            _orderStatus = orderStatus;
            _productMaterial = produktMateriale;

        }



        
        public string OrderDescriptions
        {
            get { return _orderDescription; }

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

        public OrderStatus EnummOrderStatus
        {
            get { return _orderStatus; }
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
