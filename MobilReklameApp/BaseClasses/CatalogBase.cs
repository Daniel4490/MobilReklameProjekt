using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.BaseClasses
{
    public abstract class CatalogBase<TDomainClass>
        where TDomainClass : DomainClassBase
    {
        private Dictionary<int, TDomainClass> _items;

        protected CatalogBase()
        {
            _items = new Dictionary<int, TDomainClass>();
        }

        public List<TDomainClass> All
        {
            get { return _items.Values.ToList(); }
        }

        public void Add(TDomainClass obj)
        {
            _items.Add(obj.Id, obj);
        }
    }
}
