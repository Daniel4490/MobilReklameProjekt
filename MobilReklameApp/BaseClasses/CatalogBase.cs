using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklameApp.BaseClasses
{
    public abstract class CatalogBase<TDomainClass>
    {
        private readonly Dictionary<string, TDomainClass> _items;

        protected CatalogBase()
        {
            _items = new Dictionary<string, TDomainClass>();
        }

        public List<TDomainClass> All => _items.Values.ToList();
    }
}
