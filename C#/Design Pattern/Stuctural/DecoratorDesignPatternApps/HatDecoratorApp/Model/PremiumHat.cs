﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HatDecoratorApp.Model
{
    class PremiumHat : IHat
    {
        private string _name = "Premium Hat";
        private double _price = 300;
        private float _discount;

        public PremiumHat(float discount = 0)
        {
            this._discount = discount;
        }

        public string GetDesciption()
        {
            return "Hat :" + GetName() + "\nPrice :" + GetPrice();
        }

        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return Math.Round(_price - (_price * _discount), 2);
        }
    }
}
