using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobilReklameApp.BaseClasses;
using MobilReklameApp.DomainClasses;
using MobilReklameApp.SubClasses;

namespace MobilReklameApp.Catalogs
{
    public class ProductCatalog
    {

        private static ProductCatalog _singletonInstance = new ProductCatalog();
        private Products _product;
        private ObservableCollection<string> _products;


        private ProductCatalog()
        {
            _product = new Products();
            _products = new ObservableCollection<string>();
        }

        public void Add(string product)
        {
            _products.Add(product);
        }

        public ObservableCollection<string> ListAll
        {
            get { return _products; }
        }


        public static ProductCatalog SingletonInstance
        {
            get
            {
                return _singletonInstance;
            }
        }










    }
}
