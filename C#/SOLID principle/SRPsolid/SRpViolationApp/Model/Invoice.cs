using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRpViolationApp.Model
{
    class Invoice
    {
        private int _id;
        private string _discription;
        private double _amount;
        private float _tax;
        private float _discount;

        public Invoice(int id,string discr, double amt, float tax,float discount)
        {
            _id = id;
            _discription = discr;
            _amount = amt;
            _tax = tax;
            _discount = discount;
        }

        public double CalculateDiscount()
        {
            return Math.Round((_amount * _discount),2);
        }
        public double CalculateTax()
        {
            return Math.Round((_amount * _tax),2);
        }
        public double CalculateFinalAmount()
        {
            return Math.Round(((_amount + CalculateTax())- CalculateDiscount()),2);
        }
        public void Print()
        {
            Console.WriteLine("ID :{0}\nDiscription :{1}\nAmount :{2}\nTax :{3}\nDiscount :{4}\nDiscount Amount:{5}\nTax Amount :{6}\nFinal Amount :{7}",
                _id,
                _discription,
                _amount,
                _tax * 100,
                _discount * 100,
                CalculateDiscount(),
                CalculateTax(),
                CalculateFinalAmount());
        }
    }
}
