using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopingCartLib.Model
{
    public class Customer
    {
        private int _id;
        private string _name;
        private List<Order> _orders = new List<Order>();
        private static int _count = 0;
        private double _cost = 0;

        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public void AddOrder(Order order)
        {
            _count += 1;
            _orders.Add(order);
        }
        public List<Order> GetOrders()
        {
            return _orders;
        }
        public int OrderCount
        {
            get => _count;
        }
        public int Id
        {
            get => _id;
        }
        public string Name
        {
            get => _name;
        }

        public double FinalBill()
        {
            foreach(Order order in _orders)
            {
                _cost += order.OrderPrice();
            }
            return _cost;
        }
    }
}
