using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HatDecoratorApp.Model;

namespace HatDecoratorApp.Decorator
{
    abstract class HatDecorator : IHat
    {
        private string _name = "\nHat Decorator ";
        public virtual string GetName()
        {
            return _name;
        }
        public abstract double GetPrice();
        public abstract string GetDesciption();

    }
}
