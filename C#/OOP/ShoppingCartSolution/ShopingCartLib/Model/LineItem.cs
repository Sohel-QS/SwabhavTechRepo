using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCartLib.Model
{
    public class LineItem
    {
        private int _id;
        private int _qty;
        Product _product;
        private double _productPrice; 

        public LineItem(int id, Product product, int qty)
        {
            _id = id;
            _product = product;
            _qty = qty;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }

        public Product LIProduct
        {
            get
            {
                return _product;
            }
        }

        public int Qty
        {
            get
            {
                return _qty;
            }
            set
            {
                _qty += value;
            }
        }

        public double GetLineItemPrice()
        {
            _productPrice = _product.GetFinalPrice();
            return _productPrice * _qty;    
        }
        public override bool Equals(object obj)
        {
            var item = obj as LineItem;
            if (item == null)
            {
                return false;
            }

            bool productCheck = this.LIProduct.Equals(item.LIProduct);

            return productCheck;
        }
    }
}
