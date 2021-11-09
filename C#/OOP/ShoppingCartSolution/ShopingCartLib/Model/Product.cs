using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCartLib.Model
{
    public class Product
    {

        private int _id;
        private string _name;
        private double _price;
        private float _discountPercent;
        private double _finalePrice;

        public Product(int id, string name, double price, float discount)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercent = discount;
        }
        public double GetFinalPrice()
        {
            return Math.Round(_price - (_price * _discountPercent), 2);
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }
        public float Discount
        {
            get
            {
                return _discountPercent;
            }
        }

        public override bool Equals(object obj)
        {
            var prdct = obj as Product;
            bool nameCheck = this._name == prdct.Name;
            bool priceCheck = this._price == prdct.Price;
            bool discountCheck = this._discountPercent == prdct.Discount;
            if (prdct == null)
            {
                return false;
            }
            return nameCheck && priceCheck && discountCheck;
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode() ^ _name.GetHashCode();
        }
    }
}
