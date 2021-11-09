using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCartLib.Model
{
    public class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItem> items = new List<LineItem>();
        private double _orderPrice=0;
        private static int _count = 0;

        public Order(int id, DateTime date)
        {
            _id = id;
            _date = date;
        }

        public object AddLineItem(LineItem item)
        {
            _count += 1;
            foreach (LineItem line in items)
            {
                if (line.Equals(item))
                {
                    line.Qty = item.Qty;
                    return null;
                }
            }
            items.Add(item);
            return null;
        }
        public List<LineItem> GetLineItem()
        {
            return items;
        }
        public int Id
        {
            get
            {
                return _id;
            }
        }
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }
        public int TotalLineItems
        {
            get
            {
                return _count;
            }
        }

        public double OrderPrice()
        { 
            foreach(LineItem item in items)
            {
                _orderPrice += item.GetLineItemPrice();
            }
            return Math.Round(_orderPrice,2);
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            bool idCheck = this._id == order.Id;
            bool dateCheck = this._date.ToShortDateString() == order.Date.ToShortDateString();
            bool noOFLinesCheck = this.TotalLineItems == order.TotalLineItems;
            bool orderPriceCheck = this.OrderPrice() == order.OrderPrice();
            if (order == null)
            {
                return false;
            }
            return idCheck && dateCheck && noOFLinesCheck && orderPriceCheck;
        }

        public override int GetHashCode()
        {
            return _id.GetHashCode() ^ _date.ToShortDateString().GetHashCode();
        }
    }
}
