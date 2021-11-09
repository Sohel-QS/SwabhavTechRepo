using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class LineItem
    {
        private string _productName;
        private double _price;
        private int _qty;

        public LineItem(string name, double price, int qty)
        {
            _productName = name;
            _price = price;
            _qty = qty;
        }

        public string ProductName
        {
            get => _productName;
        }
        public double Price
        {
            get => _price;
        }
        public int Quantity
        {
            get => _qty;
        }

        public double TotalPrice()
        {
            return _price * _qty;
        }
    }
}
