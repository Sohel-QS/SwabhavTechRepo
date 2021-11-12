using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SrpSolutionApp.Model
{
    class Invoice
    {
        private int _id;
        private string _discription;
        private double _amount;
        private float _tax;
        private float _discount;

        public Invoice(int id, string discr, double amt, float tax, float discount)
        {
            _id = id;
            _discription = discr;
            _amount = amt;
            _tax = tax;
            _discount = discount;
        }

        public int Id { get => _id; }
        public string Discription { get => _discription; }
        public double Amount { get => _amount; }
        public float Tax { get => _tax; }
        public float Discount { get => _discount; }

        public double CalculateDiscount()
        {
            return Math.Round((_amount * _discount), 2);
        }
        public double CalculateTax()
        {
            return Math.Round((_amount * _tax), 2);
        }
        public double CalculateFinalAmount()
        {
            return Math.Round(((_amount + CalculateTax()) - CalculateDiscount()), 2);
        }
    }
}
