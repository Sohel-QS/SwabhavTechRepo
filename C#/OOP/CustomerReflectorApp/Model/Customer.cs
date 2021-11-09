using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerReflectorApp.Model
{
    class Customer
    {
        private int _custId = 1000;
        private static int _nextCustId;
        private string _custName;
        private double _purchaseAmount;
        private float _discount;

        static Customer()
        {
            _nextCustId = 0;
        }
        
        public Customer(string name, double purchase) : this(name, purchase, 0.02f)
        {
        }

        public Customer(string name, double purchase, float discount)
        {
            _custId += _nextCustId;
            _custName = name;
            _purchaseAmount = purchase;
            _discount = discount;
            _nextCustId += 1;
        }

        public string CustomerId
        {
            get {
                return "C" + Convert.ToString(_custId);
            }
        }

        public string CustomerName
        {
            get
            {
                return _custName;
            }
        }

        public double PurchaseAmount
        {
            get
            {
                return _purchaseAmount;
            }
        }
        
        public float Discount
        {
            get
            {
                return _discount;
            }
        }

        public double GetTotalBill()
        {
            _purchaseAmount -= Math.Round((_purchaseAmount * _discount), 2);
            return _purchaseAmount;
        }
    }
}
