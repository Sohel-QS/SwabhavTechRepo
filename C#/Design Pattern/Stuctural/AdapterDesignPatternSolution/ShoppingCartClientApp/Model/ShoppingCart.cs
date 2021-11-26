using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FancyItemsLiib.Model;

namespace ShoppingCartClientApp.Model
{
    class ShoppingCart
    {
        private List<Item> _items = new List<Item>();

        internal List<Item> Items 
        { 
            get => _items; 
        }

        public void Add(Item item)
        {
            _items.Add(item);
        }

        public void Remove(Item item)
        {
            _items.Remove(item);
        }

        public double TotalPrice()
        {
            var price = 0.0;
            foreach(var item in _items)
            {
                price += item.Price;
            }
            return price;
        }
    }
}
