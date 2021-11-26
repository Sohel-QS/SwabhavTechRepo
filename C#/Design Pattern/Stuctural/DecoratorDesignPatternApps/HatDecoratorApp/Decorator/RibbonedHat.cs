using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HatDecoratorApp.Model;

namespace HatDecoratorApp.Decorator
{
    class RibbonedHat:HatDecorator
    {
        private IHat _hat;
        private string _name = "Ribboned ";
        private double _price = 100;
        private HatDecorator _anotherDecorator;
        public RibbonedHat(IHat hat)
        {
            this._hat = hat;
        }
        public RibbonedHat(HatDecorator anotherDecorator)
        {
            this._anotherDecorator = anotherDecorator;
        }
        public override string GetDesciption()
        {
            var descrp = "Ribbon Price :" + this._price;
            if (_hat != null)
            {
                return _hat.GetDesciption() + base.GetName() + descrp;
            }
            return _anotherDecorator.GetDesciption() + base.GetName() + descrp;
        }

        public override string GetName()
        {
            if (_hat != null)
            {
                return this._name + _hat.GetName();
            }
            return this._name + _anotherDecorator.GetName();
        }

        public override double GetPrice()
        {
            if (_hat != null)
            {
                return this._price + _hat.GetPrice();
            }
            return this._price + _anotherDecorator.GetPrice();
        }
    }
}
